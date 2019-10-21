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
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_FiltroViajes
    Inherits frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    ''' <summary>
    ''' Instancia unica de Formulario: frm_DemandaRapida
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre

        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_FiltroViajes()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim oeDemanda As e_Demanda
    Dim olDemanda As l_Demanda

    Dim oeDemandaDetalle As e_DemandaDetalle

    Dim oeRuta As e_Ruta
    Dim oeRutaDemanda As e_Ruta
    Dim olRuta As l_Ruta

    Dim olCombo As l_Combo
    Dim oeCombo As e_Combo

    Dim olTrabajador As l_Trabajador

    Dim oeLugar As e_Lugar
    Dim olLugar As l_Lugar

    Dim ListaEscala As List(Of e_Combo)

    Dim oeVehiculo As e_Vehiculo

    Dim olVehiculo As l_Vehiculo

    Dim oeViaje As e_Viaje
    Dim oeOperacionDetalle As e_OperacionDetalle

    Dim oeOperacion As e_Operacion
    Dim olOperacion As l_Operacion

    Dim oeUsuario As e_Usuario

    Dim oeFlete As e_Flete
    Dim olFlete As l_Flete

    Dim oeTarifa As e_TarifasCliente
    Dim olTarifa As l_TarifasCliente

    Dim ListaViajeControl As List(Of e_Viaje)
    Dim ListaViaje As List(Of e_Viaje)


    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean

    Dim OrdenEscala As Integer = 0
    Dim OrigenEscala As String
    Dim OrigenAgrega As String
    Dim OperacionEscala As Integer = 1
    Dim FechaViaje As Date

    Dim oeUsuarioPerfil As e_UsuarioPerfil
    Dim olUsuarioPerfil As l_UsuarioPerfil

    Dim oePerfil As e_Perfil
    Dim olPerfil As l_Perfil

    Dim oeRegistroEditado As e_RegistrosEditados
    Dim olRegistroEditado As l_RegistrosEditados

    Dim oeDistanciaZona As e_DistanciaZona
    Dim olDistanciaZona As l_DistanciaZona

    Dim olPrefijo As l_Configuracion

    Dim RutaOperacion As String = ""
    Dim RutaIdOrigen As String = ""
    Dim RutaIdDestino As String = ""
    Dim RutaOrigen As String = ""
    Dim RutaDestino As String = ""

    Dim Tipo As String = "E"

    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""
    Dim IndCopiloto As Boolean = False

    Dim oeBonificacion As e_Bonificacion
    Dim olBonificacion As l_Bonificacion
    Dim ListaBonificacion As List(Of e_Bonificacion)

    Dim TextoMensaje As String = ""

    Dim HoraNoche As Date = "23:00:00 PM"

    Dim ViajeTanqueado As String = ""
    Dim TractoTanqueado As String = ""
    Dim Tanqueo As String = ""
    Dim EstadoViaje As String = "1CH00017"
    Dim TractoViaje As String = ""
    Dim CarretaViaje As String = ""

    Dim FlotaTracto As String = ""
    Dim FlotaOperacion As String = ""
    Dim CargaVacia As Integer = 1

    Dim IdDestinoViaje As String = ""

    Private _acl As String = "", _estado As String = ""

    Dim olViajeTercero As l_ViajesTerceros
    Dim oeContratoTercero As e_ViajesTerceros
    Dim oeIgv As e_Impuesto

    Dim PrefijoId As String = ""

    Dim FechaServidor As Date = Now.Date

    Dim ValorIgv As Double = 0

    Dim olFuncionesGenerales As l_FuncionesGenerales

    Dim ListTercero As List(Of e_Combo)

    Dim ProcesoNegocio As String = "OPERACION"

    Dim IndPropiedadTracto As Integer = -1

    Dim IndPropiedadCarreta As Integer = -1
    Dim IndPropiedadTractoTemp As Integer = 1
    Dim IndPropiedadCarretaTemp As Integer = 1

    Public codigoCliente As String = ""
    Dim olCliente As New l_Cliente
    Dim oeCliente As New e_Cliente
    Dim codigoComisionista As String = ""
    Public Shared codigoNuevoComisionista As String = ""
    Public Shared codigoNuevoCLiente As String = ""
    Public codigoTercero As String = ""
    Dim olIgv As New l_Impuesto
    Dim listaPagoEfectivo As List(Of e_Combo)

    'bitacora
    Dim columnas As New List(Of String)
    Dim rowGeneral(14, 1) As Integer
    Dim glosasGeneral(14, 2) As String
    Dim idDetalleGeneral As String
    Dim count As Integer

    Dim ListaBitacora As New List(Of e_Bitacora)
    Dim GlosaDetalleDemanda As String = ""
    Dim ValoresAnterioresDetalleDemanda As String = ""
    Dim ValoresActualesDetalleDemanda As String = ""
    Dim objEliminarTercero As e_Bitacora
    Dim objEliminarDetalle As e_Bitacora

    Dim cadenaDemandas As String = ""
    Dim cadenaDevuelta As Array
    Public Shared motivoCancelacion As String = ""
    Public Shared IdConceptoCancEliminacion As String = ""

    Private codigoDemanda As String = ""
    Private TipoVehiculo As String = ""
    Private IdEscala As String = ""

    Private Shared instancia As frm_FiltroViajes = Nothing
    Private Shared Operacion As String
    Private Estado As String
    Private EliminarViajeSinMje As String = ""

    Private NombrePropTracto As String = ""
    Private bandTractoFicticio As String = ""
