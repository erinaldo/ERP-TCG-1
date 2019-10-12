'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Public Class frm_UltimaUbicacionUnidades

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_UltimaUbicacionUnidades = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_UltimaUbicacionUnidades()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Private Sub frm_ImprimirResumenDiarioDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarDatos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarDatos()
        Try
            Me.Text = "Ultima Ubicacion de Unidades"
            CargarReporteRemoto("/Reportes/", "OPE - Ultima Ubicacion Unidades")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#Region "Cerrar Formulario"

    Private Sub frm_ImprimirResumenDiarioDespacho_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class