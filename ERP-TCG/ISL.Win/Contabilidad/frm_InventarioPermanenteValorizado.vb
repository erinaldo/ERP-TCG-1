'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frm_InventarioPermanenteValorizado
    Inherits ISL.Win.frm_MenuPadre

    Private Shared instancia As frm_InventarioPermanenteValorizado = Nothing
    Private Shared Operacion As String
    Private oeKardex As New e_Kardex
    Private olKardex As New l_Kardex
    Private oeTipoCompra As New e_TablaContableDet
    Private oeCuentaCtable As New e_CuentaContable
    Private olCuentaContable As New l_CuentaContable
    Private leCuentaCtable As New List(Of e_CuentaContable)
    Private olPeriodo As New l_Periodo
    Private dtInventario As DataTable
    Dim oeCentro As New e_Centro, olCentro As New l_Centro
    Dim oeAlmacen As New e_Almacen, olAlmacen As New l_Almacen
    Dim oeSubAlmacen As New e_SubAlmacen, olSubAlmacen As New l_SubAlmacen

    Dim ds_CortesPeriodo As DataSet
    Dim dt_Kardex As Data.DataTable
    Dim dt_KardexDetalle As Data.DataTable
    Dim dt_KardexSaldo As Data.DataTable

#Region "Inicialización del formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_InventarioPermanenteValorizado()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones" 'Manejo de botones del menú principal del sistema

    Public Overrides Sub Nuevo()
        Try
            Inicializa(True)
            MostrarTabs(1, tc_RegInvPermVal, 1)
            Operacion = "Nuevo"
            ControlBoton(1, 0, 0, 0, 1, 0, 1, 1, 1)
            'cmbCuenta.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If grid_kardex.Rows.Count = 0 Then Throw New Exception("No hay ningun registro para exportar al Excel")
            Exportar_Excel(grid_kardex)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Select Case tc_RegInvPermVal.SelectedTab.Index
                Case 0
                    ListarCortesPeriodo()
                    If grid_CortesPeriodo.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 1
                    Select Case Operacion
                        Case "Nuevo"
                            If grid_ListaSubAlmacen.Rows.Count > 0 Then Listar()
                            Tiempo1.Enabled = True
                            If grid_kardex.Rows.Count > 0 Then
                                ControlBoton(1, 0, 0, 1, 1, 0, 1, 1, 1)
                            Else
                                ControlBoton(1, 0, 0, 0, 1, 0, 1, 0, 1)
                            End If
                            CalcularTotales(grid_kardex, "CantSal", "CostUnitSal", "CostoTotalSal")
                        Case "Editar"
                            MostrarKardex()
                            Tiempo1.Enabled = True
                            ControlBoton(1, 0, 0, 0, 1, 0, 1, 1, 1)
                            CalcularTotales(grid_kardex, "CantSal", "CostUnitSal", "CostoTotalSal")
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Corte() Then
                If grid_CortesPeriodo.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
                MostrarTabs(0, tc_RegInvPermVal)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, tc_RegInvPermVal, 2)
            If grid_CortesPeriodo.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
            Operacion = "Inicializa"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            MostrarKardex()
            grid_kardex.Focus()
            MostrarTabs(1, tc_RegInvPermVal, 1)
            ControlBoton(0, 0, 0, 0, 1, 0, 1, 1, 1)
            Operacion = "Editar"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        If grid_kardex.Rows.Count = 0 Then Throw New Exception("No hay Registros")
        Dim frm As New frm_ImprimeRegInventarioPermVal(grid_kardex.DataSource, Año1.Año.ToString, cbo_Mes.Text, cboAlmacen.Text)
        frm.ShowDialog()
    End Sub
#End Region

#Region "Eventos"

    Private Sub frm_InventarioPermanenteValorizado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboPeriodo("ALM")
            ComboCentro()
            ComboCuentasContable()
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tc_RegInvPermVal)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_InventarioPermanenteValorizado_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case tc_RegInvPermVal.SelectedTab.Index
            Case 0
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            Case 1
                ControlBoton(1, 0, 0, 1, 1, 0, 1, 1, 1)
        End Select
    End Sub

    Private Sub frm_InventarioPermanenteValorizado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_InventarioPermanenteValorizado_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub btnKardexValorizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        Try
            ComboPeriodo("ALM")
            ComboCuentasContable()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cmbCuenta_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cmbCuenta.InitializeLayout
        Me.cmbCuenta.ValueMember = "Id"
        Me.cmbCuenta.DisplayMember = "Nombre"
        For Each col As UltraGridColumn In cmbCuenta.DisplayLayout.Bands(0).Columns
            col.Hidden = True
        Next
        With cmbCuenta.DisplayLayout.Bands(0)
            .Columns("Cuenta").Hidden = False
            .Columns("Nombre").Hidden = False
        End With
    End Sub

    Private Sub cmbCuenta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCuenta.ValueChanged
        oeKardex.IdCuentaContable = cmbCuenta.Value
    End Sub

    Private Sub cboCentro_ValueChanged(sender As Object, e As EventArgs) Handles cboCentro.ValueChanged
        LimpiaCombo(cboAlmacen)
        ComboAlmacen(cboCentro.Value)
    End Sub

    Private Sub LimpiaCombo(ByVal cboCombo As ISL.Controles.Combo)
        If cboCombo.Items.Count > 0 Then
            cboCombo.Items.Clear()
        End If
    End Sub

    Private Sub cboAlmacen_ValueChanged(sender As Object, e As EventArgs) Handles cboAlmacen.ValueChanged
        Try
            ListarSubAlmacen()
            'Mostrar_Botones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_CortesPeriodo_DoubleClick(sender As Object, e As EventArgs) Handles grid_CortesPeriodo.DoubleClick
        Editar()
    End Sub

#End Region

#Region "Métodos"

    Private Sub ListarCortesPeriodo()
        Try
            oeKardex = New e_Kardex
            oeKardex.TipoOperacion = "L"
            ds_CortesPeriodo = olKardex.ListarCortePeriodos(oeKardex)

            Dim IdPerKdx() As DataColumn, IdPerCta() As DataColumn
            IdPerKdx = New DataColumn() {ds_CortesPeriodo.Tables(0).Columns("IdPeriodo"), ds_CortesPeriodo.Tables(0).Columns("IdAlmacen")}
            IdPerCta = New DataColumn() {ds_CortesPeriodo.Tables(1).Columns("IdPeriodo"), ds_CortesPeriodo.Tables(1).Columns("IdAlmacen")}
            Dim relation1 As DataRelation = New DataRelation("FK_Relacion_KCT", IdPerKdx, IdPerCta, False)
            ds_CortesPeriodo.Relations.Add(relation1)
            ds_CortesPeriodo.AcceptChanges()
            grid_CortesPeriodo.DataSource = ds_CortesPeriodo

            'grid_CortesPeriodo.DisplayLayout.Bands(1).ColHeadersVisible = False
            'grid_CortesPeriodo.DisplayLayout.Bands(2).ColHeadersVisible = False
            grid_CortesPeriodo.DisplayLayout.Bands(0).Columns("IdPeriodo").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(1).Columns("IdPeriodo").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(0).Columns("Ejercicio").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(0).Columns("Mes").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(1).Columns("Id").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(1).Columns("IdCuentaContable").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(0).Columns("ValorTotal").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            grid_CortesPeriodo.DisplayLayout.Bands(1).Columns("Total").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            grid_CortesPeriodo.DisplayLayout.Bands(0).Columns("IdAlmacen").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(1).Columns("IdSubAlmacen").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(1).Columns("IdCentro").Hidden = True
            grid_CortesPeriodo.DisplayLayout.Bands(1).Columns("SubAlmacen").Width = 250
            grid_CortesPeriodo.DisplayLayout.Bands(0).Columns("ValorTotal").Format = "#,##0.00"
            grid_CortesPeriodo.DisplayLayout.Bands(1).Columns("Total").Format = "#,##0.00"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Corte() As Boolean
        Try
            If grid_kardex.Rows.Count - 1 > 0 Then
                olKardex.GuardarMasivo(dt_Kardex, dt_KardexDetalle, dt_KardexSaldo)
                mensajeEmergente.Confirmacion("Se Genero Correctamente el Kardex.")
                MostrarTabs(0, tc_RegInvPermVal, 2)
                Consultar(True)
                grid_CortesPeriodo.Focus()
                Return True
            Else
                Throw New Exception("No se puede generar un corte de kardex sino hay registros Detalles !!")
                Return False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Function CrearDT_Kardex() As Data.DataTable
        Dim Kardex As New Data.DataTable
        With Kardex
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPeriodo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaContable", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdSubAlmacen", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Total", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdUsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("IdPeriodoSgt", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return Kardex
    End Function

    Public Function CrearDT_KardexDetalle() As Data.DataTable
        Dim Kardex As New Data.DataTable
        With Kardex
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdKardex", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdVehiculo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdArea", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdGastoFuncion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMaterial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovimientoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoOperacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Cantidad", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Valor", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Operacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("IdUsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdRegistroInventario", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ValorPromedio", Type.GetType("System.Decimal")))
        End With
        Return Kardex
    End Function

    Public Function CrearDT_KardexSaldo() As Data.DataTable
        Dim Kardex As New Data.DataTable
        With Kardex
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdKardex", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMaterial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ValorUnitario", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("CantidadFinal", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdUsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
        End With
        Return Kardex
    End Function

    Private Sub Listar()
        Dim ls_Material As String = ""
        Dim RESULT As String = ""
        Try
            Dim KardexTabla As New DataTable
            oeKardex = New e_Kardex
            ValidarCombo(cbo_Mes, "Mes")
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeKardex.TipoOperacion = "L"
            oeKardex.IdCuentaContable = cmbCuenta.Value
            oeKardex.Año = Año1.Año
            oeKardex.Mes = cbo_Mes.Text
            oeKardex.IdPeriodo = cbo_Mes.Value
            oeKardex.IdSubAlmacen = grid_ListaSubAlmacen.ActiveRow.Cells("Id").Value.ToString
            'If oeKardex.IdCuentaContable.Trim <> "" Then
            '    For Each FilaCbo As UltraGridRow In cmbCuenta.Rows
            '        If FilaCbo.Cells("Id").Value.ToString.Trim <> "" Then
            '            oeKardex.IdCuentaContable = FilaCbo.Cells("Id").Value.ToString

            '        End If

            '    Next
            'End If

            With grid_kardex
                .DataSource = olKardex.Listar2(oeKardex)

                'KardexTabla = olKardex.Listar2(oeKardex)
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                Else
                    Exit Sub
                End If

                Dim ld_saldototal As Double = 0
                Dim ld_totaling As Double = 0
                Dim ld_totalsal As Double = 0
                Dim ld_valortotal As Double = 0
                Dim ld_ValTotAux As Double = 0
                Dim ls_IdMaterial As String = ""
                Dim ls_CuentaCtble As String = ""
                Dim sw As Boolean = False
                Dim rowAlternatingColor As Color = Color.LightGoldenrodYellow

                Dim IdKardex As String = "", IdKardexDetalle As String = "", IdKardexSaldo As String = ""
                Dim lsPrefijo As String = ""

                IdKardex = olKardex.UltimoIdInserta_Kardex(gs_PrefijoIdSucursal)
                IdKardexDetalle = olKardex.UltimoIdInserta_KardexDetalle(gs_PrefijoIdSucursal)
                IdKardexSaldo = olKardex.UltimoIdInserta_KardexSaldo(gs_PrefijoIdSucursal)
                lsPrefijo = Strings.Left(IdKardex, 3)

                Dim lnNumeroKardex As Integer = CInt(Strings.Right(IdKardex, Len(IdKardex) - 3))
                Dim lnNumeroKardexDetalle As Integer = CInt(Strings.Right(IdKardexDetalle, Len(IdKardexDetalle) - 3))
                Dim lnNumeroKardexSaldo As Integer = CInt(Strings.Right(IdKardexSaldo, Len(IdKardexSaldo) - 3))

                dt_Kardex = CrearDT_Kardex()
                dt_KardexDetalle = CrearDT_KardexDetalle()
                dt_KardexSaldo = CrearDT_KardexSaldo()

                Dim rowKardex As Data.DataRow = Nothing
                Dim rowKardexDetalle As Data.DataRow
                Dim rowKardexSaldo As Data.DataRow = Nothing

                For Each fila As UltraGridRow In grid_kardex.Rows
                    ls_Material = fila.Cells("Material").Value
                    '---------------------KARDEX-------------------------------------
                    If fila.Cells("IdCuentaContable").Value <> ls_CuentaCtble Then
                        If ls_CuentaCtble <> "" Then dt_Kardex.Rows.Add(rowKardex)
                        rowKardex = dt_Kardex.NewRow
                        IdKardex = lsPrefijo & CompletaConCeros(lnNumeroKardex.ToString, 7)
                        rowKardex("Id") = IdKardex
                        rowKardex("IdPeriodo") = cbo_Mes.Value
                        rowKardex("IdCuentaContable") = fila.Cells("IdCuentaContable").Value
                        rowKardex("IdSubAlmacen") = grid_ListaSubAlmacen.ActiveRow.Cells("Id").Value.ToString
                        rowKardex("IdUsuarioCreacion") = gUsuarioSGI.Id
                        rowKardex("FechaCreacion") = Date.Now
                        rowKardex("IdPeriodoSgt") = "1SI0000"
                        rowKardex("Activo") = 1
                        rowKardex("Total") = 0
                        lnNumeroKardex = lnNumeroKardex + 1
                    Else
                        If fila.Cells("TipoFila").Value = "S" Then
                            rowKardex("Total") = rowKardex("Total") + fila.Cells("CostoTotal").Value
                        End If
                    End If

                    '----------------------KARDEX SALDO-----------------------------
                    If fila.Cells("IdMaterial").Value <> ls_IdMaterial Then
                        rowKardexSaldo = dt_KardexSaldo.NewRow
                        rowKardexSaldo("Id") = lsPrefijo & CompletaConCeros(lnNumeroKardexSaldo.ToString, 7)
                        rowKardexSaldo("IdKardex") = IdKardex
                        rowKardexSaldo("IdMaterial") = fila.Cells("IdMaterial").Value
                        rowKardexSaldo("ValorUnitario") = 0
                        rowKardexSaldo("CantidadFinal") = 0
                        rowKardexSaldo("IdUsuarioCreacion") = gUsuarioSGI.Id
                        rowKardexSaldo("FechaCreacion") = Date.Now
                        lnNumeroKardexSaldo = lnNumeroKardexSaldo + 1
                    Else
                        If fila.Cells("TipoFila").Value = "S" Then
                            rowKardexSaldo("ValorUnitario") = fila.Cells("CostoUnit").Value
                            rowKardexSaldo("CantidadFinal") = fila.Cells("CantTotal").Value
                            dt_KardexSaldo.Rows.Add(rowKardexSaldo)
                        End If
                    End If
                    '---------------------KARDEX DETALLE-----------------------------
                    rowKardexDetalle = dt_KardexDetalle.NewRow
                    rowKardexDetalle("Id") = lsPrefijo & CompletaConCeros(lnNumeroKardexDetalle.ToString, 9)
                    rowKardexDetalle("IdKardex") = IdKardex
                    rowKardexDetalle("IdVehiculo") = fila.Cells("IdVehiculo").Value
                    rowKardexDetalle("IdTrabajador") = fila.Cells("IdTrabajador").Value
                    rowKardexDetalle("IdArea") = fila.Cells("IdArea").Value
                    rowKardexDetalle("IdGastoFuncion") = fila.Cells("IdGastoFuncion").Value.ToString.Trim
                    rowKardexDetalle("IdMaterial") = fila.Cells("IdMaterial").Value
                    rowKardexDetalle("IdMovimientoDocumento") = fila.Cells("IdMovimientoDocumento").Value
                    rowKardexDetalle("TipoOperacion") = fila.Cells("TipoOper").Value.ToString.Trim

                    Select Case fila.Cells("TipoOper").Value.ToString.Trim
                        Case "02", "03", "08", "99", "21", "25" ' Ingreso
                            rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantIng").Value)
                            rowKardexDetalle("Valor") = CDec(fila.Cells("CostUnitIng").Value)
                            If CDec(fila.Cells("CantIng").Value) < 0 Then fila.Cells("CantIng").Value = "( " & fila.Cells("CantIng").Value.ToString & ")"

                        Case "01", "05", "10", "11", "20", "27", "29" 'Salida
                            rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantSal").Value)
                            rowKardexDetalle("Valor") = CDec(fila.Cells("CostUnitSal").Value)
                            If CDec(fila.Cells("CantSal").Value) < 0 Then fila.Cells("CantSal").Value = "( " & fila.Cells("CantSal").Value.ToString & ")"

                        Case "16" ' Saldo
                            rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantTotal").Value)
                            rowKardexDetalle("Valor") = CDec(fila.Cells("CostoUnit").Value)
                        Case "28"
                            If fila.Cells("Operacion").Value = "I" Then
                                rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantIng").Value)
                                rowKardexDetalle("Valor") = CDec(fila.Cells("CostUnitIng").Value)
                                If CDec(fila.Cells("CantIng").Value) < 0 Then fila.Cells("CantIng").Value = "( " & fila.Cells("CantIng").Value.ToString & ")"

                            ElseIf fila.Cells("Operacion").Value = "S" Then
                                rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantSal").Value)
                                rowKardexDetalle("Valor") = CDec(fila.Cells("CostUnitSal").Value)
                                If CDec(fila.Cells("CantSal").Value) < 0 Then fila.Cells("CantSal").Value = "( " & fila.Cells("CantSal").Value.ToString & ")"
                            End If
                    End Select

                    rowKardexDetalle("ValorPromedio") = CDec(fila.Cells("CostoUnit").Value)
                    rowKardexDetalle("Operacion") = fila.Cells("Operacion").Value
                    rowKardexDetalle("Fecha") = fila.Cells("Fecha").Value
                    rowKardexDetalle("FechaCreacion") = Date.Now
                    rowKardexDetalle("IdUsuarioCreacion") = gUsuarioSGI.Id
                    rowKardexDetalle("IdRegistroInventario") = fila.Cells("IdRegistroInventario").Value
                    RESULT = fila.Cells("IdRegistroInventario").Value
                    dt_KardexDetalle.Rows.Add(rowKardexDetalle)
                    lnNumeroKardexDetalle = lnNumeroKardexDetalle + 1

                    If fila.Cells("TipoOper").Value.ToString.Trim = "16" Then
                        ld_saldototal = ld_saldototal + fila.Cells("CostoTotal").Value
                    End If

                    ld_totaling = ld_totaling + IIf(fila.Cells("CostoTotalIng").Value <> "", fila.Cells("CostoTotalIng").Value, 0)
                    ld_totalsal = ld_totalsal + IIf(fila.Cells("CostoTotalSal").Value <> "", fila.Cells("CostoTotalSal").Value, 0)

                    If ls_IdMaterial <> "" Then
                        If fila.Cells("IdMaterial").Value <> ls_IdMaterial Then
                            rowAlternatingColor = IIf(sw = False, Color.White, Color.LightGoldenrodYellow)
                            sw = Not (sw)
                            ld_valortotal = ld_valortotal + ld_ValTotAux
                        End If
                    End If

                    fila.Cells("Material").Appearance.BackColor = rowAlternatingColor
                    fila.Cells("Fecha").Appearance.BackColor = rowAlternatingColor
                    fila.Cells("TipoDoc").Appearance.BackColor = rowAlternatingColor
                    fila.Cells("Serie").Appearance.BackColor = rowAlternatingColor
                    fila.Cells("Numero").Appearance.BackColor = rowAlternatingColor
                    fila.Cells("TipoOper").Appearance.BackColor = rowAlternatingColor

                    ls_CuentaCtble = fila.Cells("IdCuentaContable").Value
                    ls_IdMaterial = fila.Cells("IdMaterial").Value
                    ld_ValTotAux = fila.Cells("CostoTotal").Value
                Next

                dt_Kardex.Rows.Add(rowKardex)

                Me.DecSaldo.Value = ld_saldototal
                Me.DecIngresos.Value = ld_totaling
                Me.DecEgresos.Value = ld_totalsal
                Me.DecTotal.Value = IIf(ld_valortotal = 0, ld_ValTotAux, ld_valortotal + ld_ValTotAux)

                .UpdateData()
            End With
            '---------------------------
            'With grid_kardex
            '    .DataSource = olKardex.Listar2(oeKardex)
            '    If .Rows.Count > 0 Then
            '        .Focus()
            '        .Rows.Item(0).Selected = True
            '    Else
            '        Exit Sub
            '    End If

            '    Dim ld_saldototal As Double = 0
            '    Dim ld_totaling As Double = 0
            '    Dim ld_totalsal As Double = 0
            '    Dim ld_valortotal As Double = 0
            '    Dim ld_ValTotAux As Double = 0
            '    Dim ls_IdMaterial As String = ""
            '    Dim ls_CuentaCtble As String = ""
            '    Dim sw As Boolean = False
            '    Dim rowAlternatingColor As Color = Color.LightGoldenrodYellow

            '    Dim IdKardex As String = "", IdKardexDetalle As String = "", IdKardexSaldo As String = ""
            '    Dim lsPrefijo As String = ""

            '    IdKardex = olKardex.UltimoIdInserta_Kardex()
            '    IdKardexDetalle = olKardex.UltimoIdInserta_KardexDetalle()
            '    IdKardexSaldo = olKardex.UltimoIdInserta_KardexSaldo()
            '    lsPrefijo = Strings.Left(IdKardex, 3)

            '    Dim lnNumeroKardex As Integer = CInt(Strings.Right(IdKardex, Len(IdKardex) - 3))
            '    Dim lnNumeroKardexDetalle As Integer = CInt(Strings.Right(IdKardexDetalle, Len(IdKardexDetalle) - 3))
            '    Dim lnNumeroKardexSaldo As Integer = CInt(Strings.Right(IdKardexSaldo, Len(IdKardexSaldo) - 3))

            '    dt_Kardex = CrearDT_Kardex()
            '    dt_KardexDetalle = CrearDT_KardexDetalle()
            '    dt_KardexSaldo = CrearDT_KardexSaldo()

            '    Dim rowKardex As Data.DataRow = Nothing
            '    Dim rowKardexDetalle As Data.DataRow
            '    Dim rowKardexSaldo As Data.DataRow = Nothing

            '    For Each fila As UltraGridRow In grid_kardex.Rows
            '        ls_Material = fila.Cells("Material").Value
            '        '---------------------KARDEX-------------------------------------
            '        If fila.Cells("IdCuentaContable").Value <> ls_CuentaCtble Then
            '            If ls_CuentaCtble <> "" Then dt_Kardex.Rows.Add(rowKardex)
            '            rowKardex = dt_Kardex.NewRow
            '            IdKardex = lsPrefijo & CompletaConCeros(lnNumeroKardex.ToString, 7)
            '            rowKardex("Id") = IdKardex
            '            rowKardex("IdPeriodo") = cbo_Mes.Value
            '            rowKardex("IdCuentaContable") = fila.Cells("IdCuentaContable").Value
            '            rowKardex("IdSubAlmacen") = grid_ListaSubAlmacen.ActiveRow.Cells("Id").Value.ToString
            '            rowKardex("IdUsuarioCreacion") = gUsuarioSGI.Id
            '            rowKardex("FechaCreacion") = Date.Now
            '            rowKardex("IdPeriodoSgt") = "1SI0000"
            '            rowKardex("Activo") = 1
            '            rowKardex("Total") = 0
            '            lnNumeroKardex = lnNumeroKardex + 1
            '        Else
            '            If fila.Cells("TipoFila").Value = "S" Then
            '                rowKardex("Total") = rowKardex("Total") + fila.Cells("CostoTotal").Value
            '            End If
            '        End If

            '        '----------------------KARDEX SALDO-----------------------------
            '        If fila.Cells("IdMaterial").Value <> ls_IdMaterial Then
            '            rowKardexSaldo = dt_KardexSaldo.NewRow
            '            rowKardexSaldo("Id") = lsPrefijo & CompletaConCeros(lnNumeroKardexSaldo.ToString, 7)
            '            rowKardexSaldo("IdKardex") = IdKardex
            '            rowKardexSaldo("IdMaterial") = fila.Cells("IdMaterial").Value
            '            rowKardexSaldo("ValorUnitario") = 0
            '            rowKardexSaldo("CantidadFinal") = 0
            '            rowKardexSaldo("IdUsuarioCreacion") = gUsuarioSGI.Id
            '            rowKardexSaldo("FechaCreacion") = Date.Now
            '            lnNumeroKardexSaldo = lnNumeroKardexSaldo + 1
            '        Else
            '            If fila.Cells("TipoFila").Value = "S" Then
            '                rowKardexSaldo("ValorUnitario") = fila.Cells("CostoUnit").Value
            '                rowKardexSaldo("CantidadFinal") = fila.Cells("CantTotal").Value
            '                dt_KardexSaldo.Rows.Add(rowKardexSaldo)
            '            End If
            '        End If
            '        '---------------------KARDEX DETALLE-----------------------------
            '        rowKardexDetalle = dt_KardexDetalle.NewRow
            '        rowKardexDetalle("Id") = lsPrefijo & CompletaConCeros(lnNumeroKardexDetalle.ToString, 9)
            '        rowKardexDetalle("IdKardex") = IdKardex
            '        rowKardexDetalle("IdVehiculo") = fila.Cells("IdVehiculo").Value
            '        rowKardexDetalle("IdTrabajador") = fila.Cells("IdTrabajador").Value
            '        rowKardexDetalle("IdArea") = fila.Cells("IdArea").Value
            '        rowKardexDetalle("IdGastoFuncion") = fila.Cells("IdGastoFuncion").Value.ToString.Trim
            '        rowKardexDetalle("IdMaterial") = fila.Cells("IdMaterial").Value
            '        rowKardexDetalle("IdMovimientoDocumento") = fila.Cells("IdMovimientoDocumento").Value
            '        rowKardexDetalle("TipoOperacion") = fila.Cells("TipoOper").Value.ToString.Trim

            '        Select Case fila.Cells("TipoOper").Value.ToString.Trim
            '            Case "02", "03", "08", "99", "21", "25" ' Ingreso
            '                rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantIng").Value)
            '                rowKardexDetalle("Valor") = CDec(fila.Cells("CostUnitIng").Value)
            '                If CDec(fila.Cells("CantIng").Value) < 0 Then fila.Cells("CantIng").Value = "( " & fila.Cells("CantIng").Value.ToString & ")"

            '            Case "01", "05", "10", "11", "20", "27", "29" 'Salida
            '                rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantSal").Value)
            '                rowKardexDetalle("Valor") = CDec(fila.Cells("CostUnitSal").Value)
            '                If CDec(fila.Cells("CantSal").Value) < 0 Then fila.Cells("CantSal").Value = "( " & fila.Cells("CantSal").Value.ToString & ")"

            '            Case "16" ' Saldo
            '                rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantTotal").Value)
            '                rowKardexDetalle("Valor") = CDec(fila.Cells("CostoUnit").Value)
            '            Case "28"
            '                If fila.Cells("Operacion").Value = "I" Then
            '                    rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantIng").Value)
            '                    rowKardexDetalle("Valor") = CDec(fila.Cells("CostUnitIng").Value)
            '                    If CDec(fila.Cells("CantIng").Value) < 0 Then fila.Cells("CantIng").Value = "( " & fila.Cells("CantIng").Value.ToString & ")"

            '                ElseIf fila.Cells("Operacion").Value = "S" Then
            '                    rowKardexDetalle("Cantidad") = CDec(fila.Cells("CantSal").Value)
            '                    rowKardexDetalle("Valor") = CDec(fila.Cells("CostUnitSal").Value)
            '                    If CDec(fila.Cells("CantSal").Value) < 0 Then fila.Cells("CantSal").Value = "( " & fila.Cells("CantSal").Value.ToString & ")"
            '                End If
            '        End Select

            '        rowKardexDetalle("ValorPromedio") = CDec(fila.Cells("CostoUnit").Value)
            '        rowKardexDetalle("Operacion") = fila.Cells("Operacion").Value
            '        rowKardexDetalle("Fecha") = fila.Cells("Fecha").Value
            '        rowKardexDetalle("FechaCreacion") = Date.Now
            '        rowKardexDetalle("IdUsuarioCreacion") = gUsuarioSGI.Id
            '        rowKardexDetalle("IdRegistroInventario") = fila.Cells("IdRegistroInventario").Value
            '        RESULT = fila.Cells("IdRegistroInventario").Value
            '        dt_KardexDetalle.Rows.Add(rowKardexDetalle)
            '        lnNumeroKardexDetalle = lnNumeroKardexDetalle + 1

            '        If fila.Cells("TipoOper").Value.ToString.Trim = "16" Then
            '            ld_saldototal = ld_saldototal + fila.Cells("CostoTotal").Value
            '        End If

            '        ld_totaling = ld_totaling + IIf(fila.Cells("CostoTotalIng").Value <> "", fila.Cells("CostoTotalIng").Value, 0)
            '        ld_totalsal = ld_totalsal + IIf(fila.Cells("CostoTotalSal").Value <> "", fila.Cells("CostoTotalSal").Value, 0)

            '        If ls_IdMaterial <> "" Then
            '            If fila.Cells("IdMaterial").Value <> ls_IdMaterial Then
            '                rowAlternatingColor = IIf(sw = False, Color.White, Color.LightGoldenrodYellow)
            '                sw = Not (sw)
            '                ld_valortotal = ld_valortotal + ld_ValTotAux
            '            End If
            '        End If

            '        fila.Cells("Material").Appearance.BackColor = rowAlternatingColor
            '        fila.Cells("Fecha").Appearance.BackColor = rowAlternatingColor
            '        fila.Cells("TipoDoc").Appearance.BackColor = rowAlternatingColor
            '        fila.Cells("Serie").Appearance.BackColor = rowAlternatingColor
            '        fila.Cells("Numero").Appearance.BackColor = rowAlternatingColor
            '        fila.Cells("TipoOper").Appearance.BackColor = rowAlternatingColor

            '        ls_CuentaCtble = fila.Cells("IdCuentaContable").Value
            '        ls_IdMaterial = fila.Cells("IdMaterial").Value
            '        ld_ValTotAux = fila.Cells("CostoTotal").Value
            '    Next

            '    dt_Kardex.Rows.Add(rowKardex)

            '    Me.DecSaldo.Value = ld_saldototal
            '    Me.DecIngresos.Value = ld_totaling
            '    Me.DecEgresos.Value = ld_totalsal
            '    Me.DecTotal.Value = IIf(ld_valortotal = 0, ld_ValTotAux, ld_valortotal + ld_ValTotAux)

            '    .UpdateData()
            'End With
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message + " " + ls_Material + " " + RESULT, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ComboPeriodo(ByVal ls_IndCierre As String)
        Try
            Dim oePeriodo As New e_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            oePeriodo.TipoOperacion = "C"
            oePeriodo.Ejercicio = Año1.Año
            oePeriodo.IndCierre = ls_IndCierre
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            With cbo_Mes
                .DisplayMember = "Mes"
                .ValueMember = "Id"
                .DataSource = lePeriodo
                If .Items.Count > 0 Then
                    .Text = Date.Now.Month
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboCentro()
        oeCentro.TipoOperacion = ""
        oeCentro.Activo = True
        LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), 0)
        cboCentro.Value = ObtenerCentro.Id
    End Sub

    Private Sub ComboAlmacen(ByVal idCentro As String)
        Try
            oeAlmacen.TipoOperacion = ""
            oeAlmacen.Activo = True
            oeAlmacen.IdCentro = idCentro
            LlenarComboMaestro(cboAlmacen, olAlmacen.Listar(oeAlmacen), 0)
            If cboAlmacen.Items.Count = 0 Then
                grid_ListaSubAlmacen.DataSource = odSubAlmacen
                'LimpiarListas()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ListarSubAlmacen()
        Try
            'LimpiarListas()
            Me.Cursor = Cursors.WaitCursor
            oeSubAlmacen = New e_SubAlmacen
            oeSubAlmacen.IdAlmacen = cboAlmacen.Value
            oeSubAlmacen.TipoOperacion = "A"
            With grid_ListaSubAlmacen
                If Not String.IsNullOrEmpty(oeSubAlmacen.IdAlmacen) Then
                    .DataSource = olSubAlmacen.Listar_SubAlmacen(oeSubAlmacen)
                End If
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Sub Inicializa(ByVal sw As Boolean)
        DecSaldo.Value = 0
        DecIngresos.Value = 0
        DecEgresos.Value = 0
        DecTotal.Value = 0
        Año1.Año = Date.Now.Year
        cbo_Mes.SelectedIndex = -1
        cboCentro.SelectedIndex = 0
        cboAlmacen.SelectedIndex = -1
        cmbCuenta.Value = ""
        cbo_Mes.Enabled = sw
        Año1.Enabled = sw
        cmbCuenta.Enabled = sw
        cboCentro.Enabled = sw
        cboAlmacen.Enabled = sw
        grid_kardex.DataSource = od_Kardex
        gb_SubAlmacen.Visible = sw
        grid_ListaSubAlmacen.Visible = sw
        If sw Then
            gb_Montos.Location = New Point(885, 6)
        Else
            gb_Montos.Location = New Point(388, 6)
        End If
    End Sub

    Private Sub MostrarKardex()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If tc_RegInvPermVal.SelectedTab.Index = 0 Then
                Inicializa(False)
                Select Case grid_CortesPeriodo.ActiveRow.Band.Index
                    Case 0
                        Año1.Año = grid_CortesPeriodo.ActiveRow.Cells("Ejercicio").Value
                    Case 1
                        Año1.Año = grid_CortesPeriodo.ActiveRow.ParentRow.Cells("Ejercicio").Value
                End Select
                ComboPeriodo("")
                cbo_Mes.Value = grid_CortesPeriodo.ActiveRow.Cells("IdPeriodo").Value.ToString
                cboCentro.Value = grid_CortesPeriodo.ActiveRow.Cells("IdCentro").Value
                Select Case grid_CortesPeriodo.ActiveRow.Band.Index
                    Case 0
                        cmbCuenta.Value = ""
                        cboAlmacen.Value = grid_CortesPeriodo.ActiveRow.Cells("IdAlmacen").Value
                        grid_kardex.Text = grid_CortesPeriodo.ActiveRow.ChildBands(0).Rows(1).Cells("SubAlmacen").Value
                    Case 1
                        Dim idctactble As String = grid_CortesPeriodo.ActiveRow.Cells("IdCuentaContable").Value
                        cmbCuenta.Value = grid_CortesPeriodo.ActiveRow.Cells("IdCuentaContable").Value
                        cboAlmacen.Value = grid_CortesPeriodo.ActiveRow.ParentRow.Cells("IdAlmacen").Value
                        grid_kardex.Text = grid_CortesPeriodo.ActiveRow.Cells("SubAlmacen").Value
                End Select
            End If
            oeKardex = New e_Kardex
            oeKardex.IdCuentaContable = cmbCuenta.Value
            oeKardex.TipoOperacion = "K"
            oeKardex.IdPeriodo = cbo_Mes.Value
            With grid_kardex
                .DataSource = olKardex.ListarKardex(oeKardex)
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True

                    Dim ld_saldototal As Double = 0, ld_totaling As Double = 0, ld_totalsal As Double = 0
                    Dim ld_valortotal As Double = 0, ld_ValTotAux As Double = 0
                    Dim ls_IdMaterial As String = ""

                    For Each fila As UltraGridRow In .Rows
                        If fila.Cells("TipoOper").Value.ToString.Trim = "16" Then
                            ld_saldototal = ld_saldototal + fila.Cells("CostoTotal").Value
                        End If
                        ld_totaling = ld_totaling + IIf(fila.Cells("CostoTotalIng").Value <> "", fila.Cells("CostoTotalIng").Value, 0)
                        ld_totalsal = ld_totalsal + IIf(fila.Cells("CostoTotalSal").Value <> "", fila.Cells("CostoTotalSal").Value, 0)

                        If ls_IdMaterial <> "" Then
                            If fila.Cells("IdMaterial").Value <> ls_IdMaterial Then
                                ld_valortotal = ld_valortotal + ld_ValTotAux
                            End If
                        End If
                        ls_IdMaterial = fila.Cells("IdMaterial").Value
                        ld_ValTotAux = fila.Cells("CostoTotal").Value
                    Next

                    Me.DecSaldo.Value = ld_saldototal
                    Me.DecIngresos.Value = ld_totaling
                    Me.DecEgresos.Value = ld_totalsal
                    Me.DecTotal.Value = IIf(ld_valortotal = 0, ld_ValTotAux, ld_valortotal + ld_ValTotAux)

                End If
                .DisplayLayout.Bands(0).Columns("UnidMedida").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoMat").Hidden = True
            End With
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ComboCuentasContable()
        Try
            leCuentaCtable = New List(Of e_CuentaContable)
            oeCuentaCtable.Id = "" : oeCuentaCtable.Nombre = "TODAS" : oeCuentaCtable.Cuenta = "00000"
            leCuentaCtable.Add(oeCuentaCtable)
            oeCuentaCtable = New e_CuentaContable
            oeCuentaCtable.TipoOperacion = "T"
            oeCuentaCtable.Activo = True
            oeCuentaCtable.Movimiento = 1
            oeCuentaCtable.Ejercicio = Me.Año1.Año
            leCuentaCtable.AddRange(olCuentaContable.Listar(oeCuentaCtable))
            cmbCuenta.DataSource = leCuentaCtable
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