#End Region

#Region "Métodos"

    Public Sub LlenaCombos()
        Dim ListaUsuario As New List(Of e_Usuario)
        oeUsuario = New e_Usuario
        oeUsuario.Id = gUsuarioSGI.Id
        oeUsuario.Login = gUsuarioSGI.Login
        ListaUsuario.Add(oeUsuario)
        oeUsuario = New e_Usuario
        oeUsuario.Id = ""
        oeUsuario.Login = "TODOS"
        ListaUsuario.Add(oeUsuario)

        LlenarComboMaestro(cboZona, ZonaPublic, 0)

        LlenarCombo(cboTractoLista, "Nombre", TractoPublic, -1)
        LlenarComboMaestro(cboPilotoLista, PilotoPublic, -1)
    End Sub

    Public Sub ListarFiltro()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olOperacion = New l_Operacion
            olVehiculo = New l_Vehiculo
            LimpiaGrid(griDisponibleVehiculo, ogdDisponibleVehiculos)
            oeViaje = New e_Viaje
            With oeViaje
                .TipoOperacion = "VIAJEFILTER"
                .ViajeVacio = 2
                .IndMotriz = 1
                .FechaDesde = fecDesde.Value.ToString
                .FechaHasta = fecHasta.Value.ToString
                .IdTracto = cboTractoLista.Value
                .Zona = cboZona.Value
                'se cambio de cboRutaOrigen a cboOrigen
                '.IdDestino = cboOrigen.Value
            End With
            griDisponibleVehiculo.DataSource = olOperacion.ListarViaje(oeViaje)
            For I As Integer = 0 To griDisponibleVehiculo.Rows.Count - 1
                With griDisponibleVehiculo.Rows(I)
                    Select Case .Cells("TipoVehiculo").Value
                        Case "PARIHUELERO"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorParihueleroD.Color
                        Case "PLATAFORMA"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorPlataformaD.Color
                        Case "FURGON"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorFurgonD.Color
                        Case "GRANELERO"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorGraneleroD.Color
                        Case "FURGON LARGO"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorFurgonLargoD.Color
                        Case "CONTENEDOR"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorContenedorD.Color
                        Case "CAMION 20 M3"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamion20M3D.Color
                        Case "CAMION 40 M3"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamion40M3D.Color
                        Case "VOLQUETE"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorVolqueteD.Color
                        Case "CALICERA"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCaliceraD.Color
                        Case "TOLVA DE VOLTEO"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorTolvaVolteoD.Color
                        Case "MEDIA BARANDA"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorMediaBarandaD.Color
                        Case "CAMIONETA"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamionetaD.Color
                        Case "CAMION 30 M3"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamion30M3D.Color
                        Case "CAMION 65 M3"
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3D.Color
                    End Select

                    If .Cells("DisponibleP").Value = False Then
                        .Appearance.BackColor = Me.ColorAdvertencia.Color
                        .Cells("Piloto").Appearance.BackColor = Me.ColorPiloto.Color
                    End If

                    If .Cells("DisponibleC").Value = False Then
                        .Appearance.BackColor = Me.ColorAdvertencia.Color
                        .Cells("CoPiloto").Appearance.BackColor = Me.ColorCopiloto.Color
                    End If

                    'If .Cells("DisponibleA").Value = False Then
                    '    .Appearance.BackColor = Me.ColorAdvertencia.Color
                    '    .Cells("Ayudante").Appearance.BackColor = Me.ColorAyudante.Color
                    'End If

                    If Not olVehiculo.ValidarTractoMantenimiento(.Cells("IdTracto").Value) Then
                        .Appearance.BackColor = Me.ColorAdvertencia.Color
                        .Cells("Tracto").Appearance.BackColor = Me.ColorTracto.Color
                    End If

                    If .Cells("IdCarreta").Value.ToString.Trim <> "" Then
                        If Not olVehiculo.ValidarCarretaMantenimiento(.Cells("IdCarreta").Value) Then
                            .Appearance.BackColor = Me.ColorAdvertencia.Color
                            .Cells("Carreta").Appearance.BackColor = Me.ColorCarreta.Color
                        End If
                    End If
                End With
            Next
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub frm_FiltroViajes_Load(sender As Object, e As EventArgs) Handles Me.Load
        LlenaCombos()
    End Sub

    Private Sub btnConsultarDisponibles_Click(sender As Object, e As EventArgs) Handles btnConsultarDisponibles.Click
        'ListarDisponibilidad(cboVehiculoDisponible.Value)
        ListarFiltro()
    End Sub

    Private Sub UltraLabel29_Click(sender As Object, e As EventArgs)

    End Sub
#End Region
End Class
