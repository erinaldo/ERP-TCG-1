Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Microsoft.Office.Interop
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.IO
Imports Infragistics.Documents.Excel
Imports System.Text
Imports System.Runtime.InteropServices

Public Class frm_MovimientoPeaje
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Private mstrUsuCovisol As String = "induamericasl"
    Private mstrPassCovisol As String = "20479729141"

    Private oeMovimientoDocumento As New e_MovimientoDocumento
    Private ListaDocumentos As New List(Of e_MovimientoDocumento)

    Private olCovisol As CovisolR.GetDatosService

    Dim grid As UltraGrid

    Private oeMovimientoPeaje As New e_MovimientoPeaje
    Private oeMovimientoPeajeA As New e_MovimientoPeaje
    Private leMovimientoPeaje As New List(Of e_MovimientoPeaje)
    Private leMovimientoPeajeCovisol As New List(Of e_MovimientoPeaje)
    Private leMovimientoPeajeSinA As New List(Of e_MovimientoPeaje)
    Private olMovimientoPeaje As New l_MovimientoPeaje

    Private leFacWsCovison As New List(Of e_MovimientoPeaje)

    Dim oeGastoOperacion As New e_GastoOperacion
    Dim olGastoOperacion As New l_GastoOperacion
    Dim leGastoOperacion As New List(Of e_GastoOperacion)

    Dim oeGrupo As New e_Grupo
    Dim olGrupo As New l_Grupo
    Dim leGrupo As New List(Of e_Grupo)

    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim olCuentaCorriente As New l_CuentaCorriente
    Dim loCuentaCorriente As New List(Of e_CuentaCorriente)

    Private olMovimientoDocumento As New l_MovimientoDocumento

    Private oeMovimientoAnalisis As New e_MovimientoAnalisis
    
    Private leMovimientoAnalisisAGrega As List(Of e_MovimientoAnalisis)
    Private leProveedor As New List(Of e_Proveedor)
    Private leTipoCompra As New List(Of e_TablaContableDet)
    Private oeCta As New e_CuentaContable
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private _IGV As Double
    Private olImp As New l_Impuesto, oeIGV As New e_Impuesto
    Private oeItemGasto As e_ItemGasto, leItemGasto As New List(Of e_ItemGasto)
    Private _ComboTipoCompra As String = ""
    Private _ItemCta As String = ""
    Private Shared instancia As frm_MovimientoPeaje = Nothing
    Private Shared Operacion As String
    Private Ejercicio As Integer = 0
    Private oeObligacionfin As New e_ObligacionFin, olObligacionFin As New l_ObligacionFinanciera, leObligacionFin As New List(Of e_ObligacionFin)
    Private oeTipoDoc As New e_TipoDocumento, leTipoDoc As New List(Of e_TipoDocumento), olTipoDoc As New l_TipoDocumento
    Public olAsiento As New l_Asiento
    Public TipoOrigen As String = "C"
    Public IndOrigen As Integer
    Dim oeCuota As New e_CuotaDocumentoVehiculo, olCuota As New l_CuotaDocumentoVehiculo, leCuota As New List(Of e_CuotaDocumentoVehiculo)
    Dim olCombo As New l_Combo
    Private oeCuotaMovimiento As New e_CuotaDocVeh_Movimiento, leCuotaMovimiento As New List(Of e_CuotaDocVeh_Movimiento)
    Dim oeOperacionDetalle As New e_OperacionDetalle
    Dim olOperacion As New l_Operacion
    Dim olProveedor As New l_Proveedor

    Dim loConcepto As New l_Concepto
    Dim oeConcepto As New e_Concepto
    Dim ListaConcepto As New List(Of e_Concepto)


    Dim leVehiculo As New List(Of e_Vehiculo)

    Dim IdCen As String = ""


#End Region

#Region "Definición del Formulario base"

    ''' <summary>
    ''' Para modulo de documentos a rendir
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal oeDoc As e_MovimientoDocumento, ByVal oeIG As e_ItemGasto, ByVal leMovAGrega As List(Of e_MovimientoAnalisis))

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        oeMovimientoDocumento = oeDoc
        oeItemGasto = oeIG
        leMovimientoAnalisisAGrega = leMovAGrega
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_MovimientoPeaje()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Select Case tcComprobanteCompra.SelectedTab.Index
                Case 0
                    ListarMovimientoPeaje()
                Case 1
                    
                Case 2
                    ListarAsociarViaje()
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        
    End Sub

    Public Overrides Sub Editar()
        
    End Sub

    Public Overrides Sub Guardar()
        
    End Sub

    Public Overrides Sub Cancelar()
        
    End Sub

    Public Overrides Sub Eliminar()
        
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        ColorMontoIncorrecto.Color = Color.Orange
        ColorPendiente.Color = Color.LightGreen
        ColorHabilitada.Color = Color.LemonChiffon
        ColorLiquidada.Color = Color.NavajoWhite
        ColorNoReembolsado.Color = Color.Orange
        ColorReembolsado.Color = Color.RosyBrown
        dtpDesde.Value = Date.Today.AddDays(-30)
        dtpHasta.Value = ObtenerFechaServidor()
        dtpDesdeCovisol.Value = Date.Today.AddDays(-15)
        dtpHastaCovisol.Value = ObtenerFechaServidor()
        rfDesde.Value = Date.Today.AddDays(-30)
        rfHasta.Value = ObtenerFechaServidor()
        oeIGV = olImp.IGV(Date.Now)
        _IGV = oeIGV.Porcentaje
        _ItemCta = ""
        grupoCabeceraAsiento.Enabled = True
        grupoDetalle.Enabled = True
        LlenarCombos()
        cboTipoDocumento.SelectedIndex = -1
        cbeCtaCte.Value = Nothing
        cboMoneda.SelectedIndex = -1
        cboTipoCompra.SelectedIndex = -1
        cbeCtaCte.Text = String.Empty
        cboCuenta.SelectedIndex = -1
        cboGastonFuncion.SelectedIndex = -1
        cboGastonFuncion.Enabled = False
        cboItemGasto.SelectedIndex = -1
        cboItemGasto.Enabled = False

        LimpiagridListaMovimientoPeaje()
        'LimpiaGrid(gridListaMovimientoPeaje, UltraDataSource1)
        LimpiagridListaMovimientoPeajeImportar()
        'LimpiaGrid(griMovimientoPeajeImportar, odMovimientoPeaje)

        HabilitarAsiento()
        HabilitarBotones(8)
        HabilitarBotones(4)

    End Sub

    Private Sub IniciarAsiento()
        dtpFechaEjercicio.Value = Now.Date
        cboMes.SelectedIndex = -1
        cboTipoDocumento.SelectedIndex = cboTipoDocumento.FindStringExact("FACTURA")
        cbeCtaCte.Value = Nothing
        cbeCtaCte.Text = String.Empty
        cboMoneda.SelectedIndex = cboMoneda.FindStringExact("SOLES")
        cboTipoCompra.SelectedIndex = cboTipoCompra.FindStringExact("GASTOS POR SERVICIOS PRESTADOS POR TERCEROS")

        cboTipoCompra_Validated(Nothing, New EventArgs)
        cboCuenta.SelectedIndex = cboCuenta.FindStringExact("PEAJES Y ESTACIONAMIENTO")
        cboCuenta_SelectionChangeCommitted(Nothing, New EventArgs)
        cboGastonFuncion.SelectedIndex = cboGastonFuncion.FindStringExact("COSTO DE VENTA")
        cboItemGasto.SelectedIndex = cboItemGasto.FindStringExact("PEAJES Y ESTACIONAMIENTO")
    End Sub

    Private Sub HabilitarBotones(i As Integer)
        If i = 1 Then
            btnBuscar.Enabled = False
            btnValidar.Enabled = True
            btnGuardar.Enabled = False
            BloquearAsiento()
            tcComprobanteDetalle.Tabs(1).Enabled = False
        End If
        If i = 2 Then
            btnBuscar.Enabled = False
            btnValidar.Enabled = False
            btnGuardar.Enabled = True
        End If
        If i = 3 Then
            btnBuscar.Enabled = True
            btnValidar.Enabled = False
            btnGuardar.Enabled = False
            griMovimientoPeajeImportar.DataSource = New List(Of e_MovimientoPeaje) : griMovimientoPeajeImportar.DataBind()
        End If
        If i = 4 Then
            btnBuscar.Enabled = True
            btnValidar.Enabled = False
            btnGuardar.Enabled = False
            HabilitarAsiento()
            IniciarAsiento()
            griMovimientoPeajeImportar.DataSource = New List(Of e_MovimientoPeaje) : griMovimientoPeajeImportar.DataBind()
            MostrarTabs(0, tcComprobanteDetalle, 1)
        End If
        If i = 5 Then
            btnBuscarCovisol.Enabled = False
            btnValidarCovisol.Enabled = True
            btnGuardarCovisol.Enabled = False
            BloquearAsiento()
            'MostrarTabs(1, tcComprobanteDetalle)
            tcComprobanteDetalle.Tabs(0).Enabled = False
        End If
        If i = 6 Then
            btnBuscarCovisol.Enabled = False
            btnValidarCovisol.Enabled = False
            btnGuardarCovisol.Enabled = True
        End If
        If i = 7 Then
            btnBuscarCovisol.Enabled = True
            btnValidarCovisol.Enabled = False
            btnGuardarCovisol.Enabled = False
            griMovPeajeCovisol.DataSource = New List(Of e_MovimientoPeaje) : griMovPeajeCovisol.DataBind()
        End If
        If i = 8 Then
            btnBuscarCovisol.Enabled = True
            btnValidarCovisol.Enabled = False
            btnGuardarCovisol.Enabled = False
            HabilitarAsiento()
            IniciarAsiento()
            griMovPeajeCovisol.DataSource = New List(Of e_MovimientoPeaje) : griMovPeajeCovisol.DataBind()
            MostrarTabs(1, tcComprobanteDetalle, 0)
        End If
    End Sub

    Private Sub HabilitarAsiento()
        grupoCabeceraAsiento.Enabled = True
        grupoDetalle.Enabled = True
    End Sub

    Private Sub BloquearAsiento()
        grupoCabeceraAsiento.Enabled = True
        grupoDetalle.Enabled = True
    End Sub

    Public Sub LimpiagridListaMovimientoPeaje()
        Try
            Dim lista As New List(Of e_MovimientoPeaje)
            gridListaMovimientoPeaje.DataSource = lista
            FormatoColumna(gridListaMovimientoPeaje, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")
            gridListaMovimientoPeaje.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LimpiagridListaMovimientoPeajeImportar()
        Try
            Dim lista As New List(Of e_MovimientoPeaje)
            griMovimientoPeajeImportar.DataSource = lista
            FormatoColumna(griMovimientoPeajeImportar, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")
            griMovimientoPeajeImportar.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarMovimientoPeaje()
        Try
            oeMovimientoPeajeA = New e_MovimientoPeaje
            oeMovimientoPeajeA.Activo = True
            oeMovimientoPeajeA.TipoOperacion = "L"
            oeMovimientoPeajeA.fechaInicio = dtpDesde.Value
            oeMovimientoPeajeA.fechaFin = dtpHasta.Value
            leMovimientoPeajeSinA = olMovimientoPeaje.Listar(oeMovimientoPeajeA)
            gridListaMovimientoPeaje.DataSource = leMovimientoPeajeSinA
            gridListaMovimientoPeaje.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarAsociarViaje()
        Try
            'Cursor.Current = Cursors.WaitCursor
            'Me.Cursor = Cursors.WaitCursor
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            ugb_Espera3.Visible = True

            ValidarFechaDesde_Hasta(rfDesde, rfHasta)
            ValidarCombo(cboTractoLista, "Vehículo")
            oeMovimientoPeajeA = New e_MovimientoPeaje
            oeMovimientoPeajeA.Activo = True
            oeMovimientoPeajeA.TipoOperacion = "1"
            oeMovimientoPeajeA.fechaInicio = rfDesde.Value
            oeMovimientoPeajeA.fechaFin = rfHasta.Value
            oeMovimientoPeajeA.IdVehiculo = cboTractoLista.Value

            grid_ListaAsociaMP.DataSource = olMovimientoPeaje.ListaAsociacionMovimientoPeaje(oeMovimientoPeajeA)

            If grid_ListaAsociaMP.Rows.Count > 0 Then
                grid_ListaAsociaMP.Focus()
                grid_ListaAsociaMP.Rows.Item(0).Selected = True
            End If
            If grid_ListaAsociaMP.Rows.Count < 11 Then
                grid_ListaAsociaMP.Rows.ExpandAll(True)
            End If

            Dim band As UltraGridBand = Me.grid_ListaAsociaMP.DisplayLayout.Bands(1)
            Dim fila As UltraGridRow
            For Each fila In band.GetRowEnumerator(GridRowType.DataRow)
                If fila.Cells("Estado").Value = gNombreEstadoPendiente Then
                    fila.CellAppearance.BackColor = Me.ColorPendiente.Color
                End If
                If fila.Cells("Estado").Value = gNombreEstadoHabilitada Then
                    fila.CellAppearance.BackColor = Me.ColorHabilitada.Color
                End If
                If fila.Cells("Estado").Value = gNombreEstadoLiquidada Then
                    fila.CellAppearance.BackColor = Me.ColorLiquidada.Color
                End If
                If fila.Cells("Estado").Value = gNombreEstadoReembolsado Then
                    fila.CellAppearance.BackColor = Me.ColorReembolsado.Color
                End If
            Next fila
        Catch ex As Exception
            ugb_Espera3.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera3.Visible = False
            'Me.Cursor = Cursors.Default
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
        grid_ListaAsociaMP.Focus()
    End Sub

    Public Sub ConsultarTanqueosNoAsociados()
        Try
            oeMovimientoPeajeA = New e_MovimientoPeaje
            oeMovimientoPeajeA.Activo = True
            oeMovimientoPeajeA.TipoOperacion = 4
            oeMovimientoPeajeA.fechaInicio = rfDesde.Value
            oeMovimientoPeajeA.fechaFin = rfHasta.Value
            oeMovimientoPeajeA.IdVehiculo = cboTractoLista.Value
            leMovimientoPeajeSinA = olMovimientoPeaje.Listar(oeMovimientoPeajeA)
            grid_ListaMPnoAsoc.DataSource = leMovimientoPeajeSinA
            gbTanqueosNoAsociados.Expanded = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' traigo los documentos asociados, lista de objetos de la clase e_MovimientoDocumento
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LlenarCombos()
        Try
            ComboPeriodo()
            ComboTipoCompra()
            ComboMoneda()
            ComboTipoDocumentoOperacion()
            ComboProveedor()
            Vehiculo()
            ListarCuentaCorriente()
            CargarGrupo()
            CargarEmpresasPrePago()
            'LlenaComboProveedor()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboMoneda()
        Try
            If cboMoneda.Items.Count = 0 Then
                Dim oeMoneda As New e_Moneda
                Dim olMoneda As New l_Moneda
                Dim leMoneda As New List(Of e_Moneda)
                oeMoneda.Activo = True
                leMoneda.AddRange(olMoneda.Listar(oeMoneda))
                With cboMoneda
                    .DisplayMember = "Nombre"
                    .ValueMember = "Id"
                    .DataSource = leMoneda
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            Dim lePeriodo As New List(Of e_Periodo)
            lePeriodo.AddRange(ObtenerPeriodoActivo(dtpFechaEjercicio.Value.Year.ToString))

            With cboMes
                .DisplayMember = "NomMes"
                .ValueMember = "Id"
                .DataSource = lePeriodo
                If .Items.Count > 0 Then
                    .SelectedIndex = -1
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboTipoDocumentoOperacion()
        Try
            If cboTipoDocumento.Items.Count = 0 Then
                oeTipoDoc = New e_TipoDocumento
                oeTipoDoc.Activo = True : oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
                leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
                With cboTipoDocumento
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leTipoDoc
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboProveedor()
        Try
            If cbeCtaCte.Rows.Count = 0 Then
                Dim oeProveedor As New e_Proveedor
                leProveedor = New List(Of e_Proveedor)
                Dim olProveedor As New l_Proveedor
                leProveedor.AddRange(olProveedor.Listar(oeProveedor))
                With cbeCtaCte
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leProveedor
                End With
                InicializarComboPro()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboTipoCompra()
        Try
            If Ejercicio <> dtpFechaEjercicio.Value.Year Then
                Dim oeTablaContableDet As New e_TablaContableDet
                Dim olTablaContableDet As New l_TablaContableDet
                oeTablaContableDet.TipoOperacion = "N"
                oeTablaContableDet.Nombre = "TIPO DE COMPRA" 'Tipo de COMPRA
                oeTablaContableDet.Valor1 = dtpFechaEjercicio.Value.Year
                oeTablaContableDet.Activo = True
                leTipoCompra.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
                With cboTipoCompra
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leTipoCompra
                End With
                Ejercicio = dtpFechaEjercicio.Value.Year
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarComboPro()
        Try
            Me.cbeCtaCte.ValueMember = "Id"
            Me.cbeCtaCte.DisplayMember = "Nombre"
            With cbeCtaCte.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Codigo").Hidden = True
                .Columns("NroDocumento").Hidden = True
                .Columns("TipoPersonaEmpresa").Hidden = True
                .Columns("IdPersona").Hidden = True
                .Columns("IdEmpresa").Hidden = True
                .Columns("FechaActividad").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("Seleccion").Hidden = True
                .Columns("Email").Hidden = True
                .Columns("Contacto").Hidden = True
                .Columns("Nombre").Header.Caption = "Proveedor"
                .Columns("NroDocumento").Header.Caption = "RUC/DNI"
                .Columns("NroDocumento").Header.VisiblePosition = 0
                .Columns("Nombre").Header.VisiblePosition = 1
                .Columns("NroDocumento").Width = 120
                .Columns("Nombre").Width = 450
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaCuenta(ByVal lsCta As String)
        Try
            Dim oeCta As New e_CuentaContable
            Dim leCta As New List(Of e_CuentaContable)
            Dim olCta As New l_CuentaContable
            oeCta.TipoOperacion = "L"
            oeCta.Cuenta = oeMovimientoDocumento.Compra.TipoCompra.Texto1
            oeCta.Activo = True
            oeCta.Movimiento = 1
            oeCta.Ejercicio = dtpFechaEjercicio.Value.Year
            leCta.AddRange(olCta.Listar(oeCta))
            ''--------------------- para llenar combo en grilla    
            'With gridDetalleAsientoAnalisis.DisplayLayout
            '    If .Bands(0).Columns.Exists("IdCuentaContable") Then
            '        .ValueLists.Clear()
            '        .ValueLists.Add("IdCuentaContable")
            '    End If
            'End With
            'With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdCuentaContable").ValueListItems
            '    .Clear()
            '    For Each oeTD As e_CuentaContable In leCta
            '        .Add(oeTD.Id, oeTD.Nombre)
            '    Next
            'End With
            'CrearComboGrid3("IdCuentaContable", "Nombre", gridDetalleAsientoAnalisis, True)
            ''------------------------------------------
            With cboCuenta
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leCta
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaCombosSegunCta()
        Try
            If Not oeCta Is Nothing Then
                ItemGasto(oeCta.Id)
                If oeCta.GastoFuncion = 1 Then
                    cboGastonFuncion.Enabled = True
                    GastoFuncion()
                Else
                    cboGastonFuncion.Enabled = False
                    cboGastonFuncion.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerDocumentoServicios() As Boolean
        'Try
        '    If Operacion = "Nuevo" And opcTerceros.CheckedIndex <> 2 Then
        '        oeOperacionDetalle = New e_OperacionDetalle
        '        With oeOperacionDetalle
        '            .IdOperacion = "ENVIADA"
        '            .FechaDesde = ""
        '            .FechaHasta = ""
        '            .IdDemanda = txtNroSerie.Text
        '            .Cliente = txtNroDocumento.Text
        '            .Proveedor = cbeCtaCte.Value
        '            Select Case opcTerceros.CheckedIndex
        '                Case 0
        '                    .TipoOperacion = "7"
        '                Case 1
        '                    .TipoOperacion = "T"
        '                    .IdOperacion = "ENVIADO"
        '                Case 2
        '                    .Proveedor = ""
        '                    LimpiaGrid(griLista, ogdOperacionDetalle)
        '            End Select
        '        End With
        '        If oeOperacionDetalle.Proveedor <> "" Then
        '            griLista.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
        '            CalcularTotales(griLista, "FleteUnitario")
        '        End If
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Function

#Region "Combos"



    Private Sub GastoFuncion()
        If cboGastonFuncion.Items.Count = 0 Then
            Dim oeTablaContableDet As New e_TablaContableDet
            Dim olTablaContableDet As New l_TablaContableDet
            Dim leTabla As New List(Of e_TablaContableDet)
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "GASTO FUNCION" 'Tipo de medio de pago
            oeTablaContableDet.Activo = True
            oeTablaContableDet.Logico2 = 1
            leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            ''--------------------- para llenar combo en grilla    
            'gridDetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdGastoFuncion")
            'With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdGastoFuncion").ValueListItems
            '    .Clear()
            '    For Each oeTD As e_TablaContableDet In leTabla
            '        .Add(oeTD.Id, oeTD.Nombre)
            '    Next
            'End With
            'CrearComboGrid3("IdGastoFuncion", "Nombre", gridDetalleAsientoAnalisis, True)
            ''------------------------------------------
            With cboGastonFuncion
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leTabla
            End With
        End If

    End Sub

    Private Sub ItemGasto(ByVal idCuenta As String)
        If _ItemCta <> idCuenta Then
            Dim oeItemGasto As New e_ItemGasto
            Dim olItemGasto As New l_ItemGasto
            Dim leIG As New List(Of e_ItemGasto)
            oeItemGasto.Activo = True
            oeItemGasto.IdCuentaContable = idCuenta
            oeItemGasto.Ejercicio = dtpFechaEjercicio.Value.Year
            leIG.AddRange(olItemGasto.Listar(oeItemGasto))
            With cboItemGasto
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leIG
            End With
            If cboItemGasto.Items.Count = 0 Then
                cboItemGasto.Enabled = False
            Else
                cboItemGasto.Enabled = True
            End If
            _ItemCta = idCuenta
        End If
    End Sub

    Private Sub Vehiculo()
        Dim oeVehiculo As New e_Vehiculo
        Dim olVehiculo As New l_Vehiculo
        leVehiculo.Clear()
        oeVehiculo.Activo = True
        oeVehiculo.TipoOperacion = "D"
        oeVehiculo.Motriz = 1
        leVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
        With cboTractoLista
            .ValueMember = "Id"
            .DisplayMember = "Placa"
            .DataSource = leVehiculo
        End With
    End Sub

#End Region

    Private Function ValidaAgregaMovimientoAnalisis() As Boolean
        Try
            If cboCuenta.Enabled Then
                ValidarCombo(cboCuenta, "Cuenta Contable")
            Else
                cboCuenta.SelectedIndex = -1
            End If
            If cboGastonFuncion.Enabled Then
                ValidarCombo(cboGastonFuncion, "Distribucion")
            Else
                cboGastonFuncion.SelectedIndex = -1
            End If
            If cboItemGasto.Enabled Then
                ValidarCombo(cboItemGasto, "Item Gasto")
            Else
                cboItemGasto.SelectedIndex = -1
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarMovimientoAnalisis()
        Try
            If ValidaAgregaMovimientoAnalisis() Then
                'Inicializo objeto
                oeMovimientoAnalisis = New e_MovimientoAnalisis
                Dim leListaAn As New List(Of e_MovimientoAnalisis)
                Dim Divide As Integer = 0
                Divide = 1
                With oeMovimientoAnalisis
                    .Id = ""
                    .IdAsientoMovimiento = ""
                    .IdCuentaContable = cboCuenta.Value
                    .IdGastoFuncion = cboGastonFuncion.Value
                    .IdItemGasto = cboItemGasto.Value
                    .IdCentroCosto = ""
                    .IdTrabajador = ""
                    .IdVehiculo = ""
                    .IdRuta = ""
                    .IdBanco = ""
                    .IdAnalisis1 = ""
                    .IdAnalisis2 = ""
                    .Monto = 0
                    .Saldo = 0
                    .Activo = True
                    .TipoOperacion = "I"
                    .IdTipoCompraParaCompra = oeCta.IdTipoCompra
                    If cboGastonFuncion.SelectedIndex > -1 Then
                        .GastoFuncion = cboGastonFuncion.Items(cboGastonFuncion.SelectedIndex).ListObject
                    End If
                End With
                'leListaAn.Add(oeMovimientoAnalisis)
                oeMovimientoDocumento.MovimientoAnalisis.Add(oeMovimientoAnalisis)

                ''-----------------------
                'For Each obj As e_MovimientoAnalisis In leListaAn
                '    With oeMovimientoDocumento
                '        If .TipoOperacion = "I" Then ' cuando inserto o nuevo cabecera y detalles
                '            If Not .MovimientoAnalisis.Contains(obj) Then
                '                ' si no esta en la lista o no esta contenido AGREGOOO
                '                obj.Monto = obj.Monto / Divide
                '                obj.Saldo = obj.Saldo / Divide
                '                .MovimientoAnalisis.Add(obj)
                '            Else
                '                Throw New Exception("Ya existe este Análisis")
                '            End If
                '        ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                '            If Not .MovimientoAnalisis.Contains(obj) Then
                '                ' si no esta en la lista o no esta contenido AGREGOOO
                '                obj.Monto = obj.Monto / Divide
                '                obj.Saldo = obj.Saldo / Divide
                '                .MovimientoAnalisis.Add(obj)
                '            Else
                '                '-------BUSCA OBJETO EN LA LISTA DE OBJETOS
                '                oeMovimientoAnalisis = .MovimientoAnalisis.Item(.MovimientoAnalisis.IndexOf(obj))
                '                '---------
                '                If oeMovimientoAnalisis.TipoOperacion = "E" Then 'Existe en la BD y esta para eliminarse
                '                    ' la dejo como estaba al inicio(carga)
                '                    oeMovimientoAnalisis.TipoOperacion = ""
                '                Else
                '                    Throw New Exception("Ya existe este Análisis")
                '                End If
                '            End If
                '        End If

                '    End With
                'Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarCuentaCorriente()
        Try
            oeCuentaCorriente = New e_CuentaCorriente
            oeCuentaCorriente.Tipooperacion = "0"
            oeCuentaCorriente.Activo = True
            loCuentaCorriente = olCuentaCorriente.Listar(oeCuentaCorriente).OrderBy(Function(item) item.Trabajador).ToList
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarGrupo()
        Try
            'Dim oeGrupo As New e_Grupo
            'Dim olGrupo As New l_Grupo
            'oeGrupo.TipoOperacion = "1"
            'oeGrupo.Tipo = 1
            'oeGrupo.Estado = "GENERADA"
            'oeGrupo.Activo = True
            'oeGrupo.IdCentro = IdCen
            'leGrupo = olGrupo.Listar(oeGrupo).OrderByDescending(Function(item) item.FechaCreacion).ToList
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarEmpresasPrePago()
        Try
            ListaConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "30" 'prefijo de tipo banda
            ListaConcepto = loConcepto.Listar(oeConcepto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarUsuarioCaja()
        Try
            Dim oeCajaUsuario As New e_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            If oeCajaUsuario.Id <> "" Then
                IdCen = oeCajaUsuario.IdCentro
            Else
                mensajeEmergente.Problema("Este Usuario no esta asignado a ninguna caja", True)
                IdCen = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ValidarCabecera()
        Try
            ValidarCombo(cboMes, "Mes.")
            ValidarCombo(cboTipoDocumento, "Tipo de Documento.")
            ValidarCombo(cbeCtaCte, "Proveedor.")
            ValidarCombo(cboMoneda, "Moneda.")
            ValidarCombo(cboTipoCompra, "T. de Compra.")
            ValidarCombo(cboCuenta, "Cuenta.")
            ValidarCombo(cboGastonFuncion, "Distribución.")
            ValidarCombo(cboItemGasto, "Item Gasto.")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ComprobanteDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Me.Tag <> "bien" Then
            instancia = Nothing
        End If
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select

        If Me.Tag = "Error" Then
            e.Cancel = True
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ComprobanteDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridComprobanteCompra_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridListaMovimientoPeaje.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub gridComprobanteCompra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridListaMovimientoPeaje.DoubleClick
        If gridListaMovimientoPeaje.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub gridComprobanteCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridListaMovimientoPeaje.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        oeMovimientoDocumento.IdTipoDocumento = cboTipoDocumento.Value
        If cboTipoDocumento.SelectedIndex <> -1 Then
            Dim i As Integer = cboTipoDocumento.SelectedIndex
            oeMovimientoDocumento.Compra.TipoDoc = cboTipoDocumento.Items(i).ListObject
            If oeMovimientoDocumento.Compra.TipoDoc.Codigo.Trim = "07" Then
                oeMovimientoDocumento._Operador = -1 'negativo para proveedores o compras
            Else
                oeMovimientoDocumento._Operador = 1
            End If
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc = cboTipoDocumento.Items(i).ListObject
        End If
    End Sub

    Private Sub cboCtaCte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeCtaCte.ValueChanged
        oeMovimientoDocumento.IdClienteProveedor = cbeCtaCte.Value
        If Not IsNothing(cbeCtaCte.ActiveRow) AndAlso cbeCtaCte.Text <> String.Empty Then
            oeMovimientoDocumento.Compra.Proveedor = cbeCtaCte.ActiveRow.ListObject
        End If
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeMovimientoDocumento.IdMoneda = cboMoneda.Value
        If cboMoneda.SelectedIndex <> -1 Then
            Dim i As Integer = cboMoneda.SelectedIndex
            oeMovimientoDocumento.Compra.Moneda = cboMoneda.Items(i).ListObject
        End If
    End Sub

    Private Sub cboTipoCompra_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoCompra.Validated
        Try
            If _ComboTipoCompra <> cboTipoCompra.Value Then
                If cboTipoCompra.SelectedIndex <> -1 Then
                    CargaCuenta(cboTipoCompra.Value)
                    _ComboTipoCompra = cboTipoCompra.Value
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoCompra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCompra.ValueChanged
        oeMovimientoDocumento.Compra.IdTipoCompra = cboTipoCompra.Value
        If cboTipoCompra.SelectedIndex <> -1 Then
            Dim i As Integer = cboTipoCompra.SelectedIndex
            oeMovimientoDocumento.Compra.TipoCompra = cboTipoCompra.Items(i).ListObject
        End If
    End Sub

    Private Sub cboCuenta_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuenta.SelectionChangeCommitted
        Try
            If cboCuenta.SelectedIndex <> -1 Then
                Dim i As Integer = cboCuenta.SelectedIndex
                oeCta = cboCuenta.Items(i).ListObject
                CargaCombosSegunCta()
                oeMovimientoAnalisis = New e_MovimientoAnalisis
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btn_ListarTanqNoAsoc_Click(sender As Object, e As EventArgs) Handles btn_ListarTanqNoAsoc.Click
        Try
            ConsultarTanqueosNoAsociados()
            gbTanqueosNoAsociados.Expanded = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub





    Private Sub cboMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.ValueChanged
        If cboMes.SelectedIndex <> -1 Then
            Dim i As Integer = cboMes.SelectedIndex
            oePeriodo = cboMes.Items(i).ListObject
            'EtiPeriodo.Text = "Periodo: " & oePeriodo.Codigo
        End If
    End Sub



    Private Sub dtpFechaEjercicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEjercicio.ValueChanged
        Try
            ComboPeriodo()
            ComboTipoCompra()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_ListadoTanqueo_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grid_ListaAsociaMP.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListadoTanqueo_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid_ListaAsociaMP.DragDrop
        Try
            'If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then Throw New Exception("No Tiene Permiso para Realizar esta Accion")
            Dim uieOver As UIElement = grid_ListaAsociaMP.DisplayLayout.UIElement.ElementFromPoint(grid_ListaAsociaMP.PointToClient(New Point(e.X, e.Y)))
            Dim MensajePregunta As String
            'get the row that is the drop zone/or where the dragged row is to be dropped 
            'Dim grid1 As UltraGrid = TryCast(sender, UltraGrid)
            Dim ugrOver As UltraGridRow = TryCast(uieOver.GetContext(GetType(UltraGridRow), True), UltraGridRow)

            If grid.ActiveRow.Cells("IndIngresado").Value Then
                MensajePregunta = "Esta seguro de Mover el tanqueo con N° Vale: " & grid.ActiveRow.Cells("NroVale").Value & " al viaje con N°Codigo: " & ugrOver.Cells("CodViaje").Value & " ?"
            Else
                MensajePregunta = "Esta seguro de Mover el tanqueo con N° Vale: " & grid.ActiveRow.Cells("Serie").Value & "-" & grid.ActiveRow.Cells("Numero").Value & " al viaje con N°Codigo: " & ugrOver.Cells("CodViaje").Value & " ?"
            End If

            If Not ugrOver Is Nothing Then
                If ugrOver.Band.Index = 1 Then
                    If grid.ActiveRow.Cells("IdVehiculo").Value = ugrOver.Cells("IdTracto").Value Then
                        If MessageBox.Show(MensajePregunta, _
                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            'If MessageBox.Show("Esta seguro de Mover el tanqueo con N° Vale: " & grid.ActiveRow.Cells("Serie").Value & "-" & grid.ActiveRow.Cells("Numero").Value & " al viaje con N°Codigo: " & ugrOver.Cells("CodViaje").Value & " ?", _
                            '                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMovimientoPeajeA.TipoOperacion = 2
                            oeMovimientoPeajeA.Id = grid.ActiveRow.Cells("Id").Value
                            oeMovimientoPeajeA = olMovimientoPeaje.Obtener(oeMovimientoPeajeA)

                            Dim oeMovimiento_Viaje As New e_Movimiento_Viaje
                            Dim olMovimiento_Viaje As New l_Movimiento_Viaje
                            Dim oeMovimiento As New e_Movimiento
                            Dim olMovimiento As New l_Movimiento
                            oeMovimiento_Viaje.TipoOperacion = 3
                            oeMovimiento_Viaje.IdViaje = ugrOver.Cells("IdViaje").Value
                            oeMovimiento_Viaje = olMovimiento_Viaje.Listar(oeMovimiento_Viaje)(0)

                            If oeMovimiento_Viaje.Estado = gNombreEstadoPendiente Then
                                oeMovimiento.TipoOperacion = "H"
                                oeMovimiento.Id = ugrOver.Cells("IdViaje").Value
                                oeMovimiento.FechaCierre = Now.Date
                                olMovimiento.GuardarSimple(oeMovimiento)
                                oeMovimiento_Viaje.IdEstado = "1CH00012"
                            End If
                            If oeMovimiento_Viaje.Estado = gNombreEstadoReembolsado Then oeMovimiento_Viaje.IdEstado = "1CH00013"


                            If grid.ActiveRow.Cells("IndIngresado").Value Then
                                'validar que asociar a viajes habilitados/liquidados
                                'If ugrOver.Cells("Estado").Value <> gNombreEstadoHabilitada And ugrOver.Cells("Estado").Value <> gNombreEstadoLiquidada Then Throw New Exception("Viaje a asociar " & ugrOver.Cells("Estado").Value & "no se puede asociar.")
                                'validar que viaje origen sea habilitados/liquidados
                                'If ugrOver.Cells("Estado").Value <> gNombreEstadoHabilitada And ugrOver.Cells("Estado").Value <> gNombreEstadoLiquidada Then Throw New Exception("Viaje a asociar " & ugrOver.Cells("Estado").Value & "no se puede asociar.")

                                oeGastoOperacion = New e_GastoOperacion
                                'obtener gastooperacion
                                oeGastoOperacion.TipoOperacion = 1
                                oeGastoOperacion.Id = grid.ActiveRow.Cells("IdGastoOperacion").Value
                                oeGastoOperacion = olGastoOperacion.Obtener(oeGastoOperacion)
                                'validar si viaje ya esta liquidado/reembolsado
                                'If oeGastoOperacion.IdEstado = "1CH00013" Or oeGastoOperacion.IdEstado = "1CH00018" Then Throw New Exception("Viaje ya fue Liquidado/Reembolsado")
                                oeGastoOperacion.TipoOperacion = "P"
                                oeGastoOperacion.IdCuentaCorriente = BuscarIdCtaCte(ugrOver.Cells("IdPiloto").Value, 0, loCuentaCorriente)
                                oeGastoOperacion.IdViaje = ugrOver.Cells("IdViaje").Value
                                oeGastoOperacion.IdTrabajadorAutoriza = gUsuarioSGI.IdTrabajador
                                oeGastoOperacion.IdEstado = oeMovimiento_Viaje.IdEstado
                                oeGastoOperacion.UsuarioCreacion = gUsuarioSGI.Id
                                oeGastoOperacion.oeMovimientoDocumento = Nothing
                                oeGastoOperacion.oeRegistroCombustible = Nothing
                                oeGastoOperacion.GastoAsiento = Nothing
                                olGastoOperacion.GuardarGasto(oeGastoOperacion)
                            Else
                                'validar que asociar a viajes habilitados/liquidados
                                'If ugrOver.Cells("Estado").Value <> gNombreEstadoHabilitada And ugrOver.Cells("Estado").Value <> gNombreEstadoLiquidada Then Throw New Exception("Viaje a asociar " & ugrOver.Cells("Estado").Value & "no se puede asociar.")
                                'validar que exista grupo de liquidaciones 
                                oeGrupo = New e_Grupo
                                oeGrupo.TipoOperacion = "1"
                                oeGrupo.Tipo = 1
                                oeGrupo.Estado = "GENERADA"
                                oeGrupo.Activo = True
                                oeGrupo.IdCentro = IdCen
                                leGrupo = olGrupo.Listar(oeGrupo).OrderByDescending(Function(item) item.FechaCreacion).ToList
                                If leGrupo.Count = 0 Then Throw New Exception("No existe grupo de liquidaciones.")

                                'gNombreEstadoPendiente
                                'gNombreEstadoHabilitada
                                'gNombreEstadoLiquidada
                                'gNombreEstadoReembolsado

                                ''guardar gasto operacion
                                oeGastoOperacion = New e_GastoOperacion
                                oeGastoOperacion.TipoOperacion = "I"
                                oeGastoOperacion.IdCuentaCorriente = BuscarIdCtaCte(ugrOver.Cells("IdPiloto").Value, 0, loCuentaCorriente)
                                oeGastoOperacion.IdCaja = ""
                                oeGastoOperacion.TipoMovimiento = 1
                                oeGastoOperacion.IdFlujoCaja = "1CH000000021"
                                oeGastoOperacion.IdDocumento = grid.ActiveRow.Cells("IdDocumento").Value
                                oeGastoOperacion.IdViaje = ugrOver.Cells("IdViaje").Value
                                oeGastoOperacion.Glosa = "PEAJES Y ESTACIONAMIENTO"
                                oeGastoOperacion.Total = grid.ActiveRow.Cells("Monto").Value
                                'oeGastoOperacion.IdEstado = "1CH00012"
                                oeGastoOperacion.IdEstado = oeMovimiento_Viaje.IdEstado
                                oeGastoOperacion.IdGrupo = leGrupo(0).Id
                                oeGastoOperacion.IdTrabajadorAutoriza = gUsuarioSGI.IdTrabajador
                                oeGastoOperacion.IdLugar = ""
                                oeGastoOperacion.UsuarioCreacion = gUsuarioSGI.Id
                                oeGastoOperacion.Activo = True
                                oeGastoOperacion.FechaEmision = grid.ActiveRow.Cells("Fecha").Value
                                'indCerrado
                                oeGastoOperacion.IndAlmacen = True
                                'fecha cierre
                                oeGastoOperacion.IndGasto = 2
                                Dim EmpPrePago = ListaConcepto.Where(Function(x) x.Valor1 = grid.ActiveRow.Cells("IdEmpresa").Value).ToList()
                                If EmpPrePago.Count > 0 Then oeGastoOperacion.IndGasto = 1
                                oeGastoOperacion.oeMovimientoDocumento = Nothing
                                oeGastoOperacion.oeRegistroCombustible = Nothing
                                oeGastoOperacion.GastoAsiento = Nothing
                                olGastoOperacion.GuardarGasto(oeGastoOperacion)
                                ''asociar
                                oeMovimientoPeajeA.TipoOperacion = "P"
                                oeMovimientoPeajeA.IndIngresado = True
                                oeMovimientoPeajeA.IdGastoOperacion = oeGastoOperacion.Id
                                oeMovimientoPeajeA.UsuarioCreacion = gUsuarioSGI.Id
                                olMovimientoPeaje.Guardar(oeMovimientoPeajeA)
                            End If

                            ConsultarTanqueosNoAsociados()
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("Agregue peaje que contenga el mismo vehiculo")
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListadoTanqueo_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid_ListaAsociaMP.DragOver
        e.Effect = DragDropEffects.Move
        Dim grid As UltraGrid = TryCast(sender, UltraGrid)
        Dim pointInGridCoords As Point = grid.PointToClient(New Point(e.X, e.Y))
        If pointInGridCoords.Y < 20 Then
            ' Scroll up
            Me.grid_ListaAsociaMP.ActiveRowScrollRegion.Scroll(RowScrollAction.LineUp)
        ElseIf pointInGridCoords.Y > grid.Height - 20 Then
            ' Scroll down
            Me.grid_ListaAsociaMP.ActiveRowScrollRegion.Scroll(RowScrollAction.LineDown)
        End If
    End Sub

    Private Sub griListadoTanqueo_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_ListaAsociaMP.InitializeLayout
        e.Layout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        e.Layout.Override.CellClickAction = CellClickAction.RowSelect

        With grid_ListaAsociaMP.DisplayLayout
            .UseFixedHeaders = True
            .Override.FixedHeaderIndicator = FixedHeaderIndicator.None

            With .Bands(0)
                .Override.RowAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .Columns("Id").Header.Fixed = True
                .Columns("Placa").Header.Fixed = True
                .Columns("Marca").Header.Fixed = True
                .Columns("Placa").Header.Caption = "Placa/Viaje/NroVale"
                .Columns("Peso").Header.Caption = "Peso/Monto"
                .Columns("IndTanqueo").Header.Caption = "Full"
                .Columns("CantidadGls").Header.Caption = "Gls"
                .Columns("Marca").Header.Caption = "Marca/Fecha Viaje/Tanqueo"
                .Columns("Marca").CellActivation = Activation.NoEdit
                .Columns("Id").Hidden = True
                .Columns("IdPiloto").Hidden = True
                .Columns("IdCopiloto").Hidden = True
                .Columns("KmTractoOrigen").Hidden = True
                .Columns("KmTractoDestino").Hidden = True
                .Columns("ROrigen").Hidden = True
                .Columns("RDestino").Hidden = True
                .Columns("IdGastoOperacion").Hidden = True
                .Columns("IdOrigen").Hidden = True
                .Columns("IdDestino").Hidden = True
                .Columns("IdMaterial").Hidden = True
                .Columns("IdEmpresaGrifo").Hidden = True
                .Columns("EqOrigen").Hidden = True
                .Columns("EqDestino").Hidden = True
                .Columns("Placa").Width = 80
                .Columns("Marca").Width = 125
                .Columns("Modelo").Width = 80
                .Columns("Piloto").Width = 180
                .Columns("Copiloto").Width = 180
                .Columns("CantidadGls").Width = 65
                .Columns("KM").Width = 80
                .Columns("Grifo").Width = 150
                .Columns("Ruta").Width = 150
                .Columns("LugTanqueo").Width = 100
                .Columns("Peso").Width = 35
                .Columns("Cons").Width = 45
                .Columns("Dist").Width = 45
                .Columns("Rend").Width = 45
                .Columns("UsuarioCrea").Width = 60
                .Columns("IndIngresado").Width = 35
                .Columns("Estado").Width = 45
                .Columns("Documento").Width = 80
                .Columns("IndTanqueo").Width = 30
                .Columns("Rutas").Width = 150
                .Columns("Pesos").Width = 150
                .Columns("Glosa").Width = 150
                .Columns("Material").Width = 60
                .Columns("RendEsperado").Width = 50
                .Columns("GlsEsperado").Width = 50
                .Columns("Desviacion").Width = 50
                .Columns("UsuarioCrea").Width = 70
                .Columns("FechaCrea").Width = 100
                .Columns("UsuarioModif").Width = 70
                .Columns("FechaModif").Width = 100
                .Columns("Cliente").Width = 220
                .Columns("CargaMaterial").Width = 125
                .Columns("KM").CellAppearance.BackColor = Color.SkyBlue
            End With

            With .Bands(1)
                .ColHeadersVisible = False
                .HeaderVisible = False
                .Override.RowAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .Columns("IdTracto").Header.Fixed = True
                .Columns("IdViaje").Header.Fixed = True
                .Columns("CodViaje").Header.Fixed = True
                .Columns("FechaViaje").Header.Fixed = True
                .Columns("FechaViaje").CellActivation = Activation.NoEdit
                .Columns("IdOrigen").Hidden = True
                .Columns("IdDestino").Hidden = True
                .Columns("IdMaterial").Hidden = True
                .Columns("IdTracto").Hidden = True
                .Columns("IdViaje").Hidden = True
                .Columns("IdPiloto").Hidden = True
                .Columns("IdCopiloto").Hidden = True
                .Columns("IdGastoOperacion").Hidden = True
                .Columns("KmTractoOrigen").Hidden = True
                .Columns("KmTractoDestino").Hidden = True
                .Columns("ROrigen").Hidden = True
                .Columns("RDestino").Hidden = True
                .Columns("IdEmpresaGrifo").Hidden = True
                .Columns("EqOrigen").Hidden = True
                .Columns("EqDestino").Hidden = True
                .Columns("FechaViaje").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("KM").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Dist").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Peso").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("FechaViaje").Width = 125
                .Columns("CodViaje").Width = 80
                .Columns("Carreta").Width = 80
                .Columns("Piloto").Width = 180
                .Columns("Copiloto").Width = 180
                .Columns("Ruta").Width = 150
                .Columns("LugTanqueo").Width = 100
                .Columns("Grifo").Width = 150
                .Columns("KM").Width = 80
                .Columns("CantidadGls").Width = 65
                .Columns("Peso").Width = 35
                .Columns("Material").Width = 60
                .Columns("IndIngresado").Width = 35
                .Columns("Estado").Width = 45
                .Columns("IndTanqueo").Width = 30
                .Columns("UsuarioCrea").Width = 60
                .Columns("Cons").Width = 45
                .Columns("Dist").Width = 45
                .Columns("Rend").Width = 45
                .Columns("Rutas").Width = 150
                .Columns("Pesos").Width = 150
                .Columns("Glosa").Width = 150
                .Columns("RendEsperado").Width = 50
                .Columns("GlsEsperado").Width = 50
                .Columns("Desviacion").Width = 50
                .Columns("UsuarioCrea").Width = 70
                .Columns("FechaCrea").Width = 100
                .Columns("UsuarioModif").Width = 70
                .Columns("FechaModif").Width = 100
                .Columns("Cliente").Width = 220
                .Columns("CargaMaterial").Width = 125
                .Columns("CodViaje").CellAppearance.BackColor = Color.Khaki
                .Columns("Dist").CellAppearance.BackColor = Color.Silver
                .Columns("KM").CellAppearance.BackColor = Color.SkyBlue
                .Columns("Peso").Format = "#,##0.00"
                .Columns("KM").Format = "#,##0.00"
                .Columns("FechaViaje").Style = ColumnStyle.DateTime
            End With

            With .Bands(2)
                .Override.RowAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .ColHeadersVisible = False
                .HeaderVisible = False
                .Columns("NroVale").Header.Fixed = True
                .Columns("FechaTanqueo").Header.Fixed = True
                .Columns("IdOrigen").Hidden = True
                .Columns("IdDestino").Hidden = True
                .Columns("IdMaterial").Hidden = True
                .Columns("IdVehiculo").Hidden = True
                .Columns("Id").Hidden = True
                .Columns("IdViaje").Hidden = True
                .Columns("IdGastoOperacion").Hidden = True
                .Columns("KmTractoOrigen").Hidden = True
                .Columns("KmTractoDestino").Hidden = True
                .Columns("ROrigen").Hidden = True
                .Columns("RDestino").Hidden = True
                .Columns("IdPiloto").Hidden = True
                .Columns("IdCopiloto").Hidden = True
                .Columns("IdEmpresaGrifo").Hidden = True
                .Columns("EqOrigen").Hidden = True
                .Columns("EqDestino").Hidden = True
                .Columns("Glosa").CellClickAction = CellClickAction.Edit
                .Columns("FechaTanqueo").CellActivation = Activation.NoEdit
                .Columns("FechaCrea").CellActivation = Activation.NoEdit
                .Columns("FechaModif").CellActivation = Activation.NoEdit
                .Columns("CantidadGls").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Cons").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Kilometraje").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Dist").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("NroVale").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Rend").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("FechaTanqueo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("FechaCrea").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("FechaModif").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("RendEsperado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("GlsEsperado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Desviacion").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Estado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("Documento").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("Id").Width = 80
                .Columns("IdViaje").Width = 80
                .Columns("IdVehiculo").Width = 80
                .Columns("NroVale").Width = 80
                .Columns("FechaTanqueo").Width = 125
                .Columns("Carreta").Width = 80
                .Columns("Piloto").Width = 180
                .Columns("Copiloto").Width = 180
                .Columns("Ruta").Width = 150
                .Columns("Grifo").Width = 150
                .Columns("Kilometraje").Width = 80
                .Columns("LugTanqueo").Width = 100
                .Columns("CantidadGls").Width = 65
                .Columns("Peso").Width = 35
                .Columns("Material").Width = 60
                .Columns("IndIngresado").Width = 35
                .Columns("Estado").Width = 45
                .Columns("IndTanqueo").Width = 30
                .Columns("UsuarioCrea").Width = 60
                .Columns("Cons").Width = 45
                .Columns("Dist").Width = 45
                .Columns("Rend").Width = 45
                .Columns("Rutas").Width = 150
                .Columns("Pesos").Width = 150
                .Columns("Glosa").Width = 150
                .Columns("RendEsperado").Width = 50
                .Columns("GlsEsperado").Width = 50
                .Columns("Desviacion").Width = 50
                .Columns("UsuarioCrea").Width = 70
                .Columns("FechaCrea").Width = 100
                .Columns("UsuarioModif").Width = 70
                .Columns("FechaModif").Width = 100
                .Columns("Cliente").Width = 220
                .Columns("CargaMaterial").Width = 125
                .Columns("NroVale").CellAppearance.BackColor = Color.Khaki
                .Columns("Dist").CellAppearance.BackColor = Color.Silver
                .Columns("Kilometraje").CellAppearance.BackColor = Color.SkyBlue
                .Columns("Kilometraje").Format = "#,##0.00"
                .Columns("Cons").Format = "#,##0.00"
                .Columns("Dist").Format = "#,##0.00"
                .Columns("RendEsperado").Format = "#,##0.00"
                .Columns("GlsEsperado").Format = "#,##0.00"
                .Columns("Desviacion").Format = "#,##0.00"
                .Columns("RendEsperado").Style = ColumnStyle.Double
                .Columns("GlsEsperado").Style = ColumnStyle.Double
                .Columns("Desviacion").Style = ColumnStyle.Double
                .Columns("RendEsperado").MaskInput = "{double:6.2}"
                .Columns("GlsEsperado").MaskInput = "{double:6.2}"
                .Columns("Desviacion").MaskInput = "{double:6.2}"
                .Columns("FechaTanqueo").Style = ColumnStyle.DateTime
                .Columns("FechaCrea").Style = ColumnStyle.DateTime
                .Columns("FechaModif").Style = ColumnStyle.DateTime
            End With
        End With
    End Sub

    Private Sub griListadoTanqueo_SelectionDrag(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grid_ListaAsociaMP.SelectionDrag
        grid = sender
        grid_ListaAsociaMP.DoDragDrop(grid_ListaAsociaMP.Selected.Rows, DragDropEffects.Move)
    End Sub

    Private Sub grid_TanqNoAsoc_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_ListaMPnoAsoc.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            Eliminar()
            e.Cancel = True
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    'Private Sub grid_TanqNoAsoc_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grid_TanqNoAsoc.DoubleClickRow
    '    If grid_TanqNoAsoc.Rows.Count > 0 Then

    '        Operacion = "Editar"
    '        oeRegConsumoCombustible = New e_RegistroConsumoCombustible
    '        Try
    '            ctrEditar = False
    '            If grid_TanqNoAsoc.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
    '                EditarConsumoCombustible()
    '            End If
    '        Catch ex As Exception
    '            mensajeEmergente.Problema("Seleccione un Registro de Consumo de Combustible a Editar")
    '            Exit Sub
    '        End Try
    '        gbeConsultar.Expanded = False
    '        oeRegConsumoCombustible.TipoOperacion = "A"
    '        MostrarTabs(1, ficConCombustible, 1)
    '        MyBase.Editar()

    '    Else
    '        Throw New Exception("No existen filas a editar en tanqueos no asociados.")
    '    End If
    'End Sub

    Private Sub grilisRegCon_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid_ListaMPnoAsoc.DragOver
        e.Effect = DragDropEffects.Move

        Dim grid As UltraGrid = TryCast(sender, UltraGrid)
        Dim pointInGridCoords As Point = grid.PointToClient(New Point(e.X, e.Y))
        If pointInGridCoords.Y < 20 Then
            ' Scroll up
            Me.grid_ListaAsociaMP.ActiveRowScrollRegion.Scroll(RowScrollAction.LineUp)
        ElseIf pointInGridCoords.Y > grid.Height - 20 Then
            ' Scroll down
            Me.grid_ListaAsociaMP.ActiveRowScrollRegion.Scroll(RowScrollAction.LineDown)
        End If
    End Sub

    Private Sub grilisRegCon_SelectionDrag(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grid_ListaMPnoAsoc.SelectionDrag
        grid = sender
        grid_ListaMPnoAsoc.DoDragDrop(grid_ListaMPnoAsoc.Selected.Rows, DragDropEffects.Move)
    End Sub

    Private Sub btnExpande1_Click(sender As Object, e As EventArgs) Handles btnExpande1.Click
        grid_ListaAsociaMP.Rows.CollapseAll(True)
    End Sub

    Private Sub btnExpande2_Click(sender As Object, e As EventArgs) Handles btnExpande2.Click
        btnExpande3.PerformClick()
        For i As Integer = 0 To grid_ListaAsociaMP.Rows.Count - 1
            For Each aChildBand1 As UltraGridChildBand In grid_ListaAsociaMP.Rows(i).ChildBands
                For x As Integer = 0 To aChildBand1.Rows.Count - 1
                    aChildBand1.Rows(x).CollapseAll()
                Next
            Next
        Next
    End Sub

    Private Sub btnExpande3_Click(sender As Object, e As EventArgs) Handles btnExpande3.Click
        grid_ListaAsociaMP.Rows.ExpandAll(True)
    End Sub

#End Region

#Region "Verificación de documentos"

#End Region

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            ugb_Espera2.Visible = True
            ValidarCabecera()
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                'etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty

                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                leMovimientoPeaje.Clear()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 2, 1).Value Is Nothing) Then
                        'etiEjecuta.Text = "Procesando " & ln_Fila & " registros ... "

                        oeMovimientoPeaje = New e_MovimientoPeaje
                        oeMovimientoPeaje.TipoOperacion = "I"
                        oeMovimientoPeaje.IdEmpresa = cbeCtaCte.Value
                        oeMovimientoPeaje.NroTarjeta = Convert.ToString(objWorkSheet.Cells(ln_Fila + 2, 6).Value)
                        oeMovimientoPeaje.Placa = Strings.Left(Convert.ToString(objWorkSheet.Cells(ln_Fila + 2, 5).Value), 3) & "-" & Strings.Right(Convert.ToString(objWorkSheet.Cells(ln_Fila + 2, 5).Value), 3)
                        If leVehiculo.Where(Function(x) x.Placa = oeMovimientoPeaje.Placa).ToList.Count <> 1 Then Throw New Exception("La Placa: " + oeMovimientoPeaje.Placa + " no se encuentra.")
                        oeMovimientoPeaje.IdVehiculo = leVehiculo.Where(Function(x) x.Placa = oeMovimientoPeaje.Placa).ToList(0).Id
                        oeMovimientoPeaje.Fecha = Convert.ToString(objWorkSheet.Cells(ln_Fila + 2, 18).Value)
                        oeMovimientoPeaje.IdDocumento = ""
                        oeMovimientoPeaje.Serie = Strings.Left(Convert.ToString(objWorkSheet.Cells(ln_Fila + 2, 17).Value), 4)
                        oeMovimientoPeaje.Numero = FormatoDocumento(Strings.Right(Convert.ToString(objWorkSheet.Cells(ln_Fila + 2, 17).Value), 8), 10)
                        'oeMovimientoPeaje.Monto = Math.Round(objWorkSheet.Cells(ln_Fila + 2, 16).Value, 2)
                        oeMovimientoPeaje.Monto = objWorkSheet.Cells(ln_Fila + 2, 16).Value
                        oeMovimientoPeaje.IndIngresado = 0
                        oeMovimientoPeaje.IdGastoOperacion = ""
                        oeMovimientoPeaje.UsuarioCreacion = gUsuarioSGI.Id
                        oeMovimientoPeaje.Activo = True
                        leMovimientoPeaje.Add(oeMovimientoPeaje)
                    Else
                        Exit For
                    End If
                Next
                CargarDetImportar(leMovimientoPeaje) : griMovimientoPeajeImportar.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
                mensajeEmergente.Confirmacion("Se han Procesado " & leMovimientoPeaje.Count & " registros", True)
                HabilitarBotones(1)
            Else
                OpenFileDialog1.Dispose()
            End If
        Catch ex As Exception
            'etiEjecuta.Visible = False  
            ugb_Espera2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera2.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
            'etiEjecuta.Visible = False
        End Try
    End Sub

    Private Sub CargarDetImportar(leDI As List(Of e_MovimientoPeaje))
        Try
            With griMovimientoPeajeImportar
                .ResetDisplayLayout()
                .DataSource = leDI
                If leDI.Count > 0 Then btnValidar.Enabled = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetCovisol(leDI As List(Of e_MovimientoPeaje))
        Try
            With griMovPeajeCovisol
                .ResetDisplayLayout()
                .DataSource = leDI
                If leDI.Count > 0 Then btnValidar.Enabled = True
            End With

            Dim band As UltraGridBand = Me.griMovPeajeCovisol.DisplayLayout.Bands(0)
            Dim fila As UltraGridRow
            For Each fila In band.GetRowEnumerator(GridRowType.DataRow)
                If fila.Cells("IndIngresado").Value Then
                    fila.CellAppearance.BackColor = Me.ColorMontoIncorrecto.Color
                End If
            Next fila

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            ugb_Espera2.Visible = True
            olMovimientoPeaje.GuardarConDocumento(leMovimientoPeaje, ListaDocumentos)
            HabilitarBotones(3)
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
        Catch ex As Exception
            ugb_Espera2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera2.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Try
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            ugb_Espera2.Visible = True
            Dim leMovDoc As List(Of e_MovimientoDocumento)
            Dim oeMovDoc As e_MovimientoDocumento
            Dim _TipoCambio As Double = 0

            ListaDocumentos.Clear()

            For Each fila In leMovimientoPeaje
                leMovDoc = New List(Of e_MovimientoDocumento)
                oeMovimientoDocumento = New e_MovimientoDocumento
                _TipoCambio = 0

                With oeMovimientoDocumento
                    .IndCompraVenta = 1 'indica compra
                    ._Operador = 1 'positivo para proveedores-compras
                    .IdUsuarioCrea = gUsuarioSGI.Id
                    .EstadoDocumento = "EMITIDA"
                    .Compra.AnoEmisionAduana = Date.Now.Year
                    .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                End With

                oeMovimientoDocumento.IdTipoDocumento = cboTipoDocumento.Value
                oeMovimientoDocumento.IdClienteProveedor = cbeCtaCte.Value
                oeMovimientoDocumento.IdMoneda = cboMoneda.Value
                oeMovimientoDocumento.Compra.IdTipoCompra = cboTipoCompra.Value

                oeMovimientoDocumento.Compra.TipoDoc = cboTipoDocumento.Items(cboTipoDocumento.SelectedIndex).ListObject
                oeMovimientoDocumento.Compra.Proveedor = cbeCtaCte.ActiveRow.ListObject
                oeMovimientoDocumento.Compra.Moneda = cboMoneda.Items(cboMoneda.SelectedIndex).ListObject
                oeMovimientoDocumento.Compra.TipoCompra = cboTipoCompra.Items(cboTipoCompra.SelectedIndex).ListObject

                If cboMes.SelectedIndex <> -1 Then
                    'Inicializar()
                    oeMovimientoDocumento.IdPeriodo = cboMes.Value
                    oeMovimientoDocumento.FechaFinal = oePeriodo.FechaFin
                    oeMovimientoDocumento.TipoOperacion = "I"
                    oeMovimientoDocumento.Compra.TipoOperacion = "I"
                    oeMovimientoDocumento.Modificado = True
                    Operacion = "Nuevo"
                Else
                    mensajeEmergente.Problema("Seleccione Mes", True)
                End If

                AgregarMovimientoAnalisis()

                'If ValidaComprobante() Then
                If True Then
                    oeMovimientoDocumento.DocAsoc = Nothing
                    With oeMovimientoDocumento
                        .IndOrigenContable = 6
                        .Mac_PC_Local = MacPCLocal()
                        .EstadoDocumento = "ENVIADO"
                        .Compra.CobraCajaChica = 0
                        .leCuotaDocVehMovimiento.Clear()
                        oeObligacionfin.TipoCambio = 0

                    End With
                    oeMovimientoDocumento.Compra.TipoOperacion = oeMovimientoDocumento.TipoOperacion


                    Dim leTCD As New List(Of e_TablaContableDet)
                    Dim i As Integer = 0
                    For Each obj As e_MovimientoAnalisis In oeMovimientoDocumento.MovimientoAnalisis
                        oeMovDoc = New e_MovimientoDocumento
                        If obj.IdTipoCompraParaCompra Is Nothing Then
                            Throw New Exception("Este Item tiene una cuenta que no tiene Tipo de Compra: " & obj.Cuenta)
                        End If
                        If i = 0 Then
                            oeMovimientoDocumento.Compra.IdTipoCompra = obj.IdTipoCompraParaCompra
                            oeMovDoc = oeMovimientoDocumento.Clonar
                            oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                            oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
                            oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
                            oeMovDoc.Compra.Base1 = obj.Monto
                            leTCD = leTipoCompra.Where(Function(item) item.Id = obj.IdTipoCompraParaCompra).ToList
                            oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
                            oeMovimientoDocumento.Compra.IdTipoCompra = leTCD.Item(0).Id
                            leMovDoc.Add(oeMovDoc)
                        ElseIf obj.IdTipoCompraParaCompra = oeMovimientoDocumento.MovimientoAnalisis(i - 1).IdTipoCompraParaCompra Then
                            leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 = leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 + obj.Monto
                        Else
                            oeMovDoc = oeMovimientoDocumento.Clonar
                            oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                            oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
                            oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
                            oeMovDoc.Compra.Base1 = obj.Monto
                            leTCD = leTipoCompra.Where(Function(item) item.Id = obj.IdTipoCompraParaCompra).ToList
                            oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
                            leMovDoc.Add(oeMovDoc)
                        End If
                        i = i + 1
                    Next

                    'olMovimientoDocumento.GuardarCompra(oeMovimientoDocumento, leMovDoc, True, Nothing)
                    'mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                End If

                oeMovimientoDocumento.FechaEmision = fila.Fecha
                oeMovimientoDocumento.FechaVencimiento = fila.Fecha
                oeMovimientoDocumento.IdClienteProveedor = fila.IdEmpresa
                oeMovimientoDocumento.Serie = fila.Serie
                oeMovimientoDocumento.Numero = fila.Numero
                oeMovimientoDocumento.SubTotal = Math.Round((fila.Monto / (1 + _IGV)), 2)
                oeMovimientoDocumento.IGV = fila.Monto - oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.MovimientoAnalisis(0).Monto = oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.MovimientoAnalisis(0).Saldo = oeMovimientoDocumento.SubTotal
                leMovDoc(0).Compra.Base1 = oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.Total = fila.Monto
                oeMovimientoDocumento.Saldo = fila.Monto

                oeMovimientoDocumento.MovimientoAnalisis(0).IdVehiculo = fila.Placa

                _TipoCambio = TipoCambio(oeMovimientoDocumento.FechaEmision)(0)

                If _TipoCambio = 0 Then Throw New Exception("No Existe Tipo Cambio de la Fecha: " & oeMovimientoDocumento.FechaEmision.Date)

                oeMovimientoDocumento.TipoCambio = _TipoCambio

                With oeMovimientoDocumento
                    If cboMoneda.Value = "1CH02" Then
                        .Compra.Base1 = oeMovimientoDocumento.SubTotal * _TipoCambio
                        .Compra.Base2 = 0 : .Compra.Base3 = 0
                        .Compra.Igv1 = oeMovimientoDocumento.IGV * _TipoCambio
                        .Compra.Igv2 = 0 : .Compra.Igv3 = 0 : .Compra.Isc = 0 : .Compra.OtrosTributos = 0 : .Compra.NoGravadas = 0
                    Else
                        .Compra.Base1 = oeMovimientoDocumento.SubTotal
                        .Compra.Base2 = 0 : .Compra.Base3 = 0
                        .Compra.Igv1 = oeMovimientoDocumento.IGV
                        .Compra.Igv2 = 0 : .Compra.Igv3 = 0 : .Compra.Isc = 0 : .Compra.OtrosTributos = 0 : .Compra.NoGravadas = 0
                    End If
                End With


                oeMovimientoDocumento.Compra.TotalBaseCompra = oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.Compra.TotalIGVCompra = oeMovimientoDocumento.IGV

                ListaDocumentos.Add(oeMovimientoDocumento)
                'olMovimientoDocumento.GuardarCompra(oeMovimientoDocumento, leMovDoc, True, Nothing)
                'fila.IdDocumento = oeMovimientoDocumento.Id
                'olMovimientoPeaje.Guardar(fila)
            Next

            HabilitarBotones(2)
            mensajeEmergente.Confirmacion("Se valido correctamente.", True)
            'If olMovimientoPeaje.ImportarDatos(leMovimientoPeaje) Then
            '    mensajeEmergente.Confirmacion("Los Datos han sido Importados Correctamente!!", True)
            'End If
        Catch ex As Exception
            ugb_Espera2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera2.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try

    End Sub

    Private Sub Validar222()
        Try
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            ugb_Espera2.Visible = True
            Dim leMovDoc As List(Of e_MovimientoDocumento)
            Dim oeMovDoc As e_MovimientoDocumento
            Dim _TipoCambio As Double = 0

            ListaDocumentos.Clear()

            For Each fila In leMovimientoPeaje
                leMovDoc = New List(Of e_MovimientoDocumento)
                oeMovimientoDocumento = New e_MovimientoDocumento
                _TipoCambio = 0

                With oeMovimientoDocumento
                    .IndCompraVenta = 1 'indica compra
                    ._Operador = 1 'positivo para proveedores-compras
                    .IdUsuarioCrea = gUsuarioSGI.Id
                    .EstadoDocumento = "EMITIDA"
                    .Compra.AnoEmisionAduana = Date.Now.Year
                    .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                End With

                oeMovimientoDocumento.IdTipoDocumento = cboTipoDocumento.Value
                oeMovimientoDocumento.IdClienteProveedor = cbeCtaCte.Value
                oeMovimientoDocumento.IdMoneda = cboMoneda.Value
                oeMovimientoDocumento.Compra.IdTipoCompra = cboTipoCompra.Value

                oeMovimientoDocumento.Compra.TipoDoc = cboTipoDocumento.Items(cboTipoDocumento.SelectedIndex).ListObject
                oeMovimientoDocumento.Compra.Proveedor = cbeCtaCte.ActiveRow.ListObject
                oeMovimientoDocumento.Compra.Moneda = cboMoneda.Items(cboMoneda.SelectedIndex).ListObject
                oeMovimientoDocumento.Compra.TipoCompra = cboTipoCompra.Items(cboTipoCompra.SelectedIndex).ListObject

                If cboMes.SelectedIndex <> -1 Then
                    'Inicializar()
                    oeMovimientoDocumento.IdPeriodo = cboMes.Value
                    oeMovimientoDocumento.FechaFinal = oePeriodo.FechaFin
                    oeMovimientoDocumento.TipoOperacion = "I"
                    oeMovimientoDocumento.Compra.TipoOperacion = "I"
                    oeMovimientoDocumento.Modificado = True
                    Operacion = "Nuevo"
                Else
                    mensajeEmergente.Problema("Seleccione Mes", True)
                End If

                AgregarMovimientoAnalisis()

                'If ValidaComprobante() Then
                If True Then
                    oeMovimientoDocumento.DocAsoc = Nothing
                    With oeMovimientoDocumento
                        .IndOrigenContable = 6
                        .Mac_PC_Local = MacPCLocal()
                        .EstadoDocumento = "ENVIADO"
                        .Compra.CobraCajaChica = 0
                        .leCuotaDocVehMovimiento.Clear()
                        oeObligacionfin.TipoCambio = 0

                    End With
                    oeMovimientoDocumento.Compra.TipoOperacion = oeMovimientoDocumento.TipoOperacion


                    Dim leTCD As New List(Of e_TablaContableDet)
                    Dim i As Integer = 0
                    For Each obj As e_MovimientoAnalisis In oeMovimientoDocumento.MovimientoAnalisis
                        oeMovDoc = New e_MovimientoDocumento
                        If obj.IdTipoCompraParaCompra Is Nothing Then
                            Throw New Exception("Este Item tiene una cuenta que no tiene Tipo de Compra: " & obj.Cuenta)
                        End If
                        If i = 0 Then
                            oeMovimientoDocumento.Compra.IdTipoCompra = obj.IdTipoCompraParaCompra
                            oeMovDoc = oeMovimientoDocumento.Clonar
                            oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                            oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
                            oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
                            oeMovDoc.Compra.Base1 = obj.Monto
                            leTCD = leTipoCompra.Where(Function(item) item.Id = obj.IdTipoCompraParaCompra).ToList
                            oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
                            oeMovimientoDocumento.Compra.IdTipoCompra = leTCD.Item(0).Id
                            leMovDoc.Add(oeMovDoc)
                        ElseIf obj.IdTipoCompraParaCompra = oeMovimientoDocumento.MovimientoAnalisis(i - 1).IdTipoCompraParaCompra Then
                            leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 = leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 + obj.Monto
                        Else
                            oeMovDoc = oeMovimientoDocumento.Clonar
                            oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                            oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
                            oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
                            oeMovDoc.Compra.Base1 = obj.Monto
                            leTCD = leTipoCompra.Where(Function(item) item.Id = obj.IdTipoCompraParaCompra).ToList
                            oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
                            leMovDoc.Add(oeMovDoc)
                        End If
                        i = i + 1
                    Next

                    'olMovimientoDocumento.GuardarCompra(oeMovimientoDocumento, leMovDoc, True, Nothing)
                    'mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                End If

                oeMovimientoDocumento.FechaEmision = fila.Fecha
                oeMovimientoDocumento.FechaVencimiento = fila.Fecha
                oeMovimientoDocumento.IdClienteProveedor = fila.IdEmpresa
                oeMovimientoDocumento.Serie = fila.Serie
                oeMovimientoDocumento.Numero = fila.Numero
                oeMovimientoDocumento.SubTotal = Math.Round((fila.Monto / (1 + _IGV)), 2)
                oeMovimientoDocumento.IGV = fila.Monto - oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.MovimientoAnalisis(0).Monto = oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.MovimientoAnalisis(0).Saldo = oeMovimientoDocumento.SubTotal
                leMovDoc(0).Compra.Base1 = oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.Total = fila.Monto
                oeMovimientoDocumento.Saldo = fila.Monto

                oeMovimientoDocumento.MovimientoAnalisis(0).IdVehiculo = fila.Placa

                _TipoCambio = TipoCambio(oeMovimientoDocumento.FechaEmision)(0)

                If _TipoCambio = 0 Then Throw New Exception("No Existe Tipo Cambio de la Fecha: " & oeMovimientoDocumento.FechaEmision.Date)

                oeMovimientoDocumento.TipoCambio = _TipoCambio

                With oeMovimientoDocumento
                    If cboMoneda.Value = "1CH02" Then
                        .Compra.Base1 = oeMovimientoDocumento.SubTotal * _TipoCambio
                        .Compra.Base2 = 0 : .Compra.Base3 = 0
                        .Compra.Igv1 = oeMovimientoDocumento.IGV * _TipoCambio
                        .Compra.Igv2 = 0 : .Compra.Igv3 = 0 : .Compra.Isc = 0 : .Compra.OtrosTributos = 0 : .Compra.NoGravadas = 0
                    Else
                        .Compra.Base1 = oeMovimientoDocumento.SubTotal
                        .Compra.Base2 = 0 : .Compra.Base3 = 0
                        .Compra.Igv1 = oeMovimientoDocumento.IGV
                        .Compra.Igv2 = 0 : .Compra.Igv3 = 0 : .Compra.Isc = 0 : .Compra.OtrosTributos = 0 : .Compra.NoGravadas = 0
                    End If
                End With


                oeMovimientoDocumento.Compra.TotalBaseCompra = oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.Compra.TotalIGVCompra = oeMovimientoDocumento.IGV

                ListaDocumentos.Add(oeMovimientoDocumento)
                'olMovimientoDocumento.GuardarCompra(oeMovimientoDocumento, leMovDoc, True, Nothing)
                'fila.IdDocumento = oeMovimientoDocumento.Id
                'olMovimientoPeaje.Guardar(fila)
            Next

            HabilitarBotones(2)
            mensajeEmergente.Confirmacion("Se valido correctamente.", True)
            'If olMovimientoPeaje.ImportarDatos(leMovimientoPeaje) Then
            '    mensajeEmergente.Confirmacion("Los Datos han sido Importados Correctamente!!", True)
            'End If
        Catch ex As Exception
            ugb_Espera2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera2.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            HabilitarBotones(4)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tcComprobanteCompra_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles tcComprobanteCompra.SelectedTabChanged
        Try
            Select Case tcComprobanteCompra.SelectedTab.Index
                Case 0
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                Case 1
                    ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
                Case 2
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscarCovisol_Click(sender As Object, e As EventArgs) Handles btnBuscarCovisol.Click
        Try
            ValidarCabecera()
            Dim oeMovPeaAux As e_MovimientoPeaje
            olCovisol = New CovisolR.GetDatosService
            Dim strFecIni As String = dtpDesdeCovisol.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")
            Dim strFecFin As String = dtpHastaCovisol.Value.AddDays(1).Date.ToString("yyyy-MM-dd HH:mm:ss")

            If strFecIni > strFecFin Then Throw New Exception("Fecha Incorrecta. Fecha Fin debe ser mayor.")


            'Movimientos de WebService
            'Dim loMovimientos = olCovisol.getListRecargas(mstrUsuCovisol, mstrPassCovisol, strTarjeta, strFecIni, strFecFin)
            'listar doc y Pea de WS
            Dim loFacturaPeaje = olCovisol.getFacturasTelepeaje(mstrUsuCovisol, mstrPassCovisol, strFecIni, strFecFin)
            Dim loConsumosPeaje = olCovisol.getConsumosTelepeaje(mstrUsuCovisol, mstrPassCovisol, strFecIni, strFecFin)

            Try
                If loFacturaPeaje.Count = 0 Then Throw New Exception("No existen documentos generados.")
            Catch ex As Exception
                Throw New Exception("No existen documentos generados.")
            End Try
            Try
                If loConsumosPeaje.Count = 0 Then Throw New Exception("No existen peajes generados.")
            Catch ex As Exception
                Throw New Exception("No existen peajes generados.")
            End Try


            '' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Dim loFacturaPeaje As New List(Of CovisolR.xDocumentoETP)
            'Dim loConsumosPeaje As New List(Of CovisolR.saldoTP)
            'Dim oFacturaPeaje As New CovisolR.xDocumentoETP
            'Dim oConsumosPeaje As New CovisolR.saldoTP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000001" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)
            'oFacturaPeaje = New CovisolR.xDocumentoETP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000002" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)
            'oFacturaPeaje = New CovisolR.xDocumentoETP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000003" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)
            'oFacturaPeaje = New CovisolR.xDocumentoETP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000004" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)
            'oFacturaPeaje = New CovisolR.xDocumentoETP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000005" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)
            'oFacturaPeaje = New CovisolR.xDocumentoETP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000006" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)
            'oFacturaPeaje = New CovisolR.xDocumentoETP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000007" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)
            'oFacturaPeaje = New CovisolR.xDocumentoETP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000008" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)
            'oFacturaPeaje = New CovisolR.xDocumentoETP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000009" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)
            'oFacturaPeaje = New CovisolR.xDocumentoETP
            'oFacturaPeaje.serie = "FF01" : oFacturaPeaje.numero = "00000010" : oFacturaPeaje.fechaEmision = "01/06/2017" : oFacturaPeaje.igv = 1.8 : oFacturaPeaje.subTotal = 10
            'loFacturaPeaje.Add(oFacturaPeaje)

            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000001" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000001" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000001" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 4.8
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000002" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000002" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000002" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 4.8
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000003" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000003" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000003" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 3
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000004" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000004" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000004" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 4.8
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000005" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000005" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000005" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 4.8
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP

            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000006" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000006" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000006" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 4.8
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP

            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000007" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000007" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000007" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 4.8
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP

            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000008" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000008" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000008" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 3
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000009" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000009" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000009" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 4.8
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000010" : oConsumosPeaje.placa = "T2K819" : oConsumosPeaje.cantidad = 2
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000010" : oConsumosPeaje.placa = "T2K843" : oConsumosPeaje.cantidad = 5
            'loConsumosPeaje.Add(oConsumosPeaje)
            'oConsumosPeaje = New CovisolR.saldoTP
            'oConsumosPeaje.seriedoc = "FF01" : oConsumosPeaje.numerodoc = "00000010" : oConsumosPeaje.placa = "T2L916" : oConsumosPeaje.cantidad = 4.8
            'loConsumosPeaje.Add(oConsumosPeaje)


            '' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'listar Pea de BD            
            Dim oePeaDb As New e_MovimientoPeaje
            oePeaDb.TipoOperacion = "L"
            oePeaDb.Activo = True
            oePeaDb.IdEmpresa = cbeCtaCte.Value
            Dim listaMovPeaBD = olMovimientoPeaje.Listar(oePeaDb)
            'comparar WS y DB
            Dim contador As Integer = 0
            Dim MontoFact As Decimal = 0
            leMovimientoPeajeCovisol.Clear()
            leFacWsCovison.Clear()
            For Each filaFac In loFacturaPeaje
                contador = listaMovPeaBD.Where(Function(x) x.Serie = filaFac.serie And x.Numero = filaFac.numero).Count()
                If contador <> 0 Then Continue For

                Dim loConPeaAux = loConsumosPeaje.Where(Function(x) x.seriedoc = filaFac.serie And x.numerodoc = filaFac.numero).ToList

                For Each fila In loConPeaAux
                    If fila.seriedoc = "" Then Continue For
                    If fila.numerodoc < 1 Then Continue For

                    'contador = listaMovPeaBD.Where(Function(x) x.Serie = fila.seriedoc And x.Numero = fila.numerodoc).Count()
                    oeMovPeaAux = New e_MovimientoPeaje
                    'If contador = 0 Then
                    '    oeMovPeaAux.TipoOperacion = "I"
                    'Else
                    '    oeMovPeaAux.TipoOperacion = "Z"
                    'End If
                    oeMovPeaAux.TipoOperacion = "I"
                    oeMovPeaAux.IdEmpresa = cbeCtaCte.Value
                    oeMovPeaAux.NroTarjeta = ""
                    oeMovPeaAux.Placa = Strings.Left(Convert.ToString(fila.placa), 3) & "-" & Strings.Right(Convert.ToString(fila.placa), 3)
                    If leVehiculo.Where(Function(x) x.Placa = oeMovPeaAux.Placa).ToList.Count <> 1 Then Throw New Exception("La Placa: " + oeMovimientoPeaje.Placa + " no se encuentra.")
                    oeMovPeaAux.IdVehiculo = leVehiculo.Where(Function(x) x.Placa = oeMovPeaAux.Placa).ToList(0).Id
                    oeMovPeaAux.Fecha = filaFac.fechaEmision
                    oeMovPeaAux.IdDocumento = ""
                    oeMovPeaAux.Serie = fila.seriedoc
                    oeMovPeaAux.Numero = FormatoDocumento(fila.numerodoc, 8)
                    oeMovPeaAux.Monto = fila.cantidad
                    oeMovPeaAux.IndIngresado = 0
                    oeMovPeaAux.IdGastoOperacion = ""
                    oeMovPeaAux.UsuarioCreacion = gUsuarioSGI.Id
                    oeMovPeaAux.Activo = True
                    leMovimientoPeajeCovisol.Add(oeMovPeaAux)
                Next

                MontoFact = leMovimientoPeajeCovisol.Where(Function(x) x.Serie = filaFac.serie And x.Numero = filaFac.numero).Sum(Function(y) y.Monto)

                If Math.Round(MontoFact, 2) = Math.Round(filaFac.igv + filaFac.subTotal, 2) Then
                    oeMovPeaAux = New e_MovimientoPeaje
                    oeMovPeaAux.Serie = filaFac.serie
                    oeMovPeaAux.Numero = filaFac.numero
                    oeMovPeaAux.Monto = filaFac.igv + filaFac.subTotal
                    oeMovPeaAux.Fecha = filaFac.fechaEmision
                    oeMovPeaAux.IdEmpresa = cbeCtaCte.Value
                    leFacWsCovison.Add(oeMovPeaAux)
                    Continue For
                End If

                For Each filaNo In leMovimientoPeajeCovisol
                    If filaNo.Serie = filaFac.serie And filaNo.Numero = filaFac.numero Then filaNo.IndIngresado = True
                Next

            Next
            CargarDetCovisol(leMovimientoPeajeCovisol) : griMovPeajeCovisol.DataBind()
            HabilitarBotones(5)
        Catch ex As Exception
            'etiEjecuta.Visible = False  
            ugb_Espera2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera2.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
            'etiEjecuta.Visible = False
        End Try
    End Sub

    Private Sub btnValidarCovisol_Click(sender As Object, e As EventArgs) Handles btnValidarCovisol.Click
        Try
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            ugb_Espera2.Visible = True
            Dim leMovDoc As List(Of e_MovimientoDocumento)
            Dim oeMovDoc As e_MovimientoDocumento
            Dim _TipoCambio As Double = 0

            ListaDocumentos.Clear() '''''''''''''''''''''

            For Each fila In leFacWsCovison
                leMovDoc = New List(Of e_MovimientoDocumento)
                oeMovimientoDocumento = New e_MovimientoDocumento
                _TipoCambio = 0

                With oeMovimientoDocumento
                    .IndCompraVenta = 1 'indica compra
                    ._Operador = 1 'positivo para proveedores-compras
                    .IdUsuarioCrea = gUsuarioSGI.Id
                    .EstadoDocumento = "EMITIDA"
                    .Compra.AnoEmisionAduana = Date.Now.Year
                    .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                End With

                oeMovimientoDocumento.IdTipoDocumento = cboTipoDocumento.Value
                oeMovimientoDocumento.IdClienteProveedor = cbeCtaCte.Value
                oeMovimientoDocumento.IdMoneda = cboMoneda.Value
                oeMovimientoDocumento.Compra.IdTipoCompra = cboTipoCompra.Value

                oeMovimientoDocumento.Compra.TipoDoc = cboTipoDocumento.Items(cboTipoDocumento.SelectedIndex).ListObject
                oeMovimientoDocumento.Compra.Proveedor = cbeCtaCte.ActiveRow.ListObject
                oeMovimientoDocumento.Compra.Moneda = cboMoneda.Items(cboMoneda.SelectedIndex).ListObject
                oeMovimientoDocumento.Compra.TipoCompra = cboTipoCompra.Items(cboTipoCompra.SelectedIndex).ListObject

                If cboMes.SelectedIndex <> -1 Then
                    'Inicializar()
                    oeMovimientoDocumento.IdPeriodo = cboMes.Value
                    oeMovimientoDocumento.FechaFinal = oePeriodo.FechaFin
                    oeMovimientoDocumento.TipoOperacion = "I"
                    oeMovimientoDocumento.Compra.TipoOperacion = "I"
                    oeMovimientoDocumento.Modificado = True
                    Operacion = "Nuevo"
                Else
                    mensajeEmergente.Problema("Seleccione Mes", True)
                End If

                For Each oePea In leMovimientoPeajeCovisol
                    If oePea.Serie <> fila.Serie Then Continue For
                    If Integer.Parse(oePea.Numero) <> fila.Numero Then Continue For
                    AgregarMovimientoAnalisis()
                Next

                Dim i As Integer = 0
                For Each oePea In leMovimientoPeajeCovisol
                    If oePea.Serie <> fila.Serie Then Continue For
                    If Integer.Parse(oePea.Numero) <> fila.Numero Then Continue For
                    oeMovimientoDocumento.MovimientoAnalisis(i).Monto = Math.Round((oePea.Monto / (1 + _IGV)), 2)
                    oeMovimientoDocumento.MovimientoAnalisis(i).Saldo = Math.Round((oePea.Monto / (1 + _IGV)), 2)
                    oeMovimientoDocumento.MovimientoAnalisis(i).IdVehiculo = oePea.Placa
                    i = i + 1
                Next

                'If ValidaComprobante() Then
                If True Then
                    oeMovimientoDocumento.DocAsoc = Nothing
                    With oeMovimientoDocumento
                        .IndOrigenContable = 6
                        .Mac_PC_Local = MacPCLocal()
                        .EstadoDocumento = "ENVIADO"
                        .Compra.CobraCajaChica = 0
                        .leCuotaDocVehMovimiento.Clear()
                        oeObligacionfin.TipoCambio = 0

                    End With
                    oeMovimientoDocumento.Compra.TipoOperacion = oeMovimientoDocumento.TipoOperacion


                    Dim leTCD As New List(Of e_TablaContableDet)
                    'Dim i As Integer = 0
                    'For Each obj As e_MovimientoAnalisis In oeMovimientoDocumento.MovimientoAnalisis
                    oeMovDoc = New e_MovimientoDocumento
                    If oeMovimientoDocumento.MovimientoAnalisis(0).IdTipoCompraParaCompra Is Nothing Then
                        Throw New Exception("Este Item tiene una cuenta que no tiene Tipo de Compra: " & oeMovimientoDocumento.MovimientoAnalisis(0).Cuenta)
                    End If
                    oeMovimientoDocumento.Compra.IdTipoCompra = oeMovimientoDocumento.MovimientoAnalisis(0).IdTipoCompraParaCompra
                    oeMovDoc = oeMovimientoDocumento.Clonar
                    oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                    oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
                    oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
                    oeMovDoc.Compra.Base1 = 0
                    leTCD = leTipoCompra.Where(Function(item) item.Id = oeMovimientoDocumento.MovimientoAnalisis(0).IdTipoCompraParaCompra).ToList
                    oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
                    oeMovimientoDocumento.Compra.IdTipoCompra = leTCD.Item(0).Id
                    leMovDoc.Add(oeMovDoc)
                    'If i = 0 Then

                    'ElseIf obj.IdTipoCompraParaCompra = oeMovimientoDocumento.MovimientoAnalisis(i - 1).IdTipoCompraParaCompra Then
                    '    leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 = leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 + obj.Monto
                    'Else
                    '    oeMovDoc = oeMovimientoDocumento.Clonar
                    '    oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                    '    oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
                    '    oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
                    '    oeMovDoc.Compra.Base1 = obj.Monto
                    '    leTCD = leTipoCompra.Where(Function(item) item.Id = obj.IdTipoCompraParaCompra).ToList
                    '    oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
                    '    leMovDoc.Add(oeMovDoc)
                    'End If
                    'i = i + 1
                    'Next

                    'olMovimientoDocumento.GuardarCompra(oeMovimientoDocumento, leMovDoc, True, Nothing)
                    'mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                End If

                oeMovimientoDocumento.FechaEmision = fila.Fecha
                oeMovimientoDocumento.FechaVencimiento = fila.Fecha
                oeMovimientoDocumento.IdClienteProveedor = fila.IdEmpresa
                oeMovimientoDocumento.Serie = fila.Serie
                oeMovimientoDocumento.Numero = FormatoDocumento(fila.Numero, 8)
                oeMovimientoDocumento.SubTotal = Math.Round((fila.Monto / (1 + _IGV)), 2)
                oeMovimientoDocumento.IGV = fila.Monto - oeMovimientoDocumento.SubTotal
                leMovDoc(0).Compra.Base1 = oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.Total = fila.Monto
                oeMovimientoDocumento.Saldo = fila.Monto

                _TipoCambio = TipoCambio(oeMovimientoDocumento.FechaEmision)(0)

                If _TipoCambio = 0 Then Throw New Exception("No Existe Tipo Cambio de la Fecha: " & oeMovimientoDocumento.FechaEmision.Date)

                oeMovimientoDocumento.TipoCambio = _TipoCambio

                With oeMovimientoDocumento
                    If cboMoneda.Value = "1CH02" Then
                        .Compra.Base1 = oeMovimientoDocumento.SubTotal * _TipoCambio
                        .Compra.Base2 = 0 : .Compra.Base3 = 0
                        .Compra.Igv1 = oeMovimientoDocumento.IGV * _TipoCambio
                        .Compra.Igv2 = 0 : .Compra.Igv3 = 0 : .Compra.Isc = 0 : .Compra.OtrosTributos = 0 : .Compra.NoGravadas = 0
                    Else
                        .Compra.Base1 = oeMovimientoDocumento.SubTotal
                        .Compra.Base2 = 0 : .Compra.Base3 = 0
                        .Compra.Igv1 = oeMovimientoDocumento.IGV
                        .Compra.Igv2 = 0 : .Compra.Igv3 = 0 : .Compra.Isc = 0 : .Compra.OtrosTributos = 0 : .Compra.NoGravadas = 0
                    End If
                End With

                oeMovimientoDocumento.Compra.TotalBaseCompra = oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.Compra.TotalIGVCompra = oeMovimientoDocumento.IGV

                ListaDocumentos.Add(oeMovimientoDocumento)
            Next

            HabilitarBotones(6)
            mensajeEmergente.Confirmacion("Se valido correctamente.", True)
        Catch ex As Exception
            ugb_Espera2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera2.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub btnGuardarCovisol_Click(sender As Object, e As EventArgs) Handles btnGuardarCovisol.Click
        Try
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            ugb_Espera2.Visible = True
            leMovimientoPeajeCovisol = leMovimientoPeajeCovisol.Where(Function(x) x.TipoOperacion = "I" And x.IndIngresado = False).ToList
            If leMovimientoPeajeCovisol.Count = 0 Then Throw New Exception("No existe información a guardar.")
            olMovimientoPeaje.GuardarConDocumento(leMovimientoPeajeCovisol, ListaDocumentos)
            HabilitarBotones(7)
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
        Catch ex As Exception
            ugb_Espera2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera2.Visible = False
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub btnNuevoCovisol_Click(sender As Object, e As EventArgs) Handles btnNuevoCovisol.Click
        Try
            HabilitarBotones(8)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
End Class
