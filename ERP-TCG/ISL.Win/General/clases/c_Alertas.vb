Imports Infragistics.Win.Misc
Imports Infragistics.Win.SoundEvents
Imports System.Net.Mail
Imports System.ServiceModel

Public Class c_Alertas

    Dim alert As New Infragistics.Win.Misc.UltraDesktopAlert
    Dim showInfo As UltraDesktopAlertShowWindowInfo = New UltraDesktopAlertShowWindowInfo()

    ''' <summary>
    ''' Muestra un mensaje emergente para hacer conocer algún error o problema encontrado en algún proceso
    ''' </summary>
    ''' <param name="mensaje">Mensaje de error o del sistema que se mostrará al usuario</param>
    ''' <param name="MensajeModal">Especifica la forma en que se muestra el mensaje al usuario; False = por defecto(ventana transparente) / True = Ventana modal MessageBox clásico</param>
    ''' <remarks></remarks>
    Public Sub Problema(ByVal mensaje As String, Optional ByVal MensajeModal As Boolean = False)
        Try
            If System.Environment.OSVersion.Version.Major >= 6 And MensajeModal = False Then
                If (alert.IsOpen("MensajeError")) Then Return
                Alerta(Color.LightPink).Show(Informacion(mensaje))
            Else
                MessageBox.Show(mensaje, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Nueva manera de mostrar mensajes emergentes para hacer conocer algún error o problema encontrado en algún proceso
    ''' </summary>
    ''' <param name="objetoMensajeError">Objeto de tipo Mensaje de error o del sistema que se mostrará al usuario</param>
    ''' <param name="MensajeModal">Especifica la forma en que se muestra el mensaje al usuario; False = por defecto(ventana transparente) / True = Ventana modal MessageBox clásico</param>
    ''' <param name="formulario">Especifica el nombre del formulario (capa windows) donde se muestra el error (se usa para la depuración y seguimiento</param>
    ''' <remarks></remarks>
    Public Sub ProblemaEnvioEmail(ByVal objetoMensajeError As FaultException(Of SGI_WCF.MensajeError), Optional ByVal MensajeModal As Boolean = False, Optional ByVal formulario As String = "")
        Try
            If errorEnviadoEmail = False Then
                'Captura la pantalla que reporta error en el ERP T&L
                Dim imagenPantallaCapturada As String = "UltimoReporteSGI.png"
                CapturaPantalla(imagenPantallaCapturada)
                'Envia email con detalles del error presentado
                Dim rutaCompletaImagenCapturada As String = System.AppDomain.CurrentDomain.BaseDirectory.ToString & imagenPantallaCapturada
                Dim mensajeHtml As String = "<html><body><table><tr><td>Usuario : " & gUsuarioSGI.oePersona.NombreCompleto & "</td></tr><tr><td>PC : " & gUsuarioSGI.ObtenerIP & "</td></tr><tr><td>Area : " & gUsuarioSGI.oeArea.Nombre & "</td></tr><tr><td>Fecha " & objetoMensajeError.Detail.Fecha.ToLocalTime & "</td></tr><tr><td>Formulario: " & formulario & " </td></tr><tr><td>Mensaje mostrado al Usuario: " & objetoMensajeError.Detail.Mensaje & " </td></tr><tr><td>Error específico del sistema: " & objetoMensajeError.Detail.Detalle & " </td></tr><tr><td>Pila: " & objetoMensajeError.Detail.Causa & "</td></tr></table></body></html>"
                EnviarEmail("consultores.tecnologicos.2010@gmail.com", "consultores.tecnologicos.2010@gmail.com", "", "", "Error en ERP T&L", mensajeHtml, rutaCompletaImagenCapturada, False)
                errorEnviadoEmail = True
            End If
            'Mostrar le mensaje al usuario
            If System.Environment.OSVersion.Version.Major >= 6 And MensajeModal = False Then
                If (alert.IsOpen("MensajeError")) Then Return
                Alerta(Color.LightPink).Show(Informacion(objetoMensajeError.Detail.Mensaje))
            Else
                MessageBox.Show(objetoMensajeError.Detail.Mensaje, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ''' <summary>
    ''' Muestra un mensaje emergente para confirmar algún proceso exitoso
    ''' </summary>
    ''' <param name="mensaje">Mensaje de error o del sistema que se mostrará al usuario</param>
    ''' <param name="MensajeModal">Especifica la forma en que se muestra el mensaje al usuario; False = por defecto(ventana transparente) / True = Ventana modal MessageBox clásico</param>
    ''' <remarks></remarks>
    Public Sub Confirmacion(ByVal mensaje As String, Optional ByVal MensajeModal As Boolean = False)
        Try
            If System.Environment.OSVersion.Version.Major >= 6 And MensajeModal = False Then
                If (alert.IsOpen("MensajeError")) Then Return
                Alerta(Color.Gainsboro).Show(Informacion(mensaje))
            Else
                MessageBox.Show(mensaje, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Evento privado que administra las alertas del sistema
    ''' </summary>
    ''' <param name="color"></param>
    ''' <remarks></remarks>
    Private Function Alerta(ByVal color As System.Drawing.Color) As Infragistics.Win.Misc.UltraDesktopAlert
        Try
            alert = New Infragistics.Win.Misc.UltraDesktopAlert
            If Not showInfo Is Nothing Then

                Infragistics.Win.Misc.Resources.Customizer.SetCustomizedString("DesktopAlertLinkUIElement_Caption_ToolTipText_Office2007", String.Empty)
                Infragistics.Win.Misc.Resources.Customizer.SetCustomizedString("DesktopAlertLinkUIElement_Text_ToolTipText_Office2007", "Cerrar esta ventana de Información")

                alert.TreatFooterTextAsLink = Infragistics.Win.DefaultableBoolean.True
                alert.TreatCaptionAsLink = Infragistics.Win.DefaultableBoolean.False

                alert.Appearance.BackColor = color
                alert.AutoClose = Infragistics.Win.DefaultableBoolean.True
                'alert.Style = DesktopAlertStyle.WindowsLiveMessenger
                alert.Style = DesktopAlertStyle.Office2007
                alert.AllowMove = Infragistics.Win.DefaultableBoolean.False

                alert.AutoCloseDelay = 500
            End If
            Return alert

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function Informacion(ByVal mensaje As String) As UltraDesktopAlertShowWindowInfo

        If showInfo.Key = "MensajeError" Then
            showInfo = New UltraDesktopAlertShowWindowInfo()
        End If

        showInfo.Key = "MensajeError"

        showInfo.Caption = "Mensaje del sistema"
        showInfo.Text = mensaje
        showInfo.FooterText = "Cerrar"
        Dim olDatosConfiguracion As New ISL.LogicaWCF.l_Configuracion

        showInfo.Image = New Icon(olDatosConfiguracion.RutaImagen & "\LogoERP.ico").ToBitmap()
        showInfo.Sound = olDatosConfiguracion.RutaImagen & "\Sonido.wav"

        showInfo.ScreenPosition = ScreenPosition.Center

        showInfo.Screen = Screen.AllScreens(Screen.AllScreens.Length - 1)

        'If Not Me.alert.CloseButtonVisible Then
        showInfo.VisibleAlertButtons.InitializeFrom(alert)
        'showInfo.VisibleAlertButtons.Remove(showInfo.VisibleAlertButtons("close"))
        'End If

        Return showInfo
    End Function


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

    End Sub


End Class