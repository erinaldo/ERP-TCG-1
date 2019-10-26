'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteRecorrido
    Inherits frm_MenuPadre


#Region "clase"
    Class CustomMergedCellEvaluator
        Implements Infragistics.Win.UltraWinGrid.IMergedCellEvaluator

        Function ShouldCellsBeMerged(ByVal row1 As UltraGridRow, ByVal row2 As UltraGridRow, ByVal column As UltraGridColumn) As Boolean Implements IMergedCellEvaluator.ShouldCellsBeMerged
            Dim CodigoOperacion1 As String = DirectCast(row1.GetCellValue("CodigoOperacion"), String)
            Dim CodigoOperacion2 As String = DirectCast(row2.GetCellValue("CodigoOperacion"), String)
            Return CodigoOperacion1 = CodigoOperacion2
        End Function
    End Class
#End Region

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteRecorrido = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReporteRecorrido()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de Variables"

    Dim OeVehiculo As New e_Vehiculo
    Dim OlVehiculo As New l_Vehiculo
    Dim lstVehiculo As New List(Of e_Vehiculo)
    Dim oeReporteRecorrido As New e_ReporteRecorrido
    Dim olReporteRecorrido As New l_ReporteRecorrido
    Dim lstReporteRecorrido As New List(Of e_ReporteRecorrido)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If Gri_Recorridos.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        'oeDocumentoVehicular = New e_DocumentoVehicular
        'oeDocumentoVehicular.TipoOperacion = "I"
        'oeDocumentoVehicular.UsuarioCreacion = gUsuarioSGI.Id
        'Inicializar()
        'MostrarTabs(1, tcSeguro, 1)
        'cmbTipoCertf.Focus()
        'Operacion = "Nuevo"
        'MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        'Try
        '    Operacion = "Editar"
        '    oeDocumentoVehicular = New e_DocumentoVehicular
        '    If grid_SegurosZ.ActiveRow.Band.Index = 0 Then
        '        EditarSeguro()
        '        MostrarTabs(1, tcSeguro, 1)
        '        cmbTipoCertf.Focus()
        '        Operacion = "Editar"
        '        MyBase.Editar()
        '    Else
        '        Throw New Exception("Seleccione un Registro válido")
        '    End If

        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try
    End Sub

    Public Overrides Sub Guardar()
        'Try
        '    If GuardarSeguro() Then
        '        MyBase.Guardar()
        '    Else
        '        MostrarTabs(1, tcSeguro, 1)
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try
    End Sub

    Public Overrides Sub Cancelar()
        'Try
        '    MostrarTabs(0, tcSeguro, 2)
        '    _ingresando_datos = False
        '    Consultar(True)
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try
    End Sub

    Public Overrides Sub Eliminar()
        'Try
        '    With grid_SegurosZ
        '        If grid_SegurosZ.ActiveRow.Band.Index = 0 Then

        '            If MessageBox.Show("Esta seguro de eliminar el seguro N°: " & _
        '            .ActiveRow.Cells("Numero").Value.ToString.Trim & "?", _
        '            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '                oeDocumentoVehicular.TipoOperacion = "E"
        '                oeDocumentoVehicular.Id = .ActiveRow.Cells("IdDocumento").Value
        '                olDocumentoVehicular.Eliminar(oeDocumentoVehicular)
        '                Consultar(True)
        '            End If
        '        Else
        '            Throw New Exception("Seleccione un seguro para poder eliminarlo")
        '        End If
        '    End With
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If Gri_Recorridos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(Gri_Recorridos)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteRecorrido_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub frm_ReporteRecorrido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub frm_ReporteConsumoConductor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub griVehiculo_T_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griVehiculo_T.CellChange
        griVehiculo_T.UpdateData()
    End Sub

    Private Sub griVehiculo_C_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griVehiculo_C.CellChange
        griVehiculo_C.UpdateData()
    End Sub

    Private Sub Gri_Recorridos_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Gri_Recorridos.InitializeLayout

        e.Layout.Bands(0).Columns("CodigoOperacion").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("EstadoOperacion").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("FechaOperacion").MergedCellStyle = MergedCellStyle.Always

        For Each col As UltraGridColumn In Gri_Recorridos.DisplayLayout.Bands(0).Columns
            If col.Key <> "CodigoOperacion" Then e.Layout.Bands(0).Columns(col.Key).MergedCellEvaluator = New CustomMergedCellEvaluator()
        Next

    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        Try
            rfDesde.Value = Date.Now.AddMonths(-1)
            rfHasta.Value = Date.Now
            LlenarComboVehiculo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenarComboVehiculo()
        Try
            OeVehiculo = New e_Vehiculo
            OeVehiculo.TipoOperacion = "A"
            OeVehiculo.Motriz = -1
            OeVehiculo.Activo = True
            lstVehiculo = OlVehiculo.Listar(OeVehiculo)
            griVehiculo_T.DataSource = lstVehiculo.Where(Function(item) item.Motriz = 1).ToList
            griVehiculo_C.DataSource = lstVehiculo.Where(Function(item) item.Motriz <> 1).ToList
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeReporteRecorrido = New e_ReporteRecorrido
            oeReporteRecorrido.FechaDesde = rfDesde.Value
            oeReporteRecorrido.FechaHasta = rfHasta.Value
            oeReporteRecorrido.TipoOperacion = "A"
            If ConjuntoTabs.Tabs(0).Active Then 'Tracto
                oeReporteRecorrido.Motriz = 1
                oeReporteRecorrido.IdCarretas = ""
                oeReporteRecorrido.IdTractos = ObtenerTractos()
            ElseIf ConjuntoTabs.Tabs(1).Active Then 'Carretaq
                oeReporteRecorrido.Motriz = 0
                oeReporteRecorrido.IdCarretas = ObtenerCarretas()
                oeReporteRecorrido.IdTractos = ""
            End If

            lstReporteRecorrido = olReporteRecorrido.Listar(oeReporteRecorrido)
            If lstReporteRecorrido.Count > 0 Then
                Dim primerelemento As Boolean = True
                Dim vehiculotracto As String = lstReporteRecorrido(0).Tracto
                Dim vehiculocarreta As String = lstReporteRecorrido(0).Carreta
                Dim KmDestinoAnteriorT As Double = lstReporteRecorrido(0).KmTractoOrigen
                Dim KmDestinoAnteriorC As Double = lstReporteRecorrido(0).KmCarretaOrigen
                Dim fila1 As Boolean = True

                If ConjuntoTabs.Tabs(0).Active Then
                    For Each rr In lstReporteRecorrido
                        If rr.Tracto = vehiculotracto Then
                            If fila1 = True Then
                                rr.KmMuerto = 0
                                fila1 = False
                            Else
                                rr.KmMuerto = Math.Round(rr.KmTractoOrigen - KmDestinoAnteriorT, 3)
                            End If
                        Else
                            rr.KmMuerto = 0
                        End If
                        vehiculotracto = rr.Tracto
                        KmDestinoAnteriorT = rr.KmTractoDestino
                        rr.KmDiferencia = Math.Round(rr.KmTractoDestino - rr.KmTractoOrigen, 3)
                        rr.KmReal = Math.Round(rr.KmDiferencia - rr.KmMuerto, 3)
                    Next
                Else
                    For Each rr In lstReporteRecorrido
                        If rr.Carreta = vehiculocarreta Then
                            If fila1 = True Then
                                rr.KmMuerto = 0
                                fila1 = False
                            Else
                                rr.KmMuerto = Math.Round(rr.KmCarretaOrigen - KmDestinoAnteriorC, 3)
                            End If
                        Else
                            rr.KmMuerto = 0
                        End If
                        vehiculocarreta = rr.Carreta
                        KmDestinoAnteriorC = rr.KmCarretaDestino
                        rr.KmDiferencia = Math.Round(rr.KmCarretaDestino - rr.KmCarretaOrigen, 3)
                        rr.KmReal = Math.Round(rr.KmDiferencia - rr.KmMuerto, 3)
                    Next
                End If
            End If

            If ConjuntoTabs.Tabs(0).Active Then
                Gri_Recorridos.DisplayLayout.Bands(0).Columns("Tracto").CellAppearance.BackColor = Color.Beige
                Gri_Recorridos.DisplayLayout.Bands(0).Columns("Carreta").CellAppearance.BackColor = Color.White
            Else
                Gri_Recorridos.DisplayLayout.Bands(0).Columns("Tracto").CellAppearance.BackColor = Color.White
                Gri_Recorridos.DisplayLayout.Bands(0).Columns("Carreta").CellAppearance.BackColor = Color.Beige
            End If
            Gri_Recorridos.DisplayLayout.Bands(0).Columns("KmReal").CellAppearance.BackColor = Color.LightBlue
            Gri_Recorridos.DisplayLayout.Bands(0).Columns("KmIdeal").CellAppearance.BackColor = Color.LightBlue

            Gri_Recorridos.DataSource = lstReporteRecorrido
            Gri_Recorridos.DataBind()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerTractos()
        Try
            Dim CadenaIdTractos As String = ""

            For Each obj As e_Vehiculo In lstVehiculo.Where(Function(item) item.Motriz = 1 And item.Seleccion = True).ToList
                If CadenaIdTractos = "" Then
                    CadenaIdTractos = "'" + obj.Id.ToString + "'"
                Else
                    CadenaIdTractos = CadenaIdTractos + ",'" + obj.Id.ToString + "'"
                End If
            Next
            Return CadenaIdTractos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ObtenerCarretas()
        Try
            Dim CadenaIdCarretas As String = ""

            For Each obj As e_Vehiculo In lstVehiculo.Where(Function(item) item.Motriz = 0 And item.Seleccion = True).ToList
                If CadenaIdCarretas = "" Then
                    CadenaIdCarretas = "'" + obj.Id.ToString + "'"
                Else
                    CadenaIdCarretas = CadenaIdCarretas + ",'" + obj.Id.ToString + "'"
                End If
            Next
            Return CadenaIdCarretas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class