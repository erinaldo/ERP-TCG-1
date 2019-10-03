'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports System.Windows.Forms

Public Class frm_justificacion_cancelacion

    Public tipo As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If tipo = "D" Then
            frm_Demanda.motivoCancelacion = Me.txtMotivoCancelacion.Text
            frm_Demanda.IdConceptoCancEliminacion = Me.cboConcepto.Value
        Else
            'eliminar/cancelar viaje
            If tipo = "V" Then
                frm_Operacion.motivoCancelacion = Me.txtMotivoCancelacion.Text
                frm_Operacion.IdConceptoCancEliminacion = Me.cboConcepto.Value
            Else
                If tipo = "VD" Then
                    frm_ViajesOperacion.motivoCancelacion = Me.txtMotivoCancelacion.Text
                    frm_ViajesOperacion.IdConceptoCancEliminacion = Me.cboConcepto.Value
                Else
                    frm_DemandaRapida.motivoCancelacion = Me.txtMotivoCancelacion.Text
                    frm_DemandaRapida.IdConceptoCancEliminacion = Me.cboConcepto.Value
                End If                
            End If
            
        End If        
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
