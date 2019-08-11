Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_BuscarViajes
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_BuscarViajes = Nothing
    Private Shared Operacion As String
    Public CodigoViaje As String = String.Empty

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_BuscarViajes()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"


    Dim olCombo As l_Combo
    Dim oeCombo As e_Combo
    Dim oeViaje As e_Viaje
    Dim olOperacion As l_Operacion
    Dim oeUsuario As e_Usuario
    Dim olPrefijo As l_Configuracion
    Dim PrefijoId As String = ""
    Dim FechaServidor As Date = Now.Date
#End Region

#Region "Métodos"

    Public Sub IniciarFiltros()
        Try
            olPrefijo = New l_Configuracion
            PrefijoId = olPrefijo.PrefijoID
            FechaServidor = ObtenerFechaServidor()
            ColorControles()
            'fecViaje.Value = FechaServidor.Date
            'hViaje.Value = TimeOfDay.ToShortTimeString
            oeUsuario = New e_Usuario
            Dim ListaUsuario As New List(Of e_Usuario)
            oeUsuario.Id = gUsuarioSGI.Id
            oeUsuario.Login = gUsuarioSGI.Login
            ListaUsuario.Add(oeUsuario)
            oeUsuario = New e_Usuario
            oeUsuario.Id = ""
            oeUsuario.Login = "TODOS"
            ListaUsuario.Add(oeUsuario)
            LlenarComboMaestro(cboUsuario, ListaUsuario, 1)

            'olLugar = New l_Lugar
            'oeLugar = New e_Lugar
            'oeLugar.TipoOperacion = "O"
            'LlenarComboMaestro(cboRutaOrigen, olLugar.Listar(oeLugar), -1)
            LlenaCombos()
            ControlRangoFechaInicializa()
            '     CargarActividadesRestringidas()
            cboCentro.Value = PrefijoId
            'If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.Consolidado.ToString And
            '                                     item.AccionSistema = gAccionSistema.ACTUALIZAR.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count > 0 Then
            '    griViajeDetalle.DisplayLayout.Bands(0).Columns("Consolidado").CellClickAction = CellClickAction.EditAndSelectText
            'End If
            CargarActividadesRestringidas()
            ''ValorIgv = ObtenerIGV()

            'cargar tractos y carretas
            TractoPublic = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "Tracto"
            TractoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

            CarretaPublic = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "Carreta"
            CarretaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ColorControles()
        '----------------------------------------------
        '------Tipo de Vehiculo------------------------
        ColorPlataforma.Color = Color.Coral
        ColorFurgonLargo.Color = Color.PeachPuff
        ColorMediaBaranda.Color = Color.Orange
        ColorFurgon.Color = Color.Gold
        ColorCalicera.Color = Color.DarkKhaki
        ColorContenedor.Color = Color.OliveDrab
        ColorGranelero.Color = Color.YellowGreen
        ColorParihuelero.Color = Color.PaleGreen
        ColorTolvaVolteo.Color = Color.RosyBrown
        ColorVolquete.Color = Color.Peru
        ColorCamioneta.Color = Color.LightGreen
        ColorCamion65M3.Color = Color.MediumSpringGreen
        ColorCamion20M3.Color = Color.PaleTurquoise
        ColorCamion30M3.Color = Color.DeepSkyBlue
        ColorCamion40M3.Color = Color.Violet
        '----------------------------------------------
        '------Estados de Viaje------------------------
        ColorProgramado.Color = Color.White
        ColorCarga.Color = Color.Yellow
        ColorTransito.Color = Color.DarkOrange
        ColorDescarga.Color = Color.Silver
        ColorFin.Color = Color.LimeGreen
        '----------------------------------------------
        '------Cambio de Registro------------------------
        colorCambio.Color = Color.Cyan
        '----------------------------------------------
        '------Carga Consolidada-----------------------
        colorCargaConsolidada.Color = Color.SaddleBrown
    End Sub

    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = FechaServidor.AddDays(-5)
        fecHasta.Value = FechaServidor.AddDays(+1)
    End Sub

