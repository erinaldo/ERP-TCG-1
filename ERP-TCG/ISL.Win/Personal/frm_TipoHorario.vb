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
Imports Infragistics.Win.UltraWinGrid

Public Class frm_TipoHorario
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"
    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TipoHorario()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private oeTipoHorario As New e_TipoHorario
    Private olTipoHorario As New l_TipoHorario
    Private Shared instancia As frm_TipoHorario = Nothing

#End Region

    Private Sub Boton1_Click(sender As System.Object, e As System.EventArgs) Handles Boton1.Click
        Me.Close()
    End Sub

    Private Sub btnAprobar_Click(sender As System.Object, e As System.EventArgs) Handles btnAprobar.Click
        Try
            If AgregarTipo(txtObservaciones.Text) Then
                mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente")
            End If
            Me.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Agregar el tipo de horario del trabajador
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AgregarTipo(observaciones As String) As Boolean
        Try
            Dim tipoAgregado As Boolean = False
            oeTipoHorario = New e_TipoHorario
            oeTipoHorario.Nombre = observaciones
            oeTipoHorario.UsuarioCreacion = gUsuarioSGI.Id
            oeTipoHorario.FechaCreacion = ObtenerFechaServidor()
            oeTipoHorario.TipoOperacion = "I"
            oeTipoHorario.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTipoHorario.Guardar(oeTipoHorario) Then
                tipoAgregado = True
            End If
            Return tipoAgregado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class