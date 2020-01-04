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

Public Class frm_Ruta
    Inherits frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#Region "Instancia"

    Private Shared instancia As frm_Ruta = Nothing

    ''' <summary>
    ''' Instancia unica de Formulario: frm_Demanda
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Ruta()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private Shared Operacion As String
    Private Estado As String
    Private oHebra As Thread
    Private oeRuta As New e_Ruta
    Private olRuta As New l_Ruta

    Private oeLugar As New e_Lugar
    Private olLugar As New l_Lugar
    Private ListaLugar As New List(Of e_Lugar)

    Private oeFlota As New e_Flota
    Private olFlota As New l_Flota
    Private ListaZona As New List(Of e_Flota)

    Private oeCentro As New e_Centro
    Private olCentro As New l_Centro
    Private ListaCentro As New List(Of e_Centro)

    Private oeTipoVehiculo As New e_TipoVehiculo
    Private olTipoVehiculo As New l_TipoVehiculo
    Private ListaTipoVehiculo As New List(Of e_TipoVehiculo)

    Private oeCliente As New e_Cliente
    Private olCliente As New l_Cliente
    Private ListaCliente As New List(Of e_Cliente)

    Private oeCombo As New e_Combo
    Private olCombo As New l_Combo

    Private oeTipoCarga As New e_TipoCarga
    Private olTipoCarga As New l_TipoCarga
    Private ListaTipoCarga As New List(Of e_TipoCarga)

    Private oeTiempoCiclo As New e_TiempoCiclo
    Private olTiempoCiclo As New l_TiempoCiclo

    Private oeFlete As New e_Flete
    Private olFlete As New l_Flete

    Private oeDistanciaZona As New e_DistanciaZona
    Private olDistanciaZona As New l_DistanciaZona

    Private oeMontoRuta As New e_MontoRuta
    Private olMontoRuta As New l_MontoRuta

    Private oeConceptoGasto As New e_ConceptoGasto
    Private olConceptoGasto As New l_ConceptoGasto
    Private ListaConceptoGasto As New List(Of e_ConceptoGasto)

    Private oeZonaD2 As New e_ZonaCombustible
    Private olZonaD2 As New l_ZonaCombustible
    Private loZonaD2 As New List(Of e_ZonaCombustible)

    Private oeBolsaViaje As New e_BolsaViaje
    Private olBolsaViaje As New l_BolsaViaje

    Dim _ingresando_datos As Boolean = False

    Dim BandCbo As Boolean = True

    Dim RutaOperacion As String = ""
    Dim RutaIdOrigen As String = ""
    Dim RutaIdDestino As String = ""
    Dim RutaOrigen As String = ""
    Dim RutaDestino As String = ""

    Private oeRutaPeaje As e_RutaPeaje
    Private olRutaPeaje As New l_RutaPeaje
    Private loRutaPeaje As New List(Of e_RutaPeaje)

    Dim olTrabajadorSeguridad As New l_TrabajadorSeguridad

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            'Tiempo1.Enabled = True
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            oeRuta.Activo = Activo
            If ficRutasMatenimiento.Tabs(0).Selected Then
                Listar()
                If griLista.Rows.Count > 0 Then
                    MyBase.Consultar(Activo)
                Else
                    MyBase.Consultar()
                End If
                griLista.Focus()
            End If

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
            Dim TiempoCiclo As New List(Of e_TiempoCiclo)
            Dim Flete As New List(Of e_Flete)
            Dim BolsaViaje As New List(Of e_BolsaViaje)
            Dim DistanciaZona As New List(Of e_DistanciaZona)
            Dim MontoRuta As New List(Of e_MontoRuta)
            Dim ZonaCombustible As New List(Of e_ZonaCombustible)
            Operacion = "Nuevo"
            Inicializar()
            'LlenaCombos()
            'ComboGrilla()
            cboOrigen.Enabled = True
            cboDestino.Enabled = True
            griTiempoCiclo.DataSource = TiempoCiclo
            griFlete.DataSource = Flete
            griBolsaViaje.DataSource = BolsaViaje
            griDistanciaZona.DataSource = DistanciaZona
            griMontoRuta.DataSource = MontoRuta
            griZonaCombustible.DataSource = ZonaCombustible
            MostrarTabs(1, ficRuta, 1)
            verLocal.Focus()
            MyBase.Nuevo()
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
            If griLista.Selected.Rows.Count > 0 Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                Operacion = "Editar"
                Inicializar()
                cboOrigen.Enabled = False
                cboDestino.Enabled = False
                If EditarRuta() Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                End If
                verLocal.Focus()
                ugb_Espera.Visible = False
            Else
                mensajeEmergente.Problema("Seleccione registro", True)
            End If
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
            If GuardarRuta() Then
                If BandCbo Then
                    'MostrarTabs(0, ficRuta, 2)
                    _Operacion = "Inicializa"
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    MyBase.Guardar()
                Else
                    Me.Close()
                End If
            Else
                MostrarTabs(1, ficRuta, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If BandCbo Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRuta() Then
                            MostrarTabs(0, ficRuta, 2)
                            _ingresando_datos = False
                            Operacion = "Inicializa"
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficRuta, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            Else
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griLista.Selected.Rows.Count > 0 Then
                griLista.ActiveRow.Delete()
            Else
                mensajeEmergente.Problema("Seleccione registro")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Me.UltraPrintPreviewDialog1.Document = PrintDocument()
        Me.UltraPrintPreviewDialog1.ShowDialog(Me)
        Me.UltraPrintPreviewDialog1.Document = Nothing
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
            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griLista)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub Btn_imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_imagen.Click
        Try
            Dim ofd_Imagen As New OpenFileDialog
            With ofd_Imagen
                .Filter = "Imágenes JPG (*.jpg)|*.jpg"
                .FilterIndex = 1
                .Title = "Abrir imagen ..."
            End With
            If ofd_Imagen.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgr_ImgAuxiliar.DisplayLayout.Bands(0).AddNew()
                Dim Fila As Integer = dgr_ImgAuxiliar.Rows.Count - 1
                With dgr_ImgAuxiliar.Rows(Fila)
                    .Cells("Ruta").Value = ofd_Imagen.FileName
                    .Cells("Imagen").Value = "Imagen " & ofd_Imagen.SafeFileName
                End With
            End If
            ofd_Imagen.Dispose()
            ofd_Imagen = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub dgr_ImgAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgr_ImgAuxiliar.Click
        Try
            Dim Fs As System.IO.FileStream = Nothing
            Dim stImagenes As String
            With dgr_ImgAuxiliar
                .UpdateData()
                If .ActiveRow.Cells("Ruta") Is DBNull.Value _
                OrElse .ActiveRow.Cells("Ruta").Value = "" Then
                    stImagenes = .ActiveRow.Cells(0).Text
                Else
                    stImagenes = .ActiveRow.Cells("Ruta").Value
                End If
                Fs = New System.IO.FileStream(stImagenes, IO.FileMode.Open, IO.FileAccess.Read)
                upb_ImgAuxiliar.Image = System.Drawing.Image.FromStream(Fs)
                If lbl_Imagen.Text.Trim = "" Then
                    lbl_Imagen.Text = .ActiveRow.Cells(0).Text
                    .ActiveRow.CellAppearance.BackColor = Color.Chocolate
                End If
            End With
            Fs.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarTc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTc.Click
        Try
            AgregarTiempoCiclo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarF.Click
        AgregarFlete()
    End Sub

    Private Sub frm_Ruta_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_Ruta_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, ficRuta)
                'Consultar(True)
                'InicializaTiempo()
            Case "Ayuda"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_Ruta_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarRuta() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Ruta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            oeLugar = New e_Lugar
            oeLugar.TipoOperacion = "O"
            LlenaCombos()
            ComboGrilla()
            cboClienteDZ.Text = "ALICORP SAA"
            griPeaje.DataSource = loRutaPeaje
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTiempoCiclo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTiempoCiclo.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("Tiempo Ciclo: " & "¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub griFlete_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griFlete.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("Flete: " & "¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If griLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        agrListaRegistro.Text = "Lista Registros: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Try
            Select Case ficTiempoFlete.SelectedTab.Index
                Case 0 'TiempoCiclo
                    If griTiempoCiclo.Rows.Count > 0 Then
                        griTiempoCiclo.ActiveRow.Delete()
                    End If
                Case 1 'Flete
                    If griFlete.Rows.Count > 0 Then
                        griFlete.ActiveRow.Delete()
                    End If
                Case 2 'Bolsa de Viaje
                    If griBolsaViaje.Rows.Count > 0 Then
                        griBolsaViaje.ActiveRow.Delete()
                    End If

                Case 3 'Distancia Zona
                    If griDistanciaZona.Rows.Count > 0 Then
                        griDistanciaZona.ActiveRow.Delete()
                    End If
                    'Case 4 'Monto Ruta
                    '    If griMontoRuta.Rows.Count > 0 Then
                    '        griMontoRuta.ActiveRow.Delete()
                    '    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTiempoCiclo_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTiempoCiclo.CellChange
        griTiempoCiclo.UpdateData()
    End Sub

    Private Sub griFlete_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griFlete.CellChange
        griFlete.UpdateData()
    End Sub

    Private Function ValidaRuta() As Boolean
        Try
            If (cboOrigen.Value IsNot Nothing OrElse Not String.IsNullOrWhiteSpace(cboOrigen.Value)) AndAlso (cboDestino.Value IsNot Nothing OrElse Not String.IsNullOrWhiteSpace(cboDestino.Value)) Then
                oeRuta = New e_Ruta
                oeRuta.IdOrigen = cboOrigen.Value
                oeRuta.IdDestino = cboDestino.Value
                If Not olRuta.ValidarRuta(oeRuta) Then
                    Exit Function
                End If
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub cboDestino_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestino.Leave
        Try
            ValidaRuta()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoVehiculoTc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculoTc.ValueChanged
        oeTiempoCiclo.TipoVehiculo = cboTipoVehiculoTc.Value
    End Sub

    Private Sub cboClienteTc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClienteTc.ValueChanged
        oeTiempoCiclo.Cliente = cboClienteTc.Value
    End Sub

    Private Sub cboTipoVehiculoF_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculoF.ValueChanged
        oeFlete.TipoVehiculo = cboTipoVehiculoF.Value
    End Sub

    Private Sub cboClienteF_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClienteF.ValueChanged
        oeFlete.Cliente = cboClienteF.Value
    End Sub

    Private Sub cboTipoCargaF_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCargaF.ValueChanged
        oeFlete.TipoCarga = cboTipoCargaF.Value
    End Sub

    Private Sub btnAgregarB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarB.Click
        AgregarBolsaViaje()
    End Sub

    Private Sub cboTipoVehiculoB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculoB.ValueChanged
        oeBolsaViaje.TipoVehiculo = cboTipoVehiculoB.Value
    End Sub

    Private Sub cboConceptoGastoB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConceptoGastoB.ValueChanged
        oeBolsaViaje.ConceptoGasto = cboConceptoGastoB.Value
    End Sub

    Private Sub griBolsaViaje_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griBolsaViaje.CellChange
        griBolsaViaje.UpdateData()
    End Sub

    Private Sub griBolsaViaje_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griBolsaViaje.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("Bolsa Viaje: " & "¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_Ruta_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub cboOrigen_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboOrigen.EditorButtonClick
        ListaLugar = New List(Of e_Lugar)
        oeLugar = New e_Lugar
        oeLugar.Activo = True
        ListaLugar.AddRange(olLugar.Listar(oeLugar))
        LlenarComboMaestro(cboOrigen, ListaLugar, 0)
    End Sub

    Private Sub cboDestino_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboDestino.EditorButtonClick
        ListaLugar = New List(Of e_Lugar)
        oeLugar = New e_Lugar
        oeLugar.Activo = True
        ListaLugar.AddRange(olLugar.Listar(oeLugar))
        LlenarComboMaestro(cboDestino, ListaLugar, 0)
    End Sub

    Private Sub cboCentro_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboCentro.EditorButtonClick
        Try
            oeCentro = New e_Centro
            oeCentro.Activo = True
            LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboFlota_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboFlota.EditorButtonClick
        oeFlota = New e_Flota
        oeFlota.Activo = True
        LlenarComboMaestro(cboFlota, olFlota.Listar(oeFlota), 0)
    End Sub

    Private Sub griLista_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.CellChange
        griLista.UpdateData()
    End Sub

    Private Sub griLista_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If Not (olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MAESTRO RUTA") Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas) Then
                Throw New Exception("No Tiene Permiso MAESTRO RUTA")
            End If


            Select Case e.Cell.Column.Key
                Case "Guardar"
                    oeRuta = New e_Ruta
                    oeRuta.PrefijoID = gs_PrefijoIdSucursal '@0001
                    With oeRuta
                        .TipoOperacion = "B"
                        .Id = RTrim(griLista.ActiveRow.Cells("IdRuta").Value)
                        .IndicadorLocal = griLista.ActiveRow.Cells("IndicadorLocal").Value
                        .IdCentro = griLista.ActiveRow.Cells("Centro").Value
                        .IdFlota = griLista.ActiveRow.Cells("Flota").Value
                        .Kilometros = griLista.ActiveRow.Cells("Kilometros").Value
                        .HorasSolo = griLista.ActiveRow.Cells("HorasSolo").Value
                        .HorasAcompañado = griLista.ActiveRow.Cells("HorasAcompañado").Value
                        .FactorReferencial = griLista.ActiveRow.Cells("FactorReferencial").Value
                        .UsuarioCreacion = gUsuarioSGI.Id
                    End With
                    olRuta.Guardar(oeRuta)
                Case "RDZ"
                    If griLista.ActiveRow.Cells("IdDistanciaZona").Value.ToString.Length > 0 Then
                        oeDistanciaZona = New e_DistanciaZona
                        With oeDistanciaZona
                            .TipoOperacion = "B"
                            .Id = RTrim(griLista.ActiveRow.Cells("IdDistanciaZona").Value)
                            .IdActividadNegocio = griLista.ActiveRow.Cells("IdActividadNegocio").Value
                            .IdZona = griLista.ActiveRow.Cells("IdZona").Value
                            .Distancia = griLista.ActiveRow.Cells("Distancia").Value
                        End With
                        oeDistanciaZona.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olDistanciaZona.Guardar(oeDistanciaZona)
                    End If
            End Select
            griLista.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboCentroMasivo_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboCentroMasivo.EditorButtonClick
        If griLista.Rows.Count > 0 Then
            If MessageBox.Show("Se va actualizar todos los centros de la lista activa por: ", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                If griLista.Rows.Count > 0 Then
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                        Fila.Cells("Centro").Value = cboCentroMasivo.Value
                    Next
                End If
                ugb_Espera.Visible = False
            End If
        End If
    End Sub

    Private Sub cboZonaMasiva_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboZonaMasiva.EditorButtonClick
        If griLista.Rows.Count > 0 Then
            If MessageBox.Show("Se va actualizar todos las Zonas de la lista activa por: " & _
                                 cboZonaMasiva.Text & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                If griLista.Rows.Count > 0 Then
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                        Fila.Cells("Flota").Value = cboZonaMasiva.Value
                    Next
                End If
                ugb_Espera.Visible = False
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            If Not (olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MAESTRO RUTA") Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas) Then
                Throw New Exception("No Tiene Permiso MAESTRO RUTA")
            End If

            If griLista.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todos los REGISTROS de la lista activa desea continuar ? ", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                        oeRuta = New e_Ruta
                        oeRuta.PrefijoID = gs_PrefijoIdSucursal '@0001
                        With oeRuta
                            .TipoOperacion = "B"
                            .Id = RTrim(Fila.Cells("IdRuta").Value)
                            .IndicadorLocal = Fila.Cells("IndicadorLocal").Value
                            .IdCentro = Fila.Cells("Centro").Value
                            .IdFlota = Fila.Cells("Flota").Value
                            .Kilometros = Fila.Cells("Kilometros").Value
                            .HorasSolo = Fila.Cells("HorasSolo").Value
                            .HorasAcompañado = Fila.Cells("HorasAcompañado").Value
                            .FactorReferencial = Fila.Cells("FactorReferencial").Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                        End With
                        olRuta.Guardar(oeRuta)
                        Fila.CellAppearance.BackColor = Me.ColorBloque.Color
                    Next
                End If
                ugb_Espera.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub mHoras_Validated(sender As Object, e As EventArgs) Handles mHorasSolo.Validated
        Try
            If IsDBNull(mHorasSolo.Value) Then mHorasSolo.Value = 0.0
            mHorasSolo.Value = ConvertirTiempoReal(mHorasSolo.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboDistanciaZona_Click(sender As Object, e As EventArgs) Handles cboDistanciaZona.Click
        Try
            oeRuta.oeDistanciaZona = griDistanciaZona.DataSource
            With oeDistanciaZona
                .Id = ""
                .IdRuta = ""
                .IdCliente = cboClienteDZ.Value
                .IdActividadNegocio = cboActividadNegocioDZ.Value
                .IdZona = cboZonaDZ.Value
                .Distancia = txtDistanciaDZ.Value
                .Observacion = txtGlozaDZ.Text
                .FechaInicio = fecInicioDZ.Value
                .FechaFin = fecFinDZ.Value
                .Actual = verActualDZ.Checked
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            oeRuta.oeDistanciaZona.Add(oeDistanciaZona)
            griDistanciaZona.DataBind()
            oeDistanciaZona = New e_DistanciaZona
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDistanciaZona_CellChange(sender As Object, e As CellEventArgs) Handles griDistanciaZona.CellChange
        Try
            griDistanciaZona.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDistanciaZona_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDistanciaZona.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If MessageBox.Show("Distancia Zona: " & "¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboActividadNegocioMasiva_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboActividadNegocioMasiva.EditorButtonClick
        Try
            If griLista.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todos las Operaciones de la lista activa por: " & _
                                    cboActividadNegocioMasiva.Text & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                        Fila.Cells("IdActividadNegocio").Value = cboActividadNegocioMasiva.Value
                    Next
                End If
                ugb_Espera.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboZonaDZMasiva_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboZonaDZMasiva.EditorButtonClick
        Try
            If griLista.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todos las Zonas de la lista activa por: " & _
                                     cboZonaDZMasiva.Text & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    If griLista.Rows.Count > 0 Then
                        For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                            Fila.Cells("IdZona").Value = cboZonaDZMasiva.Value
                        Next
                    End If
                    ugb_Espera.Visible = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardarDZ_Click(sender As Object, e As EventArgs) Handles btnGuardarDZ.Click
        Try

            If Not (olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MAESTRO RUTA") Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas) Then
                Throw New Exception("No Tiene Permiso MAESTRO RUTA")
            End If

            If griLista.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todos los REGISTROS de la lista activa desea continuar ? ", _
                                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()

                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                        If Fila.Cells("IdDistanciaZona").Value.ToString.Length > 0 Then
                            oeDistanciaZona = New e_DistanciaZona
                            oeDistanciaZona.PrefijoID = gs_PrefijoIdSucursal '@0001
                            With oeDistanciaZona
                                .TipoOperacion = "B"
                                .Id = RTrim(Fila.Cells("IdDistanciaZona").Value)
                                .IdActividadNegocio = Fila.Cells("IdActividadNegocio").Value
                                .IdZona = Fila.Cells("IdZona").Value
                                .Distancia = Fila.Cells("Distancia").Value
                            End With
                            olDistanciaZona.Guardar(oeDistanciaZona)
                            Fila.CellAppearance.BackColor = Me.ColorBloque.Color
                        End If
                    Next
                    ugb_Espera.Visible = False
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

    Private Sub btnAgregarMonto_Click(sender As Object, e As EventArgs) Handles btnAgregarMonto.Click
        Try
            AgregarMonto()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitarMonto_Click(sender As Object, e As EventArgs) Handles btnQuitarMonto.Click
        Try
            QuitarMonto()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mHorasAcompañado_Validated(sender As Object, e As EventArgs) Handles mHorasAcompañado.Validated
        Try
            If IsDBNull(mHorasAcompañado.Value) Then mHorasAcompañado.Value = 0.0
            mHorasAcompañado.Value = ConvertirTiempoReal(mHorasAcompañado.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboOrigenZonaD2_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboOrigenZonaD2.EditorButtonClick
        Try
            ListaLugar = New List(Of e_Lugar)
            oeLugar = New e_Lugar
            oeLugar.Activo = True
            ListaLugar.AddRange(olLugar.Listar(oeLugar))
            LlenarComboMaestro(cboOrigenZonaD2, ListaLugar, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboDestinoZonaD2_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboDestinoZonaD2.EditorButtonClick
        Try
            ListaLugar = New List(Of e_Lugar)
            oeLugar = New e_Lugar
            oeLugar.Activo = True
            ListaLugar.AddRange(olLugar.Listar(oeLugar))
            LlenarComboMaestro(cboDestinoZonaD2, ListaLugar, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarZonaD2_Click(sender As Object, e As EventArgs) Handles btnAgregarZonaD2.Click
        Try
            AgregarZonaD2()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEliminarZonaD2_Click(sender As Object, e As EventArgs) Handles btnEliminarZonaD2.Click
        Try
            QuitarZonaD2()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griZonaCombustible_CellChange(sender As Object, e As CellEventArgs) Handles griZonaCombustible.CellChange
        Try
            griZonaCombustible.UpdateData()
            Dim NombreColumna As String = ""
            NombreColumna = e.Cell.Column.Key
            If NombreColumna = "IdDestino" Then
                Dim IdDestino As String = ""
                For Each obj In oeRuta.loZonaD2.Where(Function(i) i.Activo = True And i.TipoOperacion <> "E").ToList.OrderBy(Function(y) y.Orden)
                    If IdDestino = "" Then
                        IdDestino = obj.IdDestino
                    Else
                        obj.IdOrigen = IdDestino
                        IdDestino = obj.IdDestino
                    End If
                Next
            ElseIf NombreColumna = "IdOrigen" Then
                Dim IdOrigen As String = ""
                For Each obj In oeRuta.loZonaD2.Where(Function(i) i.Activo = True And i.TipoOperacion <> "E").ToList.OrderByDescending(Function(y) y.Orden)
                    If IdOrigen = "" Then
                        IdOrigen = obj.IdOrigen
                    Else
                        obj.IdDestino = IdOrigen
                        IdOrigen = obj.IdOrigen
                    End If
                Next
            End If
            griZonaCombustible.UpdateData()
            griZonaCombustible.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboOrigen_ValueChanged(sender As Object, e As EventArgs) Handles cboOrigen.ValueChanged
        Try
            If cboOrigen.SelectedIndex > -1 Then
                cboOrigenZonaD2.Value = cboOrigen.Value
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboDestino_ValueChanged(sender As Object, e As EventArgs) Handles cboDestino.ValueChanged
        Try
            If cboDestino.SelectedIndex > -1 Then
                cboDestinoZonaD2.Value = cboDestino.Value
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Ruta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficRuta.SelectedTab.Index
                Case 1
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                        Case Keys.Insert
                        Case Keys.Delete
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMontoRuta_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griMontoRuta.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griZonaCombustible_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griZonaCombustible.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMontoRuta_CellChange(sender As Object, e As CellEventArgs) Handles griMontoRuta.CellChange
        Try
            griMontoRuta.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tspPeaje_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspPeaje.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarPeaje.Name
                    mt_AgregarPeaje()
                Case tsbQuitarPeaje.Name
                    mt_QuitarPeaje()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPeaje_CellChange(sender As Object, e As CellEventArgs) Handles griPeaje.CellChange
        Try
            griPeaje.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        oeRuta = New e_Ruta
        verLocal.Checked = False
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtRuta.Text = String.Empty
        mEstimadoF.Value = 0.0
        mKilometros.Value = 0.0
        mHorasSolo.Text = "00.00"
        mHorasCargaTC.Text = "00.00"
        mHorasDescargaTC.Text = "00.00"
        mHorasTrasladoTc.Text = "00.00"
        mHorasAcompañado.Text = "00.00"
        mEstimadoF.Value = 0.0
        mEstimadoF.Value = 0.0
        mContratoF.Value = 0.0
        mTecnicoF.Value = 0.0
        cboClienteF.SelectedIndex = -1
        cboClienteTc.SelectedIndex = -1
        cboOrigen.SelectedIndex = -1
        cboDestino.SelectedIndex = -1
        cboOrigenZonaD2.SelectedIndex = -1
        cboDestinoZonaD2.SelectedIndex = -1
        CboZonaD2.SelectedIndex = -1
        cboFlota.SelectedIndex = -1
        cboCentro.SelectedIndex = -1
        cboZonaMasiva.SelectedIndex = -1
        cboCentroMasivo.SelectedIndex = -1
        cboClienteTc.SelectedIndex = -1
        cboTipoCargaF.SelectedIndex = -1
        cboTipoVehiculoTc.SelectedIndex = -1
        cboTipoVehiculoB.SelectedIndex = -1
        cboConceptoGastoB.SelectedIndex = -1
        cboTipoVehiculo.SelectedIndex = -1
        rdbCargado.Checked = True
        numMontoSolo.Value = 0.0
        numMontoAcompañado.Value = 0.0
        numPorcentajeCopi.Value = 0.0
        numPorcentajeAyu.Value = 0.0
        numBonoSolo.Value = 0.0
        numCruceroC.Value = 0.0
        numCruceroP.Value = 0.0
        numCuenta.Value = 0
        chkIndNacional.Checked = True
        LimpiaGrid(griTiempoCiclo, ogdTiempoCiclo)
        LimpiaGrid(griFlete, ogdFlete)
        AsociarMenu()
        mt_InicializarRutaPeaje()
        loRutaPeaje.Clear()
        griPeaje.DataBind()
    End Sub

    Public Sub LlenaCombos()

        LlenarComboMaestro(cboOrigen, LugaresPublic, 0)
        LlenarComboMaestro(cboDestino, LugaresPublic, 0)
        LlenarComboMaestro(cboOrigenZonaD2, LugaresPublic, 0)
        LlenarComboMaestro(cboDestinoZonaD2, LugaresPublic, 0)

        LlenarComboMaestro(cboCentro, CentroPublic.Where(Function(x) x.Id.ToString.Trim <> "").ToList, -1)
        LlenarComboMaestro(cboCentroMasivo, CentroPublic, -1)

        LlenarComboMaestro(cboFlota, ZonaPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList, -1)
        LlenarComboMaestro(cboZonaMasiva, ZonaPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList, -1)
        LlenarComboMaestro(cboZonaDZ, ZonaPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList, 0)
        LlenarComboMaestro(cboZonaDZMasiva, ZonaPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList, 0)
        LlenarComboMaestro(CboZonaD2, ZonaD2Public.Where(Function(Item) Item.Nombre <> "TODOS").ToList, 0)

        LlenarComboMaestro(cboTipoVehiculoTc, ModeloFuncionalPublic, 0)
        LlenarComboMaestro(cboTipoVehiculoF, ModeloFuncionalPublic, 0)
        LlenarComboMaestro(cboTipoVehiculoB, ModeloFuncionalPublic, 0)
        LlenarCombo(cboTipoVehiculo, "Nombre", ModeloFuncionalPublic, -1)

        LlenarComboMaestro(cboClienteTc, ClientesPublic, 0)
        LlenarComboMaestro(cboClienteF, ClientesPublic, 0)
        LlenarComboMaestro(cboClienteDZ, ClientesPublic, 0)
        oeCombo = New e_Combo
        oeCombo.Nombre = "ConceptoGasto"
        ConceptoGastoPublic = New List(Of e_Combo)
        ConceptoGastoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboConceptoGastoB, ConceptoGastoPublic, 0)

        oeCombo = New e_Combo
        oeCombo.Nombre = "VENTAS"
        OperacionesPublic = New List(Of e_Combo)
        OperacionesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboActividadNegocioDZ, OperacionesPublic, 0)
        LlenarComboMaestro(cboActividadNegocioMasiva, OperacionesPublic, 0)
        LlenarComboMaestro(cboTipoCargaF, TipoCargaPublic, 0)
        'Llenar Combo Peaje
        Dim olPeaje As New l_Peaje
        ComboNormal(cmbPeaje, olPeaje.Listar(New e_Peaje With {.TipoOperacion = "GEN"}), -1)
    End Sub

    Private Sub ComboGrilla()
        Dim Cliente = New DataTable
        Dim TipoVehiculo = New DataTable
        Dim TipoCarga = New DataTable
        Dim Zona = New DataTable
        Dim ZonaD2 = New DataTable
        Dim LugarZonaD2 = New DataTable
        Dim OperacionRuta = New DataTable

        Cliente = olCombo.ComboGrilla(ClientesPublic)
        CrearComboGrid("Cliente", "Nombre", griTiempoCiclo, Cliente, True)
        CrearComboGrid("Cliente", "Nombre", griFlete, Cliente, True)
        CrearComboGrid("IdCliente", "Nombre", griDistanciaZona, Cliente, True)

        TipoCarga = olCombo.ComboGrilla(TipoCargaPublic)
        CrearComboGrid("TipoCarga", "Nombre", griFlete, TipoCarga, True)

        TipoVehiculo = olCombo.ComboGrilla(ModeloFuncionalPublic)
        CrearComboGrid("TipoVehiculo", "Nombre", griTiempoCiclo, TipoVehiculo, True)
        CrearComboGrid("TipoVehiculo", "Nombre", griFlete, TipoVehiculo, True)
        CrearComboGrid("TipoVehiculo", "Nombre", griBolsaViaje, TipoVehiculo, True)

        CrearComboGrid("ConceptoGasto", "Nombre", griBolsaViaje, olCombo.ComboGrilla(ConceptoGastoPublic), True)

        CrearComboGrid("Centro", "Nombre", griLista, olCombo.ComboGrillaEspecial(CentroPublic), True)

        Zona = olCombo.ComboGrilla(ZonaPublic)
        CrearComboGrid("Flota", "Nombre", griLista, Zona, True)
        CrearComboGrid("IdZona", "Nombre", griDistanciaZona, Zona, True)
        Zona.Rows.Item(0).Delete()
        CrearComboGrid("IdZona", "Nombre", griLista, Zona, True)
        OperacionRuta = olCombo.ComboGrilla(OperacionesPublic)
        CrearComboGrid("IdActividadNegocio", "Nombre", griDistanciaZona, OperacionRuta, True)
        CrearComboGrid("IdActividadNegocio", "Nombre", griLista, OperacionRuta, True)

        ZonaD2 = olCombo.ComboGrilla(ZonaD2Public.Where(Function(i) i.Nombre <> "TODOS").ToList)
        CrearComboGrid("IdFlota", "Nombre", griZonaCombustible, ZonaD2, True)

        LugarZonaD2 = olCombo.ComboGrilla(LugaresPublic.Where(Function(i) i.Nombre <> "TODOS").ToList)
        CrearComboGrid("IdOrigen", "Nombre", griZonaCombustible, LugarZonaD2, True)
        CrearComboGrid("IdDestino", "Nombre", griZonaCombustible, LugarZonaD2, True)
    End Sub

    Private Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim dsRuta As DataSet = olRuta.ListarGrupos(oeRuta)
            griLista.DataSource = dsRuta
            For Each Fila As UltraGridRow In griLista.Rows
                If Convert.ToInt64(Fila.Cells("CantidadTarifas").Value) = 0 Then
                    Fila.Appearance.BackColor = colorSinTarifa.Color
                End If
            Next
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Function EliminarRuta() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If Not (olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MAESTRO RUTA") Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas) Then
                Throw New Exception("No Tiene Permiso MAESTRO RUTA")
            End If

            With griLista
                If ValidarGrilla(griLista, "Ruta") Then
                    oeRuta = New e_Ruta
                    oeRuta.Id = griLista.ActiveRow.Cells("IdRuta").Value
                    oeRuta = olRuta.Obtener(oeRuta)
                    If oeRuta.Activo Then
                        If olRuta.VerificarAntesEliminar(oeRuta) = 0 Then
                            If MessageBox.Show("Esta seguro de eliminar la Ruta: " & _
                                 oeRuta.Codigo & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                olRuta.Eliminar(oeRuta)
                                Operacion = "Inicializa"
                                If griLista.Rows.Count > 0 Then
                                    MyBase.Consultar(True)
                                Else
                                    MyBase.Consultar()
                                End If
                            Else
                                Return False
                                Exit Function
                            End If
                        Else
                            MessageBox.Show("No se puede ELIMINAR esta Ruta, porque esta siendo utilizada en la PROGRAMACION DE UN VIAJE",
                                            "Información del Sistema")
                            Return False
                        End If

                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
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

    Public Function EditarRuta() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.ActiveRow.Cells("IdRuta").Value.ToString.Length > 0 Then
                oeRuta = New e_Ruta
                oeRuta.Id = griLista.ActiveRow.Cells("IdRuta").Value.ToString
                oeRuta.TipoOperacion = ""
                oeRuta = olRuta.Obtener(oeRuta)
                If oeRuta.Activo Then
                    CargarRuta(oeRuta)
                    MostrarTabs(1, ficRuta, 1)
                Else
                    Throw New Exception("El Registro se encuentra eliminado")
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

    Private Function ValidaCamposCabecera() As Boolean
        Try
            If cboOrigen.SelectedIndex < 0 Then
                mensajeEmergente.Problema("Seleccione origen válido", True)
                cboOrigen.Focus()
                Return False
            End If
            If cboDestino.SelectedIndex < 0 Then
                mensajeEmergente.Problema("Seleccione destino válido", True)
                cboDestino.Focus()
                Return False
            End If
            If cboCentro.SelectedIndex < 0 Then
                mensajeEmergente.Problema("Seleccione centro válido", True)
                cboCentro.Focus()
                Return False
            End If
            If cboFlota.SelectedIndex < 0 Then
                mensajeEmergente.Problema("Seleccione flota válido", True)
                cboFlota.Focus()
                Return False
            End If
            If Not ValidarCombo(cboOrigen, "Origen") Then Exit Function
            If Not ValidarCombo(cboFlota, "Zona") Then Exit Function
            'If oeRuta.loMontoRuta.Count = 0 Then Throw New Exception("Debe Generar un Monto de Ruta") '@0001 Quitar por ingreso de informacion
            If Operacion = "Nuevo" Then
                If Not ValidaRuta() Then Exit Function
            End If
            If mKilometros.Value = 0 Then Throw New Exception("Ingrese la distancia")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarRuta() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If Not (olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MAESTRO RUTA") Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas) Then
                Throw New Exception("No Tiene Permiso MAESTRO RUTA")
            End If

            If ValidaCamposCabecera() Then
                With oeRuta
                    .TipoOperacion = "I"
                    .Id = txtId.Text
                    .Codigo = txtCodigo.Text
                    .IndicadorLocal = verLocal.Checked
                    .IdCentro = cboCentro.Value
                    .IdFlota = cboFlota.Value
                    .Kilometros = mKilometros.Value
                    .HorasSolo = mHorasSolo.Value
                    .HorasAcompañado = mHorasAcompañado.Value
                    .FactorReferencial = mFleteReferencial.Value
                    .Activo = True
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .oeTiempoCiclo = griTiempoCiclo.DataSource
                    .oeFlete = griFlete.DataSource
                    .oeBolsaViaje = griBolsaViaje.DataSource
                    .oeDistanciaZona = griDistanciaZona.DataSource
                    .loMontoRuta = griMontoRuta.DataSource
                    .loZonaD2 = griZonaCombustible.DataSource
                    .ListaRutaPeaje.Clear()
                    .ListaRutaPeaje.AddRange(loRutaPeaje)
                End With
                oeRuta.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olRuta.Guardar(oeRuta) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    Operacion = "Inicializa"
                    MostrarTabs(0, ficRuta, 2)
                    Listar()
                    'If griLista.Rows.Count > 0 Then
                    '    MyBase.Consultar(True)
                    'Else
                    '    MyBase.Consultar()
                    'End If
                End If
                Return True
            Else
                Return False
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Origen") Then
            cboOrigen.Focus()
        End If
        If excepcion.Contains("Destino") Then
            cboDestino.Focus()
        End If
        If excepcion.Contains("Base") Then
            cboCentro.Focus()
        End If
        If excepcion.Contains("Flota") Then
            cboFlota.Focus()
        End If

    End Sub

    Private Function ValidaTiempoCiclo() As Boolean
        Try
            If Not ValidarCombo(cboTipoVehiculoTc, "Tipo Vehiculo") Then Exit Function
            If Not ValidarCombo(cboClienteTc, "Cliente") Then Exit Function
            If Not olTiempoCiclo.Validar(oeTiempoCiclo) Then Exit Function
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            EnfocarTiempoCiclo(ex.Message)
        End Try
    End Function

    Private Sub EnfocarTiempoCiclo(ByVal excepcion As String)
        If excepcion.Contains("Tipo Vehiculo") Then
            'cboTipoVehiculoTc.SE()
            cboTipoVehiculoTc.Focus()
        End If
        If excepcion.Contains("Cliente") Then
            cboClienteTc.Focus()
        End If

    End Sub

    Private Sub AgregarTiempoCiclo()
        Try
            oeRuta.oeTiempoCiclo = griTiempoCiclo.DataSource
            With oeTiempoCiclo
                .Id = ""
                .IdRuta = ""
                .TipoVehiculo = cboTipoVehiculoTc.Value
                .Cliente = cboClienteTc.Value
                .HorasCarga = mHorasCargaTC.Value
                .HorasTraslado = mHorasTrasladoTc.Value
                .HorasDescarga = mHorasDescargaTC.Value
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            If ValidaTiempoCiclo() Then
                oeRuta.oeTiempoCiclo.Add(oeTiempoCiclo)
                griTiempoCiclo.DataBind()
                oeTiempoCiclo = New e_TiempoCiclo
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaFlete() As Boolean
        Try
            If Not ValidarCombo(cboTipoVehiculoF, "Tipo Vehiculo") Then Exit Function
            If Not ValidarCombo(cboClienteF, "Cliente") Then Exit Function
            If Not ValidarCombo(cboTipoCargaF, "Tipo Carga") Then Exit Function
            If Not olFlete.Validar(oeFlete) Then Exit Function
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            EnfocarFlete(ex.Message)
        End Try
    End Function

    Private Sub EnfocarFlete(ByVal excepcion As String)
        If excepcion.Contains("Tipo Vehiculo") Then cboTipoVehiculoF.Focus()
        If excepcion.Contains("Cliente") Then cboClienteF.Focus()
        If excepcion.Contains("Tipo Carga") Then cboTipoCargaF.Focus()
    End Sub

    Private Sub AgregarFlete()
        Try
            oeRuta.oeFlete = griFlete.DataSource
            With oeFlete
                .Id = ""
                .IdRuta = ""
                .TipoVehiculo = cboTipoVehiculoF.Value
                .Cliente = cboClienteF.Value
                .TipoCarga = cboTipoCargaF.Value
                .Estimado = mEstimadoF.Value
                .DescripcionEstimado = txtDescripcionEstimadoF.Text
                .Contrato = mContratoF.Value
                .DescripcionContrato = txtDescripcionContratoF.Text
                .Tecnico = mTecnicoF.Value
                .DescripcionTecnico = txtDescripcionTecnicoF.Text
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            If ValidaFlete() Then
                oeRuta.oeFlete.Add(oeFlete)
                griFlete.DataBind()
                oeFlete = New e_Flete
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarBolsaViaje()
        Try
            oeRuta.oeBolsaViaje = griBolsaViaje.DataSource
            With oeBolsaViaje
                .Id = ""
                .IdRuta = ""
                .TipoVehiculo = cboTipoVehiculoB.Value
                .ConceptoGasto = cboConceptoGastoB.Value
                .Minimo = mMinimoB.Value
                .DescripcionMinimo = txtDescripcionMinimo.Text
                .Normal = mNormalB.Value
                .DescripcionNormal = txtDescripcionNormal.Text
                .Maximo = mMaximoB.Value
                .DescripcionMaximo = txtDescripcionMaximo.Text
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            If ValidaBolsaViaje() Then
                oeRuta.oeBolsaViaje.Add(oeBolsaViaje)
                griBolsaViaje.DataBind()
                oeBolsaViaje = New e_BolsaViaje
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarMonto()
        Try
            If cboTipoVehiculo.SelectedIndex < 0 Then
                Throw New Exception("Seleccione Tipo de Vehiculo")
            End If

            If oeRuta.loMontoRuta.Count > 0 Then
                If rdbCargado.Checked Then
                    ValidarMonto(True, cboTipoVehiculo.Value)
                Else
                    ValidarMonto(False, cboTipoVehiculo.Value)
                End If
            End If
            oeRuta.loMontoRuta = griMontoRuta.DataSource
            oeMontoRuta = New e_MontoRuta
            With oeMontoRuta
                .TipoOperacion = "I"
                .IdTipoVehiculo = cboTipoVehiculo.Value
                .TipoVehiculo = cboTipoVehiculo.Text
                .IdRuta = oeRuta.Id
                .IndCargado = IIf(rdbCargado.Checked, True, False)
                .IndNacional = IIf(chkIndNacional.Checked, True, False)
                .IndCategoria = IIf(chkIndCategoria.Checked, True, False)
                .Cuenta = numCuenta.Value
                .MontoSolo = numMontoSolo.Value
                .MontoAcompañado = numMontoAcompañado.Value
                .PorcentajeCopiloto = numPorcentajeCopi.Value
                .PorcentajeAyudante = numPorcentajeAyu.Value
                .BonoSolo = numBonoSolo.Value
                .BonoCruceroPiloto = numCruceroP.Value
                .BonoCruceroCopiloto = numCruceroC.Value
                .UsuarioCreacion = gUsuarioSGI.Id
                .FechaCreacion = ObtenerFechaServidor()
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            oeRuta.loMontoRuta.Add(oeMontoRuta)
            griMontoRuta.DataBind()
            oeMontoRuta = New e_MontoRuta
            rdbCargado.Checked = True
            numMontoSolo.Value = 0.0
            numMontoAcompañado.Value = 0.0
            numPorcentajeCopi.Value = 0.0
            numPorcentajeAyu.Value = 0.0
            numBonoSolo.Value = 0.0
            numCruceroC.Value = 0.0
            numCruceroP.Value = 0.0
            numCuenta.Value = 0
            chkIndNacional.Checked = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaBolsaViaje() As Boolean
        Try
            If Not ValidarCombo(cboTipoVehiculoB, "Tipo Vehiculo") Then Exit Function
            If Not ValidarCombo(cboConceptoGastoB, "Concepto Gasto") Then Exit Function
            If Not olBolsaViaje.Validar(oeBolsaViaje) Then Exit Function
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            EnfocarFlete(ex.Message)
        End Try
    End Function

    Private Sub EnfocarBolsaViaje(ByVal excepcion As String)
        If excepcion.Contains("Tipo Vehiculo") Then cboTipoVehiculoB.Focus()
        If excepcion.Contains("Concepto Gasto") Then cboConceptoGastoB.Focus()
    End Sub

    Private Sub CargarRuta(ByVal oe As e_Ruta)
        With oe
            txtId.Text = .Id
            txtCodigo.Text = .Codigo
            txtRuta.Text = .Nombre
            verLocal.Checked = .IndicadorLocal
            cboOrigen.Value = .IdOrigen
            cboDestino.Value = .IdDestino
            cboCentro.Value = .IdCentro
            cboFlota.Value = .IdFlota
            mKilometros.Text = .Kilometros
            mHorasSolo.Value = .HorasSolo
            mHorasAcompañado.Value = .HorasAcompañado
            mFleteReferencial.Text = .FactorReferencial

            oeTiempoCiclo = New e_TiempoCiclo
            oeTiempoCiclo.TipoOperacion = ""
            oeTiempoCiclo.IdRuta = oeRuta.Id
            griTiempoCiclo.DataSource = olTiempoCiclo.Listar(oeTiempoCiclo)

            oeFlete = New e_Flete
            oeFlete.TipoOperacion = "1"
            oeFlete.IdRuta = oeRuta.Id
            griFlete.DataSource = olFlete.Listar(oeFlete)

            oeBolsaViaje = New e_BolsaViaje
            oeBolsaViaje.IdRuta = oeRuta.Id
            griBolsaViaje.DataSource = olBolsaViaje.Listar(oeBolsaViaje)

            oeDistanciaZona = New e_DistanciaZona
            oeDistanciaZona.IdRuta = oeRuta.Id
            griDistanciaZona.DataSource = olDistanciaZona.Listar(oeDistanciaZona)

            oeMontoRuta = New e_MontoRuta
            oeMontoRuta.IdRuta = oeRuta.Id
            oeRuta.loMontoRuta.AddRange(olMontoRuta.Listar(oeMontoRuta))
            griMontoRuta.DataSource = oeRuta.loMontoRuta

            oeZonaD2 = New e_ZonaCombustible
            oeZonaD2.IdRuta = oeRuta.Id
            oeRuta.loZonaD2.AddRange(olZonaD2.Listar(oeZonaD2))
            For Each obj In oeRuta.loZonaD2
                obj.TipoOperacion = "A"
            Next
            griZonaCombustible.DataSource = oeRuta.loZonaD2

            oeRutaPeaje = New e_RutaPeaje
            With oeRutaPeaje
                .TipoOperacion = "GEN"
                .IdRuta = oeRuta.Id
            End With
            loRutaPeaje.AddRange(olRutaPeaje.Listar(oeRutaPeaje))
            griPeaje.DataBind()
        End With
    End Sub

    Private Sub mt_AgregarPeaje()
        Try
            If fc_ValidarAgregarPeaje() Then
                oeRutaPeaje = New e_RutaPeaje
                With oeRutaPeaje
                    .TipoOperacion = "I"
                    .IdPeaje = cmbPeaje.Value.ToString().Trim()
                    .Peaje = cmbPeaje.Text.Trim()
                    .Glosa = txtGlosaPeaje.Text.Trim()
                    .UsuarioCreacion = gUsuarioSGI.Id
                End With
                loRutaPeaje.Add(oeRutaPeaje)
                griPeaje.DataBind()
                mt_InicializarRutaPeaje()
                cmbPeaje.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarRutaPeaje()
        Try
            cmbPeaje.SelectedIndex = -1
            txtGlosaPeaje.Text = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarPeaje()
        Try
            If griPeaje.Selected.Rows.Count > 0 AndAlso griPeaje.ActiveRow.Index >= 0 Then
                If Not String.IsNullOrEmpty(griPeaje.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                    loRutaPeaje(loRutaPeaje.IndexOf(griPeaje.ActiveRow.ListObject)).TipoOperacion = "E"
                    griPeaje.ActiveRow.Hidden = True
                Else
                    loRutaPeaje.Remove(griPeaje.ActiveRow.ListObject)
                End If
                griPeaje.DataBind()
            Else
                MessageBox.Show("Seleccione peaje", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_ValidarAgregarPeaje()
        Try
            If cmbPeaje.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione peaje", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbPeaje.Focus()
                Return False
            End If
            If loRutaPeaje.Where(Function(x) x.TipoOperacion <> "E" And x.IdPeaje = cmbPeaje.Value.ToString().Trim()).Count > 0 Then
                MessageBox.Show("El peaje seleccionado ya se encuentra agregado a la lista", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbPeaje.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ValidarMonto(IndCargado As Boolean, IdTipoVehiculo As String)
        Try
            For Each monrut In oeRuta.loMontoRuta
                If monrut.IndCargado = IndCargado And monrut.IdTipoVehiculo = IdTipoVehiculo Then
                    Throw New Exception("Ya Ingreso Monto para esta Carga con Este Vehiculo")
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarMonto()
        Try
            If griMontoRuta.Selected.Rows.Count > 0 Then
                oeMontoRuta = New e_MontoRuta
                oeMontoRuta = griMontoRuta.ActiveRow.ListObject
                If oeMontoRuta.TipoOperacion = "I" Then
                    oeRuta.loMontoRuta.Remove(oeMontoRuta)
                Else
                    oeMontoRuta.TipoOperacion = "E"
                    griMontoRuta.ActiveRow.Hidden = True
                End If
            End If
            griMontoRuta.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarZonaD2()
        Try
            oeZonaD2 = New e_ZonaCombustible
            If cboOrigenZonaD2.SelectedIndex < 0 Then
                Throw New Exception("Seleccione un Origen Valido.")
            End If
            If cboDestinoZonaD2.SelectedIndex < 0 Then
                Throw New Exception("Seleccione un Destino válido.")
            End If
            If CboZonaD2.SelectedIndex < 0 Then
                Throw New Exception("Seleccione una Zona para poder agregarla.")
            End If
            If oeRuta.loZonaD2.Where(Function(i) i.Activo = True And i.TipoOperacion <> "E" And i.IdFlota = CboZonaD2.Value).ToList.Count() > 0 Then
                Throw New Exception("Ya se encuentra agregada la Zona señalada.")
            End If
            Dim NroMayor As Integer = 0
            NroMayor = oeRuta.loZonaD2.Where(Function(i) i.Activo = True And i.TipoOperacion <> "E").ToList.Count()
            If NroMayor > 0 Then
                If cboOrigenZonaD2.Value <> oeRuta.loZonaD2.Where(Function(y) y.Orden = NroMayor And y.TipoOperacion <> "E")(0).IdDestino Then
                    cboOrigenZonaD2.Value = oeRuta.loZonaD2.Where(Function(y) y.Orden = NroMayor And y.TipoOperacion <> "E")(0).IdDestino
                    Throw New Exception("El nuevo origen debe ser igual que el último destino")
                End If
            End If
            griZonaCombustible.DataSource = oeRuta.loZonaD2
            With oeZonaD2
                .TipoOperacion = "I"
                .Id = ""
                .IdRuta = ""
                .IdFlota = CboZonaD2.Value
                .IdOrigen = cboOrigenZonaD2.Value
                .IdDestino = cboDestinoZonaD2.Value
                .Activo = True
                .Orden = oeRuta.loZonaD2.Where(Function(i) i.Activo = True And i.TipoOperacion <> "E").ToList.Count() + 1
                .UsuarioCreacion = gUsuarioSGI.Id
                .UsuarioModifica = gUsuarioSGI.Id
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            oeRuta.loZonaD2.Add(oeZonaD2)
            cboOrigenZonaD2.Value = oeRuta.loZonaD2.Where(Function(y) y.Orden = (NroMayor + 1) And y.TipoOperacion <> "E")(0).IdDestino
            griZonaCombustible.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarZonaD2()
        Try
            If griZonaCombustible.Selected.Rows.Count > 0 Then
                oeZonaD2 = New e_ZonaCombustible
                If griZonaCombustible.Rows.Count = 0 Then
                    Throw New Exception("No existe ninguna fila por eliminar")
                End If
                If griZonaCombustible.ActiveRow.Cells("IdFlota").ToString = "" Then
                    Throw New Exception("Seleccione una fila válida para eliminar")
                End If
                oeZonaD2 = griZonaCombustible.ActiveRow.ListObject
                Dim numeroOrden As Integer = 0
                numeroOrden = oeRuta.loZonaD2.Where(Function(i) i.Activo = True And i.TipoOperacion <> "E").ToList.Max(Function(Y) Y.Orden)
                If oeZonaD2.Orden < numeroOrden Then
                    Throw New Exception("Elime primero el últmo detalle, guíese de la columna orden")
                End If
                If oeZonaD2.TipoOperacion = "I" Then
                    oeRuta.loZonaD2.Remove(oeZonaD2)
                Else
                    oeZonaD2.TipoOperacion = "E"
                    griZonaCombustible.ActiveRow.Hidden = True
                End If
                griZonaCombustible.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Function PrintDocument() As System.Drawing.Printing.PrintDocument
        PrintDocument = Me.UltraGridPrintDocument1
    End Function

    Public Sub AgregaFactorRef(ByVal idRuta As String)
        Try
            Inicializar()
            oeRuta.Id = idRuta
            oeRuta = olRuta.Obtener(oeRuta)
            CargarRuta(oeRuta)
            MostrarTabs(1, ficRuta, 1)
            oeRuta.TipoOperacion = "A"
            oeRuta.Modificado = False
            ficTiempoFlete.SelectedTab = ficTiempoFlete.Tabs(0)
            Operacion = "Editar"
            BandCbo = False
            MyBase.Editar()
            mFleteReferencial.Focus()
            mFleteReferencial.SelectAll()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menú contextual del maestro de Material"

    Private Sub AsociarMenu()
        griLista.ContextMenuStrip = Menu
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub Menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening, Menu.Opening
        Menu.Items("InsertarToolStripMenuItem").Visible = True
        If griLista.Selected.Rows.Count > 0 Then
            Menu.Items("ActualizarToolStripMenuItem").Visible = True
            Menu.Items("EliminarToolStripMenuItem").Visible = True
        Else
            Menu.Items("ActualizarToolStripMenuItem").Visible = False
            Menu.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class