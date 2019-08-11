Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteDescTrabajador
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteDescTrabajador = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReporteDescTrabajador
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeRDescTrabajador As New e_ReporteDescTrabajador
    Dim olRDescTrabajador As New l_Prestamo
    Dim leRDescTrabajador As New List(Of e_ReporteDescTrabajador)

    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla)
    Private oeDescuento As New e_Descuentos, olDescuento As New l_Descuentos, leDescuento As New List(Of e_Descuentos)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private _acl As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            oeRDescTrabajador = New e_ReporteDescTrabajador
            oeRDescTrabajador.TipoOperacion = "1"
            oeRDescTrabajador.Anio = fecPeriodo.Value.Year.ToString
            oeRDescTrabajador.Mes = FormatoDocumento(fecPeriodo.Value.Month.ToString, 2)
            oeRDescTrabajador.Indicador = IIf(optnrodesc.CheckedIndex = 0, "1", "2")
            leRDescTrabajador = olRDescTrabajador.ListarRDT(oeRDescTrabajador)
            CargarRDT(leRDescTrabajador)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Exportar_Excel(griDescTrabajador)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteDescTrabajador_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If griDescTrabajador.Rows.Count > 0 Then
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Else
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReporteDescTrabajador_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteDescTrabajador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fecPeriodo.Value = Convert.ToDateTime("01/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString)
            CargarCombo()
            optnrodesc.CheckedIndex = 0
            ficRptDescuentos.Tabs(1).Visible = False
            CargarRDT(New List(Of e_ReporteDescTrabajador))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub fecPeriodo_ValueChanged(sender As Object, e As EventArgs) Handles fecPeriodo.ValueChanged
        btnEnviar.Enabled = False
        oePeriodo = New e_Periodo
        oePeriodo.Ejercicio = fecPeriodo.Value.Year : oePeriodo.Mes = fecPeriodo.Value.Month : oePeriodo.Equivale = 2
        If lePeriodo.Contains(oePeriodo) Then
            oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
            Dim _lePla = lePlanilla.Where(Function(it) it.IdPeriodo = oePeriodo.Id And it.Estado = gNombreEstadoGenerada).ToList
            LlenarCombo(cboPlanilla, "Codigo", _lePla, -1)
        End If
    End Sub

    Private Sub cboPlanilla_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanilla.ValueChanged
        Try
            If cboPlanilla.SelectedIndex > -1 Then
                oePlanilla = New e_Planilla
                oePlanilla = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
                btnEnviar.Enabled = IIf(oePlanilla.Estado = "GENERADA", True, False)
            Else
                btnEnviar.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griDescTrabajador.Rows.Count > 0 Then
                    If cboPlanilla.SelectedIndex > -1 Then
                        oeDescuento = New e_Descuentos
                        oeDescuento.IdPlanilla = cboPlanilla.Value : oeDescuento.Activo = True
                        leDescuento = olDescuento.Listar(oeDescuento)
                        If leDescuento.Count > 0 Then
                            Throw New Exception("No se puede Realizar la Operacion. Ya Existen Registros de Descuentos en Esta Planilla")
                        Else
                            Dim formulario As frm_AutenticarTrabajador
                            formulario = New frm_AutenticarTrabajador
                            formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                            If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                                Throw New Exception("Ingrese un Clave Correcta")
                            Else
                                Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoEnviado).ToList
                                leDescuento = New List(Of e_Descuentos)
                                For Each oeRDT In leRDescTrabajador
                                    oeDescuento = New e_Descuentos
                                    oeDescuento.TipoOperacion = "I"
                                    oeDescuento.IdPlanilla = cboPlanilla.Value
                                    oeDescuento.IdTrabajador = oeRDT.oeTrabajador.Id
                                    oeDescuento.MontoAdelanto = oeRDT.Adelanto
                                    oeDescuento.MontoSancion = oeRDT.Sancion
                                    oeDescuento.UsuarioCreacion = gUsuarioSGI.Id
                                    oeDescuento.IndTipo = 1
                                    oeDescuento.IdEstado = _leEstAux(0).Id
                                    oeDescuento.Activo = True
                                    leDescuento.Add(oeDescuento)
                                Next
                                If olDescuento.GuardarMasivo(leDescuento) Then
                                    cboPlanilla.SelectedIndex = -1
                                    btnEnviar.Enabled = False
                                    mensajeEmergente.Confirmacion("El Envio de Datos se Realizo Exitosamente", True)
                                End If
                            End If
                        End If
                    Else
                        Throw New Exception("Seleccione una Planilla para Enviar")
                    End If
                Else
                    Throw New Exception("No Existen Registros para Enviar a Planilla")
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

    Private Sub CargarCombo()
        Try

            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = "" : oePeriodo.Activo = True
            lePeriodo = olPeriodo.Listar(oePeriodo)

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "" : oePlanilla.Activo = True : oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla)

            oeEstado = New e_Estado
            oeEstado.Nombre = "PLANILLA EPS"
            leEstado = olEstado.Listar(oeEstado)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarRDT(ByVal leAux As List(Of e_ReporteDescTrabajador))
        Try
            Dim _leRDT = From le In leAux _
                         Select IdTrabajador = le.oeTrabajador.Id, le.oeTrabajador.oePersona.Dni _
                         , Nombre = le.oeTrabajador.oePersona.Nombre, le.oeTrabajador.Activo _
                         , le.Adelanto, le.Sancion, le.Total _
                         Order By Nombre Ascending

            With griDescTrabajador
                .DataSource = _leRDT.ToList
                OcultarColumna(griDescTrabajador, True, "IdTrabajador", "Activo")
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 350
                FormatoColumna(griDescTrabajador, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Adelanto", "Sancion", "Total")
                .DisplayLayout.Bands(0).Columns("Adelanto").CellAppearance.BackColor = Color.LightGray
                .DisplayLayout.Bands(0).Columns("Sancion").CellAppearance.BackColor = Color.LightGray
                .DisplayLayout.Bands(0).Columns("Total").CellAppearance.BackColor = Color.LightGreen
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                .Text = "RELACIÓN DE DESCUENTOS EJECUTADOS EL MES " & MonthName(fecPeriodo.Value.Month).ToUpper & " " & fecPeriodo.Value.Year
                If .Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    For Each fila In .Rows
                        If Not fila.Cells("Activo").Value Then
                            fila.Cells("Dni").Appearance.BackColor = Color.LightCoral
                            fila.Cells("Nombre").Appearance.BackColor = Color.LightCoral
                        End If
                    Next
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If

            End With

            CalcularTotales(griDescTrabajador, "Adelanto", "Sancion", "Total")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class