'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop

Public Class frm_SueldoTrabajador
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New(Accion As String, oeSueTra As e_SueldoTrabajador, oeTrabAux As e_Trabajador)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        mnuMantSueTra.Visible = True
        bandcargar = False
        Inicializa()
        CargarCombos()
        oeSueldoTrabajador = oeSueTra
        leSueldoTrabajador = oeTrabAux.leSueldo
        Select Case Accion
            Case "Agregar"
                cboTrabajador.Value = oeSueldoTrabajador.IdTrabajador
            Case "Editar"
                CargarDatos(oeSueldoTrabajador)
                'cboTipoDocumento.ReadOnly = True
        End Select
        cboTrabajador.ReadOnly = True
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mnuMantSueTra.Visible = False
    End Sub

    Private Shared instancia As frm_SueldoTrabajador = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_SueldoTrabajador()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeSueldoTrabajador As New e_SueldoTrabajador, olSueldoTrabajador As New l_SueldoTrabajador
    Private leSueldoTrabajador As New List(Of e_SueldoTrabajador), leHistorial As New List(Of e_SueldoTrabajador)
    Private leDatosImportados As New List(Of e_SueldoTrabajador)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeConfTabla As New e_ConfiguracionTabla, olConfTabla As New l_ConfiguracionTabla, leConfTabla As New List(Of e_ConfiguracionTabla)
    Private bandcargar As Boolean = True
    Dim _cad As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            If griSueldoTrabajador.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeSueldoTrabajador = New e_SueldoTrabajador
        oeSueldoTrabajador.TipoOperacion = "I"
        oeSueldoTrabajador.Activo = True
        oeSueldoTrabajador.Vigente = 1
        Inicializa()
        'MostrarTabs(1, ficSueldoTrabajador)
        'ficSueldoTrabajador.Tabs(0).Enabled = False
        'ficSueldoTrabajador.Tabs(1).Enabled = True
        'ficSueldoTrabajador.Tabs(2).Enabled = False
        SelecionaTab(1)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializa()
            Mostrar()
            oeSueldoTrabajador.TipoOperacion = "A"
            'MostrarTabs(1, ficSueldoTrabajador)
            'ficSueldoTrabajador.Tabs(0).Enabled = False
            'ficSueldoTrabajador.Tabs(1).Enabled = True
            'ficSueldoTrabajador.Tabs(2).Enabled = False
            SelecionaTab(1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficSueldoTrabajador.SelectedTab.Index
                Case 1
                    LlenarSueldoTrabajador()
                    oeSueldoTrabajador.UsuarioCreacion = gUsuarioSGI.Id
                    oeSueldoTrabajador.FechaActividad = fecActividad.Value
                    oeSueldoTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olSueldoTrabajador.Guardar(oeSueldoTrabajador)
                    mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                Case 2
                    Dim _leAux = leDatosImportados.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        olSueldoTrabajador.GuardarMasivo(_leAux, gs_PrefijoIdSucursal)
                        mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)
                    Else
                        Throw New Exception("No hay datos para guardar")
                    End If
                Case 3
                    If _cad.Length > 0 Then
                        oeTrabajador = New e_Trabajador
                        Select Case cboTipoMas.SelectedIndex
                            Case 0 : oeTrabajador.TipoOperacion = "B"
                            Case 1 : oeTrabajador.TipoOperacion = "D"
                        End Select
                        oeTrabajador.Codigo = _cad
                        oeTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olTrabajador.Migrar(oeTrabajador)
                        mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)
                    Else
                        Throw New Exception("No hay Datos para Guardar!!")
                    End If
                    
            End Select
            'MostrarTabs(0, ficSueldoTrabajador)
            'ficSueldoTrabajador.Tabs(0).Enabled = True
            'ficSueldoTrabajador.Tabs(1).Enabled = False
            'ficSueldoTrabajador.Tabs(2).Enabled = False
            SelecionaTab(0)
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Select Case ficSueldoTrabajador.SelectedTab.Index
            Case 1
                If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                    SelecionaTab(0)
                    Consultar(True)
                End If
            Case 2
                If MessageBox.Show("¿Desea Cancelar la Importación de Datos?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    SelecionaTab(0)
                    Consultar(True)
                End If
            Case 3
                If MessageBox.Show("¿Desea Cancelar la Importación de Datos?", "Mensaje de Sistema", _
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    SelecionaTab(0)
                    Consultar(True)
                End If
        End Select
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griSueldoTrabajador.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro.")
            oeSueldoTrabajador = New e_SueldoTrabajador
            oeSueldoTrabajador.Id = griSueldoTrabajador.ActiveRow.Cells("Id").Value
            oeSueldoTrabajador = olSueldoTrabajador.Obtener(oeSueldoTrabajador)
            oeSueldoTrabajador.TipoOperacion = "E"
            If olSueldoTrabajador.Eliminar(oeSueldoTrabajador) Then
                mensajeEmergente.Confirmacion("Registro eliminado correctamente!!", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficSueldoTrabajador.SelectedTab.Index
                Case 0
                    If griSueldoTrabajador.Rows.Count > 0 Then Exportar_Excel(griSueldoTrabajador)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_SueldoTrabajador_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficSueldoTrabajador.SelectedTab.Index
            Case 0
                If griSueldoTrabajador.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Case 2
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_SueldoTrabajador_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_SueldoTrabajador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If bandcargar Then
                CargarSueloTra(New List(Of e_SueldoTrabajador))
                'MostrarTabs(0, ficSueldoTrabajador)
                colorRegistrados.Color = Color.LightGreen
                colorNoRegistrados.Color = Color.Gold
                'ficSueldoTrabajador.Tabs(0).Enabled = True
                'ficSueldoTrabajador.Tabs(1).Enabled = False
                'ficSueldoTrabajador.Tabs(2).Enabled = False
                SelecionaTab(0)
                CargarCombos()
            Else
                'MostrarTabs(1, ficSueldoTrabajador)
                'ficSueldoTrabajador.Tabs(0).Enabled = False
                'ficSueldoTrabajador.Tabs(1).Enabled = True
                'ficSueldoTrabajador.Tabs(2).Enabled = False
                SelecionaTab(1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griSueldoTrabajador_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griSueldoTrabajador.DoubleClick
        If griSueldoTrabajador.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub cboTrabajador_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajador.ValueChanged
        If cboTrabajador.SelectedIndex > -1 Then oeSueldoTrabajador.IdTrabajador = cboTrabajador.Value
    End Sub

    Private Sub ndSueldo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndSueldo.ValueChanged
        If Not IsDBNull(ndSueldo.Value) Then
            oeSueldoTrabajador.Sueldo = ndSueldo.Value
        Else
            ndSueldo.Value = 0
        End If
    End Sub

    Private Sub cboTipoPago_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoPago.ValueChanged
        oeSueldoTrabajador.TipoPago = cboTipoPago.Value
    End Sub

    Private Sub cboPeriocidad_ValueChanged(sender As Object, e As EventArgs) Handles cboPeriocidad.ValueChanged
        oeSueldoTrabajador.Periocidad = cboPeriocidad.Value
    End Sub

    Private Sub fecActividad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecActividad.ValueChanged
        oeSueldoTrabajador.FechaActividad = fecActividad.Value
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
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
                leDatosImportados.Clear()

                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        oeSueldoTrabajador = New e_SueldoTrabajador
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        End If
                        With oeSueldoTrabajador
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .Sueldo = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value, 2)
                            .TipoPago = 2
                            .Periocidad = 1
                            .FechaActividad = objWorkSheet.Cells(ln_Fila + 1, 4).Value
                            .Activo = False
                        End With
                        oeSueldoTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leDatosImportados.Add(oeSueldoTrabajador)
                    Else
                        Exit For
                    End If
                Next

                CargarImportar(leDatosImportados)

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

    Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar.Click
        Try
            CargarCombos()
            If leDatosImportados.Count > 0 Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()

                _cad = String.Empty

                For Each oeImp In leDatosImportados
                    ' Verifica si los Trabajadores entan registradas en el ERP
                    oeImp.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If oeImp.IdTrabajador = "" Then
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = oeImp.Dni
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        End If
                        oeImp.IdTrabajador = oeTrabajador.Id
                    End If
                Next
                CargarImportar(leDatosImportados)
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            ' Verifica si estan Registrados en Regimen Pensionario
            Listar()
            For Each oeSuelTra In leDatosImportados
                oeSuelTra.PrefijoID = gs_PrefijoIdSucursal '@0001
                If oeSuelTra.IdTrabajador <> "" Then
                    If Not leSueldoTrabajador.Contains(oeSuelTra) Then
                        oeSuelTra.TipoOperacion = "I"
                        oeSuelTra.Activo = True
                        oeSuelTra.Vigente = 1
                        oeSuelTra.UsuarioCreacion = gUsuarioSGI.Id
                    Else
                        oeSuelTra.Activo = False
                    End If
                End If
            Next
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

    Private Sub verTrabajador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTrabajador.CheckedChanged
        CargarImportar(leDatosImportados)
    End Sub

    Private Sub mnuMantSueTra_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuMantSueTra.ToolClick
        Try
            Select Case e.Tool.Key
                Case "GrabarSue"
                    Dim oeSueTraAux As New e_SueldoTrabajador
                    Dim _idPerDoc As String = String.Empty
                    ' oePersonaDocumento.TipoDocumento = cboTipoDocumento.Text
                    oeSueldoTrabajador.Equivale = 1
                    If Not leSueldoTrabajador.Contains(oeSueldoTrabajador) Then
                        oeSueldoTrabajador.Equivale = 2
                        If Not leSueldoTrabajador.Contains(oeSueldoTrabajador) Then
                            oeSueldoTrabajador.TipoOperacion = "I"
                            oeSueldoTrabajador.UsuarioCreacion = gUsuarioSGI.Id
                            oeSueldoTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                            leSueldoTrabajador.Add(oeSueldoTrabajador)
                        Else
                            oeSueTraAux = leSueldoTrabajador.Item(leSueldoTrabajador.IndexOf(oeSueldoTrabajador))
                            If oeSueTraAux.TipoOperacion = "E" Then
                                oeSueTraAux.Activo = True
                                oeSueTraAux.TipoOperacion = "A"
                            Else
                                Throw New Exception("El Sueldo: " & oeSueTraAux.Sueldo & "ya esta Registrado")
                            End If
                        End If
                    Else
                        oeSueTraAux = New e_SueldoTrabajador
                        oeSueTraAux = leSueldoTrabajador.Item(leSueldoTrabajador.IndexOf(oeSueldoTrabajador))
                        _idPerDoc = oeSueTraAux.Id
                        oeSueldoTrabajador.Equivale = 2
                        If Not leSueldoTrabajador.Contains(oeSueldoTrabajador) Then
                            oeSueTraAux.Sueldo = oeSueldoTrabajador.Sueldo
                            oeSueTraAux.SueldoCaja = oeSueldoTrabajador.SueldoCaja
                            oeSueTraAux.TipoOperacion = "A"
                        Else
                            oeSueTraAux = leSueldoTrabajador.Item(leSueldoTrabajador.IndexOf(oeSueldoTrabajador))
                            If oeSueTraAux.TipoOperacion = "E" Then
                                oeSueTraAux.Activo = True
                                oeSueTraAux.TipoOperacion = "A"
                            Else
                                If oeSueTraAux.Id = _idPerDoc Then
                                    oeSueTraAux.TipoOperacion = "A"
                                Else
                                    Throw New Exception("El Saldo: " & oeSueTraAux.Sueldo & " ya esta Registrado")
                                End If
                            End If
                        End If
                    End If
                    mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente!!", True)
                    Me.Close()
                Case "CancelarSue"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                 , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscarMas_Click(sender As Object, e As EventArgs) Handles btnBuscarMas.Click

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
                leDatosImportados.Clear()

                Dim ddt As Data.DataTable = CrearDT(cboTipoMas.SelectedIndex)
                Dim rw As Data.DataRow

                Select Case cboTipoMas.SelectedIndex
                    Case 0
                        For ln_Fila As Integer = 1 To 100000
                            If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                                rw = ddt.NewRow
                                oeTrabajador = New e_Trabajador
                                oeTrabajador.TipoBusca = 2
                                oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                                If leTrabajador.Contains(oeTrabajador) Then
                                    oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                                End If
                                With rw
                                    .Item("IdTrabajador") = oeTrabajador.Id
                                    .Item("DNI") = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                                    .Item("Trabajador") = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                                    .Item("AF") = IIf(objWorkSheet.Cells(ln_Fila + 1, 3).Value = "SI", True, False)
                                    .Item("OK") = False
                                End With
                                ddt.Rows.Add(rw)
                            Else
                                Exit For
                            End If
                        Next
                    Case 1
                        For ln_Fila As Integer = 1 To 100000
                            If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                                rw = ddt.NewRow
                                oeTrabajador = New e_Trabajador
                                oeTrabajador.TipoBusca = 2
                                oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                                If leTrabajador.Contains(oeTrabajador) Then
                                    oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                                End If
                                With rw
                                    .Item("IdTrabajador") = oeTrabajador.Id
                                    .Item("DNI") = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                                    .Item("Trabajador") = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                                    .Item("IdRuta") = String.Empty
                                    .Item("Ruta") = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                                    .Item("OK") = False
                                End With
                                ddt.Rows.Add(rw)
                            Else
                                Exit For
                            End If
                        Next
                End Select



                CargarDT(ddt, cboTipoMas.SelectedIndex)

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

    Private Sub btnVerificarMas_Click(sender As Object, e As EventArgs) Handles btnVerificarMas.Click
        Try

            If griOtros.Rows.Count > 0 Then

                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()

                Select Case cboTipoMas.SelectedIndex
                    Case 0
                        _cad = String.Empty
                        For Each fila In griOtros.DisplayLayout.Rows
                            If fila.Cells("AF").Value = True Then
                                fila.Cells("OK").Value = True
                                _cad = _cad & "'" & fila.Cells("IdTrabajador").Value & "',"
                            Else
                                fila.Cells("OK").Value = False
                            End If
                        Next
                        If _cad.Trim.Length > 0 Then _cad = _cad.Substring(0, _cad.Length - 1)
                    Case 1
                        _cad = String.Empty
                        For Each fila In griOtros.DisplayLayout.Rows
                            If fila.Cells("RUTA").Value = "VILLA EL SALVADOR" Then
                                fila.Cells("OK").Value = True
                                _cad = _cad & "'" & fila.Cells("IdTrabajador").Value & "',"
                            Else
                                fila.Cells("OK").Value = False
                            End If
                        Next
                        If _cad.Trim.Length > 0 Then _cad = _cad.Substring(0, _cad.Length - 1)
                End Select

                ugb_Espera.Visible = False
                mensajeEmergente.Confirmacion("Los Datos se Validaron Correctamente!!", True)

            Else
                Throw New Exception("No hay Datos para validar")
            End If

        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oeTrabajador = New e_Trabajador
            leTrabajador = New List(Of e_Trabajador)
            cboTrabajador.DataSource = Nothing

            oeTrabajador.TipoOperacion = "P"
            leTrabajador = olTrabajador.Listar(oeTrabajador)

            Dim _leTrabAux = From le In leTrabajador _
                             Where le.Activo = True _
                             Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni

            LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, -1)

            LlenaComboConfigurable(cboPeriocidad, "T13_Periocidad", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboTipoPago, "T16_TipoPago", "CODIGO", "NOMBRE", -1)

            cboTipoMas.Items.Clear()
            cboTipoMas.Items.Add("ASIGNACION")
            cboTipoMas.Items.Add("RUTA")
            cboTipoMas.SelectedIndex = -1

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarSueldoTrabajador()
        Try
            oeSueldoTrabajador.Activo = True
            oeSueldoTrabajador.FechaActividad = fecActividad.Value
            oeSueldoTrabajador.Sueldo = ndSueldo.Value
            oeSueldoTrabajador.IdTrabajador = cboTrabajador.Value
            oeSueldoTrabajador.TipoPago = cboTipoPago.Value
            oeSueldoTrabajador.Periocidad = cboPeriocidad.Value
            oeSueldoTrabajador.Vigente = IIf(chkVigente.Checked, 1, 0)
            oeSueldoTrabajador.SueldoCaja = ndCaja.Value
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try

            oeSueldoTrabajador = New e_SueldoTrabajador
            oeSueldoTrabajador.TipoOperacion = ""
            oeSueldoTrabajador.Activo = True
            oeSueldoTrabajador.Vigente = 1
            leSueldoTrabajador = olSueldoTrabajador.Listar(oeSueldoTrabajador)

            CargarSueloTra(leSueldoTrabajador)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarSueloTra(ByVal leSueldoTra As List(Of e_SueldoTrabajador))
        Try
            With griSueldoTrabajador

                .ResetDisplayLayout()
                .DataSource = leSueldoTra

                ConfiguraGrilla(griSueldoTrabajador, 1)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        cboTrabajador.SelectedIndex = -1
        ndSueldo.Value = 0
        cboPeriocidad.Value = 1
        cboTipoPago.Value = 2
        fecActividad.Value = Date.Now.Date
        CargarHistorial(New List(Of e_SueldoTrabajador))
    End Sub

    Private Sub Mostrar()
        Try
            oeSueldoTrabajador = New e_SueldoTrabajador
            oeSueldoTrabajador.Id = griSueldoTrabajador.ActiveRow.Cells("Id").Value
            oeSueldoTrabajador = olSueldoTrabajador.Obtener(oeSueldoTrabajador)
            CargarDatos(oeSueldoTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarHistorial(ByVal leHistSuelTrab As List(Of e_SueldoTrabajador))
        Try
            With griHistorial
                .ResetDisplayLayout()
                .DataSource = leHistSuelTrab

                ConfiguraGrilla(griHistorial, 2)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarImportar(ByVal leImportar As List(Of e_SueldoTrabajador))
        Try
            With griImporta

                .ResetDisplayLayout()
                '.DataSource = leImportar

                Dim leAux As New List(Of e_SueldoTrabajador)

                If verTrabajador.Checked Then
                    leAux = leImportar.Where(Function(it) it.IdTrabajador = "").ToList
                End If

                If leAux.Count > 0 Then
                    .DataSource = leAux
                Else
                    .DataSource = leImportar
                End If

                ConfiguraGrilla(griImporta, 3)

                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("IdTrabajador").Value.ToString <> "" Then
                            Fila.Cells("Trabajador").Appearance.BackColor = colorRegistrados.Color
                            Fila.Cells("Dni").Appearance.BackColor = colorRegistrados.Color
                        Else
                            Fila.Cells("Trabajador").Appearance.BackColor = colorNoRegistrados.Color
                            Fila.Cells("Dni").Appearance.BackColor = colorNoRegistrados.Color
                        End If
                    Next
                    .Text = "Datos Importados (" & .Rows.Count & ")"
                    verTrabajador.Enabled = True
                    btnValidar.Enabled = True
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(ByVal Grilla As UltraWinGrid.UltraGrid, ByVal Tipo As Integer)
        Try
            With Grilla

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                If Tipo = 2 Then .DisplayLayout.Bands(0).Columns("Trabajador").Hidden = True
                If Tipo <> 2 Then .DisplayLayout.Bands(0).Columns("FechaInactividad").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                If Tipo <> 3 Then .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Id").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("FechaInactividad").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("Vigente").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("Activo").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True

                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 300
                .DisplayLayout.Bands(0).Columns("Sueldo").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Sueldo").Format = "#,##0.00"
                .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                .DisplayLayout.Bands(0).Columns("Vigente").Style = ColumnStyle.CheckBox
                .DisplayLayout.Bands(0).Columns("SueldoCaja").CellAppearance.TextHAlign = HAlign.Right '@0001
                .DisplayLayout.Bands(0).Columns("SueldoCaja").Format = "#,##0.00" '@0001

                .DisplayLayout.Bands(0).Columns("Dni").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Sueldo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("TipoPago").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Periocidad").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("FechaActividad").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("FechaInactividad").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Vigente").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Activo").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("SueldoCaja").Header.VisiblePosition = 9 '@0001

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDatos(oeSuelTrab As e_SueldoTrabajador)
        With oeSuelTrab
            cboTrabajador.Value = .IdTrabajador
            cboTipoPago.Value = .TipoPago
            cboPeriocidad.Value = .Periocidad
            ndSueldo.Value = .Sueldo
            fecActividad.Value = .FechaActividad
            chkVigente.Checked = IIf(.Vigente = 1, True, False)
            ndCaja.Value = .SueldoCaja
            CargarHistorial(.leHistorial)
        End With
    End Sub

    Private Sub SelecionaTab(_index As Integer)
        ficSueldoTrabajador.Tabs(0).Enabled = False
        ficSueldoTrabajador.Tabs(1).Enabled = False
        ficSueldoTrabajador.Tabs(2).Enabled = False
        ficSueldoTrabajador.Tabs(3).Enabled = False
        ficSueldoTrabajador.Tabs(_index).Enabled = True
        ficSueldoTrabajador.Tabs(_index).Selected = True
    End Sub

    Private Function CrearDT(_index As Integer) As System.Data.DataTable
        Dim dt As New Data.DataTable
        With dt
            Select Case _index
                Case 0
                    .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
                    .Columns.Add(New Data.DataColumn("DNI", Type.GetType("System.String")))
                    .Columns.Add(New Data.DataColumn("Trabajador", Type.GetType("System.String")))
                    .Columns.Add(New Data.DataColumn("AF", Type.GetType("System.Boolean")))
                    .Columns.Add(New Data.DataColumn("OK", Type.GetType("System.Boolean")))
                Case 1
                    .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
                    .Columns.Add(New Data.DataColumn("DNI", Type.GetType("System.String")))
                    .Columns.Add(New Data.DataColumn("Trabajador", Type.GetType("System.String")))
                    .Columns.Add(New Data.DataColumn("IdRuta", Type.GetType("System.String")))
                    .Columns.Add(New Data.DataColumn("Ruta", Type.GetType("System.String")))
                    .Columns.Add(New Data.DataColumn("OK", Type.GetType("System.Boolean")))
            End Select
        End With
        Return dt
    End Function

    Private Sub CargarDT(dtaux As Data.DataTable, _index As Integer)
        Try
            'Dim ddt As Data.DataTable = CrearDT(_index)

            With griOtros

                .ResetDisplayLayout()
                .DataSource = dtaux

                Select Case _index
                    Case 0
                        .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                    Case 1
                        .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                        .DisplayLayout.Bands(0).Columns("IdRuta").Hidden = True
                End Select

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Conceptual"

    Private Sub mnuSueTra_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuSueTra.Opening
        Try
            mnuSueTra.Items("tsmiNuevo").Enabled = True
            mnuSueTra.Items("tsmiEditar").Enabled = False
            mnuSueTra.Items("tsmiEliminar").Enabled = False
            mnuSueTra.Items("tsmiImportar").Enabled = True
            If griSueldoTrabajador.Rows.Count > 0 Then
                mnuSueTra.Items("tsmiEditar").Enabled = True
                mnuSueTra.Items("tsmiEliminar").Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

    Private Sub ndCaja_ValueChanged(sender As Object, e As EventArgs) Handles ndCaja.ValueChanged
        If Not IsDBNull(ndCaja.Value) Then
            oeSueldoTrabajador.SueldoCaja = ndCaja.Value
        Else
            ndCaja.Value = 0
        End If
    End Sub

    Private Sub tsmiNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevo.Click
        Try
            Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub tsmiImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiImportar.Click
        Try
            'MostrarTabs(2, ficSueldoTrabajador)
            'ficSueldoTrabajador.Tabs(0).Enabled = False
            'ficSueldoTrabajador.Tabs(1).Enabled = False
            'ficSueldoTrabajador.Tabs(2).Enabled = True
            SelecionaTab(2)
            verTrabajador.Checked = False
            verTrabajador.Enabled = False
            btnValidar.Enabled = False
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            CargarImportar(New List(Of e_SueldoTrabajador))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

    Private Sub tsmiOtros_Click(sender As Object, e As EventArgs) Handles tsmiOtros.Click
        Try
            SelecionaTab(3)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

#End Region

    Private Sub griHistorial_DoubleClick(sender As Object, e As EventArgs) Handles griHistorial.DoubleClick

        Try
            If griHistorial.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro.")
            oeSueldoTrabajador = New e_SueldoTrabajador
            oeSueldoTrabajador.Id = griHistorial.ActiveRow.Cells("Id").Value
            oeSueldoTrabajador = olSueldoTrabajador.Obtener(oeSueldoTrabajador)
            oeSueldoTrabajador.TipoOperacion = "A"
            CargarDatos(oeSueldoTrabajador)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub
End Class