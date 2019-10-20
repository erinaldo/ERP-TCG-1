'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_DatoUsuario

#Region "Declaracion de Variables"

    Private oeEmail As e_Email, olEmail As New l_Email, leEmail As New List(Of e_Email)
    Private MensajeISL As New c_Alertas

#End Region

#Region "Eventos"

    Private Sub frm_DatoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtMensaje.CharacterCasing = CharacterCasing.Normal
            txtCorporativo.CharacterCasing = CharacterCasing.Normal
            txtPersonal.CharacterCasing = CharacterCasing.Normal
            txtMensaje.Text = Environment.NewLine &
                "El Presente Formulario tiene como finalidad vincular su cuenta en el ERP a algún correo corporativo " &
                " y/o personal donde se enviará cualquier mensaje de alerta y/o comunicado asociado a los procesos propios del Sistema." &
                Environment.NewLine & Environment.NewLine & "Esta información sera guardada con la debida reserve y es para el uso" &
                " exclusivo del sistema ERP"
            verCorporativo.Checked = False
            verPersonal.Checked = True
            txtCorporativo.Focus()
            txtCorporativo.Select()
        Catch ex As Exception
            MensajeISL.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verCorporativo_CheckedChanged(sender As Object, e As EventArgs) Handles verCorporativo.CheckedChanged
        txtCorporativo.Enabled = Not verCorporativo.Checked
        If verCorporativo.Checked Then txtCorporativo.Text = String.Empty
        HabilitaGuardar(verCorporativo.Checked, verPersonal.Checked)
    End Sub

    Private Sub verPersonal_CheckedChanged(sender As Object, e As EventArgs) Handles verPersonal.CheckedChanged
        'txtPersonal.Enabled = Not verPersonal.Checked
        If verPersonal.Checked Then txtPersonal.Text = String.Empty
        HabilitaGuardar(verCorporativo.Checked, verPersonal.Checked)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Validar()
            leEmail = New List(Of e_Email)
            If Not verCorporativo.Checked Then
                oeEmail = New e_Email
                oeEmail.Nombre = txtCorporativo.Text.Trim
                CargarDatos(oeEmail)
                oeEmail.Principal = 1
                oeEmail.PrefijoID = gs_PrefijoIdSucursal '@0001
                leEmail.Add(oeEmail)
            End If
            If Not verPersonal.Checked Then
                oeEmail = New e_Email
                oeEmail.Nombre = txtPersonal.Text
                CargarDatos(oeEmail)
                oeEmail.Principal = IIf(verCorporativo.Checked, 1, 0)
                oeEmail.PrefijoID = gs_PrefijoIdSucursal '@0001
                leEmail.Add(oeEmail)
            End If
            If leEmail.Count > 0 Then
                olEmail.GuardarListar(leEmail)
                MensajeISL.Confirmacion("Se guardaron correctamente los Datos!!", True)
                Me.Close()
            End If
        Catch ex As Exception
            MensajeISL.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCerrrar_Click(sender As Object, e As EventArgs) Handles btnCerrrar.Click
        Dim lb_Band As Boolean = True
        Dim ls_Mensaje As String = ""
        If Not verCorporativo.Checked AndAlso txtCorporativo.Text.Trim <> "" Then
            ls_Mensaje = "Email Coorporativo: " & txtCorporativo.Text & Environment.NewLine
        End If
        If Not verPersonal.Checked AndAlso txtPersonal.Text.Trim <> "" Then
            ls_Mensaje = ls_Mensaje & "Email Personal: " & txtPersonal.Text
        End If
        If ls_Mensaje.Trim <> "" Then
            ls_Mensaje = "¿Esta Seguro que quiere omitir el ingreso de emails?" & Environment.NewLine & ls_Mensaje
            If MessageBox.Show(ls_Mensaje, "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                lb_Band = False
            End If
        End If
        If lb_Band Then
            MensajeISL.Confirmacion("Recuerde que si no ha ingresado al menos un email; esta ventana seguira" & _
                                    "mostrandose cada vez que inicie session en el sistema", True)
            Me.Close()
        End If

    End Sub

    Private Sub txtPersonal_ValueChanged(sender As Object, e As EventArgs) Handles txtPersonal.ValueChanged
        verPersonal.Checked = IIf(txtPersonal.Text.Trim.Length > 0, False, True)
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarDatos(oeEmailAux As e_Email)
        oeEmailAux.TipoPersonaEmpresa = 1
        oeEmailAux.IdPersonaEmpresa = gUsuarioSGI.oePersona.Id
        oeEmailAux.UsuarioCreacion = gUsuarioSGI.Id
        oeEmailAux.Activo = True
        oeEmailAux.TipoOperacion = "I"
    End Sub

    Private Sub HabilitaGuardar(lb_Cor As Boolean, lb_Per As Boolean)
        If lb_Cor AndAlso lb_Per Then
            btnGuardar.Enabled = False
        Else
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Function Validar() As Boolean
        Try
            If Not verCorporativo.Checked Then
                If Not ValidarEmail(txtCorporativo.Text.Trim) Then
                    Throw New Exception("El Email Corporativo: " & txtCorporativo.Text.Trim & " no es correcto")
                End If
            End If
            If Not verPersonal.Checked Then
                If Not ValidarEmail(txtPersonal.Text.Trim) Then
                    Throw New Exception("El Email Personal: " & txtPersonal.Text.Trim & " no es correcto")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class