'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
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

Public Class frm_TarifasCliente
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_TarifasCliente = Nothing
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
            instancia = New frm_TarifasCliente()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim olTarifasCliente As New l_TarifasCliente
    Dim oeTarifasCliente As New e_TarifasCliente
    Dim ListaTarifasCliente As New List(Of e_TarifasCliente)
    Dim _ingresando_datos As Boolean = False

    Dim oeFlete As New e_Flete
    Dim olFlete As New l_Flete

    Dim oeLugar As New e_Lugar
    Dim olLugar As New l_Lugar
    Dim ListaLugar As New List(Of e_Lugar)
    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta

    Dim ValorIgv As Double = 0
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
            MostrarTabs(1, ficDemanda, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            cboCliente.Focus()
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
            Inicializar()
            If EditarTarifa() Then
                Operacion = "Editar"
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                cboCliente.Focus()
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
            If GuardarTarifa() Then
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
                    If GuardarTarifa() Then
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
        Try
            griLista.ActiveRow.Delete()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
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

    Private Sub frm_TarifasCliente_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_TarifasCliente_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficDemanda)
                If PerfilAsignado(gNombrePerfilAutorizaTarifas) Then
                    If _Activo Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    btnGuardar.Visible = False
                    ficListaTarifas.Tabs(0).Enabled = True
                    ficListaTarifas.Tabs(1).Enabled = False
                    ficListaTarifas.Tabs(2).Enabled = False
                    ficListaTarifas.Tabs(3).Enabled = False
                    ficListaTarifas.Tabs(4).Enabled = False
                    ficListaTarifas.Tabs(5).Enabled = False
                    ficListaTarifas.Tabs(6).Enabled = False
                    ficListaTarifas.Tabs(7).Enabled = False
                    griLista.DisplayLayout.Bands(0).Columns("Observacion").Hidden = True
                End If
                
                'Consultar(True)
        End Select
    End Sub

    Private Sub frm_TarifasCliente_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If PerfilAsignado(gNombrePerfilAutorizaTarifas) Then
            If griLista.Selected.Rows.Count > 0 Then Editar()
        End If

    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarTarifa() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_TarifasCliente_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub frm_TarifasCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            oeLugar = New e_Lugar
            oeLugar.TipoOperacion = "O"
            ListaLugar.AddRange(olLugar.Listar(oeLugar))
            LlenarComboMaestro(cboOrigen, ListaLugar, -1)
            LlenaCombos()
            Dim olCombo As New l_Combo
            CrearComboGrid("IdMaterial", "Nombre", griLista, olCombo.ComboGrilla(MaterialesPublic), True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboOrigen_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOrigen.Validated
        Try
            cboDestino.Items.Clear()
            oeRuta = New e_Ruta
            oeRuta.IdOrigen = cboOrigen.Value
            LlenarComboMaestro(cboDestino, olRuta.Listar(oeRuta), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaTarifasSPSA_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaTarifasVea.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaTarifasSPSA_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaTarifasVea.CellChange
        griListaTarifasVea.UpdateData()
    End Sub

    Private Sub griListaTarifasTOTTUS_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaTarifasTOTTUS.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaTarifasTOTTUS_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaTarifasTOTTUS.CellChange
        griListaTarifasTOTTUS.UpdateData()
    End Sub

    Private Sub griListaTarifasALICORP_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaTarifasALICORP.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaTarifasALICORP_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaTarifasALICORP.CellChange
        griListaTarifasALICORP.UpdateData()
    End Sub

    Private Sub griListaTarifasCEMENTOS_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaTarifasCEMENTOS.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaTarifasCEMENTOS_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaTarifasCEMENTOS.CellChange
        griListaTarifasCEMENTOS.UpdateData()
    End Sub

    Private Sub griListaTarifasGLORIA_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaTarifasGLORIA.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaTarifasGLORIA_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaTarifasGLORIA.CellChange
        griListaTarifasCEMENTOS.UpdateData()
    End Sub

    Private Sub griListaTarifasCENCOSUD_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaTarifasCENCOSUD_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        griListaTarifasCENCOSUD.UpdateData()
    End Sub

    Private Sub griListaTarifasINDUAMERICA_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaTarifasINDUAMERICA_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        griListaTarifasINDUAMERICA.UpdateData()
    End Sub

    Private Sub btnGuardarVea_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarVea.Click
        Try
            Dim TarifasActualiza As String
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "00"
                .IndHistorial = txtUltimoHistorialVea.Text
                .IndActual = 1
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            TarifasActualiza = ""
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasVea.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    .Tarifa = fila.Cells("20M3").Value
                                Case "PARIHUELERO"
                                    .Tarifa = fila.Cells("30M3").Value
                                Case "CONSOLIDADO"
                                    .Tarifa = fila.Cells("40M3").Value
                            End Select
                            Exit For
                        End If
                    Next
                    .IdTipoRuta = "1CH0024"
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeVea.Text
                    .IndHistorial = CInt(txtUltimoHistorialVea.Text) + 1
                    .FechaInicio = fecInicioVea.Value
                    .FechaFin = fecInicioVea.Value
                    TarifasActualiza = TarifasActualiza & "'" & .Id & "',"
                    .Id = ""
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "T"
            oeTarifasCliente.Observacion = TarifasActualiza.Substring(0, TarifasActualiza.Length - 1)
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialVea.Text) - 1
                ListarHistorialCliente("0", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizarVea_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarVea.Click
        Try
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "00"
                .IndHistorial = txtUltimoHistorialVea.Text
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasVea.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    .Tarifa = fila.Cells("20M3").Value
                                Case "PARIHUELERO"
                                    .Tarifa = fila.Cells("30M3").Value
                                Case "CONSOLIDADO"
                                    .Tarifa = fila.Cells("40M3").Value
                            End Select
                            Exit For
                        End If
                    Next
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeVea.Text
                    .IndHistorial = CInt(txtUltimoHistorialVea.Text)
                    .FechaInicio = fecInicioVea.Value
                    .FechaFin = fecInicioVea.Value
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "X"
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialVea.Text) - 1
                ListarHistorialCliente("0", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub btnGuardarTottus_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarTottus.Click
        Try
            Dim TarifasActualiza As String
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "11"
                .IndHistorial = txtUltimoHistorialTottus.Text
                .IndActual = 1
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            TarifasActualiza = ""
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasTOTTUS.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    If .IndConsolidado = 0 Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("50M3").Value
                                    End If
                                Case "FURGON LARGO"
                                    .Tarifa = fila.Cells("65M3").Value
                                Case "CAMION 65 M3"
                                    .Tarifa = fila.Cells("30M3").Value
                            End Select
                            Exit For
                        End If
                    Next
                    .IdTipoRuta = "1CH0024"
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeTottus.Text
                    .IndHistorial = CInt(txtUltimoHistorialTottus.Text) + 1
                    .FechaInicio = fecInicioTottus.Value
                    .FechaFin = fecInicioTottus.Value
                    TarifasActualiza = TarifasActualiza & "'" & .Id & "',"
                    .Id = ""
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "T"
            oeTarifasCliente.Observacion = TarifasActualiza.Substring(0, TarifasActualiza.Length - 1)
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialTottus.Text) - 1
                ListarHistorialCliente("1", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizarTottus_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarTottus.Click
        Try
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "11"
                .IndHistorial = txtUltimoHistorialTottus.Text
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasTOTTUS.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    If .IndConsolidado = 0 Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("50M3").Value
                                    End If
                                Case "FURGON LARGO"
                                    .Tarifa = fila.Cells("65M3").Value
                                Case "CAMION 65 M3"
                                    .Tarifa = fila.Cells("30M3").Value
                            End Select
                            Exit For
                        End If
                    Next
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeTottus.Text
                    .IndHistorial = CInt(txtUltimoHistorialTottus.Text)
                    .FechaInicio = fecInicioTottus.Value
                    .FechaFin = fecInicioTottus.Value
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "X"
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialTottus.Text) - 1
                ListarHistorialCliente("1", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardarAlicorp_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarAlicorp.Click
        Try
            Dim TarifasActualiza As String
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "22"
                .IndHistorial = txtUltimoHistorialAlicorp.Text
                .IndActual = 1
            End With
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            TarifasActualiza = ""
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasALICORP.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    .Tarifa = fila.Cells("20M3").Value
                                Case "PARIHUELERO"
                                    .Tarifa = fila.Cells("40M3").Value
                            End Select
                            Exit For
                        End If
                    Next
                    .IdTipoRuta = "1CH0024"
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeAlicorp.Text
                    .IndHistorial = CInt(txtUltimoHistorialAlicorp.Text) + 1
                    .FechaInicio = fecInicioAlicorp.Value
                    .FechaFin = fecInicioAlicorp.Value
                    TarifasActualiza = TarifasActualiza & "'" & .Id & "',"
                    .Id = ""
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "T"
            oeTarifasCliente.Observacion = TarifasActualiza.Substring(0, TarifasActualiza.Length - 1)
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialAlicorp.Text) - 1
                ListarHistorialCliente("2", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizarAlicorp_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarAlicorp.Click
        Try
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "22"
                .IndHistorial = txtUltimoHistorialAlicorp.Text
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasALICORP.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    .Tarifa = fila.Cells("20M3").Value
                                Case "PARIHUELERO"
                                    .Tarifa = fila.Cells("40M3").Value
                            End Select
                            Exit For
                        End If
                    Next
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeAlicorp.Text
                    .IndHistorial = CInt(txtUltimoHistorialAlicorp.Text)
                    .FechaInicio = fecInicioAlicorp.Value
                    .FechaFin = fecInicioAlicorp.Value
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "X"
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialAlicorp.Text) - 1
                ListarHistorialCliente("2", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardarCementos_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarCementos.Click
        Try
            Dim TarifasActualiza As String
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "33"
                .IndHistorial = txtUltimoHistorialCementos.Text
                .IndActual = 1
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            TarifasActualiza = ""
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasCEMENTOS.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "PLATAFORMA"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                                Case "CALICERA"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                            End Select
                            Exit For
                        End If
                    Next
                    .IdTipoRuta = "1CH0024"
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeCementos.Text
                    .IndHistorial = CInt(txtUltimoHistorialCementos.Text) + 1
                    .FechaInicio = fecInicioCementos.Value
                    .FechaFin = fecInicioCementos.Value
                    TarifasActualiza = TarifasActualiza & "'" & .Id & "',"
                    .Id = ""
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "T"
            oeTarifasCliente.Observacion = TarifasActualiza.Substring(0, TarifasActualiza.Length - 1)
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialCementos.Text) - 1
                ListarHistorialCliente("3", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizarCementos_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarCementos.Click
        Try
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "33"
                .IndHistorial = txtUltimoHistorialCementos.Text
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasCEMENTOS.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "PLATAFORMA"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                                Case "CALICERA"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                            End Select
                            Exit For
                        End If
                    Next
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeCementos.Text
                    .IndHistorial = CInt(txtUltimoHistorialCementos.Text)
                    .FechaInicio = fecInicioCementos.Value
                    .FechaFin = fecInicioCementos.Value
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "X"
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialCementos.Text) - 1
                ListarHistorialCliente("3", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardarGloria_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarGloria.Click
        Try
            Dim TarifasActualiza As String
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "44"
                .IndHistorial = txtUltimoHistorialGloria.Text
                .IndActual = 1
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            TarifasActualiza = ""
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasGLORIA.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                            End Select
                            Exit For
                        End If
                    Next
                    .IdTipoRuta = "1CH0024"
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeGloria.Text
                    .IndHistorial = CInt(txtUltimoHistorialGloria.Text) + 1
                    .FechaInicio = fecInicioGloria.Value
                    .FechaFin = fecInicioGloria.Value
                    TarifasActualiza = TarifasActualiza & "'" & .Id & "',"
                    .Id = ""
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "T"
            oeTarifasCliente.Observacion = TarifasActualiza.Substring(0, TarifasActualiza.Length - 1)
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialGloria.Text) - 1
                ListarHistorialCliente("4", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizarGloria_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarGloria.Click
        Try
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "44"
                .IndHistorial = txtUltimoHistorialGloria.Text
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasGLORIA.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                            End Select
                            Exit For
                        End If
                    Next
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeGloria.Text
                    .IndHistorial = CInt(txtUltimoHistorialGloria.Text)
                    .FechaInicio = fecInicioGloria.Value
                    .FechaFin = fecInicioGloria.Value
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "X"
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialGloria.Text) - 1
                ListarHistorialCliente("4", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardarCencosud_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarCencosud.Click
        Try
            Dim TarifasActualiza As String
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "55"
                .IndHistorial = txtUltimoHistorialCencosud.Text
                .IndActual = 1
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            TarifasActualiza = ""
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasCENCOSUD.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                            End Select
                            Exit For
                        End If
                    Next
                    .IdTipoRuta = "1CH0024"
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeCencosud.Text
                    .IndHistorial = CInt(txtUltimoHistorialCencosud.Text) + 1
                    .FechaInicio = fecInicioCencosud.Value
                    .FechaFin = fecInicioCencosud.Value
                    TarifasActualiza = TarifasActualiza & "'" & .Id & "',"
                    .Id = ""
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "T"
            oeTarifasCliente.Observacion = TarifasActualiza.Substring(0, TarifasActualiza.Length - 1)
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialCencosud.Text) - 1
                ListarHistorialCliente("5", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizarCencosud_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarCencosud.Click
        Try
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "55"
                .IndHistorial = txtUltimoHistorialCencosud.Text
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasCENCOSUD.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "FURGON"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                            End Select
                            Exit For
                        End If
                    Next
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeCencosud.Text
                    .IndHistorial = CInt(txtUltimoHistorialCencosud.Text)
                    .FechaInicio = fecInicioCencosud.Value
                    .FechaFin = fecInicioCencosud.Value
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "X"
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialCencosud.Text) - 1
                ListarHistorialCliente("5", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardarInduamerica_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarInduamerica.Click
        Try
            Dim TarifasActualiza As String
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "66"
                .IndHistorial = txtUltimoHistorialInduamerica.Text
                .IndActual = 1
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            TarifasActualiza = ""
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasINDUAMERICA.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "PARIHUELERO"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                            End Select
                            Exit For
                        End If
                    Next
                    .IdTipoRuta = "1CH0024"
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeInduamerica.Text
                    .IndHistorial = CInt(txtUltimoHistorialInduamerica.Text) + 1
                    .FechaInicio = fecInicioInduamerica.Value
                    .FechaFin = fecInicioInduamerica.Value
                    TarifasActualiza = TarifasActualiza & "'" & .Id & "',"
                    .Id = ""
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "T"
            oeTarifasCliente.Observacion = TarifasActualiza.Substring(0, TarifasActualiza.Length - 1)
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialInduamerica.Text) - 1
                ListarHistorialCliente("6", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizarInduamerica_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarInduamerica.Click
        Try
            Dim RangoHistorialInicial As Integer
            ListaTarifasCliente = New List(Of e_TarifasCliente)
            oeTarifasCliente = New e_TarifasCliente
            With oeTarifasCliente
                .TipoOperacion = "66"
                .IndHistorial = txtUltimoHistorialInduamerica.Text
            End With
            ListaTarifasCliente.AddRange(olTarifasCliente.Listar(oeTarifasCliente))
            For Each oeTarifas As e_TarifasCliente In ListaTarifasCliente
                With oeTarifas
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaTarifasINDUAMERICA.Rows
                        If .Observacion = fila.Cells("Origen").Value And .UsuarioCreacion = fila.Cells("Destino").Value Then
                            Select Case .IdTipoRuta
                                Case "PARIHUELERO"
                                    If .IdTipoCarga = "1CH000000002" Then
                                        .Tarifa = fila.Cells("20M3").Value
                                    Else
                                        .Tarifa = fila.Cells("30M3").Value
                                    End If
                            End Select
                            Exit For
                        End If
                    Next
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Porcentaje = txtPorcentajeInduamerica.Text
                    .IndHistorial = CInt(txtUltimoHistorialInduamerica.Text)
                    .FechaInicio = fecInicioInduamerica.Value
                    .FechaFin = fecInicioInduamerica.Value
                End With
                oeTarifas.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTarifasCliente.e_ListaTarifasCliente.Add(oeTarifas)
            Next
            oeTarifasCliente.TipoOperacion = "X"
            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasCliente.Guardar(oeTarifasCliente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Listar()
                RangoHistorialInicial = CInt(txtUltimoHistorialInduamerica.Text) - 1
                ListarHistorialCliente("6", RangoHistorialInicial, RangoHistorialInicial - 5)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
#End Region

#Region "Métodos"

    Private Sub Inicializar()
        txtId.Text = String.Empty
        txtObservacion.Text = String.Empty
        txtFleteUnitario.Text = 0.0
        verConsolidado.Checked = False
        txtIndHistorial.Text = 1
        txtPorcentajeM.Text = 1
        verActual.Checked = True
        verCargar.Checked = False
        verDescarga.Checked = False
        verContraEntrega.Checked = False
        verVariable.Checked = False
        verOtros.Checked = False
        cboTipoRuta.Text = "OTROS"
        Me.cboMaterial.Value = "1CH000001393"
        ValorIgv = ObtenerIGV()
    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeTarifasCliente = New e_TarifasCliente
            Dim RangoHistorialInicial As Integer
            If ficListaTarifas.Tabs(0).Selected Then
                oeTarifasCliente.TipoOperacion = "T"
                oeTarifasCliente.IdCliente = cboClienteLista.Value
                griLista.DataSource = olTarifasCliente.Listar(oeTarifasCliente)
                'Ubica el cursor el el primer registro de la grilla
                If griLista.Rows.Count > 0 Then
                    griLista.Focus()
                    griLista.Rows.Item(0).Selected = True
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                End If
                If Not PerfilAsignado(gNombrePerfilAutorizaTarifas) Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                End If
                griLista.Focus()
            Else
                oeTarifasCliente.TipoOperacion = "P"
                oeTarifasCliente.IndHistorial = -1
                If ficListaTarifas.Tabs(1).Selected Then
                    oeTarifasCliente.IdCliente = "0"
                    oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                    With oeTarifasCliente
                        txtPorcentajeVea.Text = .Porcentaje
                        txtUltimoHistorialVea.Text = .IndHistorial
                        fecInicioVea.Value = .FechaInicio
                    End With
                    With oeTarifasCliente
                        .TipoOperacion = "0"
                        .Porcentaje = txtPorcentajeVea.Text
                        .IndHistorial = txtUltimoHistorialVea.Text
                    End With
                    griListaTarifasVea.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                    LimpiarHistorialCliente("0")
                    RangoHistorialInicial = CInt(txtUltimoHistorialVea.Text) - 1
                    ListarHistorialCliente("0", RangoHistorialInicial, RangoHistorialInicial - 5)
                Else
                    If ficListaTarifas.Tabs(2).Selected Then
                        oeTarifasCliente.IdCliente = "1"
                        oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                        With oeTarifasCliente
                            txtPorcentajeTottus.Text = .Porcentaje
                            txtUltimoHistorialTottus.Text = .IndHistorial
                            fecInicioTottus.Value = .FechaInicio
                        End With
                        With oeTarifasCliente
                            .TipoOperacion = "1"
                            .Porcentaje = txtPorcentajeTottus.Text
                            .IndHistorial = txtUltimoHistorialTottus.Text
                        End With
                        griListaTarifasTOTTUS.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                        LimpiarHistorialCliente("1")
                        RangoHistorialInicial = CInt(txtUltimoHistorialTottus.Text) - 1
                        ListarHistorialCliente("1", RangoHistorialInicial, RangoHistorialInicial - 5)
                    Else
                        If ficListaTarifas.Tabs(3).Selected Then
                            oeTarifasCliente.IdCliente = "2"
                            oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                            With oeTarifasCliente
                                txtPorcentajeAlicorp.Text = .Porcentaje
                                txtUltimoHistorialAlicorp.Text = .IndHistorial
                                fecInicioAlicorp.Value = .FechaInicio
                            End With
                            With oeTarifasCliente
                                .TipoOperacion = "2"
                                .Porcentaje = txtPorcentajeAlicorp.Text
                                .IndHistorial = txtUltimoHistorialAlicorp.Text
                            End With
                            griListaTarifasALICORP.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                            LimpiarHistorialCliente("2")
                            RangoHistorialInicial = CInt(txtUltimoHistorialAlicorp.Text) - 1
                            ListarHistorialCliente("2", RangoHistorialInicial, RangoHistorialInicial - 5)
                        Else
                            If ficListaTarifas.Tabs(4).Selected Then
                                oeTarifasCliente.IdCliente = "3"
                                oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                                With oeTarifasCliente
                                    txtPorcentajeCementos.Text = .Porcentaje
                                    txtUltimoHistorialCementos.Text = .IndHistorial
                                    fecInicioCementos.Value = .FechaInicio
                                End With
                                With oeTarifasCliente
                                    .TipoOperacion = "3"
                                    .Porcentaje = txtPorcentajeCementos.Text
                                    .IndHistorial = txtUltimoHistorialCementos.Text
                                End With
                                griListaTarifasCEMENTOS.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                LimpiarHistorialCliente("3")
                                RangoHistorialInicial = CInt(txtUltimoHistorialCementos.Text) - 1
                                ListarHistorialCliente("3", RangoHistorialInicial, RangoHistorialInicial - 5)
                            Else
                                If ficListaTarifas.Tabs(5).Selected Then
                                    oeTarifasCliente.IdCliente = "4"
                                    oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                                    With oeTarifasCliente
                                        txtPorcentajeGloria.Text = .Porcentaje
                                        txtUltimoHistorialGloria.Text = .IndHistorial
                                        fecInicioGloria.Value = .FechaInicio
                                    End With
                                    With oeTarifasCliente
                                        .TipoOperacion = "4"
                                        .Porcentaje = txtPorcentajeGloria.Text
                                        .IndHistorial = txtUltimoHistorialGloria.Text
                                    End With
                                    griListaTarifasGLORIA.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    LimpiarHistorialCliente("4")
                                    RangoHistorialInicial = CInt(txtUltimoHistorialGloria.Text) - 1
                                    ListarHistorialCliente("4", RangoHistorialInicial, RangoHistorialInicial - 5)
                                Else
                                    If ficListaTarifas.Tabs(6).Selected Then
                                        oeTarifasCliente.IdCliente = "5"
                                        oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                                        With oeTarifasCliente
                                            txtPorcentajeCencosud.Text = .Porcentaje
                                            txtUltimoHistorialCencosud.Text = .IndHistorial
                                            fecInicioCencosud.Value = .FechaInicio
                                        End With
                                        With oeTarifasCliente
                                            .TipoOperacion = "5"
                                            .Porcentaje = txtPorcentajeCencosud.Text
                                            .IndHistorial = txtUltimoHistorialCencosud.Text
                                        End With
                                        griListaTarifasCENCOSUD.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                        LimpiarHistorialCliente("5")
                                        RangoHistorialInicial = CInt(txtUltimoHistorialCencosud.Text) - 1
                                        ListarHistorialCliente("5", RangoHistorialInicial, RangoHistorialInicial - 5)
                                    Else
                                        If ficListaTarifas.Tabs(7).Selected Then
                                            oeTarifasCliente.IdCliente = "6"
                                            oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                                            With oeTarifasCliente
                                                txtPorcentajeInduamerica.Text = .Porcentaje
                                                txtUltimoHistorialInduamerica.Text = .IndHistorial
                                                fecInicioInduamerica.Value = .FechaInicio
                                            End With
                                            With oeTarifasCliente
                                                .TipoOperacion = "6"
                                                .Porcentaje = txtPorcentajeInduamerica.Text
                                                .IndHistorial = txtUltimoHistorialInduamerica.Text
                                            End With
                                            griListaTarifasINDUAMERICA.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                            LimpiarHistorialCliente("6")
                                            RangoHistorialInicial = CInt(txtUltimoHistorialInduamerica.Text) - 1
                                            ListarHistorialCliente("6", RangoHistorialInicial, RangoHistorialInicial - 5)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
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

    Public Sub LimpiarHistorialCliente(IndCliente As String)
        Select Case IndCliente
            Case "0"
                tabHistorialVea.Tabs(0).Text = ""
                tabHistorialVea.Tabs(1).Text = ""
                tabHistorialVea.Tabs(2).Text = ""
                tabHistorialVea.Tabs(3).Text = ""
                tabHistorialVea.Tabs(4).Text = ""
                LimpiaGrid(griVeaH1, ogdTarifas)
                LimpiaGrid(griVeaH2, ogdTarifas)
                LimpiaGrid(griVeaH3, ogdTarifas)
                LimpiaGrid(griVeaH4, ogdTarifas)
                LimpiaGrid(griVeaH5, ogdTarifas)
            Case "1"
                tabHistorialTottus.Tabs(0).Text = ""
                tabHistorialTottus.Tabs(1).Text = ""
                tabHistorialTottus.Tabs(2).Text = ""
                tabHistorialTottus.Tabs(3).Text = ""
                tabHistorialTottus.Tabs(4).Text = ""
                LimpiaGrid(griTottusH1, ogdTarifas)
                LimpiaGrid(griTottusH2, ogdTarifas)
                LimpiaGrid(griTottusH3, ogdTarifas)
                LimpiaGrid(griTottusH4, ogdTarifas)
                LimpiaGrid(griTottusH5, ogdTarifas)
            Case "2"
                tabHistorialAlicorp.Tabs(0).Text = ""
                tabHistorialAlicorp.Tabs(1).Text = ""
                tabHistorialAlicorp.Tabs(2).Text = ""
                tabHistorialAlicorp.Tabs(3).Text = ""
                tabHistorialAlicorp.Tabs(4).Text = ""
                LimpiaGrid(griAlicorpH1, ogdTarifas)
                LimpiaGrid(griAlicorpH2, ogdTarifas)
                LimpiaGrid(griAlicorpH3, ogdTarifas)
                LimpiaGrid(griAlicorpH4, ogdTarifas)
                LimpiaGrid(griAlicorpH5, ogdTarifas)
            Case "3"
                tabHistorialCementos.Tabs(0).Text = ""
                tabHistorialCementos.Tabs(1).Text = ""
                tabHistorialCementos.Tabs(2).Text = ""
                tabHistorialCementos.Tabs(3).Text = ""
                tabHistorialCementos.Tabs(4).Text = ""
                LimpiaGrid(griCementosH1, ogdTarifas)
                LimpiaGrid(griCementosH2, ogdTarifas)
                LimpiaGrid(griCementosH3, ogdTarifas)
                LimpiaGrid(griCementosH4, ogdTarifas)
                LimpiaGrid(griCementosH5, ogdTarifas)
            Case "4"
                tabHistorialGloria.Tabs(0).Text = ""
                tabHistorialGloria.Tabs(1).Text = ""
                tabHistorialGloria.Tabs(2).Text = ""
                tabHistorialGloria.Tabs(3).Text = ""
                tabHistorialGloria.Tabs(4).Text = ""
                LimpiaGrid(griGloriaH1, ogdTarifas)
                LimpiaGrid(griGloriaH2, ogdTarifas)
                LimpiaGrid(griGloriaH3, ogdTarifas)
                LimpiaGrid(griGloriaH4, ogdTarifas)
                LimpiaGrid(griGloriaH5, ogdTarifas)
            Case "5"
                tabHistorialCencosud.Tabs(0).Text = ""
                tabHistorialCencosud.Tabs(1).Text = ""
                tabHistorialCencosud.Tabs(2).Text = ""
                tabHistorialCencosud.Tabs(3).Text = ""
                tabHistorialCencosud.Tabs(4).Text = ""
                LimpiaGrid(griCencosudH1, ogdTarifas)
                LimpiaGrid(griCencosudH2, ogdTarifas)
                LimpiaGrid(griCencosudH3, ogdTarifas)
                LimpiaGrid(griCencosudH4, ogdTarifas)
                LimpiaGrid(griCencosudH5, ogdTarifas)
            Case "6"
                tabHistorialInduamerica.Tabs(0).Text = ""
                tabHistorialInduamerica.Tabs(1).Text = ""
                tabHistorialInduamerica.Tabs(2).Text = ""
                tabHistorialInduamerica.Tabs(3).Text = ""
                tabHistorialInduamerica.Tabs(4).Text = ""
                LimpiaGrid(griInduamericaH1, ogdTarifas)
                LimpiaGrid(griInduamericaH2, ogdTarifas)
                LimpiaGrid(griInduamericaH3, ogdTarifas)
                LimpiaGrid(griInduamericaH4, ogdTarifas)
                LimpiaGrid(griInduamericaH5, ogdTarifas)
        End Select
    End Sub

    Public Function EditarTarifa() As Boolean
        Try
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeTarifasCliente = New e_TarifasCliente
                oeTarifasCliente.Id = griLista.ActiveRow.Cells("Id").Value
                oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                With oeTarifasCliente
                    If .Activo Then
                        txtId.Text = .Id
                        cboCliente.Value = .IdCliente
                        cboTipoRuta.Value = .IdTipoRuta
                        cboTipoVehiculo.Value = .IdTipoVehiculo
                        txtFleteUnitario.Text = .Tarifa
                        verConsolidado.Checked = .IndConsolidado
                        txtObservacion.Text = .Observacion
                        cboOrigen.Value = .IdOrigen
                        cboOrigen_Validated(Nothing, Nothing)
                        cboDestino.Value = .IdDestino
                        fecInicio.Value = .FechaInicio
                        fecFin.Value = .FechaFin
                        txtIndHistorial.Text = .IndHistorial
                        verActual.Checked = .IndActual
                        txtPorcentajeM.Text = .Porcentaje
                        cboTipoCarga.Value = .IdTipoCarga
                        verCargar.Checked = .IndCarga
                        verDescarga.Checked = .IndDescarga
                        verContraEntrega.Checked = .IndContraEntrega
                        verVariable.Checked = .IndVariable
                        verOtros.Checked = .IndOtros
                        fecInicioCamp.Value = .FInicioCampaña
                        fecFinCamp.Value = .FFinCampaña
                        Me.cboMaterial.Value = .IdMaterial.Trim
                        Me.chkIncluyeMaterial.Checked = .IndMaterial
                        Me.chkAceptaComision.Checked = .AceptaComision
                        MostrarTabs(1, ficDemanda, 1)
                    Else
                        Throw New Exception("El Registro se encuentra eliminada no se puede editar")
                    End If
                End With

            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function ValidarTarifas() As Boolean
        Try
            If cboCliente.SelectedIndex < 0 Then
                mensajeEmergente.Problema("Seleccione cliente válido", True)
                cboCliente.Focus()
                Return False
            End If
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
            If Operacion = "Nuevo" Then
                oeTarifasCliente = New e_TarifasCliente
                With oeTarifasCliente
                    .TipoOperacion = ""
                    .IdCliente = cboCliente.Value
                    .IdTipoVehiculo = cboTipoVehiculo.Value
                    .IdOrigen = cboOrigen.Value
                    .IdDestino = cboDestino.Value
                    .IdTipoCarga = cboTipoCarga.Value
                    .IdMaterial = cboMaterial.Value
                End With
                olTarifasCliente.Validar(oeTarifasCliente)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarTarifa() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ValidarTarifas() Then
                oeTarifasCliente = New e_TarifasCliente
                With oeTarifasCliente
                    .TipoOperacion = "I"
                    .Id = txtId.Text.Trim
                    .IdCliente = cboCliente.Value
                    .IdTipoRuta = cboTipoRuta.Value
                    .IdTipoVehiculo = cboTipoVehiculo.Value
                    .Tarifa = txtFleteUnitario.Text
                    .IndConsolidado = verConsolidado.Checked
                    .Observacion = txtObservacion.Text
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .IdOrigen = cboOrigen.Value
                    .IdDestino = cboDestino.Value
                    .FechaInicio = fecInicio.Value
                    .FechaFin = fecFin.Value
                    .IndHistorial = txtIndHistorial.Value
                    .IndActual = verActual.Checked
                    .Porcentaje = txtPorcentajeM.Text
                    .IdTipoCarga = cboTipoCarga.Value
                    .IndCarga = verCargar.Checked
                    .IndDescarga = verDescarga.Checked
                    .IndContraEntrega = verContraEntrega.Checked
                    .IndVariable = verVariable.Checked
                    .IndOtros = verOtros.Checked
                    .FInicioCampaña = fecInicioCamp.Value
                    .FFinCampaña = fecFinCamp.Value
                    .IdMaterial = Me.cboMaterial.Value
                    .AceptaComision = Me.chkAceptaComision.Checked
                    .IndMaterial = Me.chkIncluyeMaterial.Checked
                End With
                oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olTarifasCliente.Guardar(oeTarifasCliente) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                    Consultar(True)
                End If
                Operacion = "Inicializa"
                If griLista.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                End If
                Return True
                ugb_Espera.Visible = False
            Else
                Return False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function EliminarTarifa() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLista
                If ValidarGrilla(griLista, "Tarifas Cliente") Then
                    oeTarifasCliente = New e_TarifasCliente
                    oeTarifasCliente.Id = griLista.ActiveRow.Cells("Id").Value
                    oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                    If oeTarifasCliente.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Registro ?", _
                                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            olTarifasCliente.Eliminar(oeTarifasCliente)
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

    Public Sub LlenaCombos()
        LlenarComboMaestro(cboCliente, ClientesPublic, 1)
        LlenarComboMaestro(cboClienteLista, ClientesPublic, -1)
        LlenarComboMaestro(cboTipoRuta, TipoRutaPublic, 1)
        LlenarComboMaestro(cboTipoVehiculo, ModeloFuncionalPublic, 1)
        LlenarComboMaestro(cboTipoCarga, TipoCargaPublic, 0)
        LlenarComboMaestro(cboMaterial, MaterialesPublic, -1)
    End Sub

    Public Function ListarHistorialCliente(IndCliente As String, InicioHistorial As Integer, FinalHistorial As Integer) As Boolean
        Try
            oeTarifasCliente = New e_TarifasCliente
            Dim Contador As Integer
            Dim Titulo As String
            Dim TituloGrilla As String
            Dim Porcentaje As Double
            For I As Integer = InicioHistorial To FinalHistorial Step -1
                If I >= 1 Then
                    Contador = Contador + 1
                    With oeTarifasCliente
                        .TipoOperacion = "P"
                        .IndHistorial = I
                        .IndActual = 0
                        .IdCliente = IndCliente
                    End With
                    oeTarifasCliente = olTarifasCliente.Obtener(oeTarifasCliente)
                    With oeTarifasCliente
                        Porcentaje = .Porcentaje
                        Titulo = .FechaInicio.Date
                        TituloGrilla = "HISTORIAL  Desde  " & .FechaInicio.Date & "  Hasta  " & .FechaFin.Date
                    End With

                    oeTarifasCliente = New e_TarifasCliente
                    With oeTarifasCliente
                        .TipoOperacion = IndCliente
                        .Porcentaje = Porcentaje
                        .IndHistorial = I
                        .IndActual = 0
                    End With
                    Select Case Contador
                        Case 1
                            Select Case IndCliente
                                Case "0"
                                    tabHistorialVea.Tabs(0).Text = Titulo
                                    griVeaH1.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griVeaH1.Text = TituloGrilla
                                Case "1"
                                    tabHistorialTottus.Tabs(0).Text = Titulo
                                    griTottusH1.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griTottusH1.Text = TituloGrilla
                                Case "2"
                                    tabHistorialAlicorp.Tabs(0).Text = Titulo
                                    griAlicorpH1.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griAlicorpH1.Text = TituloGrilla
                                Case "3"
                                    tabHistorialCementos.Tabs(0).Text = Titulo
                                    griCementosH1.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCementosH1.Text = TituloGrilla
                                Case "4"
                                    tabHistorialGloria.Tabs(0).Text = Titulo
                                    griGloriaH1.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griGloriaH1.Text = TituloGrilla
                                Case "5"
                                    tabHistorialCencosud.Tabs(0).Text = Titulo
                                    griCencosudH1.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCencosudH1.Text = TituloGrilla
                                Case "6"
                                    tabHistorialInduamerica.Tabs(0).Text = Titulo
                                    griInduamericaH1.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griInduamericaH1.Text = TituloGrilla
                            End Select
                        Case 2
                            Select Case IndCliente
                                Case "0"
                                    tabHistorialVea.Tabs(1).Text = Titulo
                                    griVeaH2.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griVeaH2.Text = TituloGrilla
                                Case "1"
                                    tabHistorialTottus.Tabs(1).Text = Titulo
                                    griTottusH2.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griTottusH2.Text = TituloGrilla
                                Case "2"
                                    tabHistorialAlicorp.Tabs(1).Text = Titulo
                                    griAlicorpH2.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griAlicorpH2.Text = TituloGrilla
                                Case "3"
                                    tabHistorialCementos.Tabs(1).Text = Titulo
                                    griCementosH2.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCementosH2.Text = TituloGrilla
                                Case "4"
                                    tabHistorialGloria.Tabs(1).Text = Titulo
                                    griGloriaH2.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griGloriaH2.Text = TituloGrilla
                                Case "5"
                                    tabHistorialCencosud.Tabs(1).Text = Titulo
                                    griCencosudH2.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCencosudH2.Text = TituloGrilla
                                Case "6"
                                    tabHistorialInduamerica.Tabs(1).Text = Titulo
                                    griInduamericaH2.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griInduamericaH2.Text = TituloGrilla
                            End Select
                        Case 3
                            Select Case IndCliente
                                Case "0"
                                    tabHistorialVea.Tabs(2).Text = Titulo
                                    griVeaH3.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griVeaH3.Text = TituloGrilla
                                Case "1"
                                    tabHistorialTottus.Tabs(2).Text = Titulo
                                    griTottusH3.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griTottusH3.Text = TituloGrilla
                                Case "2"
                                    tabHistorialAlicorp.Tabs(2).Text = Titulo
                                    griAlicorpH3.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griAlicorpH3.Text = TituloGrilla
                                Case "3"
                                    tabHistorialCementos.Tabs(2).Text = Titulo
                                    griCementosH3.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCementosH3.Text = TituloGrilla
                                Case "4"
                                    tabHistorialGloria.Tabs(2).Text = Titulo
                                    griGloriaH3.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griGloriaH3.Text = TituloGrilla
                                Case "5"
                                    tabHistorialCencosud.Tabs(2).Text = Titulo
                                    griCencosudH3.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCencosudH3.Text = TituloGrilla
                                Case "6"
                                    tabHistorialInduamerica.Tabs(2).Text = Titulo
                                    griInduamericaH3.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griInduamericaH3.Text = TituloGrilla
                            End Select
                        Case 4
                            Select Case IndCliente
                                Case "0"
                                    tabHistorialVea.Tabs(3).Text = Titulo
                                    griVeaH4.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griVeaH4.Text = TituloGrilla
                                Case "1"
                                    tabHistorialTottus.Tabs(3).Text = Titulo
                                    griTottusH4.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griTottusH4.Text = TituloGrilla
                                Case "2"
                                    tabHistorialAlicorp.Tabs(3).Text = Titulo
                                    griAlicorpH4.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griAlicorpH4.Text = TituloGrilla
                                Case "3"
                                    tabHistorialCementos.Tabs(3).Text = Titulo
                                    griCementosH4.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCementosH4.Text = TituloGrilla
                                Case "4"
                                    tabHistorialGloria.Tabs(3).Text = Titulo
                                    griGloriaH4.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griGloriaH4.Text = TituloGrilla
                                Case "5"
                                    tabHistorialCencosud.Tabs(3).Text = Titulo
                                    griCencosudH4.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCencosudH4.Text = TituloGrilla
                                Case "6"
                                    tabHistorialInduamerica.Tabs(3).Text = Titulo
                                    griInduamericaH4.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griInduamericaH4.Text = TituloGrilla
                            End Select
                        Case 5
                            Select Case IndCliente
                                Case "0"
                                    tabHistorialVea.Tabs(4).Text = Titulo
                                    griVeaH5.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griVeaH5.Text = TituloGrilla
                                Case "1"
                                    tabHistorialTottus.Tabs(4).Text = Titulo
                                    griTottusH5.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griTottusH5.Text = TituloGrilla
                                Case "2"
                                    tabHistorialAlicorp.Tabs(4).Text = Titulo
                                    griAlicorpH5.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griAlicorpH5.Text = TituloGrilla
                                Case "3"
                                    tabHistorialCementos.Tabs(4).Text = Titulo
                                    griCementosH5.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCementosH5.Text = TituloGrilla
                                Case "4"
                                    tabHistorialGloria.Tabs(4).Text = Titulo
                                    griGloriaH5.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griGloriaH5.Text = TituloGrilla
                                Case "5"
                                    tabHistorialCencosud.Tabs(4).Text = Titulo
                                    griCencosudH5.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griCencosudH5.Text = TituloGrilla
                                Case "6"
                                    tabHistorialInduamerica.Tabs(4).Text = Titulo
                                    griInduamericaH5.DataSource = olTarifasCliente.ListarTarifas(oeTarifasCliente)
                                    griInduamericaH5.Text = TituloGrilla
                            End Select
                    End Select
                Else
                    Exit For
                End If
            Next
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

    Private Sub griLista_ClickCellButton(sender As Object, e As CellEventArgs) Handles griLista.ClickCellButton
        Try
            If PerfilAsignado(gNombrePerfilAutorizaTarifas) Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                If griLista.ActiveRow.Cells("Porcentaje").Value >= 0 Then
                    oeTarifasCliente = New e_TarifasCliente
                    With oeTarifasCliente
                        .TipoOperacion = "P"
                        .Id = RTrim(griLista.ActiveRow.Cells("Id").Value)
                        .Tarifa = griLista.ActiveRow.Cells("Tarifa").Value
                        .IndConsolidado = griLista.ActiveRow.Cells("IndConsolidado").Value
                        .FechaInicio = griLista.ActiveRow.Cells("FInicioCampaña").Value
                        .FechaFin = griLista.ActiveRow.Cells("FFinCampaña").Value
                        .IndHistorial = griLista.ActiveRow.Cells("IndHistorial").Value
                        .IndActual = griLista.ActiveRow.Cells("IndActual").Value
                        .Porcentaje = griLista.ActiveRow.Cells("Porcentaje").Value
                        .IndCarga = griLista.ActiveRow.Cells("IndCarga").Value
                        .IndDescarga = griLista.ActiveRow.Cells("IndDescarga").Value
                        .IndContraEntrega = griLista.ActiveRow.Cells("IndContraEntrega").Value
                        .IndVariable = griLista.ActiveRow.Cells("IndVariable").Value
                        .IndOtros = griLista.ActiveRow.Cells("IndOtros").Value
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .IdMaterial = griLista.ActiveRow.Cells("IdMaterial").Value
                        .IndMaterial = griLista.ActiveRow.Cells("IndMaterial").Value
                        .AceptaComision = griLista.ActiveRow.Cells("AceptaComision").Value
                    End With
                    Select Case e.Cell.Column.Key
                        Case "Observacion"
                            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
                            olTarifasCliente.Guardar(oeTarifasCliente)
                    End Select
                Else
                    Throw New Exception("Porcentaje de Tarifa Mayor o Igual 0")
                End If
                griLista.ActiveRow.CellAppearance.BackColor = Me.colorCambio.Color
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

    Private Sub fecInicioCampaña_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles fecInicioCampaña.EditorButtonClick
        Try
            If griLista.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todas las Fechas Inicio Campaña de la lista activa por: " & _
                                     fecInicioCampaña.Value & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    If griLista.Rows.Count > 0 Then
                        For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                            Fila.Cells("FInicioCampaña").Value = fecInicioCampaña.Value
                        Next
                    End If
                    ugb_Espera.Visible = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecFinCampaña_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles fecFinCampaña.EditorButtonClick
        Try
            If griLista.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todas las Fechas Fin Campaña de la lista activa por: " & _
                                     fecFinCampaña.Value & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    If griLista.Rows.Count > 0 Then
                        For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                            Fila.Cells("FFinCampaña").Value = fecFinCampaña.Value
                        Next
                    End If
                    ugb_Espera.Visible = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If griLista.Rows.Count > 0 Then
                If MessageBox.Show("Se va actualizar todos los REGISTROS de la lista activa desea continuar ? ", _
                                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                        If Fila.Cells("Porcentaje").Value >= 1 Then
                            oeTarifasCliente = New e_TarifasCliente
                            With oeTarifasCliente
                                .TipoOperacion = "P"
                                .Id = RTrim(Fila.Cells("Id").Value)
                                .Tarifa = Fila.Cells("Tarifa").Value
                                .IndConsolidado = Fila.Cells("IndConsolidado").Value
                                .FechaInicio = Fila.Cells("FInicioCampaña").Value
                                .FechaFin = Fila.Cells("FFinCampaña").Value
                                .IndHistorial = Fila.Cells("IndHistorial").Value
                                .IndActual = Fila.Cells("IndActual").Value
                                .Porcentaje = Fila.Cells("Porcentaje").Value
                                .IndCarga = Fila.Cells("IndCarga").Value
                                .IndDescarga = Fila.Cells("IndDescarga").Value
                                .IndContraEntrega = Fila.Cells("IndContraEntrega").Value
                                .IndVariable = Fila.Cells("IndVariable").Value
                                .IndOtros = Fila.Cells("IndOtros").Value
                                .IdMaterial = Fila.Cells("IdMaterial").Value
                                .UsuarioCreacion = gUsuarioSGI.Id
                            End With
                            oeTarifasCliente.PrefijoID = gs_PrefijoIdSucursal '@0001
                            olTarifasCliente.Guardar(oeTarifasCliente)
                            Fila.CellAppearance.BackColor = Me.colorCambio.Color
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

    Private Sub txtPorcentajeLista_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPorcentajeLista.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If griLista.Rows.Count > 0 Then
                    If MessageBox.Show("Se va actualizar todos los Porcentajes de la lista activa por: " & _
                                         txtPorcentajeLista.Text & " ?", _
                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        ugb_Espera.Visible = True
                        Application.DoEvents()
                        Cursor.Current = Cursors.WaitCursor
                        Cursor.Show()
                        If griLista.Rows.Count > 0 Then
                            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                                Fila.Cells("Porcentaje").Value = txtPorcentajeLista.Text
                            Next
                        End If
                        ugb_Espera.Visible = False
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtFleteUnitario_ValueChanged(sender As Object, e As EventArgs) Handles txtFleteUnitario.ValueChanged
        Try
            If IsNumeric(txtFleteUnitario.Value) Then
                If Not txtFleteUnitarioIGV.Focused Then
                    txtFleteUnitarioIGV.Value = (CDbl(txtFleteUnitario.Value) + CDbl(txtFleteUnitario.Value) * ValorIgv).ToString("###,##0.000")
                End If
            Else
                txtFleteUnitario.Value = 0.0
                txtFleteUnitarioIGV.Value = 0.0
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtFleteUnitarioIGV_ValueChanged(sender As Object, e As EventArgs) Handles txtFleteUnitarioIGV.ValueChanged
        Try

            If IsNumeric(txtFleteUnitarioIGV.Value) Then
                If txtFleteUnitarioIGV.Focused Then
                    txtFleteUnitario.Value = (CDbl(txtFleteUnitarioIGV.Value) / (1 + ValorIgv)).ToString("###,##0.000")
                End If
            Else
                txtFleteUnitarioIGV.Value = 0.0
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_TarifasCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficDemanda.SelectedTab.Index
                Case 0
                Case 1
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservacion.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

End Class