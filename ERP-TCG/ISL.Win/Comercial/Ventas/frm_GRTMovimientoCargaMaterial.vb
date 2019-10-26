'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Public Class frm_GRTMovimientoCargaMaterial
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_GRTMovimientoCargaMaterial = Nothing
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
            instancia = New frm_GRTMovimientoCargaMaterial()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeFechas As New e_Fechas

    Dim _ingresando_datos As Boolean = False

    Dim Prefijo As New l_Configuracion
    Dim oeViaje As New e_Viaje
    Dim olOperacion As New l_Operacion
    Dim oeOperacion As New e_Operacion
    Dim ListaRemitenteLista As New List(Of e_Combo)
    Dim oeGuiaTransportista As New e_GuiaTransportista
    Dim olGuiaTransportita As New l_GuiaTransportista

    Dim olCombo As l_Combo
    Dim oeCombo As e_Combo
#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            'Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                Listar()
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Try
                If gUsuarioSGI.oeArea.Nombre = "OPERACIONES" Or gUsuarioSGI.oeArea.Nombre = "SISTEMAS" Then
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    Operacion = "Editar"
                    Inicializar()
                   
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                End If
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            Finally
                Windows.Forms.Cursor.Current = Cursors.Default
                Cursor.Show()
            End Try
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            If gUsuarioSGI.oeArea.Nombre = "OPERACIONES" Or gUsuarioSGI.oeArea.Nombre = "SISTEMAS" Then
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                Operacion = "Nuevo"
                Inicializar()
                
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMovimientoMermas() Then
                MostrarTabs(0, ficCtrlMerma, 2)
                MyBase.Consultar()
            Else
                Exit Sub
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
                    If GuardarMovimientoMermas() Then
                        MostrarTabs(0, ficCtrlMerma, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                    Else
                        _ingresando_datos = True
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficCtrlMerma, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                Case Windows.Forms.DialogResult.Cancel
                    _ingresando_datos = True
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
        Catch ex As Exception
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case tabLista.SelectedTab.Index
                Case 0
                    If griListaGrt.Rows.Count > 0 Then
                        Exportar_Excel(griListaGrt)
                    End If
                Case 1
                    If griGrtCargaMaterial.Rows.Count > 0 Then
                        Exportar_Excel(griGrtCargaMaterial)
                    End If
            End Select
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try

            ControlBoton(1, 0, 0, 0, 0, 0, 1, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_GRTMovimientoCargaMaterial_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_GRTMovimientoCargaMaterial_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case ficCtrlMerma.SelectedTab.Index
            Case 0
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                Select Case tabLista.SelectedTab.Index
                    Case 2
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    Case 3
                        ControlBoton(1, 0, 0, 0, 0, 0, 1, 0, 1)
                End Select
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_GRTMovimientoCargaMaterial_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_GRTMovimientoCargaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LlenaCombos()
            ComboGrilla()
            ControlRangoFechaInicializa()
            cboCentro.Value = gs_PrefijoIdSucursal '@0001
            ListaStockAlmacenes()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verTracto_CheckedChanged(sender As Object, e As EventArgs) Handles verTracto.CheckedChanged
        If verTracto.Checked Then
            cboTractoLista.Enabled = verTracto.Checked
            cboTractoLista.Focus()
        Else
            cboTractoLista.Enabled = verTracto.Checked
            cboTractoLista.Text = ""
        End If
    End Sub

    Private Sub cboRemitenteBusca_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboRemitenteBusca.InitializeLayout
        With cboRemitenteBusca.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Width = 400
            .Columns("Descripcion").Hidden = True
        End With
    End Sub

    Private Sub cboRemitenteBusca_KeyDown(sender As Object, e As KeyEventArgs) Handles cboRemitenteBusca.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboRemitenteBusca.Text.Trim = "" Then
                cboRemitenteBusca.DataSource = Nothing
                cboRemitenteBusca.DataSource = ClientesPublic
            Else
                cboRemitenteBusca.DataSource = Nothing
                ListaRemitenteLista = ClientesPublic
                cboRemitenteBusca.DataSource = ListaRemitenteLista.Where(Function(Item) Item.Nombre.Contains(cboRemitenteBusca.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboRemitenteBusca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboRemitenteBusca.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboRemitenteBusca.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        If txtSerie.Text <> "" Then
            txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If txtNumero.Text <> "" Then
            txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
        End If
    End Sub

    Private Sub griListaGrt_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaGrt.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Function ValidarStock()


        Return True
    End Function

    Private Sub griListaGrt_ClickCellButton(sender As Object, e As CellEventArgs) Handles griListaGrt.ClickCellButton
        Try
            Dim StockM As Decimal = 0
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If griListaGrt.ActiveRow.Cells("IndCarga").Value = 0 Then
                If griListaGrt.ActiveRow.Cells("Cantidad").Value > 0 Then
                    If griListaGrt.ActiveRow.Cells("IdDestino").Value <> "" Then
                        oeGuiaTransportista = New e_GuiaTransportista
                        With oeGuiaTransportista
                            .TipoOperacion = "P"
                            .Id = RTrim(griListaGrt.ActiveRow.Cells("Id").Value)
                            .IdSeguimiento = griListaGrt.ActiveRow.Cells("IdEscala").Value
                            .IdRemitente = griListaGrt.ActiveRow.Cells("CargaMaterial").Value
                            .IdDireccionLugarPartida = griListaGrt.ActiveRow.Cells("IdOrigen").Value
                            .IdDestinatario = griListaGrt.ActiveRow.Cells("IdDestino").Value
                            .Fecha = griListaGrt.ActiveRow.Cells("LlegadaOrigen").Value
                            .Cantidad = griListaGrt.ActiveRow.Cells("Cantidad").Value
                            .PesoToneladas = griListaGrt.ActiveRow.Cells("PesoToneladas").Value
                            .Glosa = griListaGrt.ActiveRow.Cells("Tesoreria").Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                        End With
                        Select Case e.Cell.Column.Key
                            Case "Zona" 'Ingreso de Carga Material
                                oeGuiaTransportista.IndFacturado = 1
                                griListaGrt.ActiveRow.Cells("IndCarga").Value = 1
                            Case "IncidenciaOperaciones" 'Salida de Carga Material
                                oeGuiaTransportista.IndFacturado = 2
                                For Each Material As Infragistics.Win.UltraWinGrid.UltraGridRow In griStockAlmacen.Rows.Where(Function(item) item.Cells("IdMaterial").Value = oeGuiaTransportista.IdRemitente And item.Cells("IdLocalAlmacen").Value = oeGuiaTransportista.IdDestinatario).ToList
                                    StockM = CDec(Material.Cells("Stock").Value)
                                Next
                                If oeGuiaTransportista.Cantidad > StockM Then
                                    Throw New Exception("Verifica Stock del Material en Local Almacen")
                                End If
                                griListaGrt.ActiveRow.Cells("IndCarga").Value = 2
                        End Select
                        oeGuiaTransportista.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olGuiaTransportita.Guardar(oeGuiaTransportista)
                    Else
                        Throw New Exception("Seleccione Local Almacen")
                    End If
                Else
                    Throw New Exception("La Cantidad de I/S mayor a cero")
                End If
            Else
                Throw New Exception("La GRT ya fue I/S seleccione otra")
            End If
            Select Case e.Cell.Column.Key
                Case "Zona" 'Ingreso de Carga Material
                    griListaGrt.ActiveRow.CellAppearance.BackColor = Me.colorIngreso.Color

                Case "IncidenciaOperaciones" 'Salida de Carga Material
                    griListaGrt.ActiveRow.CellAppearance.BackColor = Me.colorSalida.Color

            End Select
            ListaStockAlmacenes()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griListaGrt_CellChange(sender As Object, e As CellEventArgs) Handles griListaGrt.CellChange
        griListaGrt.UpdateData()
    End Sub

    Private Sub frm_GRTMovimientoCargaMaterial_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griStockAlmacen_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griStockAlmacen.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griGrtCargaMaterial_CellChange(sender As Object, e As CellEventArgs) Handles griGrtCargaMaterial.CellChange
        griGrtCargaMaterial.UpdateData()
    End Sub

    Private Sub Extorno_Click(sender As Object, e As EventArgs) Handles Extorno.Click
        griGrtCargaMaterial.ActiveRow.Delete()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()

    End Sub

    Private Sub ComboGrilla()
        Dim Cliente As New DataTable
        Dim Material As New DataTable
        Dim Actividad As New DataTable
        Dim LocalAlmacen As DataTable
        olCombo = New l_Combo

        Cliente = olCombo.ComboGrilla(ClientesPublic)
        CrearComboGrid("Cliente", "Nombre", griListaGrt, Cliente, True)
        CrearComboGrid("IdEscala", "Nombre", griListaGrt, Cliente, True)
        CrearComboGrid("Escala", "Nombre", griListaGrt, Cliente, True)
        CrearComboGrid("IdRemitente", "Nombre", griGrtCargaMaterial, Cliente, True)

        Material = olCombo.ComboGrilla(MaterialesPublic)
        CrearComboGrid("CargaMaterial", "Nombre", griListaGrt, Material, True)
        CrearComboGrid("IdDestinatario", "Nombre", griGrtCargaMaterial, Material, True)
        CrearComboGrid("IdMaterial", "Nombre", griStockAlmacen, Material, True)

        Actividad = olCombo.ComboGrilla(OperacionesPublic)
        CrearComboGrid("IdOrigen", "Nombre", griListaGrt, Actividad, True)
        CrearComboGrid("IdMotivoDocumentoTraslado", "Nombre", griGrtCargaMaterial, Actividad, True)

        LocalAlmacen = olCombo.ComboGrillaEspecial(CentroPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList)
        CrearComboGrid("IdDestino", "Nombre", griListaGrt, LocalAlmacen, True)
        CrearComboGrid("IdSubContrata", "Nombre", griGrtCargaMaterial, LocalAlmacen, True)
        CrearComboGrid("IdLocalAlmacen", "Nombre", griStockAlmacen, LocalAlmacen, True)

    End Sub

    Public Sub LlenaCombos()
        Try
            olCombo = New l_Combo
            oeCombo = New e_Combo

            LlenarComboMaestro(cboRemitenteBusca, ClientesPublic, 0)
            LlenarCombo(cboTractoLista, "Nombre", TractoPublic, -1)
            LlenarComboMaestro(cboCentro, CentroPublic, 0)
            OperacionesPublic = New List(Of e_Combo)
            oeCombo.Id = ""
            oeCombo.Nombre = ""
            OperacionesPublic.Add(oeCombo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "VENTAS"
            OperacionesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarComboMaestro(cboActividadNegocio, OperacionesPublic, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If tabLista.Tabs(0).Selected Then
                oeViaje = New e_Viaje

                If verViajeRetorno.Checked Then
                    oeViaje.Activo = 1
                Else
                    oeViaje.Activo = 0
                End If
                With oeViaje
                    .TipoOperacion = "M"
                    .Serie = txtSerie.Text
                    .Numero = txtNumero.Text
                    .Remitente = cboRemitenteBusca.Value
                    .ViajeVacio = 2
                    .FechaDesde = fecDesde.Value
                    .FechaHasta = fecHasta.Value
                    .Centro = cboCentro.Value
                    .IndMotriz = 1
                    .IdTracto = cboTractoLista.Value
                End With

                griListaGrt.DataSource = olOperacion.ListarViaje(oeViaje)
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaGrt.Rows
                    Select Case fila.Cells("IndCarga").Value
                        Case 0
                            fila.CellAppearance.BackColor = colorDisponible.Color
                        Case 1
                            fila.CellAppearance.BackColor = colorIngreso.Color
                        Case 2
                            fila.CellAppearance.BackColor = colorSalida.Color
                    End Select
                Next
            Else
                If tabLista.Tabs(1).Selected Then
                    oeGuiaTransportista = New e_GuiaTransportista
                    With oeGuiaTransportista
                        .TipoOperacion = "P"
                        .Serie = txtSerie.Text
                        .Numero = txtNumero.Text
                        .IdRemitente = cboRemitenteBusca.Value
                        .FechaDesde = fecDesde.Value
                        .FechaHasta = fecHasta.Value
                    End With
                    griGrtCargaMaterial.DataSource = olGuiaTransportita.Listar(oeGuiaTransportista)
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGrtCargaMaterial.Rows
                        Select Case fila.Cells("IndFacturado").Value
                            Case 1
                                fila.CellAppearance.BackColor = colorIngreso.Color
                                fila.Cells("SubSerie").Value = fila.Cells("Cantidad").Value
                            Case 2
                                fila.CellAppearance.BackColor = colorSalida.Color
                                fila.Cells("SubNumero").Value = fila.Cells("Cantidad").Value
                        End Select
                    Next
                End If
                CalcularTotales(griGrtCargaMaterial, "SubSerie", "SubNumero")
            End If

            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub ListarAlmacenMermas()
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ugb_Espera.Visible = True

            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Function GuardarMovimientoMermas() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()


            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = Date.Today.AddDays(-5)
        fecHasta.Value = Date.Today.AddDays(+1)
    End Sub

    Private Sub ListaStockAlmacenes()
        LimpiaGrid(griStockAlmacen, ogdStockAlmacen)
        oeGuiaTransportista = New e_GuiaTransportista
        oeGuiaTransportista.TipoOperacion = "P"
        oeGuiaTransportista.IdVehiculo = "P"
        griStockAlmacen.DataSource = olGuiaTransportita.ListarInformeGrt(oeGuiaTransportista)
    End Sub

    Private Function EliminarGRTMovimiento() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If MessageBox.Show("Esta seguro de eliminar la GRT de I/S de Material: " & _
                                    griGrtCargaMaterial.ActiveRow.Cells("IdDestinatario").Text & " ?", _
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                oeGuiaTransportista.TipoOperacion = "A"
                oeGuiaTransportista.Id = griGrtCargaMaterial.ActiveRow.Cells("Viaje").Value
                olGuiaTransportita.Eliminar(oeGuiaTransportista)
            Else
                Return False
                Exit Function
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

#End Region

#Region "Menú contextual del maestro de Demandas rápidas"



#End Region


    Private Sub griGrtCargaMaterial_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griGrtCargaMaterial.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarGRTMovimiento() Then
                e.Cancel = False
                ListaStockAlmacenes()
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub
End Class