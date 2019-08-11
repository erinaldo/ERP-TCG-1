Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_RechazarOrdenCompra
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion del Formulario"
    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_RechazarOrdenCompra()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private oeRechOrden As New e_HistorialRechazoOC
    Private olRechOrden As New l_HistorialRechazoOC
    Private Shared instancia As frm_RechazarOrdenCompra = Nothing

#End Region

    Public Sub Listar(ByVal IdOrdenCompra As String, ByVal NroOrden As String)
        Try
            Me.lblNroOrden.Text = NroOrden
            oeRechOrden.IdOrdenCompra = IdOrdenCompra
            griHistorialRechazo.DataSource = olRechOrden.Listar(oeRechOrden)
            oeRechOrden.NroOrden = NroOrden
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        If txtObservaciones.Text = "" Then
            mensajeEmergente.Problema("Ingrese Glosa/Descripcion Por Favor")
        Else
            Dim oeOrdenCompra As New e_OrdenCompra
            Dim olOrdenCompra As New l_OrdenCompra
            oeOrdenCompra.Id = oeRechOrden.IdOrdenCompra
            oeOrdenCompra.TipoOperacion = "2"
            oeRechOrden.Fecha = Me.fecRechazo.Value
            oeRechOrden.Glosa = Me.txtObservaciones.Text
            oeRechOrden.TipoOperacion = "I"
            oeRechOrden.UsuarioCreacion = gUsuarioSGI.Id
            Dim Mensaje As String = ""
            If olRechOrden.Guardar(oeRechOrden) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                Mensaje = oeRechOrden.Glosa
                Dim oeUsuarioPerfil As New e_UsuarioPerfil
                Dim olUsuarioPerfil As New l_UsuarioPerfil
                oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                oeUsuarioPerfil.Principal = 1
                oeUsuarioPerfil = olUsuarioPerfil.Obtener(oeUsuarioPerfil)
                Dim oePerfil As New e_Perfil
                Dim olPerfil As New l_Perfil
                oePerfil.TipoOperacion = "M"
                oePerfil.Id = oeUsuarioPerfil.oePerfil.Id
                oePerfil.Codigo = Mensaje
                oePerfil.Nombre = "Rechazo de Orden: " & oeRechOrden.NroOrden & ", Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Motivo: " & Mensaje
                olPerfil.Guardar(oePerfil)
                olOrdenCompra.Guardar1(oeOrdenCompra)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Boton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton1.Click
        Me.Close()
    End Sub
End Class