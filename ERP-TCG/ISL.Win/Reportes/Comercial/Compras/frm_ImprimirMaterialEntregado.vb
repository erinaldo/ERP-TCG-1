Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ImprimirMaterialEntregado
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ImprimirMaterialEntregado = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ImprimirMaterialEntregado()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarDatos(ByVal Id As String, ByVal Tipo As String)
        Try
            Dim olDatos As New l_ControlEntregaMaterial
            Dim oeDatos As New e_ControlEntregaMaterial
            oeDatos.TipoOperacion = ""
            If Tipo = "I" Then
                oeDatos.TipoOperacion = "2"
                oeDatos.IdOrdenMaterialIngreso = Id
            ElseIf Tipo = "E" Then
                oeDatos.TipoOperacion = ""
                oeDatos.IdOrdenMaterialSalida = Id
            Else
                oeDatos.TipoOperacion = "1"
                oeDatos.Id = Id
            End If

            Dim lista As List(Of e_ControlEntregaMaterial) = olDatos.Listar(oeDatos)
            If lista.Count = 0 Then Throw New Exception("No se ha encontrado ningún dato")
            CargarReporteLocalObjeto(lista, "Material Entregado", "ISL_EntidadesWCF_e_ControlEntregaMaterial", "Reportes\MaterialEntregado.rdlc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ImprimirMaterialEntregado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class