Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ImprimirLiquidacion
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ImprimirLiquidacion = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ImprimirLiquidacion()
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
            Dim olDatos As New l_LiquidacionTrabajador
            Dim oeDatos As New e_LiquidacionTrabajador
            oeDatos.TipoOperacion = ""
            oeDatos.Id = Id
            Dim lista As List(Of e_LiquidacionTrabajador) = olDatos.Listar(oeDatos)
            If lista.Count = 0 Then Throw New Exception("No se ha encontrado ningún dato")
            If lista(0).TotalPagar > 0 Then lista(0).TotalPagarTexto = Conversiones.NumerosALetras.Ejecutar(lista(0).TotalPagar, True, True, "NUEVOS SOLES")
            Dim oeTiempoLaborado As New e_CalculaTiempoServicio
            Dim olTiempoLaborado As New l_CalculaTiempoServicio
            With oeTiempoLaborado
                .TipoOperacion = "1"
                .FechaInicio = lista(0).FechaIngreso
                .FechaCese = lista(0).FechaCese
                .FechaInicioCTS = lista(0).FechaInicioCTS
                .FechaInicioDT = lista(0).FechaInicioDT
                .FechaInicioGT = lista(0).FechaInicioGT
                .FechaInicioVT = lista(0).FechaInicioVT
            End With
            oeTiempoLaborado = olTiempoLaborado.Obtener(oeTiempoLaborado)
            lista(0).FechaCompletaCTS = oeTiempoLaborado.CTSTiempoTotal
            lista(0).FechaCompletaVT = oeTiempoLaborado.VTTiempoTotal
            lista(0).FechaCompletaGT = oeTiempoLaborado.GTTiempoTotal
            lista(0).FechaCompletaDT = oeTiempoLaborado.DTTiempoTotal
            CargarReporteLocalObjeto(lista, "Liquidacion Trabajador", "ISL_EntidadesWCF_e_LiquidacionTrabajador", "Reportes\LiquidacionTrabajador.rdlc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ImprimirLiquidacion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class