'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_ReporteFlujoCajaIsl
    Inherits ISL.Win.frm_MenuPadre

    Private Shared instancia As frm_ReporteFlujoCajaIsl = Nothing
    Private Shared Operacion As String
    Private DtaIngresos As DataTable
    Private DtaEgresos As DataTable
    Private DtaEgreFinanciero As DataTable
    Private DtaIngrFinanciero As DataTable

    'Private Shared instancia As frm_ReporteFlujoCajaIsl = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReporteFlujoCajaIsl()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteFlujoCajaIsl
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteFlujoCajaIsl
        End If
        instancia.Activate()
        Return instancia
    End Function


#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            'If grid_Ingresos.Rows.Count > 0 Then
            '    MyBase.Consultar(Activo)
            'Else
            '    MyBase.Consultar()
            'End If
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            'If grid_Ingresos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            'Exportar_Excel(grid_Ingresos)

            'MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"
    Private Sub Listar()
        Try
            Dim olMovDoc As New l_MovimientoDocumento
            Dim Dta As DataTable = olMovDoc.ListarFlujoCajaIsl(dtpFechaInicio.Value, dtpFechaFin.Value)

            Dim dtarowsEgr() As DataRow = Dta.Select("N1 = 'EGRESOS'")
            DtaEgresos = dtarowsEgr.CopyToDataTable
            Grid_Egresos.DataSource = DtaEgresos
            Grid_Egresos.DataBind()

            Dim dtarowsIng() As DataRow = Dta.Select("N1 = 'INGRESOS'")
            DtaIngresos = dtarowsIng.CopyToDataTable
            grid_Ingresos.DataSource = DtaIngresos
            grid_Ingresos.DataBind()

            Dim dtarowsEgrFinanc() As DataRow = Dta.Select("N1 = 'Egresos Financieros'")
            DtaEgreFinanciero = dtarowsEgrFinanc.CopyToDataTable
            Grid_EgresosFinnancieros.DataSource = DtaEgreFinanciero
            Grid_EgresosFinnancieros.DataBind()

            Dim DtarowsIngrFinanciero() As DataRow = Dta.Select("N1 = 'Ingresos Financieros'")
            DtaIngrFinanciero = DtarowsIngrFinanciero.CopyToDataTable
            Grid_IngresosFinancieros.DataSource = DtaIngrFinanciero
            Grid_IngresosFinancieros.DataBind()

            Dim DtarowsSaldoCaja() As DataRow = Dta.Select("N1 = 'SaldoCajaBanco'")
            EtiSaldoCajaBanco.Text = Math.Round(DtarowsSaldoCaja(0).Item("N4"), 2).ToString

            SumarSaldos()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SumarSaldos()
        Dim SaldoOperativo As Double = 0
        For Each obj As DataRow In DtaIngresos.Rows
            SaldoOperativo = SaldoOperativo + obj("N4")
        Next
        For Each obj As DataRow In DtaEgresos.Rows
            SaldoOperativo = SaldoOperativo - obj("N4")
        Next
        etiFlujoCajaOperativo.Text = Math.Round(SaldoOperativo, 2).ToString

        Dim SaldoFinanciero As Double = 0
        For Each obj As DataRow In DtaIngrFinanciero.Rows
            SaldoFinanciero = SaldoFinanciero + obj("N4")
        Next
        For Each obj As DataRow In DtaEgreFinanciero.Rows
            SaldoFinanciero = SaldoFinanciero - obj("N4")
        Next
        EtiFlujoCajaFinanciero.Text = Math.Round(SaldoFinanciero, 2).ToString
        etiFlujoCajaBancoSemanal.Text = Math.Round(SaldoOperativo + SaldoFinanciero, 2).ToString

        etiSaldoCajaAcumulado.Text = Math.Round(SaldoOperativo + SaldoFinanciero + EtiSaldoCajaBanco.Text, 2).ToString
    End Sub


#End Region

#Region "Eventos"

    Private Sub frm_ReporteFlujoCajaIsl_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ReporteFlujoCajaIsl_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteFlujoCajaIsl_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReporteFlujoCajaIsl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

#End Region


End Class
