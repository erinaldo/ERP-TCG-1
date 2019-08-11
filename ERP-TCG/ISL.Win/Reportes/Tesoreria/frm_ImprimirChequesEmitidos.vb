Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ImprimirChequesEmitidos
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ImprimirChequesEmitidos = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ImprimirChequesEmitidos()
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
            Dim olDatos As New l_ChequeEmitido
            Dim oeDatos As New e_ChequeEmitido
            oeDatos.TipoOperacion = "1"
            oeDatos.Id = Id
            oeDatos.Fecha = Date.Parse("01/01/1901")
            oeDatos.FechaCreacion = Date.Parse("01/01/1901")
            Dim lista As List(Of e_ChequeEmitido) = olDatos.Listar(oeDatos)
            If lista.Count = 0 Then Throw New Exception("No se ha encontrado ningún dato")
            CargarReporteLocalObjeto(lista, "Cheque Emitido", "ISL_EntidadesWCF_e_ChequeEmitido", "Reportes\ChequesPendientes.rdlc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ImprimirChequesEmitidos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class