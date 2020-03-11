'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-08-30  |   NSOFT   |   Se comento los mensaje emergentes
' @0002 |   2019-01-01  |   CT2010  |   LLenar Combo
' @0003 |   2019-10-01  |   CT2010  |   Disponibilidad de BD tabla EmpresaSistemas
'=================================================================================================================


Imports System.IO
Imports Infragistics.Win
Imports Infragistics.Win.Misc
Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports System.Threading
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Deployment.Application
Imports Infragistics.Win.UltraWinGrid
'Imports System.Text
Public Class frm_Menu

    Public Sub New()
        InitializeComponent()
    End Sub

#Region "Variables para Alertas"

    Public IniciaSeccion As Boolean = False
    Public Conecta As Boolean = False
    Public Desconecta As Boolean = False
    Dim HoraSalida As Integer = 0
    Dim band As Boolean = True
    Dim band2 As Boolean = True
    Dim band3 As Boolean = False
    Dim Bandbd As Boolean = False
    Dim Bandr As Boolean = False
    Dim BandOC As Boolean = False
    Dim TotalOC As Integer = 0
    Dim BandRestablece As Boolean = False
    Public Contador As Integer = 0

#End Region

#Region "Variables"

    Private Const mstrUsuCovisol As String = "slalito"
    Private Const mstrPassCovisol As String = "20480099720"
    Private mintTarjetasPocoSaldo As Integer = 0
    Private mbolProcesoCancelado As Boolean = False
    Dim HiloIsl As Thread
    Dim HiloIslInicio As New ThreadStart(AddressOf VerificaHiloIsl)
    Dim MetodoHilo As New MethodInvoker(AddressOf ListaOnomasticos)

    Dim MensajeEmergente As New c_Alertas
    Dim oeControlTU As New e_ControlTurnoUsuario

    Dim Ampliacion As Integer = 0
    Dim Mantenimiento As String = ""
    Dim Operaciones As String = ""
    Dim Seguimiento As String = ""
    Dim Guias As String = ""
    Dim Logistica As String = ""
    Dim Tesoreria As String = ""
    Dim DocumentosVehiculares As String = ""

    Dim oeUsuarioPerfil As New e_UsuarioPerfil
    Dim olUsuarioPerfil As l_UsuarioPerfil
    Dim oePerfil As New e_Perfil
    Dim olPerfil As New l_Perfil
    Dim olEmpresaSistema As New l_EmpresaSistemas


#End Region

#Region "Eventos"

#Region "Ribbon ERP T&L"

    Private Sub Botonera(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles utm_ISLSGI.ToolClick
        Try

            Dim o_frmChild As frm_MenuPadre = ActiveMdiChild
            Select Case e.Tool.Key
                'Case "ActivoConsulta"
                '    o_frmChild._Activo = True
                '    o_frmChild.Consultar(o_frmChild._Activo)
                'Case "InactivoConsulta"
                '    o_frmChild._Activo = False
                '    o_frmChild.Consultar(o_frmChild._Activo)

                Case "Consultar"
                    o_frmChild._Activo = True
                    o_frmChild.Consultar(o_frmChild._Activo)
                Case "Nuevo"
                    'o_frmChild._Operacion = e.Tool.Key
                    o_frmChild.Nuevo()
                Case "Editar"
                    'o_frmChild._Operacion = e.Tool.Key
                    o_frmChild.Editar()
                Case "Guardar"
                    o_frmChild.Guardar()
                Case "Cancelar"
                    o_frmChild.Cancelar()
                Case "Eliminar"
                    o_frmChild.Eliminar()
                Case "Imprimir"
                    o_frmChild.Imprimir()
                Case "Exportar"
                    o_frmChild.Exportar()
                Case "Salir"
                    If (Not o_frmChild Is Nothing) Then
                        o_frmChild.Salir()
                    Else
                        If MessageBox.Show("¿ Desea Salir del Sistema ?", "ERP T&L", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            ControlUsuario()
                            Application.Exit()
                        End If
                    End If
                Case "SalirSGI"
                    If MessageBox.Show("¿ Desea Salir del Sistema ?", "ERP T&L", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        ControlUsuario()
                        Application.Exit()
                    End If

                Case "Cerrar Sesion"
                    ControlUsuario()
                    Application.Restart()

                Case "mnuClientePersona"
                    TipoCliente = 1
                    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)

                Case "mnuClienteEmpresa"
                    TipoCliente = 2
                    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)

                Case "mnuProveedorPersona"
                    TipoProveedor = 1
                    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)

                Case "mnuProveedorEmpresa"
                    TipoProveedor = 2
                    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)

                    'Case "mnuOCMaterial"
                    '    TipoOC = "MATERIAL"
                    '    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)

                    'Case "mnuOCServicio"
                    '    TipoOC = "SERVICIO"
                    '    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)

                Case "mnuMarca"
                    TipoMarca = "MATERIAL"
                    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)

                Case "mnuMarcaNeumatico"
                    TipoMarca = "LLANTAS"
                    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)
                Case "mnuAnticipos Clientes"
                    TipoAnticipo = "Cliente"
                    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)
                Case "mnufrm_AnticipoClienteP"
                    TipoAnticipo = "Proveedor"
                    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image)

                Case "iconusuario", "iconconectado", "sbNombreUsuario", "sbFechaUltimoIngreso", "sbPCIP", "sbUsuario", "sbFecha1", "Desde", "Tecla", "sbTipoCambio"
                    'Case "mnuAyuda"
                    '    SendKeys.Send("{F1}")
                Case Else

                    'Dim NombrePadre As String = e.Tool.SharedProps.StatusText
                    'Dim MultiInstancia As String = e.Tool.SharedProps.Category

                    InstanciaFormMdiChild(e.Tool.SharedProps.Tag, e.Tool.SharedProps.AppearancesSmall.Appearance.Image, e.Tool.SharedProps.Category,
                                          e.Tool.SharedProps.StatusText, e.Tool.SharedProps.CustomizerCaption)
            End Select
        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Explorador ERP T&L"

    Private Sub ebModuloOperaciones(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinExplorerBar.ItemEventArgs) Handles MenuISL.ItemClick

        Select Case e.Item.Key

            Case "ebiClientePersona"
                TipoCliente = 1
                InstanciaFormMdiChild(e.Item.Tag, e.Item.Settings.AppearancesSmall.Appearance.Image)

            Case "ebiClienteEmpresa"
                TipoCliente = 2
                InstanciaFormMdiChild(e.Item.Tag, e.Item.Settings.AppearancesSmall.Appearance.Image)

                'Case "ebiAyuda"
                '    SendKeys.Send("{F1}")

            Case Else

                'Dim NombrePadre As String = e.Item.Settings.AppearancesLarge.Tag
                'Dim MultiInstancia As String = e.Item.Settings.AppearancesSmall.Tag

                InstanciaFormMdiChild(e.Item.Tag, e.Item.Settings.AppearancesSmall.Appearance.Image)
        End Select

    End Sub

