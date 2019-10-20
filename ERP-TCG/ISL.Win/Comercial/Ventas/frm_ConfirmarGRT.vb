'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
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

Public Class frm_ConfirmarGRT
    Public mensajeEmergente As New c_Alertas
#Region "Declaración de variables"
    Dim oeLugar As New e_Lugar
    Dim olLugar As New l_Lugar
    Dim ListaLugar As New List(Of e_Lugar)

    Dim oeTipoVehiculo As New e_TipoVehiculo
    Dim olTipoVehiculo As New l_TipoVehiculo

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    Dim ListaMoneda As New List(Of e_Moneda)

    Dim oeCliente As New e_Cliente
    Dim olCliente As New l_Cliente
    Dim ListaCliente As New List(Of e_Cliente)
    Dim ListaComisionista As New List(Of e_Cliente)
    Dim ListaRemitenteLista As New List(Of e_Cliente)
    Dim ListaDestinatario As New List(Of e_Cliente)
    Dim ListaRemitente As New List(Of e_Cliente)

    Dim oeTipoCarga As New e_TipoCarga
    Dim olTipoCarga As New l_TipoCarga
    Dim ListaTipoCarga As New List(Of e_TipoCarga)

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim ListaMaterial As New List(Of e_Material)

    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta

    Dim oeSeguimiento As New e_Seguimiento
    Dim olSeguimiento As New l_Seguimiento

    Dim oeGuiaTransportista As New e_GuiaTransportista
    Dim olGuiaTransportista As New l_GuiaTransportista

    Dim GuiaTransportistaLista As New List(Of e_GuiaTransportista)


    Dim oeGuiaRemitente As New e_GuiaRemitente
    Dim olGuiaRemitente As New l_GuiaRemitente

    Dim oeGuiaTransportistaInterrumpida As New e_GuiaTransportistaInterrumpida
    Dim olGuiaTransportistaInterrumpida As New l_GuiaTransportistaInterrumpida

    Dim olDireccionEmpresa As New l_Direccion_EmpresaPersona
    Dim oeDireccionEmpresa As New e_Direccion_EmpresaPersona
    Dim ListaDireccionEmpresa As New List(Of e_Direccion_EmpresaPersona)
    Dim ListaPuntoPartida As New List(Of e_Direccion_EmpresaPersona)
    Dim ListaPuntoLlegada As New List(Of e_Direccion_EmpresaPersona)


    Dim oeViaje As New e_Viaje
    Dim oeOperacionDetalle As New e_OperacionDetalle

    Dim olIgv As New l_Impuesto
    Dim oeIgv As New e_Impuesto

    Dim olOperacion As New l_Operacion
    Dim oeOperacion As New e_Operacion

    Dim olTiempoCiclo As New l_TiempoCiclo
    Dim oeTiempoCiclo As New e_TiempoCiclo

    Dim olVehiculo As New l_Vehiculo
    Dim oeVehiculo As New e_Vehiculo

    Dim olMotivoTrasladoInterrumpido As New l_MotivoDocumento
    Dim oeMotivoTrasladoInterrumpido As New e_MotivoDocumento
    Dim ListaMotivoDocumento As New List(Of e_MotivoDocumento)

    Dim oeFechas As New e_Fechas

    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean

    Dim GRT As String

    Dim oeDemandaDetalle As New e_DemandaDetalle

    Dim SalidaOrigenIndicador As Boolean = False

    Dim SalidaDestinoIndicador As Boolean = False

    Dim oeUsuarioPerfil As New e_UsuarioPerfil
    Dim olUsuarioPerfil As New l_UsuarioPerfil

    Dim oePerfil As New e_Perfil
    Dim olPerfil As New l_Perfil

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim ListaCentro As New List(Of e_Centro)

    Dim Prefijo As New l_Configuracion

    Dim ctrNuevo As Boolean = False, ctrEditar As Boolean = False, SOrigen As String, SDestino As String

    Dim oeRegConsumoCombustible As New e_RegistroConsumoCombustible, olRegConsumoCombustible As New l_RegistroConsumoCombustible
    Dim lstRegConsumoCombustible As New List(Of e_RegistroConsumoCombustible)

    Dim IdPuntoPartida As String = ""
    Dim IdPuntoLlegada As String = ""

    Dim IdRemitente As String = ""
    Dim IdDestinatario As String = ""

    Dim Nombre As String = ""

    Dim Tipo As Integer = 0

    'Tipo 0 = Guia Transportista Normal
    'Tipo 1 = Agregar Varias Guias Transportistas a Viaje

#End Region

    Public Function ObtenerViaje(ByVal IdViaje As String) As Boolean
        Try
            verConfirmado.Checked = False
            verDocumentos.Checked = False
            verDoctsPerdido.Checked = False
            oeViaje = New e_Viaje
            oeViaje.Id = IdViaje
            oeViaje.TipoOperacion = "G"
            oeViaje = olOperacion.ObtenerViaje(oeViaje)
            txtIdViaje.Text = IdViaje
            txtIdSeguimiento.Text = oeViaje.Id
            txtIdOperacion.Text = oeViaje.IdOperacion
            txtCodigoOperacion.Text = oeViaje.Operacion
            txtCodigoViaje.Text = oeViaje.Codigo
            txtViajeTracto.Text = oeViaje.Tracto
            txtViajeCarreta.Text = oeViaje.Carreta
            fecViaje.Value = oeViaje.Fecha
            txtViajeOrigen.Text = oeViaje.Origen
            txtViajeDestino.Text = oeViaje.Destino
            txtViajePiloto.Text = oeViaje.Piloto
            txtViajeCopiloto.Text = oeViaje.Copiloto
            txtViajeEscala.Text = oeViaje.Escala
            verFacturado.Checked = oeViaje.ViajeVacio
            verConfirmado.Checked = oeViaje.IndFecha
            verDocumentos.Checked = oeViaje.DiaNoche
            verDoctsPerdido.Checked = oeViaje.IndEscala
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Function

    Private Sub verConfirmado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verConfirmado.CheckedChanged
        If verConfirmado.Checked Then
            verDocumentos.Enabled = True
            verDoctsPerdido.Enabled = True
        Else
            verDocumentos.Enabled = False
            verDocumentos.Checked = False
            verDoctsPerdido.Enabled = False
            verDoctsPerdido.Checked = False
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            oeViaje = New e_Viaje
            oeViaje.TipoOperacion = "G"
            oeViaje.Id = txtIdSeguimiento.Text.Trim
            oeViaje.IdOperacion = txtIdOperacion.Text.Trim
            oeViaje.IndFacturado = verFacturado.Checked
            oeViaje.IndGrtConfirmada = verConfirmado.Checked
            oeViaje.IndDocumentos = verDocumentos.Checked
            oeViaje.IndGrtPerdido = verDoctsPerdido.Checked
            oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
            olOperacion.GuardarViaje(oeViaje)
            IndGrtConfirmada = verConfirmado.Checked
            IndDocumentos = verDocumentos.Checked
            IndGrtPerdido = verDoctsPerdido.Checked
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            Me.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub verDocumentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verDocumentos.CheckedChanged
        If verDocumentos.Checked Then
            verDoctsPerdido.Enabled = False
            verDoctsPerdido.Checked = False
        Else
            verDoctsPerdido.Enabled = True
            verDoctsPerdido.Checked = False
        End If
    End Sub

    Private Sub frm_ConfirmarGRT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class