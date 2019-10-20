'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles

Public Class frm_CambiarCodNeumatico
    Dim oeNeumatico As New e_Neumatico, olNeumatico As New l_Neumatico
    Private ms_IdNeumatico As String, ms_CodigoNeumatico As String

    Sub New(ByVal ls_IdNeumatico As String, ByVal ls_CodigoNeumatico As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ms_IdNeumatico = ls_IdNeumatico
        ms_CodigoNeumatico = ls_CodigoNeumatico
      
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            oeNeumatico.TipoOperacion = "C"
            oeNeumatico.Id = ms_IdNeumatico
            oeNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olNeumatico.Guardar(oeNeumatico) Then
                MessageBox.Show("Actualizado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtCodNuevo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodNuevo.ValueChanged
        oeNeumatico.Codigo = txtCodNuevo.Text
    End Sub

    Private Sub frm_CambiarCodNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me, cmdAceptar.Name)
        txtCodActual.Text = ms_CodigoNeumatico
        txtCodNuevo.Focus()
    End Sub

    Private Sub txtCodNuevo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodNuevo.Validated
        If Not String.IsNullOrEmpty(Trim(txtCodNuevo.Text)) Then
            txtCodNuevo.Text = FormatoDocumento(txtCodNuevo.Text, 8)
        End If
    End Sub

    Private Sub txtCodNuevo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodNuevo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class