#End Region

    Private Sub frm_BuscarViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IniciarFiltros()
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

    Public Sub LlenaCombos()
        olCombo = New l_Combo
        oeCombo = New e_Combo

        Dim IdOrigen As String = ""
        'LlenarComboMaestro(cboTipoVehiculo, ModeloFuncionalPublic, -1)

        'LlenarComboMaestro(cboOrigen, LugaresPublic, 0)
        'LlenarComboMaestro(cboDestino, LugaresPublic, 0)
        'LlenarComboMaestro(cboEscala, LugaresPublic, -1)
        'LlenarComboMaestro(cboEscalaBloque, LugaresPublic, -1)

        'LlenarComboMaestro(cboPiloto, PilotoPublic.Where(Function(Item) Item.Descripcion = True).ToList, -1)
        LlenarComboMaestro(cboPilotoLista, PilotoPublic, -1)

        'LlenarComboMaestro(cboCopiloto, CopilotoPublic.Where(Function(Item) Item.Descripcion = True).ToList, 0)

        'LlenarComboMaestro(cboAyudante, AyudantePublic.Where(Function(Item) Item.Descripcion = True).ToList, 0)

        LlenarCombo(cboTractoLista, "Nombre", TractoPublic, -1)
        'LlenarCombo(cboTracto, "Nombre", TractoPublic.Where(Function(Item) Item.Descripcion = 1 Or Item.Descripcion = 3).ToList, -1)
        'LlenarCombo(cboVehiculoDisponible, "Nombre", TractoPublic, -1)
        'LlenarCombo(cboTractoPeso, "Nombre", TractoPublic, -1)

        'LlenarCombo(cboCarreta, "Nombre", CarretaPublic, -1)
        'LlenarCombo(cboCarretaPeso, "Nombre", CarretaPublic, -1)
        LlenarCombo(cboCarretaLista, "Nombre", CarretaPublic, -1)

        'LlenarComboMaestro(cboCliente, ClientesPublic, -1)
        'LlenarComboMaestro(cboClienteFinal, ClientesPublic, -1)


        'LlenarComboMaestro(cboComisionista, ComisionistasPublic, -1)

        'LlenarComboMaestro(cboTipoCarga, TipoCargaPublic, -1)

        'LlenarComboMaestro(cboMaterial, MaterialesPublic.Where(Function(item) item.Descripcion = "OPERACIONESC").ToList, -1)

        'LlenarCombo(cboMoneda, "Nombre", MonedaPublic, 0)

        LlenarComboMaestro(cboZona, ZonaPublic, 0)
        'LlenarComboMaestro(cboZonaDemanda, ZonaPublic, 0)
        'LlenarComboMaestro(cboZonaDisponibles, ZonaPublic, 0)
        LlenarComboMaestro(cboCentro, CentroPublic, 0)

        OperacionesPublic = New List(Of e_Combo)
        oeCombo.Id = ""
        oeCombo.Nombre = ""
        OperacionesPublic.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "VENTAS"
        OperacionesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        'LlenarComboMaestro(cboActividadNegocio, OperacionesPublic, 0)


        'ListTercero = New List(Of e_Combo)
        'oeCombo = New e_Combo
        'oeCombo.Nombre = "Transportista"
        'ListTercero.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        'LlenarComboMaestro(cboTercero, ListTercero, 1)

        'LlenarComboMaestro(cboContacto, ComisionistasPublic, -1)
        ''  cboContacto.Text = "NINGUNO  ,"
        'LlenarCombo(cboMonedaT, "Nombre", MonedaPublic, 0)
        ''Carga Flota
        'LlenarComboMaestro(cboFlota, FlotaPublic, 0)
        'bolMarcarTodos = True
        'cboFlota.SetCheckState(CheckState.Checked)
    End Sub

    Public Sub Listar(Tipo As String, ByVal griLista As UltraWinGrid.UltraGrid)
        Try
            Dim cont As Integer = 0
            ugb_Espera.Visible = True
            ' Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olOperacion = New l_Operacion
            With oeViaje
                .TipoOperacion = Tipo
                .ViajeVacio = 2
                .FechaDesde = fecDesde.Value.ToString
                .FechaHasta = fecHasta.Value.ToString
                .UsuarioCreacion = cboUsuario.Value
                .Zona = cboZona.Value
                .Centro = cboCentro.Value
                .IdPiloto = Me.cboPilotoLista.Value
                If verTracto.Checked = True Then
                    .IndMotriz = 1
                    .IdTracto = cboTractoLista.Value
                Else
                    If verCarretaLista.Checked = True Then
                        .IndMotriz = 0
                        .IdTracto = cboCarretaLista.Value
                    End If
                End If
                'If Tipo = "A" Then
                '    If opcDesenganches.CheckedIndex = 0 Then
                '        .FechaDesde = ""
                '        .FechaHasta = ""
                '        .ViajeVacio = 3
                '    End If
                'End If
                'If Tipo = "N" Then
                '    If cboFlota.Value IsNot Nothing Then
                '        Dim Flotas As String = ""
                '        Dim CantidadItems As Integer = CType(cboFlota.Value, List(Of Object)).Count
                '        If CantidadItems = 1 Then
                '            Flotas = Flotas & CType(cboFlota.Value, List(Of Object))(0).ToString()
                '        Else
                '            For index = 0 To CantidadItems - 1
                '                If index = CantidadItems - 1 Then
                '                    Flotas = Flotas & CType(cboFlota.Value, List(Of Object))(index).ToString()
                '                Else
                '                    Flotas = Flotas & CType(cboFlota.Value, List(Of Object))(index).ToString() & "','"
                '                End If
                '            Next
                '        End If
                '        .IdOrigen = Flotas
                '    End If
                'End If
                'If Tipo = "V" Then
                '    If Me.opTractoCarreta.CheckedIndex = 0 Then
                '        .IndMotriz = 1                    
                '    Else
                '        .IndMotriz = 0
                '    End If
                '    '  .IdTracto = cboTractoCarreta.Value                  
                'End If
            End With
            Dim codDestino As String = ""
            Dim codigoTractoC As String = ""
            Dim i As Integer = 0
            '.OrderBy(Function(Item) Item.Fecha)
            Dim listaNueva As New List(Of e_Viaje)
            '    griLista.DataSource = olOperacion.ListarViaje(oeViaje)
            Dim indiceTC As String = "T"
            griLista.DataSource = olOperacion.ListarViaje(oeViaje)

            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows

                Select Case fila.Cells("Estado").Value
                    Case "PROGRAMADO"
                        fila.CellAppearance.BackColor = Me.ColorProgramado.Color
                    Case "CARGA"
                        fila.CellAppearance.BackColor = Me.ColorCarga.Color
                    Case "TRANSITO"
                        fila.CellAppearance.BackColor = Me.ColorTransito.Color
                    Case "DESCARGA"
                        fila.CellAppearance.BackColor = Me.ColorDescarga.Color
                    Case "FIN"
                        fila.CellAppearance.BackColor = Me.ColorFin.Color
                End Select

                Select Case fila.Cells("TipoVehiculo").Value
                    Case "PLATAFORMA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorPlataforma.Color
                    Case "FURGON"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgon.Color
                    Case "GRANELERO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorGranelero.Color
                    Case "FURGON LARGO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgonLargo.Color
                    Case "CONTENEDOR"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorContenedor.Color
                    Case "CAMION 20 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion20M3.Color
                    Case "CAMION 40 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion40M3.Color
                    Case "VOLQUETE"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorVolquete.Color
                    Case "CALICERA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCalicera.Color
                    Case "TOLVA DE VOLTEO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorTolvaVolteo.Color
                    Case "MEDIA BARANDA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorMediaBaranda.Color
                    Case "CAMIONETA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamioneta.Color
                    Case "CAMION 30 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion30M3.Color
                    Case "CAMION 50 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
                    Case "CAMION 65 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
                End Select
                If fila.Cells("Carga").Value > 1 Then
                    fila.Cells("Carga").Appearance.BackColor = Me.colorCargaConsolidada.Color
                End If

            Next
            'End If
            'Ubica el cursor el el primer registro de la grilla
            If griLista.Rows.Count > 0 Then
                griLista.Focus()
                griLista.Rows.Item(0).Activated = True
            End If

            If gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Or gUsuarioSGI.oeArea.Nombre = gNombreAreaSeguridadMedioAmbiente Then
                If griLista.Rows.Count > 0 Then
                    If Tipo = "0" Or Tipo = "A" Then
                        CalcularTotales(griLista, "TotalFlete", "Produccion")
                    Else
                        If Tipo = "T" Then
                            CalcularTotales(griLista, "FleteUnitario", "TotalFlete", "KmTractoOrigen", "KmTractoDestino", "KmCarretaOrigen", "KmCarretaDestino", "PorcentajeFlete", "Produccion")
                        End If
                    End If
                Else

                End If
            Else
                If Tipo = "0" Or Tipo = "A" Then
                    CalcularTotales(griLista, "TotalFlete", "Produccion")
                Else
                    If Tipo = "T" Then
                        CalcularTotales(griLista, "FleteUnitario", "TotalFlete", "KmTractoOrigen", "KmTractoDestino", "KmCarretaOrigen", "KmCarretaDestino", "PorcentajeFlete", "Produccion")
                    End If
                End If

            End If
            'InicializaTiempo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub verTracto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTracto.CheckedChanged
        If verTracto.Checked Then
            cboTractoLista.Enabled = verTracto.Checked
            verCarretaLista.Checked = False
            cboTractoLista.Focus()
        Else
            cboTractoLista.Enabled = verTracto.Checked
            cboTractoLista.Text = ""
        End If
    End Sub

    Private Sub verCarretaLista_CheckedChanged(sender As Object, e As EventArgs) Handles verCarretaLista.CheckedChanged
        If verCarretaLista.Checked Then
            cboCarretaLista.Enabled = verCarretaLista.Checked
            verTracto.Checked = False
            cboCarretaLista.Focus()
        Else
            cboCarretaLista.Enabled = verCarretaLista.Checked
            cboCarretaLista.Text = ""
        End If
    End Sub

    Private Sub verPilotoLista_CheckedChanged(sender As Object, e As EventArgs) Handles verPilotoLista.CheckedChanged
        If verPilotoLista.Checked Then
            cboPilotoLista.Enabled = verPilotoLista.Checked
            cboPilotoLista.Focus()
        Else
            cboPilotoLista.Enabled = verPilotoLista.Checked
            cboPilotoLista.Text = ""
        End If
    End Sub


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                oeViaje = New e_Viaje
                LimpiaGrid(griLista, ogdListaOperacion)
                Listar("0", griLista)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Try
            If griLista.Selected.Rows.Count = 1 Then
                CodigoViaje = griLista.ActiveRow.Cells("Id").Value
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
End Class