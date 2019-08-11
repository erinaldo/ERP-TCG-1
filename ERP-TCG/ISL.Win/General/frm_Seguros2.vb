Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinDataSource
Imports System.Collections
Imports Infragistics.Win.UltraWinGrid


Public Class frm_Seguros2
    Inherits ISL.Win.frm_MenuPadre

#Region "clase"
    Class CustomMergedCellEvaluator
        Implements Infragistics.Win.UltraWinGrid.IMergedCellEvaluator

        Function ShouldCellsBeMerged(ByVal row1 As UltraGridRow, ByVal row2 As UltraGridRow, ByVal column As UltraGridColumn) As Boolean Implements IMergedCellEvaluator.ShouldCellsBeMerged
            'If column.Key = "Numero" Or column.Key = "EmpresaCertifica" Or column.Key = "TipoDocumento" Then
            Dim Id1 As String = DirectCast(row1.GetCellValue("IdDocumento"), String)
            Dim Id2 As String = DirectCast(row2.GetCellValue("IdDocumento"), String)
            ' Merge cells according to the date portions of the underlying DateTime cell
            ' values, ignoring any time portion. For example, "1/1/2004 10:30 AM" will be
            ' merged with "1/1/2004 1:15 AM" since the dates are the same.
            Return Id1 = Id2
            'End If
        End Function
    End Class

#End Region

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_Seguros2 = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_Seguros2()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de Variables"

    Dim _ingresando_datos As Boolean
    Dim oeDocumentoVehicular As New e_DocumentoVehicular
    Dim olDocumentoVehicular As New l_DocumentoVehicular
    Dim oeDetalleDocumentoVehiculo As New e_DetalleDocumentoVehiculo
    Dim olDetalleDocumentoVehiculo As New l_DetalleDocumentoVehiculo
    Dim ListaDocumentoVehicular As New List(Of e_DocumentoVehicular)
    Dim oeTipoDocumento As New e_TipoDocumento, olTipoDocumento As New l_TipoDocumento
    Dim oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa
    Dim oeMoneda As New e_Moneda, olMoneda As New l_Moneda
    Dim lstDetalleDocVeh As New List(Of e_DetalleDocumentoVehiculo)
    Dim oeVehiculo As New e_Vehiculo : Dim olVehiculo As New l_Vehiculo
    Dim listaVehiculos As New List(Of e_Vehiculo)
    Dim listaVehiculosS As New List(Of e_Vehiculo) : Dim listaVehiculosP As New List(Of e_Vehiculo)
    Dim oeVehiculo2 As New e_Vehiculo
    Dim olVehiculo2 As New l_Vehiculo
    Dim lstVehiculo2 As New List(Of e_Vehiculo)
    Dim oeVhAse As New e_DetalleDocumentoVehiculo
    Dim oeVhAseS As New e_DetalleDocumentoVehiculo
    Dim oeVhAseP As New e_DetalleDocumentoVehiculo

    Dim oeCuotaDocumentoVehiculo As New e_CuotaDocumentoVehiculo
    Dim ol_CuotaDocumentoVehiculo As New l_CuotaDocumentoVehiculo
    Dim lstCuota As New List(Of e_CuotaDocumentoVehiculo)
    Dim lstDocVeh_Doc As New List(Of e_DocumentoVehicular_Documento)
    Dim y As Integer = 0

    Dim olIgv As New l_Impuesto
    Dim oeImpuesto As New e_Impuesto
    Dim igv As Double = 0.0

    Dim IdentificadorTipo As String

    Dim oeDocVeh_Doc As New e_DocumentoVehicular_Documento
    Dim olDocVeh_Doc As New l_DocumentoVehicular_Documento
    Dim ListaCombo As New List(Of e_DocumentoVehicular_Documento)
    Dim i As Integer = 0
    Dim Monto As Decimal = 0
    Dim SaldoAdministrativo As Decimal = 0
    Dim SaldoContable As Decimal = 0

    Public IndMenu As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListarZ(Activo)
            Operacion = "Inicializa"
            If griSegurosZ.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            If CmbTipoDocumento.Value = "1CH000000048" Or CmbTipoDocumento.Value = "1CH000000049" Then
                oeDocumentoVehicular = New e_DocumentoVehicular
                oeDocumentoVehicular.TipoOperacion = "I"
                oeDocumentoVehicular.UsuarioCreacion = gUsuarioSGI.Id
                Inicializar()
                MostrarTabs(1, tcSeguro, 1)
                Operacion = "Nuevo"
                MyBase.Nuevo()
                If CmbTipoDocumento.Value = "1CH000000048" Then
                    TabDocumentos.Tabs(0).Visible = False
                    TabDocumentos.Tabs(1).Visible = True
                    IdentificadorTipo = "1CH000000048"
                    TxtNumeroP.Focus()
                    UltraTabControl2.Tabs(0).Selected() = True
                ElseIf CmbTipoDocumento.Value = "1CH000000049" Then
                    TabDocumentos.Tabs(0).Visible = True
                    TabDocumentos.Tabs(1).Visible = False
                    IdentificadorTipo = "1CH000000049"
                    TxtNumeroS.Focus()
                End If
            Else
                Throw New Exception("Especifique el Tipo de documento que desea crear")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            oeDocumentoVehicular = New e_DocumentoVehicular
            If griSegurosZ.ActiveRow.Band.Index = 0 Then
                EditarSeguro()
                MostrarTabs(1, tcSeguro, 1)
                Operacion = "Editar"
                If IdentificadorTipo = "1CH000000048" Then
                    TabDocumentos.Tabs(0).Visible = False
                    TabDocumentos.Tabs(1).Visible = True
                    TxtNumeroP.Focus()
                ElseIf IdentificadorTipo = "1CH000000049" Then
                    TabDocumentos.Tabs(0).Visible = True
                    TabDocumentos.Tabs(1).Visible = False
                    TxtNumeroS.Focus()
                End If
                MyBase.Editar()
            Else
                Throw New Exception("Seleccione un Registro válido")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarSeguro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcSeguro, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, tcSeguro, 2)
            IdentificadorTipo = ""
            _ingresando_datos = False
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griSegurosZ
                If griSegurosZ.ActiveRow.Band.Index = 0 Then
                    If MessageBox.Show("Esta seguro de eliminar el seguro N°: " & _
                    .ActiveRow.Cells("Numero").Value.ToString.Trim & "?", _
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeDocumentoVehicular.TipoOperacion = "E"
                        oeDocumentoVehicular.Id = .ActiveRow.Cells("IdDocumento").Value
                        olDocumentoVehicular.Eliminar(oeDocumentoVehicular)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("Seleccione un seguro para poder eliminarlo")
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griSegurosZ.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griSegurosZ)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Seguros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        LlenaCombos()
        ListarVehiculos()
        CmbTipoDocumento.Value = ""
        CalcularTotales(griSegurosZ, "Importe", "Prima", "DerEmision", "Igv", "Total")
        CalcularTotales(griVehAseP, "Prima", "Comision", "DerEmision", "Igv", "Total")
        CalcularTotales(griListaCuotas, "Monto", "SaldoAdministrativo", "SaldoContable")
    End Sub

    Private Sub frm_Seguros_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Seguros_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub MostrarVehiculos()
        Try
            If IdentificadorTipo = "1CH000000048" Then
                griVehAseP.DataSource = oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.Activo = True).ToList
                griVehAseP.DataBind()
            ElseIf IdentificadorTipo = "1CH000000049" Then
                For Each obj In oeDocumentoVehicular.ldDetalleDocVeh
                    For Each obj2 In listaVehiculosS
                        If obj2.Id = obj.IdVehiculo And obj.Activo = True Then
                            obj2.Seleccion = True
                            Exit For
                        End If
                    Next
                Next
                listaVehiculosS.RemoveAll(Function(item) item.Seleccion = True)
                Grid_VehAseS.DataSource = oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.Activo = True).ToList
                Grid_VehAseS.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub grid_SegurosZ_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griSegurosZ.InitializeLayout

        'With grid_SegurosZ.DisplayLayout
        '    .UseFixedHeaders = True
        '    .Override.FixedHeaderIndicator = FixedHeaderIndicator.None
        '    With .Bands(0)
        '        .Columns("IdDocumento").Header.Fixed = True
        '        .Columns("Numero").Header.Fixed = True
        '        .Columns("EmpresaCertifica").Header.Fixed = True
        '        .Columns("Placa").Header.Fixed = True
        '        .Columns("FechaEmision").Header.Fixed = True
        '        .Columns("FechaVencimiento").Header.Fixed = True
        '        .Columns("EmpresaCertifica").Header.Fixed = True
        '        .Columns("EmpresaPropietaria").Header.Fixed = True
        '        .Columns("TipoDocumento").Header.Fixed = True
        '    End With
        'End With

        e.Layout.Bands(0).Columns("EmpresaCertifica").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("TipoDocumento").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Numero").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Moneda").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Importe").MergedCellStyle = MergedCellStyle.Always

        For Each col As UltraGridColumn In griSegurosZ.DisplayLayout.Bands(0).Columns
            If col.Key <> "IdDocumento" Then e.Layout.Bands(0).Columns(col.Key).MergedCellEvaluator = New CustomMergedCellEvaluator()
        Next

    End Sub

    Private Sub grid_SegurosZ_DoubleClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles griSegurosZ.DoubleClickCell
        Try
            Operacion = "Editar"
            oeDocumentoVehicular = New e_DocumentoVehicular
            If griSegurosZ.ActiveRow.Band.Index = 0 Then
                EditarSeguro()
                MostrarTabs(1, tcSeguro, 1)
                Operacion = "Editar"
                If IdentificadorTipo = "1CH000000048" Then
                    TabDocumentos.Tabs(0).Visible = False
                    TabDocumentos.Tabs(1).Visible = True
                    TxtNumeroP.Focus()
                    UltraTabControl2.Tabs(0).Selected() = True
                ElseIf IdentificadorTipo = "1CH000000049" Then
                    TabDocumentos.Tabs(0).Visible = True
                    TabDocumentos.Tabs(1).Visible = False
                    TxtNumeroS.Focus()
                End If
                MyBase.Editar()
            Else
                Throw New Exception("Seleccione un registro válido")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_SegurosZ_MouseEnterElement(ByVal sender As System.Object, ByVal e As Infragistics.Win.UIElementEventArgs) Handles griSegurosZ.MouseEnterElement
        If griSegurosZ.Rows.Count > 0 Then
            Dim celda As UltraGridCell = TryCast(e.Element.GetContext(GetType(UltraGridCell), True), UltraGridCell)
            If Not celda Is Nothing Then
                If celda.Column.Key = "FechaVencimiento" AndAlso Not IsDBNull(celda.Value) Then
                    Dim diasRetrazo As Integer = DateDiff(DateInterval.Day, Date.Now, celda.Value)
                    If diasRetrazo > 0 Then
                        Dim mensaje As String = diasRetrazo.ToString & " días para vencer"
                        Dim tipInfo As New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo(mensaje, Infragistics.Win.ToolTipImage.Default, "Información", Infragistics.Win.DefaultableBoolean.True)
                        UltraToolTipManager1.SetUltraToolTip(griSegurosZ, tipInfo)
                        UltraToolTipManager1.ShowToolTip(griSegurosZ)
                    End If
                Else
                    UltraToolTipManager1.HideToolTip()
                End If
            End If
        End If
    End Sub

    Private Sub ChkMontos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMontos.CheckedChanged
        Try
            If ChkMontos.Checked = False Then
                griSegurosZ.DisplayLayout.Bands(0).Columns("Prima").Hidden = True
                griSegurosZ.DisplayLayout.Bands(0).Columns("DerEmision").Hidden = True
                griSegurosZ.DisplayLayout.Bands(0).Columns("Igv").Hidden = True
                griSegurosZ.DisplayLayout.Bands(0).Columns("Total").Hidden = True
            Else
                griSegurosZ.DisplayLayout.Bands(0).Columns("Prima").Hidden = False
                griSegurosZ.DisplayLayout.Bands(0).Columns("DerEmision").Hidden = False
                griSegurosZ.DisplayLayout.Bands(0).Columns("Igv").Hidden = False
                griSegurosZ.DisplayLayout.Bands(0).Columns("Total").Hidden = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


#End Region

#Region "Métodos"

    Sub LlenaCombos()
        Try
            LlenaComboConsultaTracto()
            LlenaComboMoneda()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Sub LlenaComboConsultaTracto()
        Try
            oeVehiculo2.Id = ""
            oeVehiculo2.Placa = "TODOS"
            lstVehiculo2.Add(oeVehiculo2)
            oeVehiculo2 = New e_Vehiculo
            oeVehiculo2.TipoOperacion = "A"
            oeVehiculo2.Motriz = -1
            oeVehiculo2.Activo = True
            lstVehiculo2.AddRange(olVehiculo2.Listar(oeVehiculo2))
            LlenarComboMaestro(CmbFilTracto, lstVehiculo2, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LlenaComboMoneda()
        Try
            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            LlenarComboMaestro(CmbMonedaS, olMoneda.Listar(oeMoneda), 0)
            LlenarComboMaestro(CmbMonedaP, olMoneda.Listar(oeMoneda), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Inicializar()
        Try
            ''Soat
            TxtNumeroS.Value = ""
            NdImporteS.Value = 0
            TxtGlosaS.Value = String.Empty
            DtpFechaEmisionS.Value = Date.Now()
            DtpFechaVenciminetoS.Value = Date.Now.AddYears(1)
            CmbMonedaS.SelectedIndex = -1
            CmbEmpresaEmisoraS.DataSource = ProveedorPublic
            CmbEmpresaEmisoraS.Value = Nothing
            ''Poliza
            TxtNumeroP.Value = ""
            ndImporteP.Value = 0
            TxtGlosaP.Value = String.Empty
            DtpFechaEmisionP.Value = Date.Now()
            DtpFechaVencimientoP.Value = Date.Now.AddYears(1)
            CmbMonedaP.SelectedIndex = -1
            CmbEmpresaEmisoraP.DataSource = ProveedorPublic
            CmbEmpresaEmisoraP.Value = Nothing
            ndPrimaP.Value = 0
            ndDerEmisionP.Value = 0
            ndIgvP.Value = 0
            ndTotalP.Value = 0
            ''Cuota
            dtp_FechaCuotaIndividual.Value = Date.Now()
            nd_MontoCuotaIndivudual.Value = 0.0
            Txt_DescripCuotaIndividual.Value = ""
            Dtp_FechaInicioCuota.Value = Date.Now()
            nd_NumeroCuotaMasiva.Value = 0
            nd_MontoCuotaMasiva.Value = 0
            ''Docs Referencia
            CmbTipoDocRef.Value = "POLIZA INICIAL"
            NumDocRef.Value = ""
            Dtp_FechaDocRef.Value = Date.Now()
            nd_MontoDocRef.Value = 0
            OptAfecta.Checked = False
            TxtDocRef.Value = ""
            i = 0
            oeDocumentoVehicular.ldCuotaDocVeh.Clear()
            oeDocumentoVehicular.ldDetalleDocVeh.Clear()
            oeDocumentoVehicular.ldDocVeh_Doc.Clear()
            oeDocumentoVehicular.ldDetalleDocVeh = New List(Of e_DetalleDocumentoVehiculo)
            Grid_VehAseS.DataSource = oeDocumentoVehicular.ldDetalleDocVeh
            griVehAseP.DataSource = oeDocumentoVehicular.ldDetalleDocVeh
            Grid_DocRef.DataSource = oeDocumentoVehicular.ldDocVeh_Doc
            griListaCuotas.DataSource = oeDocumentoVehicular.ldCuotaDocVeh
            ListarVehiculos()
            MostrarCuotas()
            ActualizarComboReferencia()
            verDerechoImision.Checked = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Sub ListarVehiculos()
        Try
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "S"
            oeVehiculo.Motriz = -1
            oeVehiculo.Activo = True
            listaVehiculos = olVehiculo.Listar(oeVehiculo)
            listaVehiculosS = listaVehiculos
            listaVehiculosP = listaVehiculos
            Grid_VehiculoS.DataSource = listaVehiculosS
            Grid_VehiculoP.DataSource = listaVehiculosP
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub ListarZ(Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeDocumentoVehicular = New e_DocumentoVehicular
            With griSegurosZ
                oeDocumentoVehicular.TipoOperacion = "Z"
                oeDocumentoVehicular.IdVehiculo = CmbFilTracto.Value
                oeDocumentoVehicular.IdEmpresaEmisora = ""
                oeDocumentoVehicular.IndVigencia = IIf(chk_Vigentes.Checked, True, False)
                oeDocumentoVehicular.TipoDocumento = CmbTipoDocumento.Value
                Dim ds As DataSet = olDocumentoVehicular.ListarDts(oeDocumentoVehicular)
                griSegurosZ.DataSource = ds
                'Me.Cursor = Cursors.WaitCursor
                With griSegurosZ.DisplayLayout
                    .UseFixedHeaders = True
                    .Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griSegurosZ.Rows
                        If Date.Now.AddDays(numDias.Value) > fila.Cells("FechaVencimiento").Value And fila.Cells("FechaVencimiento").Value > Date.Now Then
                            fila.CellAppearance.BackColor = Me.ColorVencimiento.Color
                        End If
                    Next
                    If IndMenu Then
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griSegurosZ.Rows
                            If Date.Now.AddDays(20) <= fila.Cells("FechaVencimiento").Value Then
                                fila.Hidden = True
                            End If
                        Next
                    End If
                    IndMenu = False
                End With
                If griSegurosZ.Rows.Count > 0 Then
                    griSegurosZ.Focus()
                    griSegurosZ.Rows.Item(0).Selected = True
                End If
            End With
            ugb_Espera.Visible = False
            griSegurosZ.Focus()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub EditarSeguro()
        Try
            Inicializar()
            If griSegurosZ.ActiveRow.Cells("IdTipoDocumento").Value = "1CH000000048" Then
                IdentificadorTipo = "1CH000000048"
            ElseIf griSegurosZ.ActiveRow.Cells("IdTipoDocumento").Value = "1CH000000049" Then
                IdentificadorTipo = "1CH000000049"
            End If
            oeDocumentoVehicular.Activo = True
            oeDocumentoVehicular.TipoOperacion = "O"
            oeDocumentoVehicular.Id = griSegurosZ.ActiveRow.Cells("IdDocumento").Value
            oeDocumentoVehicular = olDocumentoVehicular.Obtener(oeDocumentoVehicular)
            oeDocumentoVehicular.TipoOperacion = "A"
            oeDocVeh_Doc.Activo = True
            oeDocVeh_Doc.TipoOperacion = "1"
            oeDocVeh_Doc.IdDocumentoVehicular = oeDocumentoVehicular.Id
            oeDocumentoVehicular.ldDocVeh_Doc = olDocVeh_Doc.Listar(oeDocVeh_Doc)
            oeDetalleDocumentoVehiculo.TipoOperacion = "S"
            oeDetalleDocumentoVehiculo.Id = ""
            oeDetalleDocumentoVehiculo.IdDocumento = oeDocumentoVehicular.Id
            oeDocumentoVehicular.ldDetalleDocVeh = olDetalleDocumentoVehiculo.Listar(oeDetalleDocumentoVehiculo)
            MostrarVehiculos()
            oeCuotaDocumentoVehiculo.TipoOperacion = "1"
            oeCuotaDocumentoVehiculo.Id = ""
            oeCuotaDocumentoVehiculo.IdDocumento = oeDocumentoVehicular.Id
            oeCuotaDocumentoVehiculo.Activo = True
            oeDocumentoVehicular.ldCuotaDocVeh = ol_CuotaDocumentoVehiculo.Listar(oeCuotaDocumentoVehiculo)
            MostrarCuotas()
            If IdentificadorTipo = "1CH000000048" Then
                TxtNumeroP.Value = oeDocumentoVehicular.Numero
                CmbEmpresaEmisoraP.Value = oeDocumentoVehicular.IdEmpresaEmisora
                CmbMonedaP.Value = oeDocumentoVehicular.IdMoneda
                ndImporteP.Value = oeDocumentoVehicular.Importe
                TxtGlosaP.Value = oeDocumentoVehicular.Descripcion
            ElseIf IdentificadorTipo = "1CH000000049" Then
                TxtNumeroS.Value = oeDocumentoVehicular.Numero
                CmbEmpresaEmisoraS.Value = oeDocumentoVehicular.IdEmpresaEmisora
                DtpFechaEmisionS.Value = oeDocumentoVehicular.FechaEmision
                DtpFechaVenciminetoS.Value = oeDocumentoVehicular.FechaVencimiento
                CmbMonedaS.Value = oeDocumentoVehicular.IdMoneda
                NdImporteS.Value = oeDocumentoVehicular.Importe
                TxtGlosaS.Value = oeDocumentoVehicular.Descripcion
            End If
            ActualizarComboReferencia()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Function GuardarSeguro() As Boolean
        Try
            If IdentificadorTipo = "1CH000000049" Then 'Soat
                If ProveedorPublic.Where(Function(i) i.Id = CmbEmpresaEmisoraS.Value).Count = 0 Then Throw New Exception("Seleccione una aseguradora válida")
                oeDocumentoVehicular.IdTipoDocumento = "1CH000000049"
                oeDocumentoVehicular.Numero = TxtNumeroS.Value
                oeDocumentoVehicular.IdEmpresaPropietaria = ""
                oeDocumentoVehicular.Importe = NdImporteS.Value
                oeDocumentoVehicular.Descripcion = TxtGlosaS.Value
                oeDocumentoVehicular.IdMoneda = CmbMonedaS.Value
                oeDocumentoVehicular.IdEmpresaEmisora = CmbEmpresaEmisoraS.Value
                oeDocumentoVehicular.FechaEmision = DtpFechaEmisionS.Value
                oeDocumentoVehicular.FechaVencimiento = DtpFechaVenciminetoS.Value
                oeDocumentoVehicular.UsuarioCreacion = gUsuarioSGI.Id
                oeDocumentoVehicular.ldCuotaDocVeh.Clear()
                For Each obj In oeDocumentoVehicular.ldDetalleDocVeh
                    obj.Prima = 0.0
                    obj.DerEmision = 0.0
                    obj.Igv = 0.0
                    obj.Total = 0.0
                    obj.IndExcluido = False
                    obj.FechaEmision = DtpFechaEmisionS.Value
                    obj.FechaVencimiento = DtpFechaVenciminetoS.Value
                Next
            ElseIf IdentificadorTipo = "1CH000000048" Then 'Poliza
                If ProveedorPublic.Where(Function(i) i.Id = CmbEmpresaEmisoraP.Value).Count = 0 Then Throw New Exception("Seleccione una aseguradora válida")
                oeDocumentoVehicular.IdTipoDocumento = "1CH000000048"
                oeDocumentoVehicular.Numero = TxtNumeroP.Value
                oeDocumentoVehicular.IdEmpresaPropietaria = ""
                oeDocumentoVehicular.Descripcion = TxtGlosaP.Value
                oeDocumentoVehicular.IdMoneda = CmbMonedaP.Value
                oeDocumentoVehicular.Importe = ndImporteP.Value
                oeDocumentoVehicular.Descripcion = TxtGlosaP.Value
                oeDocumentoVehicular.IdMoneda = CmbMonedaP.Value
                oeDocumentoVehicular.IdEmpresaEmisora = CmbEmpresaEmisoraP.Value
                oeDocumentoVehicular.FechaEmision = DtpFechaEmisionP.Value
                oeDocumentoVehicular.FechaVencimiento = DtpFechaVencimientoP.Value
                oeDocumentoVehicular.UsuarioCreacion = gUsuarioSGI.Id
            Else
                Throw New Exception("Ha ocurrido un error interno al guardar")
            End If
            If olDocumentoVehicular.GuardarSeguro(oeDocumentoVehicular) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, tcSeguro, 2)
                Consultar(True)
                griSegurosZ.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Sub ListarVehiculoSeguro()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeDetalleDocumentoVehiculo = New e_DetalleDocumentoVehiculo
            oeDetalleDocumentoVehiculo.TipoOperacion = "E"
            oeDetalleDocumentoVehiculo.Activo = True
            oeDetalleDocumentoVehiculo.IdDocumento = oeDocumentoVehicular.Id
            lstDetalleDocVeh = olDetalleDocumentoVehiculo.Listar(oeDetalleDocumentoVehiculo)
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Menú contextual"
    Private Sub MenuSeguros_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuSeguros.Opening
        Try
            MenuSeguros.Items(0).Visible = True
            MenuSeguros.Items(1).Visible = False
            MenuSeguros.Items(2).Visible = False
            If griSegurosZ.Selected.Rows.Count > 0 Then
                MenuSeguros.Items(1).Visible = True
                MenuSeguros.Items(2).Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub
#End Region

#Region "Detalle Soat"

    Private Sub BtnAgregarS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarS.Click
        Try
            Dim sw As Boolean = False
            For i As Integer = 0 To listaVehiculosS.Count - 1
                If listaVehiculosS.Item(i).Seleccion Then
                    sw = True
                End If
            Next
            If Not sw Then Throw New Exception("Marque por lo menos un Vehiculo para agregarlo a la lista.")
            If listaVehiculosS.Where(Function(i) i.Seleccion = True).Count > 1 Then Throw New Exception("Ha marcado mas de una unidad para SOAT, solo se permite el registro de uno.")
            If Grid_VehAseS.Rows.Count = 1 Then Throw New Exception("Solo se puede agregar una unidad en SOAT")
            AgregarVehiculoS()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnEliminarS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarS.Click
        Try
            Dim sw As Boolean = False
            For i As Integer = 0 To oeDocumentoVehicular.ldDetalleDocVeh.Count - 1
                If oeDocumentoVehicular.ldDetalleDocVeh.Item(i).Seleccion Then
                    sw = True
                End If
            Next
            If Not sw Then Throw New Exception("Marque almenos un vehículo para retirarlo de la lista")
            QuitarVehiculoS()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarVehiculoS()
        Try
            For Each obj As e_Vehiculo In listaVehiculosS.Where(Function(item) item.Seleccion)
                Dim inserta = True
                oeVhAseS = New e_DetalleDocumentoVehiculo
                oeVhAseS.Seleccion = False
                oeVhAseS.IdVehiculo = obj.Id
                oeVhAseS.Placa = obj.Placa
                oeVhAseS.Id = ""
                oeVhAseS.EmpresaPropietaria = obj.EmpresaPropietaria
                oeVhAseS.Prima = 0
                oeVhAseS.DerEmision = 0
                oeVhAseS.Igv = 0
                oeVhAseS.Total = 0
                oeVhAseS.IndExcluido = False
                oeVhAseS.Activo = True
                oeVhAseS.UsuarioCreacion = gUsuarioSGI.Id
                oeVhAseS.FechaEmision = DtpFechaEmisionS.Value
                oeVhAseS.FechaVencimiento = DtpFechaVenciminetoS.Value
                oeVhAseS.NroSerieMotor = obj.NroSerieMotor
                oeVhAseS.NroSerieChasis = obj.NroSerieChasis

                For Each OeDeta As e_DetalleDocumentoVehiculo In oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.IdVehiculo = obj.Id)
                    OeDeta.Seleccion = False
                    OeDeta.Prima = 0
                    OeDeta.DerEmision = 0
                    OeDeta.Igv = 0
                    OeDeta.Total = 0
                    OeDeta.Activo = True
                    OeDeta.FechaEmision = DtpFechaEmisionS.Value
                    OeDeta.FechaVencimiento = DtpFechaVenciminetoS.Value
                    inserta = False
                    Exit For
                Next

                If inserta = True Then
                    oeDocumentoVehicular.ldDetalleDocVeh.Add(oeVhAseS)
                End If
            Next

            Grid_VehAseS.DataSource = oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.Activo = True).ToList
            Grid_VehAseS.DataBind()
            listaVehiculosS.RemoveAll(Function(item) item.Seleccion)
            Grid_VehiculoS.DataBind()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarVehiculoS()
        Try
            For Each obj As e_DetalleDocumentoVehiculo In oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.Seleccion)
                oeVehiculo = New e_Vehiculo
                oeVehiculo.Seleccion = False
                oeVehiculo.Id = obj.IdVehiculo
                oeVehiculo.Placa = obj.Placa
                oeVehiculo.EmpresaPropietaria = obj.EmpresaPropietaria
                oeVehiculo.NroSerieMotor = obj.NroSerieMotor
                oeVehiculo.NroSerieChasis = obj.NroSerieChasis
                listaVehiculosS.Add(oeVehiculo)
                If obj.Id <> "" Then
                    obj.Activo = False
                    obj.Seleccion = False
                End If
            Next
            Grid_VehiculoS.DataSource = listaVehiculosS
            Grid_VehiculoS.DataBind()
            oeDocumentoVehicular.ldDetalleDocVeh.RemoveAll(Function(item) item.Seleccion And item.Id = "")
            Grid_VehAseS.DataSource = oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.Activo = True).ToList
            Grid_VehAseS.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Detalle Poliza"

    Private Sub CalcularPrima()
        Try
            igv = oeIGVGlobal.Porcentaje
            If verDerechoImision.Checked Then
                ndDerEmisionP.Value = 3 / 100 * (ndPrimaP.Value + ndComisionP.Value)
            Else
                ndDerEmisionP.Value = 0
            End If
            ndIgvP.Value = (ndDerEmisionP.Value + ndPrimaP.Value + ndComisionP.Value) * igv
            ndTotalP.Value = ndDerEmisionP.Value + ndIgvP.Value + ndPrimaP.Value + ndComisionP.Value
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ndPrimaP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndPrimaP.ValueChanged
        Try
            CalcularPrima()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub nd_ComisionP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndComisionP.ValueChanged
        Try
            igv = oeIGVGlobal.Porcentaje

            ndDerEmisionP.Value = 3 / 100 * (ndPrimaP.Value + ndComisionP.Value)
            ndIgvP.Value = (ndDerEmisionP.Value + ndPrimaP.Value + ndComisionP.Value) * igv
            ndTotalP.Value = ndDerEmisionP.Value + ndIgvP.Value + ndPrimaP.Value + ndComisionP.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnAgregarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarP.Click
        Try
            Dim sw As Boolean = False
            For i As Integer = 0 To listaVehiculosP.Count - 1
                If listaVehiculosP.Item(i).Seleccion Then
                    sw = True
                    Exit For
                End If
            Next
            If Not sw Then Throw New Exception("Marque por lo menos un Vehiculo para agregarlo a la lista.")
            AgregarVehiculoP()
            CalcularMontoPoliza()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnEliminarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarP.Click
        Try
            Dim sw As Boolean = False
            For i As Integer = 0 To oeDocumentoVehicular.ldDetalleDocVeh.Count - 1
                If oeDocumentoVehicular.ldDetalleDocVeh.Item(i).Seleccion Then
                    sw = True
                    Exit For
                End If
            Next
            If Not sw Then Throw New Exception("Marque almenos un vehículo para retirarlo de la lista")
            QuitarVehiculoP()
            CalcularMontoPoliza()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarVehiculoP()
        Try
            For Each obj As e_Vehiculo In listaVehiculosP.Where(Function(item) item.Seleccion)
                If oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(i) i.Activo = True And i.IdVehiculo = obj.Id And i.IndExcluido = False).Count > 0 Then
                    Throw New Exception("Existe este unidad ya registrada; debe excluir antes para poder reingresarla")
                Else
                    oeVhAseP = New e_DetalleDocumentoVehiculo
                    oeVhAseP.Seleccion = False
                    oeVhAseP.IdVehiculo = obj.Id
                    oeVhAseP.Placa = obj.Placa
                    oeVhAseP.Id = ""
                    oeVhAseP.EmpresaPropietaria = obj.EmpresaPropietaria
                    oeVhAseP.Prima = ndPrimaP.Value
                    oeVhAseP.Comision = ndComisionP.Value
                    oeVhAseP.DerEmision = ndDerEmisionP.Value
                    oeVhAseP.Igv = ndIgvP.Value
                    oeVhAseP.Total = ndTotalP.Value
                    oeVhAseP.IndExcluido = False
                    oeVhAseP.Activo = True
                    oeVhAseP.UsuarioCreacion = gUsuarioSGI.Id
                    oeVhAseP.FechaEmision = DtpFechaEmisionP.Value
                    oeVhAseP.FechaVencimiento = DtpFechaVencimientoP.Value
                    oeVhAseP.FechaExclusion = DtpFechaVencimientoP.Value
                    oeVhAseP.NroSerieMotor = obj.NroSerieMotor
                    oeVhAseP.NroSerieChasis = obj.NroSerieChasis
                    oeVhAseP.IdDocVeh_Doc = CmbDocumentoReferencial.Value
                    oeVhAseP.IdDocVeh_Doc2 = "0"
                    oeDocumentoVehicular.ldDetalleDocVeh.Add(oeVhAseP)
                End If
            Next

            griVehAseP.DataSource = oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.Activo = True).ToList
            griVehAseP.DataBind()
            For Each obj In listaVehiculosP
                obj.Seleccion = False
            Next
            Grid_VehiculoP.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarVehiculoP()
        Try
            oeDocumentoVehicular.ldDetalleDocVeh.RemoveAll(Function(item) item.Seleccion And item.Id = "")
            For Each obj As e_DetalleDocumentoVehiculo In oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.Seleccion = True And item.Id <> "")
                obj.Activo = False
                obj.Seleccion = False
            Next
            griVehAseP.DataSource = oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.Activo = True).ToList
            griVehAseP.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Grid_VehAseP_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griVehAseP.CellChange
        Try
            griVehAseP.UpdateData()
            Select Case e.Cell.Column.Key
                Case "Prima"
                    With griVehAseP.Rows(e.Cell.Row.Index)
                        griVehAseP.ActiveRow.Cells("DerEmision").Value = (griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value) * 0.03
                        griVehAseP.ActiveRow.Cells("Igv").Value = (griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value + ((griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value) * 0.03)) * 0.18
                        griVehAseP.ActiveRow.Cells("Total").Value = griVehAseP.ActiveRow.Cells("Comision").Value + griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("DerEmision").Value + griVehAseP.ActiveRow.Cells("Igv").Value
                    End With
                Case "Comision"
                    With griVehAseP.Rows(e.Cell.Row.Index)
                        griVehAseP.ActiveRow.Cells("DerEmision").Value = (griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value) * 0.03
                        griVehAseP.ActiveRow.Cells("Igv").Value = (griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value + ((griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value) * 0.03)) * 0.18
                        griVehAseP.ActiveRow.Cells("Total").Value = griVehAseP.ActiveRow.Cells("Comision").Value + griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("DerEmision").Value + griVehAseP.ActiveRow.Cells("Igv").Value
                    End With
            End Select
            CalcularMontoPoliza()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_VehAseP_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griVehAseP.AfterCellUpdate
        Try
            griVehAseP.UpdateData()
            Select Case e.Cell.Column.Key
                Case "Prima"
                    With griVehAseP.Rows(e.Cell.Row.Index)
                        griVehAseP.ActiveRow.Cells("DerEmision").Value = (griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value) * 0.03
                        griVehAseP.ActiveRow.Cells("Igv").Value = (griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value + ((griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value) * 0.03)) * 0.18
                        griVehAseP.ActiveRow.Cells("Total").Value = griVehAseP.ActiveRow.Cells("Comision").Value + griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("DerEmision").Value + griVehAseP.ActiveRow.Cells("Igv").Value
                    End With
                Case "Comision"
                    With griVehAseP.Rows(e.Cell.Row.Index)
                        griVehAseP.ActiveRow.Cells("DerEmision").Value = (griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value) * 0.03
                        griVehAseP.ActiveRow.Cells("Igv").Value = (griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value + ((griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("Comision").Value) * 0.03)) * 0.18
                        griVehAseP.ActiveRow.Cells("Total").Value = griVehAseP.ActiveRow.Cells("Comision").Value + griVehAseP.ActiveRow.Cells("Prima").Value + griVehAseP.ActiveRow.Cells("DerEmision").Value + griVehAseP.ActiveRow.Cells("Igv").Value
                    End With
            End Select
            CalcularMontoPoliza()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CalcularMontoPoliza()
        Try
            ndImporteP.Value = oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(i) i.Activo = True).Sum(Function(y) y.Total)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Documento Vehicular Documento"

    Private Sub BtnAgregaDocRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaDocRef.Click
        Try
            If oeDocumentoVehicular.ldDocVeh_Doc.Where(Function(i) i.Activo = True And i.Numero = Trim(NumDocRef.Value.ToString)).Count > 0 Then
                Throw New Exception("Ya existe un documento agregado con el mismo código")
            End If
            If Trim(NumDocRef.Value) = "" Then Throw New Exception("Ingrese código al documento")
            If Dtp_FechaDocRef.Value > Date.Now() Then Throw New Exception("Ingrese una fecha válida al documento de referencia")
            If CmbTipoDocRef.Value = "" Then Throw New Exception("Especifique el tipo de documento")
            AgregarDocumentoReferencia()
            ActualizarComboReferencia()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnQuitaDocRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaDocRef.Click
        Try
            If Grid_DocRef.Rows.Count = 0 Then
                Throw New Exception("No existe ninguna fila para eliminar")
            End If
            If oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(i) i.IdDocVeh_Doc = Grid_DocRef.ActiveRow.Cells("Id").Value And i.Activo = True).ToList.Count > 0 Then
                Throw New Exception("Este documento esta siendo utilizado como detalle en una Placa de poliza")
            End If
            If oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(i) i.IdDocVeh_Doc2 = Grid_DocRef.ActiveRow.Cells("Id").Value And i.Activo = True).ToList.Count > 0 Then
                Throw New Exception("Este documento esta siendo utilizado como detalle en una Placa de poliza")
            End If
            QuitarDocumentoReferencia()
            ActualizarComboReferencia()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarDocumentoReferencia()
        Try
            If oeDocumentoVehicular.ldDocVeh_Doc.Where(Function(i) i.Numero = Trim(NumDocRef.Value)).Count > 0 Then
                Dim oe As New e_DocumentoVehicular_Documento
                oe = oeDocumentoVehicular.ldDocVeh_Doc.Item(oeDocumentoVehicular.ldDocVeh_Doc.IndexOf(oeDocVeh_Doc))
                oe.Activo = True
                oe.Tipo = CmbTipoDocRef.Value
                oe.Numero = NumDocRef.Value
                oe.Fecha = Dtp_FechaDocRef.Value
                oe.AfectaPoliza = OptAfecta.Checked
                oe.Glosa = TxtDocRef.Value
                oe.Monto = nd_MontoDocRef.Value
                oe.Saldo = nd_MontoDocRef.Value
            Else
                i = i + 1
                oeDocVeh_Doc = New e_DocumentoVehicular_Documento
                oeDocVeh_Doc.Id = (i).ToString
                oeDocVeh_Doc.IdDocumentoVehicular = oeDocumentoVehicular.Id
                oeDocVeh_Doc.Activo = True
                oeDocVeh_Doc.Tipo = CmbTipoDocRef.Value
                oeDocVeh_Doc.Numero = NumDocRef.Value
                oeDocVeh_Doc.Fecha = Dtp_FechaDocRef.Value
                oeDocVeh_Doc.AfectaPoliza = OptAfecta.Checked
                oeDocVeh_Doc.Glosa = TxtDocRef.Value
                oeDocVeh_Doc.Monto = nd_MontoDocRef.Value
                oeDocVeh_Doc.Saldo = nd_MontoDocRef.Value
                oeDocumentoVehicular.ldDocVeh_Doc.Add(oeDocVeh_Doc)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDocumentoReferencia()
        Try
            Dim oeDocVeh_Doc = New e_DocumentoVehicular_Documento
            oeDocVeh_Doc.Numero = Grid_DocRef.ActiveRow.Cells("Numero").Value
            If Len((Grid_DocRef.ActiveRow.Cells("Id").Value)) = 12 Then
                Dim oe As New e_DocumentoVehicular_Documento
                oe = oeDocumentoVehicular.ldDocVeh_Doc.Item(oeDocumentoVehicular.ldDocVeh_Doc.IndexOf(oeDocVeh_Doc))
                oe.Activo = False
            Else
                oeDocumentoVehicular.ldDocVeh_Doc.Remove(oeDocVeh_Doc)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ActualizarComboReferencia()
        Try
            Grid_DocRef.DataSource = oeDocumentoVehicular.ldDocVeh_Doc.Where(Function(i) i.Activo = True).ToList
            Grid_DocRef.DataBind()
            ListaCombo = New List(Of e_DocumentoVehicular_Documento)
            Dim oe As New e_DocumentoVehicular_Documento
            oe.Numero = "--"
            oe.Id = "0"
            ListaCombo.Add(oe)
            ListaCombo.AddRange(oeDocumentoVehicular.ldDocVeh_Doc.Where(Function(i) i.Activo = True).ToList)
            LlenarCombo(CmbDocumentoReferencial, "Numero", ListaCombo, 0)
            LlenarCombo(CmbDocRefCuotaIndividual, "Numero", ListaCombo, 0)
            LlenarCombo(CmbDocRefCuotaMasiva, "Numero", ListaCombo, 0)

            CrearComboGrid("IdDocVeh_Doc", "Nombre", griVehAseP, olDocVeh_Doc.ComboGrilla(ListaCombo), True)
            CrearComboGrid("IdDocVeh_Doc2", "Nombre", griVehAseP, olDocVeh_Doc.ComboGrilla(ListaCombo), True)
            CrearComboGrid("IdDocVeh_Doc", "Nombre", griListaCuotas, olDocVeh_Doc.ComboGrilla(ListaCombo), True)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Cuota de Documento"

    Private Sub BtnGenerarCuota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerarCuota.Click
        Try
            Dim MontoCuota As Double = 0.0
            Dim NroCuota As Integer = 0
            If nd_MontoCuotaMasiva.Value > 0.0 Then
                If nd_NumeroCuotaMasiva.Value > 0 Then
                    MontoCuota = nd_MontoCuotaMasiva.Value / nd_NumeroCuotaMasiva.Value
                    NroCuota = nd_NumeroCuotaMasiva.Value
                    y = y + 1
                    For Me.i = 0 To NroCuota - 1
                        Dim inserta As Integer = 0
                        Dim oeCuota As New e_CuotaDocumentoVehiculo
                        oeCuota.Id = ""
                        oeCuota.IdDocumento = ""
                        oeCuota.Fecha = Date.Parse(Dtp_FechaInicioCuota.Value).AddMonths(i)
                        oeCuota.Monto = MontoCuota
                        oeCuota.SaldoAdministrativo = MontoCuota
                        oeCuota.SaldoContable = MontoCuota
                        oeCuota.Glosa = "CUPON " + y.ToString + "/" + (i + 1).ToString
                        oeCuota.Activo = True
                        oeCuota.IdDocVeh_Doc = CmbDocRefCuotaMasiva.Value
                        For Each objl In oeDocumentoVehicular.ldCuotaDocVeh
                            If (objl.Glosa = oeCuota.Glosa And objl.Activo = True) Then
                                inserta = 1
                                Throw New Exception("Este cupón ya fue asignado")
                                Exit For
                            ElseIf (objl.Glosa = oeCuota.Glosa And objl.Activo = False) Then
                                objl.Monto = oeCuota.Monto
                                objl.SaldoAdministrativo = oeCuota.Monto
                                objl.SaldoContable = oeCuota.Monto
                                objl.Activo = True
                                objl.Glosa = oeCuota.Glosa
                                objl.IdDocVeh_Doc = CmbDocRefCuotaMasiva.Value
                                inserta = 1
                                Exit For
                            End If
                        Next
                        If inserta = 0 Then
                            oeDocumentoVehicular.ldCuotaDocVeh.Add(oeCuota)
                        End If
                        MostrarCuotas()
                    Next
                Else
                    Throw New Exception("Nro de Cuotas debe ser 1 o mayor que este")
                End If
            Else
                Throw New Exception("No se pueden calcular cuotas a un importa inválido")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnAgregaCuotaIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaCuotaIndividual.Click
        Try
            Dim inserta As Integer = 0
            Dim oeCuota As New e_CuotaDocumentoVehiculo
            oeCuota.Id = ""
            oeCuota.IdDocumento = ""
            oeCuota.Fecha = Date.Parse(dtp_FechaCuotaIndividual.Value)
            oeCuota.Monto = nd_MontoCuotaIndivudual.Value
            oeCuota.SaldoContable = nd_MontoCuotaIndivudual.Value
            oeCuota.SaldoAdministrativo = nd_MontoCuotaIndivudual.Value
            oeCuota.Glosa = Txt_DescripCuotaIndividual.Value
            oeCuota.IdDocVeh_Doc = CmbDocRefCuotaIndividual.Value
            oeCuota.Activo = True
            For Each objl In oeDocumentoVehicular.ldCuotaDocVeh
                If (objl.Glosa = oeCuota.Glosa And objl.Activo = True) Then
                    inserta = 1
                    Throw New Exception("Ya existe este cupón asignado.")
                    Exit For
                ElseIf (objl.Glosa = oeCuota.Glosa And objl.Activo = False) Then
                    objl.Monto = oeCuota.Monto
                    objl.Activo = True
                    objl.Glosa = oeCuota.Glosa
                    inserta = 1
                End If
            Next
            If inserta = 0 Then
                oeDocumentoVehicular.ldCuotaDocVeh.Add(oeCuota)
            End If
            MostrarCuotas()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnQuitaCuotaIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaCuotaIndividual.Click
        Try
            EliminarCuota()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarCuota()
        Try
            If griListaCuotas.Rows.Count > 0 Then
                Dim MontoCuota As Double = griListaCuotas.ActiveRow.Cells("Monto").Value
                Dim SaldoAdministrativo As Double = griListaCuotas.ActiveRow.Cells("SaldoAdministrativo").Value
                Dim SaldoContable As Double = griListaCuotas.ActiveRow.Cells("SaldoContable").Value
                If (MontoCuota = SaldoAdministrativo) Then
                    If (MontoCuota = SaldoContable) Then
                        Dim oeCuotaDocumentoVehiculo = New e_CuotaDocumentoVehiculo
                        oeCuotaDocumentoVehiculo.Glosa = griListaCuotas.ActiveRow.Cells("Glosa").Value
                        oeCuotaDocumentoVehiculo.Id = griListaCuotas.ActiveRow.Cells("Id").Value
                        If griListaCuotas.ActiveRow.Cells("Id").Value = "" Then
                            oeDocumentoVehicular.ldCuotaDocVeh.Remove(oeCuotaDocumentoVehiculo)
                        Else
                            Dim oe As New e_CuotaDocumentoVehiculo
                            oe = oeDocumentoVehicular.ldCuotaDocVeh.Item(oeDocumentoVehicular.ldCuotaDocVeh.IndexOf(oeCuotaDocumentoVehiculo))
                            oe.Activo = False
                        End If
                        MostrarCuotas()
                    Else
                        Throw New Exception("Cuota ya tiene pagos Administrativos/Contables asociados.")
                    End If
                End If
            Else
                Throw New Exception("No existe ninguna fila para eliminar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub MostrarCuotas()
        Try
            griListaCuotas.DataSource = oeDocumentoVehicular.ldCuotaDocVeh.Where(Function(item) item.Activo = True).ToList
            griListaCuotas.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CmbDocRefCuotaMasiva_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDocRefCuotaMasiva.ValueChanged
        If CmbDocRefCuotaMasiva.Value = "0" Then
            nd_MontoCuotaMasiva.Value = 0.0
        Else
            nd_MontoCuotaMasiva.Value = oeDocumentoVehicular.ldDocVeh_Doc.Where(Function(i) i.Id = CmbDocRefCuotaMasiva.Value).ToList.Item(0).Monto()
        End If
    End Sub

    Private Sub Grid_ListaCuotas_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCuotas.CellChange
        Dim MensajeError As Boolean = False
        Try
            If Len(griListaCuotas.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                If griListaCuotas.ActiveRow.Cells("Monto").Value <> griListaCuotas.ActiveRow.Cells("SaldoContable").Value Then
                    MensajeError = True
                End If
                If griListaCuotas.ActiveRow.Cells("Monto").Value <> griListaCuotas.ActiveRow.Cells("SaldoAdministrativo").Value Then
                    MensajeError = True
                End If
            End If
            If MensajeError Then
                griListaCuotas.ActiveRow.Cells("Monto").Value = Monto
                Throw New Exception("No editable,Ya existen pagos asociados")
            Else
                griListaCuotas.UpdateData()
                griListaCuotas.ActiveRow.Cells("SaldoContable").Value = griListaCuotas.ActiveRow.Cells("Monto").Value
                griListaCuotas.ActiveRow.Cells("SaldoAdministrativo").Value = griListaCuotas.ActiveRow.Cells("Monto").Value
            End If
            griListaCuotas.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

    Private Sub CmbEmpresaEmisoraS_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles CmbEmpresaEmisoraS.InitializeLayout
        Try
            With CmbEmpresaEmisoraS.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Descripcion").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 350
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CmbEmpresaEmisoraS_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbEmpresaEmisoraS.KeyDown
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If CmbEmpresaEmisoraS.Text.Trim = "" Then
                    CmbEmpresaEmisoraS.DataSource = Nothing
                    CmbEmpresaEmisoraS.DataSource = ProveedorPublic
                Else
                    CmbEmpresaEmisoraS.DataSource = Nothing
                    CmbEmpresaEmisoraS.DataSource = ProveedorPublic.Where(Function(Item) Item.Nombre.Contains(CmbEmpresaEmisoraS.Text.Trim)).ToList
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CmbEmpresaEmisoraP_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles CmbEmpresaEmisoraP.InitializeLayout
        Try
            With CmbEmpresaEmisoraP.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Descripcion").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 350
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CmbEmpresaEmisoraP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEmpresaEmisoraP.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            CmbEmpresaEmisoraP.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub CmbEmpresaEmisoraP_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbEmpresaEmisoraP.KeyDown
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If CmbEmpresaEmisoraP.Text.Trim = "" Then
                    CmbEmpresaEmisoraP.DataSource = Nothing
                    CmbEmpresaEmisoraP.DataSource = ProveedorPublic
                Else
                    CmbEmpresaEmisoraP.DataSource = Nothing
                    CmbEmpresaEmisoraP.DataSource = ProveedorPublic.Where(Function(Item) Item.Nombre.Contains(CmbEmpresaEmisoraP.Text.Trim)).ToList
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CmbEmpresaEmisoraS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEmpresaEmisoraS.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            CmbEmpresaEmisoraS.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub verDerechoImision_CheckedChanged(sender As Object, e As EventArgs) Handles verDerechoImision.CheckedChanged
        CalcularPrima()
    End Sub

    Private Sub Grid_ListaCuotas_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griListaCuotas.ClickCell
        Try
            Select Case e.Cell.Column.Key
                Case "Monto"
                    Monto = griListaCuotas.ActiveRow.Cells("Monto").Value
                    SaldoAdministrativo = griListaCuotas.ActiveRow.Cells("SaldoAdministrativo").Value
                    SaldoContable = griListaCuotas.ActiveRow.Cells("SaldoContable").Value
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Grid_VehiculoP_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_VehiculoP.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griVehAseP_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griVehAseP.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub Grid_DocRef_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_DocRef.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaCuotas_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaCuotas.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub Grid_VehiculoS_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_VehiculoS.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub Grid_VehAseS_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_VehAseS.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griSegurosZ_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griSegurosZ.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub frm_Seguros2_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub
End Class
