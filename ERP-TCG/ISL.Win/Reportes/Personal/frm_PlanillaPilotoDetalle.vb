Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_PlanillaPilotoDetalle
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_PlanillaPilotoDetalle = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_PlanillaPilotoDetalle()
        End If
        instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oePlanillaPiloto As New e_PlanillaPiloto
    Private olPlanillaPiloto As New l_PlanillaPiloto
    'Private loAsistenciaPersonal As New List(Of e_AsistenciaPersonal)

    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador

    Private oePeriodo As New e_Periodo
    Private olPeriodo As New l_Periodo
    Private lePeriodo As New List(Of e_Periodo)

    Private oePlanilla As New e_Planilla
    Private olPlanilla As New l_Planilla
    Private loPlanilla As New List(Of e_Planilla)

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            CargarDatos()
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ninguna Demanda para exportar al Excel")
            Exportar_Excel(griLista)
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_PlanillaPilotoDetalle_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_PlanillaPilotoDetalle_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_PlanillaPilotoDetalle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_AsistenciaPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBs()
        CargarPlanilla()
        cboPlanillas.Focus()
    End Sub

    Private Sub Año1_DatoCambiado_1() Handles Año1.DatoCambiado
        Try
            cboPlanillas.Clear()
            CargarPlanilla()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboTrabajador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTrabajador.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Consultar(True)
        End If
    End Sub

#End Region
    
#Region "Metodos"

    Private Sub CargarDatos()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oePlanillaPiloto = New e_PlanillaPiloto
            oePlanillaPiloto.Id = cboPlanillas.Value
            oePlanillaPiloto.IdPlanilla = cboTrabajador.Value
            Dim ds As DataSet = olPlanillaPiloto.ListarDS(oePlanillaPiloto)
            Dim parentCol As DataColumn = ds.Tables(0).Columns("Id")
            Dim childCol As DataColumn = ds.Tables(1).Columns("IdTrabajador")
            Dim relation As DataRelation = New DataRelation("FKTrabajador", parentCol, childCol, True)
            ds.Relations.Add(relation)
            ds.AcceptChanges()
            griLista.DataSource = ds
            With griLista
                If .Rows.Count > 0 Then
                    .DisplayLayout.Bands(1).Columns("IdTrabajador").Hidden = True
                    .DisplayLayout.Bands(1).Columns("Trabajador").Hidden = True
                    .DisplayLayout.Bands(1).Columns("MontoTotal").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Trabajador").Width = 350
                    .DisplayLayout.Bands(0).Columns("MontoTotal").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Ruta").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(1).Columns("Viaje").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(1).Columns("Fecha").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(1).Columns("Ruta").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(1).Columns("Viaje").Width = 125
                    .DisplayLayout.Bands(1).Columns("Ruta").Width = 350
                    .DisplayLayout.Bands(1).Columns("Cargo").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(1).Columns("Monto").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(1).Columns("Cuenta").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(1).Columns("Estado").Header.VisiblePosition = 6
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub CargarCBs()
        Dim oeC As New e_Combo
        Dim listatrabajador As New List(Of e_Combo)
        oeC.Id = ""
        oeC.Nombre = "TODOS"
        listatrabajador.Add(oeC)
        listatrabajador.AddRange(TrabajadorPublic)
        LlenarCombo(cboTrabajador, "Nombre", listatrabajador, 0)

    End Sub

    Public Sub CargarPlanilla()
        Try
            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.IdPeriodo = Año1.Año
            LlenarCombo(Me.cboPlanillas, "Codigo", olPlanilla.Listar(oePlanilla).OrderByDescending(Function(item) item.Codigo).ToList, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
    
End Class