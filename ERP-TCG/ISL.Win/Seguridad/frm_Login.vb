'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports System.Net.Mail

Public Class frm_Login

#Region "Declaración de variables"

    'Dim olMenuProceso As New l_MenuProceso
    Dim mensajeEmergente As New c_Alertas
    Dim olUsuario As l_Usuario
    'Dim oeTrabSeguridad As New e_TrabajadorSeguridad
    'Dim olTrabSeguridad As New l_TrabajadorSeguridad
    Dim oeCombo As New e_Combo '@0001
    Dim olCombo As New l_Combo '@0001
    Dim olEmpresaSistema As New l_EmpresaSistemas '@0001

#End Region

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#Region "Eventos"



    ''' <summary>
    ''' Evento que se ejecuta cuando se hace clic en el botón Aceptar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAceptarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarR.Click
        Autenticar()
    End Sub

    Private Sub frm_Login_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Not gUsuarioSGI.Autenticado Then EnfocarControlInicial()
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se ingresa al cuadro de texto del nombre del usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtUsuarioR_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuarioR.Enter
        txtUsuarioR.BackColor = Color.AliceBlue
        txtPasswordR.BackColor = Blanco

    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se ingresa datos del nombre del usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub txtUsuarioR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuarioR.ValueChanged
        txtUsuarioR.BackColor = Color.Lavender
        txtPasswordR.BackColor = Blanco
        ActivarBotonAceptar()
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se ingresa datos de la clave de acceso o password
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtPasswordR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswordR.ValueChanged
        txtUsuarioR.BackColor = Blanco
        txtPasswordR.BackColor = Color.AliceBlue
        ActivarBotonAceptar()
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se ingresa al botón Aceptar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAceptarR_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptarR.Enter
        txtUsuarioR.BackColor = Blanco
        txtPasswordR.BackColor = Blanco
    End Sub

    ''' <summary>
    ''' Carga el formulario frm_Login
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Dim Encriptador As New ISL.Encripta.Genera
            'MsgBox(Encriptador.Desencriptar("C47F68340DCC65E21C5D1C5D402A85E3"))
            LlenaCombos() '@0001
            txtUsuarioR.Text = My.Settings.Usuario
            Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Default
            'Dim Prefijo As New l_Configuracion
            'If Prefijo.PrefijoID = "1SI" Then txtPasswordR.Text = "789-+" '@0001
            lblFecha.Text = RetornarDia((Date.Now.DayOfWeek)) & " " & IIf(CStr(Date.Now.Day).Length = 2, CStr(Date.Now.Day), ("0" & CStr(Date.Now.Day))) & " de " & RetornarMes((Date.Now.Month) - 1) & " del " & Date.Now.Year
            Timer1.Start()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub linkRecuperarR_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Try
            olUsuario = New l_Usuario
            mensajeEmergente.Confirmacion(olUsuario.RecuperarClave(txtUsuarioR.Text), True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Función para verificar y/o autenticar al usuario que ingresa al SGI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Autenticar()
        Try
            '@0001
            If cboCentro.Value = "" Then
                cboCentro.Focus()
                Throw New Exception("Seleccione SUCURSAL, con relacion al Giro del Negocio.")
            Else
                gs_PrefijoIdSucursal = cboCentro.Value
            End If
            '@0001
            olUsuario = New l_Usuario
            My.Settings.Usuario = txtUsuarioR.Text
            gUsuarioSGI = olUsuario.Autenticar(txtUsuarioR.Text, txtPasswordR.Text)

            If gUsuarioSGI.Autenticado Then
                If gUsuarioSGI.Controlado > 0 Then
                    Dim oeControlUsuario As New e_ControlUsuario
                    Dim olControlUsuario As New l_ControlUsuario
                    oeControlUsuario.IdUsuario = gUsuarioSGI.Id
                    oeControlUsuario.Ipv4 = gUsuarioSGI.ObtenerLoginWindows & "(" & gUsuarioSGI.ObtenerIP & ")"
                    oeControlUsuario.TipoOperacion = "I"
                    oeControlUsuario.PrefijoID = gs_PrefijoIdSucursal '@0001
                    gIdControl = olControlUsuario.Guardar(oeControlUsuario)
                End If
                My.Settings.Save()
            End If
            '@0001 Inicio
            Dim oeEmpresaSistema As New e_EmpresaSistemas
            Dim oeVersionSis As New e_Combo
            Dim olVersionSis As New l_Combo
            Dim VersionEst As Boolean = False
            Dim VersionSis As String = ""
            VersionSis = VersionDelSistema()
            oeEmpresaSistema = olEmpresaSistema.Obtener(oeEmpresaSistema)
            If oeEmpresaSistema.VersionSis.Trim = VersionSis.Trim Then
                oeVersionSis.Id = gUsuarioSGI.Id
                oeVersionSis.Nombre = "VersionSis"
                oeVersionSis = olVersionSis.Obtener(oeVersionSis)
                If oeVersionSis.Descripcion.Trim <> oeEmpresaSistema.VersionSis.Trim Then
                    oeVersionSis.Tipo = "2"
                    oeVersionSis.Nombre = VersionSis.Trim
                    olVersionSis.Guardar(oeVersionSis)
                End If
            Else
                mensajeEmergente.Problema("Instale ERP T&L la Version Ultima Publicada : " + oeEmpresaSistema.VersionSis.Trim, True)
                Application.Exit()
            End If
            Dim oeCentro As New e_Centro
            Dim olCentro As New l_Centro
            oeCentro.TipoOperacion = "3"
            oeCentro.Abreviatura = gs_PrefijoIdSucursal
            oeCentro.PrefijoID = gs_PrefijoIdSucursal
            oeCentro = olCentro.Obtener(oeCentro)
            gs_IdSucursal = oeCentro.Id
            '@0001 Fin
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Evento para activar y/o desactivar el botón Aceptar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ActivarBotonAceptar()
        If Not String.IsNullOrEmpty(txtUsuarioR.Text) And Not String.IsNullOrEmpty(txtPasswordR.Text) Then
            btnAceptarR.Enabled = True
        Else
            btnAceptarR.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Método para que el control inicial se cargue por defecto según corresponda
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EnfocarControlInicial()
        If Not String.IsNullOrEmpty(txtUsuarioR.Text) AndAlso txtUsuarioR.Text <> "." Then
            txtPasswordR.Focus()
            txtPasswordR.SelectAll()
        ElseIf txtUsuarioR.Text = "." OrElse String.IsNullOrEmpty(txtUsuarioR.Text) Then
            txtUsuarioR.Focus()
            txtUsuarioR.SelectAll()
        Else
            btnAceptarR.Focus()
        End If
    End Sub

#End Region

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblHora.Text = String.Format("{0:HH:mm tt}", DateTime.Now)
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se hace clic en el botón Salir
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>   
    Private Sub btnSalirR_Click_1(sender As Object, e As EventArgs) Handles btnSalirR.Click
        Application.Exit()
    End Sub

    Private Sub txtPasswordR_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasswordR.KeyDown
        If e.KeyCode = Keys.Enter Then btnAceptarR.PerformClick()
    End Sub
    '@0001 Inicio
    Private Sub LlenaCombos()
        '@0001 Inicio Variables globales
        Dim oeEmpSis As New e_EmpresaSistemas
        oeEmpSis = olEmpresaSistema.Obtener(oeEmpSis)
        With oeEmpSis
            gs_IdClienteProveedorSistema = .IdClienteProveedor.Trim
            gs_IdEmpresaSistema = .IdEmpresa.Trim
            gs_TxtEmpresaSistema = .Nombre
            gs_RucEmpresaSistema = .Ruc
            gs_DireccionEmpresaSistema = .Direccion.Trim
            gs_SmtpClientSis = .SmtpClient.Trim
            gs_userNameCorreo = .UserName.Trim
            gs_passwordCorreo = .Password.Trim
        End With
        cmbEmpresa.Text = gs_TxtEmpresaSistema.Trim
        '@0001 Fin VG
        'LlenarComboMaestro(cboCentro, CentroPublic, -1)
    End Sub
    Private Sub LlenaUsuarioSucursal()
        '@0001 Ini
        UsuarioCentroPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "UsuarioCentro"
        oeCombo.Descripcion = txtUsuarioR.Text.Trim
        UsuarioCentroPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LimpiaCombos(cboCentro)
        LlenarComboMaestro(cboCentro, UsuarioCentroPublic, -1)
        '@0001 Fin
    End Sub

    Private Sub txtPasswordR_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPasswordR.KeyUp
        LlenaUsuarioSucursal() '@0001
    End Sub

    Private Sub txtUsuarioR_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUsuarioR.KeyUp
        LlenaUsuarioSucursal() '@0001
    End Sub

    Private Sub cboCentro_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCentro.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Autenticar()
        'End If
    End Sub
    'EVENTO
    '@0001 Fin
End Class