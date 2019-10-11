'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop

Public Class frm_CuentaCtePersonal
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New(Accion As String, oeCtaBan As e_CuentaCtePersonal, oeTrabAux As e_Trabajador)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' mnuCtaCtePer.Visible = True
        bandcargar = False
        Inicializa()
        CargarCombos()
        oeCuentaCtePersonal = oeCtaBan
        leCuentaCtePersonal = oeTrabAux.leCtaBancaria
        Select Case Accion
            Case "Agregar"
                Dim _leTrabAct = From le In leTrabajador _
                                 Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado _
                                 Where Activo = True And IndEstado = 1 _
                                 Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAct.ToList, -1)
                cboTrabajador.Value = oeCuentaCtePersonal.IdTrabajador
                Dim _lePerAct = From le2 In lePersona _
                                Select le2.Id, le2.NombreCompleto, le2.Dni, le2.Activo _
                                Where Activo = True
                                Order By NombreCompleto
                LlenarCombo(cboBeneficiario, "NombreCompleto", _lePerAct.ToList, -1)
            Case "Editar"
                Dim _leTrab = From le In leTrabajador _
                            Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni _
                            Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrab.ToList, -1)
                CargarDatos(oeCuentaCtePersonal)
                Dim _lePer = From le2 In lePersona _
                            Select le2.Id, le2.NombreCompleto, le2.Dni _
                            Order By NombreCompleto
                LlenarCombo(cboBeneficiario, "NombreCompleto", _lePer.ToList, -1)
        End Select
        cboTrabajador.ReadOnly = True
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mnuCtaCtePer.Visible = False
    End Sub

    Private Shared instancia As frm_CuentaCtePersonal = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_CuentaCtePersonal()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeCuentaCtePersonal As e_CuentaCtePersonal, olCuentaCtePersonal As New l_CuentaCtePersonal
    Private leCuentaCtePersonal As New List(Of e_CuentaCtePersonal), leDatosImportados As New List(Of e_CuentaCtePersonal)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)
    Private oePersona As New e_Persona, olPersona As New l_Persona, lePersona As New List(Of e_Persona)
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda, leMoneda As New List(Of e_Moneda)
    Private bandcargar As Boolean = True
    Private _opeCCP As String = "", _acl As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            If griCuentaCtePersonal.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeCCP = "GENERADA"
                oeCuentaCtePersonal = New e_CuentaCtePersonal
                oeCuentaCtePersonal.TipoOperacion = "I"
                oeCuentaCtePersonal.Activo = True
                oeCuentaCtePersonal.Vigente = 1
                Inicializa()
                Dim _leTrabAct = From le In leTrabajador _
                                 Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado _
                                 Where Activo = True And IndEstado = 1 _
                                 Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAct.ToList, -1)
                cboTrabajador.ReadOnly = False
                cboEntidadBancaria.ReadOnly = False
                Dim _lePerAct = From le2 In lePersona _
                                Select le2.Id, le2.NombreCompleto, le2.Dni, le2.Activo _
                                Where Activo = True
                                Order By NombreCompleto
                LlenarCombo(cboBeneficiario, "NombreCompleto", _lePerAct.ToList, -1)
                cboBeneficiario.ReadOnly = False
                SeleccionarTab(1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.EDITAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeCCP = "GENERADA"
                Inicializa()
                Dim _leTrab = From le In leTrabajador _
                            Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni _
                            Order By NombreCompleto
                LlenarCombo(cboTrabajador, "NombreCompleto", _leTrab.ToList, -1)
                cboTrabajador.ReadOnly = True
                cboEntidadBancaria.ReadOnly = True
                Dim _lePer = From le2 In lePersona _
                            Select le2.Id, le2.NombreCompleto, le2.Dni _
                            Order By NombreCompleto
                LlenarCombo(cboBeneficiario, "NombreCompleto", _lePer.ToList, -1)
                Mostrar()
                oeCuentaCtePersonal.TipoOperacion = "A"
                SeleccionarTab(1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case _opeCCP
                Case "GENERADA"
                    oeCuentaCtePersonal.UsuarioCreacion = gUsuarioSGI.Id
                    oeCuentaCtePersonal.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olCuentaCtePersonal.Guardar(oeCuentaCtePersonal) Then
                        mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                        SeleccionarTab(0)
                        Consultar(True)
                    End If

                Case "IMPORTAR"
                    Dim _leAux = leDatosImportados.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        Dim formulario As frm_AutenticarTrabajador
                        formulario = New frm_AutenticarTrabajador
                        formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                        If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                            Throw New Exception("Ingrese un Clave Correcta")
                        Else
                            If olCuentaCtePersonal.GuardarMasivo(_leAux, gs_PrefijoIdSucursal) Then
                                mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)
                                SeleccionarTab(0)
                                Consultar(True)
                            End If
                        End If
                    Else
                        Throw New Exception("No hay datos para guardar")
                    End If
            End Select
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Select Case ficCuentaCtePersonal.SelectedTab.Index
            Case 1
                If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    SeleccionarTab(0)
                    Consultar(True)
                End If
            Case 2
                If MessageBox.Show("¿Desea Cancelar la Importación de Datos?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    SeleccionarTab(0)
                    Consultar(True)
                End If
        End Select
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                oeCuentaCtePersonal = New e_CuentaCtePersonal
                oeCuentaCtePersonal.Id = griCuentaCtePersonal.ActiveRow.Cells("Id").Value
                oeCuentaCtePersonal.UsuarioCreacion = gUsuarioSGI.Id
                If olCuentaCtePersonal.Eliminar(oeCuentaCtePersonal) Then
                    mensajeEmergente.Confirmacion("El registro fue eliminado correctamente!!", True)
                End If
                Consultar(True)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griCuentaCtePersonal.Rows.Count > 0 Then
                    Exportar_Excel(griCuentaCtePersonal, "Cuenta Bancaria de Personal")
                Else
                    Throw New Exception("¡No hay Registos para Exportar!")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CuentaCtePersonal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficCuentaCtePersonal.SelectedTab.Index
            Case 0
                If griCuentaCtePersonal.Rows.Count > 0 Then
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

    Private Sub frm_CuentaCtePersonal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CuentaCtePersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If bandcargar Then
                MostrarTabs(0, ficCuentaCtePersonal)
                colorRegistrados.Color = Color.LightGreen
                colorNoRegistrados.Color = Color.Gold
                ficCuentaCtePersonal.Tabs(0).Enabled = True
                ficCuentaCtePersonal.Tabs(1).Enabled = False
                ficCuentaCtePersonal.Tabs(2).Enabled = False
                CargarCtaCtePer(New List(Of e_CuentaCtePersonal))
                CargarCombos()
            Else
                MostrarTabs(1, ficCuentaCtePersonal)
                ficCuentaCtePersonal.Tabs(0).Enabled = False
                ficCuentaCtePersonal.Tabs(1).Enabled = True
                ficCuentaCtePersonal.Tabs(2).Enabled = False
            End If
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajador_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajador.ValueChanged
        If cboTrabajador.SelectedIndex > -1 Then oeCuentaCtePersonal.IdTrabajador = cboTrabajador.Value
    End Sub

    Private Sub cboEntidadBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEntidadBancaria.ValueChanged
        If cboEntidadBancaria.SelectedIndex > -1 Then oeCuentaCtePersonal.IdEntidadBancaria = cboEntidadBancaria.Value : oeCuentaCtePersonal.EntidadBancaria = cboEntidadBancaria.Text
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        If cboMoneda.SelectedIndex > -1 Then oeCuentaCtePersonal.IdMoneda = cboMoneda.Value : oeCuentaCtePersonal.Moneda = cboMoneda.Text
    End Sub

    Private Sub txtNroCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroCuenta.ValueChanged
        oeCuentaCtePersonal.NroCuenta = txtNroCuenta.Text
    End Sub

    Private Sub cboConcepto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.ValueChanged
        If cboConcepto.SelectedIndex > -1 Then oeCuentaCtePersonal.TipoConcepto = cboConcepto.Text
        cboBeneficiario.ReadOnly = IIf(cboConcepto.Text = "JUDICIAL", False, True)
        cboVinculo.ReadOnly = IIf(cboConcepto.Text = "JUDICIAL", False, True)
        If cboConcepto.Text <> "JUDICIAL" Then cboBeneficiario.SelectedIndex = -1 : cboVinculo.SelectedIndex = -1
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty
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
                        etiEjecuta.Text = "Procesando " & ln_Fila & " registros ... "
                        oeCuentaCtePersonal = New e_CuentaCtePersonal
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        oeEmpresa = New e_Empresa
                        oeEmpresa.TipoBusca = 3 : oeEmpresa.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                        If leEmpresa.Contains(oeEmpresa) Then oeEmpresa = leEmpresa.Item(leEmpresa.IndexOf(oeEmpresa))
                        oeMoneda = New e_Moneda
                        oeMoneda.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value)
                        If leMoneda.Contains(oeMoneda) Then oeMoneda = leMoneda.Item(leMoneda.IndexOf(oeMoneda))
                        With oeCuentaCtePersonal
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .IdEntidadBancaria = oeEmpresa.Id
                            .EntidadBancaria = IIf(oeEmpresa.Id = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value), oeEmpresa.Nombre)
                            .NroCuenta = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value)
                            .TipoConcepto = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value)
                            .IdMoneda = oeMoneda.Id
                            .Moneda = IIf(oeMoneda.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value), oeMoneda.Nombre)
                            .Activo = False
                        End With
                        leDatosImportados.Add(oeCuentaCtePersonal)
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
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            mensajeEmergente.Confirmacion("Se han Procesado " & leDatosImportados.Count & " registros", True)
            etiEjecuta.Visible = False
        Catch ex As Exception
            etiEjecuta.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            etiEjecuta.Visible = False
        End Try
    End Sub

    Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar.Click
        Try
            Dim nroreg As Integer = 0, nrotrab As Integer = 0, nrobanco As Integer = 0
            Dim ls_msg As String = String.Empty
            CargarCombos()
            If leDatosImportados.Count > 0 Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty : upbLoad.Visible = True
                upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                For Each oeImp In leDatosImportados
                    nroreg = nroreg + 1
                    etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leDatosImportados.Count
                    upbLoad.Value = Math.Round(nroreg / leDatosImportados.Count, 2) * 50
                    ' Verifica si los Trabajadores entan registradas en el SGI
                    If oeImp.IdTrabajador = "" Then
                        oeImp.Activo = False
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = oeImp.Dni
                        If leTrabajador.Contains(oeTrabajador) Then
                            Dim _leAux = leTrabajador.Where(Function(it) it.oePersona.Dni = oeTrabajador.oePersona.Dni).ToList
                            If _leAux.Count > 0 Then
                                oeImp.IdTrabajador = _leAux(0).Id : oeImp.Activo = True
                            End If
                        End If
                    Else
                        oeImp.Activo = True
                    End If
                    If oeImp.IdTrabajador.Trim = String.Empty Then nrotrab = nrotrab + 1
                    ' Verifica si las Empresas entan registradas en el SGI
                    If oeImp.IdEntidadBancaria = "" Then
                        oeImp.Activo = False
                        oeEmpresa = New e_Empresa
                        oeEmpresa.TipoBusca = 3 : oeEmpresa.Abreviatura = oeImp.EntidadBancaria
                        If leEmpresa.Contains(oeEmpresa) Then oeEmpresa = leEmpresa.Item(leEmpresa.IndexOf(oeEmpresa)) : oeImp.Activo = True
                        oeImp.IdEntidadBancaria = oeEmpresa.Id
                    End If
                    If oeImp.IdEntidadBancaria.Trim = String.Empty Then nrobanco = nrobanco + 1
                    If oeImp.IdMoneda = "" Then
                        oeMoneda = New e_Moneda
                        oeMoneda.Nombre = oeImp.Moneda
                        If leMoneda.Contains(oeMoneda) Then oeMoneda = leMoneda.Item(leMoneda.IndexOf(oeMoneda))
                        oeImp.IdMoneda = oeMoneda.Id
                    End If
                Next
                CargarImportar(leDatosImportados)
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            ' Verifica si estan Registrados en Regimen Pensionario
            Listar()
            For Each oeCtaCteTra In leDatosImportados
                nroreg = nroreg + 1
                etiEjecuta.Text = "Validando Registro " & (nroreg - leDatosImportados.Count) & " de " & leDatosImportados.Count
                upbLoad.Value = Math.Round(nroreg / leDatosImportados.Count, 2) * 50
                If oeCtaCteTra.IdTrabajador.Trim <> "" AndAlso oeCtaCteTra.IdEntidadBancaria.Trim <> "" _
                    AndAlso oeCtaCteTra.IdMoneda.Trim <> "" AndAlso oeCtaCteTra.NroCuenta.Trim <> "" Then
                    oeCtaCteTra.Equivale = 2
                    If Not leCuentaCtePersonal.Contains(oeCtaCteTra) Then
                        oeCtaCteTra.TipoOperacion = "I"
                        oeCtaCteTra.Activo = True : oeCtaCteTra.Vigente = True
                        oeCtaCteTra.UsuarioCreacion = gUsuarioSGI.Id
                    Else
                        oeCtaCteTra.Activo = False
                    End If
                End If
            Next
            If nrotrab > 0 Then ls_msg = " * " & nrotrab & " Trabajadores no registrados." & Environment.NewLine
            If nrobanco > 0 Then ls_msg = ls_msg & " * " & nrobanco & " Trabajadores con bancos no registrados."
            If ls_msg.Trim.Length > 0 Then
                'btnDatosExcluidos.Enabled = True
                ls_msg = "Se necesita solucionar lo siguente: " & Environment.NewLine & ls_msg
            Else
                ls_msg = "Todos los Datos estan Listos para Importar"
            End If
            mensajeEmergente.Confirmacion("Se Validaron " & leDatosImportados.Count & " Registros" & Environment.NewLine & ls_msg, True)
            etiEjecuta.Visible = False : upbLoad.Visible = False
        Catch ex As Exception
            etiEjecuta.Visible = False : upbLoad.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            etiEjecuta.Visible = False : upbLoad.Visible = False
        End Try
    End Sub

    Private Sub verTrabajador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTrabajador.CheckedChanged
        CargarImportar(leDatosImportados)
    End Sub

    Private Sub verEmpresa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verEmpresa.CheckedChanged
        CargarImportar(leDatosImportados)
    End Sub

    Private Sub griCuentaCtePersonal_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griCuentaCtePersonal.DoubleClick
        If griCuentaCtePersonal.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub mnuMantCtaBan_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuMantCtaBan.ToolClick
        Select Case e.Tool.Key
            Case "GrabarCta"
                Dim oeCtaBanAux As New e_CuentaCtePersonal
                Dim _idPerDoc As String = String.Empty
                ' oePersonaDocumento.TipoDocumento = cboTipoDocumento.Text
                oeCuentaCtePersonal.Equivale = 1
                If Not leCuentaCtePersonal.Contains(oeCuentaCtePersonal) Then
                    oeCuentaCtePersonal.Equivale = 2
                    If Not leCuentaCtePersonal.Contains(oeCuentaCtePersonal) Then
                        oeCuentaCtePersonal.TipoOperacion = "I"
                        oeCuentaCtePersonal.UsuarioCreacion = gUsuarioSGI.Id
                        leCuentaCtePersonal.Add(oeCuentaCtePersonal)
                    Else
                        oeCtaBanAux = leCuentaCtePersonal.Item(leCuentaCtePersonal.IndexOf(oeCuentaCtePersonal))
                        If oeCtaBanAux.TipoOperacion = "E" Then
                            oeCtaBanAux.Activo = True
                            oeCtaBanAux.TipoOperacion = "A"
                        Else
                            Throw New Exception("El Nro Cuenta: " & oeCtaBanAux.NroCuenta & "ya esta Registrado")
                        End If
                    End If
                Else
                    oeCtaBanAux = New e_CuentaCtePersonal
                    oeCtaBanAux = leCuentaCtePersonal.Item(leCuentaCtePersonal.IndexOf(oeCuentaCtePersonal))
                    _idPerDoc = oeCtaBanAux.Id
                    oeCuentaCtePersonal.Equivale = 2
                    If Not leCuentaCtePersonal.Contains(oeCuentaCtePersonal) Then
                        oeCtaBanAux.NroCuenta = oeCuentaCtePersonal.NroCuenta
                        oeCtaBanAux.TipoConcepto = oeCuentaCtePersonal.TipoConcepto
                        oeCtaBanAux.TipoOperacion = "A"
                    Else
                        oeCtaBanAux = leCuentaCtePersonal.Item(leCuentaCtePersonal.IndexOf(oeCuentaCtePersonal))
                        If oeCtaBanAux.TipoOperacion = "E" Then
                            oeCtaBanAux.Activo = True
                            oeCtaBanAux.TipoOperacion = "A"
                        Else
                            If oeCtaBanAux.Id = _idPerDoc Then
                                oeCtaBanAux.TipoOperacion = "A"
                            Else
                                Throw New Exception("El Nro Cuenta: " & oeCtaBanAux.NroCuenta & " ya esta Registrado")
                            End If
                        End If
                    End If
                End If
                'lePersonaDocumento.Add(oePersonaDocumento)
                mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente!!", True)
                Me.Close()
            Case "CancelarCta"
                If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                  , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub cboBeneficiario_ValueChanged(sender As Object, e As EventArgs) Handles cboBeneficiario.ValueChanged
        If cboBeneficiario.SelectedIndex > -1 Then oeCuentaCtePersonal.IdBeneficiario = cboBeneficiario.Value
    End Sub

    Private Sub cboVinculo_ValueChanged(sender As Object, e As EventArgs) Handles cboVinculo.ValueChanged
        If cboVinculo.SelectedIndex > -1 Then oeCuentaCtePersonal.Vinculo = cboVinculo.Value
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oeTrabajador = New e_Trabajador
            leTrabajador = New List(Of e_Trabajador)
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)

            oePersona = New e_Persona
            oePersona.TipoOperacion = ""
            oePersona.Activo = True
            lePersona = olPersona.Listar(oePersona)

            oeEmpresa = New e_Empresa
            leEmpresa = New List(Of e_Empresa)
            cboEntidadBancaria.DataSource = Nothing

            oeEmpresa.TipoOperacion = ""
            oeEmpresa.Activo = True
            leEmpresa = olEmpresa.Listar(oeEmpresa).Where(Function(it) it.TipoEmpresa = gTEFinancieraBancaria).ToList
            LlenarCombo(cboEntidadBancaria, "Nombre", leEmpresa, -1)

            oeMoneda = New e_Moneda
            leMoneda = New List(Of e_Moneda)
            cboMoneda.DataSource = Nothing

            oeMoneda.TipoOperacion = ""
            oeMoneda.Activo = True
            leMoneda = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboMoneda, "Nombre", leMoneda, -1)

            cboConcepto.Items.Clear()
            cboConcepto.Items.Add("SUELDO")
            cboConcepto.Items.Add("CTS")
            cboConcepto.Items.Add("JUDICIAL")
            cboConcepto.SelectedIndex = -1

            LlenaComboConfigurable(cboVinculo, "T19_VinculoFamiliar", "CODIGO", "NOMBRE", -1)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try

            oeCuentaCtePersonal = New e_CuentaCtePersonal
            oeCuentaCtePersonal.TipoOperacion = ""
            oeCuentaCtePersonal.Activo = True
            oeCuentaCtePersonal.Vigente = 1
            leCuentaCtePersonal = olCuentaCtePersonal.Listar(oeCuentaCtePersonal)

            CargarCtaCtePer(leCuentaCtePersonal)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCtaCtePer(ByVal leCtaCtePer As List(Of e_CuentaCtePersonal))
        Try

            With griCuentaCtePersonal
                .ResetDisplayLayout()
                .DataSource = leCtaCtePer
                ConfiguraGrilla(griCuentaCtePersonal, 1)
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        cboTrabajador.SelectedIndex = -1
        cboEntidadBancaria.SelectedIndex = -1
        cboMoneda.SelectedIndex = -1
        cboConcepto.SelectedIndex = -1
        txtNroCuenta.Text = String.Empty
        cboBeneficiario.SelectedIndex = -1
        cboVinculo.SelectedIndex = -1
    End Sub

    Private Sub Mostrar()
        Try
            oeCuentaCtePersonal = New e_CuentaCtePersonal
            oeCuentaCtePersonal.Id = griCuentaCtePersonal.ActiveRow.Cells("Id").Value
            oeCuentaCtePersonal = olCuentaCtePersonal.Obtener(oeCuentaCtePersonal)
            CargarDatos(oeCuentaCtePersonal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarImportar(ByVal leImportar As List(Of e_CuentaCtePersonal))
        Try
            With griImporta

                .ResetDisplayLayout()

                Dim leAux As New List(Of e_CuentaCtePersonal)

                If verTrabajador.Checked Then
                    leAux = leImportar.Where(Function(it) it.IdTrabajador = "").ToList
                End If

                If verEmpresa.Checked Then
                    If verTrabajador.Checked Then
                        leAux = leImportar.Where(Function(it) it.IdTrabajador = "" Or it.IdEntidadBancaria = "").ToList
                    Else
                        leAux = leImportar.Where(Function(it) it.IdEntidadBancaria = "").ToList
                    End If
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
                        If Fila.Cells("IdEntidadBancaria").Value.ToString <> "" Then
                            Fila.Cells("EntidadBancaria").Appearance.BackColor = colorRegistrados.Color
                        Else
                            Fila.Cells("EntidadBancaria").Appearance.BackColor = colorNoRegistrados.Color
                        End If
                    Next
                    .Text = "Datos Importados (" & .Rows.Count & ")"
                    btnValidar.Enabled = True
                    verTrabajador.Enabled = True
                    verEmpresa.Enabled = True
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(ByVal Grilla As UltraWinGrid.UltraGrid, ByVal Tipo As Integer)
        Try
            With Grilla

                ExcluirColumna(Grilla, "Id", "IdTrabajador", "IdEntidadBancaria", "IdMoneda", "IdBeneficiario", "FechaCreacion", "UsuarioCreacion")
                If Tipo <> 3 Then .DisplayLayout.Bands(0).Columns("Activo").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True

                OcultarColumna(Grilla, True, "Id", "IdTrabajador", "IdEntidadBancaria", "IdMoneda", "IdBeneficiario", "FechaCreacion", "UsuarioCreacion")
                If Tipo <> 3 Then .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("EntidadBancaria").Width = 200
                .DisplayLayout.Bands(0).Columns("NroCuenta").Width = 125
                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("TipoConcepto").Width = 70
                .DisplayLayout.Bands(0).Columns("Moneda").Width = 50
                .DisplayLayout.Bands(0).Columns("Beneficiario").Width = 200
                .DisplayLayout.Bands(0).Columns("Vinculo").Width = 50
                .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                .DisplayLayout.Bands(0).Columns("TipoConcepto").Header.Caption = "Tipo"
                .DisplayLayout.Bands(0).Columns("Vigente").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("Dni").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NroCuenta").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("EntidadBancaria").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("TipoConcepto").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Moneda").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Beneficiario").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Vinculo").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Vigente").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Activo").Header.VisiblePosition = 9

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

    Private Sub CargarDatos(oeCtaBan As e_CuentaCtePersonal)
        With oeCtaBan
            cboTrabajador.Value = .IdTrabajador
            cboEntidadBancaria.Value = .IdEntidadBancaria
            cboMoneda.Value = .IdMoneda
            txtNroCuenta.Text = .NroCuenta
            cboConcepto.Text = .TipoConcepto
            If cboConcepto.Text = "JUDICIAL" Then
                cboBeneficiario.Value = .IdBeneficiario
                If Not IsDBNull(.Vinculo) AndAlso .Vinculo.Trim <> String.Empty AndAlso CInt(.Vinculo) > 0 Then cboVinculo.Value = CInt(.Vinculo)
            End If
        End With
    End Sub

    Private Sub SeleccionarTab(_index)
        ficCuentaCtePersonal.Tabs(0).Enabled = False
        ficCuentaCtePersonal.Tabs(1).Enabled = False
        ficCuentaCtePersonal.Tabs(2).Enabled = False
        ficCuentaCtePersonal.Tabs(_index).Enabled = True
        ficCuentaCtePersonal.Tabs(_index).Selected = True
    End Sub

    Private Sub Importar()
        Try
            _acl = gAccionSistema.IMPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeCCP = "IMPORTAR"
                SeleccionarTab(2)
                verTrabajador.Checked = False
                verEmpresa.Checked = False
                btnValidar.Enabled = False
                verTrabajador.Enabled = False
                verEmpresa.Enabled = False
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                CargarImportar(New List(Of e_CuentaCtePersonal))
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mnuCtaCtePer_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuCtaCtePer.Opening
        mnuCtaCtePer.Items("tsmiNuevo").Enabled = True
        mnuCtaCtePer.Items("tsmiEditar").Enabled = False
        mnuCtaCtePer.Items("tsmiEliminar").Enabled = False
        mnuCtaCtePer.Items("tsmiImportar").Enabled = True
        If griCuentaCtePersonal.Rows.Count > 0 Then
            mnuCtaCtePer.Items("tsmiEditar").Enabled = True
            mnuCtaCtePer.Items("tsmiEliminar").Enabled = True
        End If
    End Sub

    Private Sub tsmiNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub tsmiImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiImportar.Click
        Importar()
    End Sub

#End Region

End Class