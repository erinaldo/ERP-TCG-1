'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop

Public Class frm_Utilidad
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Utilidad = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Utilidad()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeUtilidad As New e_Utilidad, olUtilidad As New l_Utilidad, leUtilidad As New List(Of e_Utilidad)
    Private oeConsolidado As New e_ConsolidadoUtilidad, olConsolidado As New l_ConsolidadoUtilidad
    Private leConsolidado As New List(Of e_ConsolidadoUtilidad), leConsolidadoImportar As New List(Of e_ConsolidadoUtilidad)
    Private oeDetalle As New e_DetalleUtilidad, olDetalle As New l_DetalleUtilidad, leDetalle As New List(Of e_DetalleUtilidad)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeAsientoModel As e_AsientoModelo, olAsientoModel As l_AsientoModelo, leAsientoModel As List(Of e_AsientoModelo)
    Private oePeriodo As e_Periodo, olPeriodo As l_Periodo
    Private _opeUtilidad As String = "", _acl As String = "", _estado As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griUtilidad.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Operacion = "Nuevo"
        _opeUtilidad = "GENERADA"
        oeUtilidad = New e_Utilidad
        oeUtilidad.TipoOperacion = "I"
        oeUtilidad.Activo = True
        Inicializa()
        txtCodigo.Text = fn_ObtenerCodigo()
        'LlenarCombo(cboPlanilla, "Codigo", lePlanillaGen, -1)
        'cboPlanilla.ReadOnly = False
        cboEstado.Text = "GENERADA"
        SeleccionaTab(1)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializa()
            'LlenarCombo(cboPlanilla, "Codigo", lePlanilla, -1)
            Mostrar()
            oeUtilidad.TipoOperacion = "A"
            SeleccionaTab(1)
            'cboPlanilla.ReadOnly = True                
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficUtilidad.SelectedTab.Index
                Case 1
                    Select Case _opeUtilidad
                        Case "GENERADA"
                            With oeUtilidad
                                .TipoOperacion = "I"
                                .Codigo = txtCodigo.Text
                                .Año = Año1.Año
                                .Activo = True
                                .MontoDistribucion = ndMontoDistribuir.Value
                                .MontoBase = ndMontoBase.Value
                                .PorcentajeParticipacion = ndPorcParti.Value
                                .CantidadTrabajadores = nCanTrabajador.Value
                                .TotalDiasAnual = numTotalDias.Value
                                .TotalSueldoAnual = decTotalSueldo.Value
                                .IdEstado = cboEstado.Value
                                .UsuarioCreacion = gUsuarioSGI.Id
                                .leConsolidado = leConsolidado
                                .leDetalle = leDetalle
                                .PrefijoID = gs_PrefijoIdSucursal '@0001
                                If olUtilidad.ImportarDatos(oeUtilidad) Then
                                    mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente", True)
                                    SeleccionaTab(0)
                                    Consultar(True)
                                End If
                            End With
                        Case "ENVIAR"
                            oeUtilidad.TipoOperacion = "A"
                            oeUtilidad.IdEstado = cboEstado.Value
                            oeUtilidad.UsuarioModifica = gUsuarioSGI.Id
                            oeUtilidad.PrefijoID = gs_PrefijoIdSucursal '@0001
                            If olUtilidad.Guardar(oeUtilidad) Then
                                mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente", True)
                                SeleccionaTab(0)
                                Consultar(True)
                            End If
                        Case "PROVISIONAR"
                            If decTipoCambio.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
                            oePeriodo = New e_Periodo
                            oePeriodo.TipoOperacion = String.Empty : oePeriodo.Activo = True
                            oePeriodo.Ejercicio = fecProvision.Value.Date.Year : oePeriodo.Mes = fecProvision.Value.Date.Month
                            oePeriodo = olPeriodo.Obtener(oePeriodo)
                            oeAsientoModel = New e_AsientoModelo
                            oeAsientoModel.TipoOperacion = String.Empty : oeAsientoModel.Id = leAsientoModel(0).Id
                            oeAsientoModel.Ejercicio = oePeriodo.Ejercicio
                            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                            oeAsientoModel.FechaMov = fecProvision.Value
                            oeAsientoModel.TipoCambio = decTipoCambio.Value
                            oeAsientoModel.UsuarioCreacion = gUsuarioSGI.Id
                            oeUtilidad.IdEstado = cboEstado.Value
                            oeUtilidad.UsuarioModifica = gUsuarioSGI.Id
                            If olUtilidad.Provisionar(oeUtilidad, oeAsientoModel, oePeriodo) Then
                                mensajeEmergente.Confirmacion("¡El Registro de Utilidad Nº: " & oeUtilidad.Codigo & " se Termino correctamente!", True)
                                SeleccionaTab(0)
                                Consultar(True)
                            End If
                    End Select
                Case 2
                    Dim _leAux = leConsolidadoImportar.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        oeUtilidad = New e_Utilidad
                        oeUtilidad.TipoOperacion = "I"
                        oeUtilidad.Codigo = fn_ObtenerCodigo()
                        Dim _leEst = leEstado.Where(Function(it) it.Nombre = "PERDIDOS").ToList
                        If _leEst.Count > 0 Then oeUtilidad.IdEstado = _leEst(0).Id
                        oeUtilidad.IndImportar = True
                        oeUtilidad.Activo = True
                        oeUtilidad.MontoDistribucion = ndMontoDistribuirUI.Value
                        oeUtilidad.MontoBase = ndMontoBaseUI.Value
                        oeUtilidad.PorcentajeParticipacion = ndPorcParticipacionUI.Value
                        oeUtilidad.CantidadTrabajadores = nCanTrabajadorUI.Value
                        oeUtilidad.leConsolidado = _leAux
                        oeUtilidad.Año = Año3.Año
                        oeUtilidad.UsuarioCreacion = gUsuarioSGI.Id
                        olUtilidad.ImportarDatos(oeUtilidad)
                        mensajeEmergente.Confirmacion("Los Datos han sido Importados Correctamente!!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    Else
                        Throw New Exception("No hay Registros Validados para Importar")
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case ficUtilidad.SelectedTab.Index
                Case 1
                    If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                Case 2
                    If MessageBox.Show("¿Desea Cancelar la Importacion de Datos?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficUtilidad.SelectedTab.Index
                Case 0
                    If griUtilidad.Rows.Count = 0 Then Throw New Exception("No Hay Datos que Exportar. Verificar")
                    Exportar_Excel(griUtilidad)
                Case 1
                    Select Case ficDetalle.SelectedTab.Index
                        Case 0
                            If griUtilidadDetalle.Rows.Count = 0 Then Throw New Exception("No Hay Datos que Exportar. Verificar")
                            Exportar_Excel(griUtilidadDetalle)
                        Case 1
                            If griUtilidadConsolidado.Rows.Count = 0 Then Throw New Exception("No Hay Datos que Exportar. Verificar")
                            Exportar_Excel(griUtilidadConsolidado)
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Utilidad_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            Select Case ficUtilidad.SelectedTab.Index
                Case 0
                    If griUtilidad.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 1
                    If Operacion = "Nuevo" Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                    Else
                        ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 0)
                    End If

                Case 2
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Utilidad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Utilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            olAsientoModel = New l_AsientoModelo
            olPeriodo = New l_Periodo
            CargarCombos()
            CargarDetalle(New List(Of e_ConsolidadoUtilidad))
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            SeleccionaTab(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()

                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                leConsolidadoImportar.Clear()

                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 2).Value Is Nothing) Then
                        oeConsolidado = New e_ConsolidadoUtilidad
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        End If
                        With oeConsolidado
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .IndSituacion = IIf(objWorkSheet.Cells(ln_Fila + 1, 3).Value = "ACTIVO", 1, 0)
                            .SueldoAnual = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 4).Value, 2)
                            .Subsidios = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 5).Value, 2)
                            .SueldoNetoAnual = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 6).Value, 2)
                            .UtilidadporSueldo = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 7).Value, 2)
                            .DiasTrabajadosAnual = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 8).Value, 2)
                            .UtilidadporDiasTrabajados = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 9).Value, 2)
                            .UtilidadTotal = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 10).Value, 2)
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .Activo = False
                        End With
                        leConsolidadoImportar.Add(oeConsolidado)
                    Else
                        Exit For
                    End If
                Next

                CargarDetImportar(leConsolidadoImportar)
                griImportar.DataBind()

                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True
                    objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then
                    proceso(proceso.Length - 1).Kill()
                End If
            Else
                OpenFileDialog1.Dispose()
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

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Try
            If leConsolidadoImportar.Count > 0 Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                For Each oeAux In leConsolidadoImportar
                    ' Verifica si los Trabajadores entan registradas en el SGI
                    If oeAux.IdTrabajador = "" Then
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = oeAux.Dni
                        If leTrabajador.Contains(oeTrabajador) Then
                            Dim _leAux = leTrabajador.Where(Function(it) it.oePersona.Dni = oeTrabajador.oePersona.Dni).ToList
                            If _leAux.Count > 0 Then
                                oeTrabajador = _leAux(0)
                                oeAux.IdTrabajador = oeTrabajador.Id
                                oeAux.Activo = True
                            End If
                        End If
                    Else
                        oeAux.Activo = True
                    End If
                Next
                CargarDetImportar(leConsolidadoImportar)
                griImportar.DataBind()
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            ugb_Espera.Visible = False
            mensajeEmergente.Confirmacion("Los Datos se Validaron Correctamente!!", True)
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            ListarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnConsolidar_Click(sender As Object, e As EventArgs) Handles btnConsolidar.Click
        Try
            If ndMontoBase.Value > 0 And ndMontoDistribuir.Value > 0 Then
                ConsolidarUtilidades()
            Else
                Throw New Exception("No Puede Consolidar las Utilidades sin MontoBase y/o sin Monto a Distribuir")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griUtilidad_DoubleClick(sender As Object, e As EventArgs) Handles griUtilidad.DoubleClick
        Editar()
    End Sub

    Private Sub btnMontoLiq_Click(sender As Object, e As EventArgs) Handles btnMontoLiq.Click
        Try
            If griUtilidadConsolidado.Rows.Count = 0 Then Throw New Exception("¡No se ha consolidad la información!")
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        oeConsolidado = New e_ConsolidadoUtilidad
                        oeConsolidado.Equivale = 3
                        oeConsolidado.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leConsolidado.Contains(oeConsolidado) Then
                            oeConsolidado = leConsolidado.Item(leConsolidado.IndexOf(oeConsolidado))
                            oeConsolidado.Subsidios = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value, 2)
                            oeConsolidado.SueldoNetoAnual = oeConsolidado.SueldoAnual + oeConsolidado.Subsidios
                            'oeConsolidado.UtilidadporSueldo = oeConsolidado.SueldoNetoAnual / decTotalSueldo.Value * ndMontoDistribuir.Value
                            'oeConsolidado.UtilidadTotal = oeConsolidado.UtilidadporSueldo + oeConsolidado.UtilidadporDiasTrabajados
                        Else
                            Throw New Exception("No se encontro Dni: " & oeConsolidado.Dni)
                        End If
                    Else
                        Exit For
                    End If
                Next
                decTotalSueldo.Value = leConsolidado.Sum(Function(it) it.SueldoNetoAnual)
                For Each _oeCon In leConsolidado
                    _oeCon.UtilidadporSueldo = _oeCon.SueldoNetoAnual / decTotalSueldo.Value * ndMontoDistribuir.Value
                    _oeCon.UtilidadTotal = _oeCon.UtilidadporSueldo + _oeCon.UtilidadporDiasTrabajados
                Next
                griUtilidadConsolidado.UpdateData() : griUtilidadConsolidado.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            mensajeEmergente.Confirmacion("Se han Procesado con exito registros", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub btnMontoSub_Click(sender As Object, e As EventArgs) Handles btnMontoSub.Click
        Try
            If griUtilidadConsolidado.Rows.Count = 0 Then Throw New Exception("¡No se ha consolidad la información!")
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        oeConsolidado = New e_ConsolidadoUtilidad
                        oeConsolidado.Equivale = 3
                        oeConsolidado.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leConsolidado.Contains(oeConsolidado) Then
                            oeConsolidado = leConsolidado.Item(leConsolidado.IndexOf(oeConsolidado))
                            oeConsolidado.Subsidios = oeConsolidado.Subsidios - Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value, 2)
                            oeConsolidado.SueldoNetoAnual = oeConsolidado.SueldoAnual + oeConsolidado.Subsidios
                            'oeConsolidado.UtilidadporSueldo = oeConsolidado.SueldoNetoAnual / decTotalSueldo.Value * ndMontoDistribuir.Value
                            'oeConsolidado.UtilidadTotal = oeConsolidado.UtilidadporSueldo + oeConsolidado.UtilidadporDiasTrabajados
                        Else
                            Throw New Exception("No se encontro Dni: " & oeConsolidado.Dni)
                        End If
                    Else
                        Exit For
                    End If
                Next
                decTotalSueldo.Value = leConsolidado.Sum(Function(it) it.SueldoNetoAnual)
                For Each _oeCon In leConsolidado
                    _oeCon.UtilidadporSueldo = _oeCon.SueldoNetoAnual / decTotalSueldo.Value * ndMontoDistribuir.Value
                    _oeCon.UtilidadTotal = _oeCon.UtilidadporSueldo + _oeCon.UtilidadporDiasTrabajados
                Next
                griUtilidadConsolidado.UpdateData() : griUtilidadConsolidado.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            mensajeEmergente.Confirmacion("Se han Procesado con exito registros", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub btnDiasLab_Click(sender As Object, e As EventArgs) Handles btnDiasLab.Click
        Try
            If griUtilidadConsolidado.Rows.Count = 0 Then Throw New Exception("¡No se ha consolidad la información!")
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        oeConsolidado = New e_ConsolidadoUtilidad
                        oeConsolidado.Equivale = 3
                        oeConsolidado.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leConsolidado.Contains(oeConsolidado) Then
                            oeConsolidado = leConsolidado.Item(leConsolidado.IndexOf(oeConsolidado))
                            oeConsolidado.DiasTrabajadosAnual = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                            'oeConsolidado.UtilidadporDiasTrabajados = oeConsolidado.DiasTrabajadosAnual / numTotalDias.Value * ndMontoDistribuir.Value
                            'oeConsolidado.UtilidadTotal = oeConsolidado.UtilidadporSueldo + oeConsolidado.UtilidadporDiasTrabajados
                        Else
                            Throw New Exception("No se encontro Dni: " & oeConsolidado.Dni)
                        End If
                    Else
                        Exit For
                    End If
                Next
                numTotalDias.Value = leConsolidado.Sum(Function(it) it.DiasTrabajadosAnual)
                For Each _oeCon In leConsolidado
                    _oeCon.UtilidadporDiasTrabajados = _oeCon.DiasTrabajadosAnual / numTotalDias.Value * ndMontoDistribuir.Value
                    _oeCon.UtilidadTotal = _oeCon.UtilidadporSueldo + _oeCon.UtilidadporDiasTrabajados
                Next
                griUtilidadConsolidado.UpdateData() : griUtilidadConsolidado.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            mensajeEmergente.Confirmacion("Se han Procesado con exito registros", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub fecProvision_ValueChanged(sender As Object, e As EventArgs) Handles fecProvision.ValueChanged
        Try
            decTipoCambio.Value = 0
            decTipoCambio.Value = TipoCambio(fecProvision.Value.Date)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            oeEstado = New e_Estado
            oeEstado.Nombre = "UTILIDADES"
            leEstado = olEstado.Listar(oeEstado)
            LlenarCombo(cboEstadoBus, "Nombre", leEstado, -1)
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)
            ' Cargar Asiento Modelo
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeUtilidad = New e_Utilidad
            oeUtilidad.TipoOperacion = ""
            oeUtilidad.Activo = True
            leUtilidad = olUtilidad.Listar(oeUtilidad)
            griUtilidad.DataSource = leUtilidad
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        txtCodigo.Text = String.Empty
        cboEstado.SelectedIndex = -1
        ndMontoBase.Value = 0
        ndMontoDistribuir.Value = 0
        nCanTrabajador.Value = 0
        cboEstado.ReadOnly = True
        leConsolidado = New List(Of e_ConsolidadoUtilidad)
        Me.btnConsolidar.Enabled = True
        Me.btnConsultar.Enabled = True
        CargarDetalle(leConsolidado)
    End Sub

    Private Sub CargarDetalle(leDet As List(Of e_ConsolidadoUtilidad))
        Try
            With griUtilidadConsolidado
                .ResetDisplayLayout()
                Dim _leDetAux = leDet.OrderBy(Function(it) it.Trabajador).ToList
                .DataSource = _leDetAux
                ConfiguraGrilla(griUtilidadConsolidado, 1)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetImportar(leImp As List(Of e_ConsolidadoUtilidad))
        Try
            With griImportar

                .ResetDisplayLayout()
                .DataSource = leImp

                ConfiguraGrilla(griImportar, 2)

                ndMontoDistribuirUI.Value = leImp.Sum(Function(it) it.UtilidadTotal)
                ndMontoBaseUI.Value = ndMontoDistribuirUI.Value * 100 / 5
                ndPorcParticipacionUI.Value = 5
                nCanTrabajadorUI.Value = leImp.Count

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(Grilla As UltraGrid, tipo As Integer)
        Try

            With Grilla

                OcultarColumna(Grilla, True, "Id", "IdUtilidad", "IdTrabajador", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModfica", "Activo")
                ExcluirColumna(Grilla, True, "Id", "IdUtilidad", "IdTrabajador")

                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "SueldoAnual", "Subsidios", "SueldoNetoAnual", "UtilidadporSueldo", _
                               "UtilidadporDiasTrabajados", "UtilidadTotal")

                .DisplayLayout.Bands(0).Columns("IndSituacion").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("DiasTrabajadosAnual").CellAppearance.TextHAlign = HAlign.Center

                .DisplayLayout.Bands(0).Columns("SueldoNetoAnual").Header.Caption = "S. Neto Anual"
                .DisplayLayout.Bands(0).Columns("UtilidadporSueldo").Header.Caption = "Util. Sueldo"
                .DisplayLayout.Bands(0).Columns("UtilidadporDiasTrabajados").Header.Caption = "Util. Dias"
                .DisplayLayout.Bands(0).Columns("DiasTrabajadosAnual").Header.Caption = "Dias Trab."
                .DisplayLayout.Bands(0).Columns("IndSituacion").Header.Caption = "Activo"

                ColorFondoColumna(Grilla, Color.Moccasin, "Trabajador", "Dni", "IndSituacion")

                ColorFondoColumna(Grilla, Color.LightCyan, "SueldoAnual", "Subsidios", "SueldoNetoAnual", "DiasTrabajadosAnual")

                ColorFondoColumna(Grilla, Color.LightSkyBlue, "UtilidadporSueldo", "UtlidadporDiasTrabajados")

                .DisplayLayout.Bands(0).Columns("UtilidadTotal").CellAppearance.BackColor = Color.Navy
                .DisplayLayout.Bands(0).Columns("UtilidadTotal").CellAppearance.ForeColor = Color.White

                If tipo = 2 Then
                    OcultarColumna(Grilla, False, "Activo")
                    .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                End If

                .DisplayLayout.Bands(0).Columns("Dni").Width = 75
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                .Text = ""

                CalcularTotales(Grilla, "SueldoNetoAnual", "UtilidadporSueldo", "DiasTrabajadosAnual", "UtlidadporDiasTrabajados", "UtilidadTotal")

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oeUti As New e_Utilidad
            oeUti.TipoOperacion = "U"
            oeUti = olUtilidad.Obtener(oeUti)
            If oeUti IsNot Nothing AndAlso oeUti.Codigo <> "" Then
                str = oeUti.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub SeleccionaTab(_index As Integer)
        ficUtilidad.Tabs(0).Enabled = False
        ficUtilidad.Tabs(1).Enabled = False
        ficUtilidad.Tabs(2).Enabled = False
        ficUtilidad.Tabs(_index).Enabled = True
        ficUtilidad.Tabs(_index).Selected = True
    End Sub

    Private Sub Mostrar()
        Try
            oeUtilidad = New e_Utilidad
            oeUtilidad.TipoOperacion = ""
            oeUtilidad.Id = griUtilidad.ActiveRow.Cells("Id").Value
            oeUtilidad = olUtilidad.Obtener(oeUtilidad)
            With oeUtilidad
                txtCodigo.Text = .Codigo
                cboEstado.Value = .IdEstado
                ndMontoBase.Value = .MontoBase
                ndPorcParti.Value = .PorcentajeParticipacion
                ndMontoDistribuir.Value = .MontoDistribucion
                nCanTrabajador.Value = .CantidadTrabajadores
                leConsolidado = .leConsolidado
                CargarDetalle(leConsolidado)
                griUtilidadDetalle.DataSource = oeUtilidad.leDetalle
                Me.decTotalSueldo.Value = oeUtilidad.leDetalle.Sum(Function(item) item.IngresoMensual)
                Me.numTotalDias.Value = oeUtilidad.leDetalle.Sum(Function(item) item.DiasLaborados)
                CalcularTotales(griUtilidadDetalle, "IngresoMensual", "DiasLaborados")
                Me.btnConsolidar.Enabled = False
                Me.btnConsultar.Enabled = False
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarDetalle()
        Try
            oeDetalle = New e_DetalleUtilidad
            oeDetalle.TipoOperacion = "1"
            oeDetalle.Año = Año1.Año
            leDetalle.AddRange(olDetalle.Listar(oeDetalle))
            griUtilidadDetalle.DataSource = leDetalle
            If leDetalle.Count > 0 Then
                Me.decTotalSueldo.Value = leDetalle.Sum(Function(item) item.IngresoMensual)
                Me.numTotalDias.Value = leDetalle.Sum(Function(item) item.DiasLaborados)
            End If
            CalcularTotales(griUtilidadDetalle, "IngresoMensual", "DiasLaborados")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConsolidarUtilidades()
        Try
            If griUtilidadDetalle.Rows.Count > 0 Then

                Dim loListaAux As New List(Of e_DetalleUtilidad)
                Dim IdTrabajador As String = ""
                leConsolidado = New List(Of e_ConsolidadoUtilidad)
                loListaAux = leDetalle.OrderBy(Function(item) item.IdTrabajador).ToList
                For Each detuti As e_DetalleUtilidad In loListaAux
                    oeConsolidado = New e_ConsolidadoUtilidad
                    With oeConsolidado
                        If IdTrabajador <> detuti.IdTrabajador Then
                            IdTrabajador = detuti.IdTrabajador
                            .Id = ""
                            .Dni = detuti.DNI
                            .IdTrabajador = detuti.IdTrabajador
                            .Trabajador = detuti.Trabajador
                            .IndSituacion = detuti.IndEstado
                            .SueldoAnual = loListaAux.Where(Function(item) item.IdTrabajador = IdTrabajador).Sum(Function(item) item.IngresoMensual)
                            .SueldoNetoAnual = .SueldoAnual
                            .UtilidadporSueldo = .SueldoNetoAnual / decTotalSueldo.Value * ndMontoDistribuir.Value
                            .DiasTrabajadosAnual = loListaAux.Where(Function(item) item.IdTrabajador = IdTrabajador).Sum(Function(item) item.DiasLaborados)
                            .UtilidadporDiasTrabajados = .DiasTrabajadosAnual / numTotalDias.Value * ndMontoDistribuir.Value
                            .UtilidadTotal = .UtilidadporSueldo + .UtilidadporDiasTrabajados
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .Activo = True
                            leConsolidado.Add(oeConsolidado)
                        End If
                    End With
                Next
                nCanTrabajador.Value = leConsolidado.Count
                CargarDetalle(leConsolidado)
                griUtilidadConsolidado.DataBind()
                ficDetalle.Tabs(1).Selected = True
            Else
                Throw New Exception("No existe Detalle para Consolidar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Enviar()
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griUtilidad.ActiveRow.Cells("Estado").Value = _estado Then
                    Editar()
                    _estado = gNombreEstadoEnviado
                    cboEstado.Text = _estado
                    _opeUtilidad = "ENVIAR"
                    btnConsultar.Enabled = False
                    btnConsolidar.Enabled = False
                    btnMontoLiq.Enabled = False
                    btnMontoSub.Enabled = False
                    btnDiasLab.Enabled = False
                Else
                    Throw New Exception("No puede en ENVIAR El Registro de Participaciones " & Environment.NewLine & _
                                        "Nº: " & griUtilidad.ActiveRow.Cells("Codigo").Value & " por que no esta en GENERADA." & _
                                        Environment.NewLine & "O no tiene ni un solo registro de detalle.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Provisionar()
        Try
            _acl = gAccionSistema.PROVISIONAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griUtilidad.ActiveRow.Cells("Estado").Value = _estado Then
                    Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                    Editar()
                    For Each oeDetUti In oeUtilidad.leConsolidado
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 1 : oeTrabajador.Id = oeDetUti.IdTrabajador
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                            If oeTrabajador.oeArea.Nombre <> gNombreAreaOperaciones And oeTrabajador.oeArea.Nombre <> gNombreAreaMantenimiento Then
                                oeDetUti.IndAdministrativo = 1
                            End If
                        End If
                    Next
                    _estado = gNombreEstadoTerminada
                    cboEstado.Text = _estado
                    _opeUtilidad = "PROVISIONAR"
                    btnConsultar.Enabled = False
                    btnConsolidar.Enabled = False
                    btnMontoLiq.Enabled = False
                    btnMontoSub.Enabled = False
                    btnDiasLab.Enabled = False
                Else
                    Throw New Exception("No puede en ENVIAR El Registro de Participaciones " & Environment.NewLine & _
                                        "Nº: " & griUtilidad.ActiveRow.Cells("Codigo").Value & " por que no esta en ENVIADA." & _
                                        Environment.NewLine & "O no tiene ni un solo registro de detalle.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mcUtilidad_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcUtilidad.Opening
        mcUtilidad.Items("tsmiNuevo").Enabled = True
        mcUtilidad.Items("tsmiImportar").Enabled = True
        If griUtilidad.Rows.Count > 0 Then
            mcUtilidad.Items("tsmiEditar").Enabled = True
            mcUtilidad.Items("tsmiEliminar").Enabled = True
            mcUtilidad.Items("tsmiExportar").Enabled = True
        Else
            mcUtilidad.Items("tsmiEditar").Enabled = False
            mcUtilidad.Items("tsmiEliminar").Enabled = False
            mcUtilidad.Items("tsmiExportar").Enabled = False
        End If
    End Sub

    Private Sub tsmiImportar_Click(sender As Object, e As EventArgs) Handles tsmiImportar.Click
        ndMontoBaseUI.Value = 0
        ndMontoDistribuirUI.Value = 0
        ndPorcParticipacionUI.Value = 0
        nCanTrabajadorUI.Value = 0
        leConsolidadoImportar = New List(Of e_ConsolidadoUtilidad)
        CargarDetImportar(leConsolidadoImportar)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        SeleccionaTab(2)
    End Sub

    Private Sub tsmiEnviar_Click(sender As Object, e As EventArgs) Handles tsmiEnviar.Click
        Try
            If griUtilidad.Selected.Rows.Count > 0 Then Enviar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiProvisionar_Click(sender As Object, e As EventArgs) Handles tsmiProvisionar.Click
        Try
            If griUtilidad.Selected.Rows.Count > 0 Then Provisionar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class