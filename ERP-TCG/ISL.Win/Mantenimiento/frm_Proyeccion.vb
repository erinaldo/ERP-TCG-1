Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Shared
Imports System.Drawing.Graphics
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class frm_Proyeccion

#Region "Inicializacion de Formulario"
    Private Shared instancia As frm_Proyeccion = Nothing
    Private Shared Operacion As String
    Dim _ingresando_datos As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Proyeccion()
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region

#Region "Definicion de Variables"
    Dim oeMarca As New e_Marca, olMarca As New l_Marca
    Dim lstMarcas As New List(Of e_Marca)
    Dim oeOT As New e_OrdenTrabajo, olOrdenTrabajo As New l_OrdenTrabajo
    Dim oeModelo As New e_Modelo, olModelo As New l_Modelo
    Dim oeMantenimiento As New e_Mantenimiento, olMantenimiento As New l_Mantenimiento
    Dim dsOTAnteriores As New DataSet

    Dim oeViaje As New e_Viaje, olOperacion As New l_Operacion
    Dim lstViaje As New List(Of e_Viaje)
    Dim oeEquipo As New e_Equipo, olEquipo As New l_Equipo
    Dim oeVehiculo As New e_Vehiculo, olVehiculo As New l_Vehiculo
#End Region

#Region "Eventos"

    Private Sub frm_Proyeccion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1)
    End Sub

    Private Sub frm_Proyeccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbKM.Checked = True
        ControlBoton(1)
    End Sub

    Private Sub cmbMarca_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarca.ValueChanged
        Try
            If cmbMarca.SelectedIndex <> -1 Then
                oeModelo = New e_Modelo
                oeModelo.IdMarca = cmbMarca.Value
                oeModelo.Activo = True
                oeModelo.TipoOperacion = ""
                LlenarComboMaestro(cmbModelo, olModelo.Listar(oeModelo), -1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_Proyeccion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Proyeccion_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub grid_Proyeccion_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_Proyeccion.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub rbKM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbKM.CheckedChanged
        Try
            If rbKM.Checked Then
                LlenaComboMarca("K")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub rbHrs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHrs.CheckedChanged
        Try
            If rbHrs.Checked Then
                LlenaComboMarca("H")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub rbDias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDias.CheckedChanged
        Try
            If rbDias.Checked Then
                LlenaComboMarca("D")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_Proyeccion_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Proyeccion.DoubleClickRow
        Try
            With grid_Proyeccion
                If .Rows.Count > 0 Then
                    If .ActiveRow.Cells("IdEquipo").Value <> Nothing Then
                        Dim IdEquipo As String = .ActiveRow.Cells("IdEquipo").Value
                        ConsultarMantenimientosAnteriores(IdEquipo)
                        gbeOTsAnteriores.Expanded = True
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub mcDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcDetalle.Opening
        Try
            mnuProyeccion.Items("ExportarToolStripMenuItem").Visible = IIf(grid_Proyeccion.Rows.Count > 0, True, False)
            mcDetalle.Items(0).Visible = False : mcDetalle.Items(1).Visible = False
            With grid_Proyeccion
                Dim NumMantProy As Integer = .ActiveRow.Cells("MantProy").Value
                If .ActiveCell.Column.Index > 0 Then
                    Dim ColumnaCeldaAct As Integer = .ActiveCell.Column.Index
                    If NumMantProy = ColumnaCeldaAct - 8 Then
                        mcDetalle.Items(0).Visible = True
                    ElseIf .ActiveCell.Column.Key = "MantProy" Then
                        mcDetalle.Items(1).Visible = True
                    End If
                End If
            End With
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Try
            ProgramarOT()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarToolStripMenuItem.Click
        Exportar_Excel(grid_Proyeccion)
    End Sub

#End Region

#Region "Metodos"

    Public Sub LlenaComboMarca(ByVal ls_TipoOperacion As String)
        Try
            oeMarca = New e_Marca
            oeMarca.Activo = True
            oeMarca.TipoOperacion = ls_TipoOperacion
            LlenarComboMaestro(cmbMarca, olMarca.Listar(oeMarca), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarProyeccion()
        Try
            Cursor.Current = Cursors.WaitCursor
            If Me.cmbMarca.SelectedIndex > -1 Then
                If Me.cmbModelo.SelectedIndex > -1 Then
                    Dim ds As New DataSet
                    Dim _tipoProy As String = ""
                    If rbKM.Checked Then
                        _tipoProy = "K"
                    ElseIf rbHrs.Checked Then
                        _tipoProy = "H"
                    Else
                        _tipoProy = "D"
                    End If

                    ds = olMantenimiento.ListarProyeccionMantenimiento(cmbMarca.Value, cmbModelo.Value, _tipoProy)
                    With grid_Proyeccion
                        If ds.Tables.Count > 0 Then
                            .DataSource = ds
                            .DisplayLayout.UseFixedHeaders = True
                            Select Case _tipoProy
                                Case "K"
                                    .DisplayLayout.Bands(0).Columns("Odometro").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                                    .DisplayLayout.Bands(0).Columns("UltimaActDisp").Header.Caption = "Ultima Act. Odo."
                                    .DisplayLayout.Bands(0).Columns("Odometro").MaskInput = "{double:-9.2:c}"
                                Case "H"
                                    .DisplayLayout.Bands(0).Columns("Horometro").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                                    .DisplayLayout.Bands(0).Columns("UltimaActDisp").Header.Caption = "Ultima Act. Horo."
                                    .DisplayLayout.Bands(0).Columns("Horometro").MaskInput = "{double:-9.2:c}"
                                Case "D"
                                    .DisplayLayout.Bands(0).Columns("Odometro").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                                    .DisplayLayout.Bands(0).Columns("UltimaActDisp").Header.Caption = "Fecha Actual"
                                    .DisplayLayout.Bands(0).Columns("Odometro").MaskInput = "{double:-9.2:c}"
                            End Select

                            .DisplayLayout.Bands(0).Columns("UltMant").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                            .DisplayLayout.Bands(0).Columns("MantProy").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center

                            'Columnas fijas(5)
                            Dim cantColFijas As Integer = 9
                            For Each fila As UltraGridRow In .Rows
                                If fila.Cells("Ind_OTPendiente").Value > 0 Then
                                    fila.Cells("MantProy").Appearance.BackColor = Color.PaleGreen
                                End If
                            Next

                            Dim x As Integer = .DisplayLayout.Bands(0).Columns.Count - cantColFijas
                            For i As Integer = 1 To x
                                .DisplayLayout.Bands(0).Columns(cantColFijas - 1 + i).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                                .DisplayLayout.Bands(0).Columns(cantColFijas - 1 + i).MaskInput = "{double:-9.2:c}"
                                .DisplayLayout.Bands(0).Columns(cantColFijas - 1 + i).CellActivation = Activation.NoEdit
                                .DisplayLayout.Bands(0).Columns(cantColFijas - 1 + i).Header.Appearance.FontData.Bold = DefaultableBoolean.True
                                For Each fila As UltraGridRow In .Rows
                                    If fila.Cells("MantProy").Value = i Then
                                        If fila.Cells(cantColFijas - 1 + i).Value < 0 Then
                                            fila.Cells(cantColFijas - 1 + i).Appearance.BackColor = Me.ColoresSobrepaso.Color
                                            fila.Cells(cantColFijas - 1 + i).Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                                        ElseIf fila.Cells(cantColFijas - 1 + i).Value >= 0 And fila.Cells(cantColFijas - 1 + i).Value < 2000 Then
                                            fila.Cells(cantColFijas - 1 + i).Appearance.BackColor = Me.ColoresFalta.Color
                                            fila.Cells(cantColFijas - 1 + i).Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                                        Else
                                            fila.Cells(cantColFijas - 1 + i).Appearance.BackColor = Me.Colores.Color
                                            fila.Cells(cantColFijas - 1 + i).Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                                        End If
                                        'fila.Cells(cantColFijas - 1 + i).Appearance.BackColor = Color.Khaki
                                    End If
                                Next
                            Next
                        Else
                            .DataSource = odProyeccion
                        End If
                    End With
                Else
                    Throw New Exception("Seleccione Modelo")
                End If
            Else
                Throw New Exception("Seleccione una Marca")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ProgramarOT()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim ld_FechaProg As Date
            Dim KmProy As Double = grid_Proyeccion.ActiveCell.Value
            Dim KmxDia As Double = CalcularRecorridoPromedioxDia(grid_Proyeccion.ActiveRow.Cells("IdEquipo").Value)
            Dim OT_Programada As Integer = grid_Proyeccion.ActiveRow.Cells("Ind_OTPendiente").Value
            If OT_Programada > 0 Then Throw New Exception("Existe una OT Pendiente")
            If KmProy > 0 Then
                ld_FechaProg = Date.Today.AddDays(KmProy / KmxDia)
            Else
                ld_FechaProg = Date.Now
            End If
            Dim OT As New frm_OrdenTrabajo
            OT = OT.getInstancia()
            OT.MdiParent = frm_Menu
            OT.Show()
            OT.Nuevo()
            OT.CargarDatos(ld_FechaProg, grid_Proyeccion.ActiveRow.Cells("IdMantEquiProy").Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Private Sub ConsultarMantenimientosAnteriores(ByVal ls_IdEquipo As String)
        Try
            Try
                Cursor.Current = Cursors.WaitCursor
                oeOT = New e_OrdenTrabajo
                oeOT.Activo = True
                oeOT.TipoOperacion = "A"
                oeOT.FechaProgramacionIni = Date.Parse("01/01/1901").Date
                oeOT.FechaProgramacionFin = Date.Parse("01/01/1901").Date
                oeOT.FechaIngresoTaller = Date.Parse("01/01/1901").Date
                oeOT.FechaInicioTrabajo = Date.Parse("01/01/1901").Date
                oeOT.FechaFinTrabajo = Date.Parse("01/01/1901").Date
                oeOT.FechaCreacion = Date.Parse("01/01/1901").Date
                oeOT.NroOT = ""
                oeOT.IdEstadoOT = ""
                oeOT.IdEquipo = ls_IdEquipo
                oeOT.IdSupervisorMant = ""
                oeOT.IdMantenimiento = ""
                oeOT.IdTipoMantenimiento = ""
                oeOT.IndicadorTipo = ""

                oeOT.FechaProgramacionIni = Date.Today.AddDays(-60)
                oeOT.FechaProgramacionFin = Date.Today

                dsOTAnteriores = olOrdenTrabajo.Listar(oeOT)

                ''''''''''''''''''''''''''''''''''''''''''''''
                'Tabla(0) OT
                'Tabla(1) Equipo
                'Tabla(2) Mantenimiento
                'Tabla(3) Material
                ''''''''''''''''''''''''''''''''''''''''''''''

                Dim IdOT As DataColumn = dsOTAnteriores.Tables(0).Columns("IdOT")
                Dim IdOT_EM As DataColumn = dsOTAnteriores.Tables(1).Columns("IdOrdenTrabajo")
                Dim relation1 As DataRelation = New DataRelation("FK_Relacion_OTOT", IdOT, IdOT_EM, True)
                dsOTAnteriores.Relations.Add(relation1)

                Dim TransactionColumns() As DataColumn, DetailColumns() As DataColumn
                TransactionColumns = New DataColumn() {dsOTAnteriores.Tables(1).Columns("IdOrdenTrabajo"), dsOTAnteriores.Tables(1).Columns("IdEquipo")}
                DetailColumns = New DataColumn() {dsOTAnteriores.Tables(2).Columns("IdOrdenTrabajo"), dsOTAnteriores.Tables(2).Columns("IdEquipo")}
                Dim Tran_Detail As New DataRelation("FK_Relacion_OTEM", TransactionColumns, DetailColumns)
                dsOTAnteriores.Relations.Add(Tran_Detail)

                Dim TransactionColumns1() As DataColumn, DetailColumns1() As DataColumn
                TransactionColumns1 = New DataColumn() {dsOTAnteriores.Tables(2).Columns("IdOrdenTrabajo"), dsOTAnteriores.Tables(2).Columns("IdEquipo"), dsOTAnteriores.Tables(2).Columns("IdMantenimiento")}
                DetailColumns1 = New DataColumn() {dsOTAnteriores.Tables(3).Columns("IdOrdenTrabajo"), dsOTAnteriores.Tables(3).Columns("IdEquipo"), dsOTAnteriores.Tables(3).Columns("IdMantenimiento")}
                Dim Tran_Detail1 As New DataRelation("FK_Relacion_MM", TransactionColumns1, DetailColumns1, True)
                dsOTAnteriores.Relations.Add(Tran_Detail1)


                dsOTAnteriores.AcceptChanges()
                With grid_OTAnteriores
                    .DataSource = dsOTAnteriores

                    .DisplayLayout.Bands(1).ColHeadersVisible = False
                    .DisplayLayout.Bands(2).ColHeadersVisible = False
                    .DisplayLayout.Bands(3).ColHeadersVisible = False

                    .DisplayLayout.Bands(1).Columns("IdOrdenTrabajo").Hidden = True
                    .DisplayLayout.Bands(1).Columns("IdEquipo").Hidden = True
                    .DisplayLayout.Bands(2).Columns("IdOrdenTrabajo").Hidden = True
                    .DisplayLayout.Bands(2).Columns("IdEquipo").Hidden = True
                    .DisplayLayout.Bands(2).Columns("IdMantenimiento").Hidden = True

                    .DisplayLayout.Bands(3).Columns("IdOrdenTrabajo").Hidden = True
                    .DisplayLayout.Bands(3).Columns("IdEquipo").Hidden = True
                    .DisplayLayout.Bands(3).Columns("IdMantenimiento").Hidden = True
                    .DisplayLayout.Bands(3).Columns("IdMaterial").Hidden = True

                    .DisplayLayout.Bands(1).Columns("Odometro").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(1).Columns("Horometro").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(3).Columns("CantidadMaterialEntregada").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Auxilio").Width = 80

                    'For x As Integer = 0 To .Rows.Count - 1
                    '    .Rows(x).ExpandAll()
                    'Next
                    .DisplayLayout.Bands(0).Columns("Odometro").CellActivation = Activation.NoEdit

                End With
            Catch ex As Exception
                Throw ex
            Finally
                Me.Cursor = Cursors.Default
            End Try
            grid_OTAnteriores.Focus()
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function CalcularRecorridoPromedioxDia(ByVal ls_IdEquipo As String) As Double
        Try
            Dim RecorridoxDia As Double = 0
            Dim kmrec As Double = 0
            Dim hrsrec As Double = 0
            Dim diasrec As Double = 0
            oeEquipo = New e_Equipo
            oeEquipo.Activo = True
            oeEquipo.Id = ls_IdEquipo
            oeEquipo.TipoOperacion = ""
            oeEquipo = olEquipo.Obtener(oeEquipo)

            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Id = oeEquipo.IdVehiculo
            oeVehiculo = olVehiculo.Obtener(oeVehiculo)

            oeViaje = New e_Viaje
            oeViaje.Activo = True
            oeViaje.ViajeVacio = 2
            oeViaje.FechaDesde = Date.Today.AddDays(-30)
            oeViaje.FechaHasta = Date.Today
            oeViaje.TipoOperacion = "1"
            oeViaje.Zona = ""
            oeViaje.IndMotriz = oeVehiculo.Motriz
            oeViaje.IdTracto = oeVehiculo.Id
            lstViaje = olOperacion.ListarViaje(oeViaje)
            If lstViaje.Count > 0 Then
                For Each objViaje As e_Viaje In lstViaje
                    hrsrec += DateDiff(DateInterval.Hour, objViaje.LlegadaOrigen, objViaje.SalidaDestino)
                    Select Case oeVehiculo.Motriz
                        Case 0
                            kmrec += (objViaje.KmCarretaDestino - objViaje.KmCarretaOrigen)
                        Case 1
                            kmrec += (objViaje.KmTractoDestino - objViaje.KmTractoOrigen)
                    End Select
                Next
                diasrec = hrsrec / 20
                RecorridoxDia = kmrec / diasrec
            End If
            Return RecorridoxDia
        Catch ex As Exception
            Throw
        End Try

    End Function

#End Region
    
#Region "Botones" 'Manejo de botones del menú principal del sistema

    ''' <summary>
    ''' Consultar información de órdenes de trabajo
    ''' </summary>
    ''' <param name="Activo"></param>
    ''' <remarks></remarks>
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListarProyeccion()
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            'If grid_Proyeccion.Rows.Count > 0 Then
            '    MyBase.Consultar(Activo)
            'Else
            '    MyBase.Consultar()
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Generar una nueva orden de trabajo
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Nuevo()
        'MyBase.Nuevo()
    End Sub

    ''' <summary>
    ''' Editar, actualizar o modificar una orden de trabajo
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Editar()

    End Sub

    ''' <summary>
    ''' Guardar la información de la orden de trabajo
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Guardar()

    End Sub

    ''' <summary>
    ''' Presionar el botón cancelar durante la actualización de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Cancelar()
    End Sub

    ''' <summary>
    ''' Eliminar una orden de trabajo
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Eliminar()
    End Sub

    ''' <summary>
    ''' Imprimir una orden de trabajo
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If grid_Proyeccion.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Proyeccion)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region


    Private Sub grid_Proyeccion_MouseEnterElement(ByVal sender As System.Object, ByVal e As Infragistics.Win.UIElementEventArgs) Handles grid_Proyeccion.MouseEnterElement
        Try
            If grid_Proyeccion.Rows.Count > 0 Then
                Dim celda As UltraGridCell = TryCast(e.Element.GetContext(GetType(UltraGridCell), True), UltraGridCell)
                If Not celda Is Nothing Then
                    If celda.Column.Key = "MantProy" AndAlso Not IsDBNull(celda.Value) Then
                        Dim num As Integer = CInt(celda.Value)
                        Dim _xnum = 8 + num
                        _xnum = IIf(_xnum > (grid_Proyeccion.DisplayLayout.Bands(0).Columns.Count - 1), 8, _xnum)
                        Dim mant As String = grid_Proyeccion.DisplayLayout.Bands(0).Columns(_xnum).Header.Caption
                        Dim tipInfo As New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo(mant, Infragistics.Win.ToolTipImage.Default, "Mantenimiento Proyectado", Infragistics.Win.DefaultableBoolean.True)
                        UltraToolTipManager1.SetUltraToolTip(grid_Proyeccion, tipInfo)
                        UltraToolTipManager1.ShowToolTip(grid_Proyeccion)
                    Else
                        UltraToolTipManager1.HideToolTip()
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
       
    End Sub

#Region "Menu Contextual"

    Private Sub mnuProyeccion_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuProyeccion.Opening
        mnuProyeccion.Items("tsmiExportaProy").Visible = IIf(grid_Proyeccion.Rows.Count > 0, True, False)
    End Sub

    Private Sub mnuDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuDetalle.Opening
        mnuDetalle.Items("tsmiExportarDet").Visible = IIf(grid_OTAnteriores.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiExportarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExportarDet.Click
        Exportar_Excel(grid_OTAnteriores)
    End Sub

    Private Sub tsmiExportaProy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExportaProy.Click
        Exportar_Excel(grid_Proyeccion)
    End Sub

#End Region

End Class
