'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Infragistics

Public Class frm_Depositos
    Inherits ISL.Win.frm_MenuPadre

    Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Depositos = Nothing
    Private Shared Operacion As String
    Private Estado As String
    Dim _ingresando_datos As Boolean = False

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Depositos()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaracion de Variables"
    Dim oeViaje As New e_Viaje
    Dim oeOperacionDetalle As New e_OperacionDetalle
    Dim loOperacionDetalle As New List(Of e_OperacionDetalle)

    Dim oeReporteFlete As New e_ReporteFlete
    Dim loReporteFlete As New List(Of e_ReporteFlete)
    Dim olReporteFlete As New l_ReporteFlete

    Dim oeOperacion As New e_Operacion
    Dim olOperacion As New l_Operacion
    Dim loOperacion As New List(Of e_Viaje)

    Dim oeMovimiento As New e_Movimiento
    Dim olMovimiento As New l_Movimiento
    Dim idOpeDet As String = ""


    Dim oeDeposito As New e_Deposito
    Dim olDeposito As New l_Deposito

    Dim oeDepositoDetalle, oeDepositoDetalle2 As New e_DepositoDetalle
    Dim olDepositoDetalle As New l_DepositoDetalle

    Dim loDepositoDetalle = New List(Of e_DepositoDetalle)

    Dim oeMovGrupo As New e_Movimiento
    Dim olMovGrupo As New l_Movimiento

    Dim loMovimientoFlete As New List(Of e_Movimiento_Flete)
    Dim oeMovimientoFlete As New e_Movimiento_Flete
    Dim olMovimientoFlete As New l_Movimiento_Flete
    Dim loCA As New List(Of e_CuentaCorriente)

    Dim oeIgv As New e_Impuesto
    Dim OlIgv As New l_Impuesto

    Dim oeMovimientoViaje As New e_Movimiento_Viaje
    Dim olMovimientoViaje As New l_Movimiento_Viaje

    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim oeTemp As New e_CuentaCorriente

    Dim olCuentaCorriente As New l_CuentaCorriente
    Dim loCuentaCorriente As New List(Of e_CuentaCorriente)

    Dim oeChequexCobrar As New e_ChequexCobrar
    Dim olChequexCobrar As New l_ChequexCobrar

    Dim oeEstado As New e_Estado
    Dim olEstado As New l_Estado

    Dim IndFleOpe As Boolean = False

    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta

    Dim oeCliente As New e_Cliente
    Dim olCliente As New l_Cliente
    Dim loCliente As New List(Of e_Cliente)

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador
    Dim loTrabajador As New List(Of e_Trabajador)


    Dim oeTipoCarga As New e_TipoCarga
    Dim olTipoCarga As New l_TipoCarga

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim loMaterial As New List(Of e_Material)

    Dim oeLugar As New e_Lugar
    Dim olLugar As New l_Lugar

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim loVehiculo As New List(Of e_Vehiculo)

    Dim oeTipoVehiculo As New e_TipoVehiculo
    Dim olTipoVehiculo As New l_TipoVehiculo

    Dim Prefijo As New l_Configuracion

    Dim IdTrabajador As String
    Dim ImporteCarga As Decimal
    Dim IdViaje As String
    Dim OperacionFlete, IdDetalleOperacion, IdOperacion As String

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim ListaCentro As New List(Of e_Centro)

    Dim Cargado As Decimal
    Dim Cobrado As Decimal
    Dim Depositado As Decimal
    Dim SaldoPorDepositar As Decimal

    Dim FleteGrupo As Boolean = False

    Dim FilaOperacion As Integer = -1
    Dim IdMovimiento As String = ""

#End Region

    Private Sub InicializarDeposito()
        oeDeposito = New e_Deposito
    End Sub

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            InicializarDeposito()
            oeDeposito.Activo = True
            ListarDeposito()
            InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MostrarTabs(1, ficDeposito, 1)
        LimpiarDeposito(False)
        'ListarOrigenFletes()
        ListarGrupoFletes()
        OperacionFlete = "Depositar"
        InicializarDeposito()
        oeDeposito.TipoOperacion = "I"
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Public Overrides Sub Cancelar()
        MostrarTabs(0, ficDeposito, 0)
        Consultar(True)
        LimpiarDeposito(False)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Public Overrides Sub Guardar()
        If GuardarDeposito() Then
            MostrarTabs(1, ficDeposito, 0)
            MyBase.Guardar()
            LimpiarDeposito(True)
            'Consultar(True)
        End If
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griListaDeposito.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griListaDeposito)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub txtOperacionBuscar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperacionBuscar.ValueChanged
        If Me.txtOperacionBuscar.Text <> String.Empty Then
            Me.cboGrupo.Enabled = False
        Else
            Me.cboGrupo.Enabled = True
        End If
    End Sub

    Private Sub txtOperacionBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOperacionBuscar.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue >= 37 And e.KeyValue <= 40) OrElse (e.KeyValue >= 65 And e.KeyValue <= 90) _
         OrElse (e.KeyValue >= 37 And e.KeyValue <= 40) OrElse (e.KeyValue = 192) OrElse (e.KeyValue = 8 OrElse e.KeyValue = 46 OrElse e.KeyValue = 13)) Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtOperacionBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperacionBuscar.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ListarFletes()
        End If
    End Sub

    Private Sub MnuNuevoDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuNuevoDeposito.Click
        Nuevo()
    End Sub

    Private Sub cboCuentaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancaria.ValueChanged
        txtGlosaDeposito.Text = "DEPOSITO CUENTA: " & cboCuentaBancaria.Text & " /NUMERO: " & txtNumeroDeposito.Text
    End Sub

    Private Sub frm_Depositos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If ficDeposito.SelectedTab.Index = 0 Then
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Depositos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Depositos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Depositos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me, btnListarFletes.Name)
        CargarCombosDeposito()
        Me.fecDepoDesde.Value = Date.Now.AddDays(-7)
        Me.ficDeposito.Tabs(1).Enabled = False
    End Sub

    Private Sub btnListarFletes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarFletes.Click
        ListarFletes()
    End Sub

    Private Sub griOrigenDatoDeposito_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griOrigenDatoDeposito.CellChange
        Try
            With griOrigenDatoDeposito
                .UpdateData()
                If .ActiveRow.Cells("Selec").Activated Then
                    oeDepositoDetalle = New e_DepositoDetalle
                    Dim Fila As UltraGridRow
                    If IndFleOpe Then
                        oeDepositoDetalle.IdMovimientoFlete = .ActiveRow.Cells("Id").Value
                        oeDepositoDetalle.IdOperacionDetalle = ""
                        oeDepositoDetalle.IdViaje = .ActiveRow.Cells("IdViaje").Value
                        oeDepositoDetalle.IndFleOpe = 1
                    Else
                        oeDepositoDetalle.IdMovimientoFlete = ""
                        oeDepositoDetalle.IdOperacionDetalle = .ActiveRow.Cells("Id").Value
                        oeDepositoDetalle.IdViaje = .ActiveRow.Cells("IdViaje").Value
                        oeDepositoDetalle.IndFleOpe = 2
                    End If
                    Fila = .ActiveRow
                    If .ActiveRow.Cells("Selec").Value Then
                        If IndFleOpe Then
                            AgregarFlete(oeDepositoDetalle, Fila)
                        Else
                            If griDetalleDeposito.Rows.Count > 0 Then
                                .ActiveRow.Cells("Selec").Value = False
                                mensajeEmergente.Problema("Primero retire los depositos de flete en el detalle")
                            Else
                                idOpeDet = griOrigenDatoDeposito.ActiveRow.Cells("Id").Value.ToString
                                AgregarFlete(oeDepositoDetalle, Fila)
                            End If
                        End If
                    Else
                        QuitarFlete(oeDepositoDetalle, Fila)
                    End If
                End If
            End With
            griDetalleDeposito.DataBind()
            If griDetalleDeposito.Rows.Count > 0 Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            Else
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboGrupo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.ValueChanged
        Dim oeGr As New e_Grupo
        Dim olGr As New l_Grupo
        If Me.cboGrupo.SelectedIndex >= 0 Then
            Me.txtOperacionBuscar.Enabled = False
            Me.txtOperacionBuscar.Text = String.Empty
            oeGr.Id = cboGrupo.Value
            oeGr.TipoOperacion = "X"
            oeGr = olGr.Obtener(oeGr)
            oeMovGrupo.IdCuentaCorrienteDestino = oeGr.IdCuentaCorriente
        Else
            Me.txtOperacionBuscar.Enabled = True
        End If
    End Sub

    Private Sub txtNumeroDeposito_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroDeposito.ValueChanged
        txtGlosaDeposito.Text = "DEPOSITO CUENTA: " & cboCuentaBancaria.Text & " /NUMERO: " & txtNumeroDeposito.Text
    End Sub

    Private Sub griDetalleDeposito_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleDeposito.CellChange
        Try
            Dim oe As New e_DepositoDetalle
            oe = griDetalleDeposito.ActiveRow.ListObject
            If IndFleOpe Then
                If Len(Trim(oe.IdMovimientoFlete)) < 15 AndAlso oe.Importe > oe.Flete Then
                    griDetalleDeposito.ActiveRow.Cells("Importe").Value = griDetalleDeposito.ActiveRow.Cells("Flete").Value
                    Throw New Exception("El importe a depositar no debe ser mayor al Flete")
                ElseIf Len(Trim(oe.IdMovimientoFlete)) = 15 Then

                    If griDetalleDeposito.ActiveRow.Cells("Importe").Value > griDetalleDeposito.ActiveRow.Cells("SaldoPorDepositar").Value Then
                        griDetalleDeposito.ActiveRow.Cells("Importe").Value = griDetalleDeposito.ActiveRow.Cells("SaldoPorDepositar").Value
                        Throw New Exception("El importe a depositar no debe ser mayor al saldo por depositar")
                    End If
                End If
            End If
            griDetalleDeposito.UpdateData()
            CalTotales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ficDeposito_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficDeposito.SelectedTabChanged
        Me.txtOperacionBuscar.Text = String.Empty
    End Sub

    Private Sub griListaDeposito_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaDeposito.AfterRowActivate
        expDepositoDetalle.Expanded = False
        griDepositoDetalle.DataSource = Nothing
    End Sub

    Private Sub mnuVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVerDetalle.Click
        expDepositoDetalle.Expanded = True
        oeDepositoDetalle2.TipoOperacion = "2"
        oeDepositoDetalle2.IdDeposito = griListaDeposito.ActiveRow.Cells("Id").Value
        With griDepositoDetalle
            .DataSource = olDepositoDetalle.Listar(oeDepositoDetalle2)
            .ResetDisplayLayout()
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdDeposito").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdMovimientoFlete").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdOperacionDetalle").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
            .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
            .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 1
            .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 2
            .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 3
            .DisplayLayout.Bands(0).Columns("Carga").Header.VisiblePosition = 4
            .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 5
            .DisplayLayout.Bands(0).Columns("Flete").Header.VisiblePosition = 6
            .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 7
            .DisplayLayout.Bands(0).Columns("Viaje").Width = 90
            .DisplayLayout.Bands(0).Columns("Cliente").Width = 287
            .DisplayLayout.Bands(0).Columns("Trabajador").Width = 287
            .DisplayLayout.Bands(0).Columns("Fecha").Style = ColumnStyle.Date
            .DisplayLayout.Bands(0).Columns("Flete").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
            .DisplayLayout.Bands(0).Columns("Flete").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        End With
    End Sub

    Private Sub txtNumeroDeposito_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroDeposito.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Guardar()
        End If
    End Sub

    Private Sub frm_Depositos_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Eventos"

    Private Sub ListarDeposito()
        Try
            If ficDeposito.Tabs(0).Selected Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                oeDeposito.FechaDesde = fecDepoDesde.Value
                oeDeposito.FechaHasta = fecDepoHasta.Value
                With griListaDeposito
                    .ResetLayouts()
                    .DataSource = olDeposito.Listar(oeDeposito)

                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCuentaBancaria").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdBanco").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Banco").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("NumeroCuenta").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 5

                    .DisplayLayout.Bands(0).Columns("Moneda").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 7

                    .DisplayLayout.Bands(0).Columns("Fecha").Style = ColumnStyle.Date
                    .DisplayLayout.Bands(0).Columns("Total").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                    .DisplayLayout.Bands(0).Columns("Banco").Width = 200
                    .DisplayLayout.Bands(0).Columns("NumeroCuenta").Width = 150
                    .DisplayLayout.Bands(0).Columns("Numero").Width = 120
                    .DisplayLayout.Bands(0).Columns("Fecha").Width = 120
                    .DisplayLayout.Bands(0).Columns("Viaje").Width = 120
                    .DisplayLayout.Bands(0).Columns("Moneda").Width = 50
                    .DisplayLayout.Bands(0).Columns("Total").Width = 100

                    .DisplayLayout.Bands(0).Columns("Total").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))

                    .DisplayLayout.Bands(0).Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
                    .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro
                    .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.Bands(0).Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton

                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)

                End With
                ugb_Espera.Visible = False
                CalcularTotales(griListaDeposito, "Total")
            Else
                Exit Sub
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Function GuardarDeposito() As Boolean
        Try
            With oeDeposito
                .TipoOperacion = "I"
                .Numero = txtNumeroDeposito.Text
                .Fecha = FecFechaDeposito.Value
                .Glosa = txtGlosaDeposito.Text
                .IdCuentaBancaria = cboCuentaBancaria.Value
                .Total = decImporteDeposito.Value
                .UsuarioCreacion = gUsuarioSGI.Id
                .FechaCreacion = Date.Now
                .Activo = True
                .loDepositoDetalle = loDepositoDetalle
            End With
            If Me.decImporteDeposito.Value = 0.0 Then

            Else
                If IndFleOpe = False Then
                    If oeDeposito.Total > griDetalleDeposito.Rows(0).Cells("SaldoPorDepositar").Value Then
                        mensajeEmergente.Problema("El Importe a Depositar No Puede ser Mayor al Saldo por Depositar")
                        griDetalleDeposito.Rows(0).Cells("Importe").Value = griDetalleDeposito.Rows(0).Cells("SaldoPorDepositar").Value
                        CalTotales()
                        Return False
                    End If
                End If
                oeDeposito.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olDeposito.Guardar(oeDeposito) Then
                    If IndFleOpe Then
                        If oeMovGrupo.IdCuentaCorrienteDestino <> "" Then
                            oeMovGrupo.Ingreso = Me.decImporteDeposito.Value
                            oeMovGrupo.Egreso = 0
                            oeMovGrupo.Glosa = "DEPOSITO DE FLETE DEL GRUPO: " & cboGrupo.Text & " Viaje: " & griDetalleDeposito.Rows(0).Cells("Viaje").Value
                            oeMovGrupo.Saldo = 0
                            oeMovGrupo.Descuento = 0
                            oeMovGrupo.TipoTransa = 5
                            oeMovGrupo.Fecha = Me.FecFechaDeposito.Value
                            oeMovGrupo.TipoProceso = "AMPLIACION"
                            oeMovGrupo.TipoOperacion = "I"
                            oeMovGrupo.UsuarioCreacion = gUsuarioSGI.Id
                            oeMovGrupo.PrefijoID = gs_PrefijoIdSucursal '@0001
                            If olMovimiento.Guardar(oeMovGrupo, New e_Movimiento) Then
                                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                                Return True
                            End If
                        End If
                    Else
                        Dim oeOpeDet As New e_OperacionDetalle
                        oeOpeDet.TipoOperacion = "S"
                        oeOpeDet.Id = idOpeDet
                        oeOpeDet.SaldoCarga = Me.decImporteDeposito.Value
                        oeOpeDet.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olOperacion.GuardarOperacionDetalle(oeOpeDet) Then
                            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                            idOpeDet = ""
                        End If
                    End If
                    MostrarTabs(1, ficDeposito, 0)
                    griListaDeposito.Focus()
                    Return True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub CargarCuentaBancaria()
        Try
            Dim oeCtaCte As New e_CuentaBancaria
            Dim olCtaCte As New l_CuentaBancaria
            oeCtaCte.Activo = 1
            LlenarCombo(cboCuentaBancaria, "BancoCuenta", olCtaCte.Listar(oeCtaCte), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LimpiarDeposito(ByVal Activo As Boolean)
        txtNumeroDeposito.Text = String.Empty
        decImporteDeposito.Value = Decimal.Zero
        If Activo = False Then
            FecFechaDeposito.Value = Date.Now
            cboCuentaBancaria.SelectedIndex = -1
            txtGlosaDeposito.Text = String.Empty
        End If
        loDepositoDetalle.clear()
        griDepositoDetalle.DataSource = Nothing
        griDetalleDeposito.DataSource = Nothing
        griOrigenDatoDeposito.DataSource = Nothing
        If Me.txtOperacionBuscar.Text <> "" Then
            ListarFletes()
        Else
            txtOperacionBuscar.Text = String.Empty
            btnListarFletes.PerformClick()
        End If
    End Sub

    Private Sub ListarFletes()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griDetalleDeposito.Rows.Count > 0 Then
                mensajeEmergente.Problema("Primero retire los depositos de flete en el detalle")
            Else
                If cboGrupo.SelectedIndex = -1 And Me.txtOperacionBuscar.Text = String.Empty Then
                    Exit Sub
                Else
                    If cboGrupo.SelectedIndex >= 0 Then
                        verDepositoDirecto.Visible = False
                        verDepositoDirecto.Checked = False
                        FleteGrupo = True
                        IndFleOpe = True
                        ListarOrigenFletes(FleteGrupo, cboGrupo.Value)
                    Else
                        verDepositoDirecto.Visible = True
                        verDepositoDirecto.Checked = False
                        FleteGrupo = False
                        IndFleOpe = False
                        ListarOrigenFletes(FleteGrupo, Me.txtOperacionBuscar.Text)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try    
    End Sub

    Private Sub ListarOrigenFletes(Optional ByVal Grupo As Boolean = False, Optional ByVal Id As String = "")
        Try
            Dim oeMovimientoFlete As New e_Movimiento_Flete
            Dim olMovimientoFlete As New l_Movimiento_Flete
            If Grupo Then
                oeMovimientoFlete.TipoOperacion = "3"
            Else
                oeMovimientoFlete.TipoOperacion = "6"
            End If
            oeMovimientoFlete.IdOperacionDetalle = Id
            With griOrigenDatoDeposito
                .ResetDisplayLayout()
                .DataSource = olMovimientoFlete.Listar(oeMovimientoFlete)
                .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOperacionDetalle").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCheque").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
                .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                .DisplayLayout.Bands(0).Columns("NumeroCheque").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoCobro").Hidden = True
                .DisplayLayout.Bands(0).Columns("Origen").Hidden = True
                .DisplayLayout.Bands(0).Columns("Destino").Hidden = True
                .DisplayLayout.Bands(0).Columns("Cobrado").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
                .DisplayLayout.Bands(0).Columns("Cliente").Hidden = True
                .DisplayLayout.Bands(0).Columns("Carga").Hidden = False
                .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True
                If Grupo Then
                    .DisplayLayout.Bands(0).Columns("Importe").Hidden = False
                Else
                    .DisplayLayout.Bands(0).Columns("Importe").Hidden = True
                End If
                .DisplayLayout.Bands(0).Columns("Viaje").Width = 110
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 280
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
                .DisplayLayout.Bands(0).Columns("Carga").Width = 110
                .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Flete").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Cargado").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Depositado").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Fecha").Style = ColumnStyle.Date
                .DisplayLayout.Bands(0).Columns("Flete").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Cargado").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Depositado").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Flete").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Cargado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Depositado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                .DisplayLayout.Bands(0).Columns("Cargado").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                .DisplayLayout.Bands(0).Columns("Viaje").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Trabajador").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Fecha").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Flete").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Cargado").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Depositado").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Viaje").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Fecha").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Flete").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Cargado").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Depositado").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub AgregarFlete(ByVal oe As e_DepositoDetalle, ByVal o_Fila As UltraGridRow)
        Try
            If Not loDepositoDetalle.Contains(oe) Then
                If o_Fila.Cells("Cargado").Value = 0 And verDepositoDirecto.Checked = False Then
                    mensajeEmergente.Problema("Saldo Cargado es 0,puede realizar un depósito directo")
                    o_Fila.Cells("Selec").Value = False
                Else
                    oe.IdDeposito = oeDeposito.Id
                    oe.Viaje = o_Fila.Cells("Viaje").Value
                    oe.Trabajador = o_Fila.Cells("Trabajador").Value
                    oe.Fecha = o_Fila.Cells("Fecha").Value
                    oe.Flete = o_Fila.Cells("Flete").Value
                    oe.Importe = o_Fila.Cells("SaldoPorDepositar").Value
                    oe.SaldoPorDepositar = o_Fila.Cells("SaldoPorDepositar").Value
                    oe.Carga = o_Fila.Cells("Carga").Value
                    oe.Cliente = o_Fila.Cells("Cliente").Value
                    oe.Glosa = String.Empty
                    oe.UsuarioCreacion = gUsuarioSGI.Id
                    oe.FechaCreacion = Date.Now
                    oe.IdMovimiento = o_Fila.Cells("IdMovimiento").Value
                    oe.IdGrupo = o_Fila.Cells("IdOperacionDetalle").Value
                    If griDetalleDeposito.Rows.Count < 1 Then LlenarGrupoDetalle(loDepositoDetalle)
                    loDepositoDetalle.Add(oe)
                    If IndFleOpe Then
                        griDetalleDeposito.DisplayLayout.Bands(0).Columns("Importe").CellActivation = Activation.NoEdit
                    Else
                        griDetalleDeposito.DisplayLayout.Bands(0).Columns("Importe").CellActivation = Activation.AllowEdit
                    End If
                End If
            Else
                If oe.TipoOperacion = "E" Then
                    oe.TipoOperacion = ""
                    For Each fila As UltraGridRow In griDetalleDeposito.Rows
                        If fila.Cells("Id").Value = oe.IdMovimientoFlete Then
                            fila.Hidden = False
                            Exit For
                        End If
                    Next
                Else
                    griOrigenDatoDeposito.ActiveRow.Cells("Selec").Value = False
                    Throw New Exception("El Flete : " & o_Fila.Cells("Flete").Value & " ya esta Asignado")
                End If
            End If
            CalTotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarGrupoDetalle(ByVal Lista As List(Of e_DepositoDetalle))
        Try
            With griDetalleDeposito
                .ResetDisplayLayout()
                .DataSource = Lista
                .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdDeposito").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMovimientoFlete").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOperacionDetalle").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 200
                .DisplayLayout.Bands(0).Columns("Importe").Width = 80
                .DisplayLayout.Bands(0).Columns("Viaje").Width = 200

                .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Flete").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Carga").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 8

                .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Flete").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Flete").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Fecha").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("Carga").CellAppearance.TextHAlign = HAlign.Center

                .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))

                .DisplayLayout.Bands(0).Columns("Viaje").MergedCellStyle = MergedCellStyle.Always
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex

                For Each Columna As UltraGridColumn In griDetalleDeposito.DisplayLayout.Bands(0).Columns
                    If Not Columna.Key = "Importe" Then Columna.CellClickAction = CellClickAction.RowSelect : Columna.CellActivation = Activation.NoEdit
                Next

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalTotales()
        decImporteDeposito.Value = 0.0
        For Each DepositoDetalle As e_DepositoDetalle In loDepositoDetalle
            decImporteDeposito.Value += DepositoDetalle.Importe
        Next
    End Sub

    Private Sub QuitarFlete(ByVal oe As e_DepositoDetalle, ByVal o_Fila As UltraGridRow)
        Try
            If Me.txtOperacionBuscar.Text <> "" Then
                oe.IndFleOpe = 2
            Else
                oe.IndFleOpe = 1
            End If
            oe.Id = griOrigenDatoDeposito.ActiveRow.Cells("Id").Value.ToString
            If oe.Id <> "" Then
                loDepositoDetalle.Remove(oe)
                griDetalleDeposito.DataSource = loDepositoDetalle
                griDetalleDeposito.DataBind()
            End If
            CalTotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarGrupoFletes()
        Dim loGrupo As New List(Of e_Grupo)
        Dim oeGrupo As New e_Grupo
        Dim olGrupo As New l_Grupo
        oeGrupo = New e_Grupo
        oeGrupo.TipoOperacion = "8"
        oeGrupo.Tipo = 3
        oeGrupo.Estado = "ENVIADO"
        oeGrupo.Activo = True
        loGrupo.AddRange(olGrupo.Listar(oeGrupo))
        LlenarCombo(cboGrupo, "Codigo", loGrupo, -1)
    End Sub

    Private Sub CargarCombosDeposito()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            oeMoneda.Activo = True
            LlenarCombo(cboMoneda, "Abreviatura", olMoneda.Listar(oeMoneda), 0)
            CargarCuentaBancaria()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub MenuContextualDeposito_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextualDeposito.Opening
        MenuContextualDeposito.Items("MnuNuevoDeposito").Visible = True
        MenuContextualDeposito.Items("MnuEliminarDeposito").Visible = False
        MenuContextualDeposito.Items("MnuVerDetalle").Visible = False
        If griListaDeposito.Rows.Count > 0 Then
            'MenuContextualDeposito.Items("MnuEliminarDeposito").Visible = True
            MenuContextualDeposito.Items("MnuVerDetalle").Visible = True
        End If
    End Sub

#End Region

End Class