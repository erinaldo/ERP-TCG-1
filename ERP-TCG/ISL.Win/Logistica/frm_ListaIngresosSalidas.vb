Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.UltraChart.Shared.Styles

Public Class frm_ListaIngresosSalidas

#Region "Inicialización del formulario"

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_ListaIngresosSalidas
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Definicion de Variables"

    Private Shared Instancia As frm_ListaIngresosSalidas = Nothing
    Private Shared Operacion As String

    Dim oeCentro As New e_Centro
    Dim oeAlmacen As New e_Almacen
    Dim olCentro As New l_Centro
    Dim olAlmacen As New l_Almacen
    Dim oeTipo As New e_TipoMovimientoInventario
    Dim olTipo As New l_TipoMovimientoInventario

    Dim oeRegistroInv As New e_RegistroInventario
    Dim olRegistroInv As New l_RegistroInventario

    Dim valida As String = ""
    Dim dsRegistroInv As New DataSet

#End Region

#Region "Metodos"

    Private Sub Iniciar()
        ComboTipo()
        ComboCentro()
        chk_Rango.Checked = True
        MesesInicio.Inicializar()
        MesesFin.Inicializar()
        UE_Grafico.Visible = False
        Mostrar_Botones()
    End Sub

    Private Sub ComboCentro()
        oeCentro.TipoOperacion = ""
        oeCentro.Activo = True
        LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), 0)
    End Sub

    Private Sub ComboAlmacen(ByVal idCentro As String)
        Try
            LimpiaCombos(cboAlmacen)
            oeAlmacen.TipoOperacion = ""
            oeAlmacen.Activo = True
            oeAlmacen.IdCentro = idCentro
            LlenarComboMaestro(cboAlmacen, olAlmacen.Listar(oeAlmacen), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboTipo()
        Try
            oeTipo.TipoOperacion = ""
            oeTipo.Activo = True
            LlenarComboMaestro(cboTipo, olTipo.Listar(oeTipo), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Mostrar_Botones()
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub LimpiarListas()
        griIS.DataSource = odIS
    End Sub

    Public Sub Valida_Rango()
        If chk_Rango.Checked Then
            If MesesInicio.Id <= MesesFin.Id Then
                valida = "1"
            Else
                valida = "3"
            End If
        Else
            valida = "2"
        End If
    End Sub

    Public Sub Listar()
        Try
            Me.Cursor = Cursors.WaitCursor
            UE_Grafico.Expanded = False
            UE_Grafico.Visible = False
            oeRegistroInv = New e_RegistroInventario
            oeRegistroInv.TipoOperacion = ""
            oeRegistroInv.IdTipoMovimiento = cboTipo.Value
            oeRegistroInv.IdAlmacen = cboAlmacen.Value
            oeRegistroInv.Anio = Anio.Año
            Valida_Rango()
            If valida = "1" Then
                oeRegistroInv.MesInicio = MesesInicio.Id
                oeRegistroInv.MesFin = MesesFin.Id
            ElseIf valida = "2" Then
                oeRegistroInv.MesInicio = "1"
                oeRegistroInv.MesFin = "12"
            ElseIf valida = "3" Then
                mensajeEmergente.Problema("Verifique Rango de Meses !!!")
            End If

            If (valida = "1" Or valida = "2") Then
                dsRegistroInv = New DataSet
                dsRegistroInv = olRegistroInv.ListarIngresosSalidas(oeRegistroInv)
                ''''''''''''''''''''''''''''''''''''''''''''''
                'Tabla(0) Registro Inventario
                'Tabla(1) Detalle RI
                ''''''''''''''''''''''''''''''''''''''''''''''
                Dim Id As DataColumn = dsRegistroInv.Tables(0).Columns("Id")
                Dim IdMaterial As DataColumn = dsRegistroInv.Tables(1).Columns("IdMaterial")
                Dim relation As DataRelation = New DataRelation("FK_Relacion_RI", Id, IdMaterial, True)
                dsRegistroInv.Relations.Add(relation)
                dsRegistroInv.AcceptChanges()
                With griIS
                    .DataSource = dsRegistroInv
                    .Text = "Lista de " & cboTipo.Text
                    .DisplayLayout.Bands(0).Columns("ValorUnitario").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    Dim x As Integer = dsRegistroInv.Tables(0).Columns.Count - 7
                    For i As Integer = 1 To x
                        .DisplayLayout.Bands(0).Columns(6 + i).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    Next
                    'Ordenes
                    .DisplayLayout.Bands(1).ColHeadersVisible = False
                    .DisplayLayout.Bands(1).Columns("IdMaterial").Hidden = True
                    'Materiales
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Codigo").Width = 130
                    .DisplayLayout.Bands(0).Columns("Material").Width = 350
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Graficar()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dtGrafico As New DataTable

            dtGrafico.Columns.Add("Meses", System.Type.GetType("System.String"))
            dtGrafico.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"))


            For i As Integer = 7 To griIS.DisplayLayout.Bands(0).Columns.Count - 2
                If griIS.ActiveRow.Cells(i).Value <> 0 Then
                    dtGrafico.Rows.Add(griIS.DisplayLayout.Bands(0).Columns(i).Header.Caption, griIS.ActiveRow.Cells(i).Value)
                End If
            Next
            graDatos.ChartType = ChartType.PieChart3D

            graDatos.Transform3D.XRotation = 50
            graDatos.Transform3D.YRotation = 50
            graDatos.Transform3D.ZRotation = 0
            graDatos.Transform3D.Scale = 100
            'legenda
            graDatos.Legend.Visible = True
            graDatos.Legend.Location = LegendLocation.Right
            graDatos.Legend.Font = New Font("Tahoma", 8, FontStyle.Regular)
            'title
            graDatos.TitleTop.Text = griIS.ActiveRow.Cells("Material").Value
            graDatos.TitleTop.Font = New Font("Tahoma", 8, FontStyle.Bold)

            graDatos.Data.DataSource = dtGrafico
            graDatos.Data.DataBind()
            UE_Grafico.Expanded = True
            UE_Grafico.Visible = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ListaIngresosSalidas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Mostrar_Botones()
    End Sub

    Private Sub frm_ListaIngresosSalidas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_ListaIngresosSalidas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ListaIngresosSalidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        Iniciar()
    End Sub

    Private Sub cboCentro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentro.ValueChanged
        ComboAlmacen(cboCentro.Value)
    End Sub

    Private Sub griIS_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griIS.DoubleClick
        If griIS.Selected.Rows.Count > 0 AndAlso (String.IsNullOrEmpty(griIS.ActiveRow.Cells(4).Value.ToString) And Not String.IsNullOrEmpty(griIS.ActiveRow.Cells(1).Value.ToString)) Then
            Graficar()
        End If
    End Sub

    Private Sub griIS_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griIS.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub mcDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcDetalle.Opening
        mcDetalle.Items("GraficoToolStripMenuItem").Visible = IIf(griIS.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub GraficoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraficoToolStripMenuItem.Click
        If String.IsNullOrEmpty(griIS.ActiveRow.Cells(4).Value.ToString) And Not String.IsNullOrEmpty(griIS.ActiveRow.Cells(1).Value.ToString) Then
            Graficar()
        End If
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
            Mostrar_Botones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Mostrar_Botones()
            MostrarTabs(0, ficIngresosSalidas, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try

            If griIS.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griIS)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class