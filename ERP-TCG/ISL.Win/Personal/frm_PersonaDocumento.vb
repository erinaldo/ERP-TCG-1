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
Imports System.IO
Imports System.Configuration
Imports System.Collections.Specialized

Public Class frm_PersonaDocumento
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New(Accion As String, oePerDoc As e_PersonaDocumento, oePerAux As e_Persona)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mnuManDocPer.Visible = True
        bandcargar = False
        Inicializa()
        CargarCombos()
        oePersonaDocumento = oePerDoc
        lePersonaDocumento = oePerAux.leDocumento
        Select Case Accion
            Case "Agregar"
                'Dim _leTAux = From le In leTrabajador _
                '                  Select le.oePersona.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado _
                '                  Where Activo = True And IndEstado <> 0 _
                '                  Order By NombreCompleto
                'LlenarCombo(cboTrabajador, "NombreCompleto", _leTAux.ToList, -1)
                cboTrabajador.Value = oePersonaDocumento.IdPersona
            Case "Editar"
                'Dim _leTAux = From le In leTrabajador _
                '            Select le.oePersona.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado _
                '            Order By NombreCompleto
                'LlenarCombo(cboTrabajador, "NombreCompleto", _leTAux.ToList, -1)
                CargarDatos(oePersonaDocumento)
                cboTipoDocumento.ReadOnly = True
        End Select
        cboTrabajador.ReadOnly = True
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mnuManDocPer.Visible = False
    End Sub

    Private Shared instancia As frm_PersonaDocumento = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_PersonaDocumento()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oePersonaDocumento As New e_PersonaDocumento, olPersonaDocumento As New l_PersonaDocumento
    Private lePersonaDocumento As New List(Of e_PersonaDocumento), leHistorial As New List(Of e_PersonaDocumento)
    Private leDatosImportados As New List(Of e_PersonaDocumento)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeTipoDocumento As New e_TipoDocumento, olTipoDocumento As New l_TipoDocumento, leTipoDocumento As New List(Of e_TipoDocumento)
    Private lonDoc As Integer = 0
    Private bandcargar As Boolean = True
    Private oeAccionUsuario As New e_ActividadRestringida_Usuario
    Private _opePD As String = "", _acl As String = "", _estado As String = ""
    Private listaImagenes As New List(Of String)
    Private listaImagen As DataTable
    Public IpServidor As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidor")
    Private rutacomprobacion As String = "\\" & DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidor") & "\ControlFlota\PersonalDocumento"

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            If ckDiasVencimiento.Checked Then
                If MessageBox.Show("Usted Tiene la Busqueda por Dias de Vencimiento activado." & Environment.NewLine & _
                                   "Recuerde que no es necesario ejecutar esta accion para realizar busqueda por dias." & Environment.NewLine & _
                                   "¿Desea Mantener la búsqueda por Dias de Vencimiento?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    ckDiasVencimiento.Checked = False
                    ndDiasVencimiento.ReadOnly = True
                    ndDiasVencimiento.Value = 15
                    etiPorVencer.Text = "Por Vencer a " & ndDiasVencimiento.Value & " Dias:"
                End If
            End If
            Listar()
            If griPersonaDocumento.Rows.Count > 0 Then
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
            If VerificaAccion(_acl) Then
                _opePD = "GENERADA"
                oePersonaDocumento = New e_PersonaDocumento
                oePersonaDocumento.TipoOperacion = "I"
                oePersonaDocumento.Activo = True
                oePersonaDocumento.Vigente = 1
                Inicializa()
                'Dim _leTAux = From le In leTrabajador _
                '                  Select le.oePersona.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado _
                '                  Where Activo = True And IndEstado <> 0 _
                '                  Order By NombreCompleto
                'LlenarCombo(cboTrabajador, "NombreCompleto", _leTAux.ToList, -1)
                cboTrabajador.ReadOnly = False
                MostrarTabs(1, ficPersonaDocumento)
                ficPersonaDocumento.Tabs(0).Enabled = False
                ficPersonaDocumento.Tabs(1).Enabled = True
                ficPersonaDocumento.Tabs(2).Enabled = False
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
            If VerificaAccion(_acl) Then
                _opePD = "GENERADA"
                Inicializa()
                'Dim _leTAux = From le In leTrabajador _
                '              Select le.oePersona.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado _
                '              Order By NombreCompleto
                'cboTrabajador.Clear()
                'LlenarCombo(cboTrabajador, "NombreCompleto", _leTAux.ToList, -1)
                'LlenarCombo(cboTrabajador, "NombreCompleto", leTrabajador, -1)
                cboTrabajador.ReadOnly = False
                Mostrar()
                oePersonaDocumento.TipoOperacion = "A"
                MostrarTabs(1, ficPersonaDocumento)
                ficPersonaDocumento.Tabs(0).Enabled = False
                ficPersonaDocumento.Tabs(1).Enabled = True
                ficPersonaDocumento.Tabs(2).Enabled = False
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
            Select Case _opePD
                Case "GENERADA"
                    llenarObjeto()
                    oePersonaDocumento.UsuarioCreacion = gUsuarioSGI.Id
                    'oePersonaDocumento.FechaActividad = FecActividad.Value
                    'oePersonaDocumento.FechaVencimiento = fecVencimiento.Value
                    oePersonaDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olPersonaDocumento.Guardar(oePersonaDocumento) Then
                        mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                        MostrarTabs(0, ficPersonaDocumento)
                        ficPersonaDocumento.Tabs(0).Enabled = True
                        ficPersonaDocumento.Tabs(1).Enabled = False
                        ficPersonaDocumento.Tabs(2).Enabled = False
                        Consultar(True)
                    End If
                Case "IMPORTAR"
                    Dim _leAux = leDatosImportados.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        'Dim formulario As frm_AutenticarTrabajador
                        'formulario = New frm_AutenticarTrabajador
                        'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                        'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        '    Throw New Exception("Ingrese un Clave Correcta")
                        'Else
                        If olPersonaDocumento.GuardarMasivo(_leAux, gs_PrefijoIdSucursal) Then
                            mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)
                            MostrarTabs(0, ficPersonaDocumento)
                            ficPersonaDocumento.Tabs(0).Enabled = True
                            ficPersonaDocumento.Tabs(1).Enabled = False
                            ficPersonaDocumento.Tabs(2).Enabled = False
                            Consultar(True)
                        End If
                        'End If
                    Else
                        Throw New Exception("No hay datos para guardar")
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Select Case ficPersonaDocumento.SelectedTab.Index
            Case 1
                If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    MostrarTabs(0, ficPersonaDocumento)
                    ficPersonaDocumento.Tabs(0).Enabled = True
                    ficPersonaDocumento.Tabs(1).Enabled = False
                    ficPersonaDocumento.Tabs(2).Enabled = False
                    Consultar(True)
                End If
            Case 2
                If MessageBox.Show("¿Desea Cancelar la Importación de Datos?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    MostrarTabs(0, ficPersonaDocumento)
                    ficPersonaDocumento.Tabs(0).Enabled = True
                    ficPersonaDocumento.Tabs(1).Enabled = False
                    ficPersonaDocumento.Tabs(2).Enabled = False
                    Consultar(True)
                End If
        End Select
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If VerificaAccion(_acl) Then

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
            If VerificaAccion(_acl) Then
                If griPersonaDocumento.Rows.Count > 0 Then
                    Exportar_Excel(griPersonaDocumento, "Documentos de Trabajadores")
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

    Private Sub frm_PersonaDocumento_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Select Case ficPersonaDocumento.SelectedTab.Index
            Case 0
                If griPersonaDocumento.Rows.Count > 0 Then
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

    Private Sub frm_PersonaDocumento_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_PersonaDocumento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            colorPorVencer.Color = Color.LightGreen
            colorVencido.Color = Color.LightCoral
            colorPorVencer2.Color = Color.Gold
            ckDiasVencimiento.Checked = False
            ndDiasVencimiento.ReadOnly = True
            ndDiasVencimiento.Value = 15
            etiPorVencer.Text = "Por Vencer a " & ndDiasVencimiento.Value & " Dias:"
            If bandcargar Then
                CargarPerDoc(New List(Of e_PersonaDocumento))
                MostrarTabs(0, ficPersonaDocumento)
                colorRegistrados.Color = Color.LightGreen
                colorNoRegistrados.Color = Color.Gold
                ficPersonaDocumento.Tabs(0).Enabled = True
                ficPersonaDocumento.Tabs(1).Enabled = False
                ficPersonaDocumento.Tabs(2).Enabled = False
                CargarCombos()
            Else
                'CargarCombos()
                MostrarTabs(1, ficPersonaDocumento)
                ficPersonaDocumento.Tabs(0).Enabled = False
                ficPersonaDocumento.Tabs(1).Enabled = True
                ficPersonaDocumento.Tabs(2).Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajador_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTrabajador.ValueChanged
        Try
            If cboTrabajador.SelectedIndex > -1 Then oePersonaDocumento.IdPersona = cboTrabajador.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub cboTipoDocumento_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        If cboTipoDocumento.SelectedIndex > -1 Then oePersonaDocumento.IdTipoDocumento = cboTipoDocumento.Value : oePersonaDocumento.TipoDocumento = cboTipoDocumento.Text
    End Sub

    Private Sub txtNumero_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtNumero.ValueChanged
        oePersonaDocumento.NumeroDocumento = txtNumero.Text
    End Sub

    Private Sub FecActividad_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FecActividad.ValueChanged
        oePersonaDocumento.FechaActividad = FecActividad.Value
    End Sub

    Private Sub fecVencimiento_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fecVencimiento.ValueChanged
        oePersonaDocumento.FechaVencimiento = fecVencimiento.Value
    End Sub

    Private Sub txtDescripcion_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtDescripcion.ValueChanged
        oePersonaDocumento.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
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
                        oePersonaDocumento = New e_PersonaDocumento
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        End If
                        With oePersonaDocumento
                            .Id = String.Empty
                            .IdPersona = oeTrabajador.oePersona.Id
                            .Nombre = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .IdTipoDocumento = cboTipoDocBus.Value
                            .TipoDocumento = cboTipoDocBus.Text
                            .NumeroDocumento = objWorkSheet.Cells(ln_Fila + 1, 3).value
                            .Descripcion = objWorkSheet.Cells(ln_Fila + 1, 4).Value
                            .FechaActividad = objWorkSheet.Cells(ln_Fila + 1, 5).Value
                            .FechaVencimiento = objWorkSheet.Cells(ln_Fila + 1, 6).value
                            .Activo = False
                        End With
                        oePersonaDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leDatosImportados.Add(oePersonaDocumento)
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

    Private Sub btnValidar_Click(sender As System.Object, e As System.EventArgs) Handles btnValidar.Click
        Try

            CargarCombos()
            If leDatosImportados.Count > 0 Then

                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()

                For Each oeImp In leDatosImportados
                    ' Verifica si los Trabajadores entan registradas en el ERP
                    If oeImp.IdPersona = "" Then
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = oeImp.Dni
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        End If
                        oeImp.IdPersona = oeTrabajador.oePersona.Id
                    End If
                Next
                CargarImportar(leDatosImportados)
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            ' Verifica si estan Registrados en Regimen Pensionario
            Listar()
            For Each oePerDoc In leDatosImportados
                If oePerDoc.IdPersona <> "" AndAlso lonDoc > 0 _
                    AndAlso lonDoc = oePerDoc.NumeroDocumento.Trim.Length Then
                    If Not lePersonaDocumento.Contains(oePerDoc) Then
                        oePerDoc.TipoOperacion = "I"
                        oePerDoc.Activo = True
                        oePerDoc.Vigente = 1
                        oePerDoc.UsuarioCreacion = gUsuarioSGI.Id
                    Else
                        oePerDoc.Activo = False
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

    Private Sub verTrabajador_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles verTrabajador.CheckedChanged
        CargarImportar(leDatosImportados)
    End Sub

    Private Sub griPersonaDocumento_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griPersonaDocumento.DoubleClick
        If griPersonaDocumento.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub mnuManDocPer_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuManDocPer.ToolClick
        Try
            Select Case e.Tool.Key
                Case "GrabarDoc"
                    Dim oePerDocAux As New e_PersonaDocumento
                    Dim _idPerDoc As String = String.Empty
                    ' oePersonaDocumento.TipoDocumento = cboTipoDocumento.Text
                    llenarObjeto()
                    If oePersonaDocumento.IdPersona = "" Then Throw New Exception("Debe Seleccionar Trabajador.")
                    If oePersonaDocumento.IdTipoDocumento = "" Then Throw New Exception("Debe Seleccionar tipo documento.")
                    oePersonaDocumento.Equivale = 1
                    If Not lePersonaDocumento.Contains(oePersonaDocumento) Then
                        oePersonaDocumento.Equivale = 2
                        If Not lePersonaDocumento.Contains(oePersonaDocumento) Then
                            oePersonaDocumento.TipoOperacion = "I"
                            oePersonaDocumento.UsuarioCreacion = gUsuarioSGI.Id
                            lePersonaDocumento.Add(oePersonaDocumento)
                        Else
                            oePerDocAux = lePersonaDocumento.Item(lePersonaDocumento.IndexOf(oePersonaDocumento))
                            If oePerDocAux.TipoOperacion = "E" Then
                                oePerDocAux.Activo = True
                                oePerDocAux.TipoOperacion = "A"
                            Else
                                Throw New Exception("El Documento: " & oePerDocAux.Nombre & "ya esta Registrado")
                            End If
                        End If
                    Else
                        oePerDocAux = New e_PersonaDocumento
                        oePerDocAux = lePersonaDocumento.Item(lePersonaDocumento.IndexOf(oePersonaDocumento))
                        _idPerDoc = oePerDocAux.Id
                        oePersonaDocumento.Equivale = 2
                        If Not lePersonaDocumento.Contains(oePersonaDocumento) Then
                            oePerDocAux.NumeroDocumento = oePersonaDocumento.NumeroDocumento
                            oePerDocAux.TipoDocumento = oePersonaDocumento.TipoDocumento
                            oePerDocAux.TipoOperacion = "A"
                        Else
                            oePerDocAux = lePersonaDocumento.Item(lePersonaDocumento.IndexOf(oePersonaDocumento))
                            If oePerDocAux.TipoOperacion = "E" Then
                                oePerDocAux.Activo = True
                                oePerDocAux.TipoOperacion = "A"
                            Else
                                If oePerDocAux.Id = _idPerDoc Then
                                    oePerDocAux.TipoOperacion = "A"
                                Else
                                    Throw New Exception("El Documento: " & oePerDocAux.Nombre & " ya esta Registrado")
                                End If
                            End If
                        End If
                    End If
                    'lePersonaDocumento.Add(oePersonaDocumento)
                    mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente!!", True)
                    Me.Close()
                Case "CancelarDoc"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                      , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
        
    End Sub

    Private Sub ndDiasVencimiento_ValueChanged(sender As Object, e As EventArgs) Handles ndDiasVencimiento.ValueChanged
        Try
            If ndDiasVencimiento.Value > 0 Then
                etiPorVencer.Text = "Por Vencer a " & ndDiasVencimiento.Value & " Dias:"
                CargarFiltros()
            Else
                etiPorVencer.Text = "Por Vencer a 0 Dias:"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub ckDiasVencimiento_CheckedChanged(sender As Object, e As EventArgs) Handles ckDiasVencimiento.CheckedChanged
        ndDiasVencimiento.ReadOnly = Not ckDiasVencimiento.Checked
    End Sub

    Private Sub cboEstadoBus_ValueChanged(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oeTrabajador = New e_Trabajador
            leTrabajador = New List(Of e_Trabajador)
            cboTrabajador.DataSource = Nothing
            cboTrabajadorBus.DataSource = Nothing

            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)

            Dim _leTAux2 = From le In leTrabajador _
                          Select le.oePersona.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado _
                          Order By NombreCompleto


            LlenarCombo(cboTrabajador, "NombreCompleto", _leTAux2.ToList, -1)

            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = ""
            oeTrabajador.oePersona.ApellidoPaterno = " [TODOS] "
            Dim _leTB As New List(Of e_Trabajador)
            _leTB.Add(oeTrabajador)
            _leTB.AddRange(leTrabajador)
            Dim _leTAux = From le In _leTB _
                          Select le.oePersona.Id, le.oePersona.NombreCompleto, le.oePersona.Dni _
                          Order By NombreCompleto
            LlenarCombo(cboTrabajadorBus, "NombreCompleto", _leTAux.ToList, 0)

            oeTipoDocumento = New e_TipoDocumento
            leTipoDocumento = New List(Of e_TipoDocumento)
            cboTipoDocumento.DataSource = Nothing
            cboTipoDocBus.DataSource = Nothing

            oeTipoDocumento.TipoOperacion = "Z"
            leTipoDocumento = olTipoDocumento.Listar(oeTipoDocumento)
            LlenarCombo(cboTipoDocumento, "Nombre", leTipoDocumento, -1)
            Dim _leTDAux As New List(Of e_TipoDocumento)
            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.Id = ""
            oeTipoDocumento.Nombre = " [TODOS] "
            _leTDAux.Add(oeTipoDocumento)
            _leTDAux.AddRange(leTipoDocumento)
            LlenarCombo(cboTipoDocBus, "Nombre", _leTDAux, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try

            oePersonaDocumento = New e_PersonaDocumento
            oePersonaDocumento.TipoOperacion = ""
            oePersonaDocumento.IdTipoDocumento = cboTipoDocBus.Value
            oePersonaDocumento.IdPersona = cboTrabajadorBus.Value
            oePersonaDocumento.Activo = True
            oePersonaDocumento.Vigente = 1
            lePersonaDocumento = olPersonaDocumento.Listar(oePersonaDocumento)

            CargarPerDoc(lePersonaDocumento)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPerDoc(lePerDoc As List(Of e_PersonaDocumento))
        Try
            With griPersonaDocumento

                .ResetDisplayLayout()
                .DataSource = lePerDoc

                .DisplayLayout.Bands(0).Columns.Add("Estado", "Estado")
                .DisplayLayout.Bands(0).Columns("Estado").DataType = System.Type.GetType("System.String")
                .DisplayLayout.Bands(0).Columns("Estado").Width = 180

                ConfiguraGrilla(griPersonaDocumento, 1)

                CargarFiltros()

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        cboTrabajador.SelectedIndex = -1
        cboTipoDocumento.SelectedIndex = -1
        txtNumero.Text = String.Empty
        FecActividad.Value = Date.Now.Date
        fecVencimiento.Value = Date.Now.Date
        CargarHistorial(New List(Of e_PersonaDocumento))
        CargarImagenes("")
    End Sub

    Private Sub Mostrar()
        Try
            oePersonaDocumento = New e_PersonaDocumento
            oePersonaDocumento.Id = griPersonaDocumento.ActiveRow.Cells("Id").Value
            oePersonaDocumento = olPersonaDocumento.Obtener(oePersonaDocumento)
            CargarDatos(oePersonaDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDatos(oePerDoc As e_PersonaDocumento)
        With oePerDoc
            cboTipoDocumento.Value = .IdTipoDocumento
            cboTrabajador.Value = .IdPersona
            'cboTipoDocumento.Value = .IdTipoDocumento
            txtNumero.Text = .NumeroDocumento
            txtDescripcion.Text = .Descripcion
            FecActividad.Value = .FechaActividad
            CargarImagenes(.RutaImagen)
            CargarHistorial(.leHistorial)
        End With
    End Sub

    Private Sub CargarHistorial(ByVal leHisPerDoc As List(Of e_PersonaDocumento))
        Try
            With griHistorial

                .ResetDisplayLayout()
                .DataSource = leHisPerDoc

                ConfiguraGrilla(griHistorial, 2)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarImagenes(ByVal rutaImagenes As String)
        Try
            'Dim objI As e_ImagenesDocumentos
            listaImagenes = New List(Of String)
            listaImagen = New DataTable
            listaImagen = EstructuraImagen()

            If rutaImagenes <> "" Then
                Dim cant = rutaImagenes.Split("*").Length
                'Dim fila As DataRow = listaImagen.NewRow()
                Dim fila As DataRow
                For i As Integer = 0 To cant - 1
                    fila = listaImagen.NewRow
                    fila("NombreImagen") = rutaImagenes.Split("*")(i)
                    listaImagen.Rows.Add(fila)
                Next
                'lbxImagenes.DataSource = listaImagenes                
                'griImagenes.UpdateData()
            End If
            'griImagenes.DataSource = listaImagen
            'griImagenes.DataBind()
            llenarGridImagen()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    'Private Sub CargarImagenes()
    '    Try
    '        'Dim objI As e_ImagenesDocumentos
    '        listaImagenes = New List(Of String)

    '        With griImagenes
    '            .ResetDisplayLayout()
    '            '.DataSource = listaImagenes
    '            ''.DisplayLayout.Bands(0).Columns.Add("Estado", "Estado")
    '            '.DisplayLayout.Bands(0).Columns(0).DataType = System.Type.GetType("System.String")
    '            '.DisplayLayout.Bands(0).Columns(0).Width = 180
    '            ConfiguraGrilla(griImagenes, 1)
    '        End With

    '        If rutaImagenes <> "" Then
    '            Dim cant = rutaImagenes.Split("*").Length
    '            For i As Integer = 0 To cant - 1
    '                listaImagenes.Add(rutaImagenes.Split("*")(i))
    '            Next
    '            'lbxImagenes.DataSource = listaImagenes
    '            griImagenes.DataSource = listaImagenes
    '            griImagenes.DataBind()
    '            'griImagenes.UpdateData()
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Confirmacion(ex.Message, True)
    '    End Try
    'End Sub

    Private Sub CargarImportar(ByVal leImportar As List(Of e_PersonaDocumento))
        Try
            With griImporta

                .ResetDisplayLayout()

                Dim leAux As New List(Of e_PersonaDocumento)

                If verTrabajador.Checked Then
                    leAux = leImportar.Where(Function(it) it.IdPersona = "").ToList
                End If


                If leAux.Count > 0 Then
                    .DataSource = leAux
                Else
                    .DataSource = leImportar
                End If

                ConfiguraGrilla(griImporta, 3)

                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("IdPersona").Value.ToString <> "" Then
                            Fila.Cells("Nombre").Appearance.BackColor = colorRegistrados.Color
                            Fila.Cells("Dni").Appearance.BackColor = colorRegistrados.Color
                        Else
                            Fila.Cells("Nombre").Appearance.BackColor = colorNoRegistrados.Color
                            Fila.Cells("Dni").Appearance.BackColor = colorNoRegistrados.Color
                        End If
                    Next
                    .Text = "Datos Importados (" & .Rows.Count & ")"
                    btnValidar.Enabled = True
                    verTrabajador.Enabled = True
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(ByVal Grilla As UltraWinGrid.UltraGrid, ByVal Tipo As Integer)
        Try
            With Grilla

                OcultarColumna(Grilla, True, "Id", "IdPersona", "IdTipoDocumento", "FechaCreacion", "UsuarioCreacion")
                If Tipo = 1 Then .DisplayLayout.Bands(0).Columns("Vigente").Hidden = True
                If Tipo = 2 Then OcultarColumna(Grilla, True, "Nombre", "Dni", "TipoDocumento")
                If Tipo <> 3 Then .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                ExcluirColumna(Grilla, "Id", "Nombre", "FechaVencimiento", "Vigente", "FechaCreacion", "UsuarioCreacion", "Activo")

                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 200
                .DisplayLayout.Bands(0).Columns("NumeroDocumento").Width = 80
                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 150
                .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                .DisplayLayout.Bands(0).Columns("Vigente").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Trabajador"
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "Documento"
                .DisplayLayout.Bands(0).Columns("NumeroDocumento").Header.Caption = "Nro. Doc."
                .DisplayLayout.Bands(0).Columns("FechaActividad").Header.Caption = "Fec. Ins."
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.Caption = "Fec. Vec."

                .DisplayLayout.Bands(0).Columns("Dni").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("NumeroDocumento").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Descripcion").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("FechaActividad").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Vigente").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Activo").Header.VisiblePosition = 8

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

    Private Sub CargarFiltros()
        Try
            With griPersonaDocumento
                Dim _dias As Integer = 0
                For Each fil In griPersonaDocumento.Rows
                    _dias = DateDiff(DateInterval.Day, Date.Now.Date, fil.Cells("FechaVencimiento").Value)
                    If _dias < 1 Then
                        fil.Cells("FechaVencimiento").Appearance.BackColor = colorVencido.Color
                        fil.Cells("Estado").Value = "VENCIDO"
                    Else
                        If _dias = ndDiasVencimiento.Value Then
                            fil.Cells("FechaVencimiento").Appearance.BackColor = colorPorVencer.Color
                            fil.Cells("Estado").Value = "POR VENCER A " & ndDiasVencimiento.Value & " DIAS"
                        Else
                            If _dias < ndDiasVencimiento.Value Then
                                fil.Cells("FechaVencimiento").Appearance.BackColor = colorPorVencer2.Color
                                fil.Cells("Estado").Value = "POR VENCER ANTES DE " & ndDiasVencimiento.Value & " DIAS"
                            End If
                        End If
                    End If
                Next

                .UpdateData()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function VerificaAccion(_accion As String) As Boolean
        Try
            If gUsuarioSGI.leARUsuario.Count > 0 Then
                oeAccionUsuario = New e_ActividadRestringida_Usuario
                oeAccionUsuario.IdActividadNegocio = pIdActividadNegocio
                oeAccionUsuario.AccionSistema = _accion
                oeAccionUsuario.Equivale = 1
                If gUsuarioSGI.leARUsuario.Contains(oeAccionUsuario) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Menu Contextual"

    Private Sub mnuPerDoc_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles mnuPerDoc.Opening
        mnuPerDoc.Items("tsmiNuevo").Enabled = True
        mnuPerDoc.Items("tsmiImportar").Enabled = True
        mnuPerDoc.Items("tsmiExportar").Enabled = IIf(griPersonaDocumento.Rows.Count > 0, True, False)
        mnuPerDoc.Items("tsmiEditar").Enabled = IIf(griPersonaDocumento.Selected.Rows.Count > 0, True, False)
        mnuPerDoc.Items("tsmiEliminar").Enabled = IIf(griPersonaDocumento.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(sender As System.Object, e As System.EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Exportar()
    End Sub

    Private Sub tsmiImportar_Click(sender As System.Object, e As System.EventArgs) Handles tsmiImportar.Click
        Try
            _acl = gAccionSistema.IMPORTAR.ToString
            If VerificaAccion(_acl) Then
                _opePD = "IMPORTAR"
                If cboTipoDocBus.SelectedIndex > -1 Then
                    MostrarTabs(2, ficPersonaDocumento)
                    ficPersonaDocumento.Tabs(0).Enabled = False
                    ficPersonaDocumento.Tabs(1).Enabled = False
                    ficPersonaDocumento.Tabs(2).Enabled = True
                    verTrabajador.Checked = False
                    btnValidar.Enabled = False
                    verTrabajador.Enabled = False
                    txtMensaje.Text = String.Empty
                    txtMensaje.Text = cboTipoDocBus.Text
                    Select Case cboTipoDocBus.Text
                        Case "DOCUMENTO NACIONAL DE IDENTIDAD" : txtMensaje.Text = txtMensaje.Text & " Condiserar 8 Digitos para numero"
                            lonDoc = 8
                        Case "LICENCIA DE CONDUCIR" : txtMensaje.Text = txtMensaje.Text & " Condiserar 9 Digitos para numero"
                            lonDoc = 9
                        Case "CERTIFICADO DE CAPACITACION MTC"
                        Case Else
                            lonDoc = 0
                    End Select
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    CargarImportar(New List(Of e_PersonaDocumento))
                Else
                    mensajeEmergente.Problema("Seleccione un Tipo De Documento para Importar Datos.", True)
                    cboTipoDocBus.Focus()
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Try
            Dim ofd_Imagen As New OpenFileDialog
            With ofd_Imagen
                .Filter = "Imágenes JPG (*.jpg)|*.jpg"
                .FilterIndex = 1
                .Title = "Abrir imagen ..."
            End With
            If ofd_Imagen.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim rutasImagenes As String = ""
                
                If Directory.Exists(rutacomprobacion) = False Then
                    Directory.CreateDirectory(rutacomprobacion)
                End If
                Dim RutaImagen As String = oePersonaDocumento.NumeroDocumento & "_" & Date.Now.Ticks & ".jpg"
                FileCopy(ofd_Imagen.FileName, rutacomprobacion & "\" & RutaImagen)
                
                If oePersonaDocumento.RutaImagen <> "" Then
                    oePersonaDocumento.RutaImagen = oePersonaDocumento.RutaImagen & "*" & RutaImagen
                Else
                    oePersonaDocumento.RutaImagen = RutaImagen
                End If

                CargarImagenes(oePersonaDocumento.RutaImagen)

                'listaImagenes.Add(RutaImagen)
                ''griImagenes.DataSource = listaImagenes
                ''griImagenes.DataBind()

                'With griImagenes
                '    .ResetDisplayLayout()
                '    .DataSource = listaImagenes
                '    '.DisplayLayout.Bands(0).Columns.Add("Estado", "Estado")
                '    .DisplayLayout.Bands(0).Columns(0).DataType = System.Type.GetType("System.String")
                '    .DisplayLayout.Bands(0).Columns(0).Width = 180
                '    ConfiguraGrilla(griImagenes, 1)
                'End With

                'griImagenes.DataBind()
                
            End If
            ofd_Imagen.Dispose()
            ofd_Imagen = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub LlenarListaImagenes(ByVal cadenaRutas As String)
    '    Try
    '        Dim objI As e_ImagenesDocumentos
    '        If cadenaRutas <> "" Then
    '            Dim cant = cadenaRutas.Split("*").Length
    '            For i As Integer = 0 To cant - 1
    '                objI = New e_ImagenesDocumentos
    '                objI.RutaImagen = cadenaRutas.Split("*")(i)
    '                listaImagenes.Add(objI)
    '            Next
    '            griImagenes.DataSource = listaImagenes
    '            griImagenes.DataBind()
    '            griImagenes.UpdateData()
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Confirmacion(ex.Message, True)
    '    End Try
    'End Sub

    Private Sub griImagenes_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griImagenes.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
            If MessageBox.Show("¿Desea eliminar imagen?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                'griImagenes.ActiveRow
                'griImagenes.Rows
                oePersonaDocumento.RutaImagen = oePersonaDocumento.RutaImagen.Replace(griImagenes.ActiveRow.Cells("NombreImagen").Value.ToString.Trim & "*", "")
                oePersonaDocumento.RutaImagen = oePersonaDocumento.RutaImagen.Replace("*" & griImagenes.ActiveRow.Cells("NombreImagen").Value.ToString.Trim, "")
                oePersonaDocumento.RutaImagen = oePersonaDocumento.RutaImagen.Replace(griImagenes.ActiveRow.Cells("NombreImagen").Value.ToString.Trim, "")
                'oePersonaDocumento.RutaImagen = oePersonaDocumento.RutaImagen.Replace("**", "")
                CargarImagenes(oePersonaDocumento.RutaImagen)

                'listaImagenes.Remove(griImagenes.ActiveRow.Cells(0).Value)
                'oePersonaDocumento.RutaImagen = ""
                'For Each i In listaImagenes
                '    If oePersonaDocumento.RutaImagen <> "" Then
                '        oePersonaDocumento.RutaImagen = oePersonaDocumento.RutaImagen & "*" & i
                '    Else
                '        oePersonaDocumento.RutaImagen = i
                '    End If
                'Next
                'griImagenes.DataSource = listaImagenes
                'griImagenes.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griImagenes_DoubleClickRow222(sender As Object, e As DoubleClickRowEventArgs)
        Try
            If griImagenes.Selected.Rows.Count <> 1 Then mensajeEmergente.Confirmacion("Debe seleccionar una imagen", True)
            If griImagenes.ActiveRow.Cells(0).Value = "" Then mensajeEmergente.Confirmacion("Registro no tiene imagen", True)
            Dim proceso As Process = New Process
            'Dim rutaImagen As String = IIf(griImagenes.ActiveRow.Cells(0).Value.ToString.Contains("ControlFlota"), "\\" & IpServidor, "") & griImagenes.ActiveRow.Cells("RutaImagen").Value
            Dim rutaImagen As String = rutacomprobacion & "\" & griImagenes.ActiveRow.Cells(0).Value
            proceso.StartInfo.FileName = "rundll32.exe"
            proceso.StartInfo.Arguments = "C:\WINDOWS\system32\shimgvw.dll,ImageView_Fullscreen " & rutaImagen
            'proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            proceso.StartInfo.CreateNoWindow = True
            proceso.Start()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub griImagenes_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griImagenes.DoubleClickRow
        Try
            If griImagenes.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar una imagen")
            If griImagenes.ActiveRow.Cells(0).Value = "" Then Throw New Exception("Registro no tiene imagen")
            Dim proceso As Process = New Process
            'Dim rutaImagen As String = IIf(griImagenes.ActiveRow.Cells(0).Value.ToString.Contains("ControlFlota"), "\\" & IpServidor, "") & griImagenes.ActiveRow.Cells("RutaImagen").Value
            Dim rutaImagen As String = rutacomprobacion & "\" & griImagenes.ActiveRow.Cells(0).Value
            proceso.StartInfo.FileName = "rundll32.exe"
            proceso.StartInfo.Arguments = "C:\WINDOWS\system32\shimgvw.dll,ImageView_Fullscreen " & rutaImagen
            'proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            proceso.StartInfo.CreateNoWindow = True
            proceso.Start()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Function EstructuraImagen() As DataTable
        Dim dtStruc As New Data.DataTable
        With dtStruc
            .Columns.Add(New Data.DataColumn("NombreImagen", Type.GetType("System.String")))
        End With
        Return dtStruc
    End Function

    Private Sub llenarGridImagen()
        With griImagenes
            .ResetDisplayLayout()
            .DataSource = listaImagen
            .DisplayLayout.Bands(0).Columns("NombreImagen").Width = 230
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
        griImagenes.DataBind()
    End Sub

    Private Sub llenarObjeto()
        oePersonaDocumento.IdPersona = cboTrabajador.Value
        oePersonaDocumento.IdTipoDocumento = cboTipoDocumento.Value
        oePersonaDocumento.NumeroDocumento = txtNumero.Text
        oePersonaDocumento.Descripcion = txtDescripcion.Text
        oePersonaDocumento.FechaActividad = FecActividad.Value
        oePersonaDocumento.FechaVencimiento = fecVencimiento.Value
        oePersonaDocumento.FechaActividad = FecActividad.Value
    End Sub


End Class