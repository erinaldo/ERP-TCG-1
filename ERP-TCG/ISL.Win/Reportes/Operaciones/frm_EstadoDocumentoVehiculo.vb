'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win

Public Class frm_EstadoDocumentoVehiculo
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_EstadoDocumentoVehiculo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_EstadoDocumentoVehiculo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"



#End Region

#Region "Botonera"



#End Region

#Region "Eventos"

    Private Sub frm_EstadoDocumentoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializaLogicas()
            mt_CargarCombos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_InicializaLogicas()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCombos()
        Try
            ' Cargar Flota
            LlenarCombo(cboFlota, "Nombre", FlotaPublic.Where(Function(Item) Item.Id <> "1CH013" And Item.Id <> "1CH017" _
                                                                             And Item.Id <> "1CH012" And Item.Id <> "1CH014" And Item.Id <> "1CH004").ToList, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region


End Class