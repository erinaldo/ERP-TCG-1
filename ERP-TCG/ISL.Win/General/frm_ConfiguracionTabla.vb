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

Public Class frm_ConfiguracionTabla
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ConfiguracionTabla = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ConfiguracionTabla()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeConfTabla As e_ConfiguracionTabla, olConfTabla As New l_ConfiguracionTabla, leConfTabla As List(Of e_ConfiguracionTabla)
    Private oeConfColumna As e_ConfiguracionColumna, olConfColumna As New l_ConfiguracionColumna, leConfColumna As List(Of e_ConfiguracionColumna)
    Private oeConfDato As e_ConfiguracionDato, olConfDato As New l_ConfiguracionDato, leConfDato As List(Of e_ConfiguracionDato)
    Private leCDatoImp As List(Of e_ConfiguracionDato), leTDDatoAux As List(Of e_ConfiguracionDato)
    Private ls_CodigoCol As String = "", ls_TipoOperaDato As String = ""
    Private lb_Load As Boolean, lb_Actualiza As Boolean
    Private ln_NroFila As Integer

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            mt_Listar()
            If griConfiguracionTabla.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeConfTabla = New e_ConfiguracionTabla
        oeConfTabla.TipoOperacion = "I"
        oeConfTabla.Activo = True
        mt_Inicializa()
        txtCodigo.Text = fc_ObtenerCodigo()
        ls_CodigoCol = fc_ObtenerCodCol()
        MostrarTabs(1, ficConfiguracionTabla)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        txtCodigo.Focus()
    End Sub

    Public Overrides Sub Editar()
        Try
            mt_Inicializa()
            mt_Mostrar()
            oeConfTabla.TipoOperacion = "A"
            MostrarTabs(1, ficConfiguracionTabla)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If ficTDDato.SelectedTab.Index = 1 Then Throw New Exception("No ha terminado de ingresar informacion en la ficha: Datos")
            If ficConfColumnas.SelectedTab.Index = 1 Then Throw New Exception("No ha terminado de ingresar informacion en la ficha: Columnas")
            mt_RecolectaDatos()
            If oeConfTabla.TipoOperacion = "I" Then
                oeConfTabla.UsuarioCreacion = gUsuarioSGI.Id
            Else
                oeConfTabla.UsuarioModifica = gUsuarioSGI.Id
            End If
            oeConfTabla.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olConfTabla.Guardar(oeConfTabla) Then
                MessageBox.Show("Se registro correctamente la información", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarTabs(0, ficConfiguracionTabla)
                Consultar(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, ficConfiguracionTabla)
                Consultar(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Overrides Sub Eliminar()

    End Sub

    Public Overrides Sub Exportar()

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ConfiguracionTabla_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficConfiguracionTabla.SelectedTab.Index
            Case 0
                If griConfiguracionTabla.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_ConfiguracionTabla_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConfiguracionTabla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_CargarCombo()
            txtNombre.CharacterCasing = CharacterCasing.Normal
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            numOrden.MinValue = 1
            lb_Load = True
            mt_CargarConfTabla(New List(Of e_configuraciontabla))
            mt_CargarConfColumna(New List(Of e_configuracioncolumna))
            mt_CargarFilaDato(New List(Of e_configuraciondato))
            lb_Load = False
            MostrarTabs(0, ficConfiguracionTabla)
            mt_MostrarSubBoton("cc") : mt_MostrarSubBoton("cd")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub griConfiguracionTabla_DoubleClick(sender As Object, e As EventArgs) Handles griConfiguracionTabla.DoubleClick
        If griConfiguracionTabla.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub mnuConfColumnas_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles mnuConfColumnas.ToolClick
        Try
            Dim ls_pre As String, ln_nro As Integer = 0
            Select Case e.Tool.Key
                Case "ccAgregar"
                    mt_ControlSubBoton("cc", 0, 0, 1, 1, 0, 0, 0)
                    ficConfColumnas.SelectedTab = ficConfColumnas.Tabs(1)
                    ficConfColumnas.Tabs(0).Enabled = False : ficConfColumnas.Tabs(1).Enabled = True
                    mt_InicializaCol()
                    If ls_CodigoCol <> "" Then
                        oeConfColumna = New e_configuracioncolumna
                        oeConfColumna.Equivale = 2
                        oeConfColumna.Codigo = ls_CodigoCol
                        If leConfColumna.Contains(oeConfColumna) Then
                            ls_pre = ls_CodigoCol.Substring(0, 3)
                            ln_nro = CInt(ls_CodigoCol.Substring(3, ls_CodigoCol.Length - 3))
                            ln_nro = ln_nro + 1
                            ls_CodigoCol = ls_pre & FormatoDocumento(ln_nro.ToString, ls_CodigoCol.Length - 3)
                        End If
                        txtCodigoCC.Text = ls_CodigoCol
                    End If
                    oeConfColumna = New e_configuracioncolumna
                    oeConfColumna.TipoOperacion = "I" : oeConfColumna.Activo = True : oeConfColumna.Usuariocreacion = gUsuarioSGI.Id
                Case "ccModificar"
                    mt_EditarColumnas()
                Case "ccGrabar"
                    If fc_Validar() Then
                        mt_RecogeDatosCol()
                        If oeConfColumna.TipoOperacion = "I" Then
                            oeConfColumna.Equivale = 2
                            If leConfColumna.Contains(oeConfColumna) Then
                                Dim oeCCol As New e_configuracioncolumna
                                oeCCol = leConfColumna.Item(leConfColumna.IndexOf(oeConfColumna))
                                If oeCCol.Activo = True Then
                                    Throw New Exception("Ya se Registro la Columna: " & oeCCol.Nombre & " en la posicion: ")
                                Else
                                    oeCCol.Activo = True : oeCCol.TipoOperacion = "A"
                                End If
                            Else
                                leConfColumna.Add(oeConfColumna)
                            End If
                        Else
                            If oeConfColumna.Id.Trim.Length > 0 Then
                                oeConfColumna.TipoOperacion = "A" : oeConfColumna.UsuarioModifica = gUsuarioSGI.Id
                            Else
                                oeConfColumna.TipoOperacion = "I" : oeConfColumna.Usuariocreacion = gUsuarioSGI.Id
                            End If
                        End If
                        ficConfColumnas.SelectedTab = ficConfColumnas.Tabs(0)
                        ficConfColumnas.Tabs(0).Enabled = True : ficConfColumnas.Tabs(1).Enabled = False
                        mt_CargarConfColumna(leConfColumna)
                        griConfColumna.DataBind()
                        lb_Actualiza = True
                        mt_MostrarSubBoton("cc")
                    End If
                Case "ccCancelar"
                    If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        ficConfColumnas.SelectedTab = ficConfColumnas.Tabs(0)
                        ficConfColumnas.Tabs(0).Enabled = True : ficConfColumnas.Tabs(1).Enabled = False
                        mt_MostrarSubBoton("cc")
                    End If
                Case "ccQuitar"
                    If griConfColumna.Selected.Rows.Count > 0 Then
                        oeConfColumna = New e_configuracioncolumna
                        oeConfColumna.Equivale = 2 : oeConfColumna.Codigo = griConfColumna.ActiveRow.Cells("Codigo").Value
                        If leConfColumna.Contains(oeConfColumna) Then
                            oeConfColumna = leConfColumna.Item(leConfColumna.IndexOf(oeConfColumna))
                            If oeConfColumna.IndClave = 1 Then Throw New Exception("No se puede quitar la Columna: " & oeConfColumna.Nombre & " por que es Clave Primaria.")
                            If oeConfColumna.Id <> "" Then
                                oeConfColumna.TipoOperacion = "E" : oeConfColumna.Activo = 0
                            Else
                                leConfColumna.Remove(oeConfColumna)
                            End If
                        End If
                        mt_CargarConfColumna(leConfColumna)
                        griConfColumna.DataBind()
                        mt_MostrarSubBoton("cc")
                    Else
                        Throw New Exception("¡Seleccione un Registro!")
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub utmTDDato_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles utmTDDato.ToolClick
        Try
            Select Case e.Tool.Key
                Case "cdAgregar"
                    mt_ControlSubBoton("cd", 0, 0, 1, 1, 0, 0, 0)
                    ficTDDato.SelectedTab = ficTDDato.Tabs(1)
                    ficTDDato.Tabs(0).Enabled = False : ficTDDato.Tabs(1).Enabled = True
                    mt_InicializaDato()
                    If leConfDato.Count > 0 Then ln_NroFila = leConfDato.Max(Function(it) it.NroFila)
                    ln_NroFila = ln_NroFila + 1
                    ls_TipoOperaDato = "I"
                Case "cdModificar"
                    mt_EditarDatos()
                Case "cdGrabar"
                    If fc_ValidarDato() Then
                        If ls_TipoOperaDato = "I" Then
                            For Each oeAux In leTDDatoAux
                                oeConfDato = New e_configuraciondato
                                oeConfDato.NroFila = ln_NroFila : oeConfDato.TipoOperacion = ls_TipoOperaDato
                                oeConfDato.Activo = True : oeConfDato.Usuariocreacion = gUsuarioSGI.Id
                                oeConfDato.Id = String.Empty
                                oeConfDato.IdColumna = oeAux.IdColumna
                                oeConfDato.Columna = oeAux.Columna
                                oeConfDato.Descripcion = oeAux.Descripcion
                                leConfDato.Add(oeConfDato)
                            Next
                            mt_CargarConfDatos(leConfDato)
                        Else
                            For Each oeAux In leTDDatoAux
                                oeConfDato = New e_configuraciondato
                                oeConfDato.TipoBusca = 2
                                oeConfDato.NroFila = ln_NroFila : oeConfDato.IdColumna = oeAux.IdColumna
                                If leConfDato.Contains(oeConfDato) Then
                                    oeConfDato = leConfDato.Item(leConfDato.IndexOf(oeConfDato))
                                    oeConfDato.NroFila = oeAux.NroFila
                                    oeConfDato.Id = oeAux.Id
                                    oeConfDato.IdColumna = oeAux.IdColumna
                                    oeConfDato.Columna = oeAux.Columna
                                    oeConfDato.Clave = oeAux.Clave
                                    oeConfDato.Descripcion = oeAux.Descripcion
                                    If oeConfDato.Id.Trim.Length > 0 Then
                                        oeConfDato.TipoOperacion = "A" : oeConfDato.UsuarioModifica = gUsuarioSGI.Id
                                    Else
                                        oeConfDato.TipoOperacion = "I" : oeConfDato.Usuariocreacion = gUsuarioSGI.Id
                                    End If
                                Else
                                    oeConfDato.TipoOperacion = "I"
                                    oeConfDato.Activo = True : oeConfDato.Usuariocreacion = gUsuarioSGI.Id
                                    oeConfDato.Id = String.Empty
                                    oeConfDato.IdColumna = oeAux.IdColumna
                                    oeConfDato.Columna = oeAux.Columna
                                    oeConfDato.Descripcion = oeAux.Descripcion
                                    leConfDato.Add(oeConfDato)
                                End If
                            Next
                            mt_CargarConfDatos(leConfDato)
                        End If
                        ficTDDato.SelectedTab = ficTDDato.Tabs(0)
                        ficTDDato.Tabs(0).Enabled = True : ficTDDato.Tabs(1).Enabled = False
                        mt_CargarConfDatos(leConfDato)
                        griConfDatos.DataBind()
                        mt_MostrarSubBoton("cd")
                    End If
                Case "cdCancelar"
                    If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        ficTDDato.SelectedTab = ficTDDato.Tabs(0)
                        ficTDDato.Tabs(0).Enabled = True : ficTDDato.Tabs(1).Enabled = False
                        mt_MostrarSubBoton("cd")
                    End If
                Case "cdQuitar"
                    If griConfDatos.Selected.Rows.Count > 0 Then
                        Dim ln_NFila = griConfDatos.ActiveRow.Cells("NroFila").Value
                        If ln_NFila > 0 Then
                            For Each oeCD In leConfDato.Where(Function(it) it.Activo = True And it.NroFila = ln_NFila).ToList
                                If oeCD.Id.Trim.Length > 0 Then
                                    oeCD.TipoOperacion = "E" : oeCD.Activo = False
                                Else
                                    oeCD.TipoBusca = 2
                                    leConfDato.Remove(oeCD)
                                End If
                            Next
                        End If
                        mt_CargarConfDatos(leConfDato)
                        griConfDatos.DataBind()
                        mt_MostrarSubBoton("cd")
                    Else
                        Throw New Exception("¡Seleccione un Registro!")
                    End If
                Case "cdGenerar"
                    Dim dsGri As Data.DataTable = fc_CrearDT()
                    Dim _rwGri As Data.DataRow
                    _rwGri = dsGri.NewRow
                    dsGri.Rows.Add(_rwGri)
                    griImportar.DataSource = dsGri
                    Exportar_Excel(griImportar, txtNombre.Text.Trim)
                Case "cdImportar"
                    If Not chkTipo.Checked Then Throw New Exception("Solo se puede importar datos de tablas externas")
                    If griConfDatos.Rows.Count > 0 Then Throw New Exception("Elimine todos los registros antes de importar")
                    Dim PathFilePTRA As String = ""
                    Dim _leEst As New List(Of e_configuracioncolumna)
                    Dim _pos As Integer = 0
                    OpenFileDialog1 = gfc_CargaDatosOpenFileDialog()
                    If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                        PathFilePTRA = OpenFileDialog1.FileName
                        Dim objXls As Excel.Application
                        Dim objWorkbook As Excel.Workbook
                        Dim objWorkSheet As Excel.Worksheet
                        Dim ObjExcel() As Object = Nothing
                        Dim men As String = ""
                        objXls = CreateObject("Excel.Application") : objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                        objXls.Visible = False : objWorkSheet = objXls.Worksheets(1)
                        leCDatoImp = New List(Of e_configuraciondato)
                        For ln_Fila As Integer = 1 To 100000
                            If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                                _pos = 0
                                _leEst = leConfColumna.Where(Function(it) it.Activo = True).ToList.OrderBy(Function(it) it.NroOrden).ToList
                                For Each _oeCC In _leEst
                                    _pos = _pos + 1
                                    oeConfDato = New e_configuraciondato
                                    oeConfDato.TipoOperacion = "I" : oeConfDato.Id = String.Empty : oeConfDato.Activo = True
                                    oeConfDato.Usuariocreacion = gUsuarioSGI.Id : oeConfDato.IdColumna = _oeCC.Id : oeConfDato.NroFila = ln_Fila
                                    oeConfDato.Descripcion = objWorkSheet.Cells(ln_Fila + 1, _pos).Value : oeConfDato.Clave = _oeCC.IndClave
                                    leCDatoImp.Add(oeConfDato)
                                Next
                            Else
                                Exit For
                            End If
                        Next
                        If leCDatoImp.Count > 0 Then leConfDato.AddRange(leCDatoImp)
                        mt_CargarConfDatos(leConfDato)
                        griConfDatos.DataBind()
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
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub cboTipoDato_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDato.ValueChanged
        If cboTipoDato.SelectedIndex > -1 Then
            Select Case cboTipoDato.Text
                Case "Bit", "DateTime", "Int", "Decimal"
                    ndLongitud.Enabled = False
                Case Else
                    ndLongitud.Enabled = True
            End Select
        End If

    End Sub

    Private Sub griConfColumna_DoubleClick(sender As Object, e As EventArgs) Handles griConfColumna.DoubleClick
        If griConfColumna.Selected.Rows.Count > 0 Then mt_EditarColumnas()
    End Sub

    Private Sub griTDDato_CellChange(sender As Object, e As CellEventArgs) Handles griTDDato.CellChange
        griTDDato.UpdateData()
    End Sub

    Private Sub griTDDato_KeyDown(sender As Object, e As KeyEventArgs) Handles griTDDato.KeyDown
        Try
            With griTDDato
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub griConfDatos_DoubleClick(sender As Object, e As EventArgs) Handles griConfDatos.DoubleClick
        If griConfDatos.Selected.Rows.Count > 0 Then mt_EditarDatos()
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_CargarCombo()
        Try
            cboTipoDato.Items.Clear()
            cboTipoDato.Items.Add("Bit")
            cboTipoDato.Items.Add("Char")
            cboTipoDato.Items.Add("DateTime")
            cboTipoDato.Items.Add("Decimal")
            cboTipoDato.Items.Add("Int")
            cboTipoDato.Items.Add("Varchar")
            cboTipoDato.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Listar()
        Try
            oeConfTabla = New e_configuraciontabla : leConfTabla = New List(Of e_configuraciontabla)
            oeConfTabla.TipoOperacion = "" : oeConfTabla.Activo = True
            leConfTabla = olConfTabla.Listar(oeConfTabla)
            mt_CargarConfTabla(leConfTabla)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarConfTabla(leConTab As List(Of e_ConfiguracionTabla))
        Try
            With griConfiguracionTabla
                If lb_Load Then .ResetDisplayLayout()
                .DataSource = leConTab.OrderBy(Function(it) it.Codigo).ToList
                .Text = "Tablas del SGI"
                If lb_Load Then
                    ConfiguraGrilla(griConfiguracionTabla, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna(griConfiguracionTabla, True, "Id", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")
                    ExcluirColumna(griConfiguracionTabla, "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")
                    FormatoColumna(griConfiguracionTabla, "", ColumnStyle.CheckBox, HAlign.Center, "Maestra", "Limpiar", "Insertar", "Actualizar", "IndTipo")
                    .DisplayLayout.Bands(0).Columns("Esquema").Width = 70
                    .DisplayLayout.Bands(0).Columns("Nombre").Width = 200
                    .DisplayLayout.Bands(0).Columns("Descripcion").Width = 350
                    .DisplayLayout.Bands(0).Columns("IndTipo").Header.Caption = "Externa"
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarConfColumna(leConCol As List(Of e_ConfiguracionColumna))
        Try
            With griConfColumna
                If lb_Load Then .ResetDisplayLayout()
                Dim _leActivo = leConCol.Where(Function(it) it.Activo = True).ToList.OrderBy(Function(it) it.NroOrden).ToList
                .DataSource = _leActivo
                .Text = "Columnas de la Tabla: " & txtNombre.Text.ToString
                If lb_Load Then
                    ConfiguraGrilla(griConfColumna, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna(griConfColumna, True, "Id", "IdTabla", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")
                    ExcluirColumna(griConfColumna, "IdTabla", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")
                    FormatoColumna(griConfColumna, "", ColumnStyle.CheckBox, HAlign.Center, "Obligatorio", "IndClave")
                    .DisplayLayout.Bands(0).Columns("IndClave").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("NroOrden").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("TipoDato").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Longitud").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("ValorDefecto").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Obligatorio").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("Descripcion").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("Codigo").Width = 85
                    .DisplayLayout.Bands(0).Columns("Nombre").Width = 150
                    .DisplayLayout.Bands(0).Columns("Longitud").Width = 55
                    .DisplayLayout.Bands(0).Columns("TipoDato").Width = 80
                    .DisplayLayout.Bands(0).Columns("ValorDefecto").Width = 80
                    .DisplayLayout.Bands(0).Columns("Descripcion").Width = 250
                    .DisplayLayout.Bands(0).Columns("IndClave").Header.Caption = "PK"
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarConfDatos(leCDatos As List(Of e_ConfiguracionDato))
        Try
            Dim dsCDatos As Data.DataTable = fc_CrearDT()
            Dim _nrofila As Integer = 0
            Dim _rwCD As Data.DataRow
            Dim _leAuxCD As New List(Of e_configuraciondato), _leCCCD As New List(Of e_configuraciondato)
            Dim _leAuxCC = leConfColumna.Where(Function(it) it.Activo = True).ToList
            Dim _leDatosOrdenado = leConfDato.Where(Function(it) it.Activo = True).OrderBy(Function(it) it.NroFila).ToList
            For Each _oeCD In _leDatosOrdenado
                If _nrofila <> _oeCD.NroFila Then
                    _nrofila = _oeCD.NroFila
                    _rwCD = dsCDatos.NewRow
                    _leAuxCD = New List(Of e_configuraciondato)
                    _leAuxCD = _leDatosOrdenado.Where(Function(it) it.NroFila = _nrofila).ToList
                    _rwCD("NroFila") = _nrofila
                    For Each _oeCC In _leAuxCC
                        _leCCCD = _leAuxCD.Where(Function(it) it.IdColumna = _oeCC.Id).ToList
                        If _leCCCD.Count > 0 Then
                            _rwCD(_oeCC.Codigo) = _leCCCD(0).Descripcion
                        Else
                            _rwCD(_oeCC.Codigo) = _oeCC.ValorDefecto
                        End If
                    Next
                    dsCDatos.Rows.Add(_rwCD)
                End If
            Next
            With griConfDatos
                .ResetDisplayLayout()
                .DataSource = dsCDatos
                .Text = "Datos de la Tabla: " & txtNombre.Text.Trim
                ConfiguraGrilla(griConfDatos, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna(griConfDatos, True, "NroFila")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarFilaDato(leTDDato As List(Of e_ConfiguracionDato))
        Try
            With griTDDato
                If lb_Load Then .ResetDisplayLayout()
                .DataSource = leTDDato
                .Text = ""
                If lb_Load Then
                    ConfiguraGrilla(griTDDato, "Tahoma", False, UIElementBorderStyle.Dotted, "Descripcion")
                    OcultarColumna(griTDDato, True, "Id", "IdColumna", "NroFila", "TipoReferencia", "IdReferencia", "FechaCreacion", "UsuarioCreacion", _
                                      "FechaModifica", "UsuarioModifica", "Activo")
                    ExcluirColumna(griTDDato, "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")
                    FormatoColumna(griTDDato, "", ColumnStyle.CheckBox, HAlign.Center, "Clave")
                    ColorFondoColumna2(griTDDato, Color.LightYellow, Color.Black, "Descripcion")
                    .DisplayLayout.Bands(0).Columns("Clave").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Columna").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Descripcion").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Descripcion").Width = 300
                    .DisplayLayout.Bands(0).Columns("Columna").CellAppearance.FontData.Bold = DefaultableBoolean.True
                    .DisplayLayout.Bands(0).Columns("Descripcion").CharacterCasing = CharacterCasing.Upper
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Inicializa()
        txtCodigo.Text = String.Empty
        txtEsquema.Text = String.Empty
        numOrden.Value = 1
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        chkMaestro.Checked = False
        chkLimpiar.Checked = False
        chkInsertar.Checked = False
        chkActualizar.Checked = False
        chkTipo.Checked = False
        txtCodigo.ReadOnly = True
        leConfColumna = New List(Of e_configuracioncolumna)
        mt_CargarConfColumna(leConfColumna)
        leConfDato = New List(Of e_configuraciondato)
        mt_CargarConfDatos(leConfDato)
        ficComplemento.SelectedTab = ficComplemento.Tabs(0)
        ficConfColumnas.SelectedTab = ficConfColumnas.Tabs(0)
        ficConfColumnas.Tabs(0).Enabled = True : ficConfColumnas.Tabs(1).Enabled = False
        ficTDDato.SelectedTab = ficTDDato.Tabs(0)
        ficTDDato.Tabs(0).Enabled = True : ficTDDato.Tabs(1).Enabled = False
        mt_MostrarSubBoton("cc") : mt_MostrarSubBoton("cd")
        ln_NroFila = 0 : ls_TipoOperaDato = String.Empty
        lb_Actualiza = False
    End Sub

    Private Sub mt_Mostrar()
        Try
            If griConfiguracionTabla.Selected.Rows.Count = 0 Then Throw New Exception("!Seleccione un Registro para Editar!")
            oeConfTabla = New e_configuraciontabla
            oeConfTabla.CargaCompleta = True
            oeConfTabla.Id = griConfiguracionTabla.ActiveRow.Cells("Id").Value
            oeConfTabla = olConfTabla.Obtener(oeConfTabla)
            With oeConfTabla
                txtCodigo.Text = .Codigo
                txtEsquema.Text = .Esquema
                numOrden.Value = .NroOrden
                txtNombre.Text = .Nombre
                txtDescripcion.Text = .Descripcion
                chkMaestro.Checked = IIf(.Maestra = 0, False, True)
                chkLimpiar.Checked = IIf(.Limpiar = 0, False, True)
                chkInsertar.Checked = IIf(.Insertar = 0, False, True)
                chkActualizar.Checked = IIf(.Actualizar = 0, False, True)
                chkTipo.Checked = IIf(.IndTipo = 0, False, True)
                leConfColumna = .leColumna
                mt_CargarConfColumna(leConfColumna)
                mt_MostrarSubBoton("cc")
                ls_CodigoCol = fc_ObtenerCodCol()
                leConfDato = .leDato
                mt_CargarConfDatos(leConfDato)
                mt_MostrarSubBoton("cd")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_RecolectaDatos()
        With oeConfTabla
            .Codigo = txtCodigo.Text
            .Esquema = txtEsquema.Text
            .NroOrden = numOrden.Value
            .Nombre = txtNombre.Text
            .Descripcion = txtDescripcion.Text
            .Maestra = IIf(chkMaestro.Checked, 1, 0)
            .Limpiar = IIf(chkLimpiar.Checked, 1, 0)
            .Insertar = IIf(chkInsertar.Checked, 1, 0)
            .Maestra = IIf(chkActualizar.Checked, 1, 0)
            .IndTipo = IIf(chkTipo.Checked, 1, 0)
            .leColumna = leConfColumna
            Dim _leColPK = leConfColumna.Where(Function(it) it.Activo = True And it.IndClave = 1).ToList
            If _leColPK.Count > 0 Then
                Dim ls_IdColPK = _leColPK(0).Id
                For Each oeTDDatoPK In leConfDato.Where(Function(it) it.Activo = True And it.IdColumna = ls_IdColPK).ToList
                    Dim ln_NFila = oeTDDatoPK.NroFila
                    If oeTDDatoPK.IdReferencia.Trim.Length > 0 Then
                        oeTDDatoPK.IdReferencia = String.Empty
                        oeTDDatoPK.TipoReferencia = String.Empty
                        If oeTDDatoPK.Id.Trim.Length > 0 Then oeTDDatoPK.TipoOperacion = "A"
                    End If
                    For Each oeTDatoAtr In leConfDato.Where(Function(it) it.Activo = True And it.NroFila = ln_NFila And it.IdColumna <> ls_IdColPK).ToList
                        If oeTDatoAtr.TipoReferencia.Trim <> oeTDDatoPK.Descripcion.Trim Then
                            oeTDatoAtr.TipoReferencia = oeTDDatoPK.Descripcion.Trim
                            oeTDatoAtr.IdReferencia = oeTDDatoPK.Id
                            If oeTDatoAtr.Id.Trim.Length > 0 Then oeTDatoAtr.TipoOperacion = "A"
                        End If
                    Next
                Next
            End If
            .leDato = leConfDato
        End With
    End Sub

    Private Sub mt_ControlSubBoton(_pre As String, _Agregar As Boolean, _Modificar As Boolean, _Grabar As Boolean, _Cancelar As Boolean, _Quitar As Boolean, _Generar As Boolean, _Importar As Boolean)
        Select Case _pre
            Case "cc"
                With mnuConfColumnas.Tools
                    .Item(_pre & "Agregar").SharedProps.Enabled = _Agregar
                    .Item(_pre & "Modificar").SharedProps.Enabled = _Modificar
                    .Item(_pre & "Grabar").SharedProps.Enabled = _Grabar
                    .Item(_pre & "Cancelar").SharedProps.Enabled = _Cancelar
                    .Item(_pre & "Quitar").SharedProps.Enabled = _Quitar
                End With
            Case "cd"
                With utmTDDato.Tools
                    .Item(_pre & "Agregar").SharedProps.Enabled = _Agregar
                    .Item(_pre & "Modificar").SharedProps.Enabled = _Modificar
                    .Item(_pre & "Grabar").SharedProps.Enabled = _Grabar
                    .Item(_pre & "Cancelar").SharedProps.Enabled = _Cancelar
                    .Item(_pre & "Quitar").SharedProps.Enabled = _Quitar
                    .Item(_pre & "Generar").SharedProps.Enabled = _Generar
                    .Item(_pre & "Importar").SharedProps.Enabled = _Importar
                End With
        End Select
    End Sub

    Private Sub mt_MostrarSubBoton(_pre As String)
        Dim cant As Integer = 0
        Select Case _pre
            Case "cc"
                cant = griConfColumna.Rows.Count
                If cant > 0 Then
                    mt_ControlSubBoton(_pre, 1, 1, 0, 0, 1, 0, 0)
                    If oeConfTabla.Id <> "" Then ficComplemento.Tabs(1).Enabled = True
                    If lb_Actualiza Then ficComplemento.Tabs(1).Enabled = False
                Else
                    mt_ControlSubBoton(_pre, 1, 0, 0, 0, 0, 0, 0)
                    ficComplemento.Tabs(1).Enabled = False
                End If
            Case "cd"
                cant = griConfDatos.Rows.Count
                If cant > 0 Then
                    mt_ControlSubBoton(_pre, 1, 1, 0, 0, 1, 0, 0)
                Else
                    mt_ControlSubBoton(_pre, 1, 0, 0, 0, 0, 1, 1)
                End If
        End Select
    End Sub

    Private Sub mt_InicializaCol()
        nroOrden.Value = griConfColumna.Rows.Count + 1
        txtCodigoCC.Text = String.Empty
        txtNombreCC.Text = String.Empty
        txtValorDef.Text = String.Empty
        txtDescripcionCC.Text = String.Empty
        ndLongitud.Value = 0
        cboTipoDato.SelectedIndex = -1
        txtCodigoCC.Enabled = False
        chkObligatorio.Checked = False
        chkClave.Checked = False
    End Sub

    Private Sub mt_RecogeDatosCol()
        oeConfColumna.Codigo = txtCodigoCC.Text
        oeConfColumna.NroOrden = nroOrden.Value
        oeConfColumna.Nombre = txtNombreCC.Text
        oeConfColumna.TipoDato = cboTipoDato.Text
        oeConfColumna.Longitud = ndLongitud.Value
        oeConfColumna.ValorDefecto = txtValorDef.Text
        oeConfColumna.Descripcion = txtDescripcionCC.Text
        oeConfColumna.Obligatorio = IIf(chkObligatorio.Checked, 1, 0)
        oeConfColumna.IndClave = IIf(chkClave.Checked, 1, 0)
    End Sub

    Private Sub mt_MostrarDatosCol(oeConCol As e_ConfiguracionColumna)
        With oeConCol
            nroOrden.Value = .NroOrden
            txtCodigoCC.Text = .Codigo
            txtNombreCC.Text = .Nombre
            cboTipoDato.Value = .TipoDato
            ndLongitud.Value = .Longitud
            txtValorDef.Text = .ValorDefecto
            txtDescripcionCC.Text = .Descripcion
            chkObligatorio.Checked = IIf(.Obligatorio = 1, True, False)
            chkClave.Checked = IIf(.IndClave = 1, True, False)
        End With
    End Sub

    Private Sub mt_EditarColumnas()
        If griConfColumna.Selected.Rows.Count > 0 Then
            mt_ControlSubBoton("cc", 0, 0, 1, 1, 0, 0, 0)
            ficConfColumnas.SelectedTab = ficConfColumnas.Tabs(1)
            ficConfColumnas.Tabs(0).Enabled = False : ficConfColumnas.Tabs(1).Enabled = True
            mt_InicializaCol()
            oeConfColumna = New e_ConfiguracionColumna
            oeConfColumna.Equivale = 2 : oeConfColumna.Codigo = griConfColumna.ActiveRow.Cells("Codigo").Value
            oeConfColumna = leConfColumna.Item(leConfColumna.IndexOf(oeConfColumna))
            oeConfColumna.TipoOperacion = "A" : oeConfColumna.UsuarioModifica = gUsuarioSGI.Id
            mt_MostrarDatosCol(oeConfColumna)
        Else
            Throw New Exception("¡Seleccione un Registro!")
        End If
    End Sub

    Private Sub mt_InicializaDato()
        leTDDatoAux = New List(Of e_configuraciondato)
        For Each oeTDC In leConfColumna.Where(Function(it) it.Activo = True).ToList.OrderBy(Function(it) it.NroOrden).ToList
            oeConfDato = New e_configuraciondato
            oeConfDato.Clave = oeTDC.IndClave
            oeConfDato.IdColumna = oeTDC.Id
            oeConfDato.Columna = oeTDC.Nombre
            oeConfDato.Descripcion = String.Empty
            leTDDatoAux.Add(oeConfDato)
        Next
        mt_CargarFilaDato(leTDDatoAux)
    End Sub

    Private Sub mt_EditarDatos()
        If griConfDatos.Selected.Rows.Count > 0 Then
            Dim _leTDAux As New List(Of e_configuraciondato)
            mt_ControlSubBoton("cd", 0, 0, 1, 1, 0, 0, 0)
            ficTDDato.SelectedTab = ficTDDato.Tabs(1)
            ficTDDato.Tabs(0).Enabled = False : ficTDDato.Tabs(1).Enabled = True
            mt_InicializaDato()
            ln_NroFila = griConfDatos.ActiveRow.Cells("NroFila").Value
            ls_TipoOperaDato = "A"
            _leTDAux = leConfDato.Where(Function(it) it.NroFila = ln_NroFila And it.Activo = 1).ToList
            For Each oeAux In leTDDatoAux
                oeConfDato = New e_configuraciondato
                oeConfDato.TipoBusca = 2
                oeConfDato.NroFila = ln_NroFila : oeConfDato.IdColumna = oeAux.IdColumna
                If leConfDato.Contains(oeConfDato) Then
                    oeConfDato = leConfDato.Item(leConfDato.IndexOf(oeConfDato))
                    oeAux.NroFila = oeConfDato.NroFila
                    oeAux.Id = oeConfDato.Id
                    oeAux.IdColumna = oeConfDato.IdColumna
                    oeAux.Columna = oeConfDato.Columna
                    oeAux.Clave = oeConfDato.Clave
                    oeAux.Descripcion = oeConfDato.Descripcion
                End If
            Next
            mt_CargarFilaDato(leTDDatoAux)
        Else
            Throw New Exception("¡Seleccione un Registro!")
        End If
    End Sub

#End Region

#Region "Funciones"

    Private Function fc_ObtenerCodigo() As String
        Try
            Dim _oeConTab As New e_configuraciontabla
            Dim ls_Cod As String = ""
            _oeConTab.TipoOperacion = "U"
            _oeConTab = olConfTabla.Obtener(_oeConTab)
            If _oeConTab IsNot Nothing AndAlso _oeConTab.Codigo <> "" Then
                ls_Cod = _oeConTab.Codigo
            End If
            Return ls_Cod
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_ObtenerCodCol() As String
        Try
            Dim _oeConCol As New e_configuracioncolumna
            Dim ls_Codigo As String = ""
            _oeConCol.TipoOperacion = "U"
            _oeConCol = olConfColumna.Obtener(_oeConCol)
            If _oeConCol IsNot Nothing AndAlso _oeConCol.Codigo <> "" Then
                ls_Codigo = _oeConCol.Codigo
            End If
            Return ls_Codigo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_Validar() As Boolean
        Dim leColAux As New List(Of e_configuracioncolumna)
        'With oeConfColumna
        If txtNombreCC.Text.Trim = "" Then Throw New Exception("Ingrese Nombre")
        If cboTipoDato.SelectedIndex = -1 Then Throw New Exception("Seleccione Tipo de Dato")
        leColAux = leConfColumna.Where(Function(it) it.Activo = True).ToList
        If leColAux.Count > 0 Then
            If chkClave.Checked Then
                Dim leColPK = leColAux.Where(Function(it) it.IndClave = 1 And it.Codigo <> txtCodigoCC.Text).ToList
                If leColPK.Count > 0 Then
                    Throw New Exception("La Tabla: " & txtNombre.Text.Trim & " ya tiene Clave Primaria: " & leColPK(0).Nombre)
                End If
            End If
        End If
        'End With
        Return True
    End Function

    Private Function fc_CrearDT() As System.Data.DataTable
        Dim dsCCol As New Data.DataTable
        Dim _td As String = ""
        With dsCCol
            .Columns.Add(New Data.DataColumn("NroFila", Type.GetType("System.Int32")))
            .Columns("NroFila").Caption = "NroFila"
            For Each oeCCol In leConfColumna.OrderBy(Function(it) it.NroOrden).ToList
                Select Case oeCCol.TipoDato
                    Case "Bit" : _td = "Boolean"
                    Case "Char" : _td = "String"
                    Case "DateTime" : _td = "DateTime"
                    Case "Decimal" : _td = "Decimal"
                    Case "Int" : _td = "Int32"
                    Case "Varchar" : _td = "String"
                End Select
                .Columns.Add(New Data.DataColumn(oeCCol.Codigo, Type.GetType("System." & _td)))
                .Columns(oeCCol.Codigo).Caption = oeCCol.Nombre
            Next
        End With
        Return dsCCol
    End Function

    Private Function fc_ValidarDato() As Boolean
        For Each oeAux In leTDDatoAux
            If oeAux.Descripcion.Trim.Length = 0 Then Throw New Exception("Ingrese " & oeAux.Columna & ": ")
        Next
        Return True
    End Function

#End Region

End Class