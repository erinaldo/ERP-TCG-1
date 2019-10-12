'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_VentaMerma
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_VentaMerma = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_VentaMerma()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Metodos"

    Public Sub CargarDatos(ByVal Id As String)
        Try
            Dim oeSalida As New e_ControlMerma
            Dim olSalida As New l_ControlMerma
            oeSalida.TipoOperacion = "1"
            oeSalida.IdMovimientoMermas = Id
            Dim lista As List(Of e_ControlMerma) = olSalida.Listar(oeSalida)
            If lista.Count = 0 Then Throw New Exception("No se ha encontrado ningún dato")
            CargarReporteLocalObjeto(lista, "", "ISL_EntidadesWCF_e_ControlMerma", "Reportes\Comercial\Ventas\SalidaMerma.rdlc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region
    
#Region "Cerrar el formulario"

    Private Sub frm_VentaMerma_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class