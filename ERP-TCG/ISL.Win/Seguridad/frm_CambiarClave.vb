'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports System.Net.Mail

Public Class frm_CambiarClave

    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_CambiarClave = Nothing
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_CambiarClave()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeUsuario As New e_Usuario, olUsuario As New l_Usuario
    Private oeTrab As New e_Trabajador, olTrab As New l_Trabajador
    Dim oeAutorizacion As New e_Combo
    Dim olAutorizacion As New l_Combo
    Dim ListaAutorizacion As New List(Of e_Combo)
    Dim mensajeClave As String
    Private olPersona As New l_Persona
#End Region

#Region "Botones"

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                If gUsuarioSGI.oePersona.leEmail.Count > 0 Then
                    EnviarCorreo()
                End If
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CambiarClave_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    End Sub

    Private Sub frm_CambiarClave_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        instancia = Nothing
    End Sub

    Private Sub frm_CambiarClave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarDatos()
            chkPrincipal.Checked = True
            BloqueaClavePrincipal(False)
            txtClave.Focus()
            chkSecundario.Checked = False
            BloqueaClaveSecundario(True)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            oeAutorizacion = New e_Combo
            oeAutorizacion.Id = gUsuarioSGI.oePersona.Id
            oeAutorizacion.Nombre = "Autorizacion"
            oeAutorizacion = olAutorizacion.Obtener(oeAutorizacion)
            mensajeClave = ""
            If oeAutorizacion.Id <> "" Then
                btnVer.Visible = True
                Etiqueta1.Visible = True
                Etiqueta16.Visible = True
                txtClaveAutorizacion.Visible = True
                mensajeClave = oeAutorizacion.Nombre
            Else
                btnVer.Visible = False
                Etiqueta1.Visible = False
                Etiqueta16.Visible = False
                txtClaveAutorizacion.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        oeUsuario.Modificado = True
    End Sub

    'Private Sub txtClave_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClave.ValueChanged
    '    oeUsuario.Clave = txtClave.Text.Trim
    'End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        mensajeEmergente.Confirmacion("Su clave de Autorizacion es: " & mensajeClave, True)
    End Sub

    Private Sub chkPrincipal_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrincipal.CheckedChanged
        BloqueaClavePrincipal(Not chkPrincipal.Checked)
        If chkPrincipal.Checked Then txtClave.Focus()
    End Sub

    Private Sub chkSecundario_CheckedChanged(sender As Object, e As EventArgs) Handles chkSecundario.CheckedChanged
        BloqueaClaveSecundario(Not chkSecundario.Checked)
        If chkSecundario.Checked Then txtClave2.Focus()
    End Sub

#End Region

