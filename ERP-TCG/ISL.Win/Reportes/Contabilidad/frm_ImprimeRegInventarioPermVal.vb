Public Class frm_ImprimeRegInventarioPermVal

    Private Sub frm_ImprimeRegInventarioPermVal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos(Data, Ejercicio, Mes, Almacen)
    End Sub

#Region "Inicializar formulario"
    Dim Data As Object
    Dim Ejercicio As Integer
    Dim Mes As Integer
    Dim Almacen As String
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Sub New(ByVal obj_data As Object, ByVal li_ejercicio As Integer, ByVal li_mes As Integer, ByVal ls_Almacen As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Data = obj_data
        Ejercicio = li_ejercicio
        Mes = li_mes
        Almacen = ls_Almacen
    End Sub

    Private Shared instancia As frm_ImprimeRegInventarioPermVal = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ImprimeRegInventarioPermVal()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarDatos(ByVal obj_data As Object, ByVal li_ejercicio As Integer, ByVal li_mes As Integer, ls_Almacena As String)
        Try
            If obj_data Is Nothing Then Throw New Exception("No se ha encontrado ningún dato")
            Dim myParams(2) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", li_ejercicio, True)
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", li_mes, True)
            myParams(2) = New Microsoft.Reporting.WinForms.ReportParameter("Almacen", ls_Almacena, True)
            CargarReporteLocal(obj_data, "Registro de Inventario Permanente Valorizado", "dtRegInvPermVal", "Reportes\Contabilidad\ImprimeRegInventarioPermVal.rdlc", myParams)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteAlmacen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
        ControlBoton(1, 0, 0, 0, 1, 0, 1, 0, 1)
    End Sub

#End Region
End Class
