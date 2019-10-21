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

Public Class frm_FondoPensionTrabajador
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New(Accion As String, oeFondoTra As e_FondoPensionTrabajador, oeTrabAux As e_Trabajador)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        mnuMantFonPen.Visible = True
        bandcargar = False
        Inicializa()
        CargarCombos()
        oeFondoPensionTrabajador = oeFondoTra
        leFondoPensionTrabajador = oeTrabAux.leFondoPension
        Select Case Accion
            Case "Agregar"
                cboTrabajador.Value = oeFondoPensionTrabajador.IdTrabajador
            Case "Editar"
                CargarDatos(oeFondoPensionTrabajador)
                'cboTipoDocumento.ReadOnly = True
        End Select
        cboTrabajador.ReadOnly = True
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mnuMantFonPen.Visible = False
    End Sub

    Private Shared instancia As frm_FondoPensionTrabajador = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_FondoPensionTrabajador()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeFondoPensionTrabajador As New e_FondoPensionTrabajador, olFondoPensionTrabajador As New l_FondoPensionTrabajador
    Private leFondoPensionTrabajador As New List(Of e_FondoPensionTrabajador), leDatosImportados As New List(Of e_FondoPensionTrabajador)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeRegPen As New e_RegimenPensionario, olRegPen As New l_RegimenPensionario, leRegPen As New List(Of e_RegimenPensionario)
    Private bandcargar As Boolean = True

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            If griFondoPensionTrabajador.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeFondoPensionTrabajador = New e_FondoPensionTrabajador
        oeFondoPensionTrabajador.TipoOperacion = "I"
        oeFondoPensionTrabajador.Activo = True
        oeFondoPensionTrabajador.Vigente = True
        Inicializa()
        MostrarTabs(1, ficFondoPensionTrabajador)
        ficFondoPensionTrabajador.Tabs(0).Enabled = False
        ficFondoPensionTrabajador.Tabs(1).Enabled = True
        ficFondoPensionTrabajador.Tabs(2).Enabled = False
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializa()
            Mostrar()
            oeFondoPensionTrabajador.TipoOperacion = "A"
            MostrarTabs(1, ficFondoPensionTrabajador)
            ficFondoPensionTrabajador.Tabs(0).Enabled = False
            ficFondoPensionTrabajador.Tabs(1).Enabled = True
            ficFondoPensionTrabajador.Tabs(2).Enabled = False
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficFondoPensionTrabajador.SelectedTab.Index
                Case 1
                    oeFondoPensionTrabajador.UsuarioCreacion = gUsuarioSGI.Id
                    oeFondoPensionTrabajador.FechaActividad = fecActividad.Value
                    oeFondoPensionTrabajador.Vigente = IIf(chkVidente.Checked, 1, 0)
                    oeFondoPensionTrabajador.Mixta = IIf(verMixta.Checked, 1, 0)
                    oeFondoPensionTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olFondoPensionTrabajador.Guardar(oeFondoPensionTrabajador)
                    mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                Case 2
                    Dim _leAux = leDatosImportados.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        olFondoPensionTrabajador.GuardarMasivo(_leAux, gs_PrefijoIdSucursal)
                        mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)
                    Else
                        Throw New Exception("No hay datos para guardar")
                    End If
            End Select
            MostrarTabs(0, ficFondoPensionTrabajador)
            ficFondoPensionTrabajador.Tabs(0).Enabled = True
            ficFondoPensionTrabajador.Tabs(1).Enabled = False
            ficFondoPensionTrabajador.Tabs(2).Enabled = False
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Select Case ficFondoPensionTrabajador.SelectedTab.Index
            Case 1
                If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    MostrarTabs(0, ficFondoPensionTrabajador)
                    ficFondoPensionTrabajador.Tabs(0).Enabled = True
                    ficFondoPensionTrabajador.Tabs(1).Enabled = False
                    ficFondoPensionTrabajador.Tabs(2).Enabled = False
                    Consultar(True)
                End If
            Case 2
                If MessageBox.Show("¿Desea Cancelar la Importación de Datos?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    MostrarTabs(0, ficFondoPensionTrabajador)
                    ficFondoPensionTrabajador.Tabs(0).Enabled = True
                    ficFondoPensionTrabajador.Tabs(1).Enabled = False
                    ficFondoPensionTrabajador.Tabs(2).Enabled = False
                    Consultar(True)
                End If
        End Select
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griFondoPensionTrabajador.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro.")
            oeFondoPensionTrabajador = New e_FondoPensionTrabajador
            oeFondoPensionTrabajador.Id = griFondoPensionTrabajador.ActiveRow.Cells("Id").Value
            oeFondoPensionTrabajador.TipoOperacion = "E"
            If olFondoPensionTrabajador.Eliminar(oeFondoPensionTrabajador) Then
                mensajeEmergente.Confirmacion("Registro eliminado correctamente!!", True)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_FondoPensionTrabajador_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficFondoPensionTrabajador.SelectedTab.Index
            Case 0
                If griFondoPensionTrabajador.Rows.Count > 0 Then
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

    Private Sub frm_FondoPensionTrabajador_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_FondoPensionTrabajador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If bandcargar Then
                CargarFonPenTra(New List(Of e_FondoPensionTrabajador))
                MostrarTabs(0, ficFondoPensionTrabajador)
                colorRegistrados.Color = Color.LightGreen
                colorNoRegistrado.Color = Color.Gold
                ficFondoPensionTrabajador.Tabs(0).Enabled = True
                ficFondoPensionTrabajador.Tabs(1).Enabled = False
                ficFondoPensionTrabajador.Tabs(2).Enabled = False
                CargarCombos()
            Else
                MostrarTabs(1, ficFondoPensionTrabajador)
                ficFondoPensionTrabajador.Tabs(0).Enabled = False
                ficFondoPensionTrabajador.Tabs(1).Enabled = True
                ficFondoPensionTrabajador.Tabs(2).Enabled = False
            End If
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajador_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajador.ValueChanged
        If cboTrabajador.SelectedIndex > -1 Then
            oeFondoPensionTrabajador.IdTrabajador = cboTrabajador.Value
        End If
    End Sub

    Private Sub cboRegimenPensionario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegimenPensionario.ValueChanged
        If cboRegimenPensionario.SelectedIndex > -1 Then
            oeFondoPensionTrabajador.IdEmpresa = cboRegimenPensionario.Value
            oeFondoPensionTrabajador.Empresa = cboRegimenPensionario.Text
            oeEmpresa = New e_Empresa
            oeEmpresa.TipoBusca = 1
            oeEmpresa.Id = cboRegimenPensionario.Value
            If leEmpresa.Contains(oeEmpresa) Then
                oeEmpresa = leEmpresa.Item(leEmpresa.IndexOf(oeEmpresa))
                txtAbreviatura.Text = oeEmpresa.Abreviatura
            End If
            oeRegPen = New e_RegimenPensionario
            oeRegPen = cboRegimenPensionario.Items(cboRegimenPensionario.SelectedIndex).ListObject
            ndObligatorio.Value = oeRegPen.PorcentajeObligatorio
            ndComision.Value = oeRegPen.PorcentajeComision
            ndSeguros.Value = oeRegPen.PorcentajeSeguros
            ndTotal.Value = oeRegPen.PorcentajeTotal
            ndComisionMixta.Value = oeRegPen.PorcentajeComisionMixta
            ndSaldoMixta.Value = oeRegPen.PorcentajeSaldoMixta
        Else
            ndObligatorio.Value = 0
            ndComision.Value = 0
            ndSeguros.Value = 0
            ndTotal.Value = 0
        End If
    End Sub

    Private Sub txtCussp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCussp.ValueChanged
        oeFondoPensionTrabajador.CUSPP = txtCussp.Text
    End Sub

    Private Sub fecActividad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecActividad.ValueChanged
        oeFondoPensionTrabajador.FechaActividad = fecActividad.Value
    End Sub

    Private Sub griFondoPensionTrabajador_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griFondoPensionTrabajador.DoubleClick
        If griFondoPensionTrabajador.Rows.Count > 0 Then Editar()
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
                        oeFondoPensionTrabajador = New e_FondoPensionTrabajador
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        End If
                        oeEmpresa = New e_Empresa
                        oeEmpresa.TipoBusca = 2
                        oeEmpresa.Abreviatura = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                        If leEmpresa.Contains(oeEmpresa) Then
                            oeEmpresa = leEmpresa.Item(leEmpresa.IndexOf(oeEmpresa))
                        End If
                        With oeFondoPensionTrabajador
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .IdEmpresa = oeEmpresa.Id
                            .Empresa = IIf(oeEmpresa.Id = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value), oeEmpresa.Nombre)
                            .FechaActividad = IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value) = "", #1/1/1901#, objWorkSheet.Cells(ln_Fila + 1, 5).Value)
                            .CUSPP = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value)
                            .Mixta = IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value) = "NO", 0, 1)
                            .Activo = False
                        End With
                        oeFondoPensionTrabajador.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leDatosImportados.Add(oeFondoPensionTrabajador)
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

                For Each oeImp In leDatosImportados
                    ' Verifica si los Trabajadores entan registradas en el SGI
                    If oeImp.IdTrabajador = "" Then
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = oeImp.Dni
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        End If
                        oeImp.IdTrabajador = oeTrabajador.Id
                    End If
                    ' Verifica si las Empresas entan registradas en el SGI
                    If oeImp.IdEmpresa = "" Then
                        oeEmpresa = New e_Empresa
                        oeEmpresa.TipoBusca = 2
                        oeEmpresa.Abreviatura = oeImp.Empresa
                        If leEmpresa.Contains(oeEmpresa) Then
                            oeEmpresa = leEmpresa.Item(leEmpresa.IndexOf(oeEmpresa))
                        End If
                        oeImp.IdEmpresa = oeEmpresa.Id
                    End If
                Next
                CargarImportar(leDatosImportados)
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            ' Verifica si estan Registrados en Regimen Pensionario
            Listar()
            For Each oeFonPenTra In leDatosImportados
                If oeFonPenTra.IdTrabajador <> "" AndAlso oeFonPenTra.IdEmpresa <> "" Then
                    If Not leFondoPensionTrabajador.Contains(oeFonPenTra) Then
                        oeFonPenTra.TipoOperacion = "I"
                        oeFonPenTra.Activo = True
                        oeFonPenTra.Vigente = 1
                        oeFonPenTra.UsuarioCreacion = gUsuarioSGI.Id
                    Else
                        oeFonPenTra.Activo = False
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

    Private Sub verEmpresa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verEmpresa.CheckedChanged
        CargarImportar(leDatosImportados)
    End Sub

    Private Sub verMixta_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles verMixta.CheckedChanged
        agrFlujo.Visible = Not verMixta.Checked
        agrSaldo.Visible = verMixta.Checked
        oeFondoPensionTrabajador.Mixta = IIf(verMixta.Checked = False, 0, 1)
    End Sub

    Private Sub mnuMantFonPen_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuMantFonPen.ToolClick
        Try
            Select Case e.Tool.Key
                Case "GrabarFon"
                    Dim oeFonPenAux As New e_FondoPensionTrabajador
                    Dim _idPerDoc As String = String.Empty
                    oeFondoPensionTrabajador.Equivale = 1
                    If Not leFondoPensionTrabajador.Contains(oeFondoPensionTrabajador) Then
                        oeFondoPensionTrabajador.Equivale = 2
                        If Not leFondoPensionTrabajador.Contains(oeFondoPensionTrabajador) Then
                            oeFondoPensionTrabajador.TipoOperacion = "I"
                            oeFondoPensionTrabajador.UsuarioCreacion = gUsuarioSGI.Id
                            leFondoPensionTrabajador.Add(oeFondoPensionTrabajador)
                        Else
                            oeFonPenAux = leFondoPensionTrabajador.Item(leFondoPensionTrabajador.IndexOf(oeFondoPensionTrabajador))
                            If oeFonPenAux.TipoOperacion = "E" Then
                                oeFonPenAux.Activo = True
                                oeFonPenAux.TipoOperacion = "A"
                            Else
                                Throw New Exception("La Empresa: " & oeFonPenAux.Empresa & "ya esta Registrado")
                            End If
                        End If
                    Else
                        oeFonPenAux = New e_FondoPensionTrabajador
                        oeFonPenAux = leFondoPensionTrabajador.Item(leFondoPensionTrabajador.IndexOf(oeFondoPensionTrabajador))
                        _idPerDoc = oeFonPenAux.Id
                        oeFondoPensionTrabajador.Equivale = 2
                        If Not leFondoPensionTrabajador.Contains(oeFondoPensionTrabajador) Then
                            oeFonPenAux.IdEmpresa = oeFondoPensionTrabajador.IdEmpresa
                            oeFonPenAux.Empresa = oeFondoPensionTrabajador.Empresa
                            oeFonPenAux.TipoOperacion = "A"
                        Else
                            oeFonPenAux = leFondoPensionTrabajador.Item(leFondoPensionTrabajador.IndexOf(oeFondoPensionTrabajador))
                            If oeFonPenAux.TipoOperacion = "E" Then
                                oeFonPenAux.Activo = True
                                oeFonPenAux.TipoOperacion = "A"
                            Else
                                If oeFonPenAux.Id = _idPerDoc Then
                                    oeFonPenAux.TipoOperacion = "A"
                                Else
                                    Throw New Exception("La Empresa: " & oeFonPenAux.Empresa & " ya esta Registrado")
                                End If
                            End If
                        End If
                    End If
                    mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente!!", True)
                    Me.Close()
                Case "CancelarFon"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                 , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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

            oeRegPen = New e_RegimenPensionario
            leRegPen = New List(Of e_RegimenPensionario)
            cboRegimenPensionario.DataSource = Nothing

            oeRegPen.TipoOperacion = ""
            oeRegPen.Activo = True
            oeRegPen.Vigente = 1
            leRegPen = olRegPen.Listar(oeRegPen)
            LlenarCombo(cboRegimenPensionario, "Empresa", leRegPen, -1)

            oeEmpresa = New e_Empresa
            leEmpresa = New List(Of e_Empresa)
            oeEmpresa.TipoOperacion = ""
            oeEmpresa.Activo = True
            leEmpresa = olEmpresa.Listar(oeEmpresa).Where(Function(it) it.TipoEmpresa = "ENTIDAD ASEGURADORA").ToList

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try

            oeFondoPensionTrabajador = New e_FondoPensionTrabajador
            oeFondoPensionTrabajador.TipoOperacion = ""
            oeFondoPensionTrabajador.Activo = True
            oeFondoPensionTrabajador.Vigente = 1
            leFondoPensionTrabajador = olFondoPensionTrabajador.Listar(oeFondoPensionTrabajador)

            CargarFonPenTra(leFondoPensionTrabajador)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarFonPenTra(ByVal leFonPonTra As List(Of e_FondoPensionTrabajador))
        Try
            With griFondoPensionTrabajador

                .ResetDisplayLayout()

                .DataSource = leFonPonTra

                ConfiguraGrilla(griFondoPensionTrabajador, 1)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        cboTrabajador.SelectedIndex = -1
        cboRegimenPensionario.SelectedIndex = -1
        ndObligatorio.Value = 0
        ndComision.Value = 0
        ndSeguros.Value = 0
        txtAbreviatura.Text = String.Empty
        txtCussp.Text = String.Empty
        fecActividad.Value = Date.Now.Date
        verMixta.Checked = True
        chkVidente.Checked = True
        CargarHistorial(New List(Of e_FondoPensionTrabajador))
    End Sub

    Private Sub Mostrar()
        Try
            oeFondoPensionTrabajador = New e_FondoPensionTrabajador
            oeFondoPensionTrabajador.Id = griFondoPensionTrabajador.ActiveRow.Cells("Id").Value
            oeFondoPensionTrabajador = olFondoPensionTrabajador.Obtener(oeFondoPensionTrabajador)
            CargarDatos(oeFondoPensionTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarHistorial(ByVal leHisFPT As List(Of e_FondoPensionTrabajador))
        Try
            With griHistorial

                .ResetDisplayLayout()

                .DataSource = leHisFPT

                ConfiguraGrilla(griHistorial, 2)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarImportar(ByVal leImportar As List(Of e_FondoPensionTrabajador))
        Try
            With griImportaDato

                .ResetDisplayLayout()

                Dim leAux As New List(Of e_FondoPensionTrabajador)

                If verTrabajador.Checked Then
                    leAux = leImportar.Where(Function(it) it.IdTrabajador = "").ToList
                End If

                If verEmpresa.Checked Then
                    If verTrabajador.Checked Then
                        leAux = leImportar.Where(Function(it) it.IdTrabajador = "" Or it.IdEmpresa = "").ToList
                    Else
                        leAux = leImportar.Where(Function(it) it.IdEmpresa = "").ToList
                    End If
                End If

                If leAux.Count > 0 Then
                    .DataSource = leAux
                Else
                    .DataSource = leImportar
                End If

                ConfiguraGrilla(griImportaDato, 3)

                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("IdTrabajador").Value.ToString <> "" Then
                            Fila.Cells("Trabajador").Appearance.BackColor = colorRegistrados.Color
                            Fila.Cells("Dni").Appearance.BackColor = colorRegistrados.Color
                        Else
                            Fila.Cells("Trabajador").Appearance.BackColor = colorNoRegistrado.Color
                            Fila.Cells("Dni").Appearance.BackColor = colorNoRegistrado.Color
                        End If
                        If Fila.Cells("IdEmpresa").Value.ToString <> "" Then
                            Fila.Cells("Empresa").Appearance.BackColor = colorRegistrados.Color
                        Else
                            Fila.Cells("Empresa").Appearance.BackColor = colorNoRegistrado.Color
                        End If
                    Next

                    .Text = "Datos Importados (" & .Rows.Count & ")"
                    verTrabajador.Enabled = True
                    verEmpresa.Enabled = True
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

                .DisplayLayout.Bands(0).Columns("Id").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("IdEmpresa").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("FechaInactividad").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("Vigente").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("Activo").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                If Tipo = 2 Then .DisplayLayout.Bands(0).Columns("Trabajador").Hidden = True
                If Tipo <> 2 Then .DisplayLayout.Bands(0).Columns("FechaInactividad").Hidden = True
                .DisplayLayout.Bands(0).Columns("Vigente").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                If Tipo <> 3 Then .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Dni").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("FechaActividad").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("CUSPP").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Mixta").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Empresa").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Activo").Header.VisiblePosition = 6

                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 300
                .DisplayLayout.Bands(0).Columns("Empresa").Width = 300
                .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                .DisplayLayout.Bands(0).Columns("Mixta").Header.Caption = "Comision Mixta"

                .DisplayLayout.Bands(0).Columns("Mixta").Style = ColumnStyle.CheckBox

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

    Private Sub CargarDatos(FondoPenTrab As e_FondoPensionTrabajador)
        With FondoPenTrab
            cboTrabajador.Value = .IdTrabajador
            cboRegimenPensionario.Value = .IdEmpresa
            txtCussp.Text = .CUSPP
            fecActividad.Value = .FechaActividad
            verMixta.Checked = IIf(.Mixta = 0, False, True)
            chkVidente.Checked = IIf(.Vigente = 0, False, True)
            CargarHistorial(.leHistorial)
        End With
    End Sub

#End Region

#Region "Menu Conceptual"

    Private Sub mnuFonPenTra_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuFonPenTra.Opening
        mnuFonPenTra.Items("tsmiNuevo2").Enabled = True
        mnuFonPenTra.Items("tsmiEditar2").Enabled = False
        mnuFonPenTra.Items("tsmiEliminar2").Enabled = False
        mnuFonPenTra.Items("tsmiImportar2").Enabled = True
        If griFondoPensionTrabajador.Rows.Count > 0 Then
            mnuFonPenTra.Items("tsmiEditar2").Enabled = True
            mnuFonPenTra.Items("tsmiEliminar2").Enabled = True
        End If
    End Sub

    Private Sub tsmiNuevo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevo2.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar2.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar2.Click
        Eliminar()
    End Sub

    Private Sub tsmiImportar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiImportar2.Click
        MostrarTabs(2, ficFondoPensionTrabajador)
        ficFondoPensionTrabajador.Tabs(0).Enabled = False
        ficFondoPensionTrabajador.Tabs(1).Enabled = False
        ficFondoPensionTrabajador.Tabs(2).Enabled = True
        verTrabajador.Checked = False
        verEmpresa.Checked = False
        btnValidar.Enabled = False
        verTrabajador.Enabled = False
        verEmpresa.Enabled = False
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        CargarImportar(New List(Of e_FondoPensionTrabajador))
    End Sub

#End Region

    Private Sub griHistorial_DoubleClick(sender As Object, e As EventArgs) Handles griHistorial.DoubleClick
        Try
            If griHistorial.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro.")
            oeFondoPensionTrabajador = New e_FondoPensionTrabajador
            oeFondoPensionTrabajador.Id = griHistorial.ActiveRow.Cells("Id").Value
            oeFondoPensionTrabajador = olFondoPensionTrabajador.Obtener(oeFondoPensionTrabajador)
            oeFondoPensionTrabajador.TipoOperacion = "A"
            CargarDatos(oeFondoPensionTrabajador)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
End Class