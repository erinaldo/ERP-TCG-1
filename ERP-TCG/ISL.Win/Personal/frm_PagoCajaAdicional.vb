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
Imports Microsoft.Office.Interop

Public Class frm_PagoCajaAdicional
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_PagoCajaAdicional = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_PagoCajaAdicional()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oePagoCajaTrabajador As New e_PagoCajaTrabajador, olPagoCajaTrabajador As New l_PagoCajaTrabajador, lePagoCajaTrabajador As New List(Of e_PagoCajaTrabajador)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeDetalle As New e_DetallePagoCajaTrabajador, olDetalle As New l_DetallePagoCajaTrabajador
    Private leDetalle As New List(Of e_DetallePagoCajaTrabajador), leDetImportar As New List(Of e_DetallePagoCajaTrabajador)
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla), lePlanillaGen As New List(Of e_Planilla)
    Private oeResumenAsis As New e_ResumenAsistencia, olResumenAsist As New l_ResumenAsistencia, leResumenAsist As New List(Of e_ResumenAsistencia)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private _opePA As String = "", _acl As String = "", _estado As String = ""
    Private dsDatosGen As New Data.DataTable
    Private oePAAuxiliar As New e_PagoCajaTrabajador

    Dim loConcepto As New l_Concepto
    Dim oeConcepto As New e_Concepto
    Dim ListaConcepto As New List(Of e_Concepto)

#End Region


#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griPagoAdicional.Rows.Count > 0 Then
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
                _opePA = "GENERADA"
                oePagoCajaTrabajador = New e_PagoCajaTrabajador
                oePagoCajaTrabajador.TipoOperacion = "I"
                oePagoCajaTrabajador.Activo = True
                Inicializa()
                txtCodigo.Text = fn_ObtenerCodigo()
                LlenarCombo(cboPlanilla, "Codigo", lePlanillaGen, -1)
                cboPlanilla.ReadOnly = False
                _estado = gNombreEstadoGenerada
                cboEstado.Text = _estado
                SeleccionaTab(1)
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
                _opePA = "GENERADA"
                Inicializa()
                LlenarCombo(cboPlanilla, "Codigo", lePlanilla, -1)
                Mostrar()
                oePagoCajaTrabajador.TipoOperacion = "A"
                cboPlanilla.ReadOnly = True
                SeleccionaTab(1)
                'If griHora25.Rows.Count = 0 Then btnCargar.Enabled = True

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
            Select Case _opePA
                Case "GENERADA"
                    RecolectaDatos()
                    oePagoCajaTrabajador.UsuarioCreacion = gUsuarioSGI.Id
                    oePagoCajaTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olPagoCajaTrabajador.Guardar(oePagoCajaTrabajador) Then
                        mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                Case "ENVIAR"
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                    '    Throw New Exception("Ingrese un Clave Correcta")
                    'Else
                    oePagoCajaTrabajador.IdEstado = cboEstado.Value
                    oePagoCajaTrabajador.UsuarioModifica = gUsuarioSGI.Id
                    oePagoCajaTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olPagoCajaTrabajador.Guardar(oePagoCajaTrabajador) Then
                        mensajeEmergente.Confirmacion("¡El Registro de Pagos Adicionales Nº: " & oePagoCajaTrabajador.Codigo &
                                                  " se Envio correctamente!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                    'End If
                Case "TERMINAR"
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                    '    Throw New Exception("Ingrese un Clave Correcta")
                    'Else
                    oePagoCajaTrabajador.IdEstado = cboEstado.Value
                    oePagoCajaTrabajador.UsuarioModifica = gUsuarioSGI.Id
                    oePagoCajaTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olPagoCajaTrabajador.Guardar(oePagoCajaTrabajador) Then
                        mensajeEmergente.Confirmacion("¡El Registro de Pagos Adicionales Nº: " & oePagoCajaTrabajador.Codigo &
                                                  " se Termino correctamente!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                    'End If
                Case "IMPORTAR"
                    Dim _leAux = leDetImportar.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        'Dim formulario As frm_AutenticarTrabajador
                        'formulario = New frm_AutenticarTrabajador
                        'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                        'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        '    Throw New Exception("Ingrese un Clave Correcta")
                        'Else
                        oePagoCajaTrabajador = New e_PagoCajaTrabajador
                        oePagoCajaTrabajador.TipoOperacion = ""
                        oePagoCajaTrabajador.IdPlanilla = cboPlanillaDI.Value
                        oePagoCajaTrabajador.Activo = True
                        oePagoCajaTrabajador = olPagoCajaTrabajador.Obtener(oePagoCajaTrabajador)
                        If oePagoCajaTrabajador IsNot Nothing AndAlso oePagoCajaTrabajador.Id.Trim <> "" Then
                            oePagoCajaTrabajador.TipoOperacion = "A"
                            oePagoCajaTrabajador.UsuarioModifica = gUsuarioSGI.Id
                            oePagoCajaTrabajador.leDetalle = New List(Of e_DetallePagoCajaTrabajador)
                            oePagoCajaTrabajador.leDetalle = _leAux
                        Else
                            oePagoCajaTrabajador.TipoOperacion = "I"
                            oePagoCajaTrabajador.IdPlanilla = cboPlanillaDI.Value
                            oePagoCajaTrabajador.UsuarioCreacion = gUsuarioSGI.Id
                            oePagoCajaTrabajador.Descripcion = txtGlosa.Text
                            oePagoCajaTrabajador.Codigo = fn_ObtenerCodigo()
                            Dim _leEst = leEstado.Where(Function(it) it.Nombre = "GENERADA").ToList
                            If _leEst.Count > 0 Then
                                oePagoCajaTrabajador.IdEstado = _leEst(0).Id
                            End If
                            oePagoCajaTrabajador.Activo = True
                            oePagoCajaTrabajador.leDetalle = _leAux
                        End If
                        If olPagoCajaTrabajador.ImportarDatos(oePagoCajaTrabajador) Then
                            mensajeEmergente.Confirmacion("Los Datos han sido Importados Correctamente!!", True)
                            SeleccionaTab(0)
                            Consultar(True)
                        End If
                        'End If
                    Else
                        Throw New Exception("No hay Registros Validados para Importar")
                    End If
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case ficPagoAdicional.SelectedTab.Index
                Case 1
                    If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                Case 2
                    If MessageBox.Show("¿Desea Cancelar la Importacion de Datos?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
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
                If griPagoAdicional.ActiveRow.Cells("Estado").Value = gNombreEstadoGenerada Then
                    oePagoCajaTrabajador = New e_PagoCajaTrabajador
                    oePagoCajaTrabajador.TipoOperacion = "E"
                    oePagoCajaTrabajador.Id = griPagoAdicional.ActiveRow.Cells("Id").Value
                    oePagoCajaTrabajador.UsuarioModifica = gUsuarioSGI.Id
                    If olPagoCajaTrabajador.Eliminar(oePagoCajaTrabajador) Then
                        mensajeEmergente.Confirmacion("Registro Eliminado correctamente!!", True)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("No se puede Eliminar el Registro " & Environment.NewLine & _
                                       "Nº: " & griPagoAdicional.ActiveRow.Cells("Codigo").Value & " por que no esta en estado GENERADA")
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
                If griPagoAdicional.Rows.Count > 0 Then
                    Exportar_Excel(griPagoAdicional, "Pagos Adicionales")
                Else
                    Throw New Exception("¡No hay Registos para Exportar!")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_PagoCajaTrabajador_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub frm_PagoCajaTrabajador_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_PagoCajaTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _oeTrabAux As New e_Trabajador
            _oeTrabAux.TipoOperacion = "" : _oeTrabAux.Id = cboPlanilla.Value
            dsDatosGen = olTrabajador.CargarDatosGenerales(_oeTrabAux).Tables(0)

            SeleccionaTab(0)
            CargarCombos()
            lePagoCajaTrabajador = New List(Of e_PagoCajaTrabajador)
            CargarPagoCajaTrabajador(lePagoCajaTrabajador)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPlanillaBus_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanillaBus.ValueChanged
        Try
            If cboPlanillaBus.SelectedIndex > -1 Then
                Dim _oeplaaux = cboPlanillaBus.Items(cboPlanillaBus.SelectedIndex).ListObject
                fecInicioBus.Value = _oeplaaux.FechaInicio
                fecFinBus.Value = _oeplaaux.FechaFin
            Else
                fecInicioBus.Value = Date.Now.Date
                fecFinBus.Value = Date.Now.Date
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPlanilla_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanilla.ValueChanged
        Try
            If cboPlanilla.SelectedIndex > -1 Then
                Dim _oeplaaux = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
                fecInicio.Value = _oeplaaux.FechaInicio
                fecFin.Value = _oeplaaux.FechaFin
                If oePagoCajaTrabajador.TipoOperacion = "I" Then
                    Dim oePA As New e_PagoCajaTrabajador
                    oePA.TipoOperacion = ""
                    oePA.IdPlanilla = _oeplaaux.id
                    oePA.Activo = True
                    oePA = olPagoCajaTrabajador.Obtener(oePA)
                    If oePA.Id <> "" And oePA.Activo = True Then
                        'btnCargar.Enabled = False
                        cboPlanilla.SelectedIndex = -1
                        Throw New Exception("No se puede Seleccionar la Planilla Nº " & _oeplaaux.Codigo & _
                                            ", ya se encuentra Registrada en Nº: " & oePA.Codigo)
                    Else
                        'btnCargar.Enabled = True
                    End If
                Else
                    'btnCargar.Enabled = False
                End If
                oePeriodo = New e_Periodo
                oePeriodo.Equivale = 1
                oePeriodo.Id = _oeplaaux.IdPeriodo
                If lePeriodo.Contains(oePeriodo) Then
                    oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                    txtGlosa.Text = "PAGO ADICIONAL MES " & MonthName(oePeriodo.Mes).ToUpper & " AÑO " & oePeriodo.Ejercicio
                End If
            Else
                fecInicio.Value = Date.Now.Date
                fecFin.Value = Date.Now.Date
                'btnCargar.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            If cboPlanilla.SelectedIndex > -1 Then
                'leDetalle = New List(Of e_DetallePagoCajaTrabajador)
                oeResumenAsis = New e_ResumenAsistencia
                oeResumenAsis.TipoOperacion = "" : oeResumenAsis.IdPlanilla = cboPlanilla.Value : oeResumenAsis.Activo = True : oeResumenAsis.IndTipo = 4
                leResumenAsist = olResumenAsist.Listar(oeResumenAsis)
                oeResumenAsis = New e_ResumenAsistencia
                oeResumenAsis.TipoOperacion = "" : oeResumenAsis.IdPlanilla = cboPlanilla.Value : oeResumenAsis.Activo = True : oeResumenAsis.IndTipo = 5
                leResumenAsist.AddRange(olResumenAsist.Listar(oeResumenAsis))
                oeResumenAsis = New e_ResumenAsistencia
                oeResumenAsis.TipoOperacion = "" : oeResumenAsis.IdPlanilla = cboPlanilla.Value : oeResumenAsis.Activo = True : oeResumenAsis.IndTipo = 6
                leResumenAsist.AddRange(olResumenAsist.Listar(oeResumenAsis))
                If leResumenAsist.Count > 0 Then
                    Dim _oeTrabAux As New e_Trabajador
                    _oeTrabAux.TipoOperacion = "" : _oeTrabAux.Id = cboPlanilla.Value
                    dsDatosGen = olTrabajador.CargarDatosGenerales(_oeTrabAux).Tables(0)
                    For Each oeRA In leResumenAsist
                        oeDetalle = New e_DetallePagoCajaTrabajador
                        oeDetalle.TipoOperacion = "I"
                        oeDetalle.Calcula = 1
                        oeDetalle.Activo = True
                        oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                        oeDetalle.IdTrabajador = oeRA.IdTrabajador
                        oeDetalle.Trabajador = oeRA.Trabajador
                        oeDetalle.Dni = oeRA.Dni
                        Select Case oeRA.IndTipo
                            Case 4 : oeDetalle.IndTipo = 0
                            Case 5 : oeDetalle.IndTipo = 1
                            Case 6 : oeDetalle.IndTipo = 2
                        End Select
                        leDetalle.Add(oeDetalle)
                    Next
                    If leDetalle.Count > 0 Then
                        'btnCargar.Enabled = False
                        'btnAgregar.Visible = True : btnAgregar.Enabled = True
                        'btnAgregar.Text = "Existen " & leDetalle.Count & " Registros"
                    Else
                        'btnAgregar.Visible = False : btnAgregar.Enabled = False
                        Throw New Exception("No se Encontraron Datos")
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If leDetalle.Count > 0 Then
                If MessageBox.Show("¿Desar Agregar los Registros?", "Mensaje de Sistema", _
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    For Each oeAux In leDetalle
                        Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & oeAux.IdTrabajador & "'", "")
                        If _rwAux.Count > 0 Then
                        Else
                            Throw New Exception("No hay Datos del Trabajador: " & oeAux.Trabajador)
                        End If
                    Next
                    CargarOtros(leDetalle)
                    'btnAgregar.Enabled = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEstadoBus_ValueChanged(sender As Object, e As EventArgs) Handles cboEstadoBus.ValueChanged

    End Sub

    Private Sub cboPlanillaDI_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanillaDI.ValueChanged
        Try
            If cboPlanillaDI.SelectedIndex > -1 Then
                Dim _oeplaaux = cboPlanillaDI.Items(cboPlanillaDI.SelectedIndex).ListObject
                fecInicioDI.Value = _oeplaaux.FechaInicio
                fecFinDI.Value = _oeplaaux.FechaFin
                oePAAuxiliar = New e_PagoCajaTrabajador
                oePAAuxiliar.TipoOperacion = ""
                oePAAuxiliar.IdPlanilla = _oeplaaux.id
                oePAAuxiliar.Activo = True
                oePAAuxiliar = olPagoCajaTrabajador.Obtener(oePAAuxiliar)
                cboTipoDI.ReadOnly = False
                cboTipoDI.SelectedIndex = -1
                leDetImportar = New List(Of e_DetallePagoCajaTrabajador)
                CargarDetImportar(leDetImportar)

                oePeriodo = New e_Periodo
                oePeriodo.Equivale = 1
                oePeriodo.Id = _oeplaaux.IdPeriodo
                If lePeriodo.Contains(oePeriodo) Then
                    oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                    txtGlosa.Text = "PAGO ADICIONAL MES " & MonthName(oePeriodo.Mes).ToUpper & " AÑO " & oePeriodo.Ejercicio
                End If

            Else
                fecInicioDI.Value = Date.Now.Date
                fecFinDI.Value = Date.Now.Date
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoDI_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDI.ValueChanged
        Try
            If cboTipoDI.SelectedIndex > -1 Then
                If oePAAuxiliar.Id <> "" Then
                    If oePAAuxiliar.leDetalle.Count > 0 Then
                        Dim _leAux = oePAAuxiliar.leDetalle.Where(Function(it) it.IndTipo = cboTipoDI.Value).ToList
                        If _leAux.Count > 0 Then
                            btnBuscar.Enabled = False
                            Throw New Exception("No se puede Seleccionar la Planilla Nº " & cboPlanillaDI.Text & _
                                        ", ya se encuentra Registrada en Nº: " & oePAAuxiliar.Codigo)
                        Else
                            btnBuscar.Enabled = True
                        End If
                    Else
                        btnBuscar.Enabled = True
                    End If
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
                leDetImportar.Clear()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        etiEjecuta.Text = "Procesando " & ln_Fila & " registros ... "
                        oeDetalle = New e_DetallePagoCajaTrabajador
                        oeDetalle.Calcula = 0
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        ' '''''''''''''''''
                        ''Dim _af = EjecutaFormula("AsignacionFamiliar", False, Nothing, leFormula, leParametro, leDetParametro)
                        'Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & oeTrabajador.Id & "'", "")
                        'If _rwAux.Count > 0 Then
                        '    Dim _dsFila = _rwAux.CopyToDataTable
                        '    oeDetalle.Sueldo = _dsFila.Rows(0).Item("SUELDO")
                        '    oeDetalle.DiasDescanso = _dsFila.Rows(0).Item("DIAS_DESC")
                        '    oeDetalle.DiasFalta = _dsFila.Rows(0).Item("DIAS_FALTA")
                        '    oeDetalle.DiasVacaciones = _dsFila.Rows(0).Item("DIAS_VACAC")
                        '    If _dsFila.Rows(0).Item("ASIG_FAM") = 1 Then oeDetalle.AsignacionFamiliar = _af
                        'Else
                        '    oeDetalle.Sueldo = 0
                        '    oeDetalle.DiasDescanso = 0
                        '    oeDetalle.DiasFalta = 0
                        '    oeDetalle.DiasVacaciones = 0
                        '    oeDetalle.AsignacionFamiliar = 0
                        'End If
                        ' '''''''''''''''''
                        oeDetalle.Id = String.Empty
                        oeDetalle.IdTrabajador = oeTrabajador.Id
                        oeDetalle.Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                        oeDetalle.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        'oeDetalle.Sueldo = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value, 2)
                        'oeDetalle.AsignacionFamiliar = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 4).Value, 2)
                        '.Cantidad = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 5).Value, 2)
                        'oeDetalle.Cantidad = 1
                        oeDetalle.Monto = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value, 2)
                        'oeDetalle.HorasExtras = IIf(objWorkSheet.Cells(ln_Fila + 1, 4).Value = Nothing, 0, objWorkSheet.Cells(ln_Fila + 1, 4).Value)
                        'oeDetalle.MinutosExtras = IIf(objWorkSheet.Cells(ln_Fila + 1, 5).Value = Nothing, 0, objWorkSheet.Cells(ln_Fila + 1, 5).Value)
                        oeDetalle.IndTipo = cboTipoDI.Value
                        oeDetalle.Tipo = cboTipoDI.Text
                        oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                        oeDetalle.Activo = False
                        leDetImportar.Add(oeDetalle)
                    Else
                        Exit For
                    End If
                Next
                CargarDetImportar(leDetImportar) : griImportar.DataBind()
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
            mensajeEmergente.Confirmacion("Se han Procesado " & leDetImportar.Count & " registros", True)
        Catch ex As Exception
            etiEjecuta.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False
        End Try
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Try
            Dim nroreg As Integer = 0, nrotrab As Integer = 0
            Dim ls_msg As String = String.Empty
            If leDetImportar.Count > 0 Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty : upbLoad.Visible = True
                upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                For Each oeAux In leDetImportar
                    nroreg = nroreg + 1
                    etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leDetImportar.Count
                    upbLoad.Value = Math.Round(nroreg / leDetImportar.Count, 2) * 100
                    ' Verifica si los Trabajadores entan registradas en el SGI
                    If oeAux.IdTrabajador = "" Then
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = oeAux.Dni
                        If leTrabajador.Contains(oeTrabajador) Then
                            Dim _leAux = leTrabajador.Where(Function(it) it.oePersona.Dni = oeTrabajador.oePersona.Dni).ToList
                            If _leAux.Count > 0 Then
                                oeTrabajador = _leAux(0)
                                oeAux.IdTrabajador = oeTrabajador.Id : oeAux.Activo = True
                            End If
                        End If
                    Else
                        oeAux.Activo = True
                    End If
                    If oeAux.IdTrabajador.Trim = String.Empty Then nrotrab = nrotrab + 1
                Next
                CargarDetImportar(leDetImportar)
                griImportar.DataBind()
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            If nrotrab > 0 Then ls_msg = " * " & nrotrab & " Trabajadores no registrados."
            If ls_msg.Trim.Length > 0 Then
                ls_msg = "Se necesita solucionar lo siguente: " & Environment.NewLine & ls_msg
            Else
                ls_msg = "Todos los Datos estan Listos para Importar"
            End If
            mensajeEmergente.Confirmacion("Se Validaron " & leDetImportar.Count & " Registros" & Environment.NewLine & ls_msg, True)
        Catch ex As Exception
            etiEjecuta.Visible = False : upbLoad.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False : upbLoad.Visible = False
        End Try
    End Sub

    Private Sub griPagoAdicional_DoubleClick(sender As Object, e As EventArgs) Handles griPagoAdicional.DoubleClick
        If griPagoAdicional.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnGrabarDet_Click(sender As Object, e As EventArgs) Handles btnGrabarDet.Click
        Try
            If cboTrabajador.SelectedIndex = -1 Then Throw New Exception("¡Seleccione Trabajador!")
            If cboTipoIngreso.SelectedIndex = -1 Then Throw New Exception("¡Seleccione Tipo Ingreso!")
            If numImporte.Value = 0 Then Throw New Exception("¡Ingrese Monto!")

            Dim DetalleAux = leDetalle.Where(Function(y) y.IdTrabajador.ToString.Trim = cboTrabajador.Value.ToString.Trim And y.IndTipo.ToString.Trim = cboTipoIngreso.Value.ToString.Trim And y.Activo = True)
            If DetalleAux.Count > 0 Then Throw New Exception("Ya existe registro para " & cboTrabajador.Text & " con concepto " & cboTipoIngreso.Text)

            oeDetalle.IdTrabajador = cboTrabajador.Value
            oeDetalle.Trabajador = cboTrabajador.Text.Trim
            'oeDetalle.IndTipo = IIf(cboTipoIngreso.SelectedIndex = 0, 3, 4)
            oeDetalle.IndTipo = cboTipoIngreso.Value
            oeDetalle.Tipo = cboTipoIngreso.Text
            oeDetalle.Calcula = 1
            oeDetalle.Monto = numImporte.Value
            '''''''''''''''''''''''''''
            Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & oeDetalle.IdTrabajador & "'", "")
            If _rwAux.Count > 0 Then
            Else
                Throw New Exception("No hay Datos del Trabajador: " & oeDetalle.Trabajador)
            End If
            ''''''''''''''''''''''''''''''
            If oeDetalle.TipoOperacion = "I" Then
                oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                leDetalle.Add(oeDetalle)
            Else
                If oeDetalle.Id.Trim = "" Then
                    oeDetalle.TipoOperacion = "I" : oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                Else
                    oeDetalle.UsuarioModifica = gUsuarioSGI.Id
                End If
            End If
            CargarOtros(leDetalle)
            griOtros.DataBind()
            InicializaDetalle()
            agrDatosOtros.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelarDet_Click(sender As Object, e As EventArgs) Handles btnCancelarDet.Click
        If MessageBox.Show("¿Desea Cancelar la Operación?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            agrDatosOtros.Enabled = False
        End If
    End Sub

    Private Sub griOtros_DoubleClick(sender As Object, e As EventArgs) Handles griOtros.DoubleClick
        Try
            If griOtros.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro para Editar!")
            If cboEstado.Text.Trim = gNombreEstadoGenerada Then

            Else
                Throw New Exception("¡El Pago Adicional debe estar en estado " & gNombreEstadoGenerada)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            'llenamos combo de tipo de eventos            
            ListaConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "16"
            ListaConcepto.AddRange(loConcepto.Listar(oeConcepto))
            cboTipoDI.Items.Clear()
            cboTipoDI.DataSource = ListaConcepto
            cboTipoDI.DisplayMember = "Nombre"
            cboTipoDI.ValueMember = "Valor1"
            cboTipoDI.SelectedIndex = -1

            cboTipoIngreso.Items.Clear()
            cboTipoIngreso.DataSource = ListaConcepto
            cboTipoIngreso.DisplayMember = "Nombre"
            cboTipoIngreso.ValueMember = "Valor1"
            cboTipoIngreso.SelectedIndex = -1

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "" : oePlanilla.Activo = True : oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla).OrderByDescending(Function(it) it.Codigo).ToList

            lePlanillaGen = lePlanilla.Where(Function(it) it.Estado = "GENERADA").ToList

            LlenarCombo(cboPlanillaBus, "Codigo", lePlanilla, -1)
            LlenarCombo(cboPlanillaDI, "Codigo", lePlanilla, -1)

            oeEstado = New e_Estado
            oeEstado.Nombre = "INGRESOS ADICIONALES"
            leEstado = olEstado.Listar(oeEstado)

            LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            Dim _leEstaAux As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Id = "" : oeEstado.Nombre = " [TODOS] "
            _leEstaAux.Add(oeEstado)
            _leEstaAux.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstaAux, 0)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            Dim _leTrabAct = From le In leTrabajador _
                                Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado
                                Where Activo = True And IndEstado <> 0
                                Order By NombreCompleto
            LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAct.ToList, -1)

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = "" : oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)

            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = "" : oeDetParametro.Activo = True : oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = "" : oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = "" : oePeriodo.Activo = True
            lePeriodo = olPeriodo.Listar(oePeriodo)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPagoCajaTrabajador(lePagoAdic As List(Of e_PagoCajaTrabajador))
        Try
            With griPagoAdicional
                .ResetDisplayLayout()
                .DataSource = lePagoAdic

                OcultarColumna(griPagoAdicional, True, "Id", "IdPlanilla", "IdEstado", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")
                ExcluirColumna(griPagoAdicional, "Id", "IdPlanilla", "IdEstado", "Activo")

                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 250

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

    Private Sub Listar()
        Try
            oePagoCajaTrabajador = New e_PagoCajaTrabajador
            oePagoCajaTrabajador.TipoOperacion = ""
            oePagoCajaTrabajador.Activo = True
            If cboPlanillaBus.SelectedIndex > -1 Then oePagoCajaTrabajador.IdPlanilla = cboPlanillaBus.Value
            oePagoCajaTrabajador.IdEstado = cboEstadoBus.Value
            lePagoCajaTrabajador = olPagoCajaTrabajador.Listar(oePagoCajaTrabajador)
            CargarPagoCajaTrabajador(lePagoCajaTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        txtCodigo.Text = String.Empty
        cboEstado.SelectedIndex = -1
        cboEstado.ReadOnly = True
        cboPlanilla.SelectedIndex = -1
        'btnCargar.Enabled = False
        'btnAgregar.Visible = False
        leDetalle = New List(Of e_DetallePagoCajaTrabajador)
        CargarOtros(leDetalle)
        'ndTotal.Value = leDetallePlaVac.Sum(Function(it) it.TotalPagar)
        'ficDetalle.Tabs(0).Visible = False : ficDetalle.Tabs(1).Visible = False : ficDetalle.Tabs(2).Visible = False
        'dsDatosGen = Nothing
        ficDetalle.Tabs(0).Selected = True
        agrDatosOtros.Enabled = False
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oePagoAdi As New e_PagoCajaTrabajador
            oePagoAdi.TipoOperacion = "U"
            oePagoAdi = olPagoCajaTrabajador.Obtener(oePagoAdi)
            If oePagoAdi IsNot Nothing AndAlso oePagoAdi.Codigo <> "" Then
                str = oePagoAdi.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Mostrar()
        Try
            oePagoCajaTrabajador = New e_PagoCajaTrabajador
            oePagoCajaTrabajador.TipoOperacion = ""
            oePagoCajaTrabajador.Id = griPagoAdicional.ActiveRow.Cells("Id").Value
            oePagoCajaTrabajador = olPagoCajaTrabajador.Obtener(oePagoCajaTrabajador)
            With oePagoCajaTrabajador
                txtCodigo.Text = .Codigo
                cboPlanilla.Value = .IdPlanilla
                cboEstado.Value = .IdEstado
                leDetalle = .leDetalle
                'Cargar25Ext(leDetalle)
                'Cargar35Ext(leDetalle)
                'CargarNocturna(leDetalle)
                CargarOtros(leDetalle)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(Grilla As UltraGrid, Tipo As Integer)
        Try
            With Grilla

                OcultarColumna(Grilla, True, "Id", "IdPagoCajaTrabajador", "IdTrabajador", "IndTipo", "FechaCreacion", "UsuarioCreacion", _
                               "FechaModifica", "UsuarioModifica", "Activo")
                ExcluirColumna(Grilla, "Id", "IdPagoCajaTrabajador", "IdTrabajador", "IndTipo", "FechaCreacion", "UsuarioCreacion", _
                              "FechaModifica", "UsuarioModifica", "Activo")

                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, _
                               "Monto", "Redondeo", "TotalPagar")

                If Tipo = 5 Then
                    OcultarColumna(Grilla, False, "Activo")
                    .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                Else
                    OcultarColumna(Grilla, True, "Activo")
                End If

                .DisplayLayout.Bands(0).Columns("Dni").Width = 75
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 300
                .DisplayLayout.Bands(0).Columns("Tipo").Width = 150

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

    

    Private Sub CargarOtros(leDet As List(Of e_DetallePagoCajaTrabajador))
        Try
            With griOtros
                .ResetDisplayLayout()
                'Dim _leAux = leDet.Where(Function(it) it.Activo = True And it.IndTipo > 2).ToList
                Dim _leAux = leDet.Where(Function(it) it.Activo = True).ToList
                .DataSource = _leAux
                '.Text = "PAGOS POR ALIMENTACIÓN Y SUBSIDIOS"
                .Text = "PAGOS ADICIONALES"
                ConfiguraGrilla(griOtros, 3)
                CalcularTotales(griOtros, "Monto", "TotalPagar")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SeleccionaTab(_index As Integer)
        ficPagoAdicional.Tabs(0).Enabled = False
        ficPagoAdicional.Tabs(1).Enabled = False
        ficPagoAdicional.Tabs(2).Enabled = False
        ficPagoAdicional.Tabs(_index).Enabled = True
        ficPagoAdicional.Tabs(_index).Selected = True
    End Sub

    Private Sub RecolectaDatos()
        oePagoCajaTrabajador.Codigo = txtCodigo.Text
        oePagoCajaTrabajador.IdEstado = cboEstado.Value
        oePagoCajaTrabajador.IdPlanilla = cboPlanilla.Value
        oePagoCajaTrabajador.Descripcion = txtGlosa.Text
        oePagoCajaTrabajador.leDetalle = leDetalle
    End Sub

    Private Sub CargarDetImportar(leDI As List(Of e_DetallePagoCajaTrabajador))
        Try
            With griImportar

                .ResetDisplayLayout()
                .DataSource = leDI

                ConfiguraGrilla(griImportar, 5)

                If leDI.Count > 0 Then btnValidar.Enabled = True

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Enviar()
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griPagoAdicional.ActiveRow.Cells("Estado").Value = _estado Then
                    Editar()
                    _estado = gNombreEstadoEnviado
                    cboEstado.Text = _estado
                    _opePA = "ENVIAR"
                Else
                    Throw New Exception("No puede en ENVIAR el Registro de Pagos Adicionales" & Environment.NewLine & _
                                        "Nº: " & griPagoAdicional.ActiveRow.Cells("Codigo").Value & " por que no esta en GENERADA." & _
                                        Environment.NewLine & "O no tiene ni un solo registro de detalle.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Extornar()
        Try
            _acl = gAccionSistema.EXTORNAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griPagoAdicional.ActiveRow.Cells("Estado").Value = _estado Then
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                    '    Throw New Exception("Ingrese un Clave Correcta")
                    'Else
                    oePagoCajaTrabajador = New e_PagoCajaTrabajador
                    oePagoCajaTrabajador.TipoOperacion = ""
                    oePagoCajaTrabajador.Id = griPagoAdicional.ActiveRow.Cells("Id").Value
                    oePagoCajaTrabajador = olPagoCajaTrabajador.Obtener(oePagoCajaTrabajador)
                    oePagoCajaTrabajador.TipoOperacion = "A"
                    _estado = gNombreEstadoGenerada
                    Dim _leEst = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                    If _leEst.Count > 0 Then
                        oePagoCajaTrabajador.IdEstado = _leEst(0).Id
                        oePagoCajaTrabajador.UsuarioModifica = gUsuarioSGI.Id
                        oePagoCajaTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olPagoCajaTrabajador.Guardar(oePagoCajaTrabajador)
                        mensajeEmergente.Confirmacion("¡El Registro de Pagos Adicionales Nº: " & oePagoCajaTrabajador.Codigo &
                                                      " se Extornado correctamente!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                    'End If
                Else
                    Throw New Exception("No se puede EXTORNAR el Registro de Pagos Adicionales" & Environment.NewLine & _
                                        "Nº: " & griPagoAdicional.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Terminar()
        Try
            _acl = gAccionSistema.TERMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griPagoAdicional.ActiveRow.Cells("Estado").Value = _estado Then
                    Editar()
                    _estado = gNombreEstadoTerminada.ToString
                    cboEstado.Text = _estado
                    _opePA = "TERMINAR"
                Else
                    Throw New Exception("No puede TERMINAR el Registro de Pagos Adicionales" & Environment.NewLine & _
                                        "Nº: " & griPagoAdicional.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Importar()
        Try
            _acl = gAccionSistema.IMPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opePA = "IMPORTAR"
                SeleccionaTab(2)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                fecInicioDI.Value = Date.Now.Date
                fecFinDI.Value = Date.Now.Date
                cboPlanillaDI.SelectedIndex = -1
                cboTipoDI.ReadOnly = True
                cboTipoDI.SelectedIndex = -1
                leDetImportar = New List(Of e_DetallePagoCajaTrabajador)
                CargarDetImportar(leDetImportar)
                cboTipoDI.SelectedIndex = -1
                btnBuscar.Enabled = False
                btnValidar.Enabled = False
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub InicializaDetalle()
        cboTrabajador.SelectedIndex = -1
        cboTipoIngreso.SelectedIndex = -1
        numImporte.Value = 0
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mcPagoCajaTrabajador_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcPagoAdicional.Opening
        mcPagoAdicional.Items("tsmiNuevo").Enabled = True
        mcPagoAdicional.Items("tsmiImportar").Enabled = True
        mcPagoAdicional.Items("tsmiExportar").Enabled = IIf(griPagoAdicional.Rows.Count > 0, True, False)
        mcPagoAdicional.Items("tsmiEditar").Enabled = IIf(griPagoAdicional.Selected.Rows.Count > 0, True, False)
        mcPagoAdicional.Items("tsmiEliminar").Enabled = IIf(griPagoAdicional.Selected.Rows.Count > 0, True, False)
        mcPagoAdicional.Items("tsmiEnviar").Enabled = IIf(griPagoAdicional.Selected.Rows.Count > 0, True, False)
        mcPagoAdicional.Items("tsmiExtornar").Enabled = IIf(griPagoAdicional.Selected.Rows.Count > 0, True, False)
        mcPagoAdicional.Items("tsmiTerminar").Enabled = IIf(griPagoAdicional.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub tsmiEnviar_Click(sender As Object, e As EventArgs) Handles tsmiEnviar.Click
        Enviar()
    End Sub

    Private Sub tsmiExtornar_Click(sender As Object, e As EventArgs) Handles tsmiExtornar.Click
        Extornar()
    End Sub

    Private Sub tsmiTerminar_Click(sender As Object, e As EventArgs) Handles tsmiTerminar.Click
        Terminar()
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Exportar()
    End Sub

    Private Sub tsmiImportar_Click(sender As Object, e As EventArgs) Handles tsmiImportar.Click
        Importar()
    End Sub

#End Region

#Region "Menu Contextual Otros"

    Private Sub cmsOtros_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsOtros.Opening
        cmsOtros.Items("tsmiQuitarOtros").Enabled = IIf(griOtros.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiAgregarOtros_Click(sender As Object, e As EventArgs) Handles tsmiAgregarOtros.Click
        Try
            If cboEstado.Text.Trim = gNombreEstadoGenerada Then
                InicializaDetalle()
                agrDatosOtros.Enabled = True
                oeDetalle = New e_DetallePagoCajaTrabajador
                oeDetalle.TipoOperacion = "I" : oeDetalle.Activo = True
                cboTrabajador.Focus()
            Else
                Throw New Exception("¡El Pago Adicional debe estar en estado " & gNombreEstadoGenerada)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiQuitarOtros_Click(sender As Object, e As EventArgs) Handles tsmiQuitarOtros.Click
        Try
            EliminarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOtros_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griOtros.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
            EliminarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarDetalle()
        Try
            If griOtros.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro para Quitar!")
            If cboEstado.Text.Trim = gNombreEstadoGenerada Then
                oeDetalle = New e_DetallePagoCajaTrabajador
                oeDetalle.IdTrabajador = griOtros.ActiveRow.Cells("IdTrabajador").Value
                oeDetalle.IndTipo = griOtros.ActiveRow.Cells("IndTipo").Value
                oeDetalle.Id = griOtros.ActiveRow.Cells("Id").Value
                oeDetalle.TipoBusca = 2
                If oeDetalle.Id.Trim <> "" Then oeDetalle.TipoBusca = 1
                If leDetalle.Contains(oeDetalle) Then
                    oeDetalle = leDetalle.Item(leDetalle.IndexOf(oeDetalle))
                    If oeDetalle.Id.Trim <> "" Then
                        oeDetalle.TipoOperacion = "E"
                        oeDetalle.Activo = False
                    Else
                        oeDetalle.TipoBusca = 2
                        leDetalle.Remove(oeDetalle)
                    End If
                End If
                CargarOtros(leDetalle)
                griOtros.DataBind()
            Else
                Throw New Exception("¡El Pago Adicional debe estar en estado " & gNombreEstadoGenerada)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
End Class