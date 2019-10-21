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
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ProvisionBonificacion
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ProvisionBonificacion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ProvisionBonificacion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oePlanilla As e_Planilla, olPlanilla As l_Planilla, lePlanilla As List(Of e_Planilla)
    Private oePeriodo As e_Periodo, olPeriodo As l_Periodo, lePeriodo As List(Of e_Periodo)
    Private oeTrabajador As e_Trabajador, olTrabajador As l_Trabajador, leTrabajador As List(Of e_Trabajador)
    Private oeSueldo As e_SueldoTrabajador, olSueldo As l_SueldoTrabajador, leSueldo As List(Of e_SueldoTrabajador)
    Private oeProvision As e_ProvisionBonificacion, leProvision As List(Of e_ProvisionBonificacion)
    Private oeRSalud As e_RegimenSalud, olRSalud As l_RegimenSalud, leRSalud As List(Of e_RegimenSalud)
    Private oeParametro As e_AporteDescuento, olParametro As l_AporteDescuento, leParametro As List(Of e_AporteDescuento)
    Private oeDetParametro As e_DetalleAporteDescuento, olDetParametro As l_DetalleAporteDescuento, leDetParametro As List(Of e_DetalleAporteDescuento)
    Private oeGratificacion As e_Gratificacion, olGratificacion As l_Gratificacion
    Private oeAsientoModel As e_AsientoModelo, olAsientoModel As l_AsientoModelo, leAsientoModel As List(Of e_AsientoModelo)
    Private oeReferencia As e_AsientoModelo_Referencia, olReferencia As l_AsientoModelo_Referencia, leReferencia As List(Of e_AsientoModelo_Referencia)
    Private ld_Fecha As Date = #1/1/1901#

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            mt_Habilitar(True)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            oeAsientoModel = New e_AsientoModelo
            oeReferencia = New e_AsientoModelo_Referencia
            oeReferencia.Equivale = 3
            oeReferencia.TipoReferencia = 16 : oeReferencia.Nombre = cboTipoBono.Text
            If leReferencia.Contains(oeReferencia) Then
                oeReferencia = leReferencia.Item(leReferencia.IndexOf(oeReferencia))
                oeAsientoModel.Id = oeReferencia.IdActividad
                oeAsientoModel.TipoOperacion = String.Empty
                oeAsientoModel.Ejercicio = oePeriodo.Ejercicio
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                oeAsientoModel.FechaMov = ld_Fecha
                oeAsientoModel.TipoCambio = decTipoCambio.Value
                oeAsientoModel.UsuarioCreacion = gUsuarioSGI.Id
                oeAsientoModel.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olAsientoModel.ProvisionaBeneficios(oeAsientoModel, oePeriodo, leProvision) Then
                    mensajeEmergente.Confirmacion("¡Se ha guardado la informacion correctamente!", True)
                    mt_Habilitar(False)
                    leProvision = New List(Of e_ProvisionBonificacion)
                    mt_CargarProvBono(leProvision)
                    btnCargarDatos.Enabled = False
                    ControlBoton(0, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                mt_Habilitar(False)
                leProvision = New List(Of e_ProvisionBonificacion)
                mt_CargarProvBono(leProvision)
                ControlBoton(0, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griProvisionar.Rows.Count > 0 Then
                Exportar_Excel(griProvisionar, "Bonificacion")
            Else
                Throw New Exception("No hay Registros para Exportar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ProvisionBonificacion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If btnBuscar.Enabled Then ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0) Else ControlBoton(0, 1, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ProvisionBonificacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ProvisionBonificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_CargarLogicas()
            mt_CargarIconos()
            mt_CargarCombos()
            mt_Inicializar()
            fecPeriodo.Value = Date.Parse("01/" & fecPeriodo.Value.Month.ToString & "/" & fecPeriodo.Value.Year.ToString)
            mt_CargarProvBono(New List(Of e_ProvisionBonificacion))
            mt_Habilitar(False)
            ControlBoton(0, 1, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            mt_Inicializar()
            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = String.Empty : oePeriodo.Activo = True
            oePeriodo.Ejercicio = fecPeriodo.Value.Date.Year : oePeriodo.Mes = fecPeriodo.Value.Date.Month
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If oePeriodo.Id.Trim = "" Then Throw New Exception("¡No se encontro Periodo Contable: " & fecPeriodo.Value.Date.Year & "-" & fecPeriodo.Value.Date.Month & "!")
            oePlanilla = New e_Planilla
            oePlanilla.IdPeriodo = oePeriodo.Id : oePlanilla.IndCargaCompleto = True
            oePlanilla = olPlanilla.Obtener(oePlanilla)
            If oePlanilla.Id.Trim = "" Then Throw New Exception("¡No se encontro Planilla de Haberes: " & fecPeriodo.Value.Date.Year & "-" & fecPeriodo.Value.Date.Month & "!")
            txtPlanilla.Text = oePlanilla.Codigo
            fecInicio.Value = oePlanilla.FechaInicio : fecFin.Value = oePlanilla.FechaFin
            btnCargarDatos.Enabled = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        Try
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            leProvision = New List(Of e_ProvisionBonificacion)
            If cboTipoBono.SelectedIndex = 1 Then mt_ObtenerGratificacion()
            For Each _oePlanillaDet In oePlanilla.leDetalle
                oeProvision = New e_ProvisionBonificacion
                oeProvision.IdTrabajador = _oePlanillaDet.IdTrabajador
                oeProvision.Trabajador = _oePlanillaDet.Trabajador
                oeProvision.Dni = _oePlanillaDet.Dni
                oeProvision.Ocupacion = _oePlanillaDet.Ocupacion
                oeProvision.CentroCosto = IIf(_oePlanillaDet.IndTipoAux = 1, "ADMINISTRATIVO", "OPERACIONES")
                oeSueldo = New e_SueldoTrabajador
                oeSueldo.Equivale = 1 : oeSueldo.IdTrabajador = oeProvision.IdTrabajador
                If leSueldo.Contains(oeSueldo) Then
                    oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                    oeProvision.Remuneracion = oeSueldo.Sueldo
                End If
                Dim oeConceptoAF As New e_DetalleConcepto
                oeConceptoAF.Equivale = 3
                oeConceptoAF.CodAporDesc = "AYD004" : oeConceptoAF.IdTrabajador = oeProvision.IdTrabajador
                If oePlanilla.leDetalleConcepto.Contains(oeConceptoAF) Then
                    oeConceptoAF = oePlanilla.leDetalleConcepto.Item(oePlanilla.leDetalleConcepto.IndexOf(oeConceptoAF))
                    oeProvision.AsignacionFamiliar = oeConceptoAF.Importe
                End If
                oeTrabajador = New e_Trabajador
                oeTrabajador.TipoBusca = 1 : oeTrabajador.Id = oeProvision.IdTrabajador
                If leTrabajador.Contains(oeTrabajador) Then
                    oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                    oeProvision.FechaIngreso = oeTrabajador.FechaIngreso
                    oeProvision.FechaCese = oeTrabajador.FechaCese
                End If
                oeProvision.RemuneracionFija = oeProvision.Remuneracion + oeProvision.AsignacionFamiliar
                If cboTipoBono.SelectedIndex = 1 Then
                    Dim oeDetGrati As New e_DetalleGratificacion
                    oeDetGrati.Equivale = 1 : oeDetGrati.IdTrabajador = oeProvision.IdTrabajador
                    If oeGratificacion.leDetalle.Contains(oeDetGrati) Then
                        oeDetGrati = oeGratificacion.leDetalle.Item(oeGratificacion.leDetalle.IndexOf(oeDetGrati))
                        oeProvision.Gratificacion = oeDetGrati.NetoTotal
                    End If
                End If
                oeProvision.CostoComputable = oeProvision.RemuneracionFija + (oeProvision.Gratificacion / 6)
                oeProvision.Dias = fc_CalcularDias(oeProvision.FechaIngreso, oeProvision.FechaCese)
                oeProvision.Importe = fc_CalcularMonto(cboTipoBono.SelectedIndex, oeProvision)
                oeProvision.PrefijoID = gs_PrefijoIdSucursal '@0001
                leProvision.Add(oeProvision)
            Next
            mt_CargarProvBono(leProvision)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub cboTipoBono_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoBono.ValueChanged
        If cboTipoBono.SelectedIndex > -1 Then
            If griProvisionar.Rows.Count > 0 Then
                leProvision = New List(Of e_ProvisionBonificacion)
                mt_CargarProvBono(leProvision)
            End If
        End If
    End Sub

    Private Sub fecPeriodo_ValueChanged(sender As Object, e As EventArgs) Handles fecPeriodo.ValueChanged
        Try
            decTipoCambio.Value = 0
            ld_Fecha = Date.Parse(gf_InicioFinMes("F", fecPeriodo.Value.Year, fecPeriodo.Value.Month))
            decTipoCambio.Value = TipoCambio(ld_Fecha)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_CargarLogicas()
        olPlanilla = New l_Planilla
        olPeriodo = New l_Periodo
        olTrabajador = New l_Trabajador
        olSueldo = New l_SueldoTrabajador
        olRSalud = New l_RegimenSalud
        olParametro = New l_AporteDescuento
        olDetParametro = New l_DetalleAporteDescuento
        olGratificacion = New l_Gratificacion
        olAsientoModel = New l_AsientoModelo
        olReferencia = New l_AsientoModelo_Referencia
    End Sub

    Private Sub mt_CargarIconos()
        Try
            For Each Item In gLstIconos
                Select Case Item.Nombre
                    Case "Buscar" : btnBuscar.Appearance.Image = Item.Icono
                    Case "Agregar2" : btnCargarDatos.Appearance.Image = Item.Icono
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCombos()
        Try
            ' Cargar Tipos de Bonificaciones
            cboTipoBono.Items.Clear()
            cboTipoBono.Items.Add("GRATIFICACION")
            cboTipoBono.Items.Add("CTS")
            cboTipoBono.Items.Add("BONO EXTRA")
            cboTipoBono.Items.Add("VACACIONES")
            cboTipoBono.SelectedIndex = 0
            ' Cargar Trabajadores
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            ' Cargar Sueldos
            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = "" : oeSueldo.Activo = True : oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)
            ' Cargar Regimenes de Salud
            oeRSalud = New e_RegimenSalud
            oeRSalud.TipoOperacion = String.Empty : oeRSalud.Vigente = 1
            leRSalud = olRSalud.Listar(oeRSalud)
            ' Cargar Parametros
            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = "" : oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)
            ' Cargar Detalle Parametors
            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = "" : oeDetParametro.Activo = True : oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)
            ' Cargar Asientos Modelos
            oeAsientoModel = New e_AsientoModelo : leAsientoModel = New List(Of e_AsientoModelo)
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
            ' Cargar Asiento Modelos por Referencias
            oeReferencia = New e_AsientoModelo_Referencia : leReferencia = New List(Of e_AsientoModelo_Referencia)
            oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
            leReferencia = olReferencia.Listar(oeReferencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Inicializar()
        txtPlanilla.Text = String.Empty
        fecInicio.Value = Date.Now.Date
        fecFin.Value = Date.Now.Date
        btnCargarDatos.Enabled = False
    End Sub

    Private Sub mt_CargarProvBono(ByVal leProvBono As List(Of e_ProvisionBonificacion))
        Try
            With griProvisionar
                .ResetDisplayLayout()
                .Text = String.Empty
                .DataSource = leProvBono
                ConfiguraGrilla(griProvisionar, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna(griProvisionar, True, "IdTrabajador")
                FormatoColumna(griProvisionar, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Remuneracion", "AsignacionFamiliar", "RemuneracionFija", _
                               "Gratificacion", "CostoComputable", "Dias", "Importe")
                CalcularTotales(griProvisionar, "Importe")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ObtenerGratificacion()
        Try
            oeGratificacion = New e_Gratificacion
            oeGratificacion.TipoOperacion = "P"
            oeGratificacion.IndTipo = 1
            oeGratificacion = olGratificacion.Obtener(oeGratificacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Habilitar(ByVal lb_Band As Boolean)
        fecPeriodo.Enabled = lb_Band
        btnBuscar.Enabled = lb_Band
    End Sub

#End Region

#Region "Funciones"

    Private Function fc_CalcularDias(ByVal fecInicio As Date, ByVal fecCese As Date) As Double
        Try
            Dim NroDias As Double = 0
            If fecCese = #1/1/1901# Then
                If fecInicio <= oePeriodo.FechaInicio Then NroDias = 30 Else NroDias = DateDiff(DateInterval.Day, fecInicio, oePeriodo.FechaFin) + 1
            Else
                If fecCese = oePeriodo.FechaFin Then
                    If fecInicio <= oePeriodo.FechaInicio Then NroDias = 30 Else NroDias = DateDiff(DateInterval.Day, fecInicio, oePeriodo.FechaFin) + 1
                Else
                    If fecCese > oePeriodo.FechaFin Then
                        If fecInicio <= oePeriodo.FechaInicio Then NroDias = 30 Else NroDias = DateDiff(DateInterval.Day, fecInicio, oePeriodo.FechaFin) + 1
                    Else
                        If fecInicio <= oePeriodo.FechaInicio Then
                            NroDias = 30 - DateDiff(DateInterval.Day, fecCese, oePeriodo.FechaFin)
                        Else
                            NroDias = DateDiff(DateInterval.Day, fecInicio, fecCese) + 1
                        End If
                    End If
                End If
            End If
            Return NroDias
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_CalcularMonto(ByVal TipoBono As Integer, ByVal oeBonificacion As e_ProvisionBonificacion) As Double
        Try
            Dim Monto As Double = 0, Porc As Double = 0
            Dim _bonext = ObtieneValorParametro(gPPorcentajeEsSaludER)
            Dim _psseps = ObtieneValorParametro(gPPorcentajeEsSaludEPS)
            Select Case TipoBono
                Case 0
                    Monto = oeBonificacion.RemuneracionFija / 180 * oeBonificacion.Dias
                Case 1
                    Monto = oeBonificacion.CostoComputable / 360 * oeBonificacion.Dias
                Case 2
                    oeRSalud = New e_RegimenSalud
                    oeRSalud.Equivale = 2 : oeRSalud.IdTrabajador = oeBonificacion.IdTrabajador
                    Porc = _bonext
                    If leRSalud.Contains(oeRSalud) Then
                        oeRSalud = leRSalud.Item(leRSalud.IndexOf(oeRSalud))
                        If oeRSalud.Regimen = "01" Then Porc = _bonext - _psseps
                    End If
                    Monto = (oeBonificacion.RemuneracionFija / 180 * oeBonificacion.Dias) * Porc / 100
                Case 3
                    Monto = oeBonificacion.RemuneracionFija / 360 * oeBonificacion.Dias
            End Select
            Return Monto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ObtieneValorParametro(ls_Nombre_Parametro As String) As Double
        Try
            oeParametro = New e_AporteDescuento
            oeParametro.Abreviatura = ls_Nombre_Parametro
            oeParametro.Equivale = 4
            If leParametro.Contains(oeParametro) Then
                oeParametro = leParametro.Item(leParametro.IndexOf(oeParametro))
                oeDetParametro = New e_DetalleAporteDescuento
                oeDetParametro.IdAporteDescuento = oeParametro.Id
                oeDetParametro.Equivale = 2
                If leDetParametro.Contains(oeDetParametro) Then
                    oeDetParametro = leDetParametro.Item(leDetParametro.IndexOf(oeDetParametro))
                End If
            End If
            Return oeDetParametro.MontoCalculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region
 
End Class