#End Region

    Private Sub frm_Menu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            ControlUsuario()
        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para verificar la disponibilidad de la base de datos ERP
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Private Sub VerificarDisponibilidadBD()
        'Verificación de la disponibilidad de la base para acceder al sistema
        Dim disponibilidadBD As New l_Disponibilidad
        If Not disponibilidadBD.VerificarDisponibilidadBD() Then
            MessageBox.Show(disponibilidadBD.MensajeInicial, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End
        End If
        'Verificar la disponibilidad de la réplica de la base de datos
        If Not disponibilidadBD.VerificarDisponibilidadReplica() Then
            MessageBox.Show(disponibilidadBD.MensajeInicial, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ''' <summary>
    ''' Evento inicial de carga de formulario principal de menus del ERP T&L
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.Hide()

            'Verificar la disponibilidad de acceso a la BD ERP T&L
            VerificarDisponibilidadBD()

            'Valida que la configuración del ERP T&L sea de Perú
            If Not ConfiguracionRegionalPeru() Then
                'Await MensajePC("La configuración regional debe ser de Perú")
                Application.Exit()
            End If
            LlenaCombos() '@0002
            'Autentica el usuario que va a ingresar al ERP T&L
            If AutenticarUsuario() Then

                'Mostrar la pantalla de bienvenida
                frm_Bienvenida.Show()
                frm_Bienvenida.UltraProgressBar1.Maximum = 100
                frm_Bienvenida.UltraProgressBar1.Minimum = 0
                frm_Bienvenida.Refresh()

                Dim ol_Configuracion As New l_Configuracion

                'Información para asignar la Web de Ayuda a la tecla F1
                HelpProvider1.HelpNamespace = SiteAyudaSGI()
                HelpProvider1.SetHelpString(Me, "Ayuda del Sistema de Gestión Integral")

                'Inicialización de los botones principales
                ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)

                Tiempo.Start()

                utm_ISLSGI.Tools("sbNombreUsuario").SharedProps.Caption = gUsuarioSGI.oePersona.NombreCompleto
                ' utm_ISLSGI.Tools("sbFechaUltimoIngreso").SharedProps.Caption = Date.Now
                'utm_ISLSGI.Tools("sbPCIP").SharedProps.Caption = gUsuarioSGI.ObtenerIP
                utm_ISLSGI.Tools("sbPCIP").SharedProps.Caption = gUsuarioSGI.ObtenerLoginWindows & "(" & gUsuarioSGI.ObtenerIP & ")"
                utm_ISLSGI.Tools("sbTipoCambio").SharedProps.Caption = m_Funciones.TipoCambioCompraVenta(Date.Now)

                'Muestra el fondo del escritorio principal en caso las imágenes estén activas
                If gImagen Then
                    Me.BackgroundImage = GeneraImagen("\Fondo azul con logo ERP.jpg")
                End If

                frm_Bienvenida.Label1.Text = VersionDelSistema() & " - Cargando: Barra Inferior de ERP T&L"
                frm_Bienvenida.UltraProgressBar1.Value = 5
                frm_Bienvenida.Refresh()

                CargarConfiguracion()

                Dim olMenuProceso As New l_MenuProceso
                Dim leMenu As List(Of e_MenuProceso) = olMenuProceso.ListarMenu(gUsuarioSGI.Id)
                'cambios
                CargarMenu(leMenu)

                frm_Bienvenida.Label1.Text = VersionDelSistema() & " - Cargando: Información de maestros del sistema"
                frm_Bienvenida.UltraProgressBar1.Value = 85
                frm_Bienvenida.Refresh()

                'LlenaCombos() '@0002
                CargaIGV()
                gmt_Iconos()

                frm_Bienvenida.Label1.Text = VersionDelSistema() & " - Cargando: Alerta de Onomásticos"
                frm_Bienvenida.UltraProgressBar1.Value = 90
                frm_Bienvenida.Refresh()

                frm_Bienvenida.Label1.Text = VersionDelSistema() & " - Cargando: Verificando Tiempo de Salida"
                frm_Bienvenida.UltraProgressBar1.Value = 95
                frm_Bienvenida.Refresh()

                AnalizaTiempoSalida()
                ugb_Espera.Visible = False

                frm_Bienvenida.Label1.Text = "Finalizando ..."
                frm_Bienvenida.UltraProgressBar1.Value = 100
                frm_Bienvenida.Refresh()
                frm_Bienvenida.Close()

                Me.Show()

                'Await MensajePC("Acceso autorizado a " & gUsuarioSGI.oePersona.NombreCompleto.ToString)

                Me.Text = "ERP T&L - PLANIFICACION DE RECURSOS EMPRESARIALES - " & Lugar() & " - " & VersionDelSistema()

                ' @0001 --- Inicio --------------------------------------------------------------------------------------------------

                '' MostrarOnomasticos()
                'ListaOnomasticos()


                ''Rutina para Mostrar Alerta para Orden de Compra Generadas
                ' Nombre Proceso: APROBAR ORDENES DE COMPRA
                'If gleTrabSeguridad.Count > 0 Then
                '    Dim leTrabSeg As New List(Of e_TrabajadorSeguridad)
                '    leTrabSeg = gleTrabSeguridad.Where(Function(item) item.NombreProceso = "APROBAR ORDENES DE COMPRA").ToList
                '    If leTrabSeg.Count > 0 Then MostrarOrdenCompra(leTrabSeg(0))
                'End If

                ''Rutina para mostrar alerta de los trabajadores con permiso con dias excedidos
                'If gleTrabSeguridad.Count > 0 Then
                '    Dim leTrabSeg As New List(Of e_TrabajadorSeguridad)
                '    leTrabSeg = gleTrabSeguridad.Where(Function(item) item.NombreProceso = "CONTROL PERMISOS").ToList
                '    If leTrabSeg.Count > 0 Then DiasExcedidos()
                'End If

                ''Rutina para mostrar alerta de las placas que estan debiendo 4 o mas guias
                'If PerfilAsignado(gNombrePerfilFacturacionGuias) Then
                '    Dim placa As String = ""
                '    If TractoSinDocPublic.Count > 0 Then
                '        For Each tracto As e_Combo In TractoSinDocPublic
                '            placa = placa & "La Unidad: " & tracto.Nombre & " Debe " & tracto.Id & " Guias. - "
                '        Next
                '        AlertaDocumentos.Show(CargarDatosAlerta("Mensaje Guias", placa, , "MensajeGuias", ScreenPosition.BottomLeft))
                '        'AlertaOperaciones.Show(CargarDatosAlerta("Mensaje Guias", "La Unidad: " & tracto.Nombre & " Debe " & tracto.Id & " Guias", , "MensajeGuias", ScreenPosition.BottomLeft))
                '    End If
                'End If

                ''Contratos a vencer presente mes
                'If PerfilAsignado(gNombrePerfilJefePersonal) Or PerfilAsignado(gNombrePerfilAsistenteRRHH) Then
                '    ContratosXVencer()
                'End If
                'If PerfilAsignado(gNombrePerfilDocumentosVehiculares) Or PerfilAsignado(gNombrePerfilJefeTesoreria) Or PerfilAsignado(gNombrePerfilAsistenteTesoreria) Then
                '    DocumentosXVencer()
                'End If

                ''Rutas Sin Tarifa (Campo Descripcion trae el numero de tarifas asignadas a esa ruta)
                'If PerfilAsignado(gNombrePerfilJefeOperaciones) Then
                '    Dim CantidadRutasSinTarifa As Integer = RutasPublic.Where(Function(x) x.Descripcion = 0).Count
                '    If CantidadRutasSinTarifa > 0 Then
                '        AlertaComun.Show(CargarDatosAlerta("Mensaje Rutas", "Existen " & CantidadRutasSinTarifa & " rutas sin asignar tarifa", My.Resources.Price, "MensajeRutas", ScreenPosition.BottomLeft))
                '    End If
                'End If

                ''Verificacion Tracto y Carreta
                'If PerfilAsignado(gNombrePerfilJefeOperaciones) OrElse PerfilAsignado(gNombrePerfilSupervisorOperaciones) OrElse PerfilAsignado(gNombrePerfilCoordinadorOperaciones) Then
                '    Dim Hasta As Date = ObtenerFechaServidor().AddDays(-1).Date
                '    Dim Desde As Date = Hasta.AddDays(-2).Date
                '    Dim intCantErroresTracto As Integer = fc_ErroresTrazabilidad(True, Desde, Hasta)
                '    Dim intCantErroresCarreta As Integer = fc_ErroresTrazabilidad(False, Desde, Hasta)
                '    'Tracto
                '    If intCantErroresTracto > 0 Then
                '        AlertaComun.Show(CargarDatosAlerta("Trazabilidad Tractos", Desde.ToShortDateString() & " - " & Hasta.ToShortDateString() & Environment.NewLine _
                '                                           & "Existen " & intCantErroresTracto & " errores de trazabilidad en Tractos", My.Resources.Information, "TrazabilidadTracto", ScreenPosition.BottomLeft))
                '    End If
                '    'Carreta
                '    If intCantErroresCarreta > 0 Then
                '        AlertaComun.Show(CargarDatosAlerta("Trazabilidad Carreta", Desde.ToShortDateString() & " - " & Hasta.ToShortDateString() & Environment.NewLine _
                '                                           & "Existen " & intCantErroresCarreta & " errores de trazabilidad en Carretas", My.Resources.Information, "TrazabilidadCarreta", ScreenPosition.BottomLeft))
                '    End If
                'End If

                ''Verificacion Personal que Falta confirmar su Ingreso o Salida
                'If PerfilAsignado(gNombrePerfilJefeOperaciones) Then
                '    Dim intIngresoConfirmar As Integer = fc_CantidadPersonalConfirmar(True)
                '    Dim intSalidaConfirmar As Integer = fc_CantidadPersonalConfirmar(False)
                '    'Ingreso
                '    If intIngresoConfirmar > 0 Then
                '        AlertaComun.Show(CargarDatosAlerta("Confirmar Ingreso", "Falta Confirmar el ingreso de " & intIngresoConfirmar & " Trabajadores ", My.Resources.Information, "FaltaConfirmarIngreso", ScreenPosition.BottomLeft))
                '    End If
                '    'Salida
                '    If intSalidaConfirmar > 0 Then
                '        AlertaComun.Show(CargarDatosAlerta("Confirmar Salida", "Falta Confirmar la salida de " & intSalidaConfirmar & " Trabajadores ", My.Resources.Information, "FaltaConfirmarSalida", ScreenPosition.BottomLeft))
                '    End If
                'End If

                ''Unidades Con Cuota de Produccion en Rojo
                'If PerfilAsignado(gNombrePerfilJefeOperaciones) OrElse PerfilAsignado(gNombrePerfilSupervisorOperaciones) Then
                '    Dim intUnidadCuotaRojo As Integer = fc_UnidadesCuotaRojo()
                '    If intUnidadCuotaRojo > 0 Then
                '        AlertaComun.Show(CargarDatosAlerta("Cuota de Produccion", "Existen " & intUnidadCuotaRojo & " Unidades con cuota de produccion en rojo ", My.Resources.Information, "UnidadesCuotaRojo", ScreenPosition.BottomLeft))
                '    End If
                'End If

                ''Documentos (Revision Tecnica CPSAA y Vehicular General) por Vencer
                'If PerfilAsignado(gNombrePerfilJefeOperaciones) Then
                '    Dim DocsxVencer As String = fc_DocumentosxVencer()
                '    If Not String.IsNullOrEmpty(DocsxVencer.Trim()) Then
                '        AlertaComun.Show(CargarDatosAlerta("Tipo Doc : Cantidad x Vencer", DocsxVencer, My.Resources.Information, "DocumentosxVencer", ScreenPosition.BottomLeft))
                '    End If
                'End If

                ''Documentos por Vencer General
                'If PerfilAsignado(gNombrePerfilJefeOperaciones) Or PerfilAsignado(gNombrePerfilJefeControlFlota) Then
                '    Dim DocsxVencer As Integer = fc_DocumentosVehiculoxVencer()
                '    If DocsxVencer > 0 Then
                '        AlertaComun.Show(CargarDatosAlerta("Documentos Vehículos Por Vencer", "Existen " & DocsxVencer & " Documentos Vehículos Por Vencer", My.Resources.Information, "DocumentosVehiculoxVencer", ScreenPosition.BottomLeft))
                '    End If
                'End If

                ''Viajes con Carga por las de 24 horas
                'If PerfilAsignado(gNombrePerfilJefeOperaciones) Then
                '    Dim intViajes As Integer = fc_UnidadesCarga24Horas()
                '    If intViajes > 0 Then
                '        AlertaComun.Show(CargarDatosAlerta("Viajes con Carga por mas de 24 Horas", "Existen " & intViajes & " Viajes con carga por mas de 24 Horas", My.Resources.Information, "Viajes24Horas", ScreenPosition.BottomLeft))
                '    End If
                'End If

                ''Viajes con Carga por las de 24 horas
                'If PerfilAsignado(gNombrePerfilJefeLiquidacion) Then
                '    'Asincrono
                '    mt_IniciarWebServiceCovisol()
                'End If

                ' @0001 --- Final --------------------------------------------------------------------------------------------------

            Else
                Application.Exit()
            End If

            If gUsuarioSGI.Controlado = 1 AndAlso gUsuarioSGI.oePersona.leEmail.Count = 0 Then
                Dim _frm As New frm_DatoUsuario
                _frm.Width = 600
                _frm.Height = 400
                _frm.StartPosition = FormStartPosition.CenterScreen
                _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                _frm.ShowDialog()
            End If

            AnalizaConexion()

        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub utm_ISLSGI_AfterRibbonTabSelected(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.RibbonTabEventArgs) Handles utm_ISLSGI.AfterRibbonTabSelected
        Dim TabKey As String = e.Tab.Key.Remove(0, 2)
        Try
            If MenuISL.Groups.Count > 0 And TabKey <> "Configuracion" Then
                MenuISL.Groups.Item("eb" & TabKey).Selected = True
            End If
        Catch ex As Exception
            MessageBox.Show("El menú " & TabKey & " No esta asignado en el explorador", "ERP T&L", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub eb_Menu_GroupClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinExplorerBar.GroupEventArgs) Handles MenuISL.GroupClick
        Try
            Dim GroupKey As String = e.Group.Key.Remove(0, 2)
            If GroupKey <> "Configuracion" Then
                utm_ISLSGI.Ribbon.SelectedTab = utm_ISLSGI.Ribbon.Tabs("rb" & GroupKey)
            End If
        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub Tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tiempo.Tick
        Try
            'Static Contador As Integer
            If Not Me.Visible Then
                Exit Sub
            End If
            Static ContBD As Integer

            olPerfil = New l_Perfil
            olUsuarioPerfil = New l_UsuarioPerfil

            'Rutina para Mostrar una Alerta si es que esta habilitada o deshabilitada el adaptador de red(local)
            If Not IniciaSeccion Then
                AnalizaConexion()
                IniciaSeccion = True
                'Contador = 10
                BandRestablece = True
            Else
                If Conecta AndAlso Not BandRestablece Then
                    Contador = Contador + 1
                    If Contador > 10 Then BandRestablece = True
                End If
            End If

            'Contador = Contador + 1
            'If Contador > 10 Then
            '    Contador = 0
            AnalizaConexion()
            'End If
            'Verificación de la disponibilidad de la base para acceder al sistema
            Dim disponibilidadBD As New l_Disponibilidad
            Dim mensaje As String = "El sistema se cerrará automáticamente"

            'Sentencia para cerrar la aplicación a todos los usuarios en caso necesario, 
            'debiendo desconectar el acceso compartido al directorio Fotos
            If Not disponibilidadBD.FotosDisponibles() Then
                MessageBox.Show(mensaje, "Mensaje del Administrador ERP T&L", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.Exit()
            End If

            If Conecta AndAlso BandRestablece Then
                'Rutina para Cerrar la Aplicacion luego de 10 Minutos por No estar disponible la Base de Datos ERP
                If Bandbd Then
                    ContBD = ContBD + 1
                    'If ContBD > 100 Then '@0003
                    If ContBD > 10 Then  '@0003 
                        Tiempo.Stop()
                        MessageBox.Show("El Personal de Sistemas necesita urgentemente" & Environment.NewLine &
                                        "cerrar todas las sesiones activas. El sistema se cerrará" & Environment.NewLine &
                                        "Vuelva a intentar a ingresar en aproximadamente 1 hora.", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Application.Exit()
                    End If
                End If

                If Not disponibilidadBD.VerificarDisponibilidadBD() Then
                    If Not Bandbd Then
                        Bandbd = True
                        Alerta.Appearance.BackColor = Color.Red
                        Alerta.Show(CargarDatosAlerta("Mensaje de Sistema", disponibilidadBD.MensajeUsuariosConectados & Environment.NewLine, My.Resources.reloj1.ToBitmap, "MensajeUsuariosConectados", ScreenPosition.Default))
                    End If
                Else
                    If Bandbd Then
                        Bandbd = False
                        Alerta.Appearance.BackColor = Color.Green
                        Alerta.Show(CargarDatosAlerta("Mensaje de Sistema", "El proceso de mantenimiento de la base de datos ha sido suspendido" & Environment.NewLine &
                        "Puede continuar con su sesión e ignorar todos las alertas mostradas hasta el momento", My.Resources.reloj1.ToBitmap, "BaseDatosDisponible", ScreenPosition.Default))
                    End If
                End If

                'Verificar la disponibilidad de la réplica de la base de datos
                If (Not Bandr) AndAlso Not disponibilidadBD.VerificarDisponibilidadReplica() Then
                    Bandr = True
                    Alerta.Appearance.BackColor = Color.Red
                    Alerta.Show(CargarDatosAlerta("Mensaje de Sistema", disponibilidadBD.MensajeUsuariosConectados, My.Resources.reloj1.ToBitmap, "MensajeUsuariosConectados", ScreenPosition.Default))
                    Application.Exit()
                End If

                Dim MensajeMantenimiento As String = ""
                Dim MensajeOperaciones As String = ""
                Dim MensajeSeguimiento As String = ""
                Dim MensajeGuias As String = ""
                Dim MensajeLogistica As String = ""
                Dim MensajeTesoreria As String = ""
                Dim MensajeControlFlota As String = ""

                oeUsuarioPerfil = New e_UsuarioPerfil
                oeUsuarioPerfil.TipoOperacion = "M"
                oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                oeUsuarioPerfil.Principal = 1
                Try
                    oeUsuarioPerfil = olUsuarioPerfil.Obtener(oeUsuarioPerfil)
                Catch ex As Exception
                    oeUsuarioPerfil.Activo = False
                End Try
                '''''''''''''''
                'If PerfilAsignado(gNombrePerfilFacturacionGuias) Or PerfilAsignado(gNombrePerfilAdministrador) Then
                '    If oeUsuarioPerfil.Activo Then
                '        oePerfil = New e_Perfil
                '        oePerfil.TipoOperacion = "M"
                '        oePerfil.Nombre = gNombrePerfilFacturacionGuias
                '        oePerfil = olPerfil.Obtener(oePerfil)
                '        MensajeGuias = oePerfil.Nombre
                '        If RTrim(MensajeGuias) <> "" Then
                '            If MensajeGuias <> Guias Then
                '                Guias = MensajeGuias
                '                AlertaOperaciones.Show(CargarDatosAlerta("Mensaje de Sistema", MensajeGuias, , "MensajeGuias", ScreenPosition.BottomLeft))
                '                oeUsuarioPerfil = New e_UsuarioPerfil
                '                oeUsuarioPerfil.TipoOperacion = "M"
                '                oeUsuarioPerfil.Id = "M"
                '                oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                '                olUsuarioPerfil.Guardar(oeUsuarioPerfil)
                '            End If
                '        End If
                '    End If
                'End If
                ''''''''''''''
                'If PerfilAsignado(gNombrePerfilJefeMantenimiento) Or PerfilAsignado(gNombrePerfilAdministrador) Then
                '    If oeUsuarioPerfil.Activo Then
                '        oePerfil = New e_Perfil
                '        oePerfil.TipoOperacion = "M"
                '        oePerfil.Nombre = gNombrePerfilJefeMantenimiento
                '        oePerfil = olPerfil.Obtener(oePerfil)
                '        MensajeMantenimiento = oePerfil.Nombre
                '        If RTrim(MensajeMantenimiento) <> "" Then
                '            If MensajeMantenimiento <> Mantenimiento Then
                '                Mantenimiento = MensajeMantenimiento
                '                AlertaOperaciones.Show(CargarDatosAlerta("Mensaje de Sistema", MensajeMantenimiento, , "MensajeMantenimiento", ScreenPosition.BottomLeft))
                '                oeUsuarioPerfil = New e_UsuarioPerfil
                '                oeUsuarioPerfil.TipoOperacion = "M"
                '                oeUsuarioPerfil.Id = "M"
                '                oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                '                olUsuarioPerfil.Guardar(oeUsuarioPerfil)
                '            End If
                '        End If
                '    End If
                'End If
                '''''''''''
                'If PerfilAsignado(gNombrePerfilJefeLogistica) Or PerfilAsignado(gNombrePerfilAdministrador) Or PerfilAsignado(gNombrePerfilAsistenteLogistica) Or PerfilAsignado(gNombrePerfilJefeAlmacen) Then
                '    If oeUsuarioPerfil.Activo Then
                '        oePerfil = New e_Perfil
                '        oePerfil.TipoOperacion = "M"
                '        oePerfil.Nombre = gNombrePerfilSupervidorGeneral
                '        oePerfil = olPerfil.Obtener(oePerfil)
                '        MensajeLogistica = oePerfil.Nombre
                '        If RTrim(MensajeLogistica) <> "" Then
                '            If MensajeLogistica <> Logistica Then
                '                Logistica = MensajeLogistica
                '                AlertaLogistica.Show(CargarDatosAlerta("Mensaje Para Logistica", MensajeLogistica, , "MensajeLogistica", ScreenPosition.BottomLeft))
                '                oeUsuarioPerfil = New e_UsuarioPerfil
                '                oeUsuarioPerfil.TipoOperacion = "M"
                '                oeUsuarioPerfil.Id = "M"
                '                oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                '                olUsuarioPerfil.Guardar(oeUsuarioPerfil)
                '            End If
                '        End If
                '    End If
                'End If
                '''''''''''''
                'If PerfilAsignado(gNombrePerfilAdministrador) Or PerfilAsignado(gNombrePerfilSupervidorGeneral) Or PerfilAsignado(gNombrePerfilAsistenteLogistica) Or PerfilAsignado(gNombrePerfilJefeAlmacen) Then
                '    If oeUsuarioPerfil.Activo Then
                '        oePerfil = New e_Perfil
                '        oePerfil.TipoOperacion = "M"
                '        oePerfil.Nombre = gNombrePerfilJefeLogistica
                '        oePerfil = olPerfil.Obtener(oePerfil)
                '        MensajeLogistica = oePerfil.Nombre
                '        If RTrim(MensajeLogistica) <> "" Then
                '            If MensajeLogistica <> Logistica Then
                '                Logistica = MensajeLogistica
                '                AlertaLogistica.Show(CargarDatosAlerta("Mensaje Para Logistica", MensajeLogistica, , "MensajeLogistica", ScreenPosition.BottomLeft))
                '                oeUsuarioPerfil = New e_UsuarioPerfil
                '                oeUsuarioPerfil.TipoOperacion = "M"
                '                oeUsuarioPerfil.Id = "M"
                '                oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                '                olUsuarioPerfil.Guardar(oeUsuarioPerfil)
                '            End If
                '        End If
                '    End If
                'End If
                ''''''''''''''''
                'If PerfilAsignado(gNombrePerfilSupervidorCallCenter) Or PerfilAsignado(gNombrePerfilAdministrador) Or PerfilAsignado(gNombrePerfilOperadorCallCenter) Then
                '    If oeUsuarioPerfil.Activo Then
                '        oePerfil = New e_Perfil
                '        oePerfil.TipoOperacion = "M"
                '        oePerfil.Nombre = gNombrePerfilOperadorOperaciones
                '        oePerfil = olPerfil.Obtener(oePerfil)
                '        MensajeSeguimiento = oePerfil.Nombre
                '        If RTrim(MensajeSeguimiento) <> "" Then
                '            If MensajeSeguimiento <> Seguimiento Then
                '                Seguimiento = MensajeSeguimiento
                '                AlertaOperaciones.Show(CargarDatosAlerta("Mensaje de Sistema", MensajeSeguimiento, , "MensajeSeguimiento", ScreenPosition.BottomLeft))
                '                oeUsuarioPerfil = New e_UsuarioPerfil
                '                oeUsuarioPerfil.TipoOperacion = "M"
                '                oeUsuarioPerfil.Id = "M"
                '                oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                '                olUsuarioPerfil.Guardar(oeUsuarioPerfil)
                '            End If
                '        End If
                '    End If
                'End If
                '''''''''''''''
                'If PerfilAsignado(gNombrePerfilJefeOperaciones) Or PerfilAsignado(gNombrePerfilAdministrador) Or PerfilAsignado(gNombrePerfilOperadorOperaciones) Then
                '    If oeUsuarioPerfil.Activo Then
                '        oePerfil = New e_Perfil
                '        oePerfil.TipoOperacion = "M"
                '        oePerfil.Nombre = gNombrePerfilOperadorCallCenter
                '        oePerfil = olPerfil.Obtener(oePerfil)
                '        MensajeOperaciones = oePerfil.Nombre
                '        If RTrim(MensajeOperaciones) <> "" Then
                '            If MensajeOperaciones <> Operaciones Then
                '                Operaciones = MensajeOperaciones
                '                AlertaOperaciones.Show(CargarDatosAlerta("Mensaje de Sistema", MensajeOperaciones, , "MensajeOperaciones", ScreenPosition.BottomLeft))
                '                oeUsuarioPerfil = New e_UsuarioPerfil
                '                oeUsuarioPerfil.TipoOperacion = "M"
                '                oeUsuarioPerfil.Id = "M"
                '                oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                '                olUsuarioPerfil.Guardar(oeUsuarioPerfil)
                '            End If
                '        End If
                '    End If
                'End If
                ''''''''''''''''
                'If PerfilAsignado(gNombrePerfilJefeTesoreria) Or PerfilAsignado(gNombrePerfilAdministrador) Or PerfilAsignado(gNombrePerfilGerenteAdministrativo) Then
                '    If oeUsuarioPerfil.Activo Then
                '        oePerfil = New e_Perfil
                '        oePerfil.TipoOperacion = "M"
                '        oePerfil.Nombre = gNombrePerfilCaja
                '        oePerfil = olPerfil.Obtener(oePerfil)
                '        MensajeTesoreria = oePerfil.Nombre
                '        If RTrim(MensajeTesoreria) <> "" Then
                '            If MensajeTesoreria <> Tesoreria Then
                '                Tesoreria = MensajeTesoreria
                '                AlertaTesoreria.Show(CargarDatosAlerta("Mensaje de Tesoreria", MensajeTesoreria, , "MensajeTesoreria", ScreenPosition.BottomLeft))
                '                oeUsuarioPerfil = New e_UsuarioPerfil
                '                oeUsuarioPerfil.TipoOperacion = "M"
                '                oeUsuarioPerfil.Id = "M"
                '                oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                '                olUsuarioPerfil.Guardar(oeUsuarioPerfil)
                '            End If
                '        End If
                '    End If
                'End If
                '''''''''''''''''
                'If PerfilAsignado(gNombrePerfilJefeCallCenter) Or PerfilAsignado(gNombrePerfilDocumentosVehiculares) Or PerfilAsignado(gNombrePerfilAdministrador) Then
                '    ''DOCUMENTOS VEHICULARES
                '    oeUsuarioPerfil = New e_UsuarioPerfil
                '    With oeUsuarioPerfil
                '        .TipoOperacion = "M"
                '        .oeUsuario.Id = gUsuarioSGI.Id
                '        .Principal = -1
                '        .oePerfil.Id = "1CH000000023"
                '    End With
                '    oeUsuarioPerfil = olUsuarioPerfil.Obtener(oeUsuarioPerfil)

                'If oeUsuarioPerfil.Id <> "" Then
                '    oePerfil = New e_Perfil
                '    oePerfil.TipoOperacion = "M"
                '    oePerfil.Nombre = gNombrePerfilDocumentosVehiculares
                '    oePerfil = olPerfil.Obtener(oePerfil)
                '    MensajeOperaciones = oePerfil.Nombre
                '    If RTrim(MensajeOperaciones) <> "" Then
                '        If MensajeOperaciones <> DocumentosVehiculares Then
                '            DocumentosVehiculares = MensajeOperaciones
                '            AlertaDocumentoVehicular.Show(CargarDatosAlerta("Mensaje de Sistema", MensajeOperaciones, , "MensajeOperaciones", ScreenPosition.BottomLeft))
                '            oeUsuarioPerfil = New e_UsuarioPerfil
                '            oeUsuarioPerfil.TipoOperacion = "P"
                '            oeUsuarioPerfil.Id = "M"
                '            oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                '            oeUsuarioPerfil.oePerfil.Id = "1CH000000023"
                '            olUsuarioPerfil.Guardar(oeUsuarioPerfil)
                '        End If
                '    End If
                'End If
                'End If
                ''''''''''''''''''''

            End If

        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Alerta_DesktopAlertLinkClicked(ByVal sender As Object, ByVal e As Infragistics.Win.Misc.DesktopAlertLinkClickedEventArgs) Handles Alerta.DesktopAlertLinkClicked
        Try
            Dim ope As String = e.WindowInfo.Key
            Select Case ope
                Case "Onomastico"
                    CargaFormMdiChild(frm_Onomasticos)
                    frm_Onomasticos.Listar(MonthName(Date.Now.Month), Date.Now.Day)
                Case "OrdenCompra"
                    CargaFormMdiChild(frm_AprobarOrdenesCompra)
                    frm_AprobarOrdenesCompra.Lista_Alerta()
            End Select
        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub Alerta_MouseEnterElement(ByVal sender As Object, ByVal e As Infragistics.Win.UIElementEventArgs) Handles Alerta.MouseEnterElement
        'Dim _alert As UltraDesktopAlert
        '' Dim _windowinfo As UltraDesktopAlertWindowInfo
        '_alert = sender
    End Sub

    Private Sub TiempoHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiempoHora.Tick
        Try
            If Not Me.Visible Then
                Exit Sub
            End If
            Static Num As Integer
            Num = Num + 1
            If band AndAlso Num >= HoraSalida - (oeControlTU.TiempoAlerta * 60) Then
                band = False
                Alerta.Appearance.BackColor = Color.GreenYellow
                Alerta.Show(CargarDatosAlerta("Mensaje de Sistema", "Le quedan " & oeControlTU.TiempoAlerta & " minutos para que termine su turno.", My.Resources.reloj1.ToBitmap, "TiempoRestante", ScreenPosition.Default))
            End If

            If band2 AndAlso Num >= HoraSalida AndAlso oeControlTU.CierreAutomatico Then
                Dim oeControlUsuario As New e_ControlUsuario
                Dim olControlUsuario As New l_ControlUsuario
                oeControlUsuario.Id = gIdControl
                oeControlUsuario = olControlUsuario.Obtener(oeControlUsuario)
                band2 = False
                If oeControlUsuario.Ampliacion > 0 Then
                    band3 = True
                    Num = 0
                    Ampliacion = oeControlUsuario.Ampliacion
                    Alerta.Appearance.BackColor = Color.GreenYellow
                    Alerta.Show(CargarDatosAlerta("Mensaje de Sistema", "Se amplio " & Ampliacion & " minutos para que termine su turno.", My.Resources.reloj1.ToBitmap, "AmpliaTiempo", ScreenPosition.Default))
                Else
                    'MensajeEmergente.Confirmacion("Culminó su turno, se cerrará el ERP T&L", True)
                    MessageBox.Show("Culminó su turno, se cerrará el ERP T&L", "Mensaje ERP T&L", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Application.Exit()
                End If
            End If

            If band3 AndAlso Num >= Ampliacion * 60 Then
                'MensajeEmergente.Confirmacion("Culminó su turno, se cerrará el ERP T&L", True)
                band3 = False
                MessageBox.Show("Culminó su turno, se cerrará el ERP T&L", "Mensaje ERP T&L", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.Exit()
            End If
        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub TiempoTC_Tick(sender As Object, e As EventArgs) Handles TiempoTC.Tick
        Try
            If Not Me.Visible Then
                Exit Sub
            End If
            utm_ISLSGI.Tools("sbTipoCambio").SharedProps.Caption = m_Funciones.TipoCambioCompraVenta(Date.Now)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_Menu_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub AlertaPermisos_DesktopAlertLinkClicked(ByVal sender As System.Object, ByVal e As Infragistics.Win.Misc.DesktopAlertLinkClickedEventArgs) Handles AlertaPermisos.DesktopAlertLinkClicked
        CargaFormMdiChild(frm_ControlPermisos)
        frm_ControlPermisos.Listar()
    End Sub

    Private Sub AlertaTesoreria_DesktopAlertLinkClicked(ByVal sender As System.Object, ByVal e As Infragistics.Win.Misc.DesktopAlertLinkClickedEventArgs) Handles AlertaTesoreria.DesktopAlertLinkClicked
        CargaFormMdiChild(frm_Grupo)
        frm_Grupo.GruposPreEnviados()
    End Sub

    Private Sub AlertaContratos_DesktopAlertLinkClicked(sender As Object, e As DesktopAlertLinkClickedEventArgs) Handles AlertaContratos.DesktopAlertLinkClicked
        CargaFormMdiChild(frm_Contratos)
        frm_Contratos.rbPorVencer.Checked = True
        frm_Contratos.ListarContratosXVencer()
    End Sub

    Private Sub AlertaComun_DesktopAlertLinkClicked(sender As Object, e As DesktopAlertLinkClickedEventArgs) Handles AlertaComun.DesktopAlertLinkClicked
        Try
            Select Case e.WindowInfo.Key
                Case "MensajeRutas"
                    CargaFormMdiChild(frm_Ruta)
                    frm_Ruta.Consultar(True)
                Case "TrazabilidadTracto"
                    CargaFormMdiChild(frm_Operacion)
                    With frm_Operacion
                        .tabViajesLista.SelectedTab = .utpTrazabilidad.Tab
                        .cboUsuario.Value = ""
                        .cboCentro.Value = ""
                        .cboZona.Value = ""
                        .opTractoCarreta.CheckedIndex = 0
                        .fecHasta.Value = ObtenerFechaServidor().AddDays(-1)
                        .fecDesde.Value = Convert.ToDateTime(.fecHasta.Value).AddDays(-2)
                        .Consultar(True)
                    End With
                Case "TrazabilidadCarreta"
                    CargaFormMdiChild(frm_Operacion)
                    With frm_Operacion
                        .tabViajesLista.SelectedTab = .utpTrazabilidad.Tab
                        .cboUsuario.Value = ""
                        .cboCentro.Value = ""
                        .cboZona.Value = ""
                        .opTractoCarreta.CheckedIndex = 1
                        .fecHasta.Value = ObtenerFechaServidor().AddDays(-1)
                        .fecDesde.Value = Convert.ToDateTime(.fecHasta.Value).AddDays(-2)
                        .Consultar(True)
                    End With
                Case "FaltaConfirmarIngreso"
                    CargaFormMdiChild(frm_ControlPermisos)
                    frm_ControlPermisos.Consultar(True)
                Case "FaltaConfirmarSalida"
                    CargaFormMdiChild(frm_ControlPermisos)
                    frm_ControlPermisos.Consultar(True)
                Case "UnidadesCuotaRojo"
                    CargaFormMdiChild(frm_ReporteMontoFleteTracto)
                    frm_ReporteMontoFleteTracto.CargarDatosAlerta(Date.Now.Date)
                Case "DocumentosxVencer"
                    CargaFormMdiChild(frm_DocumentosScanner)
                    frm_DocumentosScanner.CargarDocumentosVencidos(1)
                    'CargaFormMdiChild(frm_DocumentosScanner)
                    'frm_ImagenesDocumentos.cboTipoDocLista.Value = "1SI000000007" 'CPSAA
                    'Dim Condicion As New FilterCondition
                    'Condicion.CompareValue = "01/01/1901"
                    'Condicion.ComparisionOperator = FilterComparisionOperator.DoesNotContain
                    'frm_ImagenesDocumentos.griLista.DisplayLayout.Bands(0).ColumnFilters("FechaVencimiento").FilterConditions.Add(Condicion)
                    'frm_ImagenesDocumentos.griLista.DisplayLayout.Bands(0).Columns("Vencimiento").SortIndicator = SortIndicator.Ascending
                    'frm_DocumentosScanner.Consultar(True)
                Case "DocumentosVehiculoxVencer"
                    CargaFormMdiChild(frm_DocumentosScanner)
                    frm_DocumentosScanner.CargarDocumentosVencidos(2)
                Case "Viajes24Horas"
                    CargaFormMdiChild(frm_Seguimiento)
                    frm_Seguimiento.fecDesde.Value = Date.Now.AddMonths(-3).Date
                    frm_Seguimiento.fecHasta.Value = Date.Now.Date
                    frm_Seguimiento.cboCentro.Value = String.Empty
                    frm_Seguimiento.tabListado.SelectedTab = frm_Seguimiento.tapAlertaViajes.Tab
                    frm_Seguimiento.Consultar(True)
                Case "AlertaSaldoCovisol"
                    CargaFormMdiChild(frm_Covisol)
                    Dim Condicion As New FilterCondition
                    Condicion.CompareValue = "0.00"
                    Condicion.ComparisionOperator = FilterComparisionOperator.NotEquals
                    frm_Covisol.griSaldoTarjeta.DisplayLayout.Bands(0).ColumnFilters("Entrada").FilterConditions.Add(Condicion)
                    frm_Covisol.griSaldoTarjeta.DisplayLayout.Bands(0).Columns("Saldo").SortIndicator = SortIndicator.Ascending
                    frm_Covisol.Consultar(True)
            End Select
        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ControlDeVersion_Tick(sender As Object, e As EventArgs) Handles ControlDeVersion.Tick
        'Dim informacion As UpdateCheckInfo = Nothing
        'Dim actualizacion As ApplicationDeployment

        'If ApplicationDeployment.IsNetworkDeployed Then

        '    'ControlDeVersion.Enabled = False
        '    actualizacion = ApplicationDeployment.CurrentDeployment
        '    Try
        '        informacion = actualizacion.CheckForDetailedUpdate
        '    Catch dde As DeploymentDownloadException
        '        MessageBox.Show("La nueva versión de la aplicación no se puede descargar en este momento." & Environment.NewLine() & "Verifique su conexión, Error: " & dde.Message)
        '    Catch ide As InvalidDeploymentException
        '        MessageBox.Show("Problemas en la aplicación que controla las versiones diponibles, Error: " & ide.Message)
        '    Catch ioe As Exception
        '        MessageBox.Show("No se puede actualizar esta versión de la aplicación, Error " & ioe.Message)
        '    End Try

        '    If informacion.UpdateAvailable Then
        '        Try

        '            Dim Contenido As String = "Esta disponible una nueva versión del sistema. " & Environment.NewLine & "Para aplicar dichos cambios es necesario reiniciar la aplicación."
        '            Alerta.Appearance.BackColor = Amarillo
        '            Alerta.TreatCaptionAsLink = DefaultableBoolean.False
        '            Alerta.Show(CargarDatosAlerta("Actualizacion ERP T&L", Contenido, GeneraImagen("\globo.ico"), "Version", ScreenPosition.Default))
        '            Alerta.Appearance.Tag = "ControlVersion"

        '        Catch dde As DeploymentDownloadException
        '            MessageBox.Show("No se puede instalar la última versión de la aplicación" & Environment.NewLine() & "Verifique su conexión, Error: " & dde.Message)
        '        End Try
        '    End If
        'End If
        Dim oeEmpresaSistema As New e_EmpresaSistemas
        Dim VersionEst As Boolean = False
        oeEmpresaSistema = olEmpresaSistema.Obtener(oeEmpresaSistema)
        Dim VersionSis As String = ""
        VersionSis = VersionDelSistema()
        If oeEmpresaSistema.VersionSis.Trim <> VersionSis.Trim Then
            VersionEst = True
        Else
            Dim oeVersionSis As New e_Combo
            Dim olVersionSis As New l_Combo
            oeVersionSis.Id = gUsuarioSGI.Id
            oeVersionSis.Nombre = "VersionSis"
            oeVersionSis = olVersionSis.Obtener(oeVersionSis)
            If oeVersionSis.Descripcion.Trim <> oeEmpresaSistema.VersionSis.Trim Then
                VersionEst = True
            End If
        End If
        If VersionEst = True Then
            Try
                Dim Contenido As String = "Esta disponible una nueva versión del sistema. " & Environment.NewLine & "Para aplicar dichos cambios es necesario reiniciar la aplicación."
                Alerta.Appearance.BackColor = Amarillo
                Alerta.TreatCaptionAsLink = DefaultableBoolean.False
                Alerta.Show(CargarDatosAlerta("Actualizacion ERP T&L", Contenido, GeneraImagen("\globo.ico"), "Version", ScreenPosition.Default))
                Alerta.Appearance.Tag = "ControlVersion"

            Catch dde As DeploymentDownloadException
                MessageBox.Show("No se puede instalar la última versión de la aplicación" & Environment.NewLine() & "Verifique su conexión, Error: " & dde.Message)
            End Try
        End If

        'ControlDeVersion.Enabled = True
    End Sub

    Private Sub hiloWebServiceCovisol_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles hiloWebServiceCovisol.DoWork
        Try
            e.Result = LlamadaWebService()
        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub hiloWebServiceCovisol_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles hiloWebServiceCovisol.RunWorkerCompleted
        Try
            'Manejar el caso en que se produzca un error o excepción
            If (e.Error IsNot Nothing) Then
                'MsgBox(e.Error.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            Else
                If e.Cancelled Then
                    'Manejar el caso en que el usuario haya cancelado la operación. 
                    AlertaComun.Show(CargarDatosAlerta("Alerta Tarjetas Covisol", "Servicio Web Tarjetas Covisol Inactivo", My.Resources.Information, "AlertaSaldoCovisol", ScreenPosition.BottomLeft))
                Else
                    'Manejar el caso en que la operación haya finalizado con éxito
                    If e.Result IsNot Nothing AndAlso Convert.ToInt32(e.Result) <> 0 Then
                        AlertaComun.Show(CargarDatosAlerta("Alerta Tarjetas Covisol", e.Result.ToString() & " Tarjetas tienen un saldo menor o igual a S/ 500", My.Resources.Information, "AlertaSaldoCovisol", ScreenPosition.BottomLeft))
                    End If
                End If
            End If
            If mbolProcesoCancelado Then
                AlertaComun.Show(CargarDatosAlerta("Alerta Tarjetas Covisol", "Servicio Web Tarjetas Covisol Inactivo", My.Resources.Information, "AlertaSaldoCovisol", ScreenPosition.BottomLeft))
            End If
            mbolProcesoCancelado = False
        Catch ex As Exception
            MensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AlertaDocumentos_DesktopAlertLinkClicked(sender As Object, e As DesktopAlertLinkClickedEventArgs) Handles AlertaDocumentos.DesktopAlertLinkClicked
        CargaFormMdiChild(frm_Seguros2)
        frm_Seguros2.IndMenu = True
        frm_Seguros2.ListarZ(True)
    End Sub

#End Region

#Region "Rutinas"

    Private Sub CargaComboConEstilos(ByVal comboBox As Infragistics.Win.UltraWinToolbars.ComboBoxTool, ByVal fromDirectory As DirectoryInfo)
        Dim dir As New DirectoryInfo("Estilos")
        Dim styleLibraryFiles() As FileInfo = dir.GetFiles("*.isl")
        Dim styleLibraryFile As FileInfo
        For Each styleLibraryFile In styleLibraryFiles
            comboBox.ValueList.ValueListItems.Add(styleLibraryFile)
        Next
    End Sub

    ''' <summary>
    ''' Llamar formualrio Hijo
    ''' </summary>
    ''' <param name="oFrm">Formulario Hijo</param>
    ''' <remarks></remarks>
    ''' 
    Private Sub CargaFormMdiChild(ByRef oFrm As Form)
        Try
            oFrm.MdiParent = Me
            oFrm.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Método para verificar la disponibilidad de la conexión del sistema a la red ERP
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AnalizaConexion()
        Try
            'Dim olDatosConfiguracion As New l_Configuracion
            If My.Computer.Network.IsAvailable Then
                Alerta.MultipleWindowDisplayStyle = MultipleWindowDisplayStyle.Tiled
                Alerta.TreatCaptionAsLink = DefaultableBoolean.False
                Alerta.TreatTextAsLink = DefaultableBoolean.False

                Dim ipServ As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidor")
                'If My.Computer.Network.Ping(olDatosConfiguracion.IPServidor) Then
                If My.Computer.Network.Ping(ipServ) Then
                    MuestraImagenConexion(1)
                    If Not IniciaSeccion OrElse Desconecta Then
                        Alerta.Appearance.BackColor = Celeste
                        Alerta.Show(CargarDatosAlerta("ERP T&L", "Existe Conexión a Internet", GeneraImagen("\Conectado1.ico"), "Conectar"))
                        Conecta = True
                        Desconecta = False
                        Contador = 0
                    End If
                Else
                    MuestraImagenConexion(2)
                    If IniciaSeccion Then
                        Alerta.Appearance.BackColor = Indio
                        Alerta.Show(CargarDatosAlerta("ERP T&L", "Hay Conexión \ Servidor ERP T&L no encontrado", My.Resources.Sin_Ping, "Sin Servidor"))
                        Conecta = True
                        Desconecta = False
                    End If
                End If
            Else
                MuestraImagenConexion(3)
                If (Not IniciaSeccion) Or Conecta Then
                    Alerta.Appearance.BackColor = Color.IndianRed
                    Alerta.Show(CargarDatosAlerta("ERP T&L", "No Esta Conectado", My.Resources.Desconectado, "Sin Conexión"))
                    Desconecta = True
                    Conecta = False
                    BandRestablece = False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Ejecutar y mostrar un formulario determinado
    ''' </summary>
    ''' <param name="NombreForm">Nombre del formulario que se va a ejecutar</param>
    ''' <param name="MultiInstancia">Especificar si el formulario tiene instancia única o múltiple - Por defecto False</param>
    ''' <remarks></remarks>
    Private Sub InstanciaFormMdiChild(ByVal NombreForm As String, ByVal Icono As Bitmap,
                                      Optional ByVal MultiInstancia As String = "NO", Optional ByVal NombreFormularioPadre As String = "frm_MenuPadre",
                                      Optional ByVal NombreProcesoNegocio As String = "")
        Try
            ugb_Espera.Visible = True
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            Dim objNewForm As Object = Activator.CreateInstance(Type.GetType(NombreForm))
            'If MultiInstancia = "NO" Then
            Dim frm As frm_MenuPadre = DirectCast(objNewForm, frm_MenuPadre)
            frm.IndMultiInstancia = MultiInstancia
            frm = frm.getInstancia()
            If Icono IsNot Nothing Then frm.Icon = Icon.FromHandle(Icono.GetHicon)
            frm.pIdActividadNegocio = NombreFormularioPadre
            frm.pProcesoNegocio = NombreProcesoNegocio
            frm.MdiParent = Me
            frm.Show()
            'End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    ''' <summary>
    ''' Muestra Imagen en el Status Bar
    ''' </summary>
    ''' <param name="estado">1 = Conectado; 2 = Desconectado; 3 = Sin Ping</param>
    ''' <remarks></remarks>
    Public Sub MuestraImagenConexion(ByVal estado As Integer)
        With utm_ISLSGI.Tools("iconconectado").SharedProps
            Select Case estado
                Case 1
                    .AppearancesSmall.Appearance.Image = My.Resources.Conectado
                    .ToolTipText = "Existe Conexión a Internet"
                Case 2
                    .AppearancesSmall.Appearance.Image = My.Resources.Desconectado
                    .ToolTipText = "Hay Conexión \ Servidor ERP T&L no encontrado"
                Case 3
                    .AppearancesSmall.Appearance.Image = My.Resources.Sin_Ping
                    .ToolTipText = "No Esta Conectado"
            End Select
            .ToolTipTitle = "Mensaje del Sistema"
        End With
    End Sub

    Public Sub MostrarOnomasticos()
        Try
            HiloIsl = New Thread(HiloIslInicio)
            HiloIsl.IsBackground = True
            HiloIsl.Name = "HiloIsl"
            HiloIsl.Start()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub VerificaHiloIsl()
        Try
            With True
                BeginInvoke(MetodoHilo)
                Thread.Sleep(60000)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListaOnomasticos()
        Try
            Dim leTrabajador As New List(Of e_Onomastico)
            Dim olTrabajador As New l_Trabajador
            Dim mes As String = MonthName(Date.Now.Month)
            Dim dia As String = Date.Now.Day
            Dim Contenido As String = ""
            leTrabajador = olTrabajador.ListarOnomasticos(mes, dia)
            If leTrabajador.Count > 0 Then
                For Each oeOnomastico As e_Onomastico In leTrabajador
                    Contenido = Contenido & oeOnomastico.NombreCompleto & Environment.NewLine & " / "
                Next
                Alerta.Appearance.BackColor = Amarillo
                Alerta.TreatCaptionAsLink = DefaultableBoolean.False
                Alerta.Show(CargarDatosAlerta("Onomásticos del Día", Contenido, GeneraImagen("\globo.ico"), "Onomastico", ScreenPosition.Default))
                Alerta.Appearance.Tag = "Onomastico"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AnalizaTiempoSalida()
        Try
            Dim oeUsuario As New e_Usuario
            Dim olUsuario As New l_Usuario
            oeUsuario.Id = gUsuarioSGI.Id
            Dim ds As DataSet = olUsuario.ValidaSalida(oeUsuario)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                HoraSalida = ds.Tables(0).Rows(0).Item(3)
                oeControlTU = New e_ControlTurnoUsuario
                Dim olControlTU As New l_ControlTurnoUsuario
                oeControlTU.IdUsuario = gUsuarioSGI.Id
                oeControlTU = olControlTU.Obtener(oeControlTU)
                If oeControlTU IsNot Nothing Then
                    TiempoHora.Start()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Método para registrar la salida del usuario del ERP T&L
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ControlUsuario()
        Try
            Dim olControlUsuario As New l_ControlUsuario
            olControlUsuario.RegistrarSalida(gIdControl)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarOrdenCompra(ByVal oeTrabSeg As e_TrabajadorSeguridad)
        Try
            Dim oeOrdenCompra As New e_OrdenCompra
            Dim olOrdenCompra As New l_OrdenCompra
            oeOrdenCompra.TipoOperacion = "M"
            oeOrdenCompra._CantMax = oeTrabSeg.CantidadLimite
            oeOrdenCompra._CantMin = oeTrabSeg.CantidadMinima
            oeOrdenCompra = olOrdenCompra.Obtener(oeOrdenCompra)
            If oeOrdenCompra.Total > 0 Then
                If oeOrdenCompra.Total > TotalOC Then TotalOC = oeOrdenCompra.Total : BandOC = False
                If Not BandOC Then
                    BandOC = True
                    Alerta.Appearance.BackColor = Color.Orange
                    Alerta.TreatCaptionAsLink = DefaultableBoolean.False
                    Alerta.TreatTextAsLink = DefaultableBoolean.True
                    Alerta.Show(CargarDatosAlerta("Orden de Compra", "Existen " & oeOrdenCompra.Total & " Ordenes de Compra por Aprobar", GeneraImagen("\ordering.ico"), "OrdenCompra", ScreenPosition.Default))
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DiasExcedidos()
        Try
            Dim oeCtrlPermisos As New e_ControlPermisos
            Dim olCtrlPermisos As New l_ControlPermisos
            Dim loCtrlPermisos As New List(Of e_ControlPermisos)
            Dim cantidad As Integer = 0
            Dim dias1 As Integer = 0
            Dim dias2 As Integer = 0
            Dim dias3 As Integer = 0
            oeCtrlPermisos.TipoOperacion = ""
            oeCtrlPermisos.Fecha = Date.Parse("01/01/1901")
            oeCtrlPermisos.FechaSalida = Date.Parse("01/01/1901")
            loCtrlPermisos = olCtrlPermisos.Listar(oeCtrlPermisos)
            loCtrlPermisos = loCtrlPermisos.Where(Function(Item) Item.IndConfirmaIngreso = False).ToList
            For Each permiso As e_ControlPermisos In loCtrlPermisos
                If permiso.DiasExcedidos > 0 And permiso.IndConfirmaIngreso = False And permiso.IndConfirmaSalida = True Then
                    cantidad += 1
                End If
                Dim a As Integer = DateDiff(DateInterval.Day, Date.Now.Date, permiso.FechaSalida.Date)
                Dim b As Integer = DateDiff(DateInterval.Day, Date.Now.Date, permiso.FechaIngreso.Date)
                If a = 1 Then
                    dias1 += 1
                End If
                If b = 0 And permiso.IndConfirmaIngreso = False Then
                    dias2 += 1
                End If
                If b = 1 And permiso.IndConfirmaIngreso = False Then
                    dias3 += 1
                End If
            Next
            If cantidad > 0 Or dias1 > 0 Or dias2 > 0 Then
                If Not BandOC Then
                    Dim mensaje As String = " "
                    BandOC = True

                    If cantidad > 0 Then
                        mensaje = "Existen " & cantidad & " Trabajadores con Dias Excedidos. "
                    End If
                    If dias1 > 0 Then
                        mensaje = mensaje & "Mañana salen de Permiso: " & dias1 & " Trabajadores.  "
                    End If
                    If dias2 > 0 Then
                        mensaje = mensaje & "Hoy Llegan de Permiso: " & dias2 & " Trabajadores. "
                    End If
                    If dias3 > 0 Then
                        mensaje = mensaje & "Mañana Llegan de Permiso: " & dias3 & " Trabajadores. "
                    End If
                    AlertaPermisos.Appearance.BackColor = Color.Coral
                    AlertaPermisos.TreatCaptionAsLink = DefaultableBoolean.False
                    AlertaPermisos.TreatTextAsLink = DefaultableBoolean.True
                    AlertaPermisos.Show(CargarDatosAlerta("Dias Permisos", mensaje, GeneraImagen("\ordering.ico"), "ControlPermisos", ScreenPosition.BottomLeft))
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ContratosXVencer()
        Try
            Dim oeContratos As New e_Contratos
            Dim olContratos As New l_Contratos
            Dim loContratos As New List(Of e_Contratos)
            Dim cantidad As Integer = 0
            oeContratos.TipoOperacion = "2"
            oeContratos.FechaDesde = ObtenerFechaServidor()
            loContratos = olContratos.Listar(oeContratos)
            If loContratos.Count > 0 Then
                For Each contrato As e_Contratos In loContratos
                    cantidad += 1
                Next
                Dim mensaje As String = " "
                BandOC = True
                mensaje = "Este Mes Vencen: " & cantidad & " Contratos."
                AlertaContratos.Appearance.BackColor = Color.Coral
                AlertaContratos.TreatCaptionAsLink = DefaultableBoolean.False
                AlertaContratos.TreatTextAsLink = DefaultableBoolean.True
                AlertaContratos.Show(CargarDatosAlerta("Contratos a Vencer", mensaje, GeneraImagen("\ordering.ico"), "Contratos", ScreenPosition.BottomRight))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DocumentosXVencer()
        Try
            Dim oeDocumentoVehicular As New e_DocumentoVehicular
            Dim olDocumentoVehicular As New l_DocumentoVehicular
            oeDocumentoVehicular.TipoOperacion = "M"
            Dim ds As DataSet = olDocumentoVehicular.ListarDts(oeDocumentoVehicular)

            'For i = 0 To ds.Tables(0).Rows.Count - 1
            '    AlertaDocumentos.Show(CargarDatosAlerta(ds.Tables(0).Rows(i)("Titulo").ToString, ds.Tables(0).Rows(i)("TipoDocumento").ToString + ": Existen " +
            '                                            ds.Tables(0).Rows(i)("Unidades").ToString + " unidad(es) por vencer en los próximos " + ds.Tables(0).Rows(i)("Dias").ToString + " días." _
            '                                            , , , ScreenPosition.BottomLeft))
            'Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Funciones"

    ' 0:Tracto , 1: Carreta
    Private Function fc_ErroresTrazabilidad(lbTracto As Boolean, Desde As Date, Hasta As Date) As Integer
        Try
            Dim cont As Integer = 0
            Dim codDestino As String = ""
            Dim codigoTractoC As String = ""
            Dim listaNueva As New List(Of e_Viaje)
            Dim i As Integer = 0
            Dim olOperacion As New l_Operacion
            Dim oeViaje As New e_Viaje
            With oeViaje
                .TipoOperacion = "Z"
                .ViajeVacio = 2
                .FechaDesde = Desde.ToString()
                .FechaHasta = Hasta.ToString()
                Dim lista As New List(Of e_Viaje)
                If lbTracto Then
                    .Turno = 0
                    lista = olOperacion.ListarViaje(oeViaje).OrderBy(Function(item) item.Fecha).OrderBy(Function(item) item.IdTracto).ToList
                Else
                    .Turno = 1
                    lista = olOperacion.ListarViaje(oeViaje).OrderBy(Function(item) item.CargaMaterial).OrderBy(Function(item) item.Fecha).OrderBy(Function(item) item.IdCarreta).ToList
                End If
                For Each obj As e_Viaje In lista
                    If codigoTractoC = "" Or codigoTractoC <> IIf(lbTracto, obj.IdTracto, obj.IdCarreta) Then
                        codDestino = ""
                    End If
                    If codDestino = obj.IdOrigen Or codDestino = "" Then
                        codDestino = obj.IdDestino
                    Else
                        codDestino = obj.IdDestino
                        If listaNueva.Count > 0 Then
                            If listaNueva.Item(IIf(listaNueva.Count = 0, 0, listaNueva.Count - 1)).Id <> lista.Item(i - 1).Id Then
                                cont += 1
                                lista.Item(i - 1).IndFecha = cont
                                listaNueva.Add(lista.Item(i - 1))
                            End If
                        Else
                            cont += 1
                            lista.Item(i - 1).IndFecha = cont
                            listaNueva.Add(lista.Item(i - 1))
                        End If
                        obj.IndFecha = cont
                        listaNueva.Add(obj)
                    End If
                    codigoTractoC = IIf(lbTracto, obj.IdTracto, obj.IdCarreta)
                    i += 1
                Next
            End With
            Return cont
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Retorna la cantidad de trabajadores que faltan confirmar su ingreso o salida
    ''' </summary>
    ''' <param name="lbIngreso">Indica si es Confirmar Ingreso (True) o Salida(False)</param>
    ''' <returns>Retorna la cantidad de trabajadores que faltan confirmar su ingreso o salida</returns>
    ''' <remarks></remarks>
    Private Function fc_CantidadPersonalConfirmar(lbIngreso As Boolean) As Integer
        Try
            Dim olControlPermiso As New l_ControlPermisos
            If lbIngreso Then
                Return olControlPermiso.Listar(New e_ControlPermisos With {.TipoOperacion = "Y"}).Count
            Else
                Return olControlPermiso.Listar(New e_ControlPermisos With {.TipoOperacion = "Z"}).Count
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Retorna la cantidad de unidades que estan con cuota de produccion en rojo segun dia actual
    ''' </summary>
    ''' <returns>Retorna la cantidad de unidades que estan con cuota de produccion en rojo</returns>
    ''' <remarks></remarks>
    Private Function fc_UnidadesCuotaRojo() As Integer
        Try
            Dim olFlota As New l_Flota
            Return olFlota.Listar(New e_Flota With {.TipoOperacion = "Z"}).Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Retorna tipo documento : cantidad de dias para vencimiento de documento
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fc_DocumentosxVencer() As String
        Try
            Dim Resultado As String = String.Empty
            Dim olImagenesDoc As New l_ImagenesDocumentos
            Dim loImagenesDoc As New List(Of e_ImagenesDocumentos)
            loImagenesDoc.AddRange(olImagenesDoc.Listar(New e_ImagenesDocumentos With {.TipoOperacion = "Z"}))
            If loImagenesDoc.Count > 0 Then
                Dim tipoCPSA As Integer = 0
                Dim tipoGeneral As Integer = 0
                For Each x As e_ImagenesDocumentos In loImagenesDoc
                    If x.IdTipoDocumento = "1SI000000007" Then tipoCPSA += 1
                    If x.IdTipoDocumento = "1CH000000050" Then tipoGeneral += 1
                Next
                If tipoCPSA > 0 Then Resultado &= "REVISION TECNICA CPSAA : " & tipoCPSA & " Docs  // "
                If tipoGeneral > 0 Then Resultado &= "REVISION TECNICA VEHICULAR - GENERAL : " & tipoGeneral & " Docs  // "
            End If
            Return Resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Retorna tipo documento : cantidad de dias para vencimiento de documento
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fc_DocumentosVehiculoxVencer() As Integer
        Try
            Dim olImagenesDoc As New l_ImagenesDocumentos
            Dim loImagenesDoc As New List(Of e_ImagenesDocumentos)
            loImagenesDoc = olImagenesDoc.Listar(New e_ImagenesDocumentos With {.TipoOperacion = "V"})
            Return loImagenesDoc.Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_UnidadesCarga24Horas() As Integer
        Try
            Dim olOperacion As New l_Operacion
            Dim oeViaje As New e_Viaje
            With oeViaje
                .ViajeVacio = 2
                .FechaDesde = Date.Now.AddMonths(-3).Date
                .FechaHasta = Date.Now.Date
                .TipoOperacion = "W"
                '.Centro = cboCentro.Value
                .IndMotriz = 1
                .IdTracto = String.Empty
            End With
            Return olOperacion.ListarViaje(oeViaje).Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function LlamadaWebService() As Integer
        Try
            'Llamar a Webservice
            Dim olCovisol As New CovisolR.GetDatosService
            olCovisol.Timeout = 120000 '2Minutos
            'Recupero Saldo de Tarjes Web Service
            Dim loSaldo = olCovisol.getListSaldoTarjetas(mstrUsuCovisol, mstrPassCovisol, String.Empty)
            System.Net.ServicePointManager.Expect100Continue = False
            mintTarjetasPocoSaldo = 0
            Dim dblSaldo As Decimal = 0D
            For Each Saldo In loSaldo
                dblSaldo = Saldo.entrada - Saldo.salida
                If Saldo.entrada <> 0 AndAlso dblSaldo <= 500 Then
                    mintTarjetasPocoSaldo += 1
                End If
            Next
            Return mintTarjetasPocoSaldo
        Catch ex As System.Net.WebException
            mbolProcesoCancelado = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Metodos"

    Private Sub mt_IniciarWebServiceCovisol()
        Try
            'Iniciamos el proceso asíncrono en segundo plano
            hiloWebServiceCovisol.RunWorkerAsync()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

#End Region

End Class