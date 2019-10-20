'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ReporteBanco
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteBanco = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteBanco()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Try
            Dim olDatos As New l_Banco
            Dim oeDatos As New e_Banco
            oeDatos.Activo = True
            'Dim lista As List(Of e_Banco) = olDatos.Listar(oeDatos)
            If Not cache.Contiene("Bancos") OrElse cache.ForzarActualizacion Then cache.Agregar("Bancos", olDatos.Listar(oeDatos))
            Dim lista As List(Of e_Banco) = DirectCast(cache.Obtener("Bancos"), List(Of e_Banco))
            If lista.Count < 0 Then Throw New Exception("No se ha encontrado ningún dato")
            CargarReporteLocal(lista, "Relación de Bancos", "Tabla_Datos", "Reportes\Reporte.rdlc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteBanco_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region


    Private Sub frm_ReporteBanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class