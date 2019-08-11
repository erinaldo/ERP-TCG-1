Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Reporting.WinForms

Public Class frm_ReportePrestamo
    Inherits ISL.Win.frm_MenuPadre

    Private Shared instancia As frm_ReportePrestamo = Nothing
    Private Shared Operacion As String

#Region "Instancia"
    'Private Shared instancia As frm_ReportePrestamo = Nothing

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        instancia = New frm_ReportePrestamo()
    '    End If
    '    instancia.Activate()
    '    Return instancia
    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReportePrestamo
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReportePrestamo
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variable"

    Dim oeTrab As New e_Trabajador
    Dim olTrab As New l_Trabajador
    Dim leTrab As New List(Of e_Trabajador)

    Dim oePrestamo As New e_Prestamo
    Dim olPrestamo As New l_Prestamo
    Dim lePrestamo As New List(Of e_Prestamo)

    Dim oePrestDet As New e_PrestamoDetalle
    Dim olPrestDet As New l_PrestamoDetalle
    Dim lePrestDet As New List(Of e_PrestamoDetalle)

    Dim cbovalue As String = "NIN"

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        'MyBase.Consultar(Activo)
        Try
            oePrestamo = New e_Prestamo
            Select Case optReporte.CheckedIndex
                Case 0
                    oePrestamo.TipoOperacion = "1"
                Case 1
                    oePrestamo.TipoOperacion = "2"
                    oePrestamo._anio = fecPeriodo.Value.Year
                    oePrestamo._mes = FormatoDocumento(fecPeriodo.Value.Month.ToString, 2)
                Case 2
                    oePrestamo.TipoOperacion = "3"
                    oePrestamo.fecInicio = fecDesde.Value
                    oePrestamo.fecFin = fecHasta.Value
            End Select
            oePrestamo.IdTrabajador = cboTrabajador.Value
            Dim ds As DataSet = olPrestamo.ListarDS(oePrestamo)
            Dim PadreCol As DataColumn = ds.Tables(0).Columns("Id")
            Dim HijoCol As DataColumn = ds.Tables(1).Columns("IdPrestamo")
            Dim Relacion As DataRelation = New DataRelation("Prestamo_Detalle", PadreCol, HijoCol, True)
            ds.Relations.Add(Relacion)
            ds.AcceptChanges()
            With griReportePrestamo
                .DataSource = ds
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPrestamo").Hidden = True
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 200
                .DisplayLayout.Bands(0).Columns("Concepto").Width = 100
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 250
                .DisplayLayout.Bands(0).Columns("NroCuota").Width = 50
                .DisplayLayout.Bands(0).Columns("Anio").Width = 40
                .DisplayLayout.Bands(0).Columns("Mes").Width = 40
                .DisplayLayout.Bands(0).Columns("Importe").Width = 65
                .DisplayLayout.Bands(0).Columns("Cancelado").Width = 65
                .DisplayLayout.Bands(0).Columns("Total").Width = 65
                .DisplayLayout.Bands(0).Columns("Saldo").Width = 65
                .DisplayLayout.Bands(0).Columns("MontoCancelado").Width = 65
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 60
                .DisplayLayout.Bands(0).Columns("NroGrupo").Width = 95

                .DisplayLayout.Bands(0).Columns("NombreCompleto").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("NroCuota").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Anio").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Mes").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Cancelado").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("MontoCancelado").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("NroGrupo").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("NroViaje").Header.VisiblePosition = 13

                .DisplayLayout.Bands(0).Columns("NroCuota").Header.Caption = "Nro"
                .DisplayLayout.Bands(0).Columns("MontoCancelado").Header.Caption = "Cobrado"
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Header.Caption = "Trabajador"

                .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("MontoCancelado").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("Total").Format = "#,##0.00"
                .DisplayLayout.Bands(0).Columns("Saldo").Format = "#,##0.00"
                .DisplayLayout.Bands(0).Columns("MontoCancelado").Format = "#,##0.00"

                .DisplayLayout.Bands(0).Columns("Total").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("MontoCancelado").Style = ColumnStyle.Double

                .DisplayLayout.Bands(1).ColHeadersVisible = False
                .DisplayLayout.Bands(1).Columns("Id").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdPrestamo").Hidden = True
                .DisplayLayout.Bands(1).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("Importe").Style = ColumnStyle.Double
                .DisplayLayout.Bands(1).Columns("Importe").Format = "#,##0.00"
                .DisplayLayout.Bands(1).Columns("Cancelado").Style = ColumnStyle.CheckBox

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                .DisplayLayout.Override.HeaderPlacement = HeaderPlacement.FixedOnTop
                .DisplayLayout.Bands(0).Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Bands(0).Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Bands(0).Override.FilterUIProvider = Filtro1
                .DisplayLayout.Bands(0).Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Bands(0).Override.RowAppearance.BackColor = Color.LightYellow
                CalcularTotales(griReportePrestamo, "Total", "Saldo", "MontoCancelado")
                If .Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            End With
            cbovalue = "NIN"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        If griReportePrestamo.Rows.Count > 0 Then Exportar_Excel(griReportePrestamo)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReportePrestamo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If griReportePrestamo.Rows.Count > 0 Then
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Else
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReportePrestamo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ResportePrestamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fecPeriodo.Value = Convert.ToDateTime("01/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString)
            CargaCombo()
            optReporte.CheckedIndex = 0
            fecPeriodo.Enabled = False
            fecDesde.Enabled = False
            fecHasta.Enabled = False
            btnFilas.Tag = "1"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        Me.rptResumen.RefreshReport()
    End Sub

    Private Sub optReporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optReporte.ValueChanged
        fecPeriodo.Enabled = IIf(optReporte.CheckedIndex = 1, True, False)
        fecDesde.Enabled = IIf(optReporte.CheckedIndex = 2, True, False)
        fecHasta.Enabled = IIf(optReporte.CheckedIndex = 2, True, False)
    End Sub

    Private Sub btnFilas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilas.Click
        If btnFilas.Tag = "1" Then
            For x As Integer = 0 To griReportePrestamo.Rows.Count - 1
                griReportePrestamo.Rows(x).ExpandAll()
            Next
            btnFilas.Tag = "0"
        Else
            For x As Integer = 0 To griReportePrestamo.Rows.Count - 1
                griReportePrestamo.Rows(x).CollapseAll()
            Next
            btnFilas.Tag = "1"
        End If
    End Sub

    Private Sub ficListado_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficListado.SelectedTabChanged
        If ficListado.SelectedTab.Index = 1 Then
            If cbovalue <> cboTrabajador.Value Then
                cbovalue = cboTrabajador.Value
                CargarResumen()
            End If
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargaCombo()
        Try
            oeTrab = New e_Trabajador
            oeTrab.Id = ""
            oeTrab.oePersona.ApellidoPaterno = "TODOS"
            leTrab.Add(oeTrab)
            oeTrab = New e_Trabajador
            oeTrab.TipoOperacion = "P"
            leTrab.AddRange(olTrab.Listar(oeTrab))
            Dim _leTrabAux = From le In leTrab _
                             Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, Area = le.oeArea.Nombre
            LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CrearDTMovPrestamo() As Data.DataTable
        Dim MovPrestamo As New Data.DataTable
        With MovPrestamo
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Cargo", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Abono", Type.GetType("System.Double")))
        End With
        Return MovPrestamo
    End Function

    Private Sub CargarResumen()
        Try
            If cboTrabajador.SelectedIndex > -1 Then
                lePrestDet = New List(Of e_PrestamoDetalle)
                Dim dtDetalle As Data.DataTable = CrearDTMovPrestamo()
                Dim dtDet As Data.DataTable = CrearDTMovPrestamo()
                Dim leTrab2 As New List(Of e_Trabajador)
                Dim lePrestDet2 As New List(Of e_PrestamoDetalle)
                Dim Deuda As Double = 0
                Dim Cobrado As Double = 0
                oeTrab = New e_Trabajador
                oePrestamo = New e_Prestamo
                leTrab2 = leTrab.Where(Function(item) item.Id = cboTrabajador.Value).ToList
                oeTrab = leTrab2(0)
                oePrestamo.IdTrabajador = oeTrab.Id
                oePrestamo.Cancelado = 0
                lePrestamo = olPrestamo.Listar(oePrestamo)
                Deuda = lePrestamo.Sum(Function(item) item.Monto)
                If lePrestamo.Count > 0 Then
                    For Each oePrest As e_Prestamo In lePrestamo

                        Dim rwDetalle As Data.DataRow
                        rwDetalle = dtDetalle.NewRow
                        rwDetalle("Fecha") = oePrest.Fecha
                        rwDetalle("Glosa") = oePrest.Glosa
                        rwDetalle("Cargo") = oePrest.Monto
                        rwDetalle("Abono") = 0
                        dtDetalle.Rows.Add(rwDetalle)

                        oePrestDet = New e_PrestamoDetalle
                        oePrestDet.IdPrestamo = oePrest.Id
                        oePrestDet.Cancelado = 1
                        oePrestDet.Anulado = 0
                        oePrestDet.Activo = 1
                        lePrestDet.AddRange(olPrestDet.Listar(oePrestDet))

                    Next

                    If lePrestDet.Count > 0 Then
                        Cobrado = lePrestDet.Sum(Function(item) item.Importe)
                        For Each oePreD As e_PrestamoDetalle In lePrestDet
                            Dim rwDetalle As Data.DataRow
                            rwDetalle = dtDetalle.NewRow
                            rwDetalle("Fecha") = oePreD.Fecha
                            rwDetalle("Glosa") = "Descuento por Planilla Periodo: " & oePreD.Mes & " - " & oePreD.Anio
                            rwDetalle("Cargo") = 0
                            rwDetalle("Abono") = oePreD.Importe
                            dtDetalle.Rows.Add(rwDetalle)
                        Next
                    End If

                End If

                If dtDetalle.Rows.Count > 0 Then
                    Dim aFila() As Data.DataRow = dtDetalle.Select(Nothing, "Fecha ASC")
                    For Each Fil As Data.DataRow In aFila
                        Dim rw As Data.DataRow
                        rw = dtDet.NewRow
                        rw("Fecha") = Fil.Item("Fecha")
                        rw("Glosa") = Fil.Item("Glosa")
                        rw("Cargo") = Fil.Item("Cargo")
                        rw("Abono") = Fil.Item("Abono")
                        dtDet.Rows.Add(rw)
                    Next
                End If

                Me.rptResumen.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                Me.rptResumen.Visible = True
                Dim oReport As New ReportDataSource("dsMovPrestamo_MovPrestamo", dtDet)
                Dim parametros As New List(Of ReportParameter)
                parametros.Add(New ReportParameter("Dni", oeTrab.oePersona.Dni, False))
                parametros.Add(New ReportParameter("Trabajador", oeTrab.oePersona.NombreCompleto, False))
                parametros.Add(New ReportParameter("Area", oeTrab.oeArea.Nombre, False))
                parametros.Add(New ReportParameter("Deuda", Deuda, False))
                parametros.Add(New ReportParameter("Cobrado", Cobrado, False))
                parametros.Add(New ReportParameter("Saldo", Deuda - Cobrado, False))
                Me.rptResumen.LocalReport.DataSources.Clear()
                Me.rptResumen.LocalReport.DataSources.Add(oReport)
                Me.rptResumen.LocalReport.SetParameters(parametros)
                Me.rptResumen.LocalReport.Refresh()
                Me.rptResumen.RefreshReport()

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class