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

Public Class frm_LiquidacionTrabajador
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_LiquidacionTrabajador = Nothing

    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_LiquidacionTrabajador()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeLiquidacionTrabajador As New e_LiquidacionTrabajador
    Private olLiquidacionTrabajador As New l_LiquidacionTrabajador
    Private loLiquidacionTrabajador As New List(Of e_LiquidacionTrabajador)

    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador
    Private loTrabajador As New List(Of e_Trabajador)

    Private oeContratos As New e_Contratos
    Private olContratos As New l_Contratos
    Private loContratos As New List(Of e_Contratos)

    Private oeSueldo As New e_SueldoTrabajador
    Private olSueldo As New l_SueldoTrabajador
    Private loSueldo As New List(Of e_SueldoTrabajador)

    Private oeFormula As New e_Formula
    Private olFormula As New l_Formula
    Private loFormula As New List(Of e_Formula)

    Private oeParametro As New e_AporteDescuento
    Private olParametro As New l_AporteDescuento
    Private loParametro As New List(Of e_AporteDescuento)

    Private oeDetParametro As New e_DetalleAporteDescuento
    Private olDetParametro As New l_DetalleAporteDescuento
    Private loDetParametro As New List(Of e_DetalleAporteDescuento)

    Private oeOcupacionTrabajador As New e_OcupacionTrabajador
    Private olOcupacionTrabajador As New l_OcupacionTrabajador

    Private oePeriodo As New e_Periodo
    Private olPeriodo As New l_Periodo

    Private oeTiempoLaborado As New e_CalculaTiempoServicio
    Private olTiempoLaborado As New l_CalculaTiempoServicio

    Private oeMotivoCese As New e_MotivoCese
    Private olMotivoCese As New l_MotivoCese
    Private loMotivoCese As New List(Of e_MotivoCese)

    Private TotalRemComp As Double = 0
    Private RemuSGrati As Double = 0
    Private SueldoBasico As Double = 0

    Private oeAsientoModelo, oeAsientoModeloLiquidacion As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable

    Private oePlanillaEPS As e_PlanillaEps, olPlanillaEps As New l_PlanillaEps, leCalculaEps As New List(Of e_PlanillaEps)
    Private oeRegSalud As New e_RegimenSalud, olRegSalud As New l_RegimenSalud, leRegSalud As New List(Of e_RegimenSalud)
    Private oePlanesEps As New e_PlanesEPS, olPlanesEps As New l_PlanesEPS, lePlanesEps As New List(Of e_PlanesEPS)

    Private olPersona As New l_Persona

    Dim _ingresando_datos As Boolean = False
    Private lst_TrabjadorSeguridad As New List(Of e_TrabajadorSeguridad)

    Private oeMedioPago As New e_MedioPago
    Private oeFlujoCaja As New e_FlujoCaja
    Private oeCtaBancaria As New e_CuentaBancaria
    Private olCtaBancaria As New l_CuentaBancaria
    Private leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private oeCtaCble As New e_CuentaContable
    Private olCtaCble As New l_CuentaContable
    Private leCtaCble As New List(Of e_CuentaContable)
    Private oeMovCajaBanco As New e_MovimientoCajaBanco
    Private olMovCajaBanco As New l_MovimientoCajaBanco
