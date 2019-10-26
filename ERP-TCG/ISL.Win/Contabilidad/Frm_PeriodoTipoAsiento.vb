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

Public Class Frm_PeriodoTipoAsiento
    Private _ComboPeriodo As Boolean = False
    Private oePeriodo As New e_Periodo
    Private olPeriodo As New l_Periodo
    Private oeTipoAsiento As New e_TablaContableDet
    Private loTipoAsiento As New l_TablaContableDet
    Private IndCierrePer As String = ""
    Private ErrorValidacion As Boolean
    Private ValidaPeriodo As Boolean
    Private ValidaTipoAsiento As Boolean
    Private ValidaFechaEmision As Boolean

    Public Sub New(ByVal lbValidaPeriodo As Boolean, ByVal lbValidaTipoASiento As Boolean, _
                   ByVal lbValidaFechaEmision As Boolean, ByVal IndCierre As String)
        InitializeComponent()
        ValidaPeriodo = lbValidaPeriodo
        ValidaTipoAsiento = lbValidaTipoASiento
        ValidaFechaEmision = lbValidaFechaEmision
        IndCierrePer = IndCierre
    End Sub

    Private Sub ComboPerido()
        Try
            If _ComboPeriodo = True Then
                oePeriodo = New e_Periodo
                Dim olPeriodo As New l_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                oePeriodo.IndCierre = IndCierrePer
                oePeriodo.Ejercicio = Año1.Año
                oePeriodo.TipoOperacion = "C"
                oePeriodo.Activo = 1
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

                LlenaComboMes(cboMes, lePeriodo)

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboTipoAsiento()
        Try
            oeTipoAsiento = New e_TablaContableDet
            Dim leTablaContableDet As New List(Of e_TablaContableDet)
            oeTipoAsiento.TipoOperacion = "N"
            oeTipoAsiento.Nombre = "TIPO DE ASIENTO" 'tipo de asiento
            oeTipoAsiento.Logico1 = True
            oeTipoAsiento.Activo = True
            leTablaContableDet.AddRange(loTipoAsiento.Listar(oeTipoAsiento))
          
            With cboTipoAsiento
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leTablaContableDet
                If .Items.Count > 0 Then
                    .SelectedIndex = 0
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema")
        End Try
    End Sub

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        Try
            ComboPerido()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Frm_PeriodoTipoAsiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ErrorValidacion Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Frm_PeriodoTipoAsiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not ValidaPeriodo Then
            Año1.Visible = False
            cboMes.Visible = False
            etiEjercicio.Visible = False
            EtiMes.Visible = False
        End If
        If Not ValidaTipoAsiento Then
            cboTipoAsiento.Visible = False
            etiTipoAsiento.Visible = False
        Else
            ComboTipoAsiento()
        End If
        If Not ValidaFechaEmision Then
            FecEmision.Visible = False
            etiEmision.Visible = False
        End If
        _ComboPeriodo = True
        Año1.Año = Date.Now.Year 'cargo periodo

        ToolTip.Enabled = True
        Dim ToolTipInfo As New UltraWinToolTip.UltraToolTipInfo
        ToolTipInfo.ToolTipTitle = "Facturas de Servicio"
        ToolTipInfo.ToolTipText = "Se considera como una factura de servicio para las cuentas del activo " + _
                                   "a las facturas que superan 1/4(UIT), o que superan los 912.5 nuevos soles."
        ToolTipInfo.ToolTipImage = ToolTipImage.Warning
        ToolTip.SetUltraToolTip(ChkActivo, ToolTipInfo)
        ToolTip.IsToolTipVisible(ChkActivo)

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If ValidaPeriodo Then ValidarCombo(cboMes, "Mes")
            If ValidaTipoAsiento Then ValidarCombo(cboTipoAsiento, "Tipo Asiento")
            If FecEmision.Visible = True Then
                If ValidaFechaEmision Then
                    If Not (Date.Parse(FecEmision.Value).Date >= oePeriodo.FechaInicio.Date And _
                              Date.Parse(FecEmision.Value).Date <= oePeriodo.FechaFin.Date) Then
                        Throw New Exception("La fecha no esta en el Periodo")
                    End If
                End If
            End If
            ErrorValidacion = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
            ErrorValidacion = True
        End Try

    End Sub

    Private Sub cboMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.ValueChanged
        If cboMes.SelectedIndex <> -1 Then
            Dim i As Integer = cboMes.SelectedIndex
            oePeriodo = New e_Periodo
            oePeriodo = cboMes.Items(i).ListObject
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Frm_PeriodoTipoAsiento_FormClosing(Nothing, Nothing)
    End Sub

End Class