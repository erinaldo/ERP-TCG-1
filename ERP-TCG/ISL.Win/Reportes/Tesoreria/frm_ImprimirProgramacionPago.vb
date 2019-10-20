'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Public Class frm_ImprimirProgramacionPago
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"
    Public IdProgramacion As String = ""
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ImprimirProgramacionPago = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ImprimirProgramacionPago()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarDatos(ByVal Id As String)
        Try
            Me.Width = 800
            Me.Height = 720
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Dim olDatos As New I_DetalleProgramacionPago
            Dim oeDatos As New e_DetalleProgramacionPago
            oeDatos.TipoOperacion = "R"
            oeDatos.Id = Id
            Dim lista As DataTable = olDatos.Listar(oeDatos)
            If lista.Rows.Count = 0 Then Throw New Exception("No se ha encontrado ningún dato")
            CargarReporteLocalObjeto(lista, "", "dsProgramacionPago", "Reportes\ReporteProgramacionPago.rdlc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ImprimirGrupoAprobacion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class
