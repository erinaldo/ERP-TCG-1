'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Public Class frm_VehiculoPilotoOperacion
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_VehiculoPilotoOperacion = Nothing
    Private Shared Operacion As String
    Private Estado As String

    ''' <summary>
    ''' Instancia unica de Formulario: frm_DemandaRapida
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_VehiculoPilotoOperacion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"
    Dim olVehiculoPiloto As New l_VehiculoPilotoOperacion
    Dim oeVehiculoPiloto As New e_VehiculoPilotoOperacion
    Dim oeListaVP As New List(Of e_VehiculoPilotoOperacion)
    Dim olCombo As New l_Combo
    Dim oeCombo As New e_Combo
    Dim ListaTractoProceso As New List(Of e_Combo)
    Dim oeViaje As New e_Viaje
    Dim olOperacion As New l_Operacion
    Dim _ingresando_datos As Boolean = False
    Private FechaServidor As Date = ObtenerFechaServidor()
    Private ValorIgv As Double = ObtenerIGV()
    Dim oeOperacionDetalle As New e_OperacionDetalle
    Dim ListaOD As New List(Of e_OperacionDetalle)
    Dim oeProcesarTarifasProceso As New e_ProcesarTarifasProceso
    Dim ListaPTP As New List(Of e_ProcesarTarifasProceso)
    Dim IdVP As String = ""
    Dim IndAgregar As Boolean = False
    Dim oeZonaProceso As New e_ZonaProceso
    Dim olZonaProceso As New l_ZonaProceso
    Dim IndEditarZona As Boolean = False
    Dim oeOperacionesProceso As New e_OperacionesProceso
    Dim oeProcesoDetalle As New e_OperacionesProcesoDetalle
    Dim olOperacionesProceso As New l_OperacionesProceso
    Dim olProcesarTarifasProceso As New l_ProcesarTarifasProceso

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
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
            Select Case ficListaVOP.SelectedTab.Index
                Case 0
                    btnAgregar.Enabled = True
                    opcVehiculoPiloto.Enabled = True
                    cboCliente.Text = "ALICORP SAA"
                    oeListaVP = New List(Of e_VehiculoPilotoOperacion)
                    griVehiculoPiloto.DataSource = oeListaVP
                    opcVehiculoPiloto_ValueChanged(Nothing, Nothing)
                    ficMantenimiento.Tabs(0).Selected = True
                    ficMantenimiento.Tabs(0).Enabled = True
                    ficMantenimiento.Tabs(1).Enabled = False
                Case 1
                    oeOperacionesProceso = New e_OperacionesProceso
                    LimpiaGrid(griTarifasProceso, ogdTarifasProceso)
                    LimpiaGrid(griViajesProceso, ogdViajesProceso)
                    LimpiaGrid(griVariables, ogdTarifasDetalles)
                    LimpiaGrid(griCargaOperacion, ogdViaje)
                    fecDesde.Value = Date.Now
                    fecHasta.Value = Date.Now
                    VerFiltro.Checked = False
                    txtIdOperacionProceso.Text = ""
                    txtCodigoOP.Text = ""
                    decSemanaOP.Text = "0.00"
                    decTotalOP.Text = "0.00"
                    decCostoAdicionalOP.Text = "0.00"
                    decCostoTotalOP.Text = "0.00"
                    ficMantenimiento.Tabs(0).Enabled = False
                    ficMantenimiento.Tabs(1).Selected = True
                    ficMantenimiento.Tabs(1).Enabled = True
            End Select

            MostrarTabs(1, ficDemanda, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ugb_Espera.Visible = False
        Catch ex As Exception
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
            Inicializar()
            oeListaVP = New List(Of e_VehiculoPilotoOperacion)
            griVehiculoPiloto.DataSource = oeListaVP
            If EditarVP() Then
                IndAgregar = False
                btnAgregar.Enabled = True
                Operacion = "Editar"
                Select Case ficListaVOP.SelectedTab.Index
                    Case 0
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    Case 1
                        If IndEditarZona Then
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        Else
                            If griOPLista.ActiveRow.Cells("IdEstado").Value = "GENERADA" Then
                                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                            Else
                                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
                            End If
                        End If
                End Select
                IndEditarZona = False
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

    Public Overrides Sub Guardar()
        Try
            If GuardarVP() Then
                MostrarTabs(0, ficDemanda, 2)
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficDemanda, 1)
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
                    If GuardarVP() Then
                        MostrarTabs(0, ficDemanda, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        _ingresando_datos = True
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficDemanda, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
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
        griLista.ActiveRow.Delete()
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
            If ficListaVOP.Tabs(0).Selected Then
                If griLista.Rows.Count > 0 Then
                    Exportar_Excel(griLista)
                End If
            Else
                If griTarifasProceso.Rows.Count > 0 Then
                    Exportar_Excel(griViajesProceso)
                End If
            End If
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"
    Private Sub frm_VehiculoPilotoOperacion_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_VehiculoPilotoOperacion_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficDemanda)
                If _Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
                'Consultar(True)
        End Select
    End Sub

    Private Sub frm_VehiculoPilotoOperacion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_VehiculoPilotoOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaCombos()
        ComboGrilla()
        fecDesde.Value = FechaServidor.AddDays(-6)
        fecHasta.Value = FechaServidor
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarVP() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If griLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub frm_VehiculoPilotoOperacion_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub Menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        Menu.Items("Insert").Visible = True
        If griLista.Selected.Rows.Count > 0 Then
            Menu.Items("Update").Visible = True
            Menu.Items("Delete").Visible = True
        Else
            Menu.Items("Update").Visible = False
            Menu.Items("Delete").Visible = False
        End If
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        txtId.Text = ""
        cboTracto.SelectedIndex = 0
        cboPiloto.SelectedIndex = 0
        cboCliente.SelectedIndex = 0
        cboActividadNegocio.SelectedIndex = 0
        fecInicio.Value = Date.Now
        fecFin.Value = Date.Now
        verActual.Checked = True
        txtIndHistorial.Value = 1
        txtObservacion.Text = ""
        txtMonto.Value = 0
        txtCostoFijo.Value = 0
        txtSemana.Value = 0
    End Sub

    Public Sub LlenaCombos()
        LlenarCombo(cboTracto, "Nombre", TractoPublic, -1)
        LlenarComboMaestro(cboPiloto, PilotoPublic, 0)
        LlenarComboMaestro(cboCliente, ClientesPublic, 0)
        LlenarComboMaestro(cboClienteOP, ClientesPublic, 0)
        oeCombo = New e_Combo
        oeCombo.Nombre = "VENTAS"
        OperacionesPublic = New List(Of e_Combo)
        OperacionesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboActividadNegocio, OperacionesPublic, 0)
        LlenarComboMaestro(cboActividadNegocioOP, OperacionesPublic, 0)

        LlenarComboMaestro(cboZona, ZonaPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList, 0)

        LlenarComboMaestro(cboTipoCargaOP, TipoCargaPublic, -1)
        cboCliente.Text = "ALICORP SAA"
        cboClienteOP.Text = "ALICORP SAA"
        cboTipoCargaOP.Text = "KILOMETRAJE"
        cboActividadNegocioLista_Validated(Nothing, Nothing)
    End Sub

    Private Sub ComboGrilla()
        Dim Tracto As New DataTable
        Dim Piloto As New DataTable
        Dim Cliente As New DataTable
        Dim Operacion As New DataTable
        Tracto = olCombo.ComboGrilla(TractoPublic)
        Piloto = olCombo.ComboGrilla(PilotoPublic)
        Cliente = olCombo.ComboGrilla(ClientesPublic)
        Operacion = olCombo.ComboGrilla(OperacionesPublic)
        CrearComboGrid("IdVehiculo", "Nombre", griVehiculoPiloto, Tracto, True)
        CrearComboGrid("IdPiloto", "Nombre", griVehiculoPiloto, Piloto, True)
        CrearComboGrid("IdCliente", "Nombre", griVehiculoPiloto, Cliente, True)
        CrearComboGrid("IdActividadNegocio", "Nombre", griVehiculoPiloto, Operacion, True)
        CrearComboGrid("IdVehiculo", "Nombre", griLista, Tracto, True)
        CrearComboGrid("IdPiloto", "Nombre", griLista, Piloto, True)
        CrearComboGrid("IdCliente", "Nombre", griLista, Cliente, True)
        CrearComboGrid("IdActividadNegocio", "Nombre", griLista, Operacion, True)
    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case ficListaVOP.SelectedTab.Index
                Case 0
                    oeVehiculoPiloto = New e_VehiculoPilotoOperacion
                    griLista.DataSource = olVehiculoPiloto.Listar(oeVehiculoPiloto)
                    'Ubica el cursor el el primer registro de la grilla
                    If griLista.Rows.Count > 0 Then
                        griLista.Focus()
                        griLista.Rows.Item(0).Selected = True
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                    End If
                    griLista.Focus()
                Case 1
                    oeOperacionesProceso = New e_OperacionesProceso
                    oeOperacionesProceso.Codigo = txtCodigoSemanaLista.Text
                    griOPLista.DataSource = olOperacionesProceso.Listar(oeOperacionesProceso)
                    'Ubica el cursor el el primer registro de la grilla
                    If griOPLista.Rows.Count > 0 Then
                        griOPLista.Focus()
                        griOPLista.Rows.Item(0).Selected = True
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                    End If
                    griOPLista.Focus()
                    CalcularTotales(griOPLista, "Semana", "Total", "CostoAdicional", "CostoTotal")
                    oeZonaProceso = New e_ZonaProceso
                    griTarifasDetalles.DataSource = olZonaProceso.Listar(oeZonaProceso)
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

    Public Function EditarVP() As Boolean
        Try
            Select Case ficListaVOP.SelectedTab.Index
                Case 0
                    If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                        oeVehiculoPiloto = New e_VehiculoPilotoOperacion
                        oeVehiculoPiloto.Id = griLista.ActiveRow.Cells("Id").Value
                        oeVehiculoPiloto = olVehiculoPiloto.Obtener(oeVehiculoPiloto)
                        With oeVehiculoPiloto
                            txtId.Text = .Id
                            opcVehiculoPiloto.CheckedIndex = .IndVP
                            cboTracto.Value = .IdVehiculo
                            cboPiloto.Value = .IdPiloto
                            cboActividadNegocio.Value = .IdActividadNegocio
                            fecInicio.Value = .FechaFin.AddDays(1)
                            fecFin.Value = .FechaFin.AddMonths(1)
                            verActual.Checked = .Actual
                            txtIndHistorial.Text = .IndHistorial + 1
                            txtObservacion.Text = .Observacion
                            cboCliente.Value = .IdCliente
                        End With
                        oeVehiculoPiloto = New e_VehiculoPilotoOperacion
                        oeVehiculoPiloto.Actual = -1
                        If opcVehiculoPiloto.CheckedIndex = 0 Then
                            oeVehiculoPiloto.IdVehiculo = cboTracto.Value
                        Else
                            oeVehiculoPiloto.IdPiloto = cboPiloto.Value
                        End If
                        oeListaVP = olVehiculoPiloto.Listar(oeVehiculoPiloto)
                        griVehiculoPiloto.DataSource = oeListaVP
                    End If
                Case 1
                    If IndEditarZona Then
                        ficMantenimiento.Tabs(1).Enabled = False
                        ficMantenimiento.Tabs(0).Selected = True
                        ficMantenimiento.Tabs(0).Enabled = True
                        If griTarifasDetalles.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                            oeZonaProceso = New e_ZonaProceso
                            oeZonaProceso.Id = griTarifasDetalles.ActiveRow.Cells("Id").Value
                            oeZonaProceso = olZonaProceso.Obtener(oeZonaProceso)
                            With oeZonaProceso
                                txtId.Text = .Id
                                opcVehiculoPiloto.CheckedIndex = 2
                                cboTracto.Value = ""
                                cboPiloto.Value = ""
                                cboActividadNegocio.Value = .IdActividadNegocio
                                cboCliente.Value = .IdCliente
                                cboZona.Text = .Zona
                                txtMonto.Text = .Monto
                                txtCostoFijo.Text = .CostoFijo
                                txtSemana.Text = .Semana
                                txtObservacion.Text = .Observacion
                                fecInicio.Value = .FechaInicio
                                fecFin.Value = .FechaFin
                                verActual.Checked = .Actual
                                txtIndHistorial.Text = 1
                            End With
                        End If
                    Else
                        LimpiaGrid(griTarifasProceso, ogdTarifasProceso)
                        LimpiaGrid(griViajesProceso, ogdViajesProceso)
                        LimpiaGrid(griVariables, ogdTarifasDetalles)
                        LimpiaGrid(griCargaOperacion, ogdViaje)
                        ficMantenimiento.Tabs(0).Enabled = False
                        ficMantenimiento.Tabs(1).Selected = True
                        ficMantenimiento.Tabs(1).Enabled = True
                        oeOperacionesProceso = New e_OperacionesProceso
                        oeOperacionesProceso.Id = griOPLista.ActiveRow.Cells("Id").Value
                        oeOperacionesProceso = olOperacionesProceso.Obtener(oeOperacionesProceso)
                        With oeOperacionesProceso
                            txtIdOperacionProceso.Text = .Id
                            txtCodigoOP.Text = .Codigo
                            fecDesde.Value = .FechaInicio
                            fecHasta.Value = .FechaFin
                            cboClienteOP.Value = .IdCliente
                            cboActividadNegocioOP.Value = .IdActividadNegocio
                            decSemanaOP.Text = .Semana
                            decTotalOP.Text = .Total
                            decCostoAdicionalOP.Text = .CostoAdicional
                            decCostoTotalOP.Text = .CostoTotal
                            txtObservacionOP.Text = .Observacion
                        End With
                        oeProcesarTarifasProceso = New e_ProcesarTarifasProceso
                        oeProcesarTarifasProceso.IdOperacionProceso = oeOperacionesProceso.Id
                        griTarifasProceso.DataSource = olProcesarTarifasProceso.Listar(oeProcesarTarifasProceso)
                        oeProcesoDetalle = New e_OperacionesProcesoDetalle
                        oeProcesoDetalle.IdOperacionProceso = oeOperacionesProceso.Id
                        griViajesProceso.DataSource = olOperacionesProceso.ListarDetalle(oeProcesoDetalle)
                        oeViaje = New e_Viaje
                        oeViaje.TipoOperacion = "X"
                        oeViaje.Id = cboClienteOP.Value
                        griCargaOperacion.DataSource = olOperacion.ListarViaje(oeViaje)
                        oeZonaProceso = New e_ZonaProceso
                        griVariables.DataSource = olZonaProceso.Listar(oeZonaProceso)
                        CalcularTotales(griViajesProceso, "KM", "Factor", "CostoViaje", "FleteUnitario", "Flete")
                        CalcularTotales(griTarifasProceso, "Semana", "Total", "Norte", "CostoAdicional", "CostoTotal")
                        CalcularTotales(griCargaOperacion, "TotalFlete")
                    End If
            End Select
            MostrarTabs(1, ficDemanda, 1)
            opcVehiculoPiloto.Enabled = False
            cboTracto.Enabled = False
            cboPiloto.Enabled = False
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function GuardarVP() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case ficMantenimiento.SelectedTab.Index
                Case 0
                    If opcVehiculoPiloto.CheckedIndex = 2 Then
                        oeZonaProceso = New e_ZonaProceso
                        With oeZonaProceso
                            .TipoOperacion = "I"
                            .Id = txtId.Text
                            .IdActividadNegocio = cboActividadNegocio.Value
                            .IdCliente = cboCliente.Value
                            .Zona = cboZona.Value
                            .Monto = txtMonto.Value
                            .CostoFijo = txtCostoFijo.Value
                            .Semana = txtSemana.Value
                            .Observacion = txtObservacion.Text
                            .FechaInicio = fecInicio.Value
                            .FechaFin = fecFin.Value
                            .Actual = verActual.Checked
                        End With
                        oeZonaProceso.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olZonaProceso.Guardar(oeZonaProceso)
                    Else
                        olVehiculoPiloto.Guardar(oeListaVP)
                    End If
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                Case 1
                    If griViajesProceso.Rows.Count > 0 Then
                        If ValidarOP() Then
                            ugb_Espera.Visible = True
                            Application.DoEvents()
                            Cursor.Current = Cursors.WaitCursor
                            Cursor.Show()
                            If griTarifasProceso.Rows.Count > 0 Then
                                ListaPTP = New List(Of e_ProcesarTarifasProceso)
                                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griTarifasProceso.Rows
                                    oeProcesarTarifasProceso = New e_ProcesarTarifasProceso
                                    With oeProcesarTarifasProceso
                                        .TipoOperacion = "I"
                                        .Id = Fila.Cells("Id").Value
                                        .IdOperacionProceso = ""
                                        .Codigo = Fila.Cells("Codigo").Value
                                        .IdTracto = Fila.Cells("IdTracto").Value
                                        .Tracto = Fila.Cells("Tracto").Value
                                        .CuentaNorte = Fila.Cells("CuentaNorte").Value
                                        .CuentaSur = Fila.Cells("CuentaSur").Value
                                        .CostoFijo = Fila.Cells("CostoFijo").Value
                                        .Valor = Fila.Cells("Valor").Value
                                        .Semana = Fila.Cells("Semana").Value
                                        .NViaje = Fila.Cells("NViaje").Value
                                        .CFxViaje = Fila.Cells("CFxViaje").Value
                                        .Norte = Fila.Cells("Norte").Value
                                        .Sur = Fila.Cells("Sur").Value
                                        .Total = Fila.Cells("Total").Value
                                        .VariableXViaje = Fila.Cells("VariableXViaje").Value
                                        .CostoViaje = Fila.Cells("CostoViaje").Value
                                        .CostoAdicional = Fila.Cells("CostoAdicional").Value
                                        .CostoTotal = Fila.Cells("CostoTotal").Value
                                        .Adicional01 = Fila.Cells("Adicional01").Value
                                        .Adicional02 = Fila.Cells("Adicional02").Value
                                        .FechaInicio = Fila.Cells("FechaInicio").Value
                                        .FechaFin = Fila.Cells("FechaFin").Value
                                        .Observacion = Fila.Cells("Observacion").Value
                                        .UsuarioCreacion = gUsuarioSGI.Id
                                    End With
                                    oeProcesarTarifasProceso.PrefijoID = gs_PrefijoIdSucursal '@0001
                                    oeOperacionesProceso.ListTarifaProceso.Add(oeProcesarTarifasProceso)
                                Next
                                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesProceso.Rows
                                    oeOperacionDetalle = New e_OperacionDetalle
                                    With oeOperacionDetalle
                                        .TipoOperacion = "A"
                                        .Id = Fila.Cells("IdOperacionDetalle").Value
                                        .Cantidad = Fila.Cells("KM").Value
                                        .FleteUnitario = Fila.Cells("FleteUnitario").Value
                                        .Flete = Fila.Cells("Flete").Value
                                        .UsuarioCreacion = gUsuarioSGI.Id
                                    End With
                                    oeOperacionesProceso.ListOperacionDetalle.Add(oeOperacionDetalle)
                                Next
                                For Each Fila As UltraWinGrid.UltraGridRow In griCargaOperacion.Rows
                                    oeOperacionDetalle = New e_OperacionDetalle
                                    If Fila.Cells("Seleccion").Value Then
                                        With oeOperacionDetalle
                                            .TipoOperacion = "3"
                                            .Id = Fila.Cells("Id").Value
                                            .UsuarioCreacion = gUsuarioSGI.Id
                                        End With
                                        oeOperacionesProceso.ListOperacionDetalle.Add(oeOperacionDetalle)
                                    End If
                                Next
                                With oeOperacionesProceso
                                    decSemanaOP.Text = .ListTarifaProceso.Sum(Function(Item) Item.Semana)
                                    decTotalOP.Text = .ListTarifaProceso.Sum(Function(Item) Item.Total)
                                    decCostoAdicionalOP.Text = .ListTarifaProceso.Sum(Function(Item) Item.CostoAdicional)
                                    decCostoTotalOP.Text = .ListTarifaProceso.Sum(Function(Item) Item.CostoTotal)
                                    .TipoOperacion = "I"
                                    .Id = txtIdOperacionProceso.Text
                                    .Codigo = txtCodigoOP.Text
                                    .FechaInicio = fecDesde.Value
                                    .FechaFin = fecHasta.Value
                                    .IdCliente = cboClienteOP.Value
                                    .IdActividadNegocio = cboActividadNegocioOP.Value
                                    .Semana = decSemanaOP.Text
                                    .Total = decTotalOP.Text
                                    .CostoAdicional = decCostoAdicionalOP.Text
                                    .CostoTotal = decCostoTotalOP.Text
                                    .Observacion = txtObservacionOP.Text
                                    .IdEstado = "1CH00014"
                                    .UsuarioCrea = gUsuarioSGI.Id
                                End With
                                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesProceso.Rows
                                    oeProcesoDetalle = New e_OperacionesProcesoDetalle
                                    With oeProcesoDetalle
                                        .Id = Fila.Cells("Id").Value
                                        .IdOperacionProceso = ""
                                        .IdViaje = Fila.Cells("IdViaje").Value
                                        .IdOperacionDetalle = Fila.Cells("IdOperacionDetalle").Value
                                        .Viaje = Fila.Cells("Viaje").Value
                                        .Semana = Fila.Cells("Semana").Value
                                        .Tracto = Fila.Cells("Tracto").Value
                                        .Carreta = Fila.Cells("Carreta").Value
                                        .Dia = Fila.Cells("Dia").Value
                                        .Fecha = Fila.Cells("Fecha").Value
                                        .Origen = Fila.Cells("Origen").Value
                                        .Destino = Fila.Cells("Destino").Value
                                        .Zona = Fila.Cells("Zona").Value
                                        .NTransporte = Fila.Cells("NTransporte").Value
                                        .Glosa = Fila.Cells("Glosa").Value
                                        .TipoCarga = Fila.Cells("TipoCarga").Value
                                        .KM = Fila.Cells("KM").Value
                                        .Factor = Fila.Cells("Factor").Value
                                        .CostoViaje = Fila.Cells("CostoViaje").Value
                                        .FleteUnitario = Fila.Cells("FleteUnitario").Value
                                        .Flete = Fila.Cells("Flete").Value
                                        .Observacion = Fila.Cells("Observacion").Value
                                    End With
                                    oeOperacionesProceso.ListProcesoDetalle.Add(oeProcesoDetalle)
                                Next

                                Dim VHTP = From T In oeOperacionesProceso.ListTarifaProceso Group By T.Tracto Into Count() Select Tracto
                                Dim VHPD = From T In oeOperacionesProceso.ListProcesoDetalle Group By T.Tracto Into Count() Select Tracto

                                If VHTP.Count <> VHPD.Count Then
                                    Throw New Exception("Verificar las unidades que se estan reportando no coinciden en su Detalle Costo Viajes.")
                                End If
                                oeOperacionesProceso.PrefijoID = gs_PrefijoIdSucursal '@0001
                                If olOperacionesProceso.Guardar(oeOperacionesProceso) Then
                                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                                    If MessageBox.Show("Desea Visualizar la Liquidacion en Excel:  ?", _
                                                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                                        GenerarExcelRenting(txtCostoFijoOP.Value, griVariables)
                                    End If
                                End If
                            End If
                        End If
                    End If
            End Select
            IndEditarZona = False
            Operacion = "Inicializa"
            If griLista.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
            End If
            Return True
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub GenerarExcelRenting(ByVal CostoFijo As Double, ByVal Grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        Dim objXls As Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objWorkSheet As Excel.Worksheet
        objXls = New Excel.Application
        Dim FileToCopy As String = ""
        Dim PathFilePTRA As String = ""
        Dim Origen As String = ""
        Try
            If oeOperacionesProceso.ListProcesoDetalle.Count > 0 Then

                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\PlantillaRenting.xlt"
                PathFilePTRA = Application.StartupPath & "\PlantillaRenting.xls"

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
                With objWorkSheet
                    .Cells(3, 11) = oeOperacionesProceso.FechaInicio.Date
                    .Cells(3, 12) = oeOperacionesProceso.FechaFin.Date
                    .Cells(3, 15) = oeOperacionesProceso.Codigo
                    .Cells(15, 3) = CostoFijo
                End With
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Grilla.Rows
                    With objWorkSheet
                        .Cells(ln_Fila + 5, 2) = fila.Cells("Zona").Value
                        .Cells(ln_Fila + 5, 3) = fila.Cells("Monto").Value
                    End With
                    ln_Fila = ln_Fila + 1
                Next
                ln_Fila = 1
                For Each obj As e_ProcesarTarifasProceso In oeOperacionesProceso.ListTarifaProceso
                    With objWorkSheet
                        .Cells(ln_Fila + 5, 5) = obj.Tracto
                        .Cells(ln_Fila + 5, 6) = obj.Valor
                        .Cells(ln_Fila + 5, 9) = "=G" & CStr(ln_Fila + 5) & "/H" & CStr(ln_Fila + 5)
                        .Cells(ln_Fila + 5, 11) = "=J" & CStr(ln_Fila + 5) & "/H" & CStr(ln_Fila + 5)
                        .Cells(ln_Fila + 5, 13) = obj.CostoAdicional
                        .Cells(ln_Fila + 5, 14) = "=O" & CStr(ln_Fila + 5) & "/H" & CStr(ln_Fila + 5)
                    End With
                    ln_Fila = ln_Fila + 1
                Next
                ln_Fila = 1
                For Each obj As e_OperacionesProcesoDetalle In oeOperacionesProceso.ListProcesoDetalle
                    With objWorkSheet
                        .Cells(ln_Fila + 19, 1) = obj.Viaje
                        .Cells(ln_Fila + 19, 2) = obj.Semana
                        .Cells(ln_Fila + 19, 3) = obj.Tracto
                        .Cells(ln_Fila + 19, 4) = obj.Dia
                        .Cells(ln_Fila + 19, 5) = obj.Fecha.Date
                        .Cells(ln_Fila + 19, 6) = obj.Origen
                        .Cells(ln_Fila + 19, 7) = obj.Destino
                        .Cells(ln_Fila + 19, 8) = obj.Zona
                        .Cells(ln_Fila + 19, 9) = obj.NTransporte
                        .Cells(ln_Fila + 19, 10) = obj.Glosa
                        .Cells(ln_Fila + 19, 11) = obj.TipoCarga
                        .Cells(ln_Fila + 19, 12) = obj.KM
                        .Cells(ln_Fila + 19, 15) = obj.Observacion
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
                Throw New Exception("No se genero detalle para el informe.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Function ValidarOP() As Boolean
        Try
            If Operacion = "Nuevo" Then
                oeOperacionesProceso = New e_OperacionesProceso
                oeOperacionesProceso.Codigo = txtCodigoOP.Text
                oeOperacionesProceso = olOperacionesProceso.Obtener(oeOperacionesProceso)
                If oeOperacionesProceso.Id <> "" Then
                    Throw New Exception("Esta semana ya fue generada: " & txtCodigoOP.Text)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Private Function EliminarVP() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLista
                If ValidarGrilla(griLista, "Vehiculo / Piloto") Then
                    oeVehiculoPiloto.Id = griLista.ActiveRow.Cells("Id").Value
                    oeVehiculoPiloto = olVehiculoPiloto.Obtener(oeVehiculoPiloto)
                    If oeVehiculoPiloto.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar al Vehiculo / Piloto:  ?", _
                                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            olVehiculoPiloto.Eliminar(oeVehiculoPiloto)
                            'Consultar(True)
                            Operacion = "Inicializa"
                            If griLista.Rows.Count > 0 Then
                                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                            Else
                                ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                            End If
                        Else
                            Return False
                            Exit Function
                        End If
                    Else
                        Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function ValidaCamposCabecera() As Boolean
        Try
            If opcVehiculoPiloto.CheckedIndex = 0 Then
                ValidarCombo(cboTracto, "Tracto")
            Else
                ValidarCombo(cboPiloto, "Piloto")
            End If
            ValidarCombo(cboCliente, "Cliente")
            If Operacion = "Nuevo" Then
                oeVehiculoPiloto = New e_VehiculoPilotoOperacion
                oeVehiculoPiloto.Actual = -1
                If opcVehiculoPiloto.CheckedIndex = 0 Then
                    oeVehiculoPiloto.IdVehiculo = cboTracto.Value
                Else
                    oeVehiculoPiloto.IdPiloto = cboPiloto.Value
                End If
                If olVehiculoPiloto.Listar(oeVehiculoPiloto).Count > 0 Then
                    Throw New Exception(" Vehiculo/Piloto ya esta agregado verifique en la Lista Principal")
                End If
            End If
            If Operacion = "Editar" Then
                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griVehiculoPiloto.Rows
                    Fila.Cells("Actual").Value = False
                Next
                IndAgregar = True
            End If
            If IndAgregar Then
                btnAgregar.Enabled = False
            End If
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region

#Region "Control de tiempo de respuesta y actualización"

    'Private Sub frm_DemandaRapida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    InicializaTiempo()
    'End Sub

    'Private Sub griLista_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griLista.MouseMove
    '    If _tiempo <= 0 Then
    '        Consultar(True)
    '    End If
    '    InicializaTiempo()
    'End Sub

    'Public Overloads Function InicializaTiempo() As Integer
    '    _tiempo = 120
    'End Function

#End Region

#Region "Menú contextual del maestro de Demandas rápidas"

    Private Sub AsociarMenu()
        griLista.ContextMenuStrip = Menu
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Eliminar()
    End Sub

#End Region

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If ValidaCamposCabecera() Then
                '' oeListaVP = griVehiculoPiloto.DataSource
                With oeVehiculoPiloto
                    .Id = ""
                    .IndVP = opcVehiculoPiloto.CheckedIndex
                    If opcVehiculoPiloto.CheckedIndex = 0 Then
                        .IdVehiculo = cboTracto.Value
                        .IdPiloto = ""
                    Else
                        .IdVehiculo = ""
                        .IdPiloto = cboPiloto.Value
                    End If
                    .IdCliente = cboCliente.Value
                    .IdActividadNegocio = cboActividadNegocio.Value
                    .Observacion = txtObservacion.Text
                    .FechaInicio = fecInicio.Value
                    .FechaFin = fecFin.Value
                    .IndHistorial = txtIndHistorial.Text
                    .Actual = verActual.Checked
                    .UsuarioCrea = gUsuarioSGI.Id
                End With
                oeVehiculoPiloto.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeListaVP.Add(oeVehiculoPiloto)
                LimpiaGrid(griVehiculoPiloto, ogdVehiculoPiloto)
                griVehiculoPiloto.DataSource = oeListaVP.Where(Function(Item) Item.Activo = True).ToList
                oeVehiculoPiloto = New e_VehiculoPilotoOperacion
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub opcVehiculoPiloto_ValueChanged(sender As Object, e As EventArgs) Handles opcVehiculoPiloto.ValueChanged
        btnAgregar.Enabled = True
        grupoZona.Enabled = False
        cboZona.Enabled = False
        If opcVehiculoPiloto.CheckedIndex = 0 Then
            cboTracto.Enabled = True
            cboPiloto.Enabled = False
            cboPiloto.Text = ""
        Else
            If opcVehiculoPiloto.CheckedIndex = 1 Then
                cboTracto.Text = ""
                cboTracto.Enabled = False
                cboPiloto.Enabled = True
            Else
                cboTracto.Text = ""
                cboTracto.Enabled = False
                cboPiloto.Text = ""
                cboPiloto.Enabled = False
                btnAgregar.Enabled = False
                grupoZona.Enabled = True
                cboZona.Enabled = True
            End If
        End If
    End Sub

    Private Sub cboActividadNegocioLista_Validated(sender As Object, e As EventArgs) Handles cboActividadNegocioOP.Validated
        Try
            ListaTractoProceso = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "TODOS"
            ListaTractoProceso.Add(oeCombo)
            oeCombo = New e_Combo
            oeCombo.Id = cboActividadNegocioOP.Value
            oeCombo.Nombre = "Proceso"
            oeCombo.Descripcion = fecDesde.Value
            ListaTractoProceso.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarCombo(cboTractoOP, "Nombre", ListaTractoProceso, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try


    End Sub

    Private Sub btnListarViajes_Click(sender As Object, e As EventArgs) Handles btnListarViajesOP.Click
        Try
            If ValidarOP() Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                LimpiaGrid(griTarifasProceso, ogdTarifasProceso)
                LimpiaGrid(griViajesProceso, ogdViajesProceso)
                LimpiaGrid(griTarifasDetalles, ogdTarifasDetalles)
                LimpiaGrid(griCargaOperacion, ogdViaje)
                Dim Tabla As DataSet
                oeViaje = New e_Viaje
                ListaPTP = New List(Of e_ProcesarTarifasProceso)
                With oeViaje
                    .TipoOperacion = "R"
                    .FechaDesde = fecDesde.Value
                    .FechaHasta = fecHasta.Value
                    .Cliente = cboClienteOP.Value
                    .IdOperacion = cboActividadNegocioOP.Value
                    .Tracto = cboTractoOP.Value
                    .TipoVehiculo = cboTipoCargaOP.Value
                    .FleteUnitario = ValorIgv
                    .UsuarioCreacion = gUsuarioSGI.Id
                    If VerFiltro.Checked = True Then
                        .Codigo = txtCodigoOP.Text
                    End If
                End With
                Tabla = olOperacion.ListarViajeProceso(oeViaje)
                griViajesProceso.DataSource = Tabla.Tables(0)
                CalcularTotales(griViajesProceso, "KM", "Factor", "CostoViaje", "FleteUnitario", "Flete")
                griTarifasProceso.DataSource = Tabla.Tables(1)
                CalcularTotales(griTarifasProceso, "Semana", "Total", "Norte", "CostoAdicional", "CostoTotal")
                griVariables.DataSource = Tabla.Tables(2)
                oeViaje = New e_Viaje
                oeViaje.TipoOperacion = "X"
                oeViaje.Id = cboClienteOP.Value
                griCargaOperacion.DataSource = olOperacion.ListarViaje(oeViaje)
                CalcularTotales(griCargaOperacion, "TotalFlete")
                ugb_Espera.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griVehiculoPiloto_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griVehiculoPiloto.CellChange
        griVehiculoPiloto.UpdateData()
    End Sub

    Private Sub griViajesProceso_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajesProceso.CellChange
        griViajesProceso.UpdateData()
    End Sub

    Private Sub griVehiculoPiloto_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griVehiculoPiloto.BeforeRowsDeleted
        Try
            IdVP = ""
            e.DisplayPromptMsg = False
            If EliminarVPEditado() Then
                e.Cancel = True
                LimpiaGrid(griVehiculoPiloto, ogdVehiculoPiloto)
                griVehiculoPiloto.DataSource = oeListaVP.Where(Function(Item) Item.Activo = True).ToList
                'griVehiculoPiloto.DataBind()
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function EliminarVPEditado() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griVehiculoPiloto
                If ValidarGrilla(griVehiculoPiloto, "Vehiculo / Piloto") Then
                    If MessageBox.Show("Esta seguro de eliminar al Vehiculo / Piloto:  ?", _
                                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        IdVP = .ActiveRow.Cells("Id").Text
                        ''olVehiculoPiloto.Eliminar(oeVehiculoPiloto)
                        For Each FilaVP As e_VehiculoPilotoOperacion In oeListaVP.Where(Function(Item) Item.Id = IdVP).ToList
                            FilaVP.Activo = False
                        Next
                    Else
                        Return False
                        Exit Function
                    End If
                End If
            End With
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub MZnuevo_Click(sender As Object, e As EventArgs) Handles MZnuevo.Click
        Nuevo()
        ficMantenimiento.Tabs(0).Selected = True
        ficMantenimiento.Tabs(0).Enabled = True
        ficMantenimiento.Tabs(1).Enabled = False
        opcVehiculoPiloto.CheckedIndex = 2
        opcVehiculoPiloto.Enabled = False
    End Sub

    Private Sub MZactualizar_Click(sender As Object, e As EventArgs) Handles MZactualizar.Click
        IndEditarZona = True
        Editar()
        ficMantenimiento.Tabs(0).Selected = True
        ficMantenimiento.Tabs(0).Enabled = True
        ficMantenimiento.Tabs(1).Enabled = False
        btnAgregar.Enabled = False
    End Sub

    Private Sub griTarifasDetalles_DoubleClick(sender As Object, e As EventArgs) Handles griTarifasDetalles.DoubleClick
        IndEditarZona = True
        Editar()
        btnAgregar.Enabled = False
    End Sub

    Private Function EliminarZP() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ValidarGrilla(griTarifasDetalles, "Zona Proceso") Then
                oeZonaProceso = New e_ZonaProceso
                oeZonaProceso.Id = griTarifasDetalles.ActiveRow.Cells("Id").Value
                oeZonaProceso = olZonaProceso.Obtener(oeZonaProceso)
                If oeZonaProceso.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar la Zona seleccionada ?", _
                                        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                        MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        olZonaProceso.Eliminar(oeZonaProceso)
                    Else
                        Return False
                        Exit Function
                    End If
                Else
                    Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
                End If
            End If
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub griTarifasDetalles_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTarifasDetalles.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarZP() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MZeliminar_Click(sender As Object, e As EventArgs) Handles MZeliminar.Click
        griTarifasDetalles.ActiveRow.Delete()
    End Sub

    Private Sub MenuZona_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuZona.Opening
        MenuZona.Items("MZnuevo").Visible = True
        If griTarifasDetalles.Selected.Rows.Count > 0 Then
            MenuZona.Items("MZactualizar").Visible = True
            MenuZona.Items("MZeliminar").Visible = True
        Else
            MenuZona.Items("MZactualizar").Visible = False
            MenuZona.Items("MZeliminar").Visible = False
        End If
    End Sub

    Private Sub griTarifasProceso_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTarifasProceso.CellChange
        Try
            If Operacion = "Nuevo" Then
                griTarifasProceso.UpdateData()
                If e IsNot Nothing Then
                    Select Case e.Cell.Column.Key
                        Case "CostoAdicional"
                            CostoViajeAdicional()
                    End Select
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTarifasProceso_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTarifasProceso.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub OperaSemana()
        Try
            With griTarifasProceso.ActiveRow
                .Cells("Semana").Value = txtCostoFijoOP.Value * .Cells("Valor").Value
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub OperaNroViaje()
        Try
            Dim Tracto As String = ""
            Dim NroViaje As Integer = 0
            With griTarifasProceso.ActiveRow
                Tracto = .Cells("Tracto").Value
            End With
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesProceso.Rows.Where(Function(Item) Item.Cells("TipoCarga").Value <> "VACIO" And Item.Cells("Tracto").Value = Tracto).ToList
                NroViaje = NroViaje + 1
            Next
            With griTarifasProceso.ActiveRow
                .Cells("NViaje").Value = NroViaje
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub OperaCostoFijoViaje()
        Try
            With griTarifasProceso.ActiveRow
                .Cells("CFxViaje").Value = .Cells("Semana").Value / .Cells("NViaje").Value
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub OperaTotal()
        Try
            Dim Tracto As String = ""
            Dim Total As Double = 0
            With griTarifasProceso.ActiveRow
                Tracto = .Cells("Tracto").Value
            End With
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesProceso.Rows.Where(Function(Item) Item.Cells("Tracto").Value = Tracto).ToList
                Total += Fila.Cells("Factor").Value
            Next
            With griTarifasProceso.ActiveRow
                .Cells("Total").Value = Total
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub OperaVariableXViaje()
        Try
            With griTarifasProceso.ActiveRow
                .Cells("VariableXViaje").Value = .Cells("Total").Value / .Cells("NViaje").Value
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub OperaCostoViaje()
        Try
            With griTarifasProceso.ActiveRow
                .Cells("CostoViaje").Value = .Cells("CFxViaje").Value + .Cells("VariableXViaje").Value
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub CostoViajeAdicional()
        Try
            With griTarifasProceso.ActiveRow
                .Cells("Sur").Value = (.Cells("CostoAdicional").Value / .Cells("NViaje").Value) + .Cells("CostoViaje").Value
                .Cells("CostoTotal").Value = .Cells("Sur").Value * .Cells("NViaje").Value
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub OperaCostoViajeDetalle()
        Try
            Dim Tracto As String = ""
            Dim CostoViaje As Double = 0
            With griTarifasProceso.ActiveRow
                Tracto = .Cells("Tracto").Value
                CostoViaje = .Cells("CostoViaje").Value
            End With
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesProceso.Rows.Where(Function(Item) Item.Cells("Tracto").Value = Tracto And Item.Cells("ViajeRetorno").Value = False).ToList
                Fila.Cells("CostoViaje").Value = CostoViaje
            Next
            
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griTarifasProceso_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTarifasProceso.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim CostoViaje As Double = 0.0
            Select Case e.Cell.Column.Key
                Case "Guardar"
                    With griTarifasProceso.ActiveRow
                        CostoViaje = .Cells("Sur").Value
                        For Each Fila As UltraWinGrid.UltraGridRow In griViajesProceso.Rows
                            If Fila.Cells("Tracto").Value = .Cells("Tracto").Value And (Fila.Cells("TipoCarga").Value <> "VACIO") Then
                                If Fila.Cells("KM").Value = 0 Then Fila.Cells("KM").Value = 1
                                Fila.Cells("CostoViaje").Value = CostoViaje
                                Fila.Cells("FleteUnitario").Value = CostoViaje / Fila.Cells("KM").Value
                                Fila.Cells("Flete").Value = (CostoViaje * ValorIgv) + CostoViaje
                            Else
                                If Fila.Cells("Tracto").Value = .Cells("Tracto").Value Then
                                    Fila.Cells("CostoViaje").Value = 0
                                    Fila.Cells("FleteUnitario").Value = 0
                                    Fila.Cells("Flete").Value = 0
                                End If
                            End If
                        Next
                        .CellAppearance.BackColor = Me.colorCambio.Color
                    End With
                Case "Tracto"
                    OperaSemana()
                    OperaNroViaje()
                    OperaCostoFijoViaje()
                    OperaTotal()
                    OperaVariableXViaje()
                    OperaCostoViaje()
                    CostoViajeAdicional()
                    OperaCostoViajeDetalle()
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

    Private Sub griViajesProceso_BeforeRowsDeleted(sender As Object, e As UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajesProceso.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub griCargaOperacion_CellChange(sender As Object, e As UltraWinGrid.CellEventArgs) Handles griCargaOperacion.CellChange
        Try
            griCargaOperacion.UpdateData()
            Dim IndTracto As Integer = 0
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griCargaOperacion.ActiveRow
                        If .Cells("Seleccion").Value Then
                            For Each Fila As UltraWinGrid.UltraGridRow In griTarifasProceso.Rows
                                If Fila.Cells("Tracto").Value = .Cells("Tracto").Value Then
                                    Fila.Cells("CostoAdicional").Value = Fila.Cells("CostoAdicional").Value + .Cells("TotalFlete").Value
                                    Fila.Activated = True
                                    griTarifasProceso_CellChange(Nothing, Nothing)
                                    IndTracto = 1
                                    Exit For
                                End If
                            Next
                        Else
                            For Each Fila As UltraWinGrid.UltraGridRow In griTarifasProceso.Rows
                                If Fila.Cells("Tracto").Value = .Cells("Tracto").Value Then
                                    Fila.Cells("CostoAdicional").Value = Fila.Cells("CostoAdicional").Value - .Cells("TotalFlete").Value
                                    Fila.Activated = True
                                    griTarifasProceso_CellChange(Nothing, Nothing)
                                    IndTracto = 1
                                    Exit For
                                End If
                            Next
                        End If
                        If IndTracto = 0 Then .Cells("Seleccion").Value = False
                    End With
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecDesde_Validated(sender As Object, e As EventArgs) Handles fecDesde.Validated
        If Operacion = "Nuevo" Then
            txtCodigoOP.Text = DatePart(DateInterval.WeekOfYear, fecDesde.Value) & " - " & DatePart(DateInterval.Year, fecDesde.Value)
        End If


    End Sub

    Private Sub griOPLista_DoubleClick(sender As Object, e As EventArgs) Handles griOPLista.DoubleClick
        If griOPLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub fecSemana_Validated(sender As Object, e As EventArgs) Handles fecSemana.Validated
        txtCodigoSemanaLista.Text = DatePart(DateInterval.WeekOfYear, fecSemana.Value) & " - " & DatePart(DateInterval.Year, fecSemana.Value)
    End Sub

    Private Sub NuevoInforme_Click(sender As Object, e As EventArgs) Handles NuevoInforme.Click
        Nuevo()
    End Sub

    Private Sub EditarInforme_Click(sender As Object, e As EventArgs) Handles EditarInforme.Click
        Editar()
    End Sub

    Private Sub VerArchivo_Click(sender As Object, e As EventArgs) Handles VerArchivo.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOperacionesProceso = New e_OperacionesProceso
            oeOperacionesProceso.TipoOperacion = "1"
            oeOperacionesProceso.Id = griOPLista.ActiveRow.Cells("Id").Value
            oeOperacionesProceso = olOperacionesProceso.Obtener(oeOperacionesProceso)
            GenerarExcelRenting(txtCostoFijoLista.Value, griTarifasDetalles)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub EliminarInforme_Click(sender As Object, e As EventArgs) Handles EliminarInforme.Click
        griOPLista.ActiveRow.Delete()
    End Sub

    Private Sub EnviarInforme_Click(sender As Object, e As EventArgs) Handles EnviarInforme.Click
        Try
            If griOPLista.ActiveRow.Cells("IdEstado").Value = "GENERADA" Then
                oeOperacionesProceso = New e_OperacionesProceso
                oeOperacionesProceso.TipoOperacion = "C"
                oeOperacionesProceso.Id = griOPLista.ActiveRow.Cells("Id").Value
                oeOperacionesProceso.PrefijoID = gs_PrefijoIdSucursal '@0001
                olOperacionesProceso.Guardar(oeOperacionesProceso)
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                griOPLista.ActiveRow.CellAppearance.BackColor = Me.colorCambio.Value
            Else
                Throw New Exception("Estado del informe no valido. Para esta opcion")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuProceso_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuProceso.Opening
        With MenuProceso
            .Items("NuevoInforme").Visible = True
            If griOPLista.Selected.Rows.Count > 0 Then
                .Items("EditarInforme").Visible = True
                .Items("EliminarInforme").Visible = True
                .Items("VerArchivo").Visible = True
                .Items("EnviarInforme").Visible = True
            Else
                .Items("EditarInforme").Visible = False
                .Items("EliminarInforme").Visible = False
                .Items("VerArchivo").Visible = False
                .Items("EnviarInforme").Visible = False
            End If
        End With
    End Sub

    Private Sub griOPLista_BeforeRowsDeleted(sender As Object, e As UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griOPLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarOP() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Function EliminarOP() As Boolean
        Try
            If griOPLista.ActiveRow.Cells("IdEstado").Value = "GENERADA" Then
                If MessageBox.Show("Esta seguro de eliminar el Informe SEMANA: " & _
                                                    griOPLista.ActiveRow.Cells("Codigo").Value & " ?", _
                                                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    oeOperacionesProceso = New e_OperacionesProceso
                    oeOperacionesProceso.TipoOperacion = "E"
                    oeOperacionesProceso.Id = griOPLista.ActiveRow.Cells("Id").Value
                    olOperacionesProceso.Eliminar(oeOperacionesProceso)
                Else
                    Return False
                    Exit Function
                End If
            Else
                Throw New Exception("No se puede eliminar informe, Estado no permitido")
            End If
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class