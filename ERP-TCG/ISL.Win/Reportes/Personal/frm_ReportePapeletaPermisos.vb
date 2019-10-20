'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ReportePapeletaPermisos

    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ReportePapeletaPermisos = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReportePapeletaPermisos()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarDatos(ByVal Id As String, ByVal Operacion As String)
        Try
            Dim olDatos As New l_ControlPermisos
            Dim oeDatos As New e_ControlPermisos
            oeDatos.TipoOperacion = Operacion
            oeDatos.Id = Id
            oeDatos.Fecha = Date.Parse("01/01/1901")
            oeDatos.FechaSalida = Date.Parse("01/01/1901")
            Dim lista As List(Of e_ControlPermisos) = olDatos.Listar(oeDatos)
            If lista.Count = 0 Then Throw New Exception("No se ha encontrado ningún dato")
            CargarReporteLocalObjeto(lista, "Papeleta de Salida", "e_ControlPermisos", "Reportes\PapeletaPermiso.rdlc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_Permisos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region


End Class