#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficLiquidacionTrabajador, 1)
            oeLiquidacionTrabajador.Modificado = False
            Inicializar()
            Operacion = "Nuevo"
            cboTrabajador.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            Gb_DatoGeneralCuentaTrabajador.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message,True )
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
            Operacion = "Editar"
            Inicializar()
            Mostrar()
            MostrarTabs(1, ficLiquidacionTrabajador, 1)
            Me.ficLiquidacionTrabajador.Tabs(2).Enabled = True
            dtpFechaLiqui.Focus()
            ControlBotones()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarLiquidacion() Then
                MostrarTabs(0, ficLiquidacionTrabajador)
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeLiquidacionTrabajador.Modificado Then
                If ficLiquidacionTrabajador.Tabs(2).Selected Then
                    MostrarTabs(1, ficLiquidacionTrabajador, 1)
                    Exit Sub
                Else
                    Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        Case Windows.Forms.DialogResult.Yes
                            If GuardarLiquidacion() Then
                                MostrarTabs(0, ficLiquidacionTrabajador, 2)
                                _ingresando_datos = False
                                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                            Else
                                _ingresando_datos = True
                                MostrarTabs(1, ficLiquidacionTrabajador, 1)
                            End If
                        Case Windows.Forms.DialogResult.No
                            MostrarTabs(0, ficLiquidacionTrabajador, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End Select
                End If
            Else
                MostrarTabs(0, ficLiquidacionTrabajador)
                _ingresando_datos = False
            End If
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griLiquidacionTrabajador.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griLiquidacionTrabajador)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            Dim id As String = ""
            Dim formulario As New frm_ImprimirLiquidacion
            If griLiquidacionTrabajador.Selected.Rows.Count > 0 Then
                If ficLiquidacionTrabajador.SelectedTab.Index = 0 Then
                    id = griLiquidacionTrabajador.ActiveRow.Cells("Id").Value
                    formulario.CargarDatos(id)
                    formulario.ShowDialog()
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    id = oeLiquidacionTrabajador.Id
                    formulario.CargarDatos(id)
                    formulario.ShowDialog()
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            Select Case MessageBox.Show("Desea Eliminar la Informacion?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    EliminarLiquidacion()
                    Listar()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_LiquidacionTrabajador_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficLiquidacionTrabajador.SelectedTab.Index
            Case 0
                If griLiquidacionTrabajador.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1, 2
                If Operacion = "Nuevo" Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                Else
                    If oeLiquidacionTrabajador.Estado = "GENERADA" Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                    ElseIf Operacion = "Evaluar" Or Operacion = "Firmar" Or Operacion = "Pagar" Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                    Else
                        ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
                    End If
                End If
        End Select

    End Sub

    Private Sub frm_LiquidacionTrabajador_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_LiquidacionTrabajador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_LiquidacionTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecDesde.Value = fecDesde.Value.AddDays(-30)
        CargarCombos()
        AsientosContablesProvLiquidacion()
        Call Me.Permisos_Tesoreria()
    End Sub

    Private Sub cboTrabajador_Validated(sender As Object, e As EventArgs) Handles cboTrabajador.Validated
        Try
            If cboTrabajador.SelectedIndex <> -1 Then
                If Operacion = "Nuevo" Then
                    LlenaLiquidacion()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numCantGra_ValueChanged(sender As Object, e As EventArgs) Handles numCantGra.ValueChanged
        If IsDBNull(numCantGra.Value) Then numCantGra.Value = 0.0
        Me.numTotalLiquidacion.Value = Me.numTotalCTS.Value + Me.numTotalVT.Value + Me.numTotalGT.Value + Me.numDT.Value + Me.numBE.Value + Me.numCantGra.Value - Me.numAdelantoSueldo.Value + Me.NumeroDecimalDevolucion5ta.Value - Me.NumeroDecimalRetencion5ta.Value
    End Sub

    Private Sub btnCalcularLiquidacion_Click(sender As Object, e As EventArgs) Handles btnCalcularLiquidacion.Click
        Try
            InicializarLiquidacion()
            LlenaLiquidacion()
            MostrarTabs(2, ficLiquidacionTrabajador, 1)
            CalcularLiquidacion()
            oeLiquidacionTrabajador.Modificado = True
            If Me.NumeroDecimal24.Value > 0 Then
                Me.NumeroDecimal3.ReadOnly = False
            Else
                Me.NumeroDecimal3.ReadOnly = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLiquidacionTrabajador_DoubleClick(sender As Object, e As EventArgs) Handles griLiquidacionTrabajador.DoubleClick
        Try
            If lst_TrabjadorSeguridad.Where(Function(g) g.IdTrabajador = gUsuarioSGI.IdTrabajador).Count = 0 Then
                Editar()
                ControlBotones()
                Gb_DatoGeneralCuentaTrabajador.Visible = False
            Else
                mensajeEmergente.Problema("No tiene permisos para editar liquidación de trabajador", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numBE_ValueChanged(sender As Object, e As EventArgs) Handles numBE.ValueChanged
        If IsDBNull(numCantGra.Value) Then numCantGra.Value = 0.0
        Me.numTotalLiquidacion.Value = Me.numTotalCTS.Value + Me.numTotalVT.Value + Me.numTotalGT.Value + Me.numDT.Value + Me.numBE.Value + Me.numCantGra.Value - Me.numAdelantoSueldo.Value + Me.NumeroDecimalDevolucion5ta.Value - Me.NumeroDecimalRetencion5ta.Value
    End Sub

    Private Sub numDT_ValueChanged(sender As Object, e As EventArgs) Handles numDT.ValueChanged
        If IsDBNull(numDT.Value) Then numDT.Value = 0.0
        Me.numTotalLiquidacion.Value = Me.numTotalCTS.Value + Me.numTotalVT.Value + Me.numTotalGT.Value + Me.numDT.Value + Me.numBE.Value + Me.numCantGra.Value - Me.numAdelantoSueldo.Value + Me.NumeroDecimalDevolucion5ta.Value - Me.NumeroDecimalRetencion5ta.Value
    End Sub

    Private Sub NumeroDecimal3_ValueChanged(sender As Object, e As EventArgs) Handles NumeroDecimal3.ValueChanged
        If Me.NumeroDecimal24.Value > 0 Then
            If IsDBNull(Me.NumeroDecimal3.Value) Then Me.NumeroDecimal3.Value = 0.0
            Me.numDT.Value = (Me.NumeroDecimal24.Value + Me.NumeroDecimal23.Value) - (Me.NumeroDecimal22.Value + Me.NumeroDecimal25.Value + Me.NumeroDecimal3.Value)
        End If
    End Sub

    Private Sub griLiquidacionTrabajador_AfterRowActivate(sender As Object, e As EventArgs) Handles griLiquidacionTrabajador.AfterRowActivate
        Try
            'Dim oeTrabajadorSeguridad As New e_TrabajadorSeguridad
            'Dim loTrabajadorSeguridad As New l_TrabajadorSeguridad
            'Dim lst_TrabjadorSeguridad As New List(Of e_TrabajadorSeguridad)
            btnEvaluar.Enabled = 0 : btnFirmar.Enabled = 0 : btnPagar.Enabled = 0 : btnEliminar.Enabled = 0 : btnExtornar.Enabled = 0
            If griLiquidacionTrabajador.ActiveRow.Index > -1 Then
                Select Case griLiquidacionTrabajador.ActiveRow.Cells("Estado").Value
                    Case gNombreEstadoGenerada, gNombreEstadoCalculada
                        btnEvaluar.Enabled = 1
                        btnEliminar.Enabled = 1
                    Case gNombreEstadoAprobada
                        btnFirmar.Enabled = 1
                        btnEliminar.Enabled = 1
                    Case gNombreEstadoFirmada
                        btnPagar.Enabled = 1
                        If lst_TrabjadorSeguridad.Where(Function(g) g.IdTrabajador = gUsuarioSGI.IdTrabajador).Count = 0 Then
                            btnExtornar.Enabled = 1
                        End If
                    Case gNombreEstadoPagada
                        If lst_TrabjadorSeguridad.Where(Function(g) g.IdTrabajador = gUsuarioSGI.IdTrabajador).Count > 0 Then
                            btnExtornar.Enabled = 1
                        End If
                End Select
            End If
            Dim usuario As String = ""
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Permisos_Tesoreria()
        Dim oeTrabajadorSeguridad As New e_TrabajadorSeguridad
        Dim loTrabajadorSeguridad As New l_TrabajadorSeguridad
        oeTrabajadorSeguridad.IdProcesoNegocio = "1CH000000003"
        lst_TrabjadorSeguridad.AddRange(loTrabajadorSeguridad.Listar(oeTrabajadorSeguridad))
        btnPagar.Visible = False : btnExtornar.Visible = False
        If lst_TrabjadorSeguridad.Where(Function(g) g.IdTrabajador = gUsuarioSGI.IdTrabajador).Count > 0 Then
            btnEvaluar.Visible = False
            btnFirmar.Visible = False
            btnEliminar.Visible = False
            btnPagar.Visible = True
            btnExtornar.Visible = True
        End If
    End Sub

    Private Sub btnEvaluar_Click(sender As Object, e As EventArgs) Handles btnEvaluar.Click
        Editar()
        Operacion = "Evaluar"
        ControlBotones()
        Gb_DatoGeneralCuentaTrabajador.Visible = False
    End Sub

    Private Sub btnFirmar_Click(sender As Object, e As EventArgs) Handles btnFirmar.Click
        Editar()
        Operacion = "Firmar"
        ControlBotones()
        Gb_DatoGeneralCuentaTrabajador.Visible = False
    End Sub

    Private Sub Limpiar_Pagar()
        Gb_DatoGeneralCuentaTrabajador.Visible = True
        txtOperaciones.Text = ""
        fecPago.Value = Date.Now
        LlenaCuentaBancaria()
        ficLiquidacionTrabajador.Tabs(2).Enabled = False
    End Sub
    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Editar()
        Operacion = "Pagar"
        ControlBotones()
        Limpiar_Pagar()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Inicializar()
        oeLiquidacionTrabajador = New e_LiquidacionTrabajador
        Me.Agrupacion4.Enabled = True
        Me.FotoTrabajador.Visible = False
        Me.agrDatosBasicos.Visible = False
        loContratos = New List(Of e_Contratos)
        griContratos.DataSource = loContratos
        cboTrabajador.SelectedIndex = -1
        cboPeriodo.SelectedIndex = -1
        Me.txtOcupacion.Text = String.Empty
        dtpFechaIngreso.Text = Date.Now
        dtpFechaCese.Text = Date.Now
        Me.txtTiempoServicios.Text = String.Empty
        Me.cboMotivoCese.SelectedIndex = -1
        numSueldo.Value = 0.0
        numAsigFam.Value = 0.0
        numProBonProd.Value = 0.0
        numPromHorExt.Value = 0.0
        numGratificacion.Value = 0.0
        numTotalRemComp.Value = 0.0
        btnCalcularLiquidacion.Visible = False
        InicializarLiquidacion()
    End Sub

    Public Sub InicializarLiquidacion()
        Agrupacion6.Enabled = True
        Me.etiDsctAFP.Text = String.Empty
        Me.etiAFP1.Text = String.Empty
        'cts
        Me.etiFICTS.Text = "01/01/1901"
        Me.etiFFCTS.Text = "01/01/1901"
        Me.txtFechaTotalCTS.Text = String.Empty
        Me.NumeroDecimal1.Value = 0.0
        Me.NumeroDecimal2.Value = 0.0
        Me.NumeroDecimalCTSRem.Value = 0.0
        Me.txtCTSmeses.Value = String.Empty
        Me.txtCTSdias.Value = String.Empty
        Me.txtCTSfaltas.Value = String.Empty
        Me.NumeroDecimal5.Value = 0.0
        Me.NumeroDecimal4.Value = 0.0
        Me.NumeroDecimalCTSxF.Value = 0.0
        Me.numTotalCTS.Value = 0.0
        'Vacaciones Truncas
        Me.etiFIVT.Text = "01/01/1901"
        Me.etiFFVT.Text = "01/01/1901"
        Me.txtFechaTotalVT.Text = String.Empty
        Me.NumeroDecimal11.Value = 0.0
        Me.NumeroDecimal10.Value = 0.0
        Me.NumeroDecimal9.Value = 0.0
        Me.NumeroDecimalVTRem.Value = 0.0
        Me.txtVTaños.Value = String.Empty
        Me.txtVTmeses.Value = String.Empty
        Me.txtVTdias.Value = String.Empty
        Me.txtVTfaltas.Value = String.Empty
        Me.txtVTDiasVacaciones.Value = String.Empty
        Me.NumeroDecimal8.Value = 0.0
        Me.NumeroDecimal7.Value = 0.0
        Me.NumeroDecimal6.Value = 0.0
        Me.NumeroDecimalVTxF.Value = 0.0
        Me.NumeroDecimal14.Value = 0.0
        Me.NumeroDecimal13.Value = 0.0
        Me.numTotalVT.Value = 0.0
        'Gratificaciones Truncas
        Me.etiFIGT.Text = "01/01/1901"
        Me.etiFFGT.Text = "01/01/1901"
        Me.txtFechaTotalGT.Text = String.Empty
        Me.NumeroDecimal19.Value = 0.0
        Me.NumeroDecimal18.Value = 0.0
        Me.NumeroDecimalGTRem.Value = 0.0
        Me.txtGTmeses.Value = String.Empty
        Me.txtGTdias.Value = String.Empty
        Me.txtGTfaltas.Value = String.Empty
        Me.NumeroDecimal17.Value = 0.0
        Me.NumeroDecimal16.Value = 0.0
        Me.NumeroDecimalGTxF.Value = 0.0
        Me.numTotalGT.Value = 0.0
        'dias trabajados
        Me.etiFIDT.Text = "01/01/1901"
        Me.etiFFDT.Text = "01/01/1901"
        Me.txtFechaTotalDT.Text = String.Empty
        Me.NumeroDecimal26.Value = 0.0
        Me.NumeroDecimalDTRem.Value = 0.0
        Me.txtDiasdias.Value = String.Empty
        Me.txtDTfaltas.Value = String.Empty
        Me.NumeroDecimal24.Value = 0.0
        Me.NumeroDecimalDTxFaltas.Value = 0.0
        Me.NumeroDecimal23.Value = 0.0
        Me.NumeroDecimal22.Value = 0.0
        Me.NumeroDecimal25.Value = 0.0
        Me.NumeroDecimal3.Value = 0.0
        Me.numDT.Value = 0.0
        'adelanto y renta 5ta
        Me.numAdelantoSueldo.Value = 0.0
        Me.NumeroDecimalDevolucion5ta.Value = 0.0
        Me.NumeroDecimalRetencion5ta.Value = 0.0
        'boni - cant grac - aporte
        Me.numBE.Value = 0.0
        Me.numCantGra.Value = 0.0
        Me.ND_AporteEsSalud.Value = 0.0
        'total
        Me.numTotalLiquidacion.Value = 0.0
    End Sub

    Public Sub LlenaLiquidacion()
        Try
            DatosBasicos()
            oeOcupacionTrabajador = New e_OcupacionTrabajador
            oeOcupacionTrabajador.Principal = 1
            oeOcupacionTrabajador.IdTrabajador = oeTrabajador.Id
            oeOcupacionTrabajador = olOcupacionTrabajador.Obtener(oeOcupacionTrabajador)
            oeTiempoLaborado = New e_CalculaTiempoServicio
            oeTiempoLaborado.TipoOperacion = ""
            oeTiempoLaborado.FechaInicio = oeOcupacionTrabajador.FechaIngreso
            oeTiempoLaborado.FechaCese = oeOcupacionTrabajador.FechaCese
            oeTiempoLaborado.IdTrabajador = oeTrabajador.Id
            oeTiempoLaborado.IdPeriodo = CargarPeriodo(oeTiempoLaborado.FechaCese).Id
            dtpFechaIngreso.Value = oeTiempoLaborado.FechaInicio
            dtpFechaCese.Value = oeTiempoLaborado.FechaCese
            oeTiempoLaborado = olTiempoLaborado.Obtener(oeTiempoLaborado)
            txtTiempoServicios.Text = oeTiempoLaborado.TiempoServicioTotal
            numProBonProd.Value = oeTiempoLaborado.BonificacionProduccion
            Me.btnCalcularLiquidacion.Visible = True
            numGratificacion.Value = oeTiempoLaborado.ToGratificacion
            numPromHorExt.Value = oeTiempoLaborado.PromedioHorasExtras
            numTotalRemComp.Value = numSueldo.Value + numAsigFam.Value + numProBonProd.Value + numPromHorExt.Value + numGratificacion.Value
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Mostrar()
        Try
            If griLiquidacionTrabajador.Selected.Rows.Count > 0 Then
                oeLiquidacionTrabajador.Id = griLiquidacionTrabajador.ActiveRow.Cells("Id").Value
                oeLiquidacionTrabajador = olLiquidacionTrabajador.Obtener(oeLiquidacionTrabajador)
                oeTiempoLaborado = New e_CalculaTiempoServicio
                With oeTiempoLaborado
                    .TipoOperacion = "1"
                    .FechaInicio = oeLiquidacionTrabajador.FechaIngreso
                    .FechaCese = oeLiquidacionTrabajador.FechaCese
                    .FechaInicioCTS = oeLiquidacionTrabajador.FechaInicioCTS
                    .FechaInicioDT = oeLiquidacionTrabajador.FechaInicioDT
                    .FechaInicioGT = oeLiquidacionTrabajador.FechaInicioGT
                    .FechaInicioVT = oeLiquidacionTrabajador.FechaInicioVT
                End With
                oeTiempoLaborado = olTiempoLaborado.Obtener(oeTiempoLaborado)
                With oeLiquidacionTrabajador
                    Me.txtTiempoServicios.Text = oeTiempoLaborado.TiempoServicioTotal
                    Me.txtOcupacion.Text = .Ocupacion
                    Me.txtOcupacion.Tag = .IdOcupacion
                    Me.dtpFechaIngreso.Value = .FechaIngreso
                    Me.dtpFechaCese.Value = .FechaCese
                    Me.cboTrabajador.Value = .IdTrabajador
                    Me.cboPeriodo.Value = .IdPeriodo
                    Me.dtpFechaLiqui.Value = .Fecha
                    Me.numSueldo.Value = .RemuneracionBasica
                    Me.numAsigFam.Value = .AsigFamiliar
                    Me.numProBonProd.Value = .PromBoniProd
                    Me.numPromHorExt.Value = .PromHorasExtras
                    Me.numGratificacion.Value = .PromGratificacion
                    Me.numTotalRemComp.Value = .RemuneracionBasica + .AsigFamiliar + .PromBoniProd + .PromHorasExtras + .PromGratificacion
                    Me.etiDsctAFP.Text = .PorcentajeAFP
                    Me.etiAFP1.Text = .PorcentajeAFP
                    CalcularSueldos()
                    Me.etiFICTS.Text = .FechaInicioCTS
                    Me.etiFFDT.Text = .FechaCese
                    Me.etiFFCTS.Text = .FechaCese
                    Me.etiFFGT.Text = .FechaCese
                    Me.etiFFVT.Text = .FechaCese
                    Me.txtFechaTotalCTS.Text = oeTiempoLaborado.CTSTiempoTotal
                    Me.txtCTSmeses.Text = FormatoDocumento(.CTSM, 2)
                    Me.txtCTSdias.Text = FormatoDocumento(.CTSD, 2)
                    Me.NumeroDecimal4.Value = .CTSxD
                    Me.NumeroDecimal5.Value = .CTSxM
                    Me.txtCTSfaltas.Value = FormatoDocumento(.CTSF, 2)
                    Me.NumeroDecimalCTSxF.Value = .CTSxF
                    Me.txtFechaTotalVT.Text = oeTiempoLaborado.VTTiempoTotal
                    Me.etiFIVT.Text = .FechaInicioVT
                    Me.txtVTaños.Text = FormatoDocumento(.VTA, 2)
                    Me.txtVTmeses.Text = FormatoDocumento(.VTM, 2)
                    Me.txtVTdias.Text = FormatoDocumento(.VTD, 2)
                    Me.txtVTDiasVacaciones.Text = FormatoDocumento(.VTDGozadas, 2)
                    Me.NumeroDecimal8.Value = .VTxA
                    Me.NumeroDecimal7.Value = .VTxM
                    Me.NumeroDecimal6.Value = .VTxD
                    Me.txtVTfaltas.Value = FormatoDocumento(.VTF, 2)
                    Me.NumeroDecimalVTxF.Value = .VTxF
                    Me.NumeroDecimal14.Value = .VTGozadas
                    Me.NumeroDecimal13.Value = .VTxDescuentoAFP
                    Me.txtFechaTotalGT.Text = oeTiempoLaborado.GTTiempoTotal
                    Me.etiFIGT.Text = .FechaInicioGT
                    Me.txtGTmeses.Text = FormatoDocumento(.GTM, 2)
                    Me.txtGTdias.Text = FormatoDocumento(.GTD, 2)
                    Me.txtGTfaltas.Value = FormatoDocumento(.GTF, 2)
                    Me.NumeroDecimalGTxF.Value = .GTxF
                    Me.NumeroDecimal17.Value = .GTxM
                    Me.NumeroDecimal16.Value = .GTxD
                    Me.numBE.Value = .BoniExtra
                    Me.numCantGra.Value = .CantidadGraciosa
                    Me.txtFechaTotalDT.Text = oeTiempoLaborado.DTTiempoTotal
                    If .DT = 0 Then Me.txtFechaTotalDT.Text = "PAGADO A FIN DE MES"
                    Me.etiFIDT.Text = .FechaInicioDT
                    Me.txtDiasdias.Text = FormatoDocumento(.DT, 2)
                    Me.txtDTfaltas.Value = FormatoDocumento(.DTF, 2)
                    Me.NumeroDecimalDTxFaltas.Value = .DTxF
                    Me.NumeroDecimal24.Value = .DTxD
                    Me.NumeroDecimal23.Value = .DTAsigFam
                    Me.NumeroDecimal22.Value = .DTEssaludVida
                    Me.NumeroDecimal25.Value = .DTDsctoAFP
                    Me.NumeroDecimal3.Value = .DTDsctoEPS
                    Me.numAdelantoSueldo.Value = .AdelantoSueldo
                    Me.NumeroDecimalDevolucion5ta.Value = .Dev5taCat
                    Me.NumeroDecimalRetencion5ta.Value = .Retencion5ta
                    Me.ND_AporteEsSalud.Value = .AporteEsalud
                    Me.cboMotivoCese.Value = .IdMotivoCese
                    Me.numTotalLiquidacion.Value = .TotalPagar
                    Me.numPagoTotal.Value = .TotalPagar
                    If Me.NumeroDecimal24.Value > 0 Then
                        Me.NumeroDecimal3.ReadOnly = False
                    Else
                        Me.NumeroDecimal3.ReadOnly = True
                    End If
                End With
                CalcularTotales()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()
        Try
            oeLiquidacionTrabajador = New e_LiquidacionTrabajador
            oeLiquidacionTrabajador.FechaIngreso = fecDesde.Value
            oeLiquidacionTrabajador.FechaCese = fecHasta.Value
            If lst_TrabjadorSeguridad.Where(Function(g) g.IdTrabajador = gUsuarioSGI.IdTrabajador).Count = 0 Then
                griLiquidacionTrabajador.DataSource = olLiquidacionTrabajador.Listar(oeLiquidacionTrabajador)
            Else
                griLiquidacionTrabajador.DataSource = olLiquidacionTrabajador.Listar(oeLiquidacionTrabajador).Where(Function(g) g.Estado = "FIRMADA" Or g.Estado = "PAGADA").ToList
            End If
            If griLiquidacionTrabajador.Rows.Count > 0 Then
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLiquidacionTrabajador.Rows
                    If fila.Cells("Estado").Value = "GENERADA" Then
                        fila.CellAppearance.BackColor = Me.Colores1.Color
                    ElseIf fila.Cells("Estado").Value = "CALCULADA" Then
                        fila.CellAppearance.BackColor = Me.Colores2.Color
                    ElseIf fila.Cells("Estado").Value = "APROBADA" Then
                        fila.CellAppearance.BackColor = Me.Colores3.Color
                    ElseIf fila.Cells("Estado").Value = "FIRMADA" Then
                        fila.CellAppearance.BackColor = Me.Colores4.Color
                    Else
                        fila.CellAppearance.BackColor = Me.Colores5.Color
                    End If
                Next
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function validarPagos() As Boolean
        Try
            ValidarCombo(cboMedio, "Medio de Pago")
            If cboCuentaBancaria.Enabled Then ValidarCombo(cboCuentaBancaria, "Cuenta Bancaria")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtOperaciones.Text, "Ingrese el Voucher")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GuardarLiquidacion() As Boolean
        Try
            Dim _validar As Boolean = True
            If Operacion = "Pagar" Then _validar = validarPagos()
            If _validar Then
                LlenaObjeto()
                oeLiquidacionTrabajador.TotalPagar = Math.Round(oeLiquidacionTrabajador.TotalPagar, 4)
                If oeLiquidacionTrabajador.TotalPagar < 0 Then Throw New Exception("La liquidación no puede ser negativa.")
                oeLiquidacionTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeMovCajaBanco.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olLiquidacionTrabajador.Guardar(oeLiquidacionTrabajador, IIf(Operacion = "Pagar", oeMovCajaBanco, Nothing)) Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub EliminarLiquidacion()
        Try
            If griLiquidacionTrabajador.Selected.Rows.Count > 0 Then
                Dim estado As String = griLiquidacionTrabajador.ActiveRow.Cells("Estado").Value.ToString
                If estado = "GENERADA" Or estado = "CALCULADA" Or estado = "APROBADA" Then
                    oeLiquidacionTrabajador = New e_LiquidacionTrabajador
                    oeLiquidacionTrabajador.Id = griLiquidacionTrabajador.ActiveRow.Cells("Id").Value
                    If olLiquidacionTrabajador.Eliminar(oeLiquidacionTrabajador) Then
                        mensajeEmergente.Confirmacion("La Informacion se ha Eliminado Correctamente", True)
                    End If
                Else
                    Throw New Exception("Solo puede Eliminar Liquidaciones Generadas o Calculadas")
                End If
            Else
                Throw New Exception("Seleccione Registro a Eliminar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaObjeto()
        With oeLiquidacionTrabajador
            .FechaIngreso = dtpFechaIngreso.Value
            .FechaCese = dtpFechaCese.Value
            .Fecha = dtpFechaLiqui.Value
            If Operacion = "Pagar" Then .Fecha = fecPago.Value
            .PorcentajeAFP = oeTiempoLaborado.PorcentajeAFP
            .TotalPagar = Me.numTotalLiquidacion.Value
            .RemuneracionBasica = Me.numSueldo.Value
            .AsigFamiliar = Me.numAsigFam.Value
            .IdTrabajador = cboTrabajador.Value
            .IdPeriodo = cboPeriodo.Value
            .PromBoniProd = Me.numProBonProd.Value
            .PromHorasExtras = Me.numPromHorExt.Value
            .PromGratificacion = Me.numGratificacion.Value
            .FechaInicioCTS = etiFICTS.Text
            .CTSD = oeTiempoLaborado.CTSCantidadDias
            .CTSM = oeTiempoLaborado.CTSCantidadMeses
            .CTSF = oeTiempoLaborado.CTSfaltas
            .CTSxD = NumeroDecimal4.Value
            .CTSxM = NumeroDecimal5.Value
            .CTSxF = NumeroDecimalCTSxF.Value
            .FechaInicioVT = etiFIVT.Text
            .VTA = oeTiempoLaborado.VTCantidadAños
            .VTM = oeTiempoLaborado.VTCantidadMeses
            .VTD = oeTiempoLaborado.VTCantidadDias
            .VTF = oeTiempoLaborado.VTfaltas
            .VTDGozadas = txtVTDiasVacaciones.Value
            .VTxA = NumeroDecimal8.Value
            .VTxM = NumeroDecimal7.Value
            .VTxD = NumeroDecimal6.Value
            .VTxF = NumeroDecimalVTxF.Value
            .VTGozadas = NumeroDecimal14.Value
            .VTxDescuentoAFP = NumeroDecimal13.Value
            .FechaInicioGT = etiFIGT.Text
            .GTM = oeTiempoLaborado.GTCantidadMeses
            .GTD = oeTiempoLaborado.GTCantidadDias
            .GTD = oeTiempoLaborado.GTfaltas
            .GTxM = NumeroDecimal17.Value
            .GTxD = NumeroDecimal16.Value
            .GTxF = NumeroDecimalGTxF.Value
            .BoniExtra = numBE.Value
            .CantidadGraciosa = numCantGra.Value
            .FechaInicioDT = etiFIDT.Text
            .DT = oeTiempoLaborado.DTCantidadDias
            .DTF = oeTiempoLaborado.DTfaltas
            .DTxD = NumeroDecimal24.Value
            .DTxF = NumeroDecimalDTxFaltas.Value
            .DTAsigFam = NumeroDecimal23.Value
            .DTEssaludVida = NumeroDecimal22.Value
            .DTDsctoAFP = NumeroDecimal25.Value
            .DTDsctoEPS = NumeroDecimal3.Value
            .AdelantoSueldo = numAdelantoSueldo.Value
            .Dev5taCat = NumeroDecimalDevolucion5ta.Value
            .Retencion5ta = NumeroDecimalRetencion5ta.Value
            .AporteEsalud = ND_AporteEsSalud.Value
            .UsuarioCreacion = gUsuarioSGI.Id
            .IdMotivoCese = cboMotivoCese.Value
            .IdOcupacion = oeOcupacionTrabajador.IdOcupacion
            If Operacion = "Nuevo" Then
                .TipoOperacion = "I"
                If .TotalPagar = 0 Then
                    .IdEstado = "1CH00014"
                Else
                    .IdEstado = "1CH00036"
                End If
            ElseIf Operacion = "Editar" Then
                .TipoOperacion = "A"
                If .TotalPagar = 0 Then
                    .IdEstado = "1CH00014"
                Else
                    .IdEstado = "1CH00036"
                End If
            Else
                .TipoOperacion = "C"
                If Operacion = "Evaluar" Then
                    .IdEstado = "1CH00031"
                ElseIf Operacion = "Firmar" Then
                    .IdEstado = "1CH00037"
                    Dim FechaActual As Date = ObtenerFechaServidor()
                    '.IdPeriodo = CargarPeriodo(FechaActual.Date).Id
                    'ObtenerAsientoModelo(CargarPeriodo(FechaActual.Date).Ejercicio)
                    ObtenerAsientoModelo(.FechaCese.Year)
                    .TipoCambio = TipoCambio(FechaActual, True)(0)
                    .loPlacas = ObtenerPlacas(.IdTrabajador, .FechaIngreso, .FechaCese)
                ElseIf Operacion = "Pagar" Then
                    .IdEstado = "1CH00038"
                    Dim FechaActual As Date = ObtenerFechaServidor()
                    .IdPeriodo = CargarPeriodo(FechaActual.Date).Id
                    ObtenerAsientoModelo_Pagar(CargarPeriodo(FechaActual.Date).Ejercicio)
                    ' ObtenerAsientoModelo(.FechaCese.Year)
                    .TipoCambio = TipoCambio(FechaActual, True)(0)
                    .loPlacas = ObtenerPlacas(.IdTrabajador, .FechaIngreso, .FechaCese)
                    oeMovCajaBanco = New e_MovimientoCajaBanco
                    With oeMovCajaBanco
                        .IdFlujoCaja = cboFlujoCaja.Value
                        .NroBoucher = txtOperaciones.Text
                        .IdCuentaBancaria = cboCuentaBancaria.Value
                        .Fecha = fecPago.Value
                        .IdMedioPago = cboMedio.Value
                        .IdPeriodoConcilia = ""
                        .Activo = True
                        .TipoCambio = oeLiquidacionTrabajador.TipoCambio
                        .TotalMN = Math.Round(oeLiquidacionTrabajador.TotalPagar, 2)
                        .TotalME = Math.Round(oeLiquidacionTrabajador.TotalPagar / oeLiquidacionTrabajador.TipoCambio, 2)
                        .TipoOperacion = "I"
                        .MovDoc = Nothing
                        ._Operador = -1
                        .UsuarioCreacion = gUsuarioSGI.IdTrabajador
                    End With
                End If
            End If
        End With
    End Sub

    Public Sub CargarCombos()
        LlenarCombos()
        LlenarComboTrabajadores()
        LlenaFlujoCaja()
        LlenaCuentaBancaria()
        llenacuenta()
        llenaMedio()
    End Sub

    Private Sub LlenaFlujoCaja()
        Try
            Dim oeFlujoCaja As New e_FlujoCaja
            Dim olFlujoCaja As New l_FlujoCaja
            Dim vl As New DataTable
            cboFlujoCaja.DataSource = vl
            LlenarCombo(cboFlujoCaja, "Nombre", olFlujoCaja.Listar(oeFlujoCaja), -1)
            cboFlujoCaja.Value = "1CH000000290"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    

    Private Sub llenaMedio()
        Try
            oeMedioPago = New e_MedioPago
            Dim olMedioPago As New l_MedioPago
            Dim leMedioPago As New List(Of e_MedioPago)
            oeMedioPago.Activo = True
            leMedioPago.AddRange(olMedioPago.Listar(oeMedioPago))
            '--------------------- para llenar combo en grilla    
            With cboMedio
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leMedioPago
                .Text = "TRANSFERENCIA DE FONDOS"
            End With
            oeMedioPago = New e_MedioPago
            With cboMedio
                Dim i As Integer = .SelectedIndex
                oeMedioPago = .Items(i).ListObject
            End With
            'cboMedio.Enabled = False 'Desativa el control 
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub llenacuenta()
        Try
            oeCtaCble = New e_CuentaContable
            oeCtaCble.Activo = True
            oeCtaCble.TipoOperacion = "Q"
            oeCtaCble.Cuenta = "10411"
            oeCtaCble.Ejercicio = Year(Date.Now)
            With cboCuentaContable
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = olCtaCble.Listar(oeCtaCble)
                .SelectedIndex = 0
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try
            If leCuentaBancaria.Count = 0 Then
                oeCtaBancaria = New e_CuentaBancaria
                oeCtaBancaria.TipoOperacion = "C"
                oeCtaBancaria.Ejercicio = Date.Parse(Date.Now).Year
                oeCtaBancaria.Activo = True
                oeCtaBancaria.IdCuentaContable = cboCuentaContable.Value
                leCuentaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
                LlenarCombo(cboCuentaBancaria, "BancoCuenta", leCuentaBancaria.Where(Function(g) g.NumeroCorrelativo <> 0).ToList, -1)
                'cboCuentaBancaria.Enabled = IIf(leCuentaBancaria.Count = 0, False, True)
            Else
                Dim lista As New List(Of e_CuentaBancaria)
                lista = leCuentaBancaria.ToList
                lista = lista.Where(Function(item) item.IdCuentaContable = oeCtaCble.Id).ToList()
                If lista.Count = 0 Then
                    cboCuentaBancaria.SelectedIndex = -1
                    'cboCuentaBancaria.Enabled = False
                Else
                    'cboCuentaBancaria.SelectedIndex = -1
                    LlenarCombo(cboCuentaBancaria, "BancoCuenta", lista, -1)
                    'cboCuentaBancaria.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        oeParametro = New e_AporteDescuento
        oeParametro.TipoOperacion = ""
        oeParametro.Activo = True
        loParametro = olParametro.Listar(oeParametro)
        oeDetParametro = New e_DetalleAporteDescuento
        oeDetParametro.TipoOperacion = ""
        oeDetParametro.Activo = True
        oeDetParametro.Vigencia = 1
        loDetParametro = olDetParametro.Listar(oeDetParametro)
        oeFormula = New e_Formula
        oeFormula.TipoOperacion = ""
        oeFormula.Activo = True
        loFormula = olFormula.Listar(oeFormula)
        oeMotivoCese = New e_MotivoCese
        oeMotivoCese.TipoOperacion = ""
        loMotivoCese.AddRange(olMotivoCese.Listar(oeMotivoCese))
        LlenarCombo(cboMotivoCese, "Nombre", loMotivoCese, -1)

        oePeriodo = New e_Periodo
        oePeriodo.TipoOperacion = ""
        oePeriodo.Activo = True
        Dim lePeriodo As New List(Of e_Periodo)
        lePeriodo = olPeriodo.Listar(oePeriodo)
        Dim _lePerAux = lePeriodo.OrderByDescending(Function(it) it.Codigo).ToList
        LlenarCombo(cboPeriodo, "Codigo", _lePerAux, -1)

        oeRegSalud = New e_RegimenSalud
        oeRegSalud.TipoOperacion = "" : oeRegSalud.Regimen = "01" : oeRegSalud.Vigente = 1 : oeRegSalud.Activo = True
        leRegSalud = olRegSalud.Listar(oeRegSalud)

        oePlanesEps = New e_PlanesEPS
        oePlanesEps.TipoOperacion = "" : oePlanesEps.Vigente = 1 : oePlanesEps.Activo = True
        lePlanesEps = olPlanesEps.Listar(oePlanesEps)



    End Sub

    Private Function ObtieneAsigFam() As Double
        Try
            oeFormula = New e_Formula
            oeFormula.Equivale = 3
            oeFormula.Nombre = "AsignacionFamiliar"
            If loFormula.Contains(oeFormula) Then
                oeFormula = loFormula.Item(loFormula.IndexOf(oeFormula))
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
                    If loParametro.Contains(oeParametro) Then
                        oeParametro = loParametro.Item(loParametro.IndexOf(oeParametro))
                        oeDetParametro = New e_DetalleAporteDescuento
                        oeDetParametro.IdAporteDescuento = oeParametro.Id
                        oeDetParametro.Equivale = 2
                        If loDetParametro.Contains(oeDetParametro) Then
                            oeDetParametro = loDetParametro.Item(loDetParametro.IndexOf(oeDetParametro))
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

    Public Sub LlenarComboTrabajadores()
        oeSueldo = New e_SueldoTrabajador
        oeSueldo.TipoOperacion = ""
        oeSueldo.Activo = True
        oeSueldo.Vigente = 1
        loSueldo = olSueldo.Listar(oeSueldo)
        oeTrabajador = New e_Trabajador
        loTrabajador = New List(Of e_Trabajador)
        oeTrabajador.TipoOperacion = "N"
        loTrabajador.AddRange(olTrabajador.Listar(oeTrabajador).Where(Function(item) item.Activo = True))
        Dim _leTrabTemp = From le In loTrabajador Select le.Id, le.oePersona.NombreCompleto
        LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabTemp.OrderBy(Function(item) item.NombreCompleto).ToList, -1)
        LlenarCombo(cboTrabajadorBusqueda, "NombreCompleto", _leTrabTemp.OrderBy(Function(item) item.NombreCompleto).ToList, -1)
    End Sub

    Private Function CargarPeriodo(fecha As Date) As e_Periodo
        oePeriodo = New e_Periodo
        oePeriodo.Ejercicio = fecha.Year
        oePeriodo.Mes = fecha.Month
        oePeriodo = olPeriodo.Obtener(oePeriodo)
        Return oePeriodo
    End Function

    Public Sub CalcularLiquidacion()
        Try
            CalcularSueldos()
            With oeTiempoLaborado
                Me.etiDsctAFP.Text = .PorcentajeAFP
                Me.etiAFP1.Text = .PorcentajeAFP
                'cts
                Me.etiFICTS.Text = .FechaInicioCTS.Date
                Me.etiFFCTS.Text = dtpFechaCese.Value.Date
                Me.txtFechaTotalCTS.Text = LTrim(.CTSTiempoTotal)
                Me.txtCTSmeses.Value = FormatoDocumento(.CTSCantidadMeses, 2)
                Me.NumeroDecimal5.Value = Math.Round(EjecutaFormula("CTSMes", False, Nothing, loFormula, loParametro, loDetParametro, TotalRemComp, .CTSCantidadMeses), 2)
                Me.txtCTSdias.Value = FormatoDocumento(.CTSCantidadDias, 2)
                Me.NumeroDecimal4.Value = Math.Round(EjecutaFormula("CTSDias", False, Nothing, loFormula, loParametro, loDetParametro, TotalRemComp, .CTSCantidadDias), 2)
                Me.txtCTSfaltas.Value = FormatoDocumento(.CTSfaltas, 2)
                Me.NumeroDecimalCTSxF.Value = Math.Round(EjecutaFormula("CTSDias", False, Nothing, loFormula, loParametro, loDetParametro, TotalRemComp, .CTSfaltas), 2)
                'Vacaciones Truncas
                Me.etiFIVT.Text = .FechaInicioVT.Date
                Me.etiFFVT.Text = dtpFechaCese.Value.Date
                Me.txtFechaTotalVT.Text = LTrim(.VTTiempoTotal)
                Me.txtVTaños.Value = FormatoDocumento(.VTCantidadAños, 2)
                Me.NumeroDecimal8.Value = Math.Round(EjecutaFormula("VTAnios", False, Nothing, loFormula, loParametro, loDetParametro, RemuSGrati, .VTCantidadAños), 2)
                Me.txtVTmeses.Value = FormatoDocumento(.VTCantidadMeses, 2)
                Me.NumeroDecimal7.Value = Math.Round(EjecutaFormula("VTMeses", False, Nothing, loFormula, loParametro, loDetParametro, RemuSGrati, .VTCantidadMeses), 2)
                Me.txtVTdias.Value = FormatoDocumento(.VTCantidadDias, 2)
                Me.txtVTDiasVacaciones.Value = FormatoDocumento(.VTDiasVacaciones, 2)
                Me.NumeroDecimal14.Value = Math.Round(RemuSGrati / 30 * .VTDiasVacaciones, 2)
                Me.NumeroDecimal6.Value = Math.Round(EjecutaFormula("VTDias", False, Nothing, loFormula, loParametro, loDetParametro, RemuSGrati, .VTCantidadDias), 2)
                Me.txtVTfaltas.Value = FormatoDocumento(.VTfaltas, 2)
                Me.NumeroDecimalVTxF.Value = Math.Round(EjecutaFormula("VTDias", False, Nothing, loFormula, loParametro, loDetParametro, RemuSGrati, .VTfaltas), 2)
                Me.NumeroDecimal13.Value = Math.Round((Me.NumeroDecimal8.Value + Me.NumeroDecimal7.Value + Me.NumeroDecimal6.Value - Me.NumeroDecimal14.Value - Me.NumeroDecimalVTxF.Value) * .PorcentajeAFP / 100, 2)
                'Gratificaciones Truncas
                Me.etiFIGT.Text = .FechaInicioGT.Date
                Me.etiFFGT.Text = dtpFechaCese.Value.Date
                Me.txtFechaTotalGT.Text = LTrim(.GTTiempoTotal)
                Me.txtGTmeses.Value = FormatoDocumento(.GTCantidadMeses, 2)
                Me.NumeroDecimal17.Value = Math.Round(EjecutaFormula("GTMeses", False, Nothing, loFormula, loParametro, loDetParametro, RemuSGrati, .GTCantidadMeses), 2)
                Me.txtGTdias.Value = FormatoDocumento(.GTCantidadDias, 2)
                Me.NumeroDecimal16.Value = Math.Round(EjecutaFormula("GTDias", False, Nothing, loFormula, loParametro, loDetParametro, RemuSGrati, .GTCantidadDias), 2)
                Me.txtGTfaltas.Value = FormatoDocumento(.GTfaltas, 2)
                Me.NumeroDecimalGTxF.Value = Math.Round(EjecutaFormula("GTDias", False, Nothing, loFormula, loParametro, loDetParametro, RemuSGrati, .GTfaltas), 2)
                'dias trabajados
                Me.etiFIDT.Text = .FechaInicioDT.Date
                If .DTCantidadDias = 0 Then Me.etiFIDT.Text = "01/" & FormatoDocumento(dtpFechaCese.Value.Date.Month, 2) & "/" & dtpFechaCese.Value.Date.Year
                Me.etiFFDT.Text = dtpFechaCese.Value.Date
                Me.txtFechaTotalDT.Text = LTrim(.DTTiempoTotal)
                Me.txtDiasdias.Value = FormatoDocumento(.DTCantidadDias, 2)
                Me.NumeroDecimal24.Value = Math.Round(EjecutaFormula("DTDias", False, Nothing, loFormula, loParametro, loDetParametro, SueldoBasico, .DTCantidadDias), 2)
                Me.txtDTfaltas.Value = FormatoDocumento(.DTfaltas, 2)
                Me.NumeroDecimalDTxFaltas.Value = Math.Round(EjecutaFormula("DTDias", False, Nothing, loFormula, loParametro, loDetParametro, SueldoBasico, .DTfaltas), 2)
                If Me.NumeroDecimal24.Value - Me.NumeroDecimalDTxFaltas.Value > 0 Then
                    Me.NumeroDecimal23.Value = Me.numAsigFam.Value
                    Me.NumeroDecimal22.Value = 5.0
                    Me.NumeroDecimal25.Value = Math.Round((Me.NumeroDecimal24.Value + Me.NumeroDecimal23.Value - Me.NumeroDecimalDTxFaltas.Value) * .PorcentajeAFP / 100, 2)
                    Me.NumeroDecimal3.Value = CalcularDstEPS()
                End If
                'Me.numDT.Value = Me.NumeroDecimal24.Value + Me.NumeroDecimal23.Value - Me.NumeroDecimalDTxFaltas.Value - Me.NumeroDecimal22.Value - Me.NumeroDecimal25.Value
                'total
                CalcularTotales()
                'bonificacion extraordinaria
                Me.numBE.Value = Math.Round(Me.numTotalGT.Value * 0.09, 2)
                'adelantos de sueldo
                Me.numAdelantoSueldo.Value = oeTiempoLaborado.Adelantos
                Me.NumeroDecimalDevolucion5ta.Value = 0
                Me.NumeroDecimalRetencion5ta.Value = 0

                Me.ND_AporteEsSalud.Value = Math.Round((Me.NumeroDecimal8.Value + Me.NumeroDecimal7.Value + Me.NumeroDecimal6.Value + Me.NumeroDecimal24.Value + NumeroDecimal23.Value - (Me.NumeroDecimal14.Value + Me.NumeroDecimalVTxF.Value + Me.NumeroDecimalDTxFaltas.Value)), 2)
                'Me.ND_AporteEsSalud.Value = Math.Round(EjecutaFormula("LbsEsSalud", False, Nothing, loFormula, loParametro, loDetParametro, Me.ND_AporteEsSalud.Value), 2)
                Me.ND_AporteEsSalud.Value = 0

                Me.numTotalLiquidacion.Value = Me.numTotalCTS.Value + Me.numTotalVT.Value + Me.numTotalGT.Value + Me.numDT.Value + Me.numBE.Value + Me.numCantGra.Value - Me.numAdelantoSueldo.Value + Me.NumeroDecimalDevolucion5ta.Value + Me.NumeroDecimalRetencion5ta.Value
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CalcularRenta5ta()
        Try
            Dim Utilidad As Double = 0.0
            Dim Gratificacion As Double = 0.0
            Dim Renta5ta As Double = 0.0
            Dim Sueldos As Double = 0.0
            Dim Adicional As Double = 0.0
            Dim Liquidacion As Double = 0.0

            Dim oeDetalleRentaQuinta As New e_DetalleRentaQuinta

            'periodos
            Dim loPeriodo As New List(Of e_Periodo)
            Dim oePeriodo5ta As New e_Periodo
            oePeriodo5ta.TipoOperacion = ""
            oePeriodo5ta.Ejercicio = Year(oeTrabajador.FechaCese)
            oePeriodo5ta.Activo = True
            loPeriodo = olPeriodo.Listar(oePeriodo5ta)

            'Liquidacion 
            Liquidacion = NumeroDecimal8.Value + NumeroDecimal7.Value + NumeroDecimal6.Value + NumeroDecimal17.Value + NumeroDecimal16.Value + numBE.Value + numCantGra.Value + NumeroDecimal24.Value + NumeroDecimal23.Value _
                - (NumeroDecimalVTxF.Value + NumeroDecimal14.Value + NumeroDecimalGTxF.Value + NumeroDecimalDTxFaltas.Value)

            'utilidad
            Dim oeUtilidad As New e_Utilidad
            Dim olUtilidad As New l_Utilidad
            oeUtilidad.TipoOperacion = "R" : oeUtilidad.Activo = True
            oeUtilidad = olUtilidad.Obtener(oeUtilidad)
            If oeUtilidad.Año = Year(oeTrabajador.FechaCese) Then
                Dim oeDetalleUtilidad As New e_ConsolidadoUtilidad
                oeDetalleUtilidad.IdTrabajador = oeTrabajador.Id : oeDetalleUtilidad.Equivale = 2
                If oeUtilidad.leConsolidado.Contains(oeDetalleUtilidad) Then
                    oeDetalleUtilidad = oeUtilidad.leConsolidado.Item(oeUtilidad.leConsolidado.IndexOf(oeDetalleUtilidad))
                    Utilidad = oeDetalleUtilidad.UtilidadTotal
                End If
            End If

            'grati
            Dim SumaGrati As Double = 0.0
            Dim oeGratificacion As New e_Gratificacion
            Dim olGratificacion As New l_Gratificacion
            Dim loGratificacion As New List(Of e_Gratificacion)
            oeGratificacion.TipoOperacion = ""
            oeGratificacion.Activo = True
            loGratificacion = olGratificacion.Listar(oeGratificacion).Where(Function(x) x.IndTipo = 1 And loPeriodo.Exists(Function(y) y.Id = x.IdPeriodo)).ToList
            'If loGratificacion.Count > 0 Then loGratificacion = loGratificacion.Where(Function(x) x.IndTipo = 1 And loPeriodo.Exists(Function(y) y.Id = x.IdPeriodo))
            For Each grati In loGratificacion
                oeGratificacion = New e_Gratificacion
                oeGratificacion.TipoOperacion = ""
                oeGratificacion.Activo = True
                oeGratificacion.Id = grati.Id
                oeGratificacion = olGratificacion.Obtener(oeGratificacion)
                If oeGratificacion.Id.Trim <> String.Empty Then
                    If oeGratificacion.leDetalle.Count > 0 Then
                        Dim _leDG = oeGratificacion.leDetalle.Where(Function(it) it.IdTrabajador = oeTrabajador.Id And it.IndPendiente = 0).ToList
                        If _leDG.Count > 0 Then SumaGrati = _leDG(0).Total
                    End If
                End If
            Next


            ''''''CARGAR SUELDO
            Dim oePlanilla As New e_Planilla, lePlanilla As New List(Of e_Planilla), olPlanilla As New l_Planilla
            Dim oeDetallePla As New e_DetallePlanilla, olDetallePla As New l_DetallePlanilla, leDetallePla As New List(Of e_DetallePlanilla)

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "" : oePlanilla.Activo = True : oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla).Where(Function(x) x.IdConfiguracion = "1SI00001" And loPeriodo.Exists(Function(y) y.Id = x.IdPeriodo)).ToList

            Dim _idPla As String = ""
            For Each oeAux In lePlanilla
                _idPla = _idPla & "'" & oeAux.Id & "',"
            Next
            If _idPla.Trim.Length > 0 Then
                _idPla = _idPla.Substring(0, _idPla.Length - 1)
                oeDetallePla = New e_DetallePlanilla
                oeDetallePla.IdPlanilla = _idPla : oeDetallePla.TipoOperacion = "R"
                leDetallePla = olDetallePla.Listar(oeDetallePla).Where(Function(x) x.IdTrabajador = oeTrabajador.Id).ToList
                For Each oeAux In leDetallePla
                    Sueldos = Sueldos + oeAux.Ingresos
                Next
            End If
            ''''''

            ''''''CARGAR RENTAS
            Dim olRetencionQuinta As New l_RetencionQuinta, leR5Historial As New List(Of e_RetencionQuinta), leDetalleR5Historial As New List(Of e_DetalleRentaQuinta) _
                , olDetalleRentaQuinta As New l_DetalleRentaQuinta

            Dim oeRenta As New e_RetencionQuinta
            oeRenta.TipoOperacion = "" : oeRenta.Activo = True
            leR5Historial = olRetencionQuinta.Listar(oeRenta).Where(Function(x) lePlanilla.Exists(Function(y) y.Id = x.IdPlanilla)).ToList
            If leR5Historial.Count > 0 Then
                Dim _idr5 As String = ""
                For Each oeAux In leR5Historial
                    _idr5 = _idr5 & "'" & oeAux.Id & "',"
                Next
                If _idr5.Trim.Length > 0 Then
                    _idr5 = _idr5.Substring(0, _idr5.Length - 1)
                    oeDetalleRentaQuinta = New e_DetalleRentaQuinta
                    oeDetalleRentaQuinta.TipoOperacion = "R" : oeDetalleRentaQuinta.IdRetencionQuinta = _idr5
                    leDetalleR5Historial = olDetalleRentaQuinta.Listar(oeDetalleRentaQuinta).Where(Function(x) x.IdTrabajador = oeTrabajador.Id).ToList
                    For Each oeAux In leDetalleR5Historial
                        Renta5ta = Renta5ta + oeAux.Monto
                        Adicional = Adicional + oeAux.Adicional
                    Next
                End If
            End If
            ''''''

            ''''''AGREGAR DATOS
            Dim nroreg As Integer = 0
            Dim _af = EjecutaFormula(gFAsignacionFamiliar, False, Nothing, loFormula, loParametro, loDetParametro)
            Dim _UITR7 = EjecutaFormula(gFUITRentaQuinta7, False, Nothing, loFormula, loParametro, loDetParametro)
            Dim _UITR1 = EjecutaFormula(gFRT5R1, False, Nothing, loFormula, loParametro, loDetParametro)
            Dim _UITR2 = EjecutaFormula(gFRT5R2, False, Nothing, loFormula, loParametro, loDetParametro)
            Dim _UITR3 = EjecutaFormula(gFRT5R3, False, Nothing, loFormula, loParametro, loDetParametro)
            Dim _UITR4 = EjecutaFormula(gFRT5R4, False, Nothing, loFormula, loParametro, loDetParametro)
            Dim _pR1 = ValorParametro(gPPorcRT5R1, loParametro, loDetParametro)
            Dim _pR2 = ValorParametro(gPPorcRT5R2, loParametro, loDetParametro)
            Dim _pR3 = ValorParametro(gPPorcRT5R3, loParametro, loDetParametro)
            Dim _pR4 = ValorParametro(gPPorcRT5R4, loParametro, loDetParametro)
            Dim _pR5 = ValorParametro(gPPorcRT5R5, loParametro, loDetParametro)
            'Dim oeDetalleRentaQuinta As New e_DetalleRentaQuinta
            With oeDetalleRentaQuinta
                .Calcular = True
                .IdTrabajador = oeTrabajador.Id : .Trabajador = oeTrabajador.oePersona.NombreCompleto : .Dni = oeTrabajador.oePersona.Dni
                '.NroMes = oePeriodo.Mes
                .NroMes = 12
                .DeduccionIUT = _UITR7
                .PorcRango1 = _pR1 : .PorcRango2 = _pR2 : .PorcRango3 = _pR3 : .PorcRango4 = _pR4 : .PorcRango5 = _pR5
                .UITRango1 = _UITR1 : .UITRango2 = _UITR2 : .UITRango3 = _UITR3 : .UITRango4 = _UITR4
                If oeTrabajador.oeArea.Nombre <> gNombreAreaOperaciones Then .Administrativo = 1
                .SueldoContratado = IIf(oeTrabajador.IndHijo = 1, oeSueldo.Sueldo + _af, oeSueldo.Sueldo)
                .PorcSeg = 0
                If oeRegSalud.IdPlanEPS.Trim <> String.Empty Then .PorcSeg = 0
                .Sueldo = 0
                .AsignacionFamiliar = 0
                .BonoProduccion = 0
                .RenumeracionVacacional = 0
                .CompensacionVacacional = 0
                .BonoResponsabilidad = 0
                .DescansoMedico = 0
                .TipoOperacion = "I" : .Activo = True : .UsuarioCreacion = gUsuarioSGI.Id
                .Basico1 = Sueldos + Liquidacion
                .Retencion1 = Renta5ta
                .Adicional = Adicional
                .BasicoG1 = Gratificacion
                .Utilidad = Utilidad
            End With
            ''''''            
            oeDetalleRentaQuinta.Calcular = True
            Dim aux5 = oeDetalleRentaQuinta.RentaBrutaAnual
            Dim aux4 = oeDetalleRentaQuinta.RentaNetaAnual
            Dim aux3 = oeDetalleRentaQuinta.ImpuestoAnual
            Dim aux6 = oeDetalleRentaQuinta.TotalRetencion

            If aux6 > aux3 Then
                Me.NumeroDecimalDevolucion5ta.Value = aux6 - aux3
            Else
                Me.NumeroDecimalRetencion5ta.Value = aux3 - aux6
            End If

            'obtener Utilidad 
            'obtener BasicoG1 
            'obtener BonoExtG1 
            'obtener BasicoG2 
            'obtener BonoExtG2
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DatosBasicos()
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = cboTrabajador.Value
            oeTrabajador.TipoBusca = 1
            FotoTrabajador.Visible = True
            agrDatosBasicos.Visible = True
            numSueldo.Value = 0.0
            numAsigFam.Value = 0.0
            numProBonProd.Value = 0.0
            numPromHorExt.Value = 0.0
            numGratificacion.Value = 0.0
            numTotalRemComp.Value = 0.0
            If loTrabajador.Contains(oeTrabajador) Then
                oeTrabajador = loTrabajador.Item(loTrabajador.IndexOf(oeTrabajador))
                If oeTrabajador.IndEstado <> 2 Then
                    btnCalcularLiquidacion.Visible = False
                    Throw New Exception("El Trabajador no Esta en Estado por Liquidar")
                End If
                txtArea.Text = oeTrabajador.oeArea.Nombre
                txtCargo.Text = oeTrabajador.oeCargo.Nombre
                txtOcupacion.Text = oeTrabajador.oeOcupacion.Nombre
                txtOcupacion.Tag = oeTrabajador.oeOcupacion.Id
                'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then FotoTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
                oeSueldo = New e_SueldoTrabajador
                oeSueldo.IdTrabajador = oeTrabajador.Id
                oeSueldo.Equivale = 1
                If loSueldo.Contains(oeSueldo) Then
                    oeSueldo = loSueldo.Item(loSueldo.IndexOf(oeSueldo))
                    numSueldo.Value = oeSueldo.Sueldo
                Else
                    numSueldo.Value = 0.0
                End If
                If oeTrabajador.IndHijo Then numAsigFam.Value = ObtieneAsigFam()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ControlBotones()
        Try
            If Operacion = "Editar" Then
                If oeLiquidacionTrabajador.Estado = "GENERADA" Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                Else
                    ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
                End If
            ElseIf Operacion = "Evaluar" Or Operacion = "Firmar" Or Operacion = "Pagar" Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                Agrupacion4.Enabled = False
                Agrupacion6.Enabled = False
            End If
            If Operacion = "Nuevo" Then
                Agrupacion4.Enabled = True
                Agrupacion6.Enabled = True
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CalcularSueldos()
        Try
            TotalRemComp = numTotalRemComp.Value
            RemuSGrati = TotalRemComp - numGratificacion.Value
            SueldoBasico = numSueldo.Value

            Me.NumeroDecimal1.Value = TotalRemComp
            Me.NumeroDecimal2.Value = TotalRemComp
            Me.NumeroDecimalCTSRem.Value = TotalRemComp

            Me.NumeroDecimal11.Value = RemuSGrati
            Me.NumeroDecimal10.Value = RemuSGrati
            Me.NumeroDecimal9.Value = RemuSGrati
            Me.NumeroDecimalVTRem.Value = RemuSGrati

            Me.NumeroDecimal19.Value = RemuSGrati
            Me.NumeroDecimal18.Value = RemuSGrati
            Me.NumeroDecimalGTRem.Value = RemuSGrati

            Me.NumeroDecimal26.Value = SueldoBasico
            Me.NumeroDecimalDTRem.Value = SueldoBasico

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CalcularTotales()
        Try
            Me.numTotalCTS.Value = Me.NumeroDecimal5.Value + Me.NumeroDecimal4.Value - Me.NumeroDecimalCTSxF.Value
            Me.numTotalVT.Value = Me.NumeroDecimal8.Value + Me.NumeroDecimal7.Value + Me.NumeroDecimal6.Value - (Me.NumeroDecimal14.Value + Me.NumeroDecimal13.Value + Me.NumeroDecimalVTxF.Value)
            Me.numTotalGT.Value = Me.NumeroDecimal17.Value + Me.NumeroDecimal16.Value - Me.NumeroDecimalGTxF.Value
            Me.numDT.Value = Me.NumeroDecimal24.Value + NumeroDecimal23.Value - NumeroDecimal22.Value - NumeroDecimal25.Value - NumeroDecimal3.Value - Me.NumeroDecimalDTxFaltas.Value
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerPlacas(IdTrabajador As String, FechaInicio As Date, FechaFin As Date) As List(Of e_Combo)
        Try
            Dim loLista As New List(Of e_Combo)
            Dim oeCombo As New e_Combo
            Dim olCombo As New l_Combo
            oeCombo.Id = IdTrabajador
            oeCombo.Nombre = "TRACTOCONDUCTOR"
            oeCombo.Descripcion = FechaInicio
            oeCombo.Fecha = FechaFin
            loLista = olCombo.Listar(oeCombo)
            Return loLista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Menu Contextual"

    Private Sub MenuContextual1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("NuevoToolStripMenuItem").Visible = True
        MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
        MenuContextual1.Items("EvaluarToolStripMenuItem").Visible = False
        MenuContextual1.Items("FirmarToolStripMenuItem").Visible = False
        MenuContextual1.Items("PagarToolStripMenuItem").Visible = False
        MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        MenuContextual1.Items("ExtornarToolStripMenuItem").Visible = False
        If griLiquidacionTrabajador.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = True
            If griLiquidacionTrabajador.ActiveRow.Cells("Estado").Value = "CALCULADA" Then
                MenuContextual1.Items("EvaluarToolStripMenuItem").Visible = True
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
            End If
            If griLiquidacionTrabajador.ActiveRow.Cells("Estado").Value = "APROBADA" Then
                MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
                MenuContextual1.Items("FirmarToolStripMenuItem").Visible = True
            End If
            If griLiquidacionTrabajador.ActiveRow.Cells("Estado").Value = "FIRMADA" Then
                MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
                'MenuContextual1.Items("ExtornarToolStripMenuItem").Visible = True
                ' MenuContextual1.Items("PagarToolStripMenuItem").Visible = True
            End If
            If griLiquidacionTrabajador.ActiveRow.Cells("Estado").Value = "PAGADA" Then
                MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
                ' MenuContextual1.Items("ExtornarToolStripMenuItem").Visible = True
                'MenuContextual1.Items("PagarToolStripMenuItem").Visible = False
            End If
            If lst_TrabjadorSeguridad.Where(Function(g) g.IdTrabajador = gUsuarioSGI.IdTrabajador).Count > 0 Then
                MenuContextual1.Items("NuevoToolStripMenuItem").Visible = False
                MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
                MenuContextual1.Items("EvaluarToolStripMenuItem").Visible = False
                MenuContextual1.Items("FirmarToolStripMenuItem").Visible = False
                MenuContextual1.Items("PagarToolStripMenuItem").Visible = False
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
                If griLiquidacionTrabajador.ActiveRow.Cells("Estado").Value = "FIRMADA" Then
                    MenuContextual1.Items("PagarToolStripMenuItem").Visible = True
                    MenuContextual1.Items("ExtornarToolStripMenuItem").Visible = False
                End If
                If griLiquidacionTrabajador.ActiveRow.Cells("Estado").Value = "PAGADA" Then
                    MenuContextual1.Items("ExtornarToolStripMenuItem").Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
        ControlBotones()
        Gb_DatoGeneralCuentaTrabajador.Visible = False
    End Sub

    Private Sub EvaluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluarToolStripMenuItem.Click
        Editar()
        Operacion = "Evaluar"
        ControlBotones()
        Gb_DatoGeneralCuentaTrabajador.Visible = False
    End Sub

    Private Sub FirmarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FirmarToolStripMenuItem.Click
        Editar()
        Operacion = "Firmar"
        ControlBotones()
        Gb_DatoGeneralCuentaTrabajador.Visible = False
    End Sub

    Private Sub PagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagarToolStripMenuItem.Click
        Editar()
        Operacion = "Pagar"
        ControlBotones()
       Limpiar_Pagar()
    End Sub

#End Region

#Region "Asiento Modelo"

    Private Sub AsientosContablesProvLiquidacion()
        AsientoModelo()
        dtReferencia = GeneraDTRef(loReferencia)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Public Sub ObtenerAsientoModelo(Ejercicio As Integer)
        Try
            oeLiquidacionTrabajador.oeAsientoModelo = New e_AsientoModelo
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '1CH01'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModeloLiquidacion = New e_AsientoModelo
            oeAsientoModeloLiquidacion.TipoOperacion = "" : oeAsientoModeloLiquidacion.Activo = True
            oeAsientoModeloLiquidacion.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModeloLiquidacion.Ejercicio = Ejercicio
            oeAsientoModeloLiquidacion = olAsientoModelo.Obtener(oeAsientoModeloLiquidacion)
            oeLiquidacionTrabajador.oeAsientoModelo = oeAsientoModeloLiquidacion
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ObtenerAsientoModelo_Pagar(Ejercicio As Integer)
        Try
            oeLiquidacionTrabajador.oeAsientoModelo = New e_AsientoModelo
            oeAsientoModeloLiquidacion = New e_AsientoModelo
            oeAsientoModeloLiquidacion.TipoOperacion = "" : oeAsientoModeloLiquidacion.Activo = True
            oeAsientoModeloLiquidacion.Id = "1SI000000007"
            oeAsientoModeloLiquidacion.Ejercicio = Ejercicio
            oeAsientoModeloLiquidacion = olAsientoModelo.Obtener(oeAsientoModeloLiquidacion)
            oeLiquidacionTrabajador.oeAsientoModelo = oeAsientoModeloLiquidacion
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Eliminar()
            Gb_DatoGeneralCuentaTrabajador.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            Eliminar()
            Gb_DatoGeneralCuentaTrabajador.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function CalcularDstEPS() As Double
        leCalculaEps = New List(Of e_PlanillaEps)
        Dim _leTrabAct As New List(Of e_Trabajador), _leTrabLiq As New List(Of e_Trabajador)
        _leTrabAct = loTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 1 And it.IndTipo = 0 _
                                                 And it.FechaIngreso < dtpFechaCese.Value).ToList
        _leTrabLiq = loTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 2 And it.IndTipo = 0 _
                                                 And it.FechaCese <> #1/1/1901# And it.FechaCese >= "01/" & dtpFechaCese.Value.Month & "/" & dtpFechaCese.Value.Year).ToList
        _leTrabAct.AddRange(_leTrabLiq)

        Dim _af = EjecutaFormula(gFAsignacionFamiliar, False, Nothing, loFormula, loParametro, loDetParametro)
        Dim _psrs = ValorParametro(gPPorcentajeEsSaludER, loParametro, loDetParametro)
        Dim _peps = ValorParametro(gPPorcentajeEsSaludEPS, loParametro, loDetParametro)
        Dim oeTrabajadorAux As e_Trabajador
        For Each oeRS In leRegSalud
            oeTrabajadorAUx = New e_Trabajador
            oeTrabajadorAUx.Id = oeRS.IdTrabajador : oeTrabajadorAUx.TipoBusca = 1
            If _leTrabAct.Contains(oeTrabajadorAux) Then
                oeTrabajadorAUx = _leTrabAct.Item(_leTrabAct.IndexOf(oeTrabajadorAUx))
                oePlanillaEPS = New e_PlanillaEps
                'If oeRS.IdTrabajador <> oeTrabajador.Id Then Continue For
                oeTrabajadorAUx.Id = oeRS.IdTrabajador : oeTrabajadorAUx.TipoBusca = 1
                oePlanillaEPS.Calcula = True
                oePlanillaEPS.TipoOperacion = "I"
                oePlanillaEPS.Activo = True
                oePlanillaEPS.IdTrabajador = oeTrabajadorAux.Id
                oePlanillaEPS.Dni = oeTrabajadorAux.oePersona.Dni
                oePlanillaEPS.Trabajador = oeTrabajadorAux.oePersona.NombreCompleto
                If oeTrabajadorAux.IndHijo = 1 Then oePlanillaEPS.AsignacionFamiliar = _af
                Dim oeSueldoAux As New e_SueldoTrabajador
                oeSueldoAux.IdTrabajador = oeTrabajadorAux.Id : oeSueldoAux.Equivale = 1
                If loSueldo.Contains(oeSueldoAux) Then
                    If oeTrabajador.Id = oeTrabajadorAux.Id Then
                        oeSueldoAux = loSueldo.Item(loSueldo.IndexOf(oeSueldoAux))
                        oePlanillaEPS.Sueldo = Math.Round(EjecutaFormula("DTDias", False, Nothing, loFormula, loParametro, loDetParametro, SueldoBasico, oeTiempoLaborado.DTCantidadDias), 2)
                    Else
                        oeSueldoAux = loSueldo.Item(loSueldo.IndexOf(oeSueldoAux))
                        oePlanillaEPS.Sueldo = oeSueldoAux.Sueldo
                    End If
                End If
                oePlanillaEPS.PorcEss = _psrs
                oePlanillaEPS.PorcEps = _peps
                oePlanesEps = New e_PlanesEPS
                oePlanesEps.Id = oeRS.IdPlanEPS
                oePlanesEps.Equivale = 1
                If lePlanesEps.Contains(oePlanesEps) Then
                    oePlanesEps = lePlanesEps.Item(lePlanesEps.IndexOf(oePlanesEps))
                    oePlanillaEPS.IdEpsContratada = oePlanesEps.Id
                    oePlanillaEPS.EpsContratada = oePlanesEps.Precio
                    Select Case oeRS.Adicional
                        Case 0 : oePlanillaEPS.Adicional = 0
                        Case 1 : oePlanillaEPS.Adicional = oePlanesEps.Adicional1 - oePlanesEps.Precio
                        Case 2 : oePlanillaEPS.Adicional = oePlanesEps.Adicional2 - oePlanesEps.Precio
                        Case 3 : oePlanillaEPS.Adicional = oePlanesEps.Adicional3 - oePlanesEps.Precio
                        Case 4 : oePlanillaEPS.Adicional = oePlanesEps.Adicional4 - oePlanesEps.Precio
                        Case 5 : oePlanillaEPS.Adicional = oePlanesEps.Adicional5 - oePlanesEps.Precio
                    End Select
                    oePlanillaEPS.Dependiente = oeRS.Adicional
                    oePlanillaEPS.Monto = oePlanillaEPS.TotalEps - (oePlanillaEPS.TitularDependiente * oePlanillaEPS.CreditoEps)
                End If
                leCalculaEps.Add(oePlanillaEPS)
            End If
        Next
        Dim _TotCred = leCalculaEps.Sum(Function(it) it.CreditoEps)
        Dim _Afiliados = leCalculaEps.Sum(Function(it) it.TitularDependiente)
        Dim ndCreditoTD = Math.Round(_TotCred / _Afiliados, 2)
        For Each oePEPS In leCalculaEps
            If oePEPS.IdTrabajador = oeTrabajador.Id Then Return oePEPS.TotalEps - (oePEPS.TitularDependiente * ndCreditoTD)
        Next
        Return 0
    End Function

    Private Sub NumeroDecimalDevolucion5ta_ValueChanged(sender As Object, e As EventArgs) Handles NumeroDecimalDevolucion5ta.ValueChanged
        If IsDBNull(NumeroDecimalDevolucion5ta.Value) Then NumeroDecimalDevolucion5ta.Value = 0.0
        Me.numTotalLiquidacion.Value = Me.numTotalCTS.Value + Me.numTotalVT.Value + Me.numTotalGT.Value + Me.numDT.Value + Me.numBE.Value + Me.numCantGra.Value - Me.numAdelantoSueldo.Value + Me.NumeroDecimalDevolucion5ta.Value - Me.NumeroDecimalRetencion5ta.Value
    End Sub

    Private Sub NumeroDecimalRetencion5ta_ValueChanged(sender As Object, e As EventArgs) Handles NumeroDecimalRetencion5ta.ValueChanged
        If IsDBNull(NumeroDecimalRetencion5ta.Value) Then NumeroDecimalRetencion5ta.Value = 0.0
        Me.numTotalLiquidacion.Value = Me.numTotalCTS.Value + Me.numTotalVT.Value + Me.numTotalGT.Value + Me.numDT.Value + Me.numBE.Value + Me.numCantGra.Value - Me.numAdelantoSueldo.Value + Me.NumeroDecimalDevolucion5ta.Value - Me.NumeroDecimalRetencion5ta.Value
    End Sub

    Private Sub btnCalcular5ta_Click(sender As Object, e As EventArgs) Handles btnCalcular5ta.Click
        '''''''''Calcular renta 5ta
        CalcularRenta5ta()
        '''''''''''''''''''
    End Sub

    Public Sub ExtornarLiquidacion()
        Try
            Dim oe_LiquidacionTrabajador_Asiento As New e_LiquidacionTrabajador_Asiento
            Dim ol_LiquidacionTrabajador_Asiento As New l_LiquidacionTrabajador_Asiento
            If griLiquidacionTrabajador.Selected.Rows.Count > 0 Then
                Dim estado As String = griLiquidacionTrabajador.ActiveRow.Cells("Estado").Value.ToString
                oe_LiquidacionTrabajador_Asiento.TipoOperacion = "E"
                oe_LiquidacionTrabajador_Asiento.usuariocrea = gUsuarioSGI.Id
                oe_LiquidacionTrabajador_Asiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                If estado = "PAGADA" Then
                    oe_LiquidacionTrabajador_Asiento.idliquidaciontrabajador = griLiquidacionTrabajador.ActiveRow.Cells("Id").Value
                    oe_LiquidacionTrabajador_Asiento.Tipo = "1CH00038"
                    If ol_LiquidacionTrabajador_Asiento.Guardar(oe_LiquidacionTrabajador_Asiento) Then
                        mensajeEmergente.Confirmacion("El pago de liquidación ha sido extornado correctamente.", True)
                    End If
                ElseIf estado = "FIRMADA" Then
                    oe_LiquidacionTrabajador_Asiento.idliquidaciontrabajador = griLiquidacionTrabajador.ActiveRow.Cells("Id").Value
                    oe_LiquidacionTrabajador_Asiento.Tipo = "1CH00037"
                    If ol_LiquidacionTrabajador_Asiento.Guardar(oe_LiquidacionTrabajador_Asiento) Then
                        mensajeEmergente.Confirmacion("La provisión de liquidación ha sido extornado correctamente.", True)
                    End If
                Else
                    Throw New Exception("Solo puede Extornar Liquidaciones Firmadas o Pagadas")
                End If
            Else
                Throw New Exception("Seleccione Registro a Extornar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnExtornar_Click(sender As Object, e As EventArgs) Handles btnExtornar.Click
        Try
            Select Case MessageBox.Show("Desea realizar el extorno del pago de liquidación?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    ExtornarLiquidacion()
                    Listar()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ExtornarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtornarToolStripMenuItem.Click
        Try
            Select Case MessageBox.Show("Desea realizar el extorno del pago de liquidación?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    ExtornarLiquidacion()
                    Listar()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
End Class