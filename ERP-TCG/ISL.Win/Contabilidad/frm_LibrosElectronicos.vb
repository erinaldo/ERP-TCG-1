'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb
Imports System
Imports System.IO
Imports System.Collections

Public Class frm_LibrosElectronicos
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_LibrosElectronicos = Nothing
    Private Shared Operacion As String
    Private Estado As String

    Public Overrides Function getInstancia() As frm_MenuPadre

        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_LibrosElectronicos()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim _ingresando_datos As Boolean = False

    Dim olCombo As New l_Combo
    Dim oeCombo As New e_Combo
    Dim ListaLibros As New List(Of e_Combo)
    Dim ListaCuenta As New List(Of e_Combo)

    Private oeTipoAsiento As New e_TablaContableDet
    Private loTipoAsiento As New l_TablaContableDet

    Dim oeLibroElectronico As New e_LibroElectronico
    Dim olLibroElectronico As New l_LibroElectronico

    Dim oeDetalleLE As New e_DetalleLibroElectronico
    Dim olDetalleLE As New l_DetalleLibroElectronico

    Dim leDetalleLE As New List(Of e_DetalleLibroElectronico)
    Dim leDetalleLeValidada As New List(Of e_DetalleLibroElectronico)

    Public _CadPeriodo As String = ""
    Private lstTipoRenta As New List(Of e_Combo)

    Private oeInventarioFiltro As e_DetalleLibroElectronico, leInventarioFiltro As List(Of e_DetalleLibroElectronico)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Operacion = "Inicializa"
        Try
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Nuevo"
            Inicializar()
            LimpiaGrid(griDetalleCompras, ogdDetalleLibroElectronico)
            LimpiaGrid(griDetalleVentas, ogdDetalleLibroElectronico)
            LimpiaGrid(griDetalleDiario, ogdDetalleLibroElectronico)
            LimpiaGrid(griDetalleMayor, ogdDetalleLibroElectronico)
            LimpiaGrid(griDetalleDiarioPlanContable, ogdDetalleLibroElectronico)
            LimpiaGrid(gridInventario, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv10, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv12, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv14, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv16, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv19, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv20, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv30, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv34, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv37, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv41, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv42, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv46, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv47, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv50, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvParticionaria, ogdDetalleLibroElectronico)
            webNotas.Navigate("about:blank")
            LimpiaGrid(griInvBC, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvEFEMD, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvER, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvECPN, ogdDetalleLibroElectronico)
            LimpiaGrid(gridPermanenteUF, ogdDetalleLibroElectronico)
            LimpiaGrid(griPermanenteValorizado, ogdDetalleLibroElectronico)
            LimpiaGrid(gridActivoFijo, ogdDetalleLibroElectronico)
            LimpiaGrid(griAct73, ogdDetalleLibroElectronico)
            LimpiaGrid(griAct74, ogdDetalleLibroElectronico)
            MostrarTabs(1, ficLibroElectronico, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            oeLibroElectronico.TipoOperacion = "I"
            ugb_Espera.Visible = False
            ControlBotoneria()
            cboLibroGuarda.Focus()
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Public Overrides Sub Editar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Inicializar()
            LimpiaGrid(griDetalleCompras, ogdDetalleLibroElectronico)
            LimpiaGrid(griDetalleVentas, ogdDetalleLibroElectronico)
            LimpiaGrid(griDetalleDiario, ogdDetalleLibroElectronico)
            LimpiaGrid(griDetalleMayor, ogdDetalleLibroElectronico)
            LimpiaGrid(griDetalleDiarioPlanContable, ogdDetalleLibroElectronico)
            LimpiaGrid(gridInventario, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv10, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv12, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv14, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv16, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv19, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv20, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv30, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv34, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv37, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv41, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv42, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv46, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv47, ogdDetalleLibroElectronico)
            LimpiaGrid(griInv50, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvParticionaria, ogdDetalleLibroElectronico)
            webNotas.Navigate("about:blank")
            LimpiaGrid(griInvBC, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvEFEMI, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvECPN, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvER, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvERI, ogdDetalleLibroElectronico)
            LimpiaGrid(griInvEFEMD, ogdDetalleLibroElectronico)
            LimpiaGrid(gridPermanenteUF, ogdDetalleLibroElectronico)
            LimpiaGrid(griPermanenteValorizado, ogdDetalleLibroElectronico)
            LimpiaGrid(gridActivoFijo, ogdDetalleLibroElectronico)
            LimpiaGrid(griAct73, ogdDetalleLibroElectronico)
            LimpiaGrid(griAct74, ogdDetalleLibroElectronico)
            If EditarLibro() Then
                MostrarTabs(1, ficLibroElectronico, 1)
                Operacion = "Editar"
                ControlBotoneria()
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarLibro() Then
                MostrarTabs(0, ficLibroElectronico, 2)
            Else
                MostrarTabs(1, ficLibroElectronico, 1)
            End If
            ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MostrarTabs(0, ficLibroElectronico, 2)
            _ingresando_datos = False
            Operacion = "Inicializa"
            ControlBotoneria()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        griLista.ActiveRow.Delete()
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'If leDetalleLeValidada.Count = 0 Then Throw New Exception("Tiene Que Validar el Libro Antes de Imprimirlo")
            Dim frm As New frm_ImprimeLibroElectronico
            Select Case tabDetalleLibros.SelectedTab.Index
                Case 10
                    Dim Cont As Integer = 0
                    Dim IndMat As Boolean = False
                    For Each oe As e_DetalleLibroElectronico In leDetalleLE
                        IndMat = False
                        oe.TipoDocumentoAso = CStr(dtp_FechaGuarda.Value.Year) + FormatoDocumento(cboMesGuarda.Text, 2) + "00"
                        oe.SerieAso = ISL_RUC
                        oe.NumeroDocAso = ISL_Nombre
                        If Cont > 0 Then
                            If oe.CodConvenio.Trim = leDetalleLE.Item(Cont - 1).CodConvenio.Trim Then IndMat = True
                            oe.SubTotal3 = IIf(IndMat, leDetalleLE.Item(Cont - 1).SubTotal3 + oe.SubTotal1 + oe.SubTotal2, oe.SubTotal1 + oe.SubTotal2)
                        Else
                            oe.SubTotal3 = oe.SubTotal1
                        End If
                        If IsNumeric(oe.SerieDoc) Then
                            If CInt(oe.SerieDoc) = 0 Then oe.SerieDoc = String.Empty
                        End If
                        If IsNumeric(oe.NumeroDoc) Then
                            If CInt(oe.NumeroDoc) = 0 Then oe.NumeroDoc = String.Empty
                        End If
                        Cont += 1
                    Next
                    frm.CargarDatos(leDetalleLE, 0)
                    frm.ShowDialog()
                Case 11
                    For Each oe As e_DetalleLibroElectronico In leDetalleLE
                        oe.TipoDocumentoAso = CStr(dtp_FechaGuarda.Value.Year) + FormatoDocumento(cboMesGuarda.Text, 2) + "00"
                        oe.SerieAso = ISL_RUC
                        oe.NumeroDocAso = ISL_Nombre
                        oe.NumeroDocAso2 = "PROMEDIO PONDERADO"
                        If IsNumeric(oe.SerieDoc) Then
                            If CInt(oe.SerieDoc) = 0 Then oe.SerieDoc = String.Empty
                        End If
                        If IsNumeric(oe.NumeroDoc) Then
                            If CInt(oe.NumeroDoc) = 0 Then oe.NumeroDoc = String.Empty
                        End If
                    Next
                    frm.CargarDatos(leDetalleLE, 1)
                    frm.ShowDialog()
            End Select
            ControlBotoneria()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficLibroElectronico.SelectedTab.Index
                Case 0
                    If griLista.Rows.Count = 0 Then Throw New Exception("No hay ninguna Demanda Rápida para exportar al Excel")
                    Exportar_Excel(griLista)
                Case 1
                    Select Case tabDetalleLibros.SelectedTab.Index
                        Case 1 ' Libro Inventario y Balances
                            Select Case ficInventarioBalance.SelectedTab.Index
                                Case 0 : ExportarGrillaAExcel(gridInventario, "31-EstadoSituacionFinanciera")
                                Case 1 : ExportarGrillaAExcel(griInv10, "32-Cuenta10")
                                Case 2 : ExportarGrillaAExcel(griInv12, "33-Cuenta12-13")
                                Case 3 : ExportarGrillaAExcel(griInv14, "34-Cuenta14")
                                Case 4 : ExportarGrillaAExcel(griInv16, "35-Cuenta16-17")
                                Case 5 : ExportarGrillaAExcel(griInv19, "36-Cuenta19")
                                Case 6 : ExportarGrillaAExcel(griInv20, "37-Cuenta20-21")
                                Case 7 : ExportarGrillaAExcel(griInv30, "38-Cuenta30")
                                Case 8 : ExportarGrillaAExcel(griInv34, "39-Cuenta34")
                                Case 9 : ExportarGrillaAExcel(griInv41, "311-Cuenta41")
                                Case 10 : ExportarGrillaAExcel(griInv42, "312-Cuenta42-43")
                                Case 11 : ExportarGrillaAExcel(griInv46, "313-Cuenta46-47")
                                Case 12 : ExportarGrillaAExcel(griInv47, "314-Cuenta47")
                                Case 13 : ExportarGrillaAExcel(griInv37, "315-Cuenta37")
                                Case 14 : ExportarGrillaAExcel(griInv50, "3161-Cuenta50")
                                Case 15 : ExportarGrillaAExcel(griInvParticionaria, "3162-Participaciones")
                                Case 16 : ExportarGrillaAExcel(griInvBC, "317-BalanceComprobacion")
                                Case 17 : ExportarGrillaAExcel(griInvEFEMD, "318-FlujoEfectivoDirecto")
                                Case 18 : ExportarGrillaAExcel(griInvECPN, "319-CambioPatrimonioNeto")
                                Case 19 : ExportarGrillaAExcel(griInvER, "320-EstadoResultado")
                                Case 21 : ExportarGrillaAExcel(griInvERI, "324-EstadoResultadoIntegrales")
                                Case 22 : ExportarGrillaAExcel(griInvEFEMI, "325-FlujoEfectivoIndirecto")
                            End Select
                        Case 6 ' Libro Activo Fijos
                            Select Case ficActivoFijo.SelectedTab.Index
                                Case 0 : ExportarGrillaAExcel(gridActivoFijo, "71-ActivoFijo")
                                Case 1 : ExportarGrillaAExcel(griAct73, "73-DiferenciaTipoCambio")
                                Case 2 : ExportarGrillaAExcel(griAct74, "74-ActivoFijoModalidadArrendamiento")
                            End Select
                        Case 10

                        Case 11
                            Exportar_Excel(griPermanenteValorizado)
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_LibrosElectronicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            gmt_ConfigurarEventoKeyEnter_Tab(Me, btnDetalleLibro.Name)
            LlenaCombos()
            MostrarTabs(0, ficLibroElectronico, 2)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            'Combo Grilla Tipo de Renta
            oeCombo = New e_Combo
            oeCombo.Id = "TipoRenta"
            oeCombo.Nombre = "TIPO DE RENTA"
            lstTipoRenta.Clear()
            lstTipoRenta.AddRange(olCombo.Listar(oeCombo))
            CrearComboGrid("CodTipoRenta", "Nombre", griCompras2, olCombo.ComboGrilla(lstTipoRenta), False)
            ConfigurarGrillaValorizado()
            ConfigurarGrillaUnidades()
            ComboPerido(cboMesLista, dtpEjercicioLista.Value.Year)
            ComboPerido(cboMesGuarda, dtp_FechaGuarda.Value.Year)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_LibrosElectronicos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_LibrosElectronicos_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ControlBotoneria()
    End Sub

    Private Sub frm_LibrosElectronicos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_LibrosElectronicos_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub dtp_FechaGuarda_Validated(sender As Object, e As EventArgs) Handles dtp_FechaGuarda.Validated
        ComboPerido(cboMesGuarda, dtp_FechaGuarda.Value.Year)
        Select Case tabDetalleLibros.SelectedTab.Index
            Case 1

            Case 2

            Case 3

            Case 4

            Case 5
                oeCombo = New e_Combo
                oeCombo.Id = dtp_FechaGuarda.Value.Year
                oeCombo.Nombre = "CuentaContable"
                ListaCuenta = New List(Of e_Combo)
                ListaCuenta.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
                LlenarComboMaestro(cboCuentaInicial, ListaCuenta, 0)
                LlenarComboMaestro(cboCuentaFinal, ListaCuenta.OrderByDescending(Function(Item) Item.Nombre).ToList, 0)
            Case 6

            Case 7

            Case 8

            Case 9

        End Select
    End Sub

    Private Sub dtpEjercicioLista_Validated(sender As Object, e As EventArgs) Handles dtpEjercicioLista.Validated
        ComboPerido(cboMesLista, dtpEjercicioLista.Value.Year)
    End Sub

    Private Sub dtpEjercicioLista_ValueChanged(sender As Object, e As EventArgs) Handles dtpEjercicioLista.ValueChanged
        ComboPerido(cboMesLista, dtpEjercicioLista.Value.Year)
    End Sub

    Private Sub griDetalleCompras_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDetalleCompras.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griDetalleVentas_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDetalleVentas.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub btnDetalleLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleLibro.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ValidaPeridoDeclarado() Then
                leDetalleLE = New List(Of e_DetalleLibroElectronico)
                oeDetalleLE = New e_DetalleLibroElectronico
                oeDetalleLE.IdPeriodo = cboMesGuarda.Value
                oeDetalleLE._Ejercicio = dtp_FechaGuarda.Value.Year.ToString
                oeDetalleLE._Mes = FormatoDocumento(cboMesGuarda.Text, 2)
                oeDetalleLE.Año = dtp_FechaGuarda.Value.Year
                oeDetalleLE.PrefijoID = gs_PrefijoIdSucursal '@0001
                Select Case cboLibroGuarda.Text
                    Case "REGISTRO DE COMPRAS"
                        oeDetalleLE.TipoOperacion = "C"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griDetalleCompras.DataSource = leDetalleLE.Where(Function(x) x.IndClienteProveedor <> "2").ToList()
                        griCompras2.DataSource = leDetalleLE.Where(Function(x) x.IndClienteProveedor = "2").ToList()
                        CalcularTotales(griDetalleCompras, "SubTotal1", "IGV1", "NoGravada", "Total")
                        CalcularTotales(griCompras2, "SubTotal1", "IGV1", "NoGravada", "Total")
                        decSubTotal1.Value = leDetalleLE.Sum(Function(it) it.SubTotal1)
                        decSubTotal2.Value = leDetalleLE.Sum(Function(it) it.IGV1)
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        decSubTotal4.Value = leDetalleLE.Sum(Function(it) it.NoGravada)
                    Case "REGISTRO DE VENTAS E INGRESOS"
                        oeDetalleLE.TipoOperacion = "V"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griDetalleVentas.DataSource = leDetalleLE
                        CalcularTotales(griDetalleVentas, "IGV1", "IGV3", "NoGravada", "Total")
                        decSubTotal1.Value = leDetalleLE.Sum(Function(it) it.IGV1)
                        decSubTotal2.Value = leDetalleLE.Sum(Function(it) it.IGV3)
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        decSubTotal4.Value = leDetalleLE.Sum(Function(it) it.NoGravada)
                    Case "LIBRO DIARIO"
                        oeDetalleLE.TipoOperacion = "D"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griDetalleDiario.DataSource = leDetalleLE
                        CalcularTotales(griDetalleDiario, "SubTotal1", "SubTotal2")
                        decSubTotal1.Value = leDetalleLE.Sum(Function(it) it.SubTotal1)
                        decSubTotal2.Value = leDetalleLE.Sum(Function(it) it.SubTotal2)
                        oeDetalleLE = New e_DetalleLibroElectronico
                        With oeDetalleLE
                            .TipoOperacion = "DPC"
                            ._Ejercicio = dtp_FechaGuarda.Value.Year.ToString
                            ._Mes = FormatoDocumento(cboMesGuarda.Text, 2)
                        End With
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griDetalleDiarioPlanContable.DataSource = leDetalleLE
                    Case "LIBRO MAYOR"
                        oeDetalleLE.TipoOperacion = "M"
                        If cboCuentaInicial.Text.Trim = "" Then
                            Throw New Exception("Seleccionar Cuenta Inicial para este libro.")
                        End If
                        If cboCuentaFinal.Text.Trim = "" Then
                            Throw New Exception("Seleccionar Cuenta Final para este libro.")
                        End If
                        oeDetalleLE.CuentaInicial = cboCuentaInicial.Text
                        oeDetalleLE.CuentaFinal = cboCuentaFinal.Text

                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griDetalleMayor.DataSource = leDetalleLE
                        CalcularTotales(griDetalleMayor, "SubTotal1", "SubTotal2")
                        decSubTotal1.Value = leDetalleLE.Sum(Function(it) it.SubTotal1)
                        decSubTotal2.Value = leDetalleLE.Sum(Function(it) it.SubTotal2)
                    Case "LIBRO DE INVENTARIOS Y BALANCES"
                        oeDetalleLE.TipoOperacion = "31"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        gridInventario.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        ' Inventario Cuenta 10
                        oeDetalleLE.TipoOperacion = "32"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv10.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.SubTotal1)
                        ' Inventario Cuenta 12
                        oeDetalleLE.TipoOperacion = "33"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv12.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        ' Inventario Cuenta 14
                        oeDetalleLE.TipoOperacion = "34"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv14.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        ' Inventario Cuenta 16
                        oeDetalleLE.TipoOperacion = "35"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv16.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        ' Inventario Cuenta 19
                        oeDetalleLE.TipoOperacion = "36"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv19.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        ' Inventario Cuenta 20
                        oeDetalleLE.TipoOperacion = "37"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv20.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.SubTotal3)
                        ' Inventario Cuenta 30
                        oeDetalleLE.TipoOperacion = "38"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv30.DataSource = leDetalleLE
                        decSubTotal3.Value = 0
                        ' Inventario Cuenta 34
                        oeDetalleLE.TipoOperacion = "39"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv34.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.SubTotal1)
                        ' Inventario Cuenta 41
                        oeDetalleLE.TipoOperacion = "311"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv41.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        ' Inventario Cuenta 42
                        oeDetalleLE.TipoOperacion = "312"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv42.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        ' Inventario Cuenta 46
                        oeDetalleLE.TipoOperacion = "313"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv46.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        ' Inventario Cuenta 47
                        oeDetalleLE.TipoOperacion = "314"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv47.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.Total)
                        ' Inventario Cuenta 37
                        oeDetalleLE.TipoOperacion = "315"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv37.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.SubTotal1)
                        ' Inventario Cuenta 50
                        oeDetalleLE.TipoOperacion = "3161"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInv50.DataSource = leDetalleLE
                        decSubTotal3.Value = leDetalleLE.Sum(Function(it) it.SubTotal1)
                        ' Inventario Participacion
                        oeDetalleLE.TipoOperacion = "3162"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInvParticionaria.DataSource = leDetalleLE
                        decSubTotal3.Value = 0
                        ' Balance de Comprobacion
                        oeDetalleLE.TipoOperacion = "317"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInvBC.DataSource = leDetalleLE
                        ' Estado de Flujo de Efectivo
                        oeDetalleLE.TipoOperacion = "318"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInvEFEMD.DataSource = leDetalleLE
                        ' Estado de Flujo de Efectivo
                        oeDetalleLE.TipoOperacion = "319"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInvECPN.DataSource = leDetalleLE
                        ' Estado de Flujo de Efectivo
                        oeDetalleLE.TipoOperacion = "320"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInvER.DataSource = leDetalleLE
                        ' Estado de Flujo de Efectivo
                        oeDetalleLE.TipoOperacion = "324"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInvERI.DataSource = leDetalleLE
                        ' Estado de Flujo de Efectivo
                        oeDetalleLE.TipoOperacion = "325"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griInvEFEMI.DataSource = leDetalleLE
                    Case "REGISTRO DE INVENTARIO PERMANENTE EN UNIDADES FÍSICAS"
                        oeDetalleLE.TipoOperacion = "U"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        gridPermanenteUF.DataSource = leDetalleLE
                        decSubTotal1.Value = Math.Round(leDetalleLE.Sum(Function(it) it.SubTotal1), 2)
                        decSubTotal2.Value = 0
                        decSubTotal3.Value = 0
                        decSubTotal4.Value = Math.Round(leDetalleLE.Sum(Function(it) it.SubTotal2), 2)
                    Case "REGISTRO DE INVENTARIO PERMANENTE VALORIZADO"
                        oeDetalleLE.TipoOperacion = "L"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griPermanenteValorizado.DataSource = leDetalleLE
                    Case "REGISTRO DE ACTIVOS FIJOS"
                        ' ACTIVOS FIJOS REVALUADOS Y NO REVALUADOS
                        oeDetalleLE.TipoOperacion = "71"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        gridActivoFijo.DataSource = leDetalleLE
                        ' DIFERENCIA DE CAMBIO
                        oeDetalleLE.TipoOperacion = "73"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griAct73.DataSource = leDetalleLE
                        ' ACTIVOS FIJOS BAJO LA MODALIDAD DE ARRENDAMIENTO FINANCIERO
                        oeDetalleLE.TipoOperacion = "74"
                        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
                        griAct74.DataSource = leDetalleLE
                End Select
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboLibroGuarda_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLibroGuarda.Validated
        'Select Case cboLibroGuarda.Text
        '    Case "COMPRAS"
        '        tabDetalleLibros.Tabs(7).Selected = True
        '        ControltabDetalleLibro(0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0)
        '    Case "VENTAS"
        '        tabDetalleLibros.Tabs(10).Selected = True
        '        ControltabDetalleLibro(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)
        'End Select
    End Sub

    Private Sub cboLibroGuarda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLibroGuarda.ValueChanged
        Etiqueta5.Text = "Base Imponible"
        Etiqueta6.Text = "IGV"
        Etiqueta9.Text = "Valor A. No G."
        Etiqueta8.Text = "Importe Total"
        Select Case cboLibroGuarda.Text
            Case "LIBRO DIARIO"
                tabDetalleLibros.Tabs(3).Selected = True
                ControltabDetalleLibro(0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                Etiqueta5.Text = "DEBE"
                Etiqueta6.Text = "HABER"
            Case "REGISTRO DE COMPRAS"
                tabDetalleLibros.Tabs(7).Selected = True
                ControltabDetalleLibro(0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0)
                Etiqueta5.Text = "Base Imponible"
                Etiqueta6.Text = "IGV"
            Case "REGISTRO DE VENTAS E INGRESOS"
                tabDetalleLibros.Tabs(12).Selected = True
                ControltabDetalleLibro(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)
                Etiqueta5.Text = "Base Imponible"
                Etiqueta6.Text = "IGV"
            Case "LIBRO MAYOR"
                tabDetalleLibros.Tabs(5).Selected = True
                ControltabDetalleLibro(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0)
                Etiqueta5.Text = "DEBE"
                Etiqueta6.Text = "HABER"
            Case "LIBRO DE INVENTARIOS Y BALANCES"
                tabDetalleLibros.Tabs(1).Selected = True
                ControltabDetalleLibro(0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                ficInventarioBalance.Tabs(0).Selected = True
            Case "REGISTRO DE INVENTARIO PERMANENTE EN UNIDADES FÍSICAS"
                Etiqueta5.Text = "Unidades Ingresadas"
                Etiqueta6.Text = ""
                Etiqueta9.Text = "Unidades Retiradas"
                Etiqueta8.Text = ""
                tabDetalleLibros.Tabs(10).Selected = True
                ControltabDetalleLibro(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
            Case "REGISTRO DE INVENTARIO PERMANENTE VALORIZADO"
                Etiqueta5.Text = "Unidades Ingresadas"
                Etiqueta6.Text = "Costo Total Ingresado"
                Etiqueta9.Text = "Unidades Retiradas"
                Etiqueta8.Text = "Costo Total Retirado"
                tabDetalleLibros.Tabs(11).Selected = True
                ControltabDetalleLibro(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0)
            Case "REGISTRO DE ACTIVOS FIJOS"
                tabDetalleLibros.Tabs(6).Selected = True
                ControltabDetalleLibro(0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0)
            Case Else
                ControltabDetalleLibro(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                Etiqueta5.Text = "Base Imponible:"
                Etiqueta6.Text = "IGV"
        End Select
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        leDetalleLeValidada = New List(Of e_DetalleLibroElectronico)
        Select Case cboLibroGuarda.Text
            Case "REGISTRO DE COMPRAS"
                leDetalleLeValidada = griDetalleCompras.DataSource
                psb_Generacion_txt("C")
                leDetalleLeValidada = griCompras2.DataSource
                psb_Generacion_txt("C2")
            Case "REGISTRO DE VENTAS E INGRESOS"
                leDetalleLeValidada = griDetalleVentas.DataSource
                psb_Generacion_txt("V")
            Case "LIBRO DIARIO"
                leDetalleLeValidada = griDetalleDiario.DataSource
                psb_Generacion_txt("D")
                leDetalleLeValidada = griDetalleDiarioPlanContable.DataSource
                psb_Generacion_txt("DPC")
            Case "LIBRO MAYOR"
                leDetalleLeValidada = griDetalleMayor.DataSource
                psb_Generacion_txt("M")
            Case "REGISTRO DE INVENTARIO PERMANENTE EN UNIDADES FÍSICAS"
                leDetalleLeValidada = gridPermanenteUF.DataSource
                psb_Generacion_txt("UF")
            Case "REGISTRO DE INVENTARIO PERMANENTE VALORIZADO"
                leDetalleLeValidada = griPermanenteValorizado.DataSource
                psb_Generacion_txt("PV")
            Case "LIBRO DE INVENTARIOS Y BALANCES"
                leDetalleLeValidada = gridInventario.DataSource
                psb_Generacion_txt("31")
                leDetalleLeValidada = griInv10.DataSource
                psb_Generacion_txt("32")
                leDetalleLeValidada = griInv12.DataSource
                psb_Generacion_txt("33")
                leDetalleLeValidada = griInv14.DataSource
                psb_Generacion_txt("34")
                leDetalleLeValidada = griInv16.DataSource
                psb_Generacion_txt("35")
                leDetalleLeValidada = griInv19.DataSource
                psb_Generacion_txt("36")
                leDetalleLeValidada = griInv20.DataSource
                psb_Generacion_txt("37")
                leDetalleLeValidada = griInv30.DataSource
                psb_Generacion_txt("38")
                leDetalleLeValidada = griInv34.DataSource
                psb_Generacion_txt("39")
                leDetalleLeValidada = griInv41.DataSource
                psb_Generacion_txt("311")
                leDetalleLeValidada = griInv42.DataSource
                psb_Generacion_txt("312")
                leDetalleLeValidada = griInv46.DataSource
                psb_Generacion_txt("313")
                leDetalleLeValidada = griInv47.DataSource
                psb_Generacion_txt("314")
                leDetalleLeValidada = griInv37.DataSource
                psb_Generacion_txt("315")
                leDetalleLeValidada = griInv50.DataSource
                psb_Generacion_txt("3161")
                leDetalleLeValidada = griInvParticionaria.DataSource
                psb_Generacion_txt("3162")
                leDetalleLeValidada = griInvBC.DataSource
                psb_Generacion_txt("317")
                leDetalleLeValidada = griInvEFEMD.DataSource
                psb_Generacion_txt("318")
                leDetalleLeValidada = griInvECPN.DataSource
                psb_Generacion_txt("319")
                leDetalleLeValidada = griInvER.DataSource
                psb_Generacion_txt("320")
                leDetalleLeValidada = griInvERI.DataSource
                psb_Generacion_txt("324")
                leDetalleLeValidada = griInvEFEMI.DataSource
                psb_Generacion_txt("325")
            Case "REGISTRO DE ACTIVOS FIJOS"
                ' ACTIVOS FIJOS REVALUADOS Y NO REVALUADOS
                leDetalleLeValidada = gridActivoFijo.DataSource
                psb_Generacion_txt("71")
                ' DIFERENCIA DE CAMBIO
                leDetalleLeValidada = New List(Of e_DetalleLibroElectronico)
                psb_Generacion_txt("73")
                ' ACTIVOS FIJOS BAJO LA MODALIDAD DE ARRENDAMIENTO FINANCIERO
                leDetalleLeValidada = griAct74.DataSource
                psb_Generacion_txt("74")
        End Select
    End Sub

    Private Sub btnValidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidacion.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim _cont As Integer = 0
            Dim _fec As Date = #1/1/1901#
            leDetalleLeValidada = New List(Of e_DetalleLibroElectronico)
            _fec = CDate("01/" & cboMesGuarda.Text & "/" & dtp_FechaGuarda.Value.Year.ToString).AddMonths(-12)
            Dim mes As String = ""
            mes = cboMesGuarda.Text
            If Len(mes) = 1 Then
                mes = "0" & mes
            End If
            Select Case cboLibroGuarda.Text
                Case "REGISTRO DE COMPRAS"
                    '8.1 Registro de Compras
                    leDetalleLE = griDetalleCompras.DataSource
                    For Each _DetLE As e_DetalleLibroElectronico In leDetalleLE.OrderBy(Function(Item) Item.FechaEmision).ToList
                        With _DetLE
                            _cont += 1
                            'Valida Indicador (Campo 32)
                            If .FechaEmision.Date.Year = dtp_FechaGuarda.Value.Year.ToString And .FechaEmision.Date.Month = cboMesGuarda.Text Then
                                If .IGV1 = 0 And (.TipoDocumento <> "12" And .TipoDocumento <> "13" And .TipoDocumento <> "14") Then
                                    If .TipoDocumento = "01" Then
                                        .Indicador = "1"
                                    Else
                                        .Indicador = "0"
                                    End If
                                Else
                                    .Indicador = "1"
                                End If
                            ElseIf .FechaEmision.Date >= _fec.Date Then
                                If .IGV1 = 0 And .TipoDocumento <> "12" Then
                                    If .TipoDocumento = "01" Then
                                        .Indicador = "6"
                                    Else
                                        .Indicador = "0"
                                    End If
                                Else
                                    .Indicador = "6"
                                End If
                            Else
                                .Indicador = "7"
                            End If
                            'Valida Periodo
                            'Valida Numero Correlativo
                            If .Indicador = "0" Or .Indicador = "1" Or .Indicador = "6" Or .Indicador = "7" Then
                                '.CodigoUnicoOperacion = .NumeroDocIdentidad & .TipoDocumento & .SerieDoc & .NumeroDoc & FormatoDocumento(_cont, 9)
                                .NumeroCorrelativo = "M" & FormatoDocumento(_cont, 9)
                            End If
                            'Valida Fecha Emision
                            'Valida Fecha Vencimiento
                            If .TipoDocumento <> "14" Then
                                .FechaVencimiento = .FechaEmision
                            End If
                            'Valida Tipo Comprobante
                            'Valida Serie Comprobante
                            If .TipoDocumento = "01" Or .TipoDocumento = "03" Or .TipoDocumento = "04" Or .TipoDocumento = "07" Or .TipoDocumento = "08" Then
                                .SerieDoc = FormatoDocumento(.SerieDoc, 4)
                            Else
                                If .TipoDocumento = "50" Or .TipoDocumento = "52" Then
                                    .SerieDoc = FormatoDocumento(.SerieDoc, 3)
                                ElseIf .TipoDocumento = "05" Then
                                    .SerieDoc = "3"
                                End If
                            End If


                            'Valida Año de Emision DUA
                            If .TipoDocumento = "50" Or .TipoDocumento = "52" Then
                                If CInt(.AnioEmisionDUA) < 1981 Then
                                    .AnioEmisionDUA = "1990"
                                ElseIf CInt(.AnioEmisionDUA) > CInt(dtp_FechaGuarda.Value.Year.ToString) Then
                                    .AnioEmisionDUA = "1990"
                                End If
                            Else
                                .AnioEmisionDUA = "0"
                            End If
                            'Valida Numero Comprobante
                            If .TipoDocumento = "01" Then 'Factura
                                If .SerieDoc.StartsWith("E") OrElse .SerieDoc.StartsWith("F") Then 'Factura Electronica
                                    .NumeroDoc = Microsoft.VisualBasic.Right(.NumeroDoc, 8)
                                Else
                                    .NumeroDoc = Microsoft.VisualBasic.Right(.NumeroDoc, 7)
                                End If
                            End If

                            'Valida Numero Final
                            'Valida Tipo Documento Identidad
                            'Valida Nro Documento Identidad
                            'Valida Denominanacion
                            'Valida Base Imponible, Gravadas y/o Exportacion
                            'Valida Impuesto General a la Venta
                            'Valida Base Imponible, Gravadas y/o Exportacion y no Gravadas
                            'Valida Impuesto General a la Venta
                            'Valida Base Imponible, Gravadas y/o Exportacion 
                            'Valida Impuesto General a la Venta
                            'Valida Valor de la Adquisicion no Gravada
                            'Valida ISC (Impuesto Selectivo al Consumo)
                            'Valida Otros Tributos
                            'Valida Importe Total
                            'Valida Tipo Cambio
                            If .TipoDocumento = "07" Or .TipoDocumento = "08" Or .TipoDocumento = "87" _
                            Or .TipoDocumento = "88" Or .TipoDocumento = "97" Or .TipoDocumento = "98" Then
                                'Valida Fecha Emsion de Comprobante de pago que se me se modifica
                                If .FechaEmisionAso = "01/01/0001" Then
                                    .FechaEmisionAso = "01/01/1901"
                                End If
                                'Valida Tipo Documento Asociado
                                If .TipoDocumentoAso = "00" Then
                                    .TipoDocumentoAso = "99"
                                End If
                                'Valida Numero del comprobante de pago que se midifica
                                If .NumeroDocAso = "" Then
                                    .NumeroDocAso = ""
                                End If
                            End If
                            'Valida Serie de Comprobante de pago que se modifica
                            'Valida Numero del comprobante de pago emitido sujeto no domiciliado
                            If .TipoDocumento = "91" Or .TipoDocumento = "97" Or .TipoDocumento = "98" Then
                                If .NumeroDocAso2 = "" Then
                                    .NumeroDocAso2 = ""
                                End If
                            End If

                            'Valida Fecha Emision de la Constancia Deposito d Detraccion
                            'Valida Numero de la Constancia Deposito d Detraccion
                            'Indicador si se pago con un medio de pago diferente a efectivo
                            If .Total >= 3500 Then
                                .IndCancelaComprobPago = "1"
                            End If
                        End With
                        leDetalleLeValidada.Add(_DetLE)
                    Next

                    LimpiaGrid(griDetalleCompras, ogdDetalleLibroElectronico)
                    griDetalleCompras.DataSource = leDetalleLeValidada
                    '8.2 Registro de Compras Sujetos no Domiciliados
                    Dim lstComprasValidadas2 As New List(Of e_DetalleLibroElectronico)
                    leDetalleLE = griCompras2.DataSource
                    _cont = 0
                    For Each _Fila In leDetalleLE.OrderBy(Function(x) x.FechaEmision).ToList
                        With _Fila
                            _cont += 1
                            If .Indicador = "0" Or .Indicador = "1" Or .Indicador = "9" Then
                                .Indicador = "0"
                                .CodigoUnicoOperacion = .NumeroDocIdentidad & .TipoDocumento & .SerieDoc & .NumeroDoc & FormatoDocumento(_cont, 9)
                                .NumeroCorrelativo = "M" & FormatoDocumento(_cont, 9)
                            End If
                        End With
                        lstComprasValidadas2.Add(_Fila)
                    Next
                    griCompras2.DataSource = lstComprasValidadas2
                Case "REGISTRO DE VENTAS E INGRESOS"
                    leDetalleLE = griDetalleVentas.DataSource
                    For Each _DetLE As e_DetalleLibroElectronico In leDetalleLE.OrderBy(Function(Item) Item.FechaEmision).ToList
                        With _DetLE
                            _cont += 1
                            'Valida Indicador (Campo 27)
                            'If .FechaEmision.Date.Year = dtp_FechaGuarda.Value.Year.ToString And .FechaEmision.Date.Month = cboMesGuarda.Text And .NumeroDocIdentidad <> "" Then
                            '    .Indicador = "1"
                            'ElseIf .FechaEmision.Date >= _fec.Date And .NumeroDocIdentidad <> "" Then
                            '    .Indicador = "8"
                            'End If
                            If .FechaEmision.Date.Year = dtp_FechaGuarda.Value.Year.ToString And .FechaEmision.Date.Month = cboMesGuarda.Text And .NumeroDocIdentidad <> "" Then
                                .Indicador = "1"
                            ElseIf .FechaEmision.Date >= _fec.Date And .NumeroDocIdentidad <> "" Then
                                .Indicador = "1"
                            End If
                            'Valida Periodo
                            'Valida Numero Correlativo
                            If .Indicador = "1" Or .Indicador = "2" Then
                                '.CodigoUnicoOperacion = dtp_FechaGuarda.Value.Year.ToString & mes & .TipoDocumento & .SerieDoc & .NumeroDoc & FormatoDocumento(_cont, 9)
                                .NumeroCorrelativo = "M" & FormatoDocumento(_cont, 9)
                            End If
                            'Valida Fecha Emision
                            'Valida Fecha Vencimiento
                            If .TipoDocumento <> "14" Then
                                .FechaVencimiento = .FechaEmision
                            End If
                            'Valida Tipo Comprobante
                            'Valida Serie Comprobante
                            If .TipoDocumento = "01" Or .TipoDocumento = "03" Or .TipoDocumento = "04" Or .TipoDocumento = "07" Or .TipoDocumento = "08" Then
                                .SerieDoc = FormatoDocumento(.SerieDoc, 4)
                            End If
                            'Validad Año de Emision DUA                            
                            'Valida Numero Comprobante
                            'Valida Numero Final
                            'Valida Tipo Documento Identidad
                            'Valida Nro Documento Identidad
                            'Valida Denominanacion
                            'Valida Base Imponible, Gravadas y/o Exportacion
                            'Valida Impuesto General a la Venta
                            'Valida Base Imponible, Gravadas y/o Exportacion y no Gravadas
                            'Valida Impuesto General a la Venta
                            'Valida Base Imponible, Gravadas y/o Exportacion 
                            'Valida Impuesto General a la Venta
                            'Valida Valor de la Adquisicion no Gravada
                            'Valida ISC (Impuesto Selectivo al Consumo)
                            'Valida Otros Tributos
                            'Valida Importe Total
                            'Valida Tipo Cambio
                            If .TipoDocumento = "07" Or .TipoDocumento = "08" Or .TipoDocumento = "87" _
                            Or .TipoDocumento = "88" Or .TipoDocumento = "97" Or .TipoDocumento = "98" Then
                                'Valida Fecha Emsion de Comprobante de pago que se me se modifica
                                If .FechaEmisionAso = "01/01/0001" And .NumeroDocIdentidad <> "" Then
                                    .FechaEmisionAso = "01/01/1901"
                                End If
                                'Valida Tipo Documento Asociado
                                If .TipoDocumentoAso = "00" And .NumeroDocIdentidad <> "" Then
                                    .TipoDocumentoAso = "99"
                                End If
                                'Valida Numero del comprobante de pago que se midifica
                                If .NumeroDocAso = "" And .NumeroDocIdentidad <> "" Then
                                    .NumeroDocAso = "000"
                                End If
                            End If
                            'Valida Serie de Comprobante de pago que se modifica
                            'Valida Numero del comprobante de pago emitido sujeto no domiciliado
                            'Valida Fecha Emision de la Constancia Deposito d Detraccion
                            'Valida Numero de la Constancia Deposito d Detraccion
                            .CodigoDuaDsiFob = "0.00"
                        End With
                        leDetalleLeValidada.Add(_DetLE)
                    Next
                    LimpiaGrid(griDetalleVentas, ogdDetalleLibroElectronico)
                    griDetalleVentas.DataSource = leDetalleLeValidada
                Case "LIBRO DIARIO"
                    leDetalleLE = griDetalleDiario.DataSource
                    For Each _DetLE As e_DetalleLibroElectronico In leDetalleLE.OrderBy(Function(Item) Item.FechaEmision).ToList
                        With _DetLE
                            _cont += 1
                            'Valida Indicador (Campo 27)
                            'If .FechaEmision.Date.Year = dtp_FechaGuarda.Value.Year.ToString And .FechaEmision.Date.Month = cboMesGuarda.Text And .NumeroDocIdentidad <> "-" Then
                            '    .Indicador = "1"
                            'ElseIf .FechaEmision.Date >= _fec.Date And .NumeroDocIdentidad <> "" Then
                            '    .Indicador = "8"
                            'End If
                            If .FechaEmision.Date.Year = dtp_FechaGuarda.Value.Year.ToString And .FechaEmision.Date.Month = cboMesGuarda.Text And .NumeroDocIdentidad <> "-" Then
                                .Indicador = "1"
                            ElseIf .FechaEmision.Date >= _fec.Date And .NumeroDocIdentidad <> "" Then
                                .Indicador = "1"
                            End If
                            'Valida Periodo
                            'Valida Numero Correlativo
                            If .Indicador = "1" Or .Indicador = "2" Then
                                '.CodigoUnicoOperacion = dtp_FechaGuarda.Value.Year.ToString & mes & .NumeroDoc & FormatoDocumento(_cont, 9)
                                .NumeroCorrelativo = "M" & FormatoDocumento(_cont, 9)
                            End If
                            'Valida Fecha Emision
                            'Valida Fecha Vencimiento
                            'Valida Tipo Comprobante
                            'Valida Serie Comprobante
                            If .TipoDocumento = "01" Or .TipoDocumento = "03" Or .TipoDocumento = "04" Or .TipoDocumento = "07" Or .TipoDocumento = "08" Then
                                .ErrorTipo1 = FormatoDocumento(.ErrorTipo1, 4)
                            End If
                            'Validad Año de Emision DUA                            
                            'Valida Numero Comprobante
                            'Valida Numero Final
                            'Valida Tipo Documento Identidad
                            'Valida Nro Documento Identidad
                            'Valida Denominanacion
                            'Valida Base Imponible, Gravadas y/o Exportacion
                            'Valida Impuesto General a la Venta
                            'Valida Base Imponible, Gravadas y/o Exportacion y no Gravadas
                            'Valida Impuesto General a la Venta
                            'Valida Base Imponible, Gravadas y/o Exportacion 
                            'Valida Impuesto General a la Venta
                            'Valida Valor de la Adquisicion no Gravada
                            'Valida ISC (Impuesto Selectivo al Consumo)
                            'Valida Otros Tributos
                            'Valida Importe Total
                            'Valida Tipo Cambio
                            If .TipoDocumento = "07" Or .TipoDocumento = "08" Or .TipoDocumento = "87" _
                            Or .TipoDocumento = "88" Or .TipoDocumento = "97" Or .TipoDocumento = "98" Then
                                'Valida Fecha Emsion de Comprobante de pago que se me se modifica
                                If .FechaEmisionAso = "01/01/0001" And .NumeroDocIdentidad <> "" Then
                                    .FechaEmisionAso = "01/01/1901"
                                End If
                                'Valida Tipo Documento Asociado
                                If .TipoDocumentoAso = "00" And .NumeroDocIdentidad <> "" Then
                                    .TipoDocumentoAso = "99"
                                End If
                                'Valida Numero del comprobante de pago que se midifica
                                If .NumeroDocAso = "" And .NumeroDocIdentidad <> "" Then
                                    .NumeroDocAso = "000"
                                End If
                            End If
                            'Valida Serie de Comprobante de pago que se modifica
                            'Valida Numero del comprobante de pago emitido sujeto no domiciliado
                            'Valida Fecha Emision de la Constancia Deposito d Detraccion
                            'Valida Numero de la Constancia Deposito d Detraccion
                            'Valida Glosa (AlfaNumerico)
                            If .TipoDocumento = "05" Then
                                .ErrorTipo1 = "3" 'Serie = 3
                            End If
                            .NumeroDocAso2 = gf_quitarSaltosLinea(gf_ConvertirCadenaAlfanumerica(.NumeroDocAso2), " ")
                        End With
                        leDetalleLeValidada.Add(_DetLE)
                    Next
                    LimpiaGrid(griDetalleDiario, ogdDetalleLibroElectronico)
                    griDetalleDiario.DataSource = leDetalleLeValidada
                Case "LIBRO MAYOR"
                    leDetalleLE = griDetalleMayor.DataSource
                    For Each _DetLE As e_DetalleLibroElectronico In leDetalleLE.OrderBy(Function(Item) Item.NumeroDoc).ThenBy(Function(Item) Item.FechaEmision).ToList
                        With _DetLE
                            _cont += 1
                            'Valida Indicador (Campo 27)
                            'If .FechaEmision.Date.Year = dtp_FechaGuarda.Value.Year.ToString And .FechaEmision.Date.Month = cboMesGuarda.Text And .NumeroDocIdentidad <> "" Then
                            '    .Indicador = "1"
                            'ElseIf .FechaEmision.Date >= _fec.Date And .NumeroDocIdentidad <> "" Then
                            '    .Indicador = "8"
                            'End If
                            If .FechaEmision.Date.Year = dtp_FechaGuarda.Value.Year.ToString And .FechaEmision.Date.Month = cboMesGuarda.Text And .NumeroDocIdentidad <> "" Then
                                .Indicador = "1"
                            ElseIf .FechaEmision.Date >= _fec.Date And .NumeroDocIdentidad <> "" Then
                                .Indicador = "1"
                            End If
                            'Valida Periodo
                            'Valida Numero Correlativo
                            If .Indicador = "1" Or .Indicador = "2" Then
                                '.CodigoUnicoOperacion = dtp_FechaGuarda.Value.Year.ToString & mes & .NumeroDoc & FormatoDocumento(_cont, 9)
                                .NumeroCorrelativo = "M" & FormatoDocumento(_cont, 9)
                            End If
                            'Valida Fecha Emision
                            'Valida Fecha Vencimiento
                            'Valida Tipo Comprobante
                            'Valida Serie Comprobante
                            If .TipoDocumento = "01" Or .TipoDocumento = "03" Or .TipoDocumento = "04" Or .TipoDocumento = "07" Or .TipoDocumento = "08" Then
                                .ErrorTipo1 = FormatoDocumento(.ErrorTipo1, 4)
                            End If
                            'Validad Año de Emision DUA                            
                            'Valida Numero Comprobante
                            'Valida Numero Final
                            'Valida Tipo Documento Identidad
                            'Valida Nro Documento Identidad
                            'Valida Denominanacion
                            'Valida Base Imponible, Gravadas y/o Exportacion
                            'Valida Impuesto General a la Venta
                            'Valida Base Imponible, Gravadas y/o Exportacion y no Gravadas
                            'Valida Impuesto General a la Venta
                            'Valida Base Imponible, Gravadas y/o Exportacion 
                            'Valida Impuesto General a la Venta
                            'Valida Valor de la Adquisicion no Gravada
                            'Valida ISC (Impuesto Selectivo al Consumo)
                            'Valida Otros Tributos
                            'Valida Importe Total
                            'Valida Tipo Cambio
                            If .TipoDocumento = "07" Or .TipoDocumento = "08" Or .TipoDocumento = "87" _
                            Or .TipoDocumento = "88" Or .TipoDocumento = "97" Or .TipoDocumento = "98" Then
                                'Valida Fecha Emsion de Comprobante de pago que se me se modifica
                                If .FechaEmisionAso = "01/01/0001" And .NumeroDocIdentidad <> "" Then
                                    .FechaEmisionAso = "01/01/1901"
                                End If
                                'Valida Tipo Documento Asociado
                                If .TipoDocumentoAso = "00" And .NumeroDocIdentidad <> "" Then
                                    .TipoDocumentoAso = "99"
                                End If
                                'Valida Numero del comprobante de pago que se midifica
                                If .NumeroDocAso = "-" And .NumeroDocIdentidad <> "" Then
                                    .NumeroDocAso = "000"
                                End If
                            End If
                            'Valida Serie de Comprobante de pago que se modifica
                            'Valida Numero del comprobante de pago emitido sujeto no domiciliado
                            'Valida Fecha Emision de la Constancia Deposito d Detraccion
                            'Valida Numero de la Constancia Deposito d Detraccion
                            'Validar Glosa Obligatoria
                            If .TipoDocumento = "05" Then
                                .ErrorTipo1 = "3"
                            End If
                            .NumeroDocAso2 = gf_quitarSaltosLinea(gf_ConvertirCadenaAlfanumerica(.NumeroDocAso2), " ")
                        End With
                        leDetalleLeValidada.Add(_DetLE)
                    Next
                    LimpiaGrid(griDetalleMayor, ogdDetalleLibroElectronico)
                    griDetalleMayor.DataSource = leDetalleLeValidada
                Case "REGISTRO DE INVENTARIO PERMANENTE EN UNIDADES FÍSICAS"
                    leDetalleLE = gridPermanenteUF.DataSource
                    ConfigurarListaUnidades(leDetalleLE)
                    leDetalleLeValidada.AddRange(leDetalleLE)
                    gridPermanenteUF.DataSource = New List(Of e_DetalleLibroElectronico)
                    gridPermanenteUF.DataSource = leDetalleLeValidada
                Case "REGISTRO DE INVENTARIO PERMANENTE VALORIZADO"
                    leDetalleLE = griPermanenteValorizado.DataSource
                    ConfigurarListaValorizado(leDetalleLE)
                    'leDetalleLeValidada.AddRange(leDetalleLE)
                    leDetalleLeValidada.AddRange(leInventarioFiltro)
                    griPermanenteValorizado.DataSource = New List(Of e_DetalleLibroElectronico)
                    griPermanenteValorizado.DataSource = leDetalleLeValidada
                    decSubTotal1.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.SubTotal1), 2)
                    decSubTotal2.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.SubTotal2), 2)
                    decSubTotal3.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.IGV3), 2)
                    decSubTotal4.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.IGV2), 2)
            End Select
            ugb_Espera.Visible = False
            mensajeEmergente.Confirmacion("Los Datos de Validaron Correctamente", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griDetalleCompras_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleCompras.CellChange
        griDetalleCompras.UpdateData()
    End Sub

    Private Sub griDetalleVentas_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleVentas.CellChange
        griDetalleVentas.UpdateData()
    End Sub

    Private Sub Menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        Menu.Items("Insert").Visible = True
        If griLista.Selected.Rows.Count > 0 Then
            Menu.Items("Update").Visible = True
            Menu.Items("Delete").Visible = True
            Menu.Items("VerArchivo").Visible = True
            Menu.Items("Enviar").Visible = True
        Else
            Menu.Items("Update").Visible = False
            Menu.Items("Delete").Visible = False
            Menu.Items("VerArchivo").Visible = False
            Menu.Items("Enviar").Visible = False

        End If
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarLiquidacion() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Eliminar()
    End Sub

    Private Sub Enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enviar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.ActiveRow.Cells("IdEstado").Value = "GENERADA" Then
                oeLibroElectronico = New e_LibroElectronico
                oeLibroElectronico.TipoOperacion = "D"
                oeLibroElectronico.Id = griLista.ActiveRow.Cells("Id").Value
                If MessageBox.Show("Se cambiara el estado de la Libro Electronico" & Environment.NewLine & _
                                    "a DESCARGADA porque ya fue declarado en la sunat", _
                                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    oeLibroElectronico.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olLibroElectronico.Guardar(oeLibroElectronico)
                End If
            Else
                Throw New Exception("El Libro ya fue DECLARADO")
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub VerArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerArchivo.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.Rows.Count > 0 Then
                oeLibroElectronico = New e_LibroElectronico
                oeLibroElectronico.Id = griLista.ActiveRow.Cells("Id").Value
                oeLibroElectronico = olLibroElectronico.Obtener(oeLibroElectronico)
                Dim xvar() As String
                xvar = oeLibroElectronico.IdPeriodo.Split("-")
                _CadPeriodo = xvar(0) & xvar(1)
                oeDetalleLE = New e_DetalleLibroElectronico
                oeDetalleLE.TipoOperacion = "E"
                oeDetalleLE.IdLibroElectronico = oeLibroElectronico.Id
                leDetalleLeValidada = olDetalleLE.Listar(oeDetalleLE)
                Select Case oeLibroElectronico.IdTablaContableDet
                    Case "REGISTRO DE COMPRAS"
                        psb_Generacion_txt("C", True)
                    Case "REGISTRO DE VENTAS E INGRESOS"
                        psb_Generacion_txt("V", True)
                    Case "LIBRO DIARIO"
                        psb_Generacion_txt("D", True)
                    Case "LIBRO MAYOR"
                        psb_Generacion_txt("M", True)
                End Select
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        If griLista.Selected.Rows.Count > 0 Then
            Editar()
        End If
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        If griLista.Selected.Rows.Count > 0 Then
            Editar()
        End If
    End Sub

    'Private Sub cboImportarArchivo_Click(sender As Object, e As EventArgs) Handles cboImportarArchivo.Click
    '    Try
    '        Dim TodoTexto As String = "", LineaDeTexto As String = ""
    '        Dim x As Integer = 0
    '        Dim Tabla As New DataTable
    '        Dim sfd_Dialogo As New System.Windows.Forms.OpenFileDialog
    '        With sfd_Dialogo
    '            .Filter = "Libros de Texto Plano (*.txt)|*.txt|Todos Los Archivos (*.*)|*.*"
    '            .DefaultExt = "txt"
    '            .FilterIndex = 1
    '            .Title = "Importar a ..."
    '        End With
    '        sfd_Dialogo.ShowDialog()
    '        If sfd_Dialogo.FileName <> "" Then
    '            Dim objReader As New StreamReader(sfd_Dialogo.FileName)
    '            Dim sLine As String = ""
    '            Dim arrText As New ArrayList()
    '            For T = 0 To objReader.ReadLine.Split("|").Length - 1
    '                Tabla.Columns.Add("Campo " & (T + 1))
    '                x += 1
    '            Next
    '            Do
    '                sLine = objReader.ReadLine()
    '                If Not sLine Is Nothing Then
    '                    arrText.AddRange(sLine.Split("|"))
    '                    Dim newRow As DataRow = Tabla.NewRow()
    '                    For Item = 0 To x - 1
    '                        newRow("Campo " & (Item + 1)) = arrText(Item).ToString
    '                    Next
    '                    Tabla.Rows.Add(newRow)
    '                    arrText.Clear()
    '                End If
    '            Loop Until sLine Is Nothing
    '            objReader.Close()
    '            gridArchivoTexto.DataSource = Tabla
    '            txtObservacion.Text = sfd_Dialogo.SafeFileName
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try

    'End Sub

    Private Sub cboImportarArchivo_Click(sender As Object, e As EventArgs) Handles cboImportarArchivo.Click
        Try
            leDetalleLE = New List(Of e_DetalleLibroElectronico)
            oeDetalleLE = New e_DetalleLibroElectronico

            Dim TodoTexto As String = "", LineaDeTexto As String = ""
            Dim x As Integer = 0
            Dim Tabla As New DataTable
            Dim sfd_Dialogo As New System.Windows.Forms.OpenFileDialog
            With sfd_Dialogo
                .Filter = "Libros de Texto Plano (*.txt)|*.txt|Todos Los Archivos (*.*)|*.*"
                .DefaultExt = "txt"
                .FilterIndex = 1
                .Title = "Importar a ..."
            End With
            sfd_Dialogo.ShowDialog()
            If sfd_Dialogo.FileName <> "" Then
                Dim objReader As New StreamReader(sfd_Dialogo.FileName)
                Dim sLine As String = ""
                Dim arrText As New ArrayList()
                Do
                    sLine = objReader.ReadLine()
                    If Not sLine Is Nothing Then
                        arrText.AddRange(sLine.Split("|"))
                        With oeDetalleLE
                            .Periodo = arrText(0).ToString
                            .CodigoUnicoOperacion = arrText(1).ToString
                            .NumeroCorrelativo = arrText(2).ToString
                            .FechaEmision = arrText(3).ToString
                            .FechaVencimiento = arrText(4).ToString
                            .TipoDocumento = arrText(5).ToString
                            .SerieDoc = arrText(6).ToString
                            .NumeroDoc = arrText(7).ToString
                            .NumeroDoc2 = arrText(8).ToString
                            .TipoDocIdentidad = arrText(9).ToString
                            .NumeroDocIdentidad = arrText(10).ToString
                            .Denominacion = arrText(11).ToString
                            .SubTotal1 = arrText(12).ToString
                            .IGV1 = arrText(13).ToString
                            .SubTotal2 = arrText(14).ToString
                            .IGV2 = arrText(15).ToString
                            .SubTotal3 = arrText(16).ToString
                            .IGV3 = arrText(17).ToString
                            .NoGravada = arrText(18).ToString
                            .ISC = arrText(19).ToString
                            .OtrosTributos = arrText(20).ToString
                            .Total = arrText(21).ToString
                            .TipoCambio = arrText(22).ToString
                            .FechaEmisionAso = arrText(23).ToString
                            .TipoDocumentoAso = arrText(24).ToString
                            .SerieAso = arrText(25).ToString
                            .NumeroDocAso = arrText(26).ToString
                            .CodigoDuaDsiFob = arrText(27).ToString
                            .Indicador = arrText(28).ToString
                        End With
                        leDetalleLE.Add(oeDetalleLE)
                        oeDetalleLE = New e_DetalleLibroElectronico
                        arrText.Clear()
                    End If
                Loop Until sLine Is Nothing
                objReader.Close()
                gridArchivoTexto.DataSource = leDetalleLE
                txtObservacion.Text = sfd_Dialogo.SafeFileName
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub griDetalleDiario_CellChange(sender As Object, e As CellEventArgs) Handles griDetalleDiario.CellChange
        griDetalleDiario.UpdateData()
    End Sub

    Private Sub griDetalleDiario_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleDiario.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub griDetalleMayor_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleMayor.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub griDetalleMayor_CellChange(sender As Object, e As CellEventArgs) Handles griDetalleMayor.CellChange
        griDetalleMayor.UpdateData()
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Try
            Dim open_Dialogo As New System.Windows.Forms.OpenFileDialog
            With open_Dialogo
                .InitialDirectory = Application.StartupPath
                .Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"
                If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    txtNombreArchivo.Text = .FileName
                    webNotas.Navigate(.FileName)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGenerarCUO_Click(sender As Object, e As EventArgs) Handles btnGenerarCUO.Click
        Try
            Dim oeLibElec As New e_LibroElectronico
            Dim listaLibro As New List(Of e_LibroElectronico)
            Dim libro As String = String.Empty

            If Not (cboLibroGuarda.Text = "REGISTRO DE COMPRAS" Or
                cboLibroGuarda.Text = "REGISTRO DE VENTAS E INGRESOS" Or
                cboLibroGuarda.Text = "LIBRO DIARIO" Or
                cboLibroGuarda.Text = "LIBRO MAYOR") Then
                Throw New Exception("CUOS debe generarse en libro conpra, venta, mayor y diario.")
            End If

            'VALIDAR SI EXISTE UN LIBRO YA GUARDADO EN EL PERIODO NO SE VUELVA A GENERAR.
            oeLibElec.TipoOperacion = ""
            oeLibElec.Id = ""
            oeLibElec.IdPeriodo = cboMesGuarda.Value
            oeLibElec.IdEstado = "1CH00006"
            listaLibro = olLibroElectronico.Listar(oeLibElec)

            For Each obj As e_LibroElectronico In listaLibro
                If obj.IdTablaContableDet = cboLibroGuarda.Text Then Throw New Exception("Libro a generar CUOS, ya fue declarado")
                If (obj.IdTablaContableDet = "LIBRO DIARIO" Or obj.IdTablaContableDet = "LIBRO MAYOR") And (cboLibroGuarda.Text = "LIBRO DIARIO" Or cboLibroGuarda.Text = "LIBRO MAYOR") Then Throw New Exception("Libro a generar CUOS, ya fue declarado")
            Next

            oeLibElec = New e_LibroElectronico
            oeLibElec.TipoOperacion = IIf(cboLibroGuarda.Text = "REGISTRO DE COMPRAS", "C", IIf(cboLibroGuarda.Text = "REGISTRO DE VENTAS E INGRESOS", "V", "U"))
            oeLibElec.IdPeriodo = cboMesGuarda.Value
            If olLibroElectronico.ActualizarCUO(oeLibElec) Then
                mensajeEmergente.Confirmacion("Se actualizo correctamente los codigo unico de operacion", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPermanenteValorizado_AfterRowFilterChanged(sender As Object, e As AfterRowFilterChangedEventArgs) Handles griPermanenteValorizado.AfterRowFilterChanged
        Try
            If griPermanenteValorizado.Rows.Where(Function(it) it.IsFilteredOut = False).Count > 0 Then
                decSubTotal1.Value = griPermanenteValorizado.Rows.Where(Function(it) it.IsFilteredOut = False).Sum(Function(it) CDbl(it.Cells("SubTotal1").Value))
                decSubTotal2.Value = griPermanenteValorizado.Rows.Where(Function(it) it.IsFilteredOut = False).Sum(Function(it) CDbl(it.Cells("SubTotal2").Value))
                decSubTotal3.Value = griPermanenteValorizado.Rows.Where(Function(it) it.IsFilteredOut = False).Sum(Function(it) CDbl(it.Cells("IGV3").Value))
                decSubTotal4.Value = griPermanenteValorizado.Rows.Where(Function(it) it.IsFilteredOut = False).Sum(Function(it) CDbl(it.Cells("IGV2").Value))
            Else
                decSubTotal1.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.SubTotal1), 2)
                decSubTotal2.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.SubTotal2), 2)
                decSubTotal3.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.IGV3), 2)
                decSubTotal4.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.IGV2), 2)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griInvetnarioBalances_AfterRowFilterChanged(sender As Object, e As AfterRowFilterChangedEventArgs) Handles gridInventario.AfterRowFilterChanged, _
        griInv10.AfterRowFilterChanged, griInv12.AfterRowFilterChanged
        Try
            Select Case ficInventarioBalance.SelectedTab.Index
                Case 0
                    If gridInventario.Rows.Where(Function(it) Not it.IsFilteredOut).Count > 0 Then
                        decSubTotal3.Value = gridInventario.Rows.Where(Function(it) Not it.IsFilteredOut).Sum(Function(it) CDbl(it.Cells("Total").Value))
                    Else
                        decSubTotal3.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.Total), 2)
                    End If
                Case 1
                    If griInv10.Rows.Where(Function(it) Not it.IsFilteredOut).Count > 0 Then
                        decSubTotal3.Value = griInv10.Rows.Where(Function(it) Not it.IsFilteredOut).Sum(Function(it) CDbl(it.Cells("SubTotal1").Value))
                    Else
                        decSubTotal3.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.Total), 2)
                    End If
                Case 2
                    If griInv12.Rows.Where(Function(it) Not it.IsFilteredOut).Count > 0 Then
                        decSubTotal3.Value = griInv12.Rows.Where(Function(it) Not it.IsFilteredOut).Sum(Function(it) CDbl(it.Cells("Total").Value))
                    Else
                        decSubTotal3.Value = Math.Round(leDetalleLeValidada.Sum(Function(it) it.Total), 2)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        oeLibroElectronico = New e_LibroElectronico
        oeLibroElectronico.FechaCreacion = Date.Now.Date
        leDetalleLeValidada = New List(Of e_DetalleLibroElectronico)
        leDetalleLE = New List(Of e_DetalleLibroElectronico)
        txtObservacion.Text = String.Empty
        cboLibroGuarda.SelectedIndex = -1
        decSubTotal1.Value = 0
        decSubTotal2.Value = 0
        decSubTotal3.Value = 0
        decSubTotal4.Value = 0
        If Operacion <> "Nuevo" Then
            cboLibroGuarda.ReadOnly = True
            dtp_FechaGuarda.Enabled = False
            cboMesGuarda.ReadOnly = True
            btnDetalleLibro.Enabled = False
        Else
            cboLibroGuarda.ReadOnly = False
            dtp_FechaGuarda.Enabled = True
            cboMesGuarda.ReadOnly = False
            btnDetalleLibro.Enabled = True
        End If
    End Sub

    Public Sub LlenaCombos()
        Try
            oeCombo = New e_Combo
            oeCombo.Nombre = "LIBRO O REGISTRO"
            ListaLibros.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarComboMaestro(cboLibroGuarda, ListaLibros, -1)
            LlenarComboMaestro(cboLibroLista, ListaLibros, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeLibroElectronico = New e_LibroElectronico
            oeLibroElectronico.IdPeriodo = cboMesLista.Value
            oeLibroElectronico.IdTablaContableDet = cboLibroLista.Value
            griLista.DataSource = olLibroElectronico.Listar(oeLibroElectronico)

            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Function EditarLibro() As Boolean
        Try
            Dim xvar() As String
            oeLibroElectronico = New e_LibroElectronico
            oeLibroElectronico.Id = griLista.ActiveRow.Cells("Id").Value
            oeLibroElectronico = olLibroElectronico.Obtener(oeLibroElectronico)
            With oeLibroElectronico
                cboLibroGuarda.Text = .IdTablaContableDet
                xvar = .IdPeriodo.Split("-")
                dtp_FechaGuarda.Value = "01/01/" + xvar(0).ToString
                dtp_FechaGuarda_Validated(Nothing, Nothing)
                cboMesGuarda.Text = CInt(xvar(1))
                txtObservacion.Text = .Observacion
                decSubTotal1.Value = .SubTotal1
                decSubTotal2.Value = .SubTotal2
                decSubTotal3.Value = .SubTotal3
                decSubTotal4.Value = .SubTotal4
            End With
            oeDetalleLE = New e_DetalleLibroElectronico
            oeDetalleLE.TipoOperacion = "E"
            oeDetalleLE.IdLibroElectronico = oeLibroElectronico.Id
            Select Case oeLibroElectronico.IdTablaContableDet
                Case "REGISTRO DE COMPRAS"
                    'griDetalleCompras.DataSource = olDetalleLE.Listar(oeDetalleLE)
                    psb_Generacion_txt_Editar(griDetalleCompras, "C", False, If(oeLibroElectronico.FechaCreacion <= #1/2/2016#, "0", "1"))
                    CalcularTotales(griDetalleCompras, "SubTotal1", "IGV1", "NoGravada", "Total")
                    psb_Generacion_txt_Editar(griCompras2, "C2", False, If(oeLibroElectronico.FechaCreacion <= #1/2/2016#, "0", "1"))
                    CalcularTotales(griCompras2, "SubTotal1", "IGV1", "NoGravada", "Total")
                Case "REGISTRO DE VENTAS E INGRESOS"
                    'griDetalleVentas.DataSource = olDetalleLE.Listar(oeDetalleLE)
                    psb_Generacion_txt_Editar(griDetalleVentas, "V", False, If(oeLibroElectronico.FechaCreacion <= #1/2/2016#, "0", "1"))
                    CalcularTotales(griDetalleVentas, "IGV1", "IGV3", "NoGravada", "Total")
                Case "LIBRO DIARIO"
                    'griDetalleDiario.DataSource = olDetalleLE.Listar(oeDetalleLE)
                    psb_Generacion_txt_Editar(griDetalleDiario, "D", False, If(oeLibroElectronico.FechaCreacion <= #1/2/2016#, "0", "1"))
                    CalcularTotales(griDetalleDiario, "SubTotal1", "SubTotal2")
                    psb_Generacion_txt_Editar(griDetalleDiarioPlanContable, "DPC", False, If(oeLibroElectronico.FechaCreacion <= #1/2/2016#, "0", "1"))
                Case "LIBRO MAYOR"
                    'griDetalleMayor.DataSource = olDetalleLE.Listar(oeDetalleLE)
                    psb_Generacion_txt_Editar(griDetalleMayor, "M", False, If(oeLibroElectronico.FechaCreacion <= #1/2/2016#, "0", "1"))
                    CalcularTotales(griDetalleMayor, "SubTotal1", "SubTotal2")
                Case "REGISTRO DE INVENTARIO PERMANENTE EN UNIDADES FÍSICAS"
                    psb_Generacion_txt_Editar(gridPermanenteUF, "UF", False, If(oeLibroElectronico.FechaCreacion <= #1/2/2016#, "0", "1"))
                Case "REGISTRO DE INVENTARIO PERMANENTE VALORIZADO"
                    psb_Generacion_txt_Editar(griPermanenteValorizado, "PV", False, If(oeLibroElectronico.FechaCreacion <= #1/2/2016#, "0", "1"))
                Case "REGISTRO DE ACTIVOS FIJOS"
                    psb_Generacion_txt_Editar(gridActivoFijo, "71", False, "1")
                    psb_Generacion_txt_Editar(griAct73, "73", False, "1")
                    psb_Generacion_txt_Editar(griAct74, "74", False, "1")
                Case "LIBRO DE INVENTARIOS Y BALANCES"
                    psb_Generacion_txt_Editar(gridInventario, "31", False, "1")
                    psb_Generacion_txt_Editar(griInv10, "32", False, "1")
                    psb_Generacion_txt_Editar(griInv12, "33", False, "1")
                    psb_Generacion_txt_Editar(griInv14, "34", False, "1")
                    psb_Generacion_txt_Editar(griInv16, "35", False, "1")
                    psb_Generacion_txt_Editar(griInv19, "36", False, "1")
                    psb_Generacion_txt_Editar(griInv20, "37", False, "1")
                    psb_Generacion_txt_Editar(griInv30, "38", False, "1")
                    psb_Generacion_txt_Editar(griInv34, "39", False, "1")
                    psb_Generacion_txt_Editar(griInv41, "311", False, "1")
                    psb_Generacion_txt_Editar(griInv42, "312", False, "1")
                    psb_Generacion_txt_Editar(griInv46, "313", False, "1")
                    psb_Generacion_txt_Editar(griInv47, "314", False, "1")
                    psb_Generacion_txt_Editar(griInv37, "315", False, "1")
                    psb_Generacion_txt_Editar(griInv50, "3161", False, "1")
                    psb_Generacion_txt_Editar(griInvParticionaria, "3162", False, "1")
                    psb_Generacion_txt_Editar(griInvBC, "317", False, "1")
                    psb_Generacion_txt_Editar(griInvEFEMD, "318", False, "1")
                    psb_Generacion_txt_Editar(griInvECPN, "319", False, "1")
                    psb_Generacion_txt_Editar(griInvER, "320", False, "1")
                    psb_Generacion_txt_Editar(griInvERI, "324", False, "1")
                    psb_Generacion_txt_Editar(griInvEFEMI, "325", False, "1")
            End Select
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function GuardarLibro() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Select Case cboLibroGuarda.Text
                Case "REGISTRO DE COMPRAS"
                    If griDetalleCompras.Rows.Count = 0 Then Throw New Exception("No Hay Registros de COMPRAS")
                Case "REGISTRO DE VENTAS E INGRESOS"
                    If griDetalleVentas.Rows.Count = 0 Then Throw New Exception("No Hay Registros de VENTAS")
                Case "LIBRO DIARIO"
                    If griDetalleDiario.Rows.Count = 0 Then Throw New Exception("No Hay Registros de DIARIOS")
                Case "LIBRO MAYOR"
                    If griDetalleMayor.Rows.Count = 0 Then Throw New Exception("No Hay Registros de MAYOR")
                Case "LIBRO DE INVENTARIOS Y BALANCES"
                    If gridInventario.Rows.Count = 0 Then Throw New Exception("No Hay Registros de INVENTARIOS Y BALANCES")
                Case "REGISTRO DE INVENTARIO PERMANENTE EN UNIDADES FÍSICAS"
                    If gridPermanenteUF.Rows.Count = 0 Then Throw New Exception("No Hay Registros de UNIDADES FISICAS")
                Case "REGISTRO DE INVENTARIO PERMANENTE VALORIZADO"
                    If griPermanenteValorizado.Rows.Count = 0 Then Throw New Exception("No hay Registros de Valorizado")
                Case "REGISTRO DE ACTIVOS FIJOS"
                    If gridActivoFijo.Rows.Count = 0 Then Throw New Exception("No hay Registros de Activo Fijos")
                Case Else
                    Throw New Exception("Libro Contable en Proceso de Desarrollo")
            End Select
            With oeLibroElectronico
                .IdPeriodo = cboMesGuarda.Value
                .IdTablaContableDet = cboLibroGuarda.Value
                .UsuarioCreacion = gUsuarioSGI.Id
                .leDetallePLE = leDetalleLeValidada
                .IdEstado = "1CH00014"
                .Observacion = txtObservacion.Text
                .SubTotal1 = Math.Round(decSubTotal1.Value, 2)
                .SubTotal2 = Math.Round(decSubTotal2.Value, 2)
                .SubTotal3 = Math.Round(decSubTotal3.Value, 2)
                .SubTotal4 = Math.Round(decSubTotal4.Value, 2)
            End With
            oeLibroElectronico.PrefijoID = gs_PrefijoIdSucursal '@0001
            olLibroElectronico.Guardar(oeLibroElectronico)
            leDetalleLeValidada = New List(Of e_DetalleLibroElectronico)
            Select Case cboLibroGuarda.Text
                Case "REGISTRO DE COMPRAS"
                    leDetalleLeValidada = griDetalleCompras.DataSource
                    psb_Generacion_txt_Guardar("C")
                    leDetalleLeValidada = griCompras2.DataSource
                    psb_Generacion_txt_Guardar("C2")
                Case "REGISTRO DE VENTAS E INGRESOS"
                    leDetalleLeValidada = griDetalleVentas.DataSource
                    psb_Generacion_txt_Guardar("V")
                Case "LIBRO DIARIO"
                    leDetalleLeValidada = griDetalleDiario.DataSource
                    psb_Generacion_txt_Guardar("D")
                    leDetalleLeValidada = griDetalleDiarioPlanContable.DataSource
                    psb_Generacion_txt_Guardar("DPC")
                Case "LIBRO MAYOR"
                    leDetalleLeValidada = griDetalleMayor.DataSource
                    psb_Generacion_txt_Guardar("M")
                Case "LIBRO DE INVENTARIOS Y BALANCES"
                    leDetalleLeValidada = gridInventario.DataSource
                    psb_Generacion_txt_Guardar("31")
                    leDetalleLeValidada = griInv10.DataSource
                    psb_Generacion_txt_Guardar("32")
                    leDetalleLeValidada = griInv12.DataSource
                    psb_Generacion_txt_Guardar("33")
                    leDetalleLeValidada = griInv14.DataSource
                    psb_Generacion_txt_Guardar("34")
                    leDetalleLeValidada = griInv16.DataSource
                    psb_Generacion_txt_Guardar("35")
                    leDetalleLeValidada = griInv19.DataSource
                    psb_Generacion_txt_Guardar("36")
                    leDetalleLeValidada = griInv20.DataSource
                    psb_Generacion_txt_Guardar("37")
                    leDetalleLeValidada = griInv30.DataSource
                    psb_Generacion_txt_Guardar("38")
                    leDetalleLeValidada = griInv34.DataSource
                    psb_Generacion_txt_Guardar("39")
                    leDetalleLeValidada = griInv41.DataSource
                    psb_Generacion_txt_Guardar("311")
                    leDetalleLeValidada = griInv42.DataSource
                    psb_Generacion_txt_Guardar("312")
                    leDetalleLeValidada = griInv46.DataSource
                    psb_Generacion_txt_Guardar("313")
                    leDetalleLeValidada = griInv47.DataSource
                    psb_Generacion_txt_Guardar("314")
                    leDetalleLeValidada = griInv37.DataSource
                    psb_Generacion_txt_Guardar("315")
                    leDetalleLeValidada = griInv50.DataSource
                    psb_Generacion_txt_Guardar("3161")
                    leDetalleLeValidada = griInvParticionaria.DataSource
                    psb_Generacion_txt_Guardar("3162")
                    leDetalleLeValidada = griInvBC.DataSource
                    psb_Generacion_txt_Guardar("317")
                    leDetalleLeValidada = griInvEFEMD.DataSource
                    psb_Generacion_txt_Guardar("318")
                    leDetalleLeValidada = griInvECPN.DataSource
                    psb_Generacion_txt_Guardar("319")
                    leDetalleLeValidada = griInvER.DataSource
                    psb_Generacion_txt_Guardar("320")
                    leDetalleLeValidada = griInvERI.DataSource
                    psb_Generacion_txt_Guardar("324")
                    leDetalleLeValidada = griInvEFEMI.DataSource
                    psb_Generacion_txt_Guardar("325")
                Case "REGISTRO DE INVENTARIO PERMANENTE EN UNIDADES FÍSICAS"
                    leDetalleLeValidada = gridPermanenteUF.DataSource
                    psb_Generacion_txt_Guardar("UF")
                Case "REGISTRO DE INVENTARIO PERMANENTE VALORIZADO"
                    leDetalleLeValidada = griPermanenteValorizado.DataSource
                    psb_Generacion_txt_Guardar("PV")
                Case "REGISTRO DE ACTIVOS FIJOS"
                    ' ACTIVOS FIJOS REVALUADOS Y NO REVALUADOS
                    leDetalleLeValidada = gridActivoFijo.DataSource
                    psb_Generacion_txt_Guardar("71")
                    ' DIFERENCIA DE CAMBIO
                    leDetalleLeValidada = griAct73.DataSource
                    psb_Generacion_txt_Guardar("73")
                    ' ACTIVOS FIJOS BAJO LA MODALIDAD DE ARRENDAMIENTO FINANCIERO
                    leDetalleLeValidada = griAct74.DataSource
                    psb_Generacion_txt_Guardar("74")
            End Select
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            If MessageBox.Show("Desea Visualizar el Archivo Txt:  ?", _
                                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                leDetalleLeValidada = New List(Of e_DetalleLibroElectronico)
                Select Case cboLibroGuarda.Text
                    Case "REGISTRO DE COMPRAS"
                        leDetalleLeValidada = griDetalleCompras.DataSource
                        psb_Generacion_txt("C")
                        leDetalleLeValidada = griCompras2.DataSource
                        psb_Generacion_txt("C2")
                    Case "REGISTRO DE VENTAS E INGRESOS"
                        leDetalleLeValidada = griDetalleVentas.DataSource
                        psb_Generacion_txt("V")
                    Case "LIBRO DIARIO"
                        leDetalleLeValidada = griDetalleDiario.DataSource
                        psb_Generacion_txt("D")
                        leDetalleLeValidada = griDetalleDiarioPlanContable.DataSource
                        psb_Generacion_txt("DPC")
                    Case "LIBRO MAYOR"
                        leDetalleLeValidada = griDetalleMayor.DataSource
                        psb_Generacion_txt("M")
                    Case "LIBRO DE INVENTARIOS Y BALANCES"
                        leDetalleLeValidada = gridInventario.DataSource
                        psb_Generacion_txt("31")
                        leDetalleLeValidada = griInv10.DataSource
                        psb_Generacion_txt("32")
                        leDetalleLeValidada = griInv12.DataSource
                        psb_Generacion_txt("33")
                        leDetalleLeValidada = griInv14.DataSource
                        psb_Generacion_txt("34")
                        leDetalleLeValidada = griInv16.DataSource
                        psb_Generacion_txt("35")
                        leDetalleLeValidada = griInv19.DataSource
                        psb_Generacion_txt("36")
                        leDetalleLeValidada = griInv20.DataSource
                        psb_Generacion_txt("37")
                        leDetalleLeValidada = griInv30.DataSource
                        psb_Generacion_txt("38")
                        leDetalleLeValidada = griInv34.DataSource
                        psb_Generacion_txt("39")
                        leDetalleLeValidada = griInv41.DataSource
                        psb_Generacion_txt("311")
                        leDetalleLeValidada = griInv42.DataSource
                        psb_Generacion_txt("312")
                        leDetalleLeValidada = griInv46.DataSource
                        psb_Generacion_txt("313")
                        leDetalleLeValidada = griInv47.DataSource
                        psb_Generacion_txt("314")
                        leDetalleLeValidada = griInv37.DataSource
                        psb_Generacion_txt("315")
                        leDetalleLeValidada = griInv50.DataSource
                        psb_Generacion_txt("3161")
                        leDetalleLeValidada = griInvParticionaria.DataSource
                        psb_Generacion_txt("3162")
                        leDetalleLeValidada = griInvBC.DataSource
                        psb_Generacion_txt("317")
                        leDetalleLeValidada = griInvEFEMD.DataSource
                        psb_Generacion_txt("318")
                        leDetalleLeValidada = griInvECPN.DataSource
                        psb_Generacion_txt("319")
                        leDetalleLeValidada = griInvER.DataSource
                        psb_Generacion_txt("320")
                End Select
            End If
            MyBase.Consultar()
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub ComboPerido(ByVal Combo As ISL.Controles.Combo, Anio As Integer)
        Try
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            oePeriodo.Ejercicio = Anio
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            oePeriodo = New e_Periodo
            lePeriodo.Add(oePeriodo)
            With Combo
                .DisplayMember = "Mes"
                .ValueMember = "Id"
                .DataSource = lePeriodo.OrderBy(Function(Item) Item.Mes).ToList
                If .Items.Count > 0 Then
                    .Text = Date.Now.Month
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ControltabDetalleLibro(ByVal Tab0 As Boolean, ByVal Tab1 As Boolean, ByVal Tab2 As Boolean, ByVal Tab3 As Boolean _
                                       , ByVal Tab4 As Boolean, ByVal Tab5 As Boolean, ByVal Tab6 As Boolean, ByVal Tab7 As Boolean _
                                       , ByVal Tab8 As Boolean, ByVal Tab9 As Boolean, ByVal Tab10 As Boolean, ByVal Tab11 As Boolean _
                                       , ByVal Tab12 As Boolean)
        tabDetalleLibros.Tabs(0).Enabled = Tab0
        tabDetalleLibros.Tabs(1).Enabled = Tab1
        tabDetalleLibros.Tabs(2).Enabled = Tab2
        tabDetalleLibros.Tabs(3).Enabled = Tab3
        tabDetalleLibros.Tabs(4).Enabled = Tab4
        tabDetalleLibros.Tabs(5).Enabled = Tab5
        tabDetalleLibros.Tabs(6).Enabled = Tab6
        tabDetalleLibros.Tabs(7).Enabled = Tab7
        tabDetalleLibros.Tabs(8).Enabled = Tab8
        tabDetalleLibros.Tabs(9).Enabled = Tab9
        tabDetalleLibros.Tabs(10).Enabled = Tab10
        tabDetalleLibros.Tabs(11).Enabled = Tab11
        tabDetalleLibros.Tabs(12).Enabled = Tab12
    End Sub

    Private Function EliminarLiquidacion() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLista
                If ValidarGrilla(griLista, "Liquidacion") Then
                    oeLibroElectronico = New e_LibroElectronico
                    oeLibroElectronico.Id = .ActiveRow.Cells("Id").Value
                    oeLibroElectronico = olLibroElectronico.Obtener(oeLibroElectronico)
                    If oeLibroElectronico.Id <> "" Then
                        If oeLibroElectronico.IdEstado = "GENERADA" Then
                            If MessageBox.Show("Esta seguro de eliminar el Libro Electronico: " & _
                                                             oeLibroElectronico.IdTablaContableDet & _
                                                             " Periodo: " & oeLibroElectronico.IdPeriodo & " ?", _
                                                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeLibroElectronico.TipoOperacion = "E"
                                olLibroElectronico.Eliminar(oeLibroElectronico)
                            Else
                                Return False
                                Exit Function
                            End If
                        Else
                            Throw New Exception("Libro Electronico: " & _
                                                             oeLibroElectronico.IdTablaContableDet & _
                                                             " Periodo: " & oeLibroElectronico.IdPeriodo & _
                                                             " no se puede eliminar su estado es :" & oeLibroElectronico.IdEstado)
                        End If
                    End If
                End If
            End With
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub psb_Generacion_txt(ByVal Tipo As String, Optional ByVal lb_Periodo As Boolean = False)
        Dim ObjTxt As System.IO.StreamWriter
        Try
            Dim stTexto As String
            Dim LibroTipo As String = ""
            Dim LibroSubTipo As String = ""
            Dim NombreArchivo As String = ""
            Dim CadPeriodo As String = ""
            Dim Ctr As Integer = 0
            Dim bandInv As Boolean = False, bandAnual As Boolean = False
            Dim DiaMes As String = "00"
            Dim strCC As String = "00"
            Select Case Tipo
                Case "C" : LibroTipo = "080100"
                Case "C2" : LibroTipo = "080200"
                Case "V" : LibroTipo = "140100"
                Case "D" : LibroTipo = "050100"
                Case "DPC" : LibroTipo = "050300"
                Case "M" : LibroTipo = "060100"
                Case "UF" : LibroTipo = "120100"
                Case "PV" : LibroTipo = "130100"
                Case "31" : LibroTipo = "030100" : bandInv = True
                Case "32" : LibroTipo = "030200" : bandInv = True
                Case "33" : LibroTipo = "030300" : bandInv = True
                Case "34" : LibroTipo = "030400" : bandInv = True
                Case "35" : LibroTipo = "030500" : bandInv = True
                Case "36" : LibroTipo = "030600" : bandInv = True
                Case "37" : LibroTipo = "030700" : bandInv = True
                Case "38" : LibroTipo = "030800" : bandInv = True
                Case "39" : LibroTipo = "030900" : bandInv = True
                Case "311" : LibroTipo = "031100" : bandInv = True
                Case "312" : LibroTipo = "031200" : bandInv = True
                Case "313" : LibroTipo = "031300" : bandInv = True
                Case "314" : LibroTipo = "031400" : bandInv = True
                Case "315" : LibroTipo = "031500" : bandInv = True
                Case "3161" : LibroTipo = "031601" : bandInv = True
                Case "3162" : LibroTipo = "031602" : bandInv = True
                Case "317" : LibroTipo = "031700" : bandInv = True
                Case "318" : LibroTipo = "031800" : bandInv = True
                Case "319" : LibroTipo = "031900" : bandInv = True
                Case "320" : LibroTipo = "032000" : bandInv = True
                Case "324" : LibroTipo = "032400" : bandInv = True
                Case "325" : LibroTipo = "032500" : bandInv = True
                Case "71" : LibroTipo = "070100" : bandAnual = True
                Case "73" : LibroTipo = "070300" : bandAnual = True
                Case "74" : LibroTipo = "070400" : bandAnual = True
            End Select
            If lb_Periodo Then
                CadPeriodo = _CadPeriodo
            Else
                If bandAnual Then
                    CadPeriodo = dtp_FechaGuarda.Value.Year.ToString & "00"
                Else
                    CadPeriodo = dtp_FechaGuarda.Value.Year.ToString & FormatoDocumento(cboMesGuarda.Text, 2)
                End If
            End If
            If bandInv Then
                DiaMes = FormatoDocumento(CDate(gf_InicioFinMes("F", dtp_FechaGuarda.Value.Year, CInt(cboMesGuarda.Text))).Day, 2)
                Select Case CInt(cboMesGuarda.Text)
                    Case 1 : strCC = "02"
                    Case 6 : strCC = "03"
                    Case 12 : strCC = "01"
                    Case Else : strCC = "04"
                End Select
            End If
            NombreArchivo = "LE" & ISL_RUC & CadPeriodo & IIf(bandInv, DiaMes, "00") & LibroTipo & IIf(bandInv, strCC, "00") & "1" & If(leDetalleLeValidada.Count > 0, "1", "0") & "11"
            Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
            With sfd_Dialogo
                .Filter = "Libros de Texto Plano (*.txt)|*.txt|Todos Los Archivos (*.*)|*.*"
                .DefaultExt = "txt"
                .FilterIndex = 1
                .Title = "Exportar a ..."
                .FileName = NombreArchivo
            End With

            Dim result As DialogResult = sfd_Dialogo.ShowDialog()
            Dim stNombreArchivo As String = sfd_Dialogo.FileName
            stNombreArchivo = stNombreArchivo.Substring(0, stNombreArchivo.LastIndexOf("\")) & "\"
            stNombreArchivo += NombreArchivo & ".txt"

            ObjTxt = New System.IO.StreamWriter(stNombreArchivo, False)
            If result = Windows.Forms.DialogResult.Cancel Then Exit Sub
            ugb_Espera.Visible = True
            If IO.File.Exists(stNombreArchivo) = False Then IO.File.Create(stNombreArchivo)
            Select Case Tipo
                Case "C" ' (8) Estructura del Registro de Compras
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Codigo Unico de Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date, 10) & "|" ' (4) Fecha de emisión del comprobante de pago
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date, 10) & "|" ' (5) Fecha de Vencimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (6) Tipo de Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (7) Serie del comprobante de pago
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 4) & "|" ' (8) Año de emisión de la DUA o DSI
                        If IsNumeric(obj.NumeroDoc) Then ' (9) Número del comprobante de pago
                            'stTexto += Int(obj.NumeroDoc).ToString.Trim & "|"
                            stTexto += obj.NumeroDoc.ToString.TrimStart("0") & "|"
                        Else
                            stTexto += obj.NumeroDoc.ToString.Trim & "|"
                        End If
                        'stTexto += Microsoft.VisualBasic.Right(obj.NumeroDoc, 7) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 20) & "|" ' (10) Número 2 del comprobante de pago
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (11) Tipo de Documento de Identidad del proveedor
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (12) Número de RUC del proveedor
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 60) & "|" ' (13) Apellidos y nombres, denominación o razón social  del proveedor
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (14) Base imponible de las adquisiciones gravadas 
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (15) Monto del Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (16) Base imponible de las adquisiciones gravadas 
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (17) Monto del Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (18) Base imponible de las adquisiciones gravadas
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (19) Monto del Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (20) Valor de las adquisiciones no gravadas
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (21) Monto del Impuesto Selectivo al Consumo 
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (22) Otros conceptos, tributos y cargos
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (23) Importe total de las adquisiciones
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|" ' (24) Código  de la Moneda
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("#0.000"), 5) & "|" ' (25) Tipo de cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionAso.Date.ToString, 10) & "|" ' (26) Fecha de emisión del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumentoAso, 2) & "|" ' (27) Tipo de comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieAso, 20) & "|" ' (28) Número de serie del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoDuaDsiFob, 3) & "|" ' (29) Código de la dependencia Aduanera de la Declaración Única de Aduanas
                        If IsNumeric(obj.NumeroDocAso) Then ' (30) Número del comprobante de pago que se modifica
                            stTexto += Int(obj.NumeroDocAso).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDocAso.ToString.Trim & "|"
                        End If
                        'stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso2, 20) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionDetraccion.Date.ToString, 10) & "|" ' (31) Fecha de emisión de la Constancia de Depósito de Detracción
                        stTexto += Microsoft.VisualBasic.Left(obj.NroConstanciaDetraccion, 20) & "|" ' (32) Número de la Constancia de Depósito de Detracción
                        stTexto += Microsoft.VisualBasic.Left(obj.Retencion, 1) & "|" ' (33) Marca del comprobante de pago sujeto a retención
                        stTexto += Microsoft.VisualBasic.Left(obj.ClasificacionBienServicio, 1) & "|" ' (34) Clasificación de los bienes y servicios adquiridos
                        stTexto += Microsoft.VisualBasic.Left(obj.IdentificacionContratoProy, 12) & "|" ' (35) Identificación del Contrato o del proyecto
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo1, 1) & "|" ' (36) inconsistencia en el tipo de cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo2, 1) & "|" ' (37) inconsistencia por proveedores no habidos
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 1) & "|" ' (38) inconsistencia por proveedores que renunciaron a la exoneración del Apéndice I del IGV
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 1) & "|" ' (39) inconsistencia por DNIs
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (40) Indicador de Comprobantes de pago cancelados con medios de pago
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (41) Estado que identifica
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "C2"
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|"
                        If IsNumeric(obj.NumeroDoc) Then
                            'stTexto += Int(obj.NumeroDoc).ToString.Trim & "|"
                            stTexto += obj.NumeroDoc.ToString.TrimStart("0") & "|"
                        Else
                            stTexto += obj.NumeroDoc.ToString.Trim & "|"
                        End If
                        'stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumentoAso, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieAso, 20) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionAso.Date.Year, 4) & "|"
                        If IsNumeric(obj.NumeroDocAso) Then
                            stTexto += Int(obj.NumeroDocAso).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDocAso.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("#0.000"), 5) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 4) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 60) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo1, 60) & "|" 'Domicilio en el Extranjero
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += String.Empty & "|" 'Identif Beneficiario
                        stTexto += String.Empty & "|" 'Apellidos Nombres Beneficiario
                        stTexto += String.Empty & "|" 'Pais Beneficiario
                        stTexto += String.Empty & "|" 'Vínculo
                        stTexto += String.Empty & "|" 'RentaBruta
                        stTexto += String.Empty & "|" 'Enajenacion
                        stTexto += String.Empty & "|" 'Renta Neta
                        stTexto += String.Empty & "|" 'Tasa Retencion
                        stTexto += String.Empty & "|" 'Impuesto Retenido
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 2) & "|"
                        stTexto += String.Empty & "|" 'Exoneracion Aplicada
                        stTexto += Microsoft.VisualBasic.Left(obj.CodTipoRenta, 2) & "|"
                        stTexto += String.Empty & "|" 'Modalidad
                        stTexto += String.Empty & "|" 'Art 76
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "V" ' (14) Estructura del Registro de Ventas e Ingresos
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Codigo Unico de Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date, 10) & "|" ' (4) Fecha de Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date, 10) & "|" ' (5) Fecha Vencimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (6) Tipo Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (7) Nro Serie Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Right(obj.NumeroDoc, 7) & "|" ' (8) Numero Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 20) & "|" ' (9) Numero 2 Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (10) Tipo Documento Identidad Cliente
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (11) Numero Documento Identidad Cliente
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 60) & "|" ' (12) Apellidos y nombres, denominación o razón social  del cliente.
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (13) Valor facturado de la exportación
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (14) Base imponible de la operación gravada
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoBaseImp.ToString("##0.00"), 15) & "|" ' (15) Descuento de la Base Imponible
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (16) Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoIGV.ToString("##0.00"), 15) & "|" ' (17) Descuento del Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (18) Importe total de la operación exonerada
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (19) Importe total de la operación inafecta 
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (20) Impuesto Selectivo al Consumo
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (21) Base imponible de la operación gravada con el Impuesto a las Ventas del Arroz Pilado
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (22) Impuesto a las Ventas del Arroz Pilado  
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (23) Otros concepto
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (24) Importe total
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|" ' (25) Código  de la Moneda
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("#0.000"), 5) & "|" ' (26) Tipo de cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionAso.Date.ToString, 10) & "|" ' (27) Fecha de emisión del comprobante de pago o documento original que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumentoAso, 2) & "|" ' (28) Tipo del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieAso, 20) & "|" ' (29) Número de serie del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Right(obj.NumeroDocAso, 7) & "|" ' (30) Número del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.IdentificacionContratoProy, 12) & "|" ' (31) Identificación del Contrato o del proyecto
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo1, 1) & "|" ' (32) Error tipo 1
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (33) Indicador de Comprobantes de pago cancelados con medios de pago
                        'stTexto += Microsoft.VisualBasic.Left(obj.CodigoDuaDsiFob, 20) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (34) Estado que identifica la oportunidad de la anotación
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "D" ' (5) Estructura del Libro Diario
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Codigo Unico de Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|" ' (4) Código de la Cuenta Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 24) & "|" ' (5) Código de la Unidad de Operación
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 24) & "|" ' (6) Código del Centro de Costos
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|" ' (7) Tipo de Moneda de origen
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (8) tipo de documento de identidad del emisor 
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 15) & "|" ' (9) numero de documento de identidad del emisor
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (10) Tipo de Comprobante de Pago
                        stTexto += obj.ErrorTipo1 & "|" ' (11) Número de serie del comprobante de pago
                        If IsNumeric(obj.ErrorTipo2) Then ' (12) Número del comprobante de pago
                            stTexto += obj.ErrorTipo2.ToString.TrimStart("0") & "|"
                        Else
                            stTexto += obj.ErrorTipo2.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionDetraccion.Date.ToString, 10) & "|" ' (13) Fecha contable
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date.ToString, 10) & "|" ' (14) Fecha de vencimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (15) Fecha de la operación
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso2, 199) & "|" ' (16) Glosa o descripción de la naturaleza de la operación registrada
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 199) & "|" ' (17) Glosa referencia
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (18) Movimientos del Debe
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (19) Movimientos del Haber
                        stTexto += Microsoft.VisualBasic.Left(obj.NroCorrelativoVenta, 40) & "|" ' (20) Datos Estructurados
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (21)
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "DPC"
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 99) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 60) & "|"
                        stTexto += String.Empty & "|"
                        stTexto += String.Empty & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "M"
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Codigo Unico de Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|" ' (4) Código de la cuenta contable
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 24) & "|" ' (5) Código de la Unidad de Operación
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 24) & "|" ' (6) Código del Centro de Costo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|" ' (7) Código de Moneda
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (8) tipo de documento de identidad del emisor
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 15) & "|"  ' (9) numero de documento de identidad del emisor
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (10) Tipo de Comprobante de Pago
                        stTexto += obj.ErrorTipo1 & "|" ' (11) Número de serie del comprobante de pago
                        If IsNumeric(obj.ErrorTipo2) Then ' (12) Número del comprobante de pago 
                            'stTexto += Int(obj.ErrorTipo2).ToString.Trim & "|"
                            stTexto += obj.ErrorTipo2.ToString.TrimStart("0") & "|"
                        Else
                            stTexto += obj.ErrorTipo2.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionDetraccion.Date.ToString, 10) & "|" ' (13) Fecha contable
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date.ToString, 10) & "|" ' (14) Fecha contable
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (15) Fecha Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso2, 199) & "|" ' (16) Glosa o descripción
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 199) & "|" ' (17) Glosa referencia
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (18) Movimientos del Debe
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (19) Movimientos del Haber
                        stTexto += Microsoft.VisualBasic.Left(obj.NroCorrelativoVenta, 90) & "|" ' (20) Dato Estructurado
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (21) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "31" ' Estado de Situacion Financiera
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 6) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "32" ' Inventario Cuenta 10
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 24) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 30) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 6) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "33" ' Inventario Cuenta 12
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "34" ' Inventario Cuenta 14
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "35" ' Inventario Cuenta 16
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "36" ' Inventario Cuenta 19
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 24) & "|"
                        stTexto += Microsoft.VisualBasic.Right(obj.NumeroDoc, 7) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "37" ' Inventario Cuenta 20
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 1) & "|" ' (2) Codigo Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (3) Tipo Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 24) & "|" ' (4) Codigo Propio Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 16) & "|" ' (5) Codigo Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 80) & "|" ' (6) Descripcion
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 3) & "|" ' (7) Codigo Unidad Medida
                        stTexto += Microsoft.VisualBasic.Left(obj.NroConstanciaDetraccion, 1) & "|" ' (8) Codigo Metodo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (9) Cantidad Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (10) Costo Unitario
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (11) Costo Total
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (12) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "38" ' Inventario Cuenta 30
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 1) & "|" ' (4) Tipo Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 15) & "|" ' (5) Nro Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 100) & "|" ' (6) Razon Social
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 2) & "|" ' (7) Codigo Titulo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (8)
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0"), 15) & "|" ' (9)
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (10)
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (11)
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (12) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "39" ' Inventario Cuenta 34
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Perido
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (4) Fecha Inicio
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (5) Cuenta Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 40) & "|" ' (6) Descripcion
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (7) Valor Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (8) Amortizacion
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (9) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "311" ' Inventario Cuenta 41
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 24) & "|" ' (4) Cuenta Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (5) Tipo Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (6) Nro Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 11) & "|" ' (7) Codigo Trabajador
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 100) & "|" ' (8) Apellido y Nombres
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (9) Total
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (10) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "312" ' Inventario Cuenta 42
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (4) Tipo Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (5) Nro Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (6) Fecha Emision
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 100) & "|" ' (7) Razon Social
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (8) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (9) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "313" ' Inventario Cuenta 46
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (4) Tipo Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (5) Nro Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (6) Fecha Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 100) & "|" ' (7) Razon Social
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|" ' (8) Cuenta Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (9) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (10) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "314" ' Inventario Cuenta 47
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 1) & "|" ' (4) Tipo Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 15) & "|" ' (5) Nro Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 100) & "|" ' (6) Razon Social
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (7) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (8) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "315" ' Inventario Cuenta 37
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (4) Tipo Documento
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (5) Serie Doc
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|" ' (6) Serie Doc
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 24) & "|" ' (7) Cuenta Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.NroConstanciaDetraccion, 40) & "|" ' (8) Concepto
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (9) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (10) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (11) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (12) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "3161" ' Inventario Cuenta 50
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (2) Capital Social
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (3) Valor Nominal
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (4) Numero Acciones Suscritas
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (5) Numero Acciones Pagadas
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (6) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "3162" ' Inventario Participaciones
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (3) Tipo Documento
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (4) Serie Doc
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo de Tipos
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 100) & "|" ' (5) Apellidos y Nombres
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0"), 15) & "|" ' (6) Nro Acciones
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (7) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (8) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "317" ' Balance de Comprobacion
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (2) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (3) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (5) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (6) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (7) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (8) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (9) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (10) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (11) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (12) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("##0.00"), 15) & "|" ' (13) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoBaseImp.ToString("##0.00"), 15) & "|" ' (14) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoIGV.ToString("##0.00"), 15) & "|" ' (15) Saldo
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo1).ToString("##0.00"), 15) & "|" ' (16) Saldo
                        stTexto += Microsoft.VisualBasic.Left(Format(obj.ErrorTipo2, "0.00"), 15) & "|" ' (17) Saldo
                        stTexto += Microsoft.VisualBasic.Left(Format(obj.ErrorTipo3, "0.00"), 15) & "|" ' (18) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (19) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "318" ' Estado Flujo Efectivo
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (5) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "319" ' Estado Cambio de Patrimonio Neto
                    For Each obj In leDetalleLeValidada.OrderBy(Function(it) it.NumeroCorrelativo.Trim).ToList
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (4) Capital
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (5) Acciones de Inversion
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (6) Capital Adicional
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (7) Resultados no Realizados
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (8) Reservas Legales
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (9) Otras Reservas
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (10) Resultados Acumulados
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (11) Diferencias de Conversion
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (12) Ajustes al Patrimonio
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (13) Resultados Netos del Ejercicio
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("##0.00"), 15) & "|" ' (14) Excedentes de Revaluacion
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoBaseImp.ToString("##0.00"), 15) & "|" ' (15) Resultado del Ejercicio
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (16) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "320" ' Estado de Resultado
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (5) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "324" ' Estado de Resultado Integrales
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (5) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "325" ' Estado de Flujo Efectivo - Metodo Directo
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (5) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "UF" ' Unidades Fisicas
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) CUO
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo2, 7) & "|" ' (4) Establecimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.IdentificacionContratoProy, 1) & "|" ' (5) Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodTipoRenta, 2) & "|" ' (6) TipoExistencia
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 24) & "|" ' (7) CodExistencia
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 16) & "|" ' (8) OSCE
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision, 10) & "|" ' (9) FechaEmision
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (10) TipoDocumento
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (11) Serie
                        If IsNumeric(obj.NumeroDoc) Then
                            stTexto += Int(obj.NumeroDoc).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDoc.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 2) & "|" ' (13) Tipo Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 80) & "|" ' (14) Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.NroConstanciaDetraccion, 3) & "|" ' (15) Unidad Medida
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 14) & "|" ' (16) Entradas
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 14) & "|" ' (17) Salidas
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (18) Estado Operacion
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "PV"  ' Permanente Valorizado
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) CUO
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo2, 7) & "|" ' (4) Establecimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.IdentificacionContratoProy, 1) & "|" ' (5) Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodTipoRenta, 2) & "|" ' (6) TipoExistencia
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 24) & "|" ' (7) CodExistencia
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 16) & "|" ' (8) OSCE
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision, 10) & "|" ' (9) FechaEmision
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (10) TipoDocumento
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (11) Serie
                        If IsNumeric(obj.NumeroDoc) Then
                            stTexto += Int(obj.NumeroDoc).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDoc.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 2) & "|" ' (13) Tipo Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 80) & "|" ' (14) Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.NroConstanciaDetraccion, 3) & "|" ' (15) Unidad Medida
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (16) Metodo Valuacion
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 14) & "|" ' (17) Cantidad Ingreso
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 14) & "|" ' (18) Costo U. Ingreso
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 14) & "|" ' (19) Costo T. Ingreso
                        stTexto += Microsoft.VisualBasic.Left((obj.IGV2).ToString("##0.00"), 14) & "|" ' (20) Cantidad Salida
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 14) & "|" ' (21) Costo U. Salida
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 14) & "|" ' (22) Costo T. Salida
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 14) & "|" ' (23) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 14) & "|" ' (24) Costo
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 14) & "|" ' (25) Total
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (18) Estado Operacion
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "71" ' ACTIVOS FIJOS REVALUADOS Y NO REVALUADOS
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Cuo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 1) & "|" ' (4) Codigo Catalago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 24) & "|" ' (5) Codigo Propio Activo
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 16) & "|" ' (6) Codigo Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 1) & "|" ' (7) Tipo Activo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 24) & "|" ' (8) Codigo Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (9) Estado
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 40) & "|" ' (10) Descripcion
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 20) & "|" ' (11) Marca
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumentoAso, 20) & "|" ' (12) Modelo
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieAso, 30) & "|" ' (13) Serie
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (14) Importe Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (15) Importe Adquisiciones
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (16) Importe de las Mejoras
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (17) Importe de Retiros
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (18) Importe Otros Ajustes
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (19) Valor de Revaluacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (20) 
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (21) Valor Otras Revaluacion
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (22) Importe Valor Ajuste
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (23) 
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date.ToString, 10) & "|" ' (24) 
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso, 8) & "|" ' (25) Codigo Metodo Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso2, 8) & "|" ' (26) Nro Documento Autorizacion
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (27) Porcentaje Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("##0.00"), 15) & "|" ' (28) Porcentaje Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoBaseImp.ToString("##0.00"), 15) & "|" ' (29) Porcentaje Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoIGV.ToString("##0.00"), 15) & "|" ' (30) Porcentaje Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo1).ToString("##0.00"), 15) & "|" ' (31) Valor de la Depreciacion con ajustes
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo2).ToString("##0.00"), 15) & "|" ' (32) PoValor de la Depreciacion Revaluacion Voluntaria
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo3).ToString("##0.00"), 15) & "|" ' (33) Valor de la Depreciacion Revaluacion Efectuada
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo4).ToString("##0.00"), 15) & "|" ' (34) Valor de la Depreciacion Otras Revaluacion
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.IndCancelaComprobPago).ToString("##0.00"), 15) & "|" ' (35) Valor de Ajuste
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (36) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "73" ' DIFERENCIA DE CAMBIO
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Cuo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 1) & "|" ' (4) Codigo Catalago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 24) & "|" ' (5) Codigo Propio Activo
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (6) Fecha Adquisicion
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (7) Valor Adquisicion ME
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("##0.000"), 15) & "|" ' (8) Tipo Cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (9) Valor Adquisicion MN
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.000"), 15) & "|" ' (10) Tipo Cambio Cierre
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (11) Ajuste Tipo Cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (12) Depreciacion del Ejercicio
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (13) Depreciacion Relacionada con Retiros
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (14) Depreciacion con Otros Ajustes
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (15) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "74" ' ACTIVOS FIJOS BAJO LA MODALIDAD DE ARRENDAMIENTO FINANCIERO
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Cuo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 1) & "|" ' (4) Codigo Catalago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (5) Numero Contrato
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (6) Fecha Contrato
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 5) & "|" ' (7) Codigo Propio
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date.ToString, 10) & "|" ' (8) Fecha Inicio
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0"), 15) & "|" ' (9) Numero Cuotas
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (10) Monto Contrato de Arrendamiento
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (11) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
            End Select
            ObjTxt.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub psb_Generacion_txt_Guardar(ByVal Tipo As String, Optional ByVal lb_Periodo As Boolean = False)
        Try
            Dim stTexto As String
            Dim LibroTipo As String = ""
            Dim NombreArchivo As String = ""
            Dim CadPeriodo As String = ""
            Dim Ctr As Integer = 0
            Dim bandInv As Boolean = False, bandAnual As Boolean = False
            Dim DiaMes As String = "00"
            Dim strCC As String = "00"
            Select Case Tipo
                Case "C" : LibroTipo = "080100"
                Case "C2" : LibroTipo = "080200"
                Case "V" : LibroTipo = "140100"
                Case "D" : LibroTipo = "050100"
                Case "DPC" : LibroTipo = "050300"
                Case "M" : LibroTipo = "060100"
                Case "UF" : LibroTipo = "120100"
                Case "PV" : LibroTipo = "130100"
                Case "31" : LibroTipo = "030100" : bandInv = True
                Case "32" : LibroTipo = "030200" : bandInv = True
                Case "33" : LibroTipo = "030300" : bandInv = True
                Case "34" : LibroTipo = "030400" : bandInv = True
                Case "35" : LibroTipo = "030500" : bandInv = True
                Case "36" : LibroTipo = "030600" : bandInv = True
                Case "37" : LibroTipo = "030700" : bandInv = True
                Case "38" : LibroTipo = "030800" : bandInv = True
                Case "39" : LibroTipo = "030900" : bandInv = True
                Case "311" : LibroTipo = "031100" : bandInv = True
                Case "312" : LibroTipo = "031200" : bandInv = True
                Case "313" : LibroTipo = "031300" : bandInv = True
                Case "314" : LibroTipo = "031400" : bandInv = True
                Case "315" : LibroTipo = "031500" : bandInv = True
                Case "3161" : LibroTipo = "031601" : bandInv = True
                Case "3162" : LibroTipo = "031602" : bandInv = True
                Case "317" : LibroTipo = "031700" : bandInv = True
                Case "318" : LibroTipo = "031800" : bandInv = True
                Case "319" : LibroTipo = "031900" : bandInv = True
                Case "320" : LibroTipo = "032000" : bandInv = True
                Case "324" : LibroTipo = "032400" : bandInv = True
                Case "325" : LibroTipo = "032500" : bandInv = True
                Case "71" : LibroTipo = "070100" : bandAnual = True
                Case "73" : LibroTipo = "070300" : bandAnual = True
                Case "74" : LibroTipo = "070400" : bandAnual = True
            End Select
            If lb_Periodo Then
                CadPeriodo = _CadPeriodo
            Else
                If bandAnual Then
                    CadPeriodo = dtp_FechaGuarda.Value.Year.ToString & "00"
                Else
                    CadPeriodo = dtp_FechaGuarda.Value.Year.ToString & FormatoDocumento(cboMesGuarda.Text, 2)
                End If
            End If
            If bandInv Then
                DiaMes = FormatoDocumento(CDate(gf_InicioFinMes("F", dtp_FechaGuarda.Value.Year, CInt(cboMesGuarda.Text))).Day, 2)
                Select Case CInt(cboMesGuarda.Text)
                    Case 1 : strCC = "02"
                    Case 6 : strCC = "03"
                    Case 12 : strCC = "01"
                    Case Else : strCC = "04"
                End Select
            End If
            'NombreArchivo = "LE" & ISL_RUC & CadPeriodo & "00" & LibroTipo & "00" & "1" & If(leDetalleLeValidada.Count > 0, "1", "0") & "11"
            NombreArchivo = "LE" & ISL_RUC & CadPeriodo & IIf(bandInv, DiaMes, "00") & LibroTipo & IIf(bandInv, strCC, "00") & "1" & If(leDetalleLeValidada.Count > 0, "1", "0") & "11"
            Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
            With sfd_Dialogo
                .Filter = "Libros de Texto Plano (*.txt)|*.txt|Todos Los Archivos (*.*)|*.*"
                .DefaultExt = "txt"
                .FilterIndex = 1
                .Title = "Exportar a ..."
                .FileName = NombreArchivo
            End With
            'Dim result As DialogResult = sfd_Dialogo.ShowDialog()
            'Dim stNombreArchivo As String = sfd_Dialogo.FileName
            Dim olConfiguracion As New l_Configuracion
            ' "10.2.1.57"
            Dim bandAux As Boolean = True
            If Not bandAnual And Not bandInv Then bandAux = False
            Dim stNombreArchivo As String = "\\" & olConfiguracion.Servidor & "\" & "SUNAT PLE\" & dtp_FechaGuarda.Value.Year & "\" & cboLibroGuarda.Text & "\" & IIf(bandAux, NombreArchivo, cboMesGuarda.Text & "\" & NombreArchivo) & ".txt"
            stNombreArchivo = stNombreArchivo.Substring(0, stNombreArchivo.LastIndexOf("\")) & "\"
            stNombreArchivo += NombreArchivo & ".txt"

            Dim ObjTxt As New System.IO.StreamWriter(stNombreArchivo, False)
            'If result = Windows.Forms.DialogResult.Cancel Then Exit Sub
            ugb_Espera.Visible = True
            If IO.File.Exists(stNombreArchivo) = False Then IO.File.Create(stNombreArchivo)
            Select Case Tipo
                Case "C" ' (8) Estructura del Registro de Compras
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Codigo Unico de Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date, 10) & "|" ' (4) Fecha de emisión del comprobante de pago
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date, 10) & "|" ' (5) Fecha de Vencimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (6) Tipo de Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (7) Serie del comprobante de pago
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 4) & "|" ' (8) Año de emisión de la DUA o DSI
                        If IsNumeric(obj.NumeroDoc) Then ' (9) Número del comprobante de pago
                            stTexto += Int(obj.NumeroDoc).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDoc.ToString.Trim & "|"
                        End If
                        'stTexto += Microsoft.VisualBasic.Right(obj.NumeroDoc, 7) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 20) & "|" ' (10) Número 2 del comprobante de pago
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (11) Tipo de Documento de Identidad del proveedor
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (12) Número de RUC del proveedor
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 60) & "|" ' (13) Apellidos y nombres, denominación o razón social  del proveedor
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (14) Base imponible de las adquisiciones gravadas 
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (15) Monto del Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (16) Base imponible de las adquisiciones gravadas 
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (17) Monto del Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (18) Base imponible de las adquisiciones gravadas
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (19) Monto del Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (20) Valor de las adquisiciones no gravadas
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (21) Monto del Impuesto Selectivo al Consumo 
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (22) Otros conceptos, tributos y cargos
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (23) Importe total de las adquisiciones
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|" ' (24) Código  de la Moneda
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("#0.000"), 5) & "|" ' (25) Tipo de cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionAso.Date.ToString, 10) & "|" ' (26) Fecha de emisión del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumentoAso, 2) & "|" ' (27) Tipo de comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieAso, 20) & "|" ' (28) Número de serie del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoDuaDsiFob, 3) & "|" ' (29) Código de la dependencia Aduanera de la Declaración Única de Aduanas
                        If IsNumeric(obj.NumeroDocAso) Then ' (30) Número del comprobante de pago que se modifica
                            stTexto += Int(obj.NumeroDocAso).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDocAso.ToString.Trim & "|"
                        End If
                        'stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso2, 20) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionDetraccion.Date.ToString, 10) & "|" ' (31) Fecha de emisión de la Constancia de Depósito de Detracción
                        stTexto += Microsoft.VisualBasic.Left(obj.NroConstanciaDetraccion, 20) & "|" ' (32) Número de la Constancia de Depósito de Detracción
                        stTexto += Microsoft.VisualBasic.Left(obj.Retencion, 1) & "|" ' (33) Marca del comprobante de pago sujeto a retención
                        stTexto += Microsoft.VisualBasic.Left(obj.ClasificacionBienServicio, 1) & "|" ' (34) Clasificación de los bienes y servicios adquiridos
                        stTexto += Microsoft.VisualBasic.Left(obj.IdentificacionContratoProy, 12) & "|" ' (35) Identificación del Contrato o del proyecto
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo1, 1) & "|" ' (36) inconsistencia en el tipo de cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo2, 1) & "|" ' (37) inconsistencia por proveedores no habidos
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 1) & "|" ' (38) inconsistencia por proveedores que renunciaron a la exoneración del Apéndice I del IGV
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 1) & "|" ' (39) inconsistencia por DNIs
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (40) Indicador de Comprobantes de pago cancelados con medios de pago
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (41) Estado que identifica
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "C2"
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|"
                        If IsNumeric(obj.NumeroDoc) Then
                            stTexto += Int(obj.NumeroDoc).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDoc.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumentoAso, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieAso, 20) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionAso.Date.ToString, 10) & "|"
                        If IsNumeric(obj.NumeroDocAso) Then
                            stTexto += Int(obj.NumeroDocAso).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDocAso.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("#0.000"), 5) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 4) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 60) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo1, 60) & "|" 'Domicilio en el Extranjero
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += String.Empty & "|" 'Identif Beneficiario
                        stTexto += String.Empty & "|" 'Apellidos Nombres Beneficiario
                        stTexto += String.Empty & "|" 'Pais Beneficiario
                        stTexto += String.Empty & "|" 'Vínculo
                        stTexto += String.Empty & "|" 'RentaBruta
                        stTexto += String.Empty & "|" 'Enajenacion
                        stTexto += String.Empty & "|" 'Renta Neta
                        stTexto += String.Empty & "|" 'Tasa Retencion
                        stTexto += String.Empty & "|" 'Impuesto Retenido
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 2) & "|"
                        stTexto += String.Empty & "|" 'Exoneracion Aplicada
                        stTexto += Microsoft.VisualBasic.Left(obj.CodTipoRenta, 2) & "|"
                        stTexto += String.Empty & "|" 'Modalidad
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "V" ' (14) Estructura del Registro de Ventas e Ingresos
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Codigo Unico de Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date, 10) & "|" ' (4) Fecha de Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date, 10) & "|" ' (5) Fecha Vencimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (6) Tipo Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (7) Nro Serie Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Right(obj.NumeroDoc, 7) & "|" ' (8) Numero Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 20) & "|" ' (9) Numero 2 Comprobante de Pago
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (10) Tipo Documento Identidad Cliente
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (11) Numero Documento Identidad Cliente
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 60) & "|" ' (12) Apellidos y nombres, denominación o razón social  del cliente.
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (13) Valor facturado de la exportación
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (14) Base imponible de la operación gravada
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoBaseImp.ToString("##0.00"), 15) & "|" ' (15) Descuento de la Base Imponible
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (16) Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoIGV.ToString("##0.00"), 15) & "|" ' (17) Descuento del Impuesto General a las Ventas
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (18) Importe total de la operación exonerada
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (19) Importe total de la operación inafecta 
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (20) Impuesto Selectivo al Consumo
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (21) Base imponible de la operación gravada con el Impuesto a las Ventas del Arroz Pilado
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (22) Impuesto a las Ventas del Arroz Pilado  
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (23) Otros concepto
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (24) Importe total
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|" ' (25) Código  de la Moneda
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("#0.000"), 5) & "|" ' (26) Tipo de cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionAso.Date.ToString, 10) & "|" ' (27) Fecha de emisión del comprobante de pago o documento original que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumentoAso, 2) & "|" ' (28) Tipo del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieAso, 20) & "|" ' (29) Número de serie del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso, 20) & "|" ' (30) Número del comprobante de pago que se modifica
                        stTexto += Microsoft.VisualBasic.Left(obj.IdentificacionContratoProy, 12) & "|" ' (31) Identificación del Contrato o del proyecto
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo1, 1) & "|" ' (32) Error tipo 1
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (33) Indicador de Comprobantes de pago cancelados con medios de pago
                        'stTexto += Microsoft.VisualBasic.Left(obj.CodigoDuaDsiFob, 20) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (34) Estado que identifica la oportunidad de la anotación
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "D" ' (5) Estructura del Libro Diario
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Codigo Unico de Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|" ' (4) Código de la Unidad de Operación
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 24) & "|" ' (5) Código de la Unidad de Operación
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 24) & "|" ' (6) Código del Centro de Costos
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|" ' (7) Tipo de Moneda de origen
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (8) tipo de documento de identidad del emisor 
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 15) & "|" ' (9) numero de documento de identidad del emisor
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (10) Tipo de Comprobante de Pago
                        stTexto += obj.ErrorTipo1 & "|" ' (11) Número de serie del comprobante de pago
                        If IsNumeric(obj.ErrorTipo2) Then ' (12) Número del comprobante de pago
                            stTexto += Int(obj.ErrorTipo2).ToString.Trim & "|"
                        Else
                            stTexto += obj.ErrorTipo2.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionDetraccion.Date.ToString, 10) & "|" ' (13) Fecha contable
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date.ToString, 10) & "|" ' (14) Fecha de vencimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (15) Fecha de la operación
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso2, 199) & "|" ' (16) Glosa o descripción de la naturaleza de la operación registrada
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 199) & "|" ' (17) Glosa referencia
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (18) Movimientos del Debe
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (19) Movimientos del Haber
                        stTexto += Microsoft.VisualBasic.Left(obj.NroCorrelativoVenta, 40) & "|" 'Datos Estructurados
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "DPC"
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 60) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "M"
                    For Each obj As e_DetalleLibroElectronico In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|"  ' (2) Codigo Unico de Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|" ' (4) Código de la cuenta contable
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 24) & "|" ' (5) Código de la Unidad de Operación
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 24) & "|" ' (6) Código del Centro de Costo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 3) & "|" ' (7) Código de Moneda
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (8) tipo de documento de identidad del emisor
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 15) & "|"  ' (9) numero de documento de identidad del emisor
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (10) Tipo de Comprobante de Pago
                        stTexto += obj.ErrorTipo1 & "|" ' (11) Número de serie del comprobante de pago
                        If IsNumeric(obj.ErrorTipo2) Then ' (12) Número del comprobante de pago 
                            stTexto += Int(obj.ErrorTipo2).ToString.Trim & "|"
                        Else
                            stTexto += obj.ErrorTipo2.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmisionDetraccion.Date.ToString, 10) & "|" ' (13) Fecha contable
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date.ToString, 10) & "|" ' (14) Fecha contable
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (15) Fecha Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso2, 199) & "|" ' (16) Glosa o descripción
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 199) & "|" ' (17) Glosa referencia
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (18) Movimientos del Debe
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (19) Movimientos del Haber
                        stTexto += Microsoft.VisualBasic.Left(obj.NroCorrelativoVenta, 90) & "|" ' (20) Dato Estructurado
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (21) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "31" ' Estado de Situacion Financiera
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 6) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "32" ' Inventario Cuenta 10
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 24) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 30) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoMoneda, 6) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "33" ' Inventario Cuenta 12
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "34" ' Inventario Cuenta 14
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "35" ' Inventario Cuenta 16
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "36" ' Inventario Cuenta 19
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 24) & "|"
                        stTexto += Microsoft.VisualBasic.Right(obj.NumeroDoc, 7) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "37" ' Inventario Cuenta 20
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 24) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 16) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 80) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 3) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "38" ' Inventario Cuenta 30
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 100) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 2) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|"
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|"
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "39" ' Inventario Cuenta 34
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Perido
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (4) Fecha Inicio
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (5) Cuenta Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 40) & "|" ' (6) Descripcion
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (7) Valor Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (8) Amortizacion
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (9) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "311" ' Inventario Cuenta 41
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 24) & "|" ' (4) Cuenta Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (5) Tipo Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (6) Nro Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 11) & "|" ' (7) Codigo Trabajador
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 100) & "|" ' (8) Apellido y Nombres
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (9) Total
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (10) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "312" ' Inventario Cuenta 42
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (4) Tipo Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (5) Nro Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (6) Fecha Emision
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 100) & "|" ' (7) Razon Social
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (8) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (9) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "313" ' Inventario Cuenta 46
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (4) Tipo Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 15) & "|" ' (5) Nro Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (6) Fecha Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 100) & "|" ' (7) Razon Social
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|" ' (8) Cuenta Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (9) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (10) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "314" ' Inventario Cuenta 47
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 1) & "|" ' (4) Tipo Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 15) & "|" ' (5) Nro Doc Identidad
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 100) & "|" ' (6) Razon Social
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (7) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (8) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "315" ' Inventario Cuenta 37
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo Unico Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 10) & "|" ' (3) Numero Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (4) Tipo Documento
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (5) Serie Doc
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 24) & "|" ' (6) Serie Doc
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 24) & "|" ' (7) Cuenta Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.NroConstanciaDetraccion, 40) & "|" ' (8) Concepto
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (9) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (10) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (11) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (12) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "3161" ' Inventario Cuenta 50
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (2) Capital Social
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (3) Valor Nominal
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (4) Numero Acciones Suscritas
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (5) Numero Acciones Pagadas
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (6) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "3162" ' Inventario Participaciones
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (3) Tipo Documento
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (4) Serie Doc
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 40) & "|" ' (2) Codigo de Tipos
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 100) & "|" ' (5) Apellidos y Nombres
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0"), 15) & "|" ' (6) Nro Acciones
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (7) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (8) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "317" ' Balance de Comprobacion
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (2) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (3) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (5) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (6) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (7) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (8) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (9) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (10) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (11) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (12) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("##0.00"), 15) & "|" ' (13) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoBaseImp.ToString("##0.00"), 15) & "|" ' (14) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoIGV.ToString("##0.00"), 15) & "|" ' (15) Saldo
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo1).ToString("##0.00"), 15) & "|" ' (16) Saldo
                        stTexto += Microsoft.VisualBasic.Left(Format(obj.ErrorTipo2, "0.00"), 15) & "|" ' (17) Saldo
                        stTexto += Microsoft.VisualBasic.Left(Format(obj.ErrorTipo3, "0.00"), 15) & "|" ' (18) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (19) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "318" ' Estado Flujo Efectivo
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (5) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "319" ' Estado Cambio de Patrimonio Neto
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (4) Capital
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (5) Acciones de Inversion
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (6) Capital Adicional
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (7) Resultados no Realizados
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (8) Reservas Legales
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (9) Otras Reservas
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (10) Resultados Acumulados
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (11) Diferencias de Conversion
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (12) Ajustes al Patrimonio
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (13) Resultados Netos del Ejercicio
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("##0.00"), 15) & "|" ' (14) Excedentes de Revaluacion
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoBaseImp.ToString("##0.00"), 15) & "|" ' (15) Resultado del Ejercicio
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (16) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "320" ' Estado de Resultado
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (5) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "324" ' Estado de Resultado Integrales
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (5) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "325" ' Estado de Flujo Efectivo - Metodo Directo
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 2) & "|" ' (2) Codigo de Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 6) & "|" ' (3) Codigo Rubro
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (4) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (5) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "UF" ' Unidades Fisicas
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) CUO
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo2, 7) & "|" ' (4) Establecimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.IdentificacionContratoProy, 1) & "|" ' (5) Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodTipoRenta, 2) & "|" ' (6) TipoExistencia
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 24) & "|" ' (7) CodExistencia
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 16) & "|" ' (8) OSCE
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision, 10) & "|" ' (9) FechaEmision
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (10) TipoDocumento
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (11) Serie
                        If IsNumeric(obj.NumeroDoc) Then
                            stTexto += Int(obj.NumeroDoc).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDoc.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 2) & "|" ' (13) Tipo Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 80) & "|" ' (14) Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.NroConstanciaDetraccion, 3) & "|" ' (15) Unidad Medida
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 14) & "|" ' (16) Entradas
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 14) & "|" ' (17) Salidas
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (18) Estado Operacion
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "PV"  ' Permanente Valorizado
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) CUO
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo2, 7) & "|" ' (4) Establecimiento
                        stTexto += Microsoft.VisualBasic.Left(obj.IdentificacionContratoProy, 1) & "|" ' (5) Catalogo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodTipoRenta, 2) & "|" ' (6) TipoExistencia
                        stTexto += Microsoft.VisualBasic.Left(obj.CodConvenio, 24) & "|" ' (7) CodExistencia
                        stTexto += Microsoft.VisualBasic.Left(obj.CodPais, 16) & "|" ' (8) OSCE
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision, 10) & "|" ' (9) FechaEmision
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 2) & "|" ' (10) TipoDocumento
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (11) Serie
                        If IsNumeric(obj.NumeroDoc) Then
                            stTexto += Int(obj.NumeroDoc).ToString.Trim & "|"
                        Else
                            stTexto += obj.NumeroDoc.ToString.Trim & "|"
                        End If
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo3, 2) & "|" ' (13) Tipo Operacion
                        stTexto += Microsoft.VisualBasic.Left(obj.ErrorTipo4, 80) & "|" ' (14) Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.NroConstanciaDetraccion, 3) & "|" ' (15) Unidad Medida
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (16) Metodo Valuacion
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 14) & "|" ' (17) Cantidad Ingreso
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 14) & "|" ' (18) Costo U. Ingreso
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 14) & "|" ' (19) Costo T. Ingreso
                        stTexto += Microsoft.VisualBasic.Left((obj.IGV2).ToString("##0.00"), 14) & "|" ' (20) Cantidad Salida
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 14) & "|" ' (21) Costo U. Salida
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 14) & "|" ' (22) Costo T. Salida
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 14) & "|" ' (23) Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 14) & "|" ' (24) Costo
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 14) & "|" ' (25) Total
                        stTexto += Microsoft.VisualBasic.Left(obj.IndCancelaComprobPago, 1) & "|" ' (18) Estado Operacion
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "71" ' ACTIVOS FIJOS REVALUADOS Y NO REVALUADOS
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Cuo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 1) & "|" ' (4) Codigo Catalago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 24) & "|" ' (5) Codigo Propio Activo
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 16) & "|" ' (6) Codigo Existencia
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc, 1) & "|" ' (7) Tipo Activo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDoc2, 24) & "|" ' (8) Codigo Contable
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocIdentidad, 1) & "|" ' (9) Estado
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocIdentidad, 40) & "|" ' (10) Descripcion
                        stTexto += Microsoft.VisualBasic.Left(obj.Denominacion, 20) & "|" ' (11) Marca
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumentoAso, 20) & "|" ' (12) Modelo
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieAso, 30) & "|" ' (13) Serie
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (14) Importe Saldo
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (15) Importe Adquisiciones
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (16) Importe de las Mejoras
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (17) Importe de Retiros
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (18) Importe Otros Ajustes
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (19) Valor de Revaluacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (20) 
                        stTexto += Microsoft.VisualBasic.Left(obj.ISC.ToString("##0.00"), 15) & "|" ' (21) Valor Otras Revaluacion
                        stTexto += Microsoft.VisualBasic.Left(obj.OtrosTributos.ToString("##0.00"), 15) & "|" ' (22) Importe Valor Ajuste
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (23) 
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date.ToString, 10) & "|" ' (24) 
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso, 8) & "|" ' (25) Codigo Metodo Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroDocAso2, 8) & "|" ' (26) Nro Documento Autorizacion
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (27) Porcentaje Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("##0.00"), 15) & "|" ' (28) Porcentaje Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoBaseImp.ToString("##0.00"), 15) & "|" ' (29) Porcentaje Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(obj.DsctoIGV.ToString("##0.00"), 15) & "|" ' (30) Porcentaje Depreciacion
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo1).ToString("##0.00"), 15) & "|" ' (31) Valor de la Depreciacion con ajustes
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo2).ToString("##0.00"), 15) & "|" ' (32) PoValor de la Depreciacion Revaluacion Voluntaria
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo3).ToString("##0.00"), 15) & "|" ' (33) Valor de la Depreciacion Revaluacion Efectuada
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.ErrorTipo4).ToString("##0.00"), 15) & "|" ' (34) Valor de la Depreciacion Otras Revaluacion
                        stTexto += Microsoft.VisualBasic.Left(CDbl(obj.IndCancelaComprobPago).ToString("##0.00"), 15) & "|" ' (35) Valor de Ajuste
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (36) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "73" ' DIFERENCIA DE CAMBIO
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Cuo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 1) & "|" ' (4) Codigo Catalago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 24) & "|" ' (5) Codigo Propio Activo
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (6) Fecha Adquisicion
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 1) & "|" ' (7) Valor Adquisicion ME
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoCambio.ToString("##0.00"), 15) & "|" ' (8) Tipo Cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV1.ToString("##0.00"), 15) & "|" ' (9) Valor Adquisicion MN
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal2.ToString("##0.00"), 15) & "|" ' (10) Tipo Cambio Cierre
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV2.ToString("##0.00"), 15) & "|" ' (11) Ajuste Tipo Cambio
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal3.ToString("##0.00"), 15) & "|" ' (12) Depreciacion del Ejercicio
                        stTexto += Microsoft.VisualBasic.Left(obj.IGV3.ToString("##0.00"), 15) & "|" ' (13) Depreciacion Relacionada con Retiros
                        stTexto += Microsoft.VisualBasic.Left(obj.NoGravada.ToString("##0.00"), 15) & "|" ' (14) Depreciacion con Otros Ajustes
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (15) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
                Case "74" ' ACTIVOS FIJOS BAJO LA MODALIDAD DE ARRENDAMIENTO FINANCIERO
                    For Each obj In leDetalleLeValidada
                        Ctr += 1
                        stTexto = Microsoft.VisualBasic.Right(obj.Periodo, 8) & "|" ' (1) Periodo
                        stTexto += Microsoft.VisualBasic.Left(obj.CodigoUnicoOperacion, 40) & "|" ' (2) Cuo
                        stTexto += Microsoft.VisualBasic.Left(obj.NumeroCorrelativo, 10) & "|" ' (3) Nro Correlativo
                        stTexto += Microsoft.VisualBasic.Left(obj.TipoDocumento, 1) & "|" ' (4) Codigo Catalago
                        stTexto += Microsoft.VisualBasic.Left(obj.SerieDoc, 20) & "|" ' (5) Numero Contrato
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaEmision.Date.ToString, 10) & "|" ' (6) Fecha Contrato
                        stTexto += Microsoft.VisualBasic.Left(obj.AnioEmisionDUA, 5) & "|" ' (7) Codigo Propio
                        stTexto += Microsoft.VisualBasic.Left(obj.FechaVencimiento.Date.ToString, 10) & "|" ' (8) Fecha Inicio
                        stTexto += Microsoft.VisualBasic.Left(obj.SubTotal1.ToString("##0.00"), 15) & "|" ' (9) Numero Cuotas
                        stTexto += Microsoft.VisualBasic.Left(obj.Total.ToString("##0.00"), 15) & "|" ' (10) Monto Contrato de Arrendamiento
                        stTexto += Microsoft.VisualBasic.Left(obj.Indicador, 1) & "|" ' (11) Indicador
                        ObjTxt.WriteLine(stTexto)
                    Next
            End Select
            ObjTxt.Close()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub psb_Generacion_txt_Editar(ByVal griLista As UltraWinGrid.UltraGrid, ByVal Tipo As String, Optional ByVal lb_Periodo As Boolean = False, Optional ByVal ls_TipoEstructura As String = "0")
        Try
            leDetalleLE = New List(Of e_DetalleLibroElectronico)
            oeDetalleLE = New e_DetalleLibroElectronico
            Dim olConfiguracion As New l_Configuracion
            Dim TodoTexto As String = "", LineaDeTexto As String = ""
            Dim LibroTipo As String = ""
            Dim NombreArchivo As String = ""
            Dim CadPeriodo As String = ""
            Dim Ctr As Integer = 0
            Dim bandInv As Boolean = False, bandAnual As Boolean = False
            Dim DiaMes As String = "00"
            Dim strCC As String = "00"
            Select Case Tipo
                Case "C" : LibroTipo = "080100"
                Case "C2" : LibroTipo = "080200"
                Case "V" : LibroTipo = "140100"
                Case "D" : LibroTipo = "050100"
                Case "DPC" : LibroTipo = "050300"
                Case "M" : LibroTipo = "060100"
                Case "UF" : LibroTipo = "120100"
                Case "PV" : LibroTipo = "130100"
                Case "31" : LibroTipo = "030100" : bandInv = True
                Case "32" : LibroTipo = "030200" : bandInv = True
                Case "33" : LibroTipo = "030300" : bandInv = True
                Case "34" : LibroTipo = "030400" : bandInv = True
                Case "35" : LibroTipo = "030500" : bandInv = True
                Case "36" : LibroTipo = "030600" : bandInv = True
                Case "37" : LibroTipo = "030700" : bandInv = True
                Case "38" : LibroTipo = "030800" : bandInv = True
                Case "39" : LibroTipo = "030900" : bandInv = True
                Case "311" : LibroTipo = "031100" : bandInv = True
                Case "312" : LibroTipo = "031200" : bandInv = True
                Case "313" : LibroTipo = "031300" : bandInv = True
                Case "314" : LibroTipo = "031400" : bandInv = True
                Case "315" : LibroTipo = "031500" : bandInv = True
                Case "3161" : LibroTipo = "031601" : bandInv = True
                Case "3162" : LibroTipo = "031602" : bandInv = True
                Case "317" : LibroTipo = "031700" : bandInv = True
                Case "318" : LibroTipo = "031800" : bandInv = True
                Case "319" : LibroTipo = "031900" : bandInv = True
                Case "320" : LibroTipo = "032000" : bandInv = True
                Case "324" : LibroTipo = "032400" : bandInv = True
                Case "325" : LibroTipo = "032500" : bandInv = True
                Case "71" : LibroTipo = "070100" : bandAnual = True
                Case "73" : LibroTipo = "070300" : bandAnual = True
                Case "74" : LibroTipo = "070400" : bandAnual = True
            End Select
            If lb_Periodo Then
                CadPeriodo = _CadPeriodo
            Else
                If bandAnual Then
                    CadPeriodo = dtp_FechaGuarda.Value.Year.ToString & "00"
                Else
                    CadPeriodo = dtp_FechaGuarda.Value.Year.ToString & FormatoDocumento(cboMesGuarda.Text, 2)
                End If
            End If

            If bandInv Then
                DiaMes = FormatoDocumento(CDate(gf_InicioFinMes("F", dtp_FechaGuarda.Value.Year, CInt(cboMesGuarda.Text))).Day, 2)
                Select Case CInt(cboMesGuarda.Text)
                    Case 1 : strCC = "02"
                    Case 6 : strCC = "03"
                    Case 12 : strCC = "01"
                    Case Else : strCC = "04"
                End Select
            End If

            'NombreArchivo = "LE" & ISL_RUC & CadPeriodo & "00" & LibroTipo & "00" & "1111"
            NombreArchivo = "LE" & ISL_RUC & CadPeriodo & IIf(bandInv, DiaMes, "00") & LibroTipo & IIf(bandInv, strCC, "00") & "1" & "1" & "11"

            Dim bandAux As Boolean = True
            If Not bandAnual And Not bandInv Then bandAux = False

            Dim sfd_Dialogo As New System.Windows.Forms.OpenFileDialog
            With sfd_Dialogo
                .Filter = "Libros de Texto Plano (*.txt)|*.txt|Todos Los Archivos (*.*)|*.*"
                .DefaultExt = "txt"
                .FilterIndex = 1
                .Title = "Importar a ..."
                ' "10.2.1.57"
                .FileName = "\\" & olConfiguracion.Servidor & "\" & "SUNAT PLE\" & dtp_FechaGuarda.Value.Year & "\" & cboLibroGuarda.Text & "\" & IIf(bandAux, NombreArchivo, cboMesGuarda.Text & "\" & NombreArchivo) & ".txt"
            End With
            ''sfd_Dialogo.ShowDialog()
            If sfd_Dialogo.FileName <> "" Then
                Dim objReader As New StreamReader(sfd_Dialogo.FileName)
                Dim sLine As String = ""
                Dim arrText As New ArrayList()
                Do
                    sLine = objReader.ReadLine()
                    If Not sLine Is Nothing Then
                        arrText.AddRange(sLine.Split("|"))
                        Select Case ls_TipoEstructura
                            Case "0" 'Version 4 del PLE 
                                Select Case Tipo
                                    Case "C"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .FechaEmision = arrText(3).ToString
                                            .FechaVencimiento = arrText(4).ToString
                                            .TipoDocumento = arrText(5).ToString
                                            .SerieDoc = arrText(6).ToString
                                            .AnioEmisionDUA = arrText(7).ToString
                                            .NumeroDoc = arrText(8).ToString
                                            .NumeroDoc2 = arrText(9).ToString
                                            .TipoDocIdentidad = arrText(10).ToString
                                            .NumeroDocIdentidad = arrText(11).ToString
                                            .Denominacion = arrText(12).ToString
                                            .SubTotal1 = arrText(13).ToString
                                            .IGV1 = arrText(14).ToString
                                            .SubTotal2 = arrText(15).ToString
                                            .IGV2 = arrText(16).ToString
                                            .SubTotal3 = arrText(17).ToString
                                            .IGV3 = arrText(18).ToString
                                            .NoGravada = arrText(19).ToString
                                            .ISC = arrText(20).ToString
                                            .OtrosTributos = arrText(21).ToString
                                            .Total = arrText(22).ToString
                                            .TipoCambio = arrText(23).ToString
                                            .FechaEmisionAso = arrText(24).ToString
                                            .TipoDocumentoAso = arrText(25).ToString
                                            .SerieAso = arrText(26).ToString
                                            .CodigoDuaDsiFob = arrText(27).ToString
                                            .NumeroDocAso = arrText(28).ToString
                                            .NumeroDocAso2 = arrText(29).ToString
                                            .FechaEmisionDetraccion = arrText(30).ToString
                                            .NroConstanciaDetraccion = arrText(31).ToString
                                            .Retencion = arrText(32).ToString
                                            .Indicador = arrText(33).ToString
                                        End With
                                    Case "V" ' (14) Estructura del Registro de Ventas e Ingresos
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .FechaEmision = arrText(3).ToString
                                            .FechaVencimiento = arrText(4).ToString
                                            .TipoDocumento = arrText(5).ToString
                                            .SerieDoc = arrText(6).ToString
                                            .NumeroDoc = arrText(7).ToString
                                            .NumeroDoc2 = arrText(8).ToString
                                            .TipoDocIdentidad = arrText(9).ToString
                                            .NumeroDocIdentidad = arrText(10).ToString
                                            .Denominacion = arrText(11).ToString
                                            .SubTotal1 = arrText(12).ToString
                                            .IGV1 = arrText(13).ToString
                                            .DsctoBaseImp = arrText(14).ToString
                                            .IGV3 = arrText(15).ToString
                                            .DsctoIGV = arrText(16).ToString
                                            .SubTotal2 = arrText(17).ToString
                                            .IGV2 = arrText(18).ToString
                                            .SubTotal3 = arrText(19).ToString
                                            .NoGravada = arrText(20).ToString
                                            .ISC = arrText(21).ToString
                                            .OtrosTributos = arrText(22).ToString
                                            .Total = arrText(23).ToString
                                            .CodigoMoneda = arrText(24).ToString
                                            .TipoCambio = arrText(25).ToString
                                            .FechaEmisionAso = arrText(26).ToString
                                            .TipoDocumentoAso = arrText(27).ToString
                                            .SerieAso = arrText(28).ToString
                                            .NumeroDocAso = arrText(29).ToString
                                            .IdentificacionContratoProy = arrText(30).ToString
                                            .ErrorTipo1 = arrText(31).ToString
                                            .IndCancelaComprobPago = arrText(32).ToString
                                            .Indicador = arrText(33).ToString
                                        End With
                                    Case "D"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .NumeroDoc = arrText(3).ToString
                                            .ErrorTipo3 = arrText(4).ToString
                                            .ErrorTipo4 = arrText(5).ToString
                                            .CodigoMoneda = arrText(6).ToString
                                            .IndCancelaComprobPago = arrText(7).ToString
                                            .CodPais = arrText(8).ToString
                                            .TipoDocumento = arrText(9).ToString
                                            .ErrorTipo1 = arrText(10).ToString
                                            .ErrorTipo2 = arrText(11).ToString
                                            .FechaEmisionDetraccion = arrText(12).ToString
                                            .FechaVencimiento = arrText(13).ToString
                                            .FechaEmision = arrText(14).ToString
                                            .NumeroDocAso2 = arrText(15).ToString
                                            .CodConvenio = arrText(16).ToString
                                            .SubTotal1 = arrText(17).ToString
                                            .SubTotal2 = arrText(18).ToString
                                            .NroCorrelativoVenta = arrText(19).ToString
                                            .Indicador = arrText(20).ToString
                                        End With
                                    Case "DPC"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroDoc = arrText(1).ToString
                                            .NumeroDoc2 = arrText(2).ToString
                                            .TipoDocIdentidad = arrText(3).ToString
                                            .NumeroDocIdentidad = arrText(4).ToString
                                            .Indicador = arrText(5).ToString
                                        End With
                                    Case "M"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .NumeroDoc = arrText(3).ToString
                                            .ErrorTipo3 = arrText(4).ToString
                                            .ErrorTipo4 = arrText(5).ToString
                                            .CodigoMoneda = arrText(6).ToString
                                            .IndCancelaComprobPago = arrText(7).ToString
                                            .CodPais = arrText(8).ToString
                                            .TipoDocumento = arrText(9).ToString
                                            .ErrorTipo1 = arrText(10).ToString
                                            .ErrorTipo2 = arrText(11).ToString
                                            .FechaEmisionDetraccion = arrText(12).ToString
                                            .FechaVencimiento = arrText(13).ToString
                                            .FechaEmision = arrText(14).ToString
                                            .NumeroDocAso2 = arrText(15).ToString
                                            .CodConvenio = arrText(16).ToString
                                            .SubTotal1 = arrText(17).ToString
                                            .SubTotal2 = arrText(18).ToString
                                            .NroCorrelativoVenta = arrText(19).ToString
                                            .Indicador = arrText(20).ToString
                                        End With
                                    Case "71"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .TipoDocumento = arrText(3).ToString
                                            .SerieDoc = arrText(4).ToString
                                            .AnioEmisionDUA = arrText(5).ToString
                                            .NumeroDoc = arrText(6).ToString
                                            .NumeroDoc2 = arrText(7).ToString
                                            .TipoDocIdentidad = arrText(8).ToString
                                            .NumeroDocIdentidad = arrText(9).ToString
                                            .Denominacion = arrText(10).ToString
                                            .TipoDocumentoAso = arrText(11).ToString
                                            .SerieAso = arrText(12).ToString
                                            .SubTotal1 = arrText(13).ToString
                                            .IGV1 = arrText(14).ToString
                                            .SubTotal2 = arrText(15).ToString
                                            .IGV2 = arrText(16).ToString
                                            .SubTotal3 = arrText(17).ToString
                                            .IGV3 = arrText(18).ToString
                                            .NoGravada = arrText(19).ToString
                                            .ISC = arrText(20).ToString
                                            .OtrosTributos = arrText(21).ToString
                                            .FechaEmision = arrText(22).ToString
                                            .FechaVencimiento = arrText(23).ToString
                                            .NumeroDocAso = arrText(24).ToString
                                            .NumeroDocAso2 = arrText(25).ToString
                                            .Total = arrText(26).ToString
                                            .TipoCambio = arrText(27).ToString
                                            .DsctoBaseImp = arrText(28).ToString
                                            .DsctoIGV = arrText(29).ToString
                                            .ErrorTipo1 = arrText(30).ToString
                                            .ErrorTipo2 = arrText(31).ToString
                                            .ErrorTipo3 = arrText(32).ToString
                                            .ErrorTipo4 = arrText(33).ToString
                                            .IndCancelaComprobPago = arrText(34).ToString
                                            .Indicador = arrText(35).ToString
                                        End With
                                    Case "73"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .TipoDocumento = arrText(3).ToString
                                            .SerieDoc = arrText(4).ToString
                                            .FechaEmision = arrText(5).ToString
                                            .SubTotal1 = arrText(6).ToString
                                            .TipoCambio = arrText(7).ToString
                                            .IGV1 = arrText(8).ToString
                                            .SubTotal2 = arrText(9).ToString
                                            .IGV2 = arrText(10).ToString
                                            .SubTotal3 = arrText(11).ToString
                                            .IGV3 = arrText(12).ToString
                                            .NoGravada = arrText(13).ToString
                                            .Indicador = arrText(14).ToString
                                        End With
                                    Case "74"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .TipoDocumento = arrText(3).ToString
                                            .SerieDoc = arrText(4).ToString
                                            .FechaEmision = arrText(5).ToString
                                            .AnioEmisionDUA = arrText(6).ToString
                                            .FechaVencimiento = arrText(7).ToString
                                            .SubTotal1 = arrText(8).ToString
                                            .Total = arrText(9).ToString
                                            .Indicador = arrText(10).ToString
                                        End With
                                End Select
                            Case "1" 'Version 5 del PLE
                                Select Case Tipo
                                    Case "C"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .FechaEmision = arrText(3).ToString
                                            .FechaVencimiento = arrText(4).ToString
                                            .TipoDocumento = arrText(5).ToString
                                            .SerieDoc = arrText(6).ToString
                                            .AnioEmisionDUA = arrText(7).ToString
                                            .NumeroDoc = arrText(8).ToString
                                            .NumeroDoc2 = arrText(9).ToString
                                            .TipoDocIdentidad = arrText(10).ToString
                                            .NumeroDocIdentidad = arrText(11).ToString
                                            .Denominacion = arrText(12).ToString
                                            .SubTotal1 = arrText(13).ToString
                                            .IGV1 = arrText(14).ToString
                                            .SubTotal2 = arrText(15).ToString
                                            .IGV2 = arrText(16).ToString
                                            .SubTotal3 = arrText(17).ToString
                                            .IGV3 = arrText(18).ToString
                                            .NoGravada = arrText(19).ToString
                                            .ISC = arrText(20).ToString
                                            .OtrosTributos = arrText(21).ToString
                                            .Total = arrText(22).ToString
                                            .CodigoMoneda = arrText(23).ToString
                                            .TipoCambio = arrText(24).ToString
                                            .FechaEmisionAso = arrText(25).ToString
                                            .TipoDocumentoAso = arrText(26).ToString
                                            .SerieAso = arrText(27).ToString
                                            .CodigoDuaDsiFob = arrText(28).ToString
                                            .NumeroDocAso = arrText(29).ToString
                                            .FechaEmisionDetraccion = arrText(30).ToString
                                            '.NumeroDocAso2 = arrText(29).ToString
                                            .NroConstanciaDetraccion = arrText(31).ToString
                                            .Retencion = arrText(32).ToString
                                            .ClasificacionBienServicio = arrText(33).ToString
                                            .IdentificacionContratoProy = arrText(34).ToString
                                            .ErrorTipo1 = arrText(35).ToString
                                            .ErrorTipo2 = arrText(36).ToString
                                            .ErrorTipo3 = arrText(37).ToString
                                            .ErrorTipo4 = arrText(38).ToString
                                            .IndCancelaComprobPago = arrText(39).ToString
                                            .Indicador = arrText(40).ToString
                                        End With
                                    Case "C2" 'Compras Sujetos No Domiciliados
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .FechaEmision = arrText(3).ToString
                                            .TipoDocumento = arrText(4).ToString
                                            .SerieDoc = arrText(5).ToString
                                            .NumeroDoc = arrText(6).ToString
                                            .SubTotal1 = arrText(7).ToString
                                            .OtrosTributos = arrText(8).ToString
                                            .Total = arrText(9).ToString
                                            .TipoDocumentoAso = arrText(10).ToString
                                            .SerieAso = arrText(11).ToString
                                            .FechaEmisionAso = Convert.ToDateTime("01/" & FormatoDocumento(cboMesGuarda.Text, 2) & "/" & arrText(12).ToString)
                                            .NumeroDocAso = arrText(13).ToString
                                            .IGV1 = arrText(14).ToString
                                            .CodigoMoneda = arrText(15).ToString
                                            .TipoCambio = arrText(16).ToString
                                            .CodPais = arrText(17).ToString
                                            .Denominacion = arrText(18).ToString
                                            .ErrorTipo1 = arrText(19).ToString
                                            .NumeroDocIdentidad = arrText(20).ToString
                                            .CodConvenio = arrText(30).ToString
                                            .CodTipoRenta = arrText(32).ToString
                                            .Indicador = arrText(34).ToString
                                        End With
                                    Case "V"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .FechaEmision = arrText(3).ToString
                                            .FechaVencimiento = arrText(4).ToString
                                            .TipoDocumento = arrText(5).ToString
                                            .SerieDoc = arrText(6).ToString
                                            .NumeroDoc = arrText(7).ToString
                                            .NumeroDoc2 = arrText(8).ToString
                                            .TipoDocIdentidad = arrText(9).ToString
                                            .NumeroDocIdentidad = arrText(10).ToString
                                            .Denominacion = arrText(11).ToString
                                            .SubTotal1 = arrText(12).ToString
                                            .IGV1 = arrText(13).ToString
                                            .DsctoBaseImp = arrText(14).ToString
                                            .IGV3 = arrText(15).ToString
                                            .DsctoIGV = arrText(16).ToString
                                            .SubTotal2 = arrText(17).ToString
                                            .IGV2 = arrText(18).ToString
                                            .SubTotal3 = arrText(19).ToString
                                            .NoGravada = arrText(20).ToString
                                            .ISC = arrText(21).ToString
                                            .OtrosTributos = arrText(22).ToString
                                            .Total = arrText(23).ToString
                                            .CodigoMoneda = arrText(24).ToString
                                            .TipoCambio = arrText(25).ToString
                                            .FechaEmisionAso = arrText(26).ToString
                                            .TipoDocumentoAso = arrText(27).ToString
                                            .SerieAso = arrText(28).ToString
                                            .NumeroDocAso = arrText(29).ToString
                                            .IdentificacionContratoProy = arrText(30).ToString
                                            .ErrorTipo1 = arrText(31).ToString
                                            .IndCancelaComprobPago = arrText(32).ToString
                                            .Indicador = arrText(33).ToString
                                        End With
                                    Case "D"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .NumeroDoc = arrText(3).ToString
                                            .ErrorTipo3 = arrText(4).ToString
                                            .ErrorTipo4 = arrText(5).ToString
                                            .CodigoMoneda = arrText(6).ToString
                                            .IndCancelaComprobPago = arrText(7).ToString
                                            .CodPais = arrText(8).ToString
                                            .TipoDocumento = arrText(9).ToString
                                            .ErrorTipo1 = arrText(10).ToString
                                            .ErrorTipo2 = arrText(11).ToString
                                            .FechaEmisionDetraccion = arrText(12).ToString
                                            .FechaVencimiento = arrText(13).ToString
                                            .FechaEmision = arrText(14).ToString
                                            .NumeroDocAso2 = arrText(15).ToString
                                            .CodConvenio = arrText(16).ToString
                                            .SubTotal1 = arrText(17).ToString
                                            .SubTotal2 = arrText(18).ToString
                                            .NroCorrelativoVenta = arrText(19).ToString
                                            .Indicador = arrText(20).ToString
                                        End With
                                    Case "DPC"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroDoc = arrText(1).ToString
                                            .NumeroDoc2 = arrText(2).ToString
                                            .TipoDocIdentidad = arrText(3).ToString
                                            .NumeroDocIdentidad = arrText(4).ToString
                                            .Indicador = arrText(5).ToString
                                        End With
                                    Case "M"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .NumeroDoc = arrText(3).ToString
                                            .ErrorTipo3 = arrText(4).ToString
                                            .ErrorTipo4 = arrText(5).ToString
                                            .CodigoMoneda = arrText(6).ToString
                                            .IndCancelaComprobPago = arrText(7).ToString
                                            .CodPais = arrText(8).ToString
                                            .TipoDocumento = arrText(9).ToString
                                            .ErrorTipo1 = arrText(10).ToString
                                            .ErrorTipo2 = arrText(11).ToString
                                            .FechaEmisionDetraccion = arrText(12).ToString
                                            .FechaVencimiento = arrText(13).ToString
                                            .FechaEmision = arrText(14).ToString
                                            .NumeroDocAso2 = arrText(15).ToString
                                            .CodConvenio = arrText(16).ToString
                                            .SubTotal1 = arrText(17).ToString
                                            .SubTotal2 = arrText(18).ToString
                                            .NroCorrelativoVenta = arrText(19).ToString
                                            .Indicador = arrText(20).ToString
                                        End With
                                    Case "UF"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .ErrorTipo2 = arrText(3).ToString
                                            .IdentificacionContratoProy = arrText(4).ToString
                                            .CodTipoRenta = arrText(5).ToString
                                            .CodConvenio = arrText(6).ToString
                                            .CodPais = arrText(7).ToString
                                            .FechaEmision = arrText(8).ToString
                                            .TipoDocumento = arrText(9).ToString
                                            .SerieDoc = arrText(10).ToString
                                            .NumeroDoc = arrText(11).ToString
                                            .ErrorTipo3 = arrText(12).ToString
                                            .ErrorTipo4 = arrText(13).ToString
                                            .NroConstanciaDetraccion = arrText(14).ToString
                                            .SubTotal1 = arrText(15).ToString
                                            .SubTotal2 = arrText(16).ToString
                                            .IndCancelaComprobPago = arrText(17).ToString
                                        End With
                                    Case "PV"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .ErrorTipo2 = arrText(3).ToString
                                            .IdentificacionContratoProy = arrText(4).ToString
                                            .CodTipoRenta = arrText(5).ToString
                                            .CodConvenio = arrText(6).ToString
                                            .CodPais = arrText(7).ToString
                                            .FechaEmision = arrText(8).ToString
                                            .TipoDocumento = arrText(9).ToString
                                            .SerieDoc = arrText(10).ToString
                                            .NumeroDoc = arrText(11).ToString
                                            .ErrorTipo3 = arrText(12).ToString
                                            .ErrorTipo4 = arrText(13).ToString
                                            .NroConstanciaDetraccion = arrText(14).ToString
                                            .Indicador = arrText(15).ToString
                                            .SubTotal1 = arrText(16).ToString
                                            .IGV1 = arrText(17).ToString
                                            .SubTotal2 = arrText(18).ToString
                                            .IGV2 = arrText(19).ToString
                                            .SubTotal3 = arrText(20).ToString
                                            .IGV3 = arrText(21).ToString
                                            .NoGravada = arrText(22).ToString
                                            .ISC = arrText(23).ToString
                                            .OtrosTributos = arrText(24).ToString
                                            .IndCancelaComprobPago = arrText(25).ToString
                                        End With
                                    Case "31"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc = arrText(2).ToString
                                            .Total = arrText(3).ToString
                                            .Indicador = arrText(4).ToString
                                        End With
                                    Case "32"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc = arrText(2).ToString
                                            .NumeroDoc2 = arrText(3).ToString
                                            .CodigoMoneda = arrText(4).ToString
                                            .SubTotal1 = arrText(5).ToString
                                            .SubTotal2 = arrText(6).ToString
                                            .Indicador = arrText(7).ToString
                                        End With
                                    Case "33"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc = arrText(2).ToString
                                            .TipoDocIdentidad = arrText(3).ToString
                                            .NumeroDocIdentidad = arrText(4).ToString
                                            .NumeroDoc2 = arrText(5).ToString
                                            .FechaEmision = arrText(6).ToString
                                            .Total = arrText(7).ToString
                                            .Indicador = arrText(8).ToString
                                        End With
                                    Case "34"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc = arrText(2).ToString
                                            .TipoDocIdentidad = arrText(3).ToString
                                            .NumeroDocIdentidad = arrText(4).ToString
                                            .NumeroDoc2 = arrText(5).ToString
                                            .FechaEmision = arrText(6).ToString
                                            .Total = arrText(7).ToString
                                            .Indicador = arrText(8).ToString
                                        End With
                                    Case "35"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc = arrText(2).ToString
                                            .TipoDocIdentidad = arrText(3).ToString
                                            .NumeroDocIdentidad = arrText(4).ToString
                                            .NumeroDoc2 = arrText(5).ToString
                                            .FechaEmision = arrText(6).ToString
                                            .Total = arrText(7).ToString
                                            .Indicador = arrText(8).ToString
                                        End With
                                    Case "36"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc2 = arrText(2).ToString
                                            .TipoDocIdentidad = arrText(3).ToString
                                            .NumeroDocIdentidad = arrText(4).ToString
                                            .NumeroDocAso = arrText(5).ToString
                                            .TipoDocumento = arrText(6).ToString
                                            .SerieDoc = arrText(7).ToString
                                            .NumeroDoc = arrText(8).ToString
                                            .FechaEmision = arrText(9).ToString
                                            .Total = arrText(10).ToString
                                            .Indicador = arrText(11).ToString
                                        End With
                                    Case "37"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .TipoDocumento = arrText(2).ToString
                                            .SerieDoc = arrText(3).ToString
                                            .NumeroDoc = arrText(4).ToString
                                            .NumeroDoc2 = arrText(5).ToString
                                            .TipoDocIdentidad = arrText(6).ToString
                                            .NumeroDocIdentidad = arrText(7).ToString
                                            .SubTotal1 = arrText(8).ToString
                                            .SubTotal2 = arrText(9).ToString
                                            .SubTotal3 = arrText(10).ToString
                                            .Indicador = arrText(11).ToString
                                        End With
                                    Case "38"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc = arrText(2).ToString
                                            .TipoDocIdentidad = arrText(3).ToString
                                            .NumeroDocIdentidad = arrText(4).ToString
                                            .NumeroDoc2 = arrText(5).ToString
                                            .SerieDoc = arrText(6).ToString
                                            .SubTotal1 = arrText(7).ToString
                                            .IGV1 = arrText(8).ToString
                                            .SubTotal2 = arrText(9).ToString
                                            .IGV2 = arrText(10).ToString
                                            .Indicador = arrText(11).ToString
                                        End With
                                    Case "39"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc = arrText(2).ToString
                                            .FechaEmision = arrText(3).ToString
                                            .NumeroDoc2 = arrText(4).ToString
                                            .TipoDocumento = arrText(5).ToString
                                            .SubTotal1 = arrText(6).ToString
                                            .SubTotal2 = arrText(7).ToString
                                            .Indicador = arrText(8).ToString
                                        End With
                                    Case "311"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc = arrText(2).ToString
                                            .NumeroDoc2 = arrText(3).ToString
                                            .TipoDocIdentidad = arrText(4).ToString
                                            .NumeroDocIdentidad = arrText(5).ToString
                                            .TipoDocumento = arrText(6).ToString
                                            .SerieDoc = arrText(7).ToString
                                            .Total = arrText(8).ToString
                                            .Indicador = arrText(9).ToString
                                        End With
                                    Case "312"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc2 = arrText(2).ToString
                                            .TipoDocIdentidad = arrText(3).ToString
                                            .NumeroDocIdentidad = arrText(4).ToString
                                            .FechaEmision = arrText(5).ToString
                                            .Denominacion = arrText(6).ToString
                                            .Total = arrText(7).ToString
                                            .Indicador = arrText(8).ToString
                                        End With
                                    Case "313"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc2 = arrText(2).ToString
                                            .TipoDocIdentidad = arrText(3).ToString
                                            .NumeroDocIdentidad = arrText(4).ToString
                                            .FechaEmision = arrText(5).ToString
                                            .Denominacion = arrText(6).ToString
                                            .NumeroDoc = arrText(7).ToString
                                            .Total = arrText(8).ToString
                                            .Indicador = arrText(9).ToString
                                        End With
                                    Case "314"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc2 = arrText(2).ToString
                                            .TipoDocumento = arrText(3).ToString
                                            .SerieDoc = arrText(4).ToString
                                            .NumeroDoc = arrText(5).ToString
                                            .Total = arrText(6).ToString
                                            .Indicador = arrText(7).ToString
                                        End With
                                    Case "315"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .NumeroDoc2 = arrText(2).ToString
                                            .TipoDocumento = arrText(3).ToString
                                            .SerieDoc = arrText(4).ToString
                                            .NumeroDoc = arrText(5).ToString
                                            .AnioEmisionDUA = arrText(6).ToString
                                            .NroConstanciaDetraccion = arrText(7).ToString
                                            .SubTotal1 = arrText(8).ToString
                                            .SubTotal2 = arrText(9).ToString
                                            .SubTotal3 = arrText(10).ToString
                                            .Indicador = arrText(11).ToString
                                        End With
                                    Case "3161"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .SubTotal1 = arrText(1).ToString
                                            .SubTotal2 = arrText(2).ToString
                                            .SubTotal3 = arrText(3).ToString
                                            .Total = arrText(4).ToString
                                            .Indicador = arrText(5).ToString
                                        End With
                                    Case "3162"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .TipoDocumento = arrText(1).ToString
                                            .SerieDoc = arrText(2).ToString
                                            .NumeroCorrelativo = arrText(3).ToString
                                            .AnioEmisionDUA = arrText(4).ToString
                                            .SubTotal1 = arrText(5).ToString
                                            .SubTotal2 = arrText(6).ToString
                                            .Indicador = arrText(7).ToString
                                        End With
                                    Case "317"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .SubTotal1 = arrText(2).ToString
                                            .IGV1 = arrText(3).ToString
                                            .SubTotal2 = arrText(4).ToString
                                            .IGV2 = arrText(5).ToString
                                            .SubTotal3 = arrText(6).ToString
                                            .IGV3 = arrText(7).ToString
                                            .NoGravada = arrText(8).ToString
                                            .ISC = arrText(9).ToString
                                            .OtrosTributos = arrText(10).ToString
                                            .Total = arrText(11).ToString
                                            .TipoCambio = arrText(12).ToString
                                            .DsctoBaseImp = arrText(13).ToString
                                            .DsctoIGV = arrText(14).ToString
                                            .ErrorTipo1 = arrText(15).ToString
                                            .ErrorTipo2 = arrText(16).ToString
                                            .ErrorTipo3 = arrText(17).ToString
                                            .Indicador = arrText(18).ToString
                                        End With
                                    Case "318"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .TipoDocumento = arrText(2).ToString
                                            .Total = arrText(3).ToString
                                            .Indicador = arrText(4).ToString
                                        End With
                                    Case "319"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .TipoDocumento = arrText(2).ToString
                                            .SubTotal1 = arrText(3).ToString
                                            .IGV1 = arrText(4).ToString
                                            .SubTotal2 = arrText(5).ToString
                                            .IGV2 = arrText(6).ToString
                                            .SubTotal3 = arrText(7).ToString
                                            .IGV3 = arrText(8).ToString
                                            .NoGravada = arrText(9).ToString
                                            .ISC = arrText(10).ToString
                                            .OtrosTributos = arrText(11).ToString
                                            .Total = arrText(12).ToString
                                            .TipoCambio = arrText(13).ToString
                                            .DsctoBaseImp = arrText(14).ToString
                                            .Indicador = arrText(15).ToString
                                        End With
                                    Case "320"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .TipoDocumento = arrText(2).ToString
                                            .Total = arrText(3).ToString
                                            .Indicador = arrText(4).ToString
                                        End With
                                    Case "324"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .TipoDocumento = arrText(2).ToString
                                            .Total = arrText(3).ToString
                                            .Indicador = arrText(4).ToString
                                        End With
                                    Case "325"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .NumeroCorrelativo = arrText(1).ToString
                                            .TipoDocumento = arrText(2).ToString
                                            .Total = arrText(3).ToString
                                            .Indicador = arrText(4).ToString
                                        End With
                                    Case "71"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .TipoDocumento = arrText(3).ToString
                                            .SerieDoc = arrText(4).ToString
                                            .AnioEmisionDUA = arrText(5).ToString
                                            .NumeroDoc = arrText(6).ToString
                                            .NumeroDoc2 = arrText(7).ToString
                                            .TipoDocIdentidad = arrText(8).ToString
                                            .NumeroDocIdentidad = arrText(9).ToString
                                            .Denominacion = arrText(10).ToString
                                            .TipoDocumentoAso = arrText(11).ToString
                                            .SerieAso = arrText(12).ToString
                                            .SubTotal1 = arrText(13).ToString
                                            .IGV1 = arrText(14).ToString
                                            .SubTotal2 = arrText(15).ToString
                                            .IGV2 = arrText(16).ToString
                                            .SubTotal3 = arrText(17).ToString
                                            .IGV3 = arrText(18).ToString
                                            .NoGravada = arrText(19).ToString
                                            .ISC = arrText(20).ToString
                                            .OtrosTributos = arrText(21).ToString
                                            .FechaEmision = arrText(22).ToString
                                            .FechaVencimiento = arrText(23).ToString
                                            .NumeroDocAso = arrText(24).ToString
                                            .NumeroDocAso2 = arrText(25).ToString
                                            .Total = arrText(26).ToString
                                            .TipoCambio = arrText(27).ToString
                                            .DsctoBaseImp = arrText(28).ToString
                                            .DsctoIGV = arrText(29).ToString
                                            .ErrorTipo1 = arrText(30).ToString
                                            .ErrorTipo2 = arrText(31).ToString
                                            .ErrorTipo3 = arrText(32).ToString
                                            .ErrorTipo4 = arrText(33).ToString
                                            .IndCancelaComprobPago = arrText(34).ToString
                                            .Indicador = arrText(35).ToString
                                        End With
                                    Case "73"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .TipoDocumento = arrText(3).ToString
                                            .SerieDoc = arrText(4).ToString
                                            .FechaEmision = arrText(5).ToString
                                            .SubTotal1 = arrText(6).ToString
                                            .TipoCambio = arrText(7).ToString
                                            .IGV1 = arrText(8).ToString
                                            .SubTotal2 = arrText(9).ToString
                                            .IGV2 = arrText(10).ToString
                                            .SubTotal3 = arrText(11).ToString
                                            .IGV3 = arrText(12).ToString
                                            .NoGravada = arrText(13).ToString
                                            .Indicador = arrText(14).ToString
                                        End With
                                    Case "74"
                                        With oeDetalleLE
                                            .Periodo = arrText(0).ToString
                                            .CodigoUnicoOperacion = arrText(1).ToString
                                            .NumeroCorrelativo = arrText(2).ToString
                                            .TipoDocumento = arrText(3).ToString
                                            .SerieDoc = arrText(4).ToString
                                            .FechaEmision = arrText(5).ToString
                                            .AnioEmisionDUA = arrText(6).ToString
                                            .FechaVencimiento = arrText(7).ToString
                                            .SubTotal1 = arrText(8).ToString
                                            .Total = arrText(9).ToString
                                            .Indicador = arrText(10).ToString
                                        End With
                                End Select
                        End Select
                        leDetalleLE.Add(oeDetalleLE)
                        oeDetalleLE = New e_DetalleLibroElectronico
                        arrText.Clear()
                    End If
                Loop Until sLine Is Nothing
                objReader.Close()
                griLista.DataSource = leDetalleLE
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Function ValidaPeridoDeclarado() As Boolean
        Try
            Dim oeLibroElec As New e_LibroElectronico
            oeLibroElec.IdTablaContableDet = cboLibroGuarda.Value
            oeLibroElec.IdPeriodo = cboMesGuarda.Value
            oeLibroElec = olLibroElectronico.Obtener(oeLibroElec)
            If oeLibroElec.Id <> "" Then
                Throw New Exception("El Libro Electronico de : " & cboLibroGuarda.Text _
                                    & " Periodo: " & dtp_FechaGuarda.Value.Year.ToString & "-" & FormatoDocumento(cboMesGuarda.Text, 2) & " ya ha sido Declarado!!!")
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ConfigurarListaValorizado(loValorizado As List(Of e_DetalleLibroElectronico))
        Try
            Dim CodMatAlm As String
            Dim PeriodoActual As String = oeDetalleLE._Ejercicio + oeDetalleLE._Mes
            Dim PeriodoLista As String
            Dim Cont As Integer = 0
            Dim IndMat As Boolean = False
            ' Resumir salidas de materiales en el misma orden
            leInventarioFiltro = New List(Of e_DetalleLibroElectronico)
            oeInventarioFiltro = New e_DetalleLibroElectronico
            For Each _oe As e_DetalleLibroElectronico In loValorizado
                _oe.Equivale = 2
                If Not leInventarioFiltro.Contains(_oe) Then
                    leInventarioFiltro.Add(_oe.Clonar)
                Else
                    oeInventarioFiltro = leInventarioFiltro.Item(leInventarioFiltro.IndexOf(_oe))
                    If _oe.SubTotal1 > 0 Then oeInventarioFiltro.SubTotal1 = oeInventarioFiltro.SubTotal1 + _oe.SubTotal1
                    If _oe.IGV2 > 0 Then oeInventarioFiltro.IGV2 = oeInventarioFiltro.IGV2 + _oe.IGV2
                End If
            Next
            ' Cargar los Costos de Ingresos y Salidas
            'For Each oe As e_DetalleLibroElectronico In loValorizado
            For Each oe As e_DetalleLibroElectronico In leInventarioFiltro
                IndMat = False
                CodMatAlm = ""
                oe.SubTotal2 = Math.Round(oe.SubTotal1, 2) * Math.Round(oe.IGV1, 2) ' CostoTotalIngreso = CantidadIngreso * CostoUnitarioIngreso
                PeriodoLista = Strings.Left(oe.Periodo, 6)
                If PeriodoLista <> PeriodoActual Then
                    CodMatAlm = oe.CodConvenio.Trim + oe.ErrorTipo2.Trim ' CodMaterialAlmacen = CodigoMaterial + CodigoAlmacen
                    'If loValorizado.Where(Function(i) i.CodConvenio.Trim + oe.ErrorTipo2.Trim = CodMatAlm).Count > 1 Then
                    If leInventarioFiltro.Where(Function(i) i.CodConvenio.Trim + oe.ErrorTipo2.Trim = CodMatAlm).Count > 1 Then
                        oe.IndCancelaComprobPago = 9
                    Else
                        oe.IndCancelaComprobPago = 8
                    End If
                End If
                If Cont > 0 Then
                    'If oe.CodConvenio.Trim = loValorizado.Item(Cont - 1).CodConvenio.Trim Then IndMat = True
                    If oe.CodConvenio.Trim = leInventarioFiltro.Item(Cont - 1).CodConvenio.Trim Then IndMat = True ' CodigoMaterial = CodigoMaterial Anterior
                    ' CantidadSaldo = CantidadSaldo Anterior + Cantidad(I/S) or Cantidad(I/S) = Cantidad(I/S)  
                    oe.NoGravada = Math.Round(IIf(IndMat, leInventarioFiltro.Item(Cont - 1).NoGravada + oe.SubTotal1 - oe.IGV2, oe.SubTotal1 - oe.IGV2), 2)
                    'oe.NoGravada = Math.Round(IIf(IndMat, loValorizado.Item(Cont - 1).NoGravada + oe.SubTotal1 - oe.IGV2, oe.SubTotal1 - oe.IGV2), 2)
                    If Not IndMat Then
                        oe.OtrosTributos = oe.SubTotal2 ' CostoTotalSaldo = CostoTotalINgreso
                        ' CostoUnitarioSaldo = CostoTotalSaldo / CantidadSaldo
                        oe.ISC = IIf(oe.NoGravada <> 0, oe.OtrosTributos / oe.NoGravada, 0)
                    End If
                    If oe.IGV2 > 0 Then ' CantidadSalida
                        'oe.SubTotal3 = Math.Round(IIf(IndMat, loValorizado.Item(Cont - 1).ISC, 0), 2)
                        oe.SubTotal3 = Math.Round(IIf(IndMat, leInventarioFiltro.Item(Cont - 1).ISC, 0), 2) ' CostoUnitarioSalida
                    Else
                        oe.SubTotal3 = 0
                    End If
                    ' CostoTotalSalida = CantidadSalida * CostoUnitarioSalida
                    oe.IGV3 = Math.Round(oe.IGV2, 2) * Math.Round(oe.SubTotal3, 2)
                    If IndMat Then
                        ' CostoTotalSaldo = CostoTotalSaldo + CostoTotalIngreso or CostoTotalSaldo = CostoTotalSaldo - CostoTotalSalida
                        oe.OtrosTributos = Math.Round(IIf(oe.SubTotal2 > 0, leInventarioFiltro.Item(Cont - 1).OtrosTributos + oe.SubTotal2, leInventarioFiltro.Item(Cont - 1).OtrosTributos - oe.IGV3), 2)
                        'oe.OtrosTributos = Math.Round(IIf(oe.SubTotal2 > 0, loValorizado.Item(Cont - 1).OtrosTributos + oe.SubTotal2, loValorizado.Item(Cont - 1).OtrosTributos - oe.IGV3), 2)
                        ' CostoUnitarioSaldo = CostoTotalSaldo / CantidadSaldo
                        oe.ISC = Math.Round(IIf(oe.NoGravada <> 0, oe.OtrosTributos / oe.NoGravada, 0), 2)
                    End If
                Else
                    oe.NoGravada = oe.SubTotal1 ' CantidadSaldo
                    oe.ISC = oe.IGV1 ' CostoUnitarioSaldo
                    oe.OtrosTributos = oe.SubTotal2 ' CostoTotalSaldo
                End If
                Cont += 1
            Next
            ' Cargar Negativos a las Salidas
            'For Each oe As e_DetalleLibroElectronico In loValorizado
            For Each oe As e_DetalleLibroElectronico In leInventarioFiltro
                If Math.Round(oe.NoGravada, 2) = 0 Then ' CantidadSaldo 
                    oe.ISC = 0 ' CostoUnitarioSaldo
                    oe.OtrosTributos = 0 ' CostoTotalSaldo
                End If
                If oe.IGV2 > 0 Then  ' CantidadSalida
                    oe.IGV2 *= -1
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarListaUnidades(loValorizado As List(Of e_DetalleLibroElectronico))
        Try
            Dim CodMatAlm As String
            Dim PeriodoActual As String = oeDetalleLE._Ejercicio + oeDetalleLE._Mes
            Dim PeriodoLista As String
            For Each oe As e_DetalleLibroElectronico In loValorizado
                CodMatAlm = ""
                PeriodoLista = Strings.Left(oe.Periodo, 6)
                If PeriodoLista <> PeriodoActual Then
                    CodMatAlm = oe.CodConvenio.Trim + oe.ErrorTipo2.Trim
                    If loValorizado.Where(Function(i) i.CodConvenio.Trim + oe.ErrorTipo2.Trim = CodMatAlm).Count > 1 Then
                        oe.IndCancelaComprobPago = 9
                    Else
                        oe.IndCancelaComprobPago = 8
                    End If
                End If
                If oe.SubTotal2 > 0 Then
                    oe.SubTotal2 = oe.SubTotal2 * -1
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarGrillaValorizado()
        Try
            With griPermanenteValorizado
                .DataSource = New List(Of e_DetalleLibroElectronico)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = 1
                .DisplayLayout.Bands(0).Columns("IdLibroElectronico").Hidden = 1
                .DisplayLayout.Bands(0).Columns("IdMovimientoDocumento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Total").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoCambio").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaEmisionAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoDocumentoAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("SerieAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocAso2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaEmisionDetraccion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Retencion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = 1
                .DisplayLayout.Bands(0).Columns("CodigoMoneda").Hidden = 1
                .DisplayLayout.Bands(0).Columns("ClasificacionBienServicio").Hidden = 1
                .DisplayLayout.Bands(0).Columns("DsctoBaseImp").Hidden = 1
                .DisplayLayout.Bands(0).Columns("DsctoIGV").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("AnioEmisionDUA").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDoc2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoDocIdentidad").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocIdentidad").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Denominacion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("ErrorTipo1").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoVenta").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoCompra").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoConsignacion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("CodigoDuaDsiFob").Hidden = 1

                .DisplayLayout.Bands(0).Columns("Periodo").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("ErrorTipo2").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("CodConvenio").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("CodPais").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("SerieDoc").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Indicador").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("SubTotal1").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("Igv1").Header.VisiblePosition = 17
                .DisplayLayout.Bands(0).Columns("SubTotal2").Header.VisiblePosition = 18
                .DisplayLayout.Bands(0).Columns("Igv2").Header.VisiblePosition = 19
                .DisplayLayout.Bands(0).Columns("SubTotal3").Header.VisiblePosition = 20
                .DisplayLayout.Bands(0).Columns("Igv3").Header.VisiblePosition = 21
                .DisplayLayout.Bands(0).Columns("NoGravada").Header.VisiblePosition = 22
                .DisplayLayout.Bands(0).Columns("Isc").Header.VisiblePosition = 23
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Header.VisiblePosition = 24
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Header.VisiblePosition = 25

                .DisplayLayout.Bands(0).Columns("Periodo").Width = 70
                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Width = 100
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Width = 80
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Width = 70
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Width = 70
                .DisplayLayout.Bands(0).Columns("CodConvenio").Width = 70
                .DisplayLayout.Bands(0).Columns("CodPais").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 80
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 60
                .DisplayLayout.Bands(0).Columns("SerieDoc").Width = 60
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Width = 80
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Width = 60
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Width = 120
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Width = 70
                .DisplayLayout.Bands(0).Columns("Indicador").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal1").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv1").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal2").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv2").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal3").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv3").Width = 70
                .DisplayLayout.Bands(0).Columns("NoGravada").Width = 70
                .DisplayLayout.Bands(0).Columns("Isc").Width = 70
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Width = 70
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Width = 70

                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Header.Caption = "CUO"
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Header.Caption = "Correlativo"
                .DisplayLayout.Bands(0).Columns("ErrorTipo2").Header.Caption = "Establecimiento"
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Header.Caption = "Catalogo"
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Header.Caption = "Tipo Exist."
                .DisplayLayout.Bands(0).Columns("CodConvenio").Header.Caption = "Cod. Mat."
                .DisplayLayout.Bands(0).Columns("CodPais").Header.Caption = "OSCE"
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "F. Emision"
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "Tipo Doc."
                .DisplayLayout.Bands(0).Columns("SerieDoc").Header.Caption = "Serie"
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Header.Caption = "Numero"
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Header.Caption = "Tipo Ope."
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Header.Caption = "Descripcion"
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Header.Caption = "U. Medida"
                .DisplayLayout.Bands(0).Columns("Indicador").Header.Caption = "Valuacion"
                .DisplayLayout.Bands(0).Columns("SubTotal1").Header.Caption = "Cant. I"
                .DisplayLayout.Bands(0).Columns("Igv1").Header.Caption = "Costo I"
                .DisplayLayout.Bands(0).Columns("SubTotal2").Header.Caption = "Total I"
                .DisplayLayout.Bands(0).Columns("Igv2").Header.Caption = "Cant. S"
                .DisplayLayout.Bands(0).Columns("SubTotal3").Header.Caption = "Costo S"
                .DisplayLayout.Bands(0).Columns("Igv3").Header.Caption = "Total S"
                .DisplayLayout.Bands(0).Columns("NoGravada").Header.Caption = "Saldo"
                .DisplayLayout.Bands(0).Columns("Isc").Header.Caption = "CostoSaldo"
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Header.Caption = "SaldoTotal"
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Header.Caption = "Est. Ope."

                .DisplayLayout.Bands(0).Columns("SubTotal1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Igv1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("SubTotal2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Igv2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("SubTotal3").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Igv3").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("NoGravada").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Isc").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("OtrosTributos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .DisplayLayout.Bands(0).Columns("SubTotal1").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("Igv1").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("SubTotal2").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("Igv2").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("SubTotal3").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("Igv3").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("NoGravada").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("Isc").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("OtrosTributos").MaskInput = "{double:-9.2}"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarGrillaUnidades()
        Try
            With gridPermanenteUF
                .DataSource = New List(Of e_DetalleLibroElectronico)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = 1
                .DisplayLayout.Bands(0).Columns("IdLibroElectronico").Hidden = 1
                .DisplayLayout.Bands(0).Columns("IdMovimientoDocumento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Total").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoCambio").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaEmisionAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoDocumentoAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("SerieAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocAso2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaEmisionDetraccion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Retencion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Indicador").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = 1
                .DisplayLayout.Bands(0).Columns("CodigoMoneda").Hidden = 1
                .DisplayLayout.Bands(0).Columns("ClasificacionBienServicio").Hidden = 1
                .DisplayLayout.Bands(0).Columns("DsctoBaseImp").Hidden = 1
                .DisplayLayout.Bands(0).Columns("DsctoIGV").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("AnioEmisionDUA").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDoc2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoDocIdentidad").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocIdentidad").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Denominacion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("ErrorTipo1").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoVenta").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoCompra").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoConsignacion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("CodigoDuaDsiFob").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Indicador").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Igv1").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Igv2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("SubTotal3").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Igv3").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NoGravada").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Isc").Hidden = 1
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Hidden = 1

                .DisplayLayout.Bands(0).Columns("Periodo").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("ErrorTipo2").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("CodConvenio").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("CodPais").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("SerieDoc").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("SubTotal1").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("SubTotal2").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Header.VisiblePosition = 17

                .DisplayLayout.Bands(0).Columns("Periodo").Width = 70
                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Width = 100
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Width = 80
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Width = 70
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Width = 70
                .DisplayLayout.Bands(0).Columns("CodConvenio").Width = 70
                .DisplayLayout.Bands(0).Columns("CodPais").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 80
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 60
                .DisplayLayout.Bands(0).Columns("SerieDoc").Width = 60
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Width = 80
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Width = 60
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Width = 120
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Width = 70
                .DisplayLayout.Bands(0).Columns("Indicador").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal1").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv1").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal2").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv2").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal3").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv3").Width = 70
                .DisplayLayout.Bands(0).Columns("NoGravada").Width = 70
                .DisplayLayout.Bands(0).Columns("Isc").Width = 70
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Width = 70
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Width = 70

                .DisplayLayout.Bands(0).Columns("ErrorTipo2").Header.Caption = "Establecimiento"
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Header.Caption = "Catalogo"
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Header.Caption = "Tipo Exist."
                .DisplayLayout.Bands(0).Columns("CodConvenio").Header.Caption = "Cod. Mat."
                .DisplayLayout.Bands(0).Columns("CodPais").Header.Caption = "OSCE"
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "F. Emision"
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "Tipo Doc."
                .DisplayLayout.Bands(0).Columns("SerieDoc").Header.Caption = "Serie"
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Header.Caption = "Numero"
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Header.Caption = "Tipo Ope."
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Header.Caption = "Descripcion"
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Header.Caption = "U. Medida"
                .DisplayLayout.Bands(0).Columns("SubTotal1").Header.Caption = "Ingreso"
                .DisplayLayout.Bands(0).Columns("SubTotal2").Header.Caption = "Salida"
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Header.Caption = "Est. Ope."

                .DisplayLayout.Bands(0).Columns("SubTotal1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("SubTotal2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .DisplayLayout.Bands(0).Columns("SubTotal1").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("SubTotal2").MaskInput = "{double:-9.2}"

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ControlBotoneria()
        Select Case ficLibroElectronico.SelectedTab.Index
            Case 0
                If griLista.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1)
                Else
                    ControlBoton(1, 1, 0)
                End If
            Case 1
                If Operacion = "Editar" Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 1, 1, 1)
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
                End If
        End Select
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    'Private Sub frm_LibrosElectronicos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    InicializaTiempo()
    'End Sub

    'Private Sub griLista_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griLista.MouseMove
    '    If _tiempo <= 0 Then
    '        Consultar(True)
    '    End If
    '    InicializaTiempo()
    'End Sub

    'Public Overloads Function InicializaTiempo() As Integer
    '    _tiempo = 120
    'End Function

#End Region

#Region "Menú contextual del maestro de Demandas rápidas"

    Private Sub AsociarMenu()
        griLista.ContextMenuStrip = Menu
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Eliminar()
    End Sub

#End Region

End Class