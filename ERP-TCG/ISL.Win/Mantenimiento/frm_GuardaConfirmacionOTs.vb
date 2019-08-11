Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_GuardaConfirmacionOTs
    Private oeRegConformidadOT As New e_RegistroConformidadOT
    Private oeDetRegConformidadOT As New e_DetalleRegConformidadOT
    Private olRegConformidadOT As New l_RegistroConformidadOT
    Public mensajeEmergente As New c_Alertas

    Sub New(ByVal oeRegConformidad As e_RegistroConformidadOT)
        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()
        oeRegConformidadOT = oeRegConformidad
        Me.Fecha.Value = Date.Today
    End Sub
    Private Sub GuardarConfirmacionOTs()
        Try
            oeRegConformidadOT.TipoOperacion = "I"
            oeRegConformidadOT.Indicador = IIf(optIndComprobancion.CheckedIndex = 0, "C", "D")
            oeRegConformidadOT.Glosa = Me.txtGlosa.Text
            oeRegConformidadOT.FechaConfirmo = Me.Fecha.Value
            oeRegConformidadOT.UsuarioConfirmo = gUsuarioSGI.Id
            olRegConformidadOT.Guardar(oeRegConformidadOT)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    GuardarConfirmacionOTs()
                    Me.DialogResult = Windows.Forms.DialogResult.OK

                Case Windows.Forms.DialogResult.No
                    Me.DialogResult = Windows.Forms.DialogResult.No
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            GuardarConfirmacionOTs()
            mensajeEmergente.Confirmacion("Se Registro Satisfactoriamente", True)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frm_GuardaConfirmacionOTs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtGlosa.Select()
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged

    End Sub
End Class