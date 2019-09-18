Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics

Public Class frm_ReporteFlujoBancario
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el Formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteFlujoBancario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReporteFlujoBancario()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private WithEvents oeReporteFlujoBanco As e_ReporteFlujoBanco
    Private olReporteFlujoBanco As l_ReporteFlujoBanco
    Private loReporteFlujoBanco As List(Of e_ReporteFlujoBanco)

    Dim olFlujoCaja As New l_FlujoCaja
    Dim loFlujoCaja As List(Of e_FlujoCaja)

    Dim oePeriodo As New e_Periodo
    Dim olPeriodo As New l_Periodo
    Dim lePeriodo As New List(Of e_Periodo)

    Dim lo As List(Of e_FlujoCaja)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If ValidarLista(loReporteFlujoBanco) Then
                olReporteFlujoBanco = New l_ReporteFlujoBanco
                If olReporteFlujoBanco.Guardar(loReporteFlujoBanco, cboMes.Value, gs_PrefijoIdSucursal) Then
                    mensajeEmergente.Confirmacion("La Informacion se ha Guardado Correctamente", True)
                    loReporteFlujoBanco = New List(Of e_ReporteFlujoBanco)
                    griListaMov.DataSource = loReporteFlujoBanco
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        If griListaMov.Rows.Count > 0 Then Exportar_Excel(griListaMov)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteFlujoBancario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If griListaMov.Rows.Count > 0 Then
            ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
        Else
            ControlBoton(1)
        End If
    End Sub

    Private Sub frm_ReporteFlujoBancario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteFlujoBancario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ComboPeriodo()
            ComboFlujoCaja()
            cboMes.Text = Date.Now.Month.ToString
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMov_CellChange(sender As Object, e As CellEventArgs)
        griListaMov.UpdateData()
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Try
            If cboFlujoCaja.SelectedIndex = -1 Then Throw New Exception("Seleccione Flujo de Caja")
            If MessageBox.Show("Se va Actualizar los Flujos Nuevos de la Seleccion por: " & cboFlujoCaja.Text & " ?", _
                                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If griListaMov.Rows.Count > 0 Then
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaMov.Rows.Where(Function(item) item.IsFilteredOut = False)
                        If Fila.Cells("Seleccion").Value = True Then
                            Fila.Cells("IdFlujoNuevo").Value = cboFlujoCaja.Value
                            CrearComboGrid("IdFlujoNuevo", "Nombre", griListaMov, olFlujoCaja.ComboGrilla(loFlujoCaja), True)
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            '  lo = New List(Of e_FlujoCaja)
            If MessageBox.Show("Se van a Limpiar los FLujos de Caja de la Seleccion?", _
                                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If griListaMov.Rows.Count > 0 Then
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaMov.Rows.Where(Function(item) item.IsFilteredOut = False)
                        Fila.Cells("IdFlujoNuevo").Value = ""
                    Next
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbSeleccion_CheckedChanged(sender As Object, e As EventArgs) Handles cbSeleccion.CheckedChanged
        Try
            If cbSeleccion.Checked Then
                For Each obj In griListaMov.Rows.Where(Function(item) item.IsFilteredOut = False)
                    obj.Cells("Seleccion").Value = True
                Next
            Else
                For Each obj In griListaMov.Rows.Where(Function(item) item.IsFilteredOut = False)
                    obj.Cells("Seleccion").Value = False
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbInd_CheckedChanged(sender As Object, e As EventArgs) Handles cbInd.CheckedChanged
        Try
            If cbInd.Checked Then
                For Each obj In griListaMov.Rows.Where(Function(item) item.IsFilteredOut = False)
                    obj.Cells("IndFinanciamiento").Value = True
                Next
            Else
                For Each obj In griListaMov.Rows.Where(Function(item) item.IsFilteredOut = False)
                    obj.Cells("IndFinanciamiento").Value = False
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        If oePeriodo.Ejercicio <> Año1.Año Then
            oePeriodo = New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            oePeriodo.Ejercicio = Año1.Año
            oePeriodo.Activo = True
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

            With cboMes
                .DisplayMember = "NomMes"
                .ValueMember = "Id"
                .DataSource = lePeriodo
                If .Items.Count > 0 Then
                    .SelectedIndex = -1
                End If
            End With
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub Listar(Activo As Boolean)
        Try
            oeReporteFlujoBanco = New e_ReporteFlujoBanco
            olReporteFlujoBanco = New l_ReporteFlujoBanco
            loReporteFlujoBanco = New List(Of e_ReporteFlujoBanco)
            lo = New List(Of e_FlujoCaja)
            griListaMov.DataSource = loReporteFlujoBanco
            If cboMes.SelectedIndex = -1 Then Throw New Exception("¡Seleccione Periodo Contable!")
            oeReporteFlujoBanco.IdPeriodo = cboMes.Value
            loReporteFlujoBanco = olReporteFlujoBanco.Listar(oeReporteFlujoBanco)
            griListaMov.DataSource = loReporteFlujoBanco
            CrearComboGrid("IdFlujoNuevo", "Nombre", griListaMov, olFlujoCaja.ComboGrilla(loFlujoCaja), True)
            CalcularTotales(griListaMov, "Total")
            If loReporteFlujoBanco.Count > 0 Then
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            oePeriodo.Ejercicio = Año1.Año
            oePeriodo.Activo = True
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            With cboMes
                .DisplayMember = "NomMes"
                .ValueMember = "Id"
                .DataSource = lePeriodo
                If .Items.Count > 0 Then
                    .SelectedIndex = 1
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboFlujoCaja()
        Try
            Dim oeFlujoCaja As New e_FlujoCaja
            loFlujoCaja = New List(Of e_FlujoCaja)
            oeFlujoCaja.TipoOperacion = "N"
            loFlujoCaja.AddRange(olFlujoCaja.Listar(oeFlujoCaja))
            LlenarCombo(cboFlujoCaja, "Nombre", loFlujoCaja, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarLista(lo As List(Of e_ReporteFlujoBanco)) As Boolean
        Try
            'For Each oe As e_ReporteFlujoBanco In lo
            '    If oe.IdFlujoNuevo = "" Then Throw New Exception("Tiene que Asignar un Flujo a Todos los Registros")
            'Next
            Dim _leRFNuevo = lo.Where(Function(it) it.Id.Trim = "" And it.IdFlujoNuevo.Trim <> "").ToList
            Dim _leRFActualiza = lo.Where(Function(it) it.Id.Trim <> "" And it.IdFlujoNuevo.Trim <> it.IdFlujoApoyo).ToList
            If _leRFNuevo.Count = 0 And _leRFActualiza.Count = 0 Then Throw New Exception("¡No hay Informacion para guardar o actualizar!")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class