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

Public Class frm_DetallePlanillaViaje

    Public Sub CargarDetalle(Id As String, IdTrabajador As String)
        Try
            Dim oe As New e_DetallePlanillaPiloto
            Dim ol As New l_DetallePlanillaPiloto
            Dim lo As New List(Of e_DetallePlanillaPiloto)
            oe.IdPlanilla = Id
            oe.IdTrabajador = IdTrabajador
            lo.AddRange(ol.Listar(oe))
            gridDetalle.DataSource = lo
            CalcularTotales(gridDetalle, "Monto")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("Exportar").Visible = False
        If gridDetalle.Rows.Count > 0 Then
            MenuContextual1.Items("Exportar").Visible = True
        End If
    End Sub

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click
        Exportar_Excel(gridDetalle)
    End Sub

End Class