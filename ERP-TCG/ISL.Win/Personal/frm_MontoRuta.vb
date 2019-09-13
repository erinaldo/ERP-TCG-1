Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop

Public Class frm_MontoRuta
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_MontoRuta = Nothing

    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_MontoRuta()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeMontoRuta As e_MontoRuta
    Private olMontoRuta As l_MontoRuta
    Private loMontoRutaImportar As List(Of e_MontoRuta)
    Private loMontoRutaValidar As List(Of e_MontoRuta)
    Private loMontoRuta As List(Of e_MontoRuta)
    Private loHistorialMontosRutas As List(Of e_MontoRuta)

    Private oePlanVia As e_PlanillaViaje
    Private olPlanVia As l_PlanillaViaje
    Private loPlanVia As List(Of e_PlanillaViaje)

    Private oeComboVehiculo, oeComboLugarOrigen, oeComboLugarDestino As e_Combo
    Private oeRuta As e_Ruta
    Private olRuta As l_Ruta
    Private loRuta As List(Of e_Ruta)

    Private olTrabSeguridad As l_TrabajadorSeguridad
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            If olTrabSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MODIFICA/ELIMINA MONTO RUTA") Then
                MostrarTabs(1, ficMontoRuta, 1)
                MostrarTabs(0, ficMantenimiento, 0)
                Inicializar()
                oeMontoRuta.Modificado = False
                Operacion = "Nuevo"
                cboTipoVehiculo.Focus()
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If olTrabSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MODIFICA/ELIMINA MONTO RUTA") Then
                Operacion = "Editar"
                Inicializar()
                Mostrar()
                MostrarTabs(1, ficMontoRuta, 1)
                MostrarTabs(0, ficMantenimiento, 0)
                cboTipoVehiculo.Focus()
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
            Else
                Throw New Exception("No Tiene Permiso Para Editar el Monto Ruta")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficMantenimiento.SelectedTab.Index
                Case 0
                    If GuardarMontoRuta() Then
                        MostrarTabs(0, ficMontoRuta)
                        Listar()
                    End If
                Case 1
                    VerificarRutas()
                    Dim listaImpo As New List(Of e_MontoRuta)
                    listaImpo.AddRange(loMontoRutaImportar.Where(Function(item) item.IdRuta <> ""))
                    If listaImpo.Count > 0 Then
                        If olMontoRuta.GuardarMasivo(listaImpo, PrefijoIdSucursal) Then
                            mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                            MostrarTabs(0, ficMontoRuta)
                            Listar()
                        End If
                    Else
                        Throw New Exception("No hay Datos que Guardar")
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMontoRuta.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarMontoRuta() Then
                            MostrarTabs(0, ficMontoRuta, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficMontoRuta, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficMontoRuta, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficMontoRuta)
                _ingresando_datos = False
            End If
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griMontoRutas.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griMontoRutas)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If olTrabSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MODIFICA/ELIMINA MONTO RUTA") Then
                If griMontoRutas.Selected.Rows.Count <> 1 Then Throw New Exception("Debe Seleccionar Solo 1 Registro.")
                If Not ValidarMontoRutaPlanilla(griMontoRutas.ActiveRow.Cells("IdRuta").Value.ToString.Trim) Then Throw New Exception("Ruta Ya Se Encuentra Asignada a Planilla Piloto")

                Select Case MessageBox.Show("Desea Eliminar la Informacion?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        EliminarMontoRuta()
                        Listar()
                End Select
            Else
                Throw New Exception("No Tiene Permiso Para Eliminar el Monto Ruta")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_MontoRuta_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficMontoRuta.SelectedTab.Index
            Case 0
                If griMontoRutas.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_MontoRuta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_MontoRuta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_MontoRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarLogicas()
        gf_AsignarEventoSeleccionarTexto(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        oeRuta = New e_Ruta
        oeRuta.TipoOperacion = ""
        loRuta = New List(Of e_Ruta)
        loRuta.AddRange(olRuta.Listar(oeRuta))
        CargarCombos()
        fecDesde.Value = Date.Now.AddDays(-15)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuMontoRuta_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuMontoRuta.Opening
        mnuMontoRuta.Items("ToolStripMenuNuevo").Visible = True
        mnuMontoRuta.Items("ToolStripMenuEditar").Visible = False
        mnuMontoRuta.Items("ToolStripMenuEliminar").Visible = False
        If griMontoRutas.Rows.Count > 0 Then
            mnuMontoRuta.Items("ToolStripMenuEditar").Visible = True
            mnuMontoRuta.Items("ToolStripMenuEliminar").Visible = True
            mnuMontoRuta.Items("ToolStripMenuVigencia").Visible = True
        End If
    End Sub

    Private Sub ToolStripMenuNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuNuevo.Click
        Nuevo()
    End Sub

    Private Sub ToolStripMenuEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEditar.Click
        Editar()
    End Sub

    Private Sub ToolStripMenuEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEliminar.Click
        Eliminar()
    End Sub

    Private Sub ToolStripMenuImportar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuImportar.Click
        Importar()
    End Sub

    Private Sub ToolStripMenuVigencia_Click(sender As Object, e As EventArgs) Handles ToolStripMenuVigencia.Click
        Try
            If griMontoRutas.Selected.Rows.Count > 0 Then
                If olTrabSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MODIFICA/ELIMINA MONTO RUTA") Then
                    CambiarVigencia()
                Else
                    Throw New Exception("No Tiene Permiso Para Modificar la Vigencia del Monto Ruta")
                End If
            End If      
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
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
                loMontoRutaImportar = New List(Of e_MontoRuta)
                For ln_Fila As Integer = 1 To 1200
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        oeComboVehiculo = New e_Combo
                        oeComboVehiculo.Tipo = 1
                        oeComboVehiculo.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If ModeloFuncionalPublic.Contains(oeComboVehiculo) Then
                            oeComboVehiculo = ModeloFuncionalPublic.Item(ModeloFuncionalPublic.IndexOf(oeComboVehiculo))
                        End If
                        oeComboLugarOrigen = New e_Combo
                        oeComboLugarOrigen.Tipo = 1
                        oeComboLugarOrigen.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value)
                        If LugaresPublic.Contains(oeComboLugarOrigen) Then
                            oeComboLugarOrigen = LugaresPublic.Item(LugaresPublic.IndexOf(oeComboLugarOrigen))
                        End If
                        oeComboLugarDestino = New e_Combo
                        oeComboLugarDestino.Tipo = 1
                        oeComboLugarDestino.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                        If LugaresPublic.Contains(oeComboLugarDestino) Then
                            oeComboLugarDestino = LugaresPublic.Item(LugaresPublic.IndexOf(oeComboLugarDestino))
                        End If
                        oeRuta = New e_Ruta
                        oeRuta.TipoOperacion = "R"
                        oeRuta.IdOrigen = oeComboLugarOrigen.Id
                        oeRuta.IdDestino = oeComboLugarDestino.Id
                        If loRuta.Contains(oeRuta) Then
                            oeRuta = loRuta.Item(loRuta.IndexOf(oeRuta))
                        End If

                        oeMontoRuta = New e_MontoRuta
                        oeMontoRuta.Id = String.Empty
                        oeMontoRuta.IdTipoVehiculo = oeComboVehiculo.Id
                        oeMontoRuta.TipoVehiculo = oeComboVehiculo.Nombre
                        oeMontoRuta.IdRuta = oeRuta.Id
                        oeMontoRuta.Origen = IIf(oeRuta.Origen = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeRuta.Origen)
                        oeMontoRuta.Destino = IIf(oeRuta.Destino = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value), oeRuta.Destino)
                        oeMontoRuta.IndCargado = IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value) = "CARGADO", True, False)
                        oeMontoRuta.MontoSolo = CDbl(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value) = "", 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value)))
                        oeMontoRuta.MontoAcompañado = CDbl(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value) = "", 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value)))
                        oeMontoRuta.PorcentajeCopiloto = CDbl(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value) = "", 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value))) * 100
                        oeMontoRuta.BonoSolo = CDbl(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 8).Value) = "", 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 8).Value)))
                        oeMontoRuta.BonoCruceroPiloto = CDbl(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 9).Value) = "", 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 9).Value)))
                        oeMontoRuta.BonoCruceroCopiloto = CDbl(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 10).Value) = "", 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 10).Value)))
                        oeMontoRuta.Cuenta = CInt(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 11).Value) = 0, 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 11).Value)))
                        oeMontoRuta.IndNacional = IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 12).Value) = "SI", True, False)
                        oeMontoRuta.IndCategoria = True
                        oeMontoRuta.UsuarioCreacion = gUsuarioSGI.Id
                        loMontoRutaImportar.Add(oeMontoRuta)
                    Else
                        Exit For
                    End If
                Next
                CargarImportar(loMontoRutaImportar)
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True
                    objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then
                    proceso(proceso.Length - 1).Kill()
                End If
            Else
                OpenFileDialog1.Dispose()
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            Dim proceso() As Process
            proceso = Process.GetProcessesByName("EXCEL")
            If proceso.Length > 0 Then
                proceso(proceso.Length - 1).Kill()
            End If
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griMontoRutas_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griMontoRutas.DoubleClickRow
        If griMontoRutas.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Try
            VerificarRutas()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            LimpiarInactivos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_MontoRuta_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griMontoRutas_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griMontoRutas.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub InicializarLogicas()
        olMontoRuta = New l_MontoRuta
        olPlanVia = New l_PlanillaViaje
        olRuta = New l_Ruta
        olTrabSeguridad = New l_TrabajadorSeguridad
    End Sub

    Public Sub Inicializar()
        oeMontoRuta = New e_MontoRuta
        Agrupacion5.Enabled = True
        cboTipoVehiculo.SelectedIndex = -1
        cboOrigen.SelectedIndex = -1
        cboDestino.SelectedIndex = -1
        rdbCargado.Checked = True
        numMontoSolo.Value = 0
        numMontoAcompañado.Value = 0
        numPorcentajeCopi.Value = 0
        numPorcentajeAyu.Value = 0
        numCruceroC.Value = 0
        numBonoSolo.Value = 0
        numCruceroP.Value = 0
        numCuenta.Value = 0
        chkIndNacional.Checked = True
        loHistorialMontosRutas = New List(Of e_MontoRuta)
        griHistorialMontoRutas.DataSource = loHistorialMontosRutas
        loMontoRutaImportar = New List(Of e_MontoRuta)
        griImportarMontos.DataSource = loMontoRutaImportar
    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMontoRuta = New e_MontoRuta
            loMontoRuta = New List(Of e_MontoRuta)
            griMontoRutas.DataSource = loMontoRuta
            If rdbFechas.Checked Then
                oeMontoRuta.FechaDesde = fecDesde.Value
                oeMontoRuta.FechaHasta = fecHasta.Value
            Else
                If rdbTodos.Checked Then
                    oeMontoRuta.Tipo = 0
                ElseIf rdbCargados.Checked Then
                    oeMontoRuta.Tipo = 1
                ElseIf rdbVacios.Checked Then
                    oeMontoRuta.Tipo = 2
                End If
                If cboRuta.SelectedIndex <> 0 Then oeMontoRuta.IdRuta = cboRuta.Value
                If cboTipoFiltro.SelectedIndex <> 0 Then oeMontoRuta.IdTipoVehiculo = cboTipoFiltro.Value
                loMontoRuta.AddRange(olMontoRuta.Listar(oeMontoRuta))
                griMontoRutas.DataSource = loMontoRuta
            End If
            If griMontoRutas.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub Mostrar()
        Try
            Inicializar()
            oeMontoRuta.Id = griMontoRutas.ActiveRow.Cells("Id").Value
            oeMontoRuta = olMontoRuta.Obtener(oeMontoRuta)
            oePlanVia = New e_PlanillaViaje
            loPlanVia = New List(Of e_PlanillaViaje)
            oePlanVia.IndVacio = Not oeMontoRuta.IndCargado
            oePlanVia.IdRuta = oeMontoRuta.IdRuta
            oePlanVia.TipoOperacion = "3"
            loPlanVia = olPlanVia.Listar(oePlanVia)
            If loPlanVia.Count > 0 Then Agrupacion5.Enabled = False
            With oeMontoRuta
                cboTipoVehiculo.Value = .IdTipoVehiculo
                For Each oeru As e_Ruta In loRuta.Where(Function(item) item.Id = .IdRuta)
                    cboDestino.Value = oeru.IdDestino
                    cboOrigen.Value = oeru.IdOrigen
                Next
                numMontoSolo.Value = .MontoSolo
                numMontoAcompañado.Value = .MontoAcompañado
                numPorcentajeCopi.Value = .PorcentajeCopiloto
                numPorcentajeAyu.Value = .PorcentajeAyudante
                numCuenta.Value = .Cuenta
                numBonoSolo.Value = .BonoSolo
                numCruceroP.Value = .BonoCruceroPiloto
                numCruceroC.Value = .BonoCruceroCopiloto
                chkIndNacional.Checked = IIf(oeMontoRuta.IndNacional, True, False)
                chkIndCategoria.Checked = IIf(oeMontoRuta.IndCategoria, True, False)
                If oeMontoRuta.IndCargado = False Then
                    rdbVacio.Checked = True
                Else
                    rdbCargado.Checked = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GuardarMontoRuta() As Boolean
        Try
            LlenarObjeto()
            If olMontoRuta.Guardar(oeMontoRuta) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub EliminarMontoRuta()
        Try
            oeMontoRuta = New e_MontoRuta
            oeMontoRuta.Id = griMontoRutas.ActiveRow.Cells("Id").Value
            oeMontoRuta.Activo = 0
            oeMontoRuta.UsuarioCreacion = gUsuarioSGI.Id
            If olMontoRuta.Eliminar(oeMontoRuta) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Eliminada Correctamente")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarCombos()
        Try
            LlenarCombo(cboTipoVehiculo, "Nombre", ModeloFuncionalPublic, -1)
            LlenarCombo(cboOrigen, "Nombre", LugaresPublic, -1)
            LlenarCombo(cboDestino, "Nombre", LugaresPublic, -1)
            Dim loTipo As New List(Of e_Combo)
            Dim oeTipo As New e_Combo
            oeTipo.Id = ""
            oeTipo.Nombre = "TODOS"
            loTipo.Add(oeTipo)
            loTipo.AddRange(ModeloFuncionalPublic)
            LlenarCombo(cboTipoFiltro, "Nombre", loTipo, 0)
            Dim oe As New e_Ruta
            Dim loRutaListar As New List(Of e_Ruta)
            oe.Id = ""
            oe.Nombre = "TODOS"
            loRutaListar.Add(oe)
            loRutaListar.AddRange(loRuta)
            LlenarCombo(cboRuta, "Nombre", loRutaListar, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenarObjeto()
        Try
            oeRuta = New e_Ruta
            oeRuta.TipoOperacion = "M"
            oeRuta.IdOrigen = cboOrigen.Value
            oeRuta.IdDestino = cboDestino.Value
            oeRuta = olRuta.Obtener(oeRuta)
            If oeRuta.Id = "" Then Throw New Exception("Ruta no Existe. Verificar")
            If Operacion = "Nuevo" Then
                oeMontoRuta.TipoOperacion = "I"
            Else
                oeMontoRuta.TipoOperacion = "A"
            End If
            oeMontoRuta.Cuenta = numCuenta.Value
            oeMontoRuta.IdTipoVehiculo = cboTipoVehiculo.Value
            oeMontoRuta.IdRuta = oeRuta.Id
            oeMontoRuta.IndCargado = rdbCargado.Checked
            oeMontoRuta.IndNacional = chkIndNacional.Checked
            oeMontoRuta.IndCategoria = chkIndCategoria.Checked
            oeMontoRuta.MontoSolo = numMontoSolo.Value
            oeMontoRuta.MontoAcompañado = numMontoAcompañado.Value
            oeMontoRuta.PorcentajeCopiloto = numPorcentajeCopi.Value
            oeMontoRuta.PorcentajeAyudante = numPorcentajeAyu.Value
            oeMontoRuta.BonoSolo = numBonoSolo.Value
            oeMontoRuta.BonoCruceroPiloto = numCruceroP.Value
            oeMontoRuta.BonoCruceroCopiloto = numCruceroC.Value
            oeMontoRuta.FechaCreacion = ObtenerFechaServidor()
            oeMontoRuta.UsuarioCreacion = gUsuarioSGI.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Importar()
        Try
            MostrarTabs(1, ficMontoRuta, 1)
            MostrarTabs(1, ficMantenimiento, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            CargarImportar(New List(Of e_MontoRuta))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarImportar(ByVal lista As List(Of e_MontoRuta))
        Try
            With griImportarMontos
                Dim leAux As New List(Of e_MontoRuta)
                .DataSource = leAux
                .DataSource = lista
                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("IdRuta").Value.ToString = "" Then
                            Fila.CellAppearance.BackColor = colorNoRegistrados.Color
                            Fila.CellAppearance.ForeColor = Color.White
                        End If
                    Next
                    .Text = "Datos Importados (" & .Rows.Count & ")"
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub VerificarRutas()
        Try
            Dim oeMonRut As New e_MontoRuta
            Dim oe As New e_MontoRuta
            loMontoRutaValidar = New List(Of e_MontoRuta)
            oe.Tipo = 0
            loMontoRutaValidar.AddRange(olMontoRuta.Listar(oe))
            If loMontoRutaImportar.Count > 0 And loMontoRutaValidar.Count > 0 Then
                For Each monrut As e_MontoRuta In loMontoRutaImportar.Where(Function(item) item.IdRuta <> "")
                    oeMonRut = New e_MontoRuta
                    oeMonRut.IdRuta = monrut.IdRuta
                    oeMonRut.IdTipoVehiculo = monrut.IdTipoVehiculo
                    oeMonRut.IndCargado = monrut.IndCargado
                    If loMontoRutaValidar.Contains(oeMonRut) Then
                        oeMonRut = loMontoRutaValidar.Item(loMontoRutaValidar.IndexOf(oeMonRut))
                        monrut.IdRuta = ""
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GeneraMonto(Origen As String, Destino As String)
        Nuevo()
        oeComboLugarOrigen = New e_Combo
        oeComboLugarOrigen.Tipo = 1
        oeComboLugarOrigen.Nombre = Origen
        If LugaresPublic.Contains(oeComboLugarOrigen) Then
            oeComboLugarOrigen = LugaresPublic.Item(LugaresPublic.IndexOf(oeComboLugarOrigen))
        End If
        oeComboLugarDestino = New e_Combo
        oeComboLugarDestino.Tipo = 1
        oeComboLugarDestino.Nombre = Destino
        If LugaresPublic.Contains(oeComboLugarDestino) Then
            oeComboLugarDestino = LugaresPublic.Item(LugaresPublic.IndexOf(oeComboLugarDestino))
        End If
        cboOrigen.Value = oeComboLugarOrigen.Id
        cboDestino.Value = oeComboLugarDestino.Id
    End Sub

    Public Sub LimpiarInactivos()
        Try
            For Each oe As e_MontoRuta In loMontoRutaImportar.Where(Function(i) i.IdRuta = "").ToList
                loMontoRutaImportar.Remove(oe)
            Next
            griImportarMontos.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CambiarVigencia()
        Try
            oeMontoRuta = New e_MontoRuta
            oeMontoRuta.Id = griMontoRutas.ActiveRow.Cells("Id").Value
            oeMontoRuta = olMontoRuta.Obtener(oeMontoRuta)
            Select Case MessageBox.Show("Desea Cambiar la Vigencia de la Ruta: " + oeMontoRuta.Origen + " - " + oeMontoRuta.Destino, _
                                        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    oeMontoRuta.TipoOperacion = "V"
                    If olMontoRuta.Guardar(oeMontoRuta) Then
                        mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                        Consultar(True)
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ValidarMontoRutaPlanilla(IdRuta As String) As Boolean
        Dim oePlanillaViaje As New e_PlanillaViaje
        Dim olPlanillaViaje As New l_PlanillaViaje
        Dim listaPlanillaViaje As New List(Of e_PlanillaViaje)
        oePlanillaViaje.TipoOperacion = "3"
        oePlanillaViaje.IdRuta = IdRuta
        oePlanillaViaje.Activo = True
        listaPlanillaViaje = olPlanillaViaje.Listar(oePlanillaViaje)
        If listaPlanillaViaje.Count > 0 Then Throw New Exception("Ruta Ya Se Encuentra Asignada a Planilla Piloto.")
        Return True
    End Function

#End Region
    
End Class