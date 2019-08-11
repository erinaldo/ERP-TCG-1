Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ReporteVoucherMovimientoCaja
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteVoucherMovimientoCaja = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteVoucherMovimientoCaja()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarDatos(ByVal TipoOperacion As String, ByVal IdMovimiento As String)
        Try
            Dim olDatos As New l_MovimientoCaja
            Dim oeDatos As New e_MovimientoCaja
            If String.IsNullOrEmpty(IdMovimiento) Then IdMovimiento = "1SI000000001"
            oeDatos.TipoOperacion = TipoOperacion
            oeDatos.IdMovimiento = IdMovimiento
            Dim lista As List(Of e_MovimientoCaja) = olDatos.Listar(oeDatos)
            Dim prefijo As New l_Configuracion
            'If prefijo.PrefijoID().Substring(1, 2) = "LI" Then lista(0).Mov = "LI"
            'If prefijo.PrefijoID().Substring(1, 2) = "PY" Then lista(0).Mov = "PY"
            'If prefijo.PrefijoID().Substring(1, 2) = "SA" Then lista(0).Mov = "SA"
            If lista.Count = 0 Then Throw New Exception("No se ha encontrado ningún dato")
            If lista(0).Egreso > 0 Then lista(0).EgresoTexto = Conversiones.NumerosALetras.Ejecutar(lista(0).Egreso, True, True, "NUEVOS SOLES")
            CargarReporteLocal(lista, "Vale de Movimiento de Caja", "Movimientos_Caja", "Reportes\ValeCaja.rdlc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#Region "Cerrar el formulario"

    Private Sub frm_ReporteVoucherMovimientoCaja_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class