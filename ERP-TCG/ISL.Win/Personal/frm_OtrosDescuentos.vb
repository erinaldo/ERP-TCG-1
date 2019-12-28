'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports MSScriptControl
Imports Microsoft.Office.Interop

Public Class frm_OtrosDescuentos
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_OtrosDescuentos = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_OtrosDescuentos()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeOtrosDescuentos As New e_OtrosDescuentos, olOtrosDescuentos As New l_OtrosDescuentos
    Private leOtrosDescuentos As New List(Of e_OtrosDescuentos), leODImportar As New List(Of e_OtrosDescuentos)
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla), lePlanillaGen As New List(Of e_Planilla)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador), leTrabajadorAct As New List(Of e_Trabajador)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)
    Private oeCtaCtePer As New e_CuentaCtePersonal, olCtaCtePersonal As New l_CuentaCtePersonal, leCtaCtePersonal As New List(Of e_CuentaCtePersonal)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private oeGrati As New e_Gratificacion, olGrati As New l_Gratificacion, leGrati As New List(Of e_Gratificacion)
    Private olPersona As New l_Persona
    Private _asigfam As Double = 0
    Private oeAccionUsuario As New e_ActividadRestringida_Usuario
    Private _opeOD As String = "", _acl As String = "", _estado As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griOtrosDescuentos.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
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
                _opeOD = "GENERADA"
                oeOtrosDescuentos = New e_OtrosDescuentos
                oeOtrosDescuentos.TipoOperacion = "I"
                oeOtrosDescuentos.Activo = True
                Inicializa()
                LlenarCombo(cboPlanilla, "Codigo", lePlanillaGen, -1)
                cboPlanilla.ReadOnly = False
                Dim _leTrabAct = From le In leTrabajadorAct _
                                 Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado
                                 Where Activo = True And IndEstado <> 0
                                 Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAct.ToList, -1)
                cboTrabajador.ReadOnly = False
                cboEstado.Text = "GENERADA"
                SeleccionarTab(1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
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
                _opeOD = "GENERADA"
                Inicializa()
                LlenarCombo(cboPlanilla, "Codigo", lePlanilla, -1)
                cboPlanilla.ReadOnly = True
                Dim _leTrab = From le In leTrabajador _
                             Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni
                             Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrab.ToList, -1)
                cboTrabajador.ReadOnly = True
                Mostrar()
                oeOtrosDescuentos.TipoOperacion = "A"
                SeleccionarTab(1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficOtrosDescuentos.SelectedTab.Index
                Case 1
                    If cboEstado.Value <> "1CH00014" Then Throw New Exception("Solo se puede editar registros en estado GENERADA.")
                    RecolectaDatos()
                    oeOtrosDescuentos.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olOtrosDescuentos.Guardar(oeOtrosDescuentos)
                    mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                    SeleccionarTab(0)
                    Consultar(True)
                Case 2
                    Dim _leIAux = leODImportar.Where(Function(it) it.Activo = True).ToList
                    If _leIAux.Count > 0 Then
                        olOtrosDescuentos.GuardarMasivo(leODImportar, gs_PrefijoIdSucursal)
                        mensajeEmergente.Confirmacion("Los Datos han sido Importados correctamente!!", True)
                        SeleccionarTab(0)
                        Consultar(True)
                    Else
                        Throw New Exception("No hay Datos Verificados para Importar")
                    End If
            End Select
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case ficOtrosDescuentos.SelectedTab.Index
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
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griOtrosDescuentos.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro.")
                If griOtrosDescuentos.ActiveRow.Cells("Estado").ToString.Trim = "ENVIADO" Then Throw New Exception("Registros Enviados no pueden ser eliminados.")
                oeOtrosDescuentos.Id = griOtrosDescuentos.ActiveRow.Cells("Id").Value
                oeOtrosDescuentos.IdTrabajador = gUsuarioSGI.Id
                If olOtrosDescuentos.Eliminar(oeOtrosDescuentos) Then
                    mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                    Consultar(True)
                Else
                    Throw New Exception("No se puede eliminar registro.")
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
                MyBase.Exportar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OtrosDescuentos_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub frm_OtrosDescuentos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OtrosDescuentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            _asigfam = ObtieneAsigFam()
            SeleccionarTab(0)
            colorGenerada.Color = Color.White
            colorEnviado.Color = Color.LightYellow
            colorTerminada.Color = Color.LightGreen
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            leOtrosDescuentos = New List(Of e_OtrosDescuentos)
            CargarOtrosDscto(leOtrosDescuentos)
            btnEnviar.Enabled = False : btnExtornar.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipo_ValueChanged(sender As Object, e As EventArgs) Handles cboTipo.ValueChanged
        Select Case cboTipo.SelectedIndex
            Case 0 : cboEntidadBancaria.ReadOnly = False : cboBeneficiario.ReadOnly = True : cboOtros.ReadOnly = True
            Case 1 : cboEntidadBancaria.ReadOnly = True : cboBeneficiario.ReadOnly = False : cboOtros.ReadOnly = True
            Case 2 : cboEntidadBancaria.ReadOnly = True : cboBeneficiario.ReadOnly = True : cboOtros.ReadOnly = False
        End Select
        cboEntidadBancaria.SelectedIndex = -1 : cboBeneficiario.SelectedIndex = -1 : cboOtros.SelectedIndex = -1
        txtBeneficiario.Text = String.Empty
    End Sub

    Private Sub cboTrabajador_ValueChanged(sender As Object, e As EventArgs) Handles cboTrabajador.ValueChanged
        Try
            If cboTrabajador.SelectedIndex > -1 Then
                oeTrabajador = New e_Trabajador
                oeTrabajador.Id = cboTrabajador.Value
                oeTrabajador.TipoBusca = 1
                If leTrabajador.Contains(oeTrabajador) Then
                    oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                    txtDni.Text = oeTrabajador.oePersona.Dni
                    txtArea.Text = oeTrabajador.oeArea.Nombre
                    txtOcupacion.Text = oeTrabajador.oeOcupacion.Nombre
                    'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then pbFoto.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
                    oeSueldo = New e_SueldoTrabajador
                    oeSueldo.IdTrabajador = oeTrabajador.Id
                    oeSueldo.Equivale = 1
                    If leSueldo.Contains(oeSueldo) Then
                        oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                        ndSueldo.Value = oeSueldo.Sueldo
                    Else
                        ndSueldo.Value = 0
                    End If
                    ndAsigFam.Value = IIf(oeTrabajador.IndHijo = 1, _asigfam, 0)
                    ndRenumeracion.Value = ndSueldo.Value + ndAsigFam.Value
                    Dim _leCta = leCtaCtePersonal.Where(Function(it) it.IdTrabajador = oeTrabajador.Id).ToList
                    If _leCta.Count > 0 Then LlenarCombo(cboBeneficiario, "NroCuenta", _leCta, -1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPlanillaBus_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanillaBus.ValueChanged
        Try
            If cboPlanillaBus.SelectedIndex > 0 Then
                oePlanilla = cboPlanillaBus.Items(cboPlanillaBus.SelectedIndex).ListObject
                fecInicio.Value = oePlanilla.FechaInicio
                fecFin.Value = oePlanilla.FechaFin
            Else
                fecInicio.Value = Date.Now.Date
                fecFin.Value = Date.Now.Date
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOtrosDescuentos_DoubleClick(sender As Object, e As EventArgs) Handles griOtrosDescuentos.DoubleClick
        If griOtrosDescuentos.Selected.Rows.Count > 0 Then Editar()
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
                leODImportar.Clear()
                oeEstado = New e_Estado
                Dim _leEst = leEstado.Where(Function(it) it.Nombre = gNombreEstadoGenerada).ToList
                If _leEst.Count > 0 Then oeEstado = _leEst(0)
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        oeOtrosDescuentos = New e_OtrosDescuentos
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        If cboTipoI.SelectedIndex <> 1 Then
                            oeEmpresa = New e_Empresa
                            oeEmpresa.TipoBusca = 2 : oeEmpresa.Abreviatura = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                            If leEmpresa.Contains(oeEmpresa) Then oeEmpresa = leEmpresa.Item(leEmpresa.IndexOf(oeEmpresa))
                        End If
                        With oeOtrosDescuentos
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            If cboTipoI.SelectedIndex <> 1 Then
                                .IdEmpresaConvenio = oeEmpresa.Id
                                .Empresa = IIf(oeEmpresa.Id.Trim <> "", oeEmpresa.Nombre, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value))
                            End If
                            .Monto = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 4).Value, 2)
                            .IndTipo = cboTipoI.SelectedIndex
                            .IdPlanilla = cboPlanillaI.Value
                            .Planilla = cboPlanillaI.Text
                            .IdEstado = oeEstado.Id
                            .IndReferencia = 0
                            .Estado = oeEstado.Nombre
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .Activo = False
                        End With
                        oeOtrosDescuentos.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leODImportar.Add(oeOtrosDescuentos)
                    Else
                        Exit For
                    End If
                Next
                CargarODImportar(leODImportar)
                griDatosImportar.DataBind()
                btnValidar.Enabled = True
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
            mensajeEmergente.Confirmacion("Se han Procesado " & leODImportar.Count & " registros", True)
        Catch ex As Exception
            etiEjecuta.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False
        End Try
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Try
            Dim nroreg As Integer = 0
            If leODImportar.Count > 0 Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty : upbLoad.Visible = True
                upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                For Each oeOD In leODImportar
                    nroreg = nroreg + 1
                    etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leODImportar.Count
                    upbLoad.Value = Math.Round(nroreg / leODImportar.Count, 2) * 100
                    If oeOD.IdTrabajador.Trim <> "" Then
                        If cboTipoI.SelectedIndex = 0 Or cboTipoI.SelectedIndex = 2 Then
                            oeOD.Activo = IIf(oeOD.IdEmpresaConvenio <> "", True, False)
                        Else
                            oeOD.Activo = True
                        End If
                    Else
                        oeOD.Activo = False
                    End If

                    If Not oeOD.Activo Then Throw New Exception("No se encuentra empresa " & oeOD.Empresa)

                Next
                CargarODImportar(leODImportar) : griDatosImportar.DataBind()
                mensajeEmergente.Confirmacion("Se Validaron " & leODImportar.Count & " Registros", True)
            Else
                Throw New Exception("No hay Datos para validar")
            End If
        Catch ex As Exception
            etiEjecuta.Visible = False : upbLoad.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False : upbLoad.Visible = False
        End Try
    End Sub

    Private Sub cboBeneficiario_ValueChanged(sender As Object, e As EventArgs) Handles cboBeneficiario.ValueChanged
        If cboBeneficiario.SelectedIndex > -1 Then
            oeCtaCtePer = cboBeneficiario.Items(cboBeneficiario.SelectedIndex).ListObject
            txtBeneficiario.Text = oeCtaCtePer.Beneficiario
        End If
    End Sub

    Private Sub cboTipoI_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoI.ValueChanged
        If cboTipoI.SelectedIndex > -1 Then btnBuscar.Enabled = True
    End Sub

    Private Sub cboIndRef_ValueChanged(sender As Object, e As EventArgs) Handles cboIndRef.ValueChanged
        Try
            Select Case cboIndRef.Text.Trim
                Case "GRATIFICACION"
                    cboReferencia.ReadOnly = False
                    Dim _leG = leGrati.Where(Function(it) it.Activo = True And it.Estado = gNombreEstadoGenerada).ToList
                    LlenarCombo(cboReferencia, "Codigo", _leG, -1)
                Case "CTS"
                Case Else
                    cboReferencia.SelectedIndex = -1
                    cboReferencia.ReadOnly = True
                    cboReferencia.DataSource = Nothing
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If leOtrosDescuentos.Count > 0 Then
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                    '    Throw New Exception("Ingrese un Clave Correcta")
                    'Else
                    Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoEnviado).ToList
                    For Each oeDE In leOtrosDescuentos
                        oeDE.PrefijoID = gs_PrefijoIdSucursal '@0001
                        oeDE.TipoOperacion = "A" : oeDE.UsuarioModifica = gUsuarioSGI.Id
                        If _leEstAux.Count > 0 Then oeDE.IdEstado = _leEstAux(0).Id
                    Next
                    If olOtrosDescuentos.GuardarLista(leOtrosDescuentos) Then
                        mensajeEmergente.Confirmacion("Se la Planilla Otros Descuentos se Envio correctamente", True)
                        btnEnviar.Enabled = False
                        Consultar(True)
                    End If
                    'End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnExtornar_Click(sender As Object, e As EventArgs) Handles btnExtornar.Click
        Try
            _acl = gAccionSistema.EXTORNAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If leOtrosDescuentos.Count > 0 Then
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                    '    Throw New Exception("Ingrese un Clave Correcta")
                    'Else
                    Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoGenerada).ToList
                    For Each oeOD In leOtrosDescuentos
                        oeOD.PrefijoID = gs_PrefijoIdSucursal '@0001
                        oeOD.TipoOperacion = "A"
                        oeOD.UsuarioModifica = gUsuarioSGI.Id
                        If _leEstAux.Count > 0 Then oeOD.IdEstado = _leEstAux(0).Id
                    Next
                    If olOtrosDescuentos.GuardarLista(leOtrosDescuentos) Then
                        mensajeEmergente.Confirmacion("Se la Planilla Otros Descuentos se Extorno correctamente", True)
                        btnExtornar.Enabled = False
                        Consultar(True)
                    End If
                    'End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            cboTipo.Items.Clear()
            cboTipo.Items.Add("CONVENIO")
            cboTipo.Items.Add("JUDICIAL")
            cboTipo.Items.Add("SEGURO")
            cboTipo.Items.Add("OTROS INAFECTO")
            cboTipo.SelectedIndex = -1

            cboTipoI.Items.Clear()
            cboTipoI.Items.Add("CONVENIO")
            cboTipoI.Items.Add("JUDICIAL")
            cboTipoI.Items.Add("SEGURO")
            cboTipoI.Items.Add("OTROS INAFECTO")
            cboTipoI.SelectedIndex = -1

            cboTipoBus.Items.Clear()
            cboTipoBus.Items.Add("TODOS")
            cboTipoBus.Items.Add("CONVENIO")
            cboTipoBus.Items.Add("JUDICIAL")
            cboTipoBus.Items.Add("SEGURO")
            cboTipoBus.Items.Add("OTROS INAFECTO")
            cboTipoBus.SelectedIndex = 0

            cboIndRef.Items.Clear()
            cboIndRef.Items.Add("PLANILLA")
            cboIndRef.Items.Add("GRATIFICACION")
            cboIndRef.Items.Add("CTS")
            cboIndRef.SelectedIndex = 0
            cboReferencia.DataSource = Nothing
            cboReferencia.SelectedIndex = -1

            oeEstado = New e_Estado
            oeEstado.Nombre = "PLANILLA EPS"
            leEstado = olEstado.Listar(oeEstado)
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)
            Dim _leEstAux As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Nombre = " [TODOS] "
            oeEstado.Id = ""
            _leEstAux.Add(oeEstado)
            _leEstAux.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstAux, 0)

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "" : oePlanilla.Activo = True : oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla)
            lePlanillaGen = lePlanilla.Where(Function(it) it.Estado = "GENERADA").ToList
            Dim _lePlaAux = lePlanilla.OrderByDescending(Function(it) it.Codigo).ToList
            Dim _leAux As New List(Of e_Planilla)
            oePlanilla = New e_Planilla
            oePlanilla.Codigo = " [TODOS] "
            oePlanilla.Id = ""
            _leAux.Add(oePlanilla)
            _leAux.AddRange(_lePlaAux)
            LlenarCombo(cboPlanillaBus, "Codigo", _leAux, 0)
            LlenarCombo(cboPlanillaI, "Codigo", lePlanillaGen, -1)

            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = "" : oeSueldo.Activo = True : oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            leTrabajadorAct = leTrabajador.Where(Function(it) it.Activo = True).ToList

            oeCtaCtePer = New e_CuentaCtePersonal
            oeCtaCtePer.TipoOperacion = "" : oeCtaCtePer.Vigente = 1 : oeCtaCtePer.TipoConcepto = "JUDICIAL" : oeCtaCtePer.Activo = True
            leCtaCtePersonal = olCtaCtePersonal.Listar(oeCtaCtePer)

            oeEmpresa = New e_Empresa
            oeEmpresa.TipoOperacion = "" : oeEmpresa.Activo = True
            leEmpresa = olEmpresa.Listar(oeEmpresa)
            Dim _leBancos = leEmpresa.Where(Function(it) it.TipoEmpresa = gTEFinancieraBancaria).ToList
            LlenarCombo(cboEntidadBancaria, "Nombre", _leBancos, -1)
            Dim _leOtros = leEmpresa.Where(Function(it) it.TipoEmpresa <> gTEFinancieraBancaria).ToList
            LlenarCombo(cboOtros, "Nombre", _leOtros, -1)

            oeGrati = New e_Gratificacion
            oeGrati.TipoOperacion = "" : oeGrati.Activo = True
            leGrati = olGrati.Listar(oeGrati)

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = "" : oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)

            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = "" : oeDetParametro.Activo = True : oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = "" : oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SeleccionarTab(_index As Integer)
        ficOtrosDescuentos.Tabs(0).Enabled = False
        ficOtrosDescuentos.Tabs(1).Enabled = False
        ficOtrosDescuentos.Tabs(2).Enabled = False
        ficOtrosDescuentos.Tabs(_index).Enabled = True
        ficOtrosDescuentos.Tabs(_index).Selected = True
    End Sub

    Private Sub Listar()
        Try
            oeOtrosDescuentos = New e_OtrosDescuentos
            oeOtrosDescuentos.TipoOperacion = ""
            oeOtrosDescuentos.Activo = True
            oeOtrosDescuentos.IdPlanilla = cboPlanillaBus.Value
            oeOtrosDescuentos.IndTipo = cboTipoBus.SelectedIndex - 1
            oeOtrosDescuentos.IdEstado = cboEstadoBus.Value
            leOtrosDescuentos = olOtrosDescuentos.Listar(oeOtrosDescuentos)
            CargarOtrosDscto(leOtrosDescuentos)
            btnEnviar.Enabled = False : btnExtornar.Enabled = False
            If oeOtrosDescuentos.IdPlanilla.Trim <> String.Empty Then
                If leOtrosDescuentos.Count > 0 AndAlso leOtrosDescuentos(0).Estado = gNombreEstadoGenerada Then
                    btnEnviar.Enabled = True : btnExtornar.Enabled = False
                End If
                If leOtrosDescuentos.Count > 0 AndAlso leOtrosDescuentos(0).Estado = gNombreEstadoEnviado Then
                    btnEnviar.Enabled = False : btnExtornar.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarOtrosDscto(leOtrosDscto As List(Of e_OtrosDescuentos))
        Try
            With griOtrosDescuentos

                .Text = "Registros de Otros Descuentos"
                .ResetDisplayLayout()
                .DataSource = leOtrosDscto
                ConfiguraGrilla(griOtrosDescuentos, 1)

                If .Rows.Count > 0 Then
                    For Each Fila As UltraGridRow In .Rows
                        Select Case Fila.Cells("Estado").Value
                            Case "GENERADA" : Fila.Appearance.BackColor = colorGenerada.Color
                            Case "ENVIADO" : Fila.Appearance.BackColor = colorEnviado.Color
                            Case "TERMINADA" : Fila.Appearance.BackColor = colorTerminada.Color
                        End Select
                    Next
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarODImportar(leODImportar As List(Of e_OtrosDescuentos))
        Try
            With griDatosImportar

                .ResetDisplayLayout()
                .Text = "Datos a Importar"
                .DataSource = leODImportar
                ConfiguraGrilla(griDatosImportar, 2)

                If cboTipoI.SelectedIndex = 0 Then
                    OcultarColumna(griDatosImportar, True, "NroCuenta", "Beneficiario")
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(Grilla As UltraGrid, _tipo As Integer)
        Try
            With Grilla

                OcultarColumna(Grilla, True, "Id", "IdPlanilla", "IdTrabajador", "IndTipo", "IdEstado", "IdCuentaBeneficiario", _
                               "IdEmpresaConvenio", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModfica", "Activo")

                ExcluirColumna(Grilla, "IdPlanilla", "IdTrabajador", "IdEstado", "IdCuentaBeneficiario", "IdEmpresaConvenio", "Activo")

                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")

                If _tipo = 2 Then
                    OcultarColumna(Grilla, False, "Activo")
                    .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                End If

                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("Tipo").Width = 70
                .DisplayLayout.Bands(0).Columns("Estado").Width = 70
                .DisplayLayout.Bands(0).Columns("Monto").Width = 60
                .DisplayLayout.Bands(0).Columns("Beneficiario").Width = 125
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("Empresa").Width = 200
                .DisplayLayout.Bands(0).Columns("NroCuenta").Width = 125

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

                CalcularTotales(Grilla, "Monto")

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        cboPlanilla.SelectedIndex = -1
        cboTrabajador.SelectedIndex = -1
        cboTipo.SelectedIndex = -1
        ndMonto.Value = 0
        cboEntidadBancaria.SelectedIndex = -1
        cboBeneficiario.SelectedIndex = -1
        cboOtros.SelectedIndex = -1
        cboEntidadBancaria.ReadOnly = True
        cboBeneficiario.ReadOnly = True
        cboOtros.ReadOnly = True
        cboEstado.SelectedIndex = -1
        cboEstado.ReadOnly = True
        pbFoto.Image = Nothing
        txtDni.Text = String.Empty
        txtArea.Text = String.Empty
        txtOcupacion.Text = String.Empty
        ndSueldo.Value = 0
        ndAsigFam.Value = 0
        ndRenumeracion.Value = 0
    End Sub

    Private Sub Mostrar()
        Try
            oeOtrosDescuentos = New e_OtrosDescuentos
            oeOtrosDescuentos.TipoOperacion = ""
            oeOtrosDescuentos.Id = griOtrosDescuentos.ActiveRow.Cells("Id").Value
            oeOtrosDescuentos = olOtrosDescuentos.Obtener(oeOtrosDescuentos)
            With oeOtrosDescuentos
                cboPlanilla.Value = .IdPlanilla
                cboTrabajador.Value = .IdTrabajador
                cboTipo.SelectedIndex = .IndTipo
                ndMonto.Value = .Monto
                cboEntidadBancaria.Value = .IdEmpresaConvenio
                cboBeneficiario.Value = .IdCuentaBeneficiario
                cboOtros.Value = .IdEmpresaConvenio
                cboEstado.Value = .IdEstado
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaDatos()
        oeOtrosDescuentos.IdPlanilla = cboPlanilla.Value
        oeOtrosDescuentos.IdTrabajador = cboTrabajador.Value
        oeOtrosDescuentos.IndTipo = cboTipo.SelectedIndex
        oeOtrosDescuentos.Monto = ndMonto.Value
        If cboTipo.SelectedIndex = 2 Then 'Otros
            oeOtrosDescuentos.IdEmpresaConvenio = cboOtros.Value
        Else 'convenio/judicial
            oeOtrosDescuentos.IdEmpresaConvenio = cboEntidadBancaria.Value
        End If
        oeOtrosDescuentos.IdCuentaBeneficiario = cboBeneficiario.Value
        oeOtrosDescuentos.UsuarioCreacion = gUsuarioSGI.Id
        oeOtrosDescuentos.UsuarioModifica = gUsuarioSGI.Id
        oeOtrosDescuentos.IdEstado = cboEstado.Value
    End Sub

    Private Function ObtieneAsigFam() As Double
        Try
            oeFormula = New e_Formula
            oeFormula.Equivale = 3
            oeFormula.Nombre = "AsignacionFamiliar"
            If leFormula.Contains(oeFormula) Then
                oeFormula = leFormula.Item(leFormula.IndexOf(oeFormula))
                Dim val As Double = 0
                Dim sCodigo As String
                Dim sDeclara As String
                sDeclara = fn_ObtieneConstantes(oeFormula)
                sCodigo = sDeclara & " " & Environment.NewLine & _
                            "Function " & oeFormula.Nombre & Environment.NewLine _
                                & oeFormula.Nombre & " = " & oeFormula.Instrucciones & Environment.NewLine _
                             & "End Function"
                Dim sc As New ScriptControl
                With sc
                    .Language = "VBScript"
                    .AllowUI = True
                    .AddCode(sCodigo)
                    val = .Run(oeFormula.Nombre)
                End With
                Return val
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fn_ObtieneConstantes(_oeForAux As e_Formula) As String
        Try
            Dim aDatos As String = ""
            Dim sPar As String() = Nothing
            If _oeForAux.Parametros.Trim <> "" Then
                sPar = _oeForAux.Parametros.Split(",")
                For x = 0 To sPar.Length - 1
                    oeParametro = New e_AporteDescuento
                    oeParametro.Abreviatura = sPar(x)
                    oeParametro.Equivale = 4
                    If leParametro.Contains(oeParametro) Then
                        oeParametro = leParametro.Item(leParametro.IndexOf(oeParametro))
                        oeDetParametro = New e_DetalleAporteDescuento
                        oeDetParametro.IdAporteDescuento = oeParametro.Id
                        oeDetParametro.Equivale = 2
                        If leDetParametro.Contains(oeDetParametro) Then
                            oeDetParametro = leDetParametro.Item(leDetParametro.IndexOf(oeDetParametro))
                            aDatos = aDatos & "Dim " & sPar(x) & Environment.NewLine & _
                                sPar(x) & " = " & oeDetParametro.MontoCalculo & Environment.NewLine
                        End If
                        oeDetParametro.Dispose()
                    End If
                    oeParametro.Dispose()
                Next
            End If
            Return aDatos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Enviar()
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                'If griRetencionImpuesto.ActiveRow.Cells("Estado").Value = _estado AndAlso griRetencionImpuesto.ActiveRow.Cells("Importe").Value > 0 Then
                '    Editar()
                '    _estado = gNombreEstadoEnviado
                '    cboEstado.Text = _estado
                '    _opeR5ta = "ENVIAR"
                'Else
                '    Throw New Exception("No puede en ENVIAR el Registro de Retencion de 5ta Categoria" & Environment.NewLine & _
                '                        "Nº: " & griRetencionImpuesto.ActiveRow.Cells("Codigo").Value & " por que no esta en GENERADA." & _
                '                        Environment.NewLine & "O no tiene ni un solo registro de detalle.")
                'End If
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
                'If griRetencionImpuesto.ActiveRow.Cells("Estado").Value = _estado Then
                '    Dim formulario As frm_AutenticarTrabajador
                '    formulario = New frm_AutenticarTrabajador
                '    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                '    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                '        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                '        Throw New Exception("Ingrese un Clave Correcta")
                '    Else
                '        oeRetencionQuinta = New e_RetencionQuinta
                '        oeRetencionQuinta.TipoOperacion = ""
                '        oeRetencionQuinta.Id = griRetencionImpuesto.ActiveRow.Cells("Id").Value
                '        oeRetencionQuinta = olRetencionQuinta.Obtener(oeRetencionQuinta)
                '        oeRetencionQuinta.TipoOperacion = "A"
                '        _estado = gNombreEstadoGenerada
                '        Dim _leEst = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                '        If _leEst.Count > 0 Then
                '            oeRetencionQuinta.IdEstado = _leEst(0).Id
                '            oeRetencionQuinta.UsuarioModifica = gUsuarioSGI.Id
                '            olRetencionQuinta.Guardar(oeRetencionQuinta)
                '            mensajeEmergente.Confirmacion("¡El Registro de Retención de 5ta Categoria Nº: " & oeRetencionQuinta.Codigo & _
                '                                          " se Extornado correctamente!", True)
                '            SeleccionaTab(0)
                '            Consultar(True)
                '        End If
                '    End If
                'Else
                '    Throw New Exception("No se puede EXTORNAR el Registro de Renta de 5ta Categoria" & Environment.NewLine & _
                '                        "Nº: " & griRetencionImpuesto.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO")
                'End If
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
                'If griRetencionImpuesto.ActiveRow.Cells("Estado").Value = _estado Then
                '    Editar()
                '    _estado = gNombreEstadoTerminada.ToString
                '    cboEstado.Text = _estado
                '    _opeR5ta = "TERMINAR"
                'Else
                '    Throw New Exception("No puede TERMINAR el Registro de Retención de 5ta Categoria" & Environment.NewLine & _
                '                        "Nº: " & griRetencionImpuesto.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO.")
                'End If
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
                _opeOD = "IMPORTAR"
                leODImportar = New List(Of e_OtrosDescuentos)
                CargarODImportar(leODImportar)
                cboPlanillaI.SelectedIndex = -1
                cboTipoI.SelectedIndex = -1
                SeleccionarTab(2)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                btnBuscar.Enabled = False
                btnValidar.Enabled = False
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mcOtrosDsctos_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcOtrosDsctos.Opening
        mcOtrosDsctos.Items("tsmiNuevo").Enabled = True
        mcOtrosDsctos.Items("tsmiEditar").Enabled = False
        mcOtrosDsctos.Items("tsmiEliminar").Enabled = False
        mcOtrosDsctos.Items("tsmiImportar").Enabled = True
        If griOtrosDescuentos.Rows.Count > 0 Then
            mcOtrosDsctos.Items("tsmiEditar").Enabled = True
            mcOtrosDsctos.Items("tsmiEliminar").Enabled = True
        End If
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Try
            If griOtrosDescuentos.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiImportar_Click(sender As Object, e As EventArgs) Handles tsmiImportar.Click
        Try
            Importar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

    
End Class