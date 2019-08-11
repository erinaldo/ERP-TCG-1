Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports MSScriptControl
Imports Microsoft.Office.Interop

Public Class frm_BonificacionProduccion
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_BonificacionProduccion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_BonificacionProduccion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeProduccionPiloto As New e_ProduccionPiloto, olProduccionPiloto As New l_ProduccionPiloto, leProduccionPiloto As New List(Of e_ProduccionPiloto)
    Private oeDetProdPiloto As New e_DetalleProduccionPiloto, olDetProdPiloto As New l_DetalleProduccionPiloto, leDetProdPiloto As New List(Of e_DetalleProduccionPiloto)
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla), lePlanillaGen As New List(Of e_Planilla)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeBonoProd As New e_BonificacionProduccion, olBonoProd As New l_BonificacionProduccion
    Private leBonoProd As New List(Of e_BonificacionProduccion), leBPImportar As New List(Of e_BonificacionProduccion)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeOcupacionTrab As New e_OcupacionTrabajador, olOcupacionTrab As New l_OcupacionTrabajador, leOcupacionTrab As List(Of e_OcupacionTrabajador)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oePlaPiloto As New e_PlanillaPiloto, olPlaPiloto As New l_PlanillaPiloto
    Private oeDetPlaPiloto As New e_PlanillaPilotoDet, olDetPlaPiloto As New l_PlanillaPilotoDet, leDetPlaPiloto As New List(Of e_PlanillaPilotoDet)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private oeConceptoPond As New e_ConceptoPonderado, olConceptoPond As New l_ConceptoPonderado, leConceptoPond As New List(Of e_ConceptoPonderado)
    Private oeDetalleCP As New e_DetalleConceptoPonderado, olDetalleCP As New l_DetalleConceptoPonderado
    Private leDetalleCP As New List(Of e_DetalleConceptoPonderado), leDCPAux As New List(Of e_DetalleConceptoPonderado)
    Private oeDescSancion As New e_PagoDescuento, olDescSancion As New l_PagoDescuento, leDescSancion As New List(Of e_PagoDescuento)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private dsDatosGen As New Data.DataTable
    Private oeAccionUsuario As New e_ActividadRestringida_Usuario
    Private _opeProd As String = "", _acl As String = "", _estado As String = "", _indConsolida As Boolean = False

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griProduccionPiloto.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeProd = "GENERADA"
                oeProduccionPiloto = New e_ProduccionPiloto
                oeProduccionPiloto.TipoOperacion = "I"
                oeProduccionPiloto.Activo = True
                Inicializa()
                txtCodigo.Text = fn_ObtenerCodigo()
                LlenarCombo(cboPlanilla, "Codigo", lePlanillaGen, -1)
                cboPlanilla.ReadOnly = False
                Dim _leCP = leConceptoPond.Where(Function(it) it.Vigente = 1).ToList
                LlenarCombo(cboPonderado, "Nombre", _leCP, -1)
                cboPonderado.ReadOnly = False
                cboEstado.Text = "GENERADA"
                SeleccionarTab(1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.EDITAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeProd = "GENERADA"
                Inicializa()
                LlenarCombo(cboPlanilla, "Codigo", lePlanilla, -1)
                LlenarCombo(cboPonderado, "Nombre", leConceptoPond, -1)
                Mostrar()
                oeProduccionPiloto.TipoOperacion = "A"
                SeleccionarTab(1)
                cboPlanilla.ReadOnly = True
                cboPonderado.ReadOnly = False
                btnPonderado.Enabled = True
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case _opeProd
                Case "GENERADA"
                    RecolectaDatos()
                    oeProduccionPiloto.UsuarioCreacion = gUsuarioSGI.Id
                    If olProduccionPiloto.Guardar(oeProduccionPiloto) Then
                        mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                        SeleccionarTab(0)
                        Consultar(True)
                    End If
                Case "ENVIAR"
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oeProduccionPiloto.IdEstado = cboEstado.Value
                        oeProduccionPiloto.UsuarioModifica = gUsuarioSGI.Id
                        If olProduccionPiloto.Guardar(oeProduccionPiloto) Then
                            mensajeEmergente.Confirmacion("¡El Registro de Producción de Pilotos Nº: " & oeProduccionPiloto.Codigo & _
                                                      " se Envio correctamente!", True)
                            SeleccionarTab(0)
                            Consultar(True)
                        End If
                        
                    End If
                Case "TERMINAR"
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oeProduccionPiloto.IdEstado = cboEstado.Value
                        oeProduccionPiloto.UsuarioModifica = gUsuarioSGI.Id
                        If olProduccionPiloto.Guardar(oeProduccionPiloto) Then
                            mensajeEmergente.Confirmacion("¡El Registro de Producción de Pilotos Nº: " & oeProduccionPiloto.Codigo & _
                                                      " se Termino correctamente!", True)
                            SeleccionarTab(0)
                            Consultar(True)
                        End If
                    End If
                Case "IMPORTAR"
                    Dim _leAux = leBPImportar.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        Dim formulario As frm_AutenticarTrabajador
                        formulario = New frm_AutenticarTrabajador
                        formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                        If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                            Throw New Exception("Ingrese un Clave Correcta")
                        Else
                            If olBonoProd.GuardarMasivo(_leAux) Then
                                mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)
                                SeleccionarTab(0)
                                Consultar(True)
                            End If
                        End If
                    Else
                        Throw New Exception("No hay datos para guardar")
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Select Case ficBonificacionProd.SelectedTab.Index
            Case 1
                If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                    SeleccionarTab(0)
                    Consultar(True)
                End If
            Case 2
                If MessageBox.Show("¿Desea Cancelar la Importación de Datos?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    SeleccionarTab(0)
                    Consultar(True)
                End If

        End Select
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griProduccionPiloto.ActiveRow.Cells("Estado").Value = _estado Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oeProduccionPiloto = New e_ProduccionPiloto
                        oeProduccionPiloto.TipoOperacion = ""
                        oeProduccionPiloto.Id = griProduccionPiloto.ActiveRow.Cells("Id").Value
                        oeProduccionPiloto = olProduccionPiloto.Obtener(oeProduccionPiloto)
                        oeProduccionPiloto.UsuarioModifica = gUsuarioSGI.Id
                        olProduccionPiloto.Eliminar(oeProduccionPiloto)
                        mensajeEmergente.Confirmacion("¡El Registro de Producción de Pilotos Nº: " & oeProduccionPiloto.Codigo & _
                                                             " se ha Eliminado correctamente!", True)
                        SeleccionarTab(0)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("No puede en ELIMINAR el Registro de Producción de Pilotos Nº: " & _
                                        griProduccionPiloto.ActiveRow.Cells("Codigo").Value & " por no esta GENERADA.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Select Case ficBonificacionProd.SelectedTab.Index
                    Case 0
                        If griProduccionPiloto.Rows.Count > 0 Then
                            Exportar_Excel(griProduccionPiloto, "Reg_Prod_Piloto")
                        Else
                            Throw New Exception("No hay Registros para Exportar")
                        End If
                    Case 1
                        Select Case ficDetalle.SelectedTab.Index
                            Case 0
                                If griRutaNacional.Rows.Count > 0 Then
                                    Exportar_Excel(griRutaNacional, "Reg_Ruta_Nacional")
                                End If
                            Case 1
                                If griPacasmayo.Rows.Count > 0 Then
                                    Exportar_Excel(griPacasmayo, "Reg_Pacasmayo")
                                End If
                            Case 4
                                If griBoniProd.Rows.Count > 0 Then
                                    Exportar_Excel(griBoniProd, "Reg_Bono_Produccion")
                                End If
                        End Select
                End Select
                
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_BonificacionProduccion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficBonificacionProd.SelectedTab.Index
            Case 0
                If griProduccionPiloto.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Case 2
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_BonificacionProduccion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_BonificacionProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            SeleccionarTab(0)
            leProduccionPiloto = New List(Of e_ProduccionPiloto)
            CargarProduccionPiloto(leProduccionPiloto)
            leDetProdPiloto = New List(Of e_DetalleProduccionPiloto)
            CargarRutaNacional(leDetProdPiloto)
            CargarPacasmayo(leDetProdPiloto)
            'CargarLima(leDetProdPiloto)
            'CargarVilla(leDetProdPiloto)
            leBPImportar = New List(Of e_BonificacionProduccion)
            CargarBPImporta(leBPImportar)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPlanillaImportar_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanillaImportar.ValueChanged
        Try
            If cboPlanillaImportar.SelectedIndex > -1 Then
                oePlanilla = New e_Planilla
                oePlanilla = cboPlanillaImportar.Items(cboPlanillaImportar.SelectedIndex).ListObject
                fecInicioPI.Value = oePlanilla.FechaInicio
                fecFinPI.Value = oePlanilla.FechaFin
                oeBonoProd = New e_BonificacionProduccion
                oeBonoProd.TipoOperacion = ""
                oeBonoProd.Activo = True
                oeBonoProd.IdPlanilla = oePlanilla.Id
                leBonoProd = olBonoProd.Listar(oeBonoProd)
                If leBonoProd.Count > 0 Then
                    Throw New Exception("¡La Planilla Nº: " & oePlanilla.Codigo & " se encuentra Cerrada!")
                Else
                    btnBuscar.Enabled = True
                End If
            Else
                btnBuscar.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
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
                leBPImportar.Clear()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        etiEjecuta.Text = "Procesando " & ln_Fila & " registros ... "
                        oeBonoProd = New e_BonificacionProduccion
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        With oeBonoProd
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .MontoPlanilla = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value, 2)
                            .MontoCaja = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 4).Value, 2)
                            .IndRuta = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 5).Value, 2)
                            .IdPlanilla = cboPlanillaImportar.Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .Activo = False
                        End With
                        leBPImportar.Add(oeBonoProd)
                    Else
                        Exit For
                    End If
                Next
                CargarBPImporta(leBPImportar) : griBonoProdImporta.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            mensajeEmergente.Confirmacion("Se han Procesado " & leBPImportar.Count & " registros", True)
        Catch ex As Exception
            etiEjecuta.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False
        End Try
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Try
            Dim nroreg As Integer = 0, nrotrab As Integer = 0
            Dim ls_msg As String = String.Empty
            If leBPImportar.Count > 0 Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty : upbLoad.Visible = True
                upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                For Each oeAux In leBPImportar
                    nroreg = nroreg + 1
                    etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leBPImportar.Count
                    upbLoad.Value = Math.Round(nroreg / leBPImportar.Count, 2) * 100
                    ' Verifica si los Trabajadores entan registradas en el SGI
                    If oeAux.IdTrabajador = "" Then
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = oeAux.Dni
                        If leTrabajador.Contains(oeTrabajador) Then
                            Dim _leAux = leTrabajador.Where(Function(it) it.oePersona.Dni = oeTrabajador.oePersona.Dni).ToList
                            If _leAux.Count > 0 Then
                                oeTrabajador = _leAux(0)
                                oeAux.IdTrabajador = oeTrabajador.Id
                                oeAux.Activo = True
                            End If
                        End If
                    Else
                        oeAux.Activo = True
                    End If
                    If oeAux.IdTrabajador.Trim = String.Empty Then nrotrab = nrotrab + 1
                Next
                CargarBPImporta(leBPImportar) : griBonoProdImporta.DataBind()
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            If nrotrab > 0 Then ls_msg = " * " & nrotrab & " Trabajadores no registrados."
            If ls_msg.Trim.Length > 0 Then
                ls_msg = "Se necesita solucionar lo siguente: " & Environment.NewLine & ls_msg
            Else
                ls_msg = "Todos los Datos estan Listos para Importar"
            End If
            mensajeEmergente.Confirmacion("Se Validaron " & leBPImportar.Count & " Registros" & Environment.NewLine & ls_msg, True)
        Catch ex As Exception
            etiEjecuta.Visible = False : upbLoad.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False : upbLoad.Visible = False
        End Try
    End Sub

    Private Sub cboPlanilla_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanilla.ValueChanged
        Try
            If cboPlanilla.SelectedIndex > -1 Then
                Dim _oeplaaux = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
                fecInicio.Value = _oeplaaux.FechaInicio
                fecFin.Value = _oeplaaux.FechaFin
                If oeProduccionPiloto.TipoOperacion = "I" Then
                    Dim oePP As New e_ProduccionPiloto
                    oePP.TipoOperacion = ""
                    oePP.IdPlanilla = _oeplaaux.id
                    oePP.Activo = True
                    oePP = olProduccionPiloto.Obtener(oePP)
                    If oePP.Id <> "" Then
                        btnCargar.Enabled = False
                        cboPlanilla.SelectedIndex = -1
                        Throw New Exception("No se puede Seleccionar la Planilla Nº " & _oeplaaux.Codigo & _
                                            ", ya se encuentra Registrada en Nº: " & oePP.Codigo)
                    Else
                        btnCargar.Enabled = True
                    End If
                    oePeriodo = New e_Periodo
                    oePeriodo.Equivale = 1
                    oePeriodo.Id = _oeplaaux.IdPeriodo
                    If lePeriodo.Contains(oePeriodo) Then
                        oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                        txtGlosa.Text = "BONIFICACION POR PRODUCCION MES " & MonthName(oePeriodo.Mes).ToUpper & " AÑO " & oePeriodo.Ejercicio
                    End If
                Else
                    btnCargar.Enabled = False
                End If
            Else
                fecInicio.Value = Date.Now.Date
                fecFin.Value = Date.Now.Date
                btnCargar.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            If cboPonderado.SelectedIndex = -1 Then Throw New Exception("Seleccione un Concepto Ponderado")
            oePlaPiloto = New e_PlanillaPiloto
            oePlaPiloto.TipoOperacion = "1" : oePlaPiloto.Activo = True
            oePlaPiloto.Id = cboPlanilla.Value
            oePlaPiloto = olPlaPiloto.Obtener(oePlaPiloto)
            If oePlaPiloto IsNot Nothing AndAlso oePlaPiloto.Id.Trim <> "" Then
                If oePlaPiloto.Estado = "ENVIADO" Then
                    Dim _oeTrabAux As New e_Trabajador
                    _oeTrabAux.TipoOperacion = String.Empty : _oeTrabAux.Id = cboPlanilla.Value
                    dsDatosGen = olTrabajador.CargarDatosGenerales(_oeTrabAux).Tables(0)

                    oeDescSancion = New e_PagoDescuento
                    oeDescSancion.TipoOperacion = "" : oeDescSancion.Anio = oePeriodo.Ejercicio
                    oeDescSancion.DobleMes = IIf(oePeriodo.Mes = 12 Or oePeriodo.Mes = 7, 1, 0)
                    oeDescSancion.Indicador = 1 : oeDescSancion.Mes = oePeriodo.Mes
                    leDescSancion = olDescSancion.Listar(oeDescSancion)

                    oeDetalleCP = New e_DetalleConceptoPonderado
                    oeDetalleCP.TipoOperacion = "" : oeDetalleCP.IdConceptoPonderado = cboPonderado.Value : oeDetalleCP.Activo = True
                    leDetalleCP = olDetalleCP.Listar(oeDetalleCP).OrderBy(Function(it) it.NroOrden).ToList

                    oeDetPlaPiloto = New e_PlanillaPilotoDet
                    oeDetPlaPiloto.TipoOperacion = "" : oeDetPlaPiloto.IdPlanillaPiloto = oePlaPiloto.Id
                    leDetPlaPiloto = olDetPlaPiloto.Listar(oeDetPlaPiloto).Where(Function(it) it.Activo = True).ToList
                    If leDetPlaPiloto.Count > 0 Then

                        leDetProdPiloto = New List(Of e_DetalleProduccionPiloto)
                        For Each oeAux In leDetPlaPiloto
                            oeDetProdPiloto = New e_DetalleProduccionPiloto
                            oeDetProdPiloto.TipoOperacion = "I"
                            oeDetProdPiloto.Activo = True
                            oeDetProdPiloto.indCalcular = True
                            oeDetProdPiloto.IdTrabajador = oeAux.IdTrabajador
                            oeDetProdPiloto.Trabajador = oeAux.Trabajador
                            oeDetProdPiloto.IndRuta = oeAux.Tipo
                            oeDetProdPiloto.Produccion = oeAux.MontoTotal
                            oeDetProdPiloto.UsuarioCreacion = gUsuarioSGI.Id
                            leDetProdPiloto.Add(oeDetProdPiloto)
                        Next

                        btnCargar.Enabled = False
                        btnAgregar.Text = "Existen " & leDetProdPiloto.Count & " Registros"
                        btnAgregar.Enabled = True : btnAgregar.Visible = True
                    Else
                        Throw New Exception("No hay Registros en la Planilla de Piloto Nº: " & oePlaPiloto.Codigo)
                    End If
                Else
                    Throw New Exception("La Planilla de Piloto Nº: " & oePlaPiloto.Codigo & " debe estar ENVIADO")
                End If
            Else
                Throw New Exception("No se ha Creado la Planilla de Piloto correspondiente a " & Environment.NewLine & _
                                    "la Planilla Nº: " & cboPlanilla.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If leDetProdPiloto.Count > 0 Then
                If MessageBox.Show("¿Desea Agregar los " & leDetProdPiloto.Count & " Registros?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    Dim _fil As Integer = 0
                    etiEjecuta2.Visible = True : etiEjecuta2.Text = String.Empty
                    Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                    For Each oeAux In leDetProdPiloto
                        _fil = _fil + 1
                        etiEjecuta2.Text = "Procesando " & _fil & " registros ... "
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.Id = oeAux.IdTrabajador : oeTrabajador.TipoBusca = 1
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                            oeAux.Dni = oeTrabajador.oePersona.Dni
                            oeAux.Ocupacion = oeTrabajador.oeOcupacion.Nombre
                            If oeTrabajador.FechaCese <> #1/1/1901# Then oeAux.Activo = False
                        Else
                            oeAux.Activo = False
                        End If
                        If oeAux.Activo Then
                            Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & oeAux.IdTrabajador & "'", "")
                            If _rwAux.Count > 0 Then
                                Dim _dsFila = _rwAux.CopyToDataTable
                                oeAux.DiasTrabajados = _dsFila.Rows(0).Item("DIAS_TRAB")
                                oeAux.DiasInduccion = 0
                                oeAux.Renumeracion = _dsFila.Rows(0).Item("SUELDO")
                            Else
                                Throw New Exception("No hay Datos del Trabajador: " & oeAux.Trabajador)
                            End If
                        End If
                    Next
                    CargarRutaNacional(leDetProdPiloto)
                    CargarPacasmayo(leDetProdPiloto)
                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                    btnAgregar.Enabled = False : btnInduccion.Enabled = True
                    mensajeEmergente.Confirmacion("Se han Procesado " & leDetProdPiloto.Count & " registros", True)
                End If
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False
        End Try
    End Sub

    Private Sub btnConsolidar_Click(sender As Object, e As EventArgs) Handles btnConsolidar.Click
        Try
            If MessageBox.Show("¿Desea Consolidar los Datos Calculados?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim _cad As String = ""
                Dim _ind As Integer = 0
                For Each fila In griRutaNacional.Rows
                    oeDetProdPiloto = New e_DetalleProduccionPiloto
                    oeDetProdPiloto.Equivale = 1
                    oeDetProdPiloto.IdTrabajador = fila.Cells("IdTrabajador").Value
                    If leDetProdPiloto.Contains(oeDetProdPiloto) Then
                        oeDetProdPiloto = leDetProdPiloto.Item(leDetProdPiloto.IndexOf(oeDetProdPiloto))
                        _cad = ""
                        For Each oeAux In leDetalleCP
                            _ind = IIf(fila.Cells(oeAux.Codigo).Value = True, 1, 0)
                            _cad = _cad & oeAux.Codigo & _ind & ","
                        Next
                        If _cad.Trim.Length > 0 Then _cad = _cad.Substring(0, _cad.Length - 1)
                        oeDetProdPiloto.ListaPorcentaje = _cad
                        If oeDetProdPiloto.Id.Trim <> "" Then oeDetProdPiloto.TipoOperacion = "A"
                    End If
                Next
                For Each oeDPP In leDetProdPiloto
                    If oeDPP.Activo Then
                        If oeDPP.NetoBonoProduccion > 0 Or oeDPP.TotalCaja > 0 Then
                            oeBonoProd = New e_BonificacionProduccion
                            oeBonoProd.TipoOperacion = "I"
                            oeBonoProd.Activo = True
                            oeBonoProd.IdTrabajador = oeDPP.IdTrabajador
                            oeBonoProd.Dni = oeDPP.Dni
                            oeBonoProd.Trabajador = oeDPP.Trabajador
                            oeBonoProd.MontoPlanilla = oeDPP.NetoBonoProduccion
                            oeBonoProd.MontoCaja = oeDPP.TotalCaja
                            oeBonoProd.UsuarioCreacion = gUsuarioSGI.Id
                            oeBonoProd.IndRuta = oeDPP.IndRuta + 1
                            leBonoProd.Add(oeBonoProd)
                        End If
                    End If
                Next
                CargarBonoProd(leBonoProd)
                ficDetalle.Tabs(4).Selected = True
                btnConsolidar.Enabled = False : btnReiniciar.Enabled = False : _indConsolida = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Try
            If MessageBox.Show("¿Desea Reiniciar todos los calculos Realizados?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                leDetProdPiloto = New List(Of e_DetalleProduccionPiloto)
                CargarRutaNacional(leDetProdPiloto)
                CargarPacasmayo(leDetProdPiloto)
                'CargarLima(leDetProdPiloto)
                'CargarVilla(leDetProdPiloto)
                leBonoProd = New List(Of e_BonificacionProduccion)
                CargarBonoProd(leBonoProd)
                ndImporte.Value = 0
                btnInduccion.Enabled = False
                btnPonderado.Enabled = False
                btnConsolidar.Enabled = False
                btnReiniciar.Enabled = False
                btnCargar.Enabled = True
                btnAgregar.Visible = False
                ficDetalle.Tabs(0).Selected = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ckDetallePonderado_CheckedChanged(sender As Object, e As EventArgs) Handles ckDetallePonderado.CheckedChanged
        For Each oeDCP In leDetalleCP
            OcultarColumna(griRutaNacional, Not ckDetallePonderado.Checked, oeDCP.Codigo)
        Next
    End Sub

    Private Sub ficDetalle_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficDetalle.SelectedTabChanged
        ckDetallePonderado.Enabled = IIf(ficDetalle.SelectedTab.Index = 0, True, False)
    End Sub

    Private Sub griRutaNacional_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griRutaNacional.ClickCell
        Try
            With griRutaNacional
                If .ActiveRow.Index > -1 Then
                    If cboEstado.Text = "GENERADA" Then
                        'If cboEstado.Text = "ENVIADO" Then
                        Select Case .ActiveCell.Column.Key
                            Case "DiasTrabajados"
                                If Not _indConsolida Then
                                    Dim _montoreg As String
                                    _montoreg = InputBox("Ingrese Días Trabajados:", "Mensaje de Sistema", .ActiveRow.Cells("DiasTrabajados").Value)
                                    If Not IsNumeric(_montoreg) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _montoreg <= 0 Then Throw New Exception("Debe Ingresar un Número mayor igual a Cero")
                                    Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                    .ActiveRow.Cells("DiasTrabajados").Value = _montoreg
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    ModificarBonoProduccionPiloto(idTrabajador)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "Regularizacion"
                                If Not _indConsolida Then
                                    Dim _montoreg As String
                                    _montoreg = InputBox("Ingrese Monto de Regularacion:", "Mensaje de Sistema", .ActiveRow.Cells("Regularizacion").Value)
                                    If Not IsNumeric(_montoreg) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _montoreg < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                    .ActiveRow.Cells("Regularizacion").Value = _montoreg
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    ModificarBonoProduccionPiloto(idTrabajador)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "Reintegro"
                                If Not _indConsolida Then
                                    Dim _montorein As String
                                    _montorein = InputBox("Ingrese Monto de Reintegro:", "Mensaje de Sistema", .ActiveRow.Cells("Reintegro").Value)
                                    If Not IsNumeric(_montorein) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _montorein < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                    .ActiveRow.Cells("Reintegro").Value = _montorein
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    ModificarBonoProduccionPiloto(idTrabajador)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "BonoFijo"
                                If Not _indConsolida Then
                                    Dim _bonofijo As String
                                    _bonofijo = InputBox("Ingrese Bono Fijo:", "Mensaje de Sistema", .ActiveRow.Cells("Reintegro").Value)
                                    If Not IsNumeric(_bonofijo) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _bonofijo < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                    .ActiveRow.Cells("BonoFijo").Value = _bonofijo
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    ModificarBonoProduccionPiloto(idTrabajador)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "BonoFijo2"
                                If Not _indConsolida Then
                                    Dim _bonofijo2 As String
                                    _bonofijo2 = InputBox("Ingrese Bono Fijo:", "Mensaje de Sistema", .ActiveRow.Cells("Reintegro").Value)
                                    If Not IsNumeric(_bonofijo2) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _bonofijo2 < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                    .ActiveRow.Cells("BonoFijo2").Value = _bonofijo2
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    ModificarBonoProduccionPiloto(idTrabajador)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "DescuentoSancion"
                                If Not _indConsolida Then
                                    Dim _montosanc As String
                                    oeDetProdPiloto = New e_DetalleProduccionPiloto
                                    oeDetProdPiloto.Equivale = 1
                                    oeDetProdPiloto.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                    If leDetProdPiloto.Contains(oeDetProdPiloto) Then
                                        oeDetProdPiloto = leDetProdPiloto.Item(leDetProdPiloto.IndexOf(oeDetProdPiloto))
                                        'If oeDetProdPiloto.MontoSancion < 1 Then Throw New Exception("No puede ingresar Descuento por Sanción. Su Deuda es 0.00")
                                        If oeDetProdPiloto.MontoProduccion < 1 Then Throw New Exception("No puede ingresar Descuento por Sanción. Su Produccion es 0.00")
                                        _montosanc = InputBox("Su Saldo Actual >>>>>>>>> " & oeDetProdPiloto.MontoSancion & Environment.NewLine & _
                                                              "Su Cuota Asignada >>>>>>> " & oeDetProdPiloto.Cuota & Environment.NewLine & _
                                                              "Ingrese Monto a Descontar: ",
                                                              "Mensaje de Sistema", .ActiveRow.Cells("DescuentoSancion").Value)
                                        If Not IsNumeric(_montosanc) Then Throw New Exception("Solo se Permite Ingresar Números")
                                        If _montosanc < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                        'If _montosanc > .ActiveRow.Cells("MontoSancion").Value Then Throw New Exception("La Cantidad a descontar es superior a su Deuda (" & .ActiveRow.Cells("MontoSancion").Value & ")")
                                        If _montosanc > .ActiveRow.Cells("MontoProduccion").Value Then Throw New Exception("No tiene Credito Suficiente para Realizar esta Operación")
                                        Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                        .ActiveRow.Cells("DescuentoSancion").Value = _montosanc
                                        .UpdateData() : e.Cell.Row.Selected = True
                                        ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                        ModificarBonoProduccionPiloto(idTrabajador)
                                    End If
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "DiasInduccion"
                                If Not _indConsolida Then
                                    Dim _diasinduc As String
                                    _diasinduc = InputBox("Ingrese Monto de Reintegro:", "Mensaje de Sistema", .ActiveRow.Cells("DiasInduccion").Value)
                                    If Not IsNumeric(_diasinduc) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _diasinduc < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                    .ActiveRow.Cells("DiasInduccion").Value = _diasinduc
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    ModificarBonoProduccionPiloto(idTrabajador)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case Else
                                If Not _indConsolida Then
                                    oeDetalleCP = New e_DetalleConceptoPonderado
                                    oeDetalleCP.Equivale = 2 : oeDetalleCP.Codigo = .ActiveCell.Column.Key
                                    If leDetalleCP.Contains(oeDetalleCP) Then
                                        If .ActiveRow.Cells("BonoProduccion").Value > 0 Then
                                            oeDetalleCP = leDetalleCP.Item(leDetalleCP.IndexOf(oeDetalleCP))
                                            If .ActiveRow.Cells(oeDetalleCP.Codigo).Value = False Then
                                                .ActiveRow.Cells(oeDetalleCP.Codigo).Value = True
                                                .ActiveRow.Cells("TotalPonderado").Value = .ActiveRow.Cells("TotalPonderado").Value + oeDetalleCP.Porcentaje
                                            Else
                                                .ActiveRow.Cells(oeDetalleCP.Codigo).Value = False
                                                .ActiveRow.Cells("TotalPonderado").Value = .ActiveRow.Cells("TotalPonderado").Value - oeDetalleCP.Porcentaje
                                            End If
                                            .UpdateData() : e.Cell.Row.Selected = True
                                            ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                        Else
                                            .ActiveRow.Cells(oeDetalleCP.Codigo).Value = False
                                            .UpdateData()
                                            Throw New Exception("Su Bono por Producción es Cero.")
                                        End If
                                    End If
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                        End Select
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPacasmayo_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griPacasmayo.ClickCell
        Try
            With griPacasmayo
                If .ActiveRow.Index > -1 Then
                    If cboEstado.Text = "GENERADA" Then
                        Select Case .ActiveCell.Column.Key
                            Case "Regularizacion"
                                If Not _indConsolida Then
                                    Dim _montoreg As String
                                    _montoreg = InputBox("Ingrese Monto de Regularacion:", "Mensaje de Sistema", .ActiveRow.Cells("Regularizacion").Value)
                                    If Not IsNumeric(_montoreg) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _montoreg < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                    .ActiveRow.Cells("Regularizacion").Value = _montoreg
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    ModificarBonoProduccionPiloto(idTrabajador)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "Reintegro"
                                If Not _indConsolida Then
                                    Dim _montorein As String
                                    _montorein = InputBox("Ingrese Monto de Reintegro:", "Mensaje de Sistema", .ActiveRow.Cells("Reintegro").Value)
                                    If Not IsNumeric(_montorein) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _montorein < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                    .ActiveRow.Cells("Reintegro").Value = _montorein
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    ModificarBonoProduccionPiloto(idTrabajador)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "DescuentoSancion"
                                If Not _indConsolida Then
                                    Dim _montosanc As String
                                    oeDetProdPiloto = New e_DetalleProduccionPiloto
                                    oeDetProdPiloto.Equivale = 1
                                    oeDetProdPiloto.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                    If leDetProdPiloto.Contains(oeDetProdPiloto) Then
                                        oeDetProdPiloto = leDetProdPiloto.Item(leDetProdPiloto.IndexOf(oeDetProdPiloto))
                                        'If oeDetProdPiloto.MontoSancion < 1 Then Throw New Exception("No puede ingresar Descuento por Sanción. Su Deuda es 0.00")
                                        If oeDetProdPiloto.ProduccionCaja < 1 Then Throw New Exception("No puede ingresar Descuento por Sanción. Su Produccion Caja es 0.00")
                                        _montosanc = InputBox("Su Saldo Actual es >>>>>>> " & oeDetProdPiloto.MontoSancion & Environment.NewLine & _
                                                              "Su Cuota Asignada es >>>>> " & oeDetProdPiloto.Cuota & Environment.NewLine & _
                                                              "Ingrese Monto a Descontar: " & oeDetProdPiloto.DescuentoSancion,
                                                              "Mensaje de Sistema", .ActiveRow.Cells("DescuentoSancion").Value)
                                        If Not IsNumeric(_montosanc) Then Throw New Exception("Solo se Permite Ingresar Números")
                                        If _montosanc < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                        If _montosanc > .ActiveRow.Cells("MontoSancion").Value Then Throw New Exception("La Cantidad a descontar es superior a su Deuda (" & .ActiveRow.Cells("MontoSancion").Value & ")")
                                        If _montosanc > .ActiveRow.Cells("ProduccionCaja").Value Then Throw New Exception("No tiene Credito Suficiente para Realizar esta Operación")
                                        Dim idTrabajador As String = .ActiveRow.Cells("IdTrabajador").Value
                                        .ActiveRow.Cells("DescuentoSancion").Value = _montosanc
                                        .UpdateData() : e.Cell.Row.Selected = True
                                        ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                        ModificarBonoProduccionPiloto(idTrabajador)
                                    End If
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                        End Select
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            e.Cell.CancelUpdate()
        End Try
    End Sub

    Private Sub griLima_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griLima.ClickCell
        Try
            With griLima
                If .ActiveRow.Index > -1 Then
                    If cboEstado.Text = "GENERADA" Then
                        Select Case .ActiveCell.Column.Key
                            Case "Regularizacion"
                                If Not _indConsolida Then
                                    Dim _montoreg As String
                                    _montoreg = InputBox("Ingrese Monto de Regularacion:", "Mensaje de Sistema", .ActiveRow.Cells("Regularizacion").Value)
                                    If Not IsNumeric(_montoreg) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _montoreg < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    .ActiveRow.Cells("Regularizacion").Value = _montoreg
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "DescuentoSancion"
                                If Not _indConsolida Then
                                    Dim _montosanc As String
                                    oeDetProdPiloto = New e_DetalleProduccionPiloto
                                    oeDetProdPiloto.Equivale = 1
                                    oeDetProdPiloto.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                    If leDetProdPiloto.Contains(oeDetProdPiloto) Then
                                        oeDetProdPiloto = leDetProdPiloto.Item(leDetProdPiloto.IndexOf(oeDetProdPiloto))
                                        If oeDetProdPiloto.MontoSancion < 1 Then Throw New Exception("No puede ingresar Descuento por Sanción. Su Deuda es 0.00")
                                        If oeDetProdPiloto.ProduccionCaja < 1 Then Throw New Exception("No puede ingresar Descuento por Sanción. Su Produccion Caja es 0.00")
                                        _montosanc = InputBox("Su Saldo Actual es >>>>>>> " & oeDetProdPiloto.MontoSancion & Environment.NewLine & _
                                                              "Su Cuota Asignada es >>>>> " & oeDetProdPiloto.Cuota & Environment.NewLine & _
                                                              "Ingrese Monto a Descontar: " & oeDetProdPiloto.DescuentoSancion,
                                                              "Mensaje de Sistema", .ActiveRow.Cells("DescuentoSancion").Value)
                                        If Not IsNumeric(_montosanc) Then Throw New Exception("Solo se Permite Ingresar Números")
                                        If _montosanc < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                        If _montosanc > .ActiveRow.Cells("MontoSancion").Value Then Throw New Exception("La Cantidad a descontar es superior a su Deuda (" & .ActiveRow.Cells("MontoSancion").Value & ")")
                                        If _montosanc > .ActiveRow.Cells("ProduccionCaja").Value Then Throw New Exception("No tiene Credito Suficiente para Realizar esta Operación")
                                        .ActiveRow.Cells("DescuentoSancion").Value = _montosanc
                                        .UpdateData() : e.Cell.Row.Selected = True
                                        ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    End If
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                        End Select
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            e.Cell.CancelUpdate()
        End Try
    End Sub

    Private Sub griVillaSalvador_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griVillaSalvador.ClickCell
        Try
            With griVillaSalvador
                If .ActiveRow.Index > -1 Then
                    If cboEstado.Text = "GENERADA" Then
                        Select Case .ActiveCell.Column.Key
                            Case "Regularizacion"
                                If Not _indConsolida Then
                                    Dim _montoreg As String
                                    _montoreg = InputBox("Ingrese Monto de Regularacion:", "Mensaje de Sistema", .ActiveRow.Cells("Regularizacion").Value)
                                    If Not IsNumeric(_montoreg) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _montoreg < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    .ActiveRow.Cells("Regularizacion").Value = _montoreg
                                    .UpdateData() : e.Cell.Row.Selected = True
                                    ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                            Case "DescuentoSancion"
                                If Not _indConsolida Then
                                    Dim _montosanc As String
                                    oeDetProdPiloto = New e_DetalleProduccionPiloto
                                    oeDetProdPiloto.Equivale = 1
                                    oeDetProdPiloto.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                    If leDetProdPiloto.Contains(oeDetProdPiloto) Then
                                        oeDetProdPiloto = leDetProdPiloto.Item(leDetProdPiloto.IndexOf(oeDetProdPiloto))
                                        If oeDetProdPiloto.MontoSancion < 1 Then Throw New Exception("No puede ingresar Descuento por Sanción. Su Deuda es 0.00")
                                        If oeDetProdPiloto.ProduccionCaja < 1 Then Throw New Exception("No puede ingresar Descuento por Sanción. Su Produccion Caja es 0.00")
                                        _montosanc = InputBox("Su Saldo Actual es >>>>>>> " & oeDetProdPiloto.MontoSancion & Environment.NewLine & _
                                                              "Su Cuota Asignada es >>>>> " & oeDetProdPiloto.Cuota & Environment.NewLine & _
                                                              "Ingrese Monto a Descontar: " & oeDetProdPiloto.DescuentoSancion,
                                                              "Mensaje de Sistema", .ActiveRow.Cells("DescuentoSancion").Value)
                                        If Not IsNumeric(_montosanc) Then Throw New Exception("Solo se Permite Ingresar Números")
                                        If _montosanc < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                        If _montosanc > .ActiveRow.Cells("MontoSancion").Value Then Throw New Exception("La Cantidad a descontar es superior a su Deuda (" & .ActiveRow.Cells("MontoSancion").Value & ")")
                                        If _montosanc > .ActiveRow.Cells("ProduccionCaja").Value Then Throw New Exception("No tiene Credito Suficiente para Realizar esta Operación")
                                        .ActiveRow.Cells("DescuentoSancion").Value = _montosanc
                                        .UpdateData() : e.Cell.Row.Selected = True
                                        ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                                    End If
                                Else
                                    Throw New Exception("No se puede Modificar los Datos por que ya se Consolido la Infomación")
                                End If
                        End Select
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            e.Cell.CancelUpdate()
        End Try
    End Sub

    Private Sub griProduccionPiloto_DoubleClick(sender As Object, e As EventArgs) Handles griProduccionPiloto.DoubleClick
        If griProduccionPiloto.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnInduccion_Click(sender As Object, e As EventArgs) Handles btnInduccion.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta2.Visible = True : etiEjecuta2.Text = String.Empty
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
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
                leBPImportar.Clear()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        etiEjecuta2.Text = "Procesando " & ln_Fila & " registros ... "
                        For Each Fil In griRutaNacional.Rows
                            If Fil.Cells("Dni").Value = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value) Then
                                Fil.Cells("DiasInduccion").Value = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                                Exit For
                            End If
                        Next
                    Else
                        Exit For
                    End If
                Next
                griRutaNacional.UpdateData()
                ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            mensajeEmergente.Confirmacion("Se han Procesado con exito registros", True)
            btnPonderado.Enabled = True
        Catch ex As Exception
            etiEjecuta2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False
        End Try
    End Sub

    Private Sub btnPonderado_Click(sender As Object, e As EventArgs) Handles btnPonderado.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta2.Visible = True : etiEjecuta2.Text = String.Empty
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
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
                leBPImportar.Clear()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        etiEjecuta2.Text = "Procesando " & ln_Fila & " registros ... "
                        oeDetalleCP = New e_DetalleConceptoPonderado
                        oeDetalleCP.Equivale = 2 : oeDetalleCP.Codigo = objWorkSheet.Cells(ln_Fila + 1, 3).Value
                        If leDetalleCP.Contains(oeDetalleCP) Then
                            oeDetalleCP = leDetalleCP.Item(leDetalleCP.IndexOf(oeDetalleCP))
                            For Each Fil In griRutaNacional.Rows
                                If Fil.Cells("Dni").Value = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value) Then
                                    If Fil.Cells("BonoProduccion").Value > 0 Then
                                        Fil.Cells(objWorkSheet.Cells(ln_Fila + 1, 3).Value).Value = True
                                        Fil.Cells("TotalPonderado").Value = Fil.Cells("TotalPonderado").Value + oeDetalleCP.Porcentaje
                                    Else
                                        Fil.Cells(objWorkSheet.Cells(ln_Fila + 1, 3).Value).Value = False
                                    End If
                                    Exit For
                                End If
                            Next
                        End If
                    Else
                        Exit For
                    End If
                Next
                griRutaNacional.UpdateData()
                ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            mensajeEmergente.Confirmacion("Se han Procesado con exito registros", True)
            btnConsolidar.Enabled = True : btnReiniciar.Enabled = True
        Catch ex As Exception
            etiEjecuta2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = ""
            oePeriodo.Activo = True
            lePeriodo = olPeriodo.Listar(oePeriodo)

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.Activo = True
            oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla)

            LlenarCombo(cboPlanillaImportar, "Codigo", lePlanilla, -1)

            lePlanillaGen = lePlanilla.Where(Function(it) it.Estado = "GENERADA").ToList

            oeConceptoPond = New e_ConceptoPonderado
            oeConceptoPond.TipoOperacion = ""
            oeConceptoPond.Activo = True
            oeConceptoPond.Tipo = 0
            oeConceptoPond.Vigente = -1
            leConceptoPond = olConceptoPond.Listar(oeConceptoPond)

            oeEstado = New e_Estado
            oeEstado.Nombre = "BONIFICACION"
            leEstado = olEstado.Listar(oeEstado)

            LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            Dim _leEstaAux As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Id = ""
            oeEstado.Nombre = " [TODOS] "
            _leEstaAux.Add(oeEstado)
            _leEstaAux.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstaAux, 0)

            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = ""
            oeSueldo.Activo = True
            oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)

            oeOcupacionTrab = New e_OcupacionTrabajador
            oeOcupacionTrab.TipoOperacion = ""
            oeOcupacionTrab.Principal = 1
            leOcupacionTrab = olOcupacionTrab.Listar(oeOcupacionTrab)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = ""
            oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)

            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = ""
            oeDetParametro.Activo = True
            oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = ""
            oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeProduccionPiloto = New e_ProduccionPiloto
            oeProduccionPiloto.TipoOperacion = ""
            oeProduccionPiloto.Activo = True
            'oeRentencionQuinta.IdPlanilla = cboPlanillaBus.Value
            oeProduccionPiloto.IdEstado = cboEstadoBus.Value
            leProduccionPiloto = olProduccionPiloto.Listar(oeProduccionPiloto)
            CargarProduccionPiloto(leProduccionPiloto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarProduccionPiloto(leProdPiloto As List(Of e_ProduccionPiloto))
        Try
            With griProduccionPiloto
                .ResetDisplayLayout()
                .Text = "Lista Mensual de Bonificacion por Producción"
                .DataSource = leProdPiloto
                OcultarColumna(griProduccionPiloto, True, "Id", "IdPlanilla", "IdEstado", "FechaCreacion", "UsuarioCreacion", "FechaModifica", _
                               "UsuarioModifica", "Activo", "IdConceptoPonderado")
                ExcluirColumna(griProduccionPiloto, "Id", "IdPlanilla", "IdEstado", "Activo")
                FormatoColumna(griProduccionPiloto, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Planilla").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Descripcion").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 500
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                CalcularTotales(griProduccionPiloto, "Monto")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SeleccionarTab(_index)
        ficBonificacionProd.Tabs(0).Enabled = False
        ficBonificacionProd.Tabs(1).Enabled = False
        ficBonificacionProd.Tabs(2).Enabled = False
        ficBonificacionProd.Tabs(_index).Enabled = True
        ficBonificacionProd.Tabs(_index).Selected = True
    End Sub

    Private Sub CargarRutaNacional(leRutaNac As List(Of e_DetalleProduccionPiloto))
        Try
            With griRutaNacional

                .ResetDisplayLayout()
                Dim _leRN = leRutaNac.Where(Function(it) it.Activo = True And it.IndRuta = 0).ToList
                .Text = "Relación de Trabajadores de Ruta Nacional (" & _leRN.Count & ")"
                .DataSource = _leRN
                ConfiguraGriDet(griRutaNacional, 1)

                For Each col In .DisplayLayout.Bands(0).Columns
                    col.CellActivation = Activation.NoEdit : col.CellClickAction = CellClickAction.CellSelect
                Next

                Dim _ncol As Integer = 0
                If leDetalleCP.Count > 0 Then
                    For Each oeAux In leDetalleCP
                        _ncol = _ncol + 1
                        .DisplayLayout.Bands(0).Columns.Add(oeAux.Codigo, oeAux.Abreviatura)
                        .DisplayLayout.Bands(0).Columns(oeAux.Codigo).DataType = System.Type.GetType("System.Boolean")
                        .DisplayLayout.Bands(0).Columns(oeAux.Codigo).DefaultCellValue = False
                        .DisplayLayout.Bands(0).Columns(oeAux.Codigo).Header.VisiblePosition = 13 + _ncol
                        .DisplayLayout.Bands(0).Columns(oeAux.Codigo).Width = 70
                        .DisplayLayout.Bands(0).Columns(oeAux.Codigo).CellAppearance.BackColor = Color.LightCyan
                        If cboEstado.Text = gNombreEstadoGenerada Then
                            .DisplayLayout.Bands(0).Columns(oeAux.Codigo).CellActivation = Activation.AllowEdit
                            .DisplayLayout.Bands(0).Columns(oeAux.Codigo).CellClickAction = CellClickAction.Edit
                        Else
                            .DisplayLayout.Bands(0).Columns(oeAux.Codigo).CellActivation = Activation.NoEdit
                            .DisplayLayout.Bands(0).Columns(oeAux.Codigo).CellClickAction = CellClickAction.CellSelect
                        End If
                    Next
                End If

                .DisplayLayout.Bands(0).Columns("TotalPonderado").Header.VisiblePosition = 13 + _ncol + 1
                .DisplayLayout.Bands(0).Columns("ProduccionCaja").Header.VisiblePosition = 13 + _ncol + 2
                .DisplayLayout.Bands(0).Columns("Regularizacion").Header.VisiblePosition = 13 + _ncol + 3
                .DisplayLayout.Bands(0).Columns("TotalCaja").Header.VisiblePosition = 13 + _ncol + 4
                .DisplayLayout.Bands(0).Columns("MontoProduccion").Header.VisiblePosition = 13 + _ncol + 5
                .DisplayLayout.Bands(0).Columns("MontoSancion").Header.VisiblePosition = 13 + _ncol + 6
                .DisplayLayout.Bands(0).Columns("DescuentoSancion").Header.VisiblePosition = 13 + _ncol + 7
                .DisplayLayout.Bands(0).Columns("NetoBonoProduccion").Header.VisiblePosition = 13 + _ncol + 8

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPacasmayo(lePacas As List(Of e_DetalleProduccionPiloto))
        Try
            With griPacasmayo
                .ResetDisplayLayout()
                Dim _lePyo = lePacas.Where(Function(it) it.Activo = True And it.IndRuta = 1).ToList
                .Text = "Relación de Trabajadores de Pacasmayo (" & _lePyo.Count & ")"
                .DataSource = _lePyo
                ConfiguraGriDet(griPacasmayo, 2)
                For Each col In .DisplayLayout.Bands(0).Columns
                    col.CellActivation = Activation.NoEdit : col.CellClickAction = CellClickAction.CellSelect
                Next
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarLima(leLima As List(Of e_DetalleProduccionPiloto))
        Try
            With griLima
                .ResetDisplayLayout()
                Dim _leLu = leLima.Where(Function(it) it.Activo = True And it.IndRuta = 2).ToList
                .Text = "Relación de Trabajadores de Lima (" & _leLu.Count & ")"
                .DataSource = _leLu
                ConfiguraGriDet(griLima, 3)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarVilla(leVilla As List(Of e_DetalleProduccionPiloto))
        Try
            With griVillaSalvador
                .ResetDisplayLayout()
                Dim _leVS = leVilla.Where(Function(it) it.Activo = True And it.IndRuta = 3).ToList
                .Text = "Relación de Trabajadores de Villa Salvador (" & _leVS.Count & ")"
                .DataSource = _leVS
                ConfiguraGriDet(griVillaSalvador, 4)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarBPImporta(leBPI As List(Of e_BonificacionProduccion))
        Try
            With griBonoProdImporta
                .ResetDisplayLayout()
                .DataSource = leBPI
                If leBPI.Count > 0 Then btnVerificar.Enabled = True
            End With
            ConfiguraGrilla(griBonoProdImporta, 2)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarBonoProd(leBonoProd As List(Of e_BonificacionProduccion))
        Try
            With griBoniProd
                .ResetDisplayLayout()
                Dim _leBP = leBonoProd.Where(Function(it) it.Activo = True).ToList
                'Dim _leBP = leBonoProd.OrderBy(Function(it) it.Trabajador).ToList
                .Text = "Consolidado de Trabajadores (" & _leBP.Count & ")"
                .DataSource = _leBP.OrderBy(Function(it) it.Trabajador).ToList
            End With
            ConfiguraGrilla(griBoniProd, 1)
            CalcularTotales(griBoniProd, "MontoPlanilla", "MontoCaja")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(Grilla As UltraGrid, Tipo As Integer)
        Try
            With Grilla

                OcultarColumna(Grilla, True, "Id", "IdPlanilla", "IdTrabajador", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica")

                If Tipo <> 2 Then .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("Dni").Width = 80

                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MontoPlanilla", "MontoCaja")

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGriDet(Grilla As UltraGrid, tipo As Integer)
        Try
            With Grilla
                OcultarColumna(Grilla, True, "Id", "IdProduccionPiloto", "IdTrabajador", "IndRuta", "FechaCreacion", "UsuarioCreacion", _
                               "FechaModifca", "UsuarioModifica", "Activo", "ListaPorcentaje", "MontoSancion")
                If tipo = 2 Then
                    OcultarColumna(Grilla, True, "BonoProduccion", "TotalPonderado", "ProduccionCaja", "Regularizacion", "DescuentoSancion", _
                                   "TotalCaja", "DiasInduccion", "BonoFijo", "BonoFijo2")
                End If
                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Produccion", "Renumeracion", "BonoFijo2", _
                               "BonoFijo", "IngresoNeto", "TotalProduccion", "BonoProduccion", "TotalPonderado", "ProduccionCaja", _
                               "MontoProduccion", "DescuentoSancion", "NetoBonoProduccion", "TotalCaja", "MontoSancion", "Reintegro", "Regularizacion")
                ColorFondoColumna(Grilla, Color.Moccasin, "Trabajador", "Dni", "Ocupacion", "Renumeracion")
                ColorFondoColumna(Grilla, Color.LightYellow, "Regularizacion", "DescuentoSancion", "Reintegro", "DiasInduccion", "BonoFijo", "BonoFijo2")
                ColorFondoColumna(Grilla, Color.LightCyan, "Produccion", "Reintegro")
                ColorFondoColumna(Grilla, Color.LightSkyBlue, "IngresoNeto", "TotalProduccion", "TotalPonderado")
                CongelaColumna(Grilla, "Dni", "Trabajador")
                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("Dni").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Ocupacion").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Renumeracion").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("DiasTrabajados").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("DiasInduccion").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("IngresoNeto").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Produccion").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("BonoFijo").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("Reintegro").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("TotalProduccion").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("BonoProduccion").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("TotalPonderado").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("ProduccionCaja").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("BonoFijo2").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("Regularizacion").Header.VisiblePosition = 17
                .DisplayLayout.Bands(0).Columns("MontoSancion").Header.VisiblePosition = 18
                .DisplayLayout.Bands(0).Columns("DescuentoSancion").Header.VisiblePosition = 19
                .DisplayLayout.Bands(0).Columns("TotalCaja").Header.VisiblePosition = 20
                .DisplayLayout.Bands(0).Columns("MontoProduccion").Header.VisiblePosition = 21
                .DisplayLayout.Bands(0).Columns("NetoBonoProduccion").Header.VisiblePosition = 22

                .DisplayLayout.Bands(0).Columns("Renumeracion").Header.Caption = "Sueldo"
                .DisplayLayout.Bands(0).Columns("DiasTrabajados").Header.Caption = "Dias Trab."
                .DisplayLayout.Bands(0).Columns("DiasInduccion").Header.Caption = "Dias Ind."
                .DisplayLayout.Bands(0).Columns("IngresoNeto").Header.Caption = "Ingreso"
                .DisplayLayout.Bands(0).Columns("TotalProduccion").Header.Caption = "Tot. Prod."
                .DisplayLayout.Bands(0).Columns("BonoProduccion").Header.Caption = "Bono Prod."
                .DisplayLayout.Bands(0).Columns("TotalPonderado").Header.Caption = "Tot. Pond."
                .DisplayLayout.Bands(0).Columns("ProduccionCaja").Header.Caption = "Prod. Caja"
                .DisplayLayout.Bands(0).Columns("MontoProduccion").Header.Caption = "Monto Prod."
                .DisplayLayout.Bands(0).Columns("DescuentoSancion").Header.Caption = "Monto Dsto."
                .DisplayLayout.Bands(0).Columns("NetoBonoProduccion").Header.Caption = "Neto Prod."
                .DisplayLayout.Bands(0).Columns("Regularizacion").Header.Caption = "Monto Reg."
                .DisplayLayout.Bands(0).Columns("TotalCaja").Header.Caption = "Pago Caja"
                .DisplayLayout.Bands(0).Columns("MontoSancion").Header.Caption = "Deuda"
                '.DisplayLayout.Bands(0).Columns("Descuentos").Header.Caption = "Dscto."

                .DisplayLayout.Bands(0).Columns("NetoBonoProduccion").CellAppearance.BackColor = Color.Navy
                .DisplayLayout.Bands(0).Columns("NetoBonoProduccion").CellAppearance.ForeColor = Color.White
                .DisplayLayout.Bands(0).Columns("TotalCaja").CellAppearance.BackColor = Color.Navy
                .DisplayLayout.Bands(0).Columns("TotalCaja").CellAppearance.ForeColor = Color.White

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                'If tipo <> 1 Then
                '    For Each col In .DisplayLayout.Bands(0).Columns
                '        If col.Key = "Regularizacion" Or col.Key = "DescuentoSancion" Then
                '            col.CellActivation = Activation.AllowEdit : col.CellClickAction = CellClickAction.Edit
                '        Else
                '            col.CellActivation = Activation.NoEdit : col.CellClickAction = CellClickAction.CellSelect
                '        End If
                '    Next
                'End If
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1 : .DisplayLayout.MaxRowScrollRegions = 1
            End With
            CalcularTotales(Grilla, "NetoBonoProduccion", "TotalCaja")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        txtCodigo.Text = String.Empty
        cboEstado.SelectedIndex = -1
        cboPlanilla.SelectedIndex = -1
        ndImporte.Value = 0
        ndImporte.ReadOnly = True
        cboEstado.ReadOnly = True
        btnCargar.Enabled = False
        btnAgregar.Visible = False
        btnInduccion.Enabled = False
        btnPonderado.Enabled = False
        btnConsolidar.Enabled = False
        btnReiniciar.Enabled = False
        txtCodigo.ReadOnly = True
        ckDetallePonderado.Checked = True
        ficDetalle.Tabs(0).Selected = True
        ficDetalle.Tabs(2).Visible = False
        ficDetalle.Tabs(3).Visible = False
        oePeriodo = New e_Periodo
        leBonoProd = New List(Of e_BonificacionProduccion)
        CargarBonoProd(leBonoProd)
        leDetProdPiloto = New List(Of e_DetalleProduccionPiloto)
        leDetalleCP = New List(Of e_DetalleConceptoPonderado)
        CargarRutaNacional(leDetProdPiloto)
        CargarPacasmayo(leDetProdPiloto)
        CargarLima(leDetProdPiloto)
        CargarVilla(leDetProdPiloto)
        _indConsolida = False
    End Sub

    Private Sub Mostrar()
        Try
            oeProduccionPiloto = New e_ProduccionPiloto
            oeProduccionPiloto.TipoOperacion = "" : oeProduccionPiloto.Id = griProduccionPiloto.ActiveRow.Cells("Id").Value
            oeProduccionPiloto = olProduccionPiloto.Obtener(oeProduccionPiloto)
            With oeProduccionPiloto
                txtCodigo.Text = .Codigo
                cboEstado.Value = .IdEstado
                cboPlanilla.Value = .IdPlanilla
                Dim _oeplaaux = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
                fecInicio.Value = _oeplaaux.FechaInicio
                fecFin.Value = _oeplaaux.FechaFin
                ndImporte.Value = .Monto
                txtGlosa.Text = .Descripcion.Trim
                cboPonderado.Value = .IdConceptoPonderado

                leBonoProd = .leBonoProd
                CargarBonoProd(leBonoProd)

                oeDetalleCP = New e_DetalleConceptoPonderado
                oeDetalleCP.TipoOperacion = String.Empty : oeDetalleCP.IdConceptoPonderado = .IdConceptoPonderado : oeDetalleCP.Activo = True
                leDetalleCP = olDetalleCP.Listar(oeDetalleCP).OrderBy(Function(it) it.NroOrden).ToList

                leDetProdPiloto = .leDetalle

                If .IdEstado = "1CH00014" And leDetProdPiloto.Count > 0 Then
                    For i As Integer = 0 To leDetProdPiloto.Count - 1
                        leDetProdPiloto(i).indCalcular = True
                    Next
                End If

                CargarRutaNacional(leDetProdPiloto)
                CargarPacasmayo(leDetProdPiloto)
                CargarPonderado()

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaDatos()
        oeProduccionPiloto.Codigo = txtCodigo.Text
        oeProduccionPiloto.Monto = ndImporte.Value
        oeProduccionPiloto.IdEstado = cboEstado.Value
        oeProduccionPiloto.IdPlanilla = cboPlanilla.Value
        oeProduccionPiloto.Descripcion = txtGlosa.Text.Trim
        oeProduccionPiloto.IdConceptoPonderado = cboPonderado.Value
        oeProduccionPiloto.leDetalle = leDetProdPiloto.Where(Function(it) it.Activo = True).ToList
        'oeProduccionPiloto.leBonoProd = leBonoProd.Where(Function(it) it.Activo = True).ToList
        oeProduccionPiloto.leBonoProd = leBonoProd
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oePP As New e_ProduccionPiloto
            oePP.TipoOperacion = "U"
            oePP = olProduccionPiloto.Obtener(oePP)
            If oePP IsNot Nothing AndAlso oePP.Codigo <> "" Then
                str = oePP.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Enviar()
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griProduccionPiloto.ActiveRow.Cells("Estado").Value = _estado AndAlso griProduccionPiloto.ActiveRow.Cells("Monto").Value > 0 Then
                    Editar()
                    _estado = gNombreEstadoEnviado
                    cboEstado.Text = _estado
                    _opeProd = "ENVIAR"
                Else
                    Throw New Exception("No puede en ENVIAR el Registro de Produccion de Piloto" & Environment.NewLine & _
                                        "Nº: " & griProduccionPiloto.ActiveRow.Cells("Codigo").Value & " por que no esta en GENERADA." & _
                                        Environment.NewLine & "O no tiene ni un solo registro de detalle.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Extornar()
        Try
            _acl = gAccionSistema.EXTORNAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griProduccionPiloto.ActiveRow.Cells("Estado").Value = _estado Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oeProduccionPiloto = New e_ProduccionPiloto
                        oeProduccionPiloto.TipoOperacion = ""
                        oeProduccionPiloto.Id = griProduccionPiloto.ActiveRow.Cells("Id").Value
                        oeProduccionPiloto = olProduccionPiloto.Obtener(oeProduccionPiloto)
                        oeProduccionPiloto.TipoOperacion = "A"
                        _estado = gNombreEstadoGenerada
                        Dim _leEst = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                        If _leEst.Count > 0 Then
                            oeProduccionPiloto.IdEstado = _leEst(0).Id
                            oeProduccionPiloto.UsuarioModifica = gUsuarioSGI.Id
                            olProduccionPiloto.Guardar(oeProduccionPiloto)
                            mensajeEmergente.Confirmacion("¡El Registro de Producción de Pilotos Nº: " & oeProduccionPiloto.Codigo & _
                                                          " se Extornado correctamente!", True)
                            SeleccionarTab(0)
                            Consultar(True)
                        End If
                    End If
                Else
                    Throw New Exception("No se puede EXTORNAR el Registro de Producción de Pilotos" & Environment.NewLine & _
                                        "Nº: " & griProduccionPiloto.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Terminar()
        Try
            _acl = gAccionSistema.TERMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griProduccionPiloto.ActiveRow.Cells("Estado").Value = _estado Then
                    Editar()
                    _estado = gNombreEstadoTerminada.ToString
                    cboEstado.Text = _estado
                    _opeProd = "TERMINAR"
                Else
                    Throw New Exception("No puede TERMINAR el Registro de Producción de Pilotos" & Environment.NewLine & _
                                        "Nº: " & griProduccionPiloto.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Importar()
        Try
            _acl = gAccionSistema.IMPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeProd = "IMPORTAR"
                SeleccionarTab(2)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                cboPlanillaImportar.SelectedIndex = -1
                btnBuscar.Enabled = False
                btnVerificar.Enabled = False
                leBPImportar = New List(Of e_BonificacionProduccion)
                CargarBPImporta(leBPImportar)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarPonderado()
        Try
            Dim sLP As String() = Nothing
            Dim _codcp As String = "", _indcp As Boolean = False
            If griRutaNacional.Rows.Count > 0 Then
                For Each fil In griRutaNacional.Rows
                    If fil.Cells("ListaPorcentaje").Value.ToString.Trim.Length > 0 Then
                        sLP = fil.Cells("ListaPorcentaje").Value.ToString.Split(",")
                        For i = 0 To sLP.Length - 1
                            _codcp = sLP(i).Substring(0, 5)
                            _indcp = IIf(sLP(i).Substring(5) = "1", True, False)
                            fil.Cells(_codcp).Value = _indcp
                        Next
                    End If
                Next
                griRutaNacional.UpdateData()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mnuBonoProd_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuBonoProd.Opening
        mnuBonoProd.Items("tsmiNuevo").Enabled = True
        mnuBonoProd.Items("tsmiImportar").Enabled = True
        mnuBonoProd.Items("tsmiExportar").Enabled = IIf(griProduccionPiloto.Rows.Count > 0, True, False)
        If griProduccionPiloto.Selected.Rows.Count > 0 Then
            mnuBonoProd.Items("tsmiEditar").Enabled = True
            mnuBonoProd.Items("tsmiEliminar").Enabled = True
            mnuBonoProd.Items("tsmiEnviar").Enabled = True
            mnuBonoProd.Items("tsmiExtornar").Enabled = True
            mnuBonoProd.Items("tsmiTerminar").Enabled = True
        Else
            mnuBonoProd.Items("tsmiEditar").Enabled = False
            mnuBonoProd.Items("tsmiEliminar").Enabled = False
            mnuBonoProd.Items("tsmiEnviar").Enabled = False
            mnuBonoProd.Items("tsmiExtornar").Enabled = False
            mnuBonoProd.Items("tsmiTerminar").Enabled = False
        End If
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Try
            Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Try
            If griProduccionPiloto.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Try
            If griProduccionPiloto.Selected.Rows.Count > 0 Then Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEnviar_Click(sender As Object, e As EventArgs) Handles tsmiEnviar.Click
        Try
            If griProduccionPiloto.Selected.Rows.Count > 0 Then Enviar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExtornar_Click(sender As Object, e As EventArgs) Handles tsmiExtornar.Click
        Try
            If griProduccionPiloto.Selected.Rows.Count > 0 Then Extornar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiTerminar_Click(sender As Object, e As EventArgs) Handles tsmiTerminar.Click
        Try
            If griProduccionPiloto.Selected.Rows.Count > 0 Then Terminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Try
            If griProduccionPiloto.Rows.Count > 0 Then Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiImportar_Click(sender As Object, e As EventArgs) Handles tsmiImportar.Click
        Importar()
    End Sub

#End Region

    Private Sub btnReintegro_Click(sender As Object, e As EventArgs) Handles btnReintegro.Click
        Try
            Dim objetoAux As e_DetalleProduccionPiloto
            Dim listaAux As New List(Of e_DetalleProduccionPiloto)
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                leBPImportar.Clear()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        etiEjecuta.Text = "Procesando " & ln_Fila & " registros ... "
                        objetoAux = New e_DetalleProduccionPiloto
                        objetoAux.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        objetoAux.Reintegro = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value, 2)
                        listaAux.Add(objetoAux)
                    Else
                        Exit For
                    End If
                Next

                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If

            ''''validar que todos los dni coincidan con la data sino alertar
            Dim dniExiste As Boolean = False
            For Each i In listaAux
                dniExiste = False
                For Each j In leDetProdPiloto
                    If i.Dni = j.Dni Then
                        dniExiste = True
                        Exit For
                    End If
                    If Not IsNumeric(i.Reintegro) Then Throw New Exception("El DNI: " & i.Dni & " tiene reingreso incorrecto.")
                Next
                If Not dniExiste Then Throw New Exception("El DNI: " & i.Dni & " no se encuentra en la ruta.")
            Next

            ''''agregar reintegro a la data            
            For Each i In listaAux
                For Each j In leDetProdPiloto
                    If i.Dni = j.Dni Then
                        j.Reintegro = i.Reintegro + j.Reintegro
                    End If
                Next
            Next
            ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
            mensajeEmergente.Confirmacion("Se han Procesado " & listaAux.Count & " registros", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ModificarBonoProduccionPiloto(ByVal IdTrabajador As String)
        Try
            Dim bonoProduccion As Decimal = 0.0
            For i As Integer = 0 To leDetProdPiloto.Count - 1
                If leDetProdPiloto(i).IdTrabajador = IdTrabajador Then
                    leDetProdPiloto(i).TipoOperacion = IIf(leDetProdPiloto(i).TipoOperacion = "I", "I", "A")
                    leDetProdPiloto(i).UsuarioModifica = gUsuarioSGI.Id
                    bonoProduccion = leDetProdPiloto(i).NetoBonoProduccion
                    Exit For
                End If
            Next

            oeDetProdPiloto = New e_DetalleProduccionPiloto
            oeDetProdPiloto.Equivale = 1
            oeDetProdPiloto.IdTrabajador = IdTrabajador
            If leDetProdPiloto.Contains(oeDetProdPiloto) Then
                oeDetProdPiloto = leDetProdPiloto.Item(leDetProdPiloto.IndexOf(oeDetProdPiloto))
            End If

            If leBonoProd.Count > 0 Then
                'agregar o modificar o quitar bono produccion
                Dim existe As Boolean = False
                For i As Integer = 0 To leBonoProd.Count - 1
                    If leBonoProd(i).IdTrabajador = IdTrabajador Then 'actualizar bonoproduccion
                        If oeDetProdPiloto.NetoBonoProduccion > 0 Then
                            leBonoProd(i).TipoOperacion = IIf(leBonoProd(i).Id = "", "I", "A")
                            leBonoProd(i).MontoPlanilla = oeDetProdPiloto.NetoBonoProduccion
                            leBonoProd(i).Activo = True
                            leBonoProd(i).UsuarioModifica = gUsuarioSGI.Id
                        Else
                            leBonoProd(i).TipoOperacion = "E"
                            leBonoProd(i).Activo = False
                            leBonoProd(i).UsuarioModifica = gUsuarioSGI.Id
                        End If
                        existe = True
                        Exit For
                    End If
                Next

                If Not existe And bonoProduccion > 0 Then 'insertar a bonoproduccion
                    oeBonoProd = New e_BonificacionProduccion
                    oeBonoProd.TipoOperacion = "I"
                    oeBonoProd.Activo = True
                    oeBonoProd.IdTrabajador = IdTrabajador
                    oeBonoProd.Dni = oeDetProdPiloto.Dni
                    oeBonoProd.Trabajador = oeDetProdPiloto.Trabajador
                    oeBonoProd.MontoPlanilla = oeDetProdPiloto.NetoBonoProduccion
                    oeBonoProd.MontoCaja = oeDetProdPiloto.TotalCaja
                    oeBonoProd.UsuarioCreacion = gUsuarioSGI.Id
                    oeBonoProd.IndRuta = oeDetProdPiloto.IndRuta + 1
                    leBonoProd.Add(oeBonoProd)
                End If
                CargarBonoProd(leBonoProd)
                griBoniProd.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class