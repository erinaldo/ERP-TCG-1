'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports System.Threading

Public Class frm_SegurosOperacionCarga
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion de Formulario"

    Private Shared instancia As frm_SegurosOperacionCarga = Nothing
    Private Shared Operacion As String
    Private Estado As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_SegurosOperacionCarga()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeClienteViaPri As New e_ClienteViajePrima
    Private olClienteViaPrim As New l_ClienteViajePrima

    Private oeClientePrima As New e_ClientePrima
    Private olClientePrima As New l_ClientePrima
    Private loClientePrima As New List(Of e_ClientePrima)

    Private oeClienteViaPriCon As New e_ClienteViajePrimaCon
    Private olClienteViaPriCon As New l_ClienteViajePrimaCon
    Private loClienteViaPriCon As New List(Of e_ClienteViajePrimaCon)

    Private oeClienteViaPriDet As New e_ClienteViajePrimaDet
    Private olClienteViaPriDet As New l_ClienteViajePrimaDet
    Private loClienteViaPriDet As New List(Of e_ClienteViajePrimaDet)

    Private oeViaje As New e_Viaje
    Private olViaje As New l_Operacion
    Private loViaje As New List(Of e_Viaje)

    Dim oeEstado As New e_Estado
    Dim oeRuta As New e_Ruta

    Dim oeCliente As New e_Cliente
    Dim olDemanda As New l_Demanda

    Dim _ingresando_datos As Boolean = False

    Private oePeriodo As New e_Periodo

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Operacion = "Inicializa"
        Try
            Listar(Activo)
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            Inicializar()
            MostrarTabs(1, ficSegurosCarga, 1)
            MostrarTabs(0, ficSeguroDetalle, 1)
            ControlBotones()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griSegurosCarga.Selected.Rows.Count > 0 Then
                Inicializar()
                MostrarTabs(1, ficSegurosCarga, 1)
                Mostrar()
                Operacion = "Editar"
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarPrimaViaje() Then
                MostrarTabs(0, ficSegurosCarga, 2)
                Consultar(True)
            Else
                MostrarTabs(1, ficSegurosCarga, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If Operacion = "Nuevo" Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarPrimaViaje() Then
                            MostrarTabs(0, ficSegurosCarga, 2)
                            _ingresando_datos = False
                            Operacion = "Inicializa"
                            ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                        Else
                            _ingresando_datos = True
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficSegurosCarga, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, ficSegurosCarga, 2)
                _ingresando_datos = False
                Operacion = "Inicializa"
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficSegurosCarga.SelectedTab.Index
                Case 0
                    If griSegurosCarga.Rows.Count = 0 Then Throw New Exception("No hay Ningun Dato para Exportar al Excel")
                    Exportar_Excel(griSegurosCarga)
                Case 1
                    Select Case ficSeguroDetalle.SelectedTab.Index
                        Case 0
                            If griViajesCargas.Rows.Count = 0 Then Throw New Exception("No hay Ningun Dato para Exportar al Excel")
                            Exportar_Excel(griViajesCargas)
                        Case 1
                            If griPrimaSeguroCon.Rows.Count = 0 Then Throw New Exception("No hay Ningun Dato para Exportar al Excel")
                            Exportar_Excel(griPrimaSeguroCon)
                        Case 2
                            If griClientePrima.Rows.Count = 0 Then Throw New Exception("No hay Ningun Dato para Exportar al Excel")
                            Exportar_Excel(griClientePrima)
                    End Select
            End Select
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_SegurosOperacionCarga_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_SegurosOperacionCarga_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ControlBotones()
    End Sub

    Private Sub frm_SegurosOperacionCarga_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_SegurosOperacionCarga_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub Menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContex.Opening
        MenuContex.Items("Insert").Visible = True
        If griSegurosCarga.Selected.Rows.Count > 0 Then
            MenuContex.Items("Actualizar").Visible = True
            MenuContex.Items("Delete").Visible = True
        Else
            MenuContex.Items("Actualizar").Visible = False
            MenuContex.Items("Delete").Visible = False
        End If
    End Sub

    Private Sub btnConsolidar_Click(sender As Object, e As EventArgs) Handles btnConsolidar.Click
        Try
            If griViajesCargas.Rows.Count = 0 Then Throw New Exception("No Existen Datos para Consolidar")
            If txtTC.Value = 0 Then Throw New Exception("El Tipo Cambio no Puede ser 0")
            If txtFactor1.Value = 0 Then Throw New Exception("El Factor1 no Puede ser 0")
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            CrearListaDetalle()
            ConsolidarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub frm_SegurosOperacionCarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecFechaInicio.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.txtTC.Value = TipoCambio(ObtenerFechaServidor(), True)(0)
        LlenarCombosForm()
        LlenaClientePrimaSeguro()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeViaje = New e_Viaje
            loViaje = New List(Of e_Viaje)
            ValidarFechaDesde_Hasta(fecFechaInicio, fecFechaFin)
            oeViaje.FechaDesde = fecFechaInicio.Value
            oeViaje.FechaHasta = fecFechaFin.Value
            oeViaje.TipoOperacion = "R"
            loViaje = olViaje.ListarViaje(oeViaje)
            CargarPorFacturar(loViaje, griViajesCargas)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griSegurosCarga_DoubleClick(sender As Object, e As EventArgs) Handles griSegurosCarga.DoubleClick
        Editar()
    End Sub

    Private Sub PrimaSeguroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimaSeguroToolStripMenuItem.Click
        Try
            MostrarTabs(1, ficSegurosCarga, 1)
            MostrarTabs(2, ficSeguroDetalle, 2)
            griClientePrima.Focus()
            griClientePrima.Select()
            ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            MostrarTabs(1, ficPrimaSeguro, 1)
            oeClientePrima = New e_ClientePrima
            oeClientePrima.TipoOperacion = "I"
            oeClientePrima.PrefijoID = gs_PrefijoIdSucursal '@0001

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            MostrarTabs(1, ficPrimaSeguro, 1)
            oeClientePrima = New e_ClientePrima

            oeClientePrima.TipoOperacion = "A"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnVigencia_Click(sender As Object, e As EventArgs) Handles btnVigencia.Click
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MessageBox.Show("Desea Eliminar el Registro?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                oeClientePrima.Id = griClientePrima.ActiveRow.Cells("Id").Value
                olClientePrima.Eliminar(oeClientePrima)
                LlenaClientePrimaSeguro()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            MostrarTabs(0, ficPrimaSeguro, 1)
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            oeClientePrima.IdCliente = cboCliente.Value
            oeClientePrima.IdMoneda = cboMoneda.Value
            oeClientePrima.MontoAsegurado = txtTotal.Value
            oeClientePrima.Observacion = UltraTextEditor1.Value
            oeClientePrima.FechaInicio = dtpFechaIni.Value
            oeClientePrima.FechaFin = Date.Parse("01/01/1901")
            oeClientePrima.Vigente = cbVigencia.CheckState
            oeClientePrima.FechaCreacion = ObtenerFechaServidor()
            oeClientePrima.UsuarioCreacion = gUsuarioSGI.Id
            oeClientePrima.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olClientePrima.Guardar(oeClientePrima) Then
                mensajeEmergente.Confirmacion("La Informacion Ha Sido Guardada Correctamente", True)
                MostrarTabs(0, ficPrimaSeguro, 1)
                LlenaClientePrimaSeguro()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ficSeguroDetalle_Click(sender As Object, e As EventArgs) Handles ficSeguroDetalle.Click
        ControlBotones()
    End Sub

    Private Sub AñoLista_DatoCambiado() Handles AñoLista.DatoCambiado
        ObtenerMes()
    End Sub

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        ObtenerMes()
    End Sub

#End Region

#Region "Métodos"

    Private Sub ControlBotones()
        Select Case ficSegurosCarga.SelectedTab.Index
            Case 0
                If griSegurosCarga.Rows.Count > 0 Then
                    ControlBoton(1, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                End If
            Case 1
                Select Case ficSeguroDetalle.SelectedTab.Index
                    Case 0, 2
                        ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 1)
                    Case 1
                        If Operacion = "Nuevo" Then
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
                        Else
                            ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 1)
                        End If
                End Select
        End Select
    End Sub

    Private Sub Inicializar()
        oeClienteViaPri = New e_ClienteViajePrima
        oeClienteViaPriCon = New e_ClienteViajePrimaCon
        loClienteViaPriCon = New List(Of e_ClienteViajePrimaCon)
        griPrimaSeguroCon.DataSource = loClienteViaPriCon
        oeClienteViaPriDet = New e_ClienteViajePrimaDet
        loClienteViaPriDet = New List(Of e_ClienteViajePrimaDet)
        loViaje = New List(Of e_Viaje)
        CargarPorFacturar(loViaje, griViajesCargas)
        txtObservacion.Text = String.Empty
        If Operacion = "Nuevo" Then
            btnConsultar.Enabled = True
            btnConsolidar.Enabled = True
        Else
            btnConsultar.Enabled = False
            btnConsolidar.Enabled = False
        End If
    End Sub

    Public Sub LlenaObjeto()
        With oeClienteViaPri
            .IdPeriodo = cboMesCon.Value
            .TipoCambio = txtTC.Value
            .TotalViajes = loClienteViaPriCon.Sum(Function(i) i.CuentaViaje)
            .PrimaTotal = loClienteViaPriCon.Sum(Function(i) i.PrimaTotal)
            .Observacion = txtObservacion.Value
            .loViaPriCon = loClienteViaPriCon
            .loViaPriDet = loClienteViaPriDet
            .UsuarioCreacion = gUsuarioSGI.Id
            .FechaCreacion = ObtenerFechaServidor()
            If Operacion = "Nuevo" Then
                .TipoOperacion = "I"
            Else
                .TipoOperacion = "A"
            End If
        End With
    End Sub

    Private Function GuardarPrimaViaje() As Boolean
        Try
            If loClienteViaPriCon.Count = 0 Then Throw New Exception("No Puede Guardar Sin Detalles")
            LlenaObjeto()
            oeClienteViaPri.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olClienteViaPrim.Guardar(oeClienteViaPri) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Mostrar()
        Try
            ficSeguroDetalle.Tabs(0).Selected = True
            oeClienteViaPri.Id = griSegurosCarga.ActiveRow.Cells("Id").Value
            oeClienteViaPri = olClienteViaPrim.Obtener(oeClienteViaPri)
            Me.txtTC.Value = oeClienteViaPri.TipoCambio
            Me.cboMesCon.Value = oeClienteViaPri.IdPeriodo
            Me.txtObservacion.Value = oeClienteViaPri.Observacion

            oeClienteViaPriDet.TipoOperacion = ""
            oeClienteViaPriDet.IdClienteViajePrima = oeClienteViaPri.Id
            loClienteViaPriDet = olClienteViaPriDet.Listar(oeClienteViaPriDet)
            CargarDetalle(loClienteViaPriDet, griViajesCargas)

            oeClienteViaPriCon.TipoOperacion = ""
            oeClienteViaPriCon.IdClienteViajePrima = oeClienteViaPri.Id
            loClienteViaPriCon = olClienteViaPriCon.Listar(oeClienteViaPriCon)
            griPrimaSeguroCon.DataSource = loClienteViaPriCon

            If loClienteViaPriCon.Count > 0 Then
                Me.txtFactor1.Value = loClienteViaPriCon.Item(0).Factor1
                CalcularTotales(griPrimaSeguroCon, "CuentaViaje", "PrimaTotal")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal TipoOperacion As String)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeClienteViaPri = New e_ClienteViajePrima
            oeClienteViaPri.IdPeriodo = cboMesLista.Value
            griSegurosCarga.DataSource = olClienteViaPrim.Listar(oeClienteViaPri)
            If griSegurosCarga.Rows.Count > 0 Then
                griSegurosCarga.Focus()
                griSegurosCarga.Rows.Item(0).Selected = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub CargarDetalle(ByVal lo As List(Of e_ClienteViajePrimaDet), ByVal Grilla As UltraGrid)
        Try
            With Grilla
                .ResetDisplayLayout()
                .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                .Text = ""
                .DataSource = lo

                OcultarColumna(Grilla, True, "Id", "IdClienteViajePrima", "IdViaje", "IdOperacionDetalle", "IdOrigen", "IdCliente", "IdDestino", "IdMaterial", _
                               "FechaCreacion", "UsuarioCreacion", "Activo")

                .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("FechaViaje").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Tracto").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("CargaMaterial").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("IndAsegurado").Header.VisiblePosition = 8

                .DisplayLayout.Bands(0).Columns("Viaje").Width = 100
                .DisplayLayout.Bands(0).Columns("FechaViaje").Width = 100
                .DisplayLayout.Bands(0).Columns("Origen").Width = 125
                .DisplayLayout.Bands(0).Columns("Destino").Width = 125
                .DisplayLayout.Bands(0).Columns("Cliente").Width = 200
                .DisplayLayout.Bands(0).Columns("Tracto").Width = 60
                .DisplayLayout.Bands(0).Columns("CargaMaterial").Width = 125
                .DisplayLayout.Bands(0).Columns("IndAsegurado").Width = 60

                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("Viaje").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("FechaViaje").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Cliente").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("FechaViaje").Style = ColumnStyle.DateTime

                .DisplayLayout.Bands(0).Columns("IndAsegurado").Header.Appearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("IndAsegurado").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Viaje").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("Viaje").MergedCellStyle = MergedCellStyle.Always

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPorFacturar(ByVal leViaje As List(Of e_Viaje), ByVal Grilla As UltraGrid)
        Try
            With Grilla
                .ResetDisplayLayout()
                .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                .Text = ""
                .DataSource = leViaje.OrderBy(Function(i) i.Fecha).ToList

                ExcluirColumna(Grilla, "Activo", "CargaOrigen", "DescargaDestino", "DiaNoche", "GlosaEscala", "ImpresionGuiaOrigen", "IndEscala", _
                               "IndFecha", "IngresoComplejoOrigen", "IngresoDestino", "KmTractoOrigen", "KmTractoDestino", "TerminoCargaOrigen", _
                               "TerminoDescargaDestino", "Tesoreria", "Turno", "ViajeVacio", "SalidaDestino", "Documentos")
                OcultarColumna(Grilla, True, "Id", "Seleccion", "SalidaOrigen", "Tesoreria", "Activo", "ViajeVacio", "Turno", "DiaNoche", "Carga", "Flota", "Zona", "IndFecha", "PorcentajeFlete", _
                               "IndEscala", "GlosaEscala", "IngresoComplejoOrigen", "CargaOrigen", "TerminoCargaOrigen", "ImpresionGuiaOrigen", "Carreta", "TipoVehiculo", _
                               "IngresoDestino", "DescargaDestino", "TerminoDescargaDestino", "Operacion", "Estado", "KmTractoDestino", "Copiloto", "Ayudante", "Piloto", "IdOperacion", _
                               "SalidaDestino", "Capacidad", "IndCarga", "Produccion", "Cantidad", "FleteUnitario", "IncluyeIgv", "IncidenciaOperaciones", "IncidenciaSeguimiento", "IdOrigen", "IdDestino", _
                               "IdEscala", "ViajeRetorno", "IdPiloto", "DisponibleP", "IdCopiloto", "DisponibleC", "IdAyudante", "DisponibleA", "IdTipoVehiculo", "IdTracto", "IdCarreta", "IdEstado", _
                               "UsuarioCreacion", "UsuarioModifica", "UsuarioSeguimiento", "LlegadaOrigen", "LlegadaAproximadaDestino", "LlegadaDestino", "FechaCreacion", "FechaModifica", _
                               "PesoToneladas", "KmCarretaDestino", "TotalFlete", "KmCarretaOrigen", "IndPlanilla", "IdCentro")

                .DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Tracto").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Carreta").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("CargaMaterial").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("KmCarretaOrigen").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("KmCarretaDestino").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("TotalFlete").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Piloto").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("Escala").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("KmTractoOrigen").Header.VisiblePosition = 17

                .DisplayLayout.Bands(0).Columns("Escala").Hidden = True

                .DisplayLayout.Bands(0).Columns("KmCarretaOrigen").Header.Caption = "Cantidad"
                .DisplayLayout.Bands(0).Columns("KmCarretaDestino").Header.Caption = "Precio"
                .DisplayLayout.Bands(0).Columns("Operacion").Header.Caption = "Nº Operacion"
                .DisplayLayout.Bands(0).Columns("Codigo").Header.Caption = "Viaje"
                .DisplayLayout.Bands(0).Columns("Fecha").Header.Caption = "Fecha Viaje"
                .DisplayLayout.Bands(0).Columns("Estado").Header.Caption = "Est. Viaje"
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.Caption = "Peso Ton."
                .DisplayLayout.Bands(0).Columns("Flota").Header.Caption = "Tipo Carga"
                .DisplayLayout.Bands(0).Columns("Zona").Header.Caption = "Glosa GRT"
                .DisplayLayout.Bands(0).Columns("IncidenciaOperaciones").Header.Caption = "Codigo Semana"
                .DisplayLayout.Bands(0).Columns("IncidenciaSeguimiento").Header.Caption = "Comisionista"
                .DisplayLayout.Bands(0).Columns("KmTractoOrigen").Header.Caption = "Asegurado"

                .DisplayLayout.Bands(0).Columns("KmTractoOrigen").Header.Appearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("KmTractoOrigen").CellAppearance.TextHAlign = HAlign.Center

                .DisplayLayout.Bands(0).Columns("Seleccion").Width = 30
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 100
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 100
                .DisplayLayout.Bands(0).Columns("Origen").Width = 125
                .DisplayLayout.Bands(0).Columns("Destino").Width = 125
                .DisplayLayout.Bands(0).Columns("Cliente").Width = 200
                .DisplayLayout.Bands(0).Columns("Tracto").Width = 60
                .DisplayLayout.Bands(0).Columns("Carreta").Width = 60
                .DisplayLayout.Bands(0).Columns("CargaMaterial").Width = 125
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Width = 60
                .DisplayLayout.Bands(0).Columns("KmCarretaOrigen").Width = 60
                .DisplayLayout.Bands(0).Columns("Piloto").Width = 150
                .DisplayLayout.Bands(0).Columns("KmTractoOrigen").Width = 60

                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None

                .DisplayLayout.Bands(0).Columns("Codigo").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Fecha").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Cliente").Header.Fixed = True

                .DisplayLayout.Bands(0).Columns("Fecha").Style = ColumnStyle.DateTime
                .DisplayLayout.Bands(0).Columns("SalidaOrigen").Style = ColumnStyle.DateTime

                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "TotalFlete", "KmCarretaDestino", "PesoToneladas", "KmCarretaOrigen")

                .DisplayLayout.Bands(0).Columns("Operacion").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("Codigo").CellAppearance.TextVAlign = VAlign.Middle

                .DisplayLayout.Bands(0).Columns("Codigo").MergedCellStyle = MergedCellStyle.Always

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                CalcularTotales(Grilla, "PesoToneladas", "TotalFlete")
            End With
            If griViajesCargas.Rows.Count > 0 Then
                For Each Fila In griViajesCargas.Rows
                    If Fila.Cells("KmTractoOrigen").Value.ToString = -1 Then
                        Fila.CellAppearance.BackColor = Colores4.Color
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombosForm()
        oePeriodo = New e_Periodo
        Dim olPeriodo As New l_Periodo
        Dim lePeriodo As New List(Of e_Periodo)
        oePeriodo.Ejercicio = Año1.Año
        oePeriodo.Activo = True
        lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
        LlenaComboPeriodo(cboMesCon, lePeriodo)
        cboMesCon.SelectedIndex = 0
        oePeriodo = New e_Periodo
        lePeriodo.Add(oePeriodo)
        LlenaComboPeriodo(cboMesLista, lePeriodo)

        LlenarComboMaestro(cboCliente, ClientesPublic, -1)

        Dim oeMoneda As New e_Moneda
        Dim olMoneda As New l_Moneda
        oeMoneda.Activo = True
        oeMoneda.TipoOperacion = "1"
        LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), 0)

    End Sub

    Private Sub LlenaComboPeriodo(Combo As ISL.Controles.Combo, lo As List(Of e_Periodo))
        Try
            With Combo
                .DisplayMember = "NomMes"
                .ValueMember = "Id"
                .DataSource = lo.OrderByDescending(Function(i) i.Mes).ToList
                .Value = ""
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaClientePrimaSeguro()
        Try
            oeClientePrima = New e_ClientePrima
            oeClientePrima.Vigente = True
            loClientePrima = olClientePrima.Listar(oeClientePrima)
            griClientePrima.DataSource = loClientePrima
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CrearListaDetalle()
        Try
            loClienteViaPriDet = New List(Of e_ClienteViajePrimaDet)
            If loViaje.Where(Function(i) i.KmTractoOrigen = -1).ToList.Count > 0 Then Throw New Exception("No Pueden Haber Cargas No Registradas. Verificar")
            For Each oe As e_Viaje In loViaje
                oeClienteViaPriDet = New e_ClienteViajePrimaDet
                With oeClienteViaPriDet
                    .TipoOperacion = "I"
                    .IdOperacionDetalle = oe.IdOperacion
                    .IdViaje = oe.Id
                    .IdCliente = oe.IdEstado
                    .Cliente = oe.Cliente
                    .IdOrigen = oe.IdOrigen
                    .IdDestino = oe.IdDestino
                    .IdMaterial = oe.Estado
                    .IndAsegurado = oe.KmTractoOrigen
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Activo = True
                End With
                loClienteViaPriDet.Add(oeClienteViaPriDet)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConsolidarDetalle()
        Try
            Dim loCliPriSeg As New List(Of e_ClientePrima)
            oeClientePrima = New e_ClientePrima
            oeClientePrima.Vigente = True
            loCliPriSeg.AddRange(olClientePrima.Listar(oeClientePrima))
            Dim loAuxDetalle As New List(Of e_ClienteViajePrimaDet)
            loClienteViaPriCon = New List(Of e_ClienteViajePrimaCon)
            griPrimaSeguroCon.DataSource = loClienteViaPriCon
            Dim idCliente As String = ""
            loAuxDetalle.AddRange(loClienteViaPriDet.OrderBy(Function(i) i.IdCliente))
            For Each oe As e_ClienteViajePrimaDet In loAuxDetalle
                oeClienteViaPriCon = New e_ClienteViajePrimaCon
                With oeClienteViaPriCon
                    If idCliente <> oe.IdCliente Then
                        idCliente = oe.IdCliente
                        .TipoOperacion = "I"
                        .IdCliente = oe.IdCliente
                        .Cliente = oe.Cliente
                        .CuentaViaje = loAuxDetalle.Where(Function(i) i.IdCliente = idCliente).Sum(Function(i) i.IndAsegurado)
                        .Factor1 = txtFactor1.Value
                        oeClientePrima = New e_ClientePrima
                        oeClientePrima.IdCliente = .IdCliente
                        If loCliPriSeg.Contains(oeClientePrima) Then
                            oeClientePrima = loCliPriSeg.Item(loCliPriSeg.IndexOf(oeClientePrima))
                        End If
                        .ImporteSeguro = IIf(oeClientePrima.IdMoneda = "1CH01", oeClientePrima.MontoAsegurado, oeClientePrima.MontoAsegurado * txtTC.Value)
                        ' .PrimaReal = Me.txtFactor1.Value * .ImporteSeguro / 100
                        If .CuentaViaje = 1 Then
                            .PrimaReal = IIf(((.CuentaViaje * .ImporteSeguro * .Factor1) / 100) <= 50, 50, (.CuentaViaje * .ImporteSeguro * .Factor1) / 100)
                        Else
                            .PrimaReal = (.CuentaViaje * .ImporteSeguro * .Factor1) / 100
                        End If
                        ''.PrimaMinima = IIf(.PrimaReal < 10 * Me.txtTC.Value, 10 * Me.txtTC.Value, .PrimaReal)
                        '.PrimaMinima = IIf((.PrimaReal * .Factor1) <= 50, 50, (.PrimaReal * .Factor1))                        
                        .PrimaMinima = IIf((.PrimaReal * .Factor1) < 15, 15, (.PrimaReal * .Factor1))
                        ''.Factor = 1.2154
                        .Factor = (.PrimaReal + .PrimaMinima) * 0.18
                        If .CuentaViaje > 0 Then loClienteViaPriCon.Add(oeClienteViaPriCon)
                    End If
                End With
            Next
            Dim lo As New List(Of e_ClienteViajePrimaCon)
            lo.AddRange(loClienteViaPriCon.OrderBy(Function(i) i.Cliente))
            griPrimaSeguroCon.DataSource = lo
            CalcularTotales(griPrimaSeguroCon, "PrimaTotal", "CuentaViaje")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ObtenerMes()
        Dim lePeriodo As New List(Of e_Periodo)
        lePeriodo.AddRange(ObtenerPeriodoActivo(Año1.Año))
        '---------------- para llenar combo en grilla    

        With cboMesCon
            .DisplayMember = "NomMes"
            .ValueMember = "Id"
            .DataSource = lePeriodo
            If .Items.Count > 0 Then
                .SelectedIndex = Date.Today.Month - 1
            End If
        End With
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griSegurosCarga.ContextMenuStrip = MenuContex
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("ToolStripMenuItem1").Visible = False
        If griViajesCargas.Rows.Count > 0 Then
            MenuContextual1.Items("ToolStripMenuItem1").Visible = True
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            With griViajesCargas

                If .Selected.Rows.Count > 0 Then
                    Dim frm As New frm_ClienteRutaCarga
                    frm = frm.getInstancia()
                    frm.MdiParent = frm_Menu
                    frm.Show()
                    frm.CargarDesdeSeguros(.ActiveRow.Cells("IdEstado").Value, .ActiveRow.Cells("IdOrigen").Value, .ActiveRow.Cells("IdDestino").Value, .ActiveRow.Cells("Estado").Value)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class