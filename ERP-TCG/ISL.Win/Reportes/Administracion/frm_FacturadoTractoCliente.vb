Public Class frm_FacturadoTractoCliente
    Inherits frm_ReporteBasico

    Private Shared instancia As frm_FacturadoTractoCliente = Nothing
    Private Shared Operacion As String

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    'Private Shared instancia As frm_FacturadoTractoCliente = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_FacturadoTractoCliente()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_FacturadoTractoCliente
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_FacturadoTractoCliente
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
            Me.Text = "Facturacion: Tracto Cliente"
            CargarReporteRemoto("/Reportes/", "OPE - FlotaTractoClienteFacturado")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_FacturadoTractoCliente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub
#End Region

    Private Sub frm_FacturadoTractoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class