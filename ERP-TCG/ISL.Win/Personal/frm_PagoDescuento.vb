Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_PagoDescuento
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_PagoDescuento = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_PagoDescuento
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oePagoDescuento As New e_PagoDescuento, olPagoDescuento As New l_PagoDescuento, lePagoDescuento As New List(Of e_PagoDescuento)
    Private oePrestamoDet As New e_PrestamoDetalle, olPrestamoDet As New l_PrestamoDetalle, lePrestamoDet As New List(Of e_PrestamoDetalle)
    Private oeRDescTrabajador As New e_ReporteDescTrabajador, olRDescTrabajador As New l_Prestamo, leRDescTrabajador As New List(Of e_ReporteDescTrabajador)
    Private oePrestamo As New e_Prestamo, olPrestamo As New l_Prestamo, lePrestamo As New List(Of e_Prestamo)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)

    Dim var As Integer = -1
    Private FechaEjecucion As Date
    Private IndAdelantoPrestamo As Boolean
    Dim _idTrabajador As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try

            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If ficDescuento.SelectedTab.Index = 0 Then
                FechaEjecucion = fecFecha.Value
                IndAdelantoPrestamo = optConcepto.CheckedIndex
                listar(Activo)
                Tiempo1.Enabled = True
                Operacion = "Inicializa"

                If griDescuentoMes.Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Else
                oeRDescTrabajador = New e_ReporteDescTrabajador
                oeRDescTrabajador.TipoOperacion = "2"
                leRDescTrabajador = olRDescTrabajador.ListarRDT(oeRDescTrabajador)
                CargarSaldoTrabajador(leRDescTrabajador)
            End If

            ugb_Espera.Visible = False

        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If ficDescuento.Tabs(0).Selected AndAlso griDescuentoMes.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficDescuento.Tabs(0).Selected Then Exportar_Excel(griDescuentoMes)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_PagoDescuento_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                Nuevo()
            Case "Editar"
                Editar()
            Case "Inicializa"
                If griDescuentoMes.Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_PagoDescuento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_PagoDescuento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            fecFecha.Value = Convert.ToDateTime("01/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString)
            optConcepto.CheckedIndex = 0
            CargarCombos()
            lePagoDescuento = New List(Of e_PagoDescuento)
            CargarDescuentoMes(lePagoDescuento)
            CargarSaldoTrabajador(New List(Of e_ReporteDescTrabajador))
            CargaDeuda(New List(Of e_Prestamo))
            CargaOption()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFecha.ValueChanged
        Try

            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            CargaOption()
            listar(True)
            btnEjecutar.Enabled = False
            If fecFecha.Value.Date.Month = 7 Or fecFecha.Value.Date.Month = 12 Then
                If optNroDesc.CheckedIndex = 0 Then
                    cboPlanillaBus.SelectedIndex = -1
                    cboPlanillaBus.Enabled = False
                    btnEjecutar.Enabled = True
                Else
                    cboPlanillaBus.SelectedIndex = -1
                    cboPlanillaBus.Enabled = True
                End If
            Else
                cboPlanillaBus.SelectedIndex = -1
                cboPlanillaBus.Enabled = True
            End If
            oePeriodo = New e_Periodo
            oePeriodo.Ejercicio = fecFecha.Value.Year
            oePeriodo.Mes = fecFecha.Value.Month
            oePeriodo.Equivale = 2
            If lePeriodo.Contains(oePeriodo) Then
                oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                Dim _lePla = lePlanilla.Where(Function(it) it.IdPeriodo = oePeriodo.Id).ToList
                LlenarCombo(cboPlanillaBus, "Codigo", _lePla, -1)
            End If

            ugb_Espera.Visible = False

        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub optNroDesc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNroDesc.ValueChanged
        Try
            If optNroDesc.Visible Then
                btnEjecutar.Enabled = IIf(optNroDesc.CheckedIndex = 0, True, False)
                cboPlanillaBus.SelectedIndex = -1
                cboPlanillaBus.Enabled = IIf(optNroDesc.CheckedIndex = 0, False, True)
            End If
            listar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub optConcepto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optConcepto.ValueChanged
        Try
            listar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDescuentoMes_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDescuentoMes.ClickCellButton
        Try
            Dim CadId As String()
            Dim Monto As String()
            Dim xCuota As Double
            Dim leTemp As New List(Of e_PrestamoDetalle)
            lePrestamoDet = New List(Of e_PrestamoDetalle)

            griDescuentoMes.UpdateData()

            xCuota = griDescuentoMes.ActiveRow.Cells("Cuota").Value
            If xCuota = 0 Then Throw New Exception("El Monto de Descuento debe ser mayor de Cero")
            If xCuota > griDescuentoMes.ActiveRow.Cells("Saldo").Value Then Throw New Exception("El Monto de Descuento no debe ser mayo al Saldo")

            CadId = griDescuentoMes.ActiveRow.Cells("CadIdPrestamo").Value.ToString.Split("|")
            Monto = griDescuentoMes.ActiveRow.Cells("MontoPrestamo").Value.ToString.Split("|")

            For i As Integer = 0 To CadId.Length - 1
                oePrestamoDet = New e_PrestamoDetalle
                oePrestamoDet.TipoOperacion = "U"
                oePrestamoDet.IdPrestamo = CadId(i)
                oePrestamoDet.MontoPrest = Monto(i)
                oePrestamoDet.Cancelado = 0
                oePrestamoDet.Anulado = 0
                oePrestamoDet.DobleMes = IIf(optNroDesc.Visible = True, optNroDesc.CheckedIndex, 0)
                oePrestamoDet = olPrestamoDet.Obtener(oePrestamoDet)
                If oePrestamoDet.Id <> "" Then
                    xCuota = xCuota - oePrestamoDet.Importe
                Else
                    leTemp.Add(oePrestamoDet)
                End If
            Next

            If leTemp.Count > 0 Then
                For Each oeDet As e_PrestamoDetalle In leTemp
                    If xCuota > 0 Then
                        If oeDet.MontoPrest > xCuota Then
                            oeDet.Importe = xCuota
                            xCuota = 0
                        Else
                            xCuota = xCuota - oeDet.MontoPrest
                            oeDet.Importe = oeDet.MontoPrest
                        End If
                        oeDet.Anio = fecFecha.Value.Year
                        oeDet.Mes = FormatoDocumento(fecFecha.Value.Month.ToString, 2)
                        oeDet.UsuarioCreacion = gUsuarioSGI.Id
                        oeDet.TipoOperacion = "I"
                        lePrestamoDet.Add(oeDet)
                    Else
                        Exit For
                    End If
                Next
            Else
                For i As Integer = 0 To CadId.Length - 1
                    oePrestamoDet = New e_PrestamoDetalle
                    If xCuota > 0 Then
                        If Monto(i) > xCuota Then
                            oePrestamoDet.Importe = xCuota
                            xCuota = 0
                        Else
                            xCuota = xCuota - Monto(i)
                            oePrestamoDet.Importe = Monto(i)
                        End If
                        oePrestamoDet.IdPrestamo = CadId(i)
                        oePrestamoDet.Cancelado = 0
                        oePrestamoDet.Anulado = 0
                        oePrestamoDet.Anio = fecFecha.Value.Year
                        oePrestamoDet.Mes = FormatoDocumento(fecFecha.Value.Month.ToString, 2)
                        oePrestamoDet.UsuarioCreacion = gUsuarioSGI.Id
                        oePrestamoDet.TipoOperacion = "I"
                        lePrestamoDet.Add(oePrestamoDet)
                    Else
                        Exit For
                    End If
                Next
            End If

            olPrestamoDet.GuardarLista(lePrestamoDet)

            mensajeEmergente.Confirmacion("El Dato se ha Guardado correctamente", True)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDescuentoMes_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDescuentoMes.CellChange
        'griDescuentoMes.UpdateData()
    End Sub

    Private Sub griDescuentoMes_MouseEnterElement(ByVal sender As System.Object, ByVal e As Infragistics.Win.UIElementEventArgs) Handles griDescuentoMes.MouseEnterElement
        If griDescuentoMes.Rows.Count > 0 Then
            Dim celda As UltraGridCell = TryCast(e.Element.GetContext(GetType(UltraGridCell), True), UltraGridCell)
            Dim xvar As String()
            Dim txtmensaje As String = ""
            If Not celda Is Nothing Then
                If celda.Row.Index <> var Then
                    ToolTip.HideToolTip()
                    var = celda.Row.Index
                    If celda.Row.Index > -1 AndAlso celda.Column.Key = "Saldo" Then
                        'var = celda.Row.Index
                        xvar = griDescuentoMes.Rows(celda.Row.Index).Cells("MontoPrestamo").Value.ToString.Split("|")
                        For i As Integer = 0 To xvar.Length - 1
                            txtmensaje = txtmensaje & "Prestamo Nº: " & i + 1 & " --> S/ " & xvar(i) & Environment.NewLine
                        Next
                        'ToolTip.Enabled = True
                        Dim ToolTipInfo As New UltraWinToolTip.UltraToolTipInfo
                        ToolTipInfo.ToolTipTitle = "Información del Sistema"
                        ToolTipInfo.ToolTipText = txtmensaje
                        ToolTipInfo.ToolTipImage = ToolTipImage.Info
                        ToolTip.SetUltraToolTip(griDescuentoMes, ToolTipInfo)
                        ToolTip.ShowToolTip(griDescuentoMes)
                    Else
                        ToolTip.HideToolTip()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Try
            If MessageBox.Show("¿Desea Ejecutar los Descuenstos del Mes: " & fecFecha.Value.Month & "?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                FechaEjecucion = fecFecha.Value
                Dim lePagoDesc As New List(Of e_PagoDescuento)
                Dim CadPagoDesc As String = ""
                Dim oePrestamo As New e_Prestamo
                Dim olPrestamo As New l_Prestamo
                Dim lePrestamo As New List(Of e_Prestamo)
                'Dim CadPrest As String = ""
                lePagoDesc = lePagoDescuento.Where(Function(item) item.Cuota > 0).ToList
                Dim Cadid As String()
                Dim CadidPrest As String()
                If lePagoDesc.Count > 0 Then
                    For Each oePagoDesc As e_PagoDescuento In lePagoDesc
                        Cadid = oePagoDesc.CadIdPrestamoDet.Split("|")
                        CadidPrest = oePagoDesc.CadIdPrestamo.Split("|")
                        For i As Integer = 0 To Cadid.Length - 1
                            CadPagoDesc = CadPagoDesc & "'" & Cadid(i) & "',"
                        Next
                        For j As Integer = 0 To CadidPrest.Length - 1
                            oePrestamo = New e_Prestamo
                            'CadPrest = CadPrest & "'" & CadidPrest(j) & "',"
                            oePrestamo.TipoOperacion = "P"
                            oePrestamo.Id = CadidPrest(j)
                            lePrestamo.Add(oePrestamo)
                        Next
                    Next
                    CadPagoDesc = CadPagoDesc.Substring(0, CadPagoDesc.Length - 1)
                    ' CadPrest = CadPrest.Substring(0, CadPrest.Length - 1)
                    oePrestamoDet = New e_PrestamoDetalle
                    oePrestamoDet.CadIdPrestDet = CadPagoDesc
                    oePrestamoDet.TipoOperacion = "P"
                    oePrestamoDet.Glosa = "DESCUENTO POR PLANILLA EL " & Date.Now.ToString & " POR: " & gUsuarioSGI.oePersona.NombreCompleto
                    If fecFecha.Value.Month = 7 Or fecFecha.Value.Month = 12 Then
                        If optNroDesc.CheckedIndex = 0 Then
                            oePrestamoDet.Glosa = "DESCUENTO POR GRATIFICACION EL " & Date.Now.ToString & " POR: " & gUsuarioSGI.oePersona.NombreCompleto
                        End If
                    End If
                    Dim olPeriodo As New l_Periodo
                    Dim oePeriodo As New e_Periodo
                    oePeriodo.Ejercicio = FechaEjecucion.Year
                    oePeriodo.Mes = FechaEjecucion.Month
                    oePeriodo = olPeriodo.Obtener(oePeriodo)
                    l_FuncionesGenerales.ValidarPeriodo(oePeriodo.Id, gAreasSGI.Tesoreria)
                    oePrestamoDet.oePreiodo = oePeriodo
                    oePrestamoDet.UsuarioCreacion = gUsuarioSGI.Id
                    Dim lsPerioEje As String = FechaEjecucion.Year & FormatoDocumento(FechaEjecucion.Month, 2) & IIf(optNroDesc.CheckedIndex = 0, "1", "2")
                    oePrestamoDet.PeriodoEjec = FechaEjecucion.Year & FormatoDocumento(FechaEjecucion.Month, 2) & IIf(optNroDesc.CheckedIndex = 0, "1", "2")
                    olPrestamoDet.Ejecutar(oePrestamoDet, lePrestamo, ObtenerFechaServidor, IndAdelantoPrestamo, lsPerioEje) 'pagar dos campos tabla prestamos detalle fecha y cancelado
                    'olPrestamo.GuardarLista(lePrestamo, "", "", Nothing) ' actualiza saldo en la cabecera 
                    mensajeEmergente.Confirmacion("Se Ejecuto Correctamente los Descuentos", True)
                    listar(True)
                Else
                    Throw New Exception("No hay Descuentos para ejecutar este mes.")
                End If
            End If
            
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTrabajadorCesado_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griTrabajadorCesado.DoubleClick
        Try
            _idTrabajador = griTrabajadorCesado.ActiveRow.Cells("IdTrabajador").Value
            ListarDeuda()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuLiquida_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuLiquida.Opening
        If griPrestamoAsociado.Rows.Count > 0 Then
            mnuLiquida.Items("tsmiLiquidar").Visible = True
        Else
            mnuLiquida.Items("tsmiLiquidar").Visible = False
        End If
    End Sub

    Private Sub griPrestamoAsociado_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griPrestamoAsociado.CellChange
        griPrestamoAsociado.UpdateData()
    End Sub

    Private Sub griPrestamoAsociado_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griPrestamoAsociado.AfterHeaderCheckStateChanged
        griPrestamoAsociado.UpdateData()
    End Sub

    Private Sub tsmiLiquidar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiLiquidar.Click
        Try
            'Dim _cadenaprest As String = ""
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "PLA")
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                lePrestamo = New List(Of e_Prestamo)
                For Each fila In griPrestamoAsociado.Rows
                    If fila.Cells("Selec").Value = True Then
                        ' _cadenaprest = _cadenaprest & "'" & fila.Cells("Id").Value & "',"
                        oePrestamo = New e_Prestamo
                        oePrestamo.Id = fila.Cells("Id").Value
                        oePrestamo.TipoOperacion = "L"
                        oePrestamoDet = New e_PrestamoDetalle
                        oePrestamoDet.Importe = fila.Cells("Saldo").Value
                        oePrestamoDet.Cancelado = 1
                        oePrestamoDet.Anulado = 0
                        oePrestamoDet.Fecha = Date.Now.Date
                        oePrestamoDet.Mes = FormatoDocumento(frm.cboMes.Text, 2)
                        oePrestamoDet.Anio = frm.Año1.Año
                        oePrestamoDet.Glosa = "LIQUIDACION DEL PERIODO: " & oePrestamoDet.Mes & "/" & oePrestamoDet.Anio
                        oePrestamoDet.PeriodoEjec = oePrestamoDet.Anio & oePrestamoDet.Mes & "1"
                        oePrestamoDet.TipoOperacion = "I"
                        oePrestamoDet.UsuarioCreacion = gUsuarioSGI.Id
                        oePrestamo.leDetalle.Add(oePrestamoDet)
                        lePrestamo.Add(oePrestamo)
                    End If
                Next
                If lePrestamo.Count > 0 Then
                    olPrestamo.Liquidar(lePrestamo)
                    ListarDeuda()
                    mensajeEmergente.Confirmacion("Se liquidó Correctamente!!!!!", True)
                Else
                    Throw New Exception("Elija al menos un prestamo para liquidar!!")
                End If
            End If
            
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPlanillaBus_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanillaBus.ValueChanged
        Try
            If cboPlanillaBus.SelectedIndex > -1 Then
                oePlanilla = New e_Planilla
                oePlanilla = cboPlanillaBus.Items(cboPlanillaBus.SelectedIndex).ListObject
                btnEjecutar.Enabled = IIf(oePlanilla.Estado = "GENERADA", True, False)
            Else
                btnEjecutar.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDescuentoMes_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles griDescuentoMes.DoubleClickCell
        Try
            With griDescuentoMes
                If .ActiveRow.Index > -1 Then
                    Select Case .ActiveCell.Column.Key
                        Case "Cuota"
                            Dim _cuotaing As Double = 0
                            Dim _idTrabajador = .Rows(.ActiveCell.Row.Index).Cells("IdTrabajador").Value
                            Dim _frm As New frm_RegistroPagoCuota(1, New List(Of e_Prestamo), New List(Of e_PrestamoDetalle), _
                                                                  _cuotaing, fecFecha.Value, optNroDesc.CheckedIndex, optConcepto.CheckedIndex, _idTrabajador)
                            _frm.StartPosition = FormStartPosition.CenterScreen
                            _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                            If _frm.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                                Consultar(True)
                                mensajeEmergente.Confirmacion("Los Datos se guardaron correctamente", True)
                            End If
                    End Select
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = ""
            oePeriodo.Activo = True
            lePeriodo = olPeriodo.Listar(oePeriodo)

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.Activo = True
            oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla)

            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = ""
            oeTrabajador.oePersona.ApellidoPaterno = "TODOS"
            leTrabajador.Add(oeTrabajador)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))

            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = ""
            oeSueldo.Activo = True
            oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)

            Dim _leTrabAux = From le In leTrabajador _
                             Select le.Id, le.oePersona.NombreCompleto

            LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, 0)

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = ""
            oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)

            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = ""
            oeDetParametro.Activo = True
            oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = ""
            oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub listar(ByVal Activo As Boolean)
        Try
            oePagoDescuento = New e_PagoDescuento
            oePagoDescuento.TipoOperacion = String.Empty
            oePagoDescuento.IdTrabajador = cboTrabajador.Value
            oePagoDescuento.Anio = fecFecha.Value.Year
            If optNroDesc.Visible Then
                oePagoDescuento.DobleMes = optNroDesc.CheckedIndex
            Else
                oePagoDescuento.DobleMes = 0
            End If
            oePagoDescuento.Indicador = optConcepto.CheckedIndex
            oePagoDescuento.Mes = FormatoDocumento(fecFecha.Value.Month, 2)
            lePagoDescuento = olPagoDescuento.Listar(oePagoDescuento)

            oePeriodo = New e_Periodo
            oePeriodo.Ejercicio = fecFecha.Value.Year
            oePeriodo.Mes = fecFecha.Value.Month
            oePeriodo.Equivale = 2

            If lePeriodo.Contains(oePeriodo) Then
                oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                Dim _lePla = lePlanilla.Where(Function(it) it.IdPeriodo = oePeriodo.Id).ToList
                'LlenarCombo(cboPlanillaBus, "Codigo", _lePla, -1)
                If _lePla.Count > 0 Then
                    Dim dsDatosGen As New DataTable
                    oeTrabajador = New e_Trabajador
                    oeTrabajador.TipoOperacion = "" : oeTrabajador.Id = _lePla(0).Id
                    dsDatosGen = olTrabajador.CargarDatosGenerales(oeTrabajador).Tables(0)
                    Dim IdsTrab = New List(Of String)
                    For Each r In dsDatosGen.Rows
                        IdsTrab.Add(r("IDTRAB").ToString)
                    Next
                    Dim lePagoDescuentoAux As New List(Of e_PagoDescuento)
                    For Each item In lePagoDescuento
                        If IdsTrab.Contains(item.IdTrabajador) Then
                            lePagoDescuentoAux.Add(item)
                        End If
                    Next
                    lePagoDescuento = lePagoDescuentoAux
                End If
            End If

            CargarDescuentoMes(lePagoDescuento)
            If lePagoDescuento.Count > 0 Then
                'Dim _af = EjecutaFormula(gFAsignacionFamiliar, False, Nothing, leFormula, leParametro, leDetParametro)
                Dim _sueldo As Double = 0, _monaf As Double = 0
                For Each oePD In lePagoDescuento
                    _sueldo = 0 : _monaf = 0
                    oeTrabajador = New e_Trabajador
                    oeTrabajador.Id = oePD.IdTrabajador
                    oeTrabajador.TipoBusca = 1
                    If leTrabajador.Contains(oeTrabajador) Then
                        oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        oeSueldo = New e_SueldoTrabajador
                        oeSueldo.IdTrabajador = oeTrabajador.Id
                        oeSueldo.Equivale = 1
                        If leSueldo.Contains(oeSueldo) Then
                            oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                            _sueldo = oeSueldo.Sueldo
                        End If
                        If oeTrabajador.IndHijo Then _monaf = 0
                        oePD.IngresoBruto = _sueldo + _monaf
                    End If
                Next
                griDescuentoMes.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDescuentoMes(ByVal lePagoDescuento As List(Of e_PagoDescuento))
        Try
            With griDescuentoMes
                .DataSource = lePagoDescuento
                OcultarColumna(griDescuentoMes, True, "IdTrabajador", "CadIdPrestamo", "MontoPrestamo", "CadIdPrestamoDet")
                .DisplayLayout.Bands(0).Columns("Dni").Width = 80
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 300
                .DisplayLayout.Bands(0).Columns("Dni").SortIndicator = SortOrder.Ascending
                FormatoColumna(griDescuentoMes, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto", "Saldo", "SaldoFinal", "IngresoBruto", "Cuota")
                .DisplayLayout.Bands(0).Columns("Cuota").CellAppearance.BackColor = Color.LightYellow
                .DisplayLayout.Bands(0).Columns("IngresoBruto").CellAppearance.BackColor = Color.LightGreen
                CalcularTotales(griDescuentoMes, "Saldo", "Cuota", "SaldoFinal")
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.CellSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaOption()
        Dim bandok As Boolean = IIf(fecFecha.Value.Month = 7 Or fecFecha.Value.Month = 12, True, False)
        etiNroDescuento.Visible = bandok
        optNroDesc.Visible = bandok
        optNroDesc.CheckedIndex = 0
    End Sub

    Private Sub CargarSaldoTrabajador(ByVal leAux As List(Of e_ReporteDescTrabajador))
        Try
            Dim _leRDT = From le In leAux _
                         Select IdTrabajador = le.oeTrabajador.Id, le.oeTrabajador.oePersona.Dni _
                         , Nombre = le.oeTrabajador.oePersona.Nombre, Saldo = le.Adelanto _
                         Order By Nombre Ascending

            With griTrabajadorCesado

                .DataSource = _leRDT.ToList

                .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 350

                .DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.BackColor = Color.LightGray

                .DisplayLayout.Bands(0).Columns("Saldo").Format = "#,##0.00"

                '.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                '.DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                .Text = "SALDO PENDIENTE POR TRABAJADOR"

                If .Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            End With

            CalcularTotales(griTrabajadorCesado, "Saldo")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaDeuda(ByVal lePrest As List(Of e_Prestamo))
        Try
            Dim _lePrest = From le In lePrest _
                           Select le.Id, le.Fecha, le.Concepto, le.Glosa, le.Saldo

            With griPrestamoAsociado

                .ResetDisplayLayout()
                .DataSource = _lePrest.ToList

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Selec").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Selec").Width = 50

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 350
                .DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.BackColor = Color.LightGray
                .DisplayLayout.Bands(0).Columns("Saldo").Format = "#,##0.00"

                For Each Col In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Selec" Then
                        Col.CellClickAction = CellClickAction.Edit
                    Else
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                '.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                '.DisplayLayout.Override.FilterUIProvider = Filtro1
                '.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                '.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                If griTrabajadorCesado.Rows.Count > 0 Then
                    .Text = "DETALLE DE DEUDA DE TRABAJADOR: " & griTrabajadorCesado.ActiveRow.Cells("Nombre").Value
                Else
                    .Text = ""
                End If


            End With
            CalcularTotales(griPrestamoAsociado, "Saldo")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarDeuda()
        oePrestamo = New e_Prestamo
        oePrestamo.IdTrabajador = _idTrabajador
        oePrestamo.Cancelado = 0
        lePrestamo = olPrestamo.Listar(oePrestamo)
        CargaDeuda(lePrestamo)
    End Sub

#End Region

End Class