#Region "Metodos"

    Private Function Guardando() As Boolean
        Try
            'If Not chkPrincipal.Checked Then
            '    If Not chkSecundario.Checked Then
            '        Throw New Exception("Seleccione al menos Tipo de Clave para guardar")
            '    End If
            'End If
            If Validar() Then
                If chkPrincipal.Checked Then
                    oeUsuario.Clave = txtNuevaClave.Value
                    oeUsuario.Id = gUsuarioSGI.Id
                    oeUsuario.TipoOperacion = "C"
                    oeUsuario.Activo = True
                    oeUsuario.Codigo = txtClaveAutorizacion.Text.Trim
                    oeUsuario.oePersona.Id = gUsuarioSGI.oePersona.Id
                    olUsuario.CambiarClave(oeUsuario)
                End If
                If chkSecundario.Checked Then
                    oeTrab.TipoOperacion = "C"
                    oeTrab.ClaveSeguridad = txtNuevaClave2.Text
                    olTrab.CambiarClaveSeguridad(oeTrab)
                End If
                If oeAutorizacion.Id <> "" Then
                    If txtClaveAutorizacion.Text <> String.Empty Then
                        oeAutorizacion.Id = gUsuarioSGI.oePersona.Id
                        oeAutorizacion.Tipo = 1
                        oeAutorizacion.Nombre = txtClaveAutorizacion.Text
                        oeAutorizacion.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olAutorizacion.Guardar(oeAutorizacion)
                    End If                
                End If
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarDatos()
        Try
            Dim _band As Boolean = False
            With gUsuarioSGI
                txtDni.Text = .oePersona.Dni
                txtApellidoPaterno.Text = .oePersona.ApellidoPaterno
                txtApellidoMaterno.Text = .oePersona.ApellidoMaterno
                txtNombres.Text = .oePersona.Nombre
                fecUltimaSesion.Value = .FechaUltimoIngreso
                'If Not String.IsNullOrEmpty(.oePersona.Dni) Then pbFoto.Image = olPersona.Foto(.oePersona.Dni)
                If gUsuarioSGI.IdTrabajador.Trim <> "" Then
                    oeTrab = New e_Trabajador
                    oeTrab.TipoOperacion = "N"
                    oeTrab.Id = gUsuarioSGI.IdTrabajador
                    oeTrab = olTrab.Obtener(oeTrab)
                    If oeTrab.Id <> "" Then
                        txtArea.Text = oeTrab.oeArea.Nombre
                        txtOcupacion.Text = oeTrab.oeOcupacion.Nombre
                        fecIngreso.Value = oeTrab.FechaIngreso
                        _band = True
                    End If
                Else
                    chkSecundario.Enabled = False
                End If
                If Not _band Then
                    txtArea.Text = "NINGUNO"
                    txtOcupacion.Text = "NINGUNO"
                    fecIngreso.Value = #1/1/1901#
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
       
    End Sub

    Private Sub BloqueaClavePrincipal(_ind As Boolean)
        txtClave.ReadOnly = _ind
        txtNuevaClave.ReadOnly = _ind
        txtConfirmarNuevaClave.ReadOnly = _ind
        txtClave.Text = String.Empty
        txtNuevaClave.Text = String.Empty
        txtConfirmarNuevaClave.Text = String.Empty
    End Sub

    Private Sub BloqueaClaveSecundario(_ind As Boolean)
        txtClave2.ReadOnly = _ind
        txtNuevaClave2.ReadOnly = _ind
        txtConfirmarNuevaClave2.ReadOnly = _ind
        txtClave2.Text = String.Empty
        txtNuevaClave2.Text = String.Empty
        txtConfirmarNuevaClave2.Text = String.Empty
    End Sub

    Private Function Validar() As Boolean
        Try
            If chkPrincipal.Checked Then
                If txtClave.Text.Trim = "" Then Throw New Exception("Ingrese su Clave Acceso Actual al ERP T&L")
                If txtClave.Text.Trim <> gUsuarioSGI.Clave.Trim Then Throw New Exception("La Clave Acceso Actual al ERP T&L no es correcta")
                If txtNuevaClave.Text.Trim = "" Then Throw New Exception("Ingrese su Nueva Clave Acceso al ERP T&L")
                If txtConfirmarNuevaClave.Text.Trim = "" Then Throw New Exception("Confirmar Nueva Clave Acceso al ERP T&L")
                If txtNuevaClave.Text.Trim.Length < 8 Then Throw New Exception("La Nueva Clave Acceso al ERP T&L debe tener como mínimo 8 caracteres")
                If txtNuevaClave.Text.Trim <> txtConfirmarNuevaClave.Text.Trim Then
                    txtNuevaClave.Text = String.Empty : txtConfirmarNuevaClave.Text = String.Empty
                    Throw New Exception("La Nueva Clave Acceso al ERP T&L no coincide con la Confirmación")
                End If
                If txtClave.Text.Trim = txtNuevaClave.Text.Trim Then
                    txtNuevaClave.Text = String.Empty : txtConfirmarNuevaClave.Text = String.Empty
                    Throw New Exception("La Nueva Clave Acceso al ERP T&L debe ser diferente a la Clave Acceso Actual al ERP T&L")
                End If
            End If
            If chkSecundario.Checked Then
                If txtClave2.Text.Trim = "" Then Throw New Exception("Ingrese su Clave Seguridad Trabajador Actual")
                If txtClave2.Text.Trim <> oeTrab.ClaveSeguridad.Trim Then Throw New Exception("La Clave Seguridad Trabajador Actual no es correcta")
                If txtNuevaClave2.Text.Trim = "" Then Throw New Exception("Ingrese su Nueva Clave Seguridad Trabajador")
                If txtConfirmarNuevaClave2.Text.Trim = "" Then Throw New Exception("Confirmar Nueva Clave Seguridad Trabajador")
                If txtNuevaClave2.Text.Trim.Length <> 8 Then Throw New Exception("La Nueva Clave Seguridad Trabajador debe tener 8 caracteres")
                If Not IsNumeric(txtNuevaClave2.Text.Trim) Then Throw New Exception("La Nueva Clave Seguridad Trabajador debe ser sólo números")
                If txtNuevaClave2.Text.Trim <> txtConfirmarNuevaClave2.Text.Trim Then
                    txtNuevaClave2.Text = String.Empty : txtConfirmarNuevaClave2.Text = String.Empty
                    Throw New Exception("La Nueva Clave Seguridad Trabajador no coincide con la Confirmación")
                End If
                If txtClave2.Text.Trim = txtNuevaClave2.Text.Trim Then
                    txtNuevaClave2.Text = String.Empty : txtConfirmarNuevaClave2.Text = String.Empty
                    Throw New Exception("La Nueva Clave Seguridad Trabajador debe ser diferente a la Clave Seguridad Trabajador Actual")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Enfocar(excepcion As String)
        If excepcion.Contains("Clave Acceso Actual") Then txtClave.Focus()
        If excepcion.Contains("Nueva Clave Acceso") Then txtNuevaClave.Focus()
        If excepcion.Contains("Confirmar Nueva Clave Acceso") Then txtConfirmarNuevaClave.Focus()
        If excepcion.Contains("Clave Seguridad Trabajador Actual") Then txtClave2.Focus()
        If excepcion.Contains("Nueva Clave Seguridad Trabajador") Then txtNuevaClave2.Focus()
        If excepcion.Contains("Confirmar Nueva Clave Seguridad Trabajador") Then txtConfirmarNuevaClave2.Focus()
    End Sub

    Private Sub EnviarCorreo()
        Try
            Dim _leEmailAux = gUsuarioSGI.oePersona.leEmail.Where(Function(it) it.Principal = 1).ToList
            If _leEmailAux.Count > 0 Then
                Dim _subject As String = ""
                Dim _body As String = ""
                Dim clienteSMTP As New SmtpClient()
                clienteSMTP.Host = "mail.induamerica.com.pe"
                clienteSMTP.EnableSsl = False
                clienteSMTP.Credentials = New Net.NetworkCredential("consultores.tecnologicos.2010@gmail.com", "wtb123")
                Dim correo As New MailMessage()
                correo.To.Add(_leEmailAux(0).Nombre)
                correo.From = New MailAddress("consultores.tecnologicos.2010@gmail.com")
                If chkPrincipal.Checked Then
                    If chkSecundario.Checked Then
                        _subject = "Cambio de Clave Acceso y Seguridad de Trabajador del ERP T&L"
                        _body = "Su Nueva Clave de Acceso al ERP T&L es: " & oeUsuario.Clave & Environment.NewLine & _
                            "Su nueva Clave de Seguridad de Trabajador es: " & oeTrab.ClaveSeguridad
                    Else
                        _subject = "Cambio de Clave Acceso del ERP T&L"
                        _body = "Su Nueva Clave de Acceso al ERP T&L es: " & oeUsuario.Clave
                    End If
                Else
                    _subject = "Cambio de Clave de Seguridad de Trabajador del ERP T&L"
                    _body = "Su nueva Clave de Seguridad de Trabajador es: " & oeTrab.ClaveSeguridad
                End If
                _body = _body & Environment.NewLine & _
                    "Desde: " & gUsuarioSGI.ObtenerNombrePC & "(" & gUsuarioSGI.ObtenerIP & ")" & Environment.NewLine & _
                    "Usuario de Equipo: " & gUsuarioSGI.ObtenerLoginWindows & Environment.NewLine & Environment.NewLine & _
                    "Este Mensaje no necesita Respuesta. Gracias!!!"
                correo.Subject = _subject
                correo.Body = _body
                clienteSMTP.Send(correo)
                ' mensajeEmergente.Confirmacion("Mensaje Enviado, Rebice su(s) Email(s):" & _leEmailAux(0).Nombre)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class