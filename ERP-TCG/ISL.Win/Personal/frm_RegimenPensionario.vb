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

Public Class frm_RegimenPensionario
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_RegimenPensionario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_RegimenPensionario()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeRegimenPensionario As New e_RegimenPensionario, olRegimenPensionario As New l_RegimenPensionario
    Private leRegimenPensionario As New List(Of e_RegimenPensionario), leHistorialRegPen As New List(Of e_RegimenPensionario)
    Private leDatosImportados As New List(Of e_RegimenPensionario)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            If griRegimenPensionario.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
        
    Public Overrides Sub Nuevo()
        oeRegimenPensionario = New e_RegimenPensionario
        oeRegimenPensionario.TipoOperacion = "I"
        oeRegimenPensionario.Activo = True
        oeRegimenPensionario.Vigente = True
        Inicializa()
        cboEmpresa.ReadOnly = False
        Habilita_Controles(False)
        btnActualiza.Enabled = False
        MostrarTabs(1, ficRegimenPensionario)
        ficRegimenPensionario.Tabs(0).Enabled = False
        ficRegimenPensionario.Tabs(1).Enabled = True
        ficRegimenPensionario.Tabs(2).Enabled = False
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializa()
            Mostrar()
            oeRegimenPensionario.TipoOperacion = "A"
            cboEmpresa.ReadOnly = True
            Habilita_Controles(True)
            btnActualiza.Enabled = True
            MostrarTabs(1, ficRegimenPensionario)
            ficRegimenPensionario.Tabs(0).Enabled = False
            ficRegimenPensionario.Tabs(1).Enabled = True
            ficRegimenPensionario.Tabs(2).Enabled = False
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficRegimenPensionario.SelectedTab.Index
                Case 1
                    oeRegimenPensionario.UsuarioCreacion = gUsuarioSGI.Id
                    oeRegimenPensionario.FechaActividad = fecActividad.Value
                    oeRegimenPensionario.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olRegimenPensionario.Guardar(oeRegimenPensionario)
                    mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                Case 2
                    Dim _leAux = leDatosImportados.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        olRegimenPensionario.GuardarMasivo(_leAux, gs_PrefijoIdSucursal)
                        mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)
                    Else
                        Throw New Exception("No hay datos para guardar")
                    End If
            End Select
            MostrarTabs(0, ficRegimenPensionario)
            ficRegimenPensionario.Tabs(0).Enabled = True
            ficRegimenPensionario.Tabs(1).Enabled = False
            ficRegimenPensionario.Tabs(2).Enabled = False
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Select Case ficRegimenPensionario.SelectedTab.Index
            Case 1
                If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    MostrarTabs(0, ficRegimenPensionario)
                    ficRegimenPensionario.Tabs(0).Enabled = True
                    ficRegimenPensionario.Tabs(1).Enabled = False
                    ficRegimenPensionario.Tabs(2).Enabled = False
                    Consultar(True)
                End If
            Case 2
                If MessageBox.Show("¿Desea Cancelar la Importación de Datos?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    MostrarTabs(0, ficRegimenPensionario)
                    ficRegimenPensionario.Tabs(0).Enabled = True
                    ficRegimenPensionario.Tabs(1).Enabled = False
                    ficRegimenPensionario.Tabs(2).Enabled = False
                    Consultar(True)
                End If
        End Select

    End Sub

    Public Overrides Sub Eliminar()

    End Sub

    Public Overrides Sub Exportar()
        Try
            If griRegimenPensionario.Rows.Count > 0 Then Exportar_Excel(griRegimenPensionario, "Pensiones")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_RegimenPensionario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficRegimenPensionario.SelectedTab.Index
            Case 0
                If griRegimenPensionario.Rows.Count > 0 Then
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

    Private Sub frm_RegimenPensionario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_RegimenPensionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            colorVigente.Color = Color.LightGreen
            colorNoVigente.Color = Color.Khaki
            CargarRegimenPensionario(New List(Of e_RegimenPensionario))
            CargarHistorial(New List(Of e_RegimenPensionario))
            colorRegistrado.Color = Color.LightGreen
            colorNoRegistrado.Color = Color.Gold
            MostrarTabs(0, ficRegimenPensionario)
            ficRegimenPensionario.Tabs(0).Enabled = True
            ficRegimenPensionario.Tabs(1).Enabled = False
            ficRegimenPensionario.Tabs(2).Enabled = False
            CargarCombo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEmpresa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmpresa.ValueChanged
        Try
            If cboEmpresa.SelectedIndex > -1 Then
                oeEmpresa = New e_Empresa
                oeEmpresa = cboEmpresa.Items(cboEmpresa.SelectedIndex).ListObject
                txtEmpresa.Text = oeEmpresa.Abreviatura
                oeRegimenPensionario.IdEmpresa = cboEmpresa.Value
            Else
                txtEmpresa.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ndObligatorio1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndObligatorio1.ValueChanged
        If Not IsDBNull(ndObligatorio1.Value) Then
            oeRegimenPensionario.PorcentajeObligatorio = ndObligatorio1.Value
        Else
            ndObligatorio1.Value = 0
        End If
    End Sub

    Private Sub ndObligatorio2_ValueChanged(sender As Object, e As EventArgs) Handles ndObligatorio2.ValueChanged
        If Not IsDBNull(ndObligatorio2.Value) Then
            oeRegimenPensionario.PorcentajeObligatorio2 = ndObligatorio2.Value
        Else
            ndObligatorio2.Value = 0
        End If
    End Sub

    Private Sub ndComision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndComision.ValueChanged
        If Not IsDBNull(ndComision.Value) Then
            oeRegimenPensionario.PorcentajeComision = ndComision.Value
        Else
            ndComision.Value = 0
        End If
    End Sub

    Private Sub ndSeguros_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndSeguros.ValueChanged
        If Not IsDBNull(ndSeguros.Value) Then
            oeRegimenPensionario.PorcentajeSeguros = ndSeguros.Value
        Else
            ndSeguros.Value = 0
        End If
    End Sub

    Private Sub fecActividad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecActividad.ValueChanged
        oeRegimenPensionario.FechaActividad = fecActividad.Value
    End Sub

    Private Sub griRegimenPensionario_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griRegimenPensionario.DoubleClick
        If griRegimenPensionario.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click
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
                        oeRegimenPensionario = New e_RegimenPensionario
                        oeEmpresa = New e_Empresa
                        oeEmpresa.TipoBusca = 2
                        oeEmpresa.Abreviatura = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leEmpresa.Contains(oeEmpresa) Then
                            oeEmpresa = leEmpresa.Item(leEmpresa.IndexOf(oeEmpresa))
                        End If
                        With oeRegimenPensionario
                            .Id = String.Empty
                            .IdEmpresa = oeEmpresa.Id
                            .Empresa = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .PorcentajeObligatorio = Math.Round((objWorkSheet.Cells(ln_Fila + 1, 3).Value) * 100, 2)
                            .PorcentajeComision = Math.Round((objWorkSheet.Cells(ln_Fila + 1, 4).Value) * 100, 2)
                            .PorcentajeSeguros = Math.Round((objWorkSheet.Cells(ln_Fila + 1, 5).Value) * 100, 2)
                            .PorcentajeComisionMixta = Math.Round((objWorkSheet.Cells(ln_Fila + 1, 6).Value) * 100, 2)
                            .PorcentajeSaldoMixta = Math.Round((objWorkSheet.Cells(ln_Fila + 1, 7).Value) * 100, 2)
                            .RenumeracionMaxima = Math.Round((objWorkSheet.Cells(ln_Fila + 1, 8).Value) * 100, 2)
                            .PorcentajeTotal = Math.Round(.PorcentajeObligatorio + .PorcentajeComision + .PorcentajeSeguros, 2)
                            .PorcentajeTotalMixta = Math.Round(.PorcentajeObligatorio + .PorcentajeComisionMixta + .PorcentajeSeguros, 2)
                            .FechaActividad = objWorkSheet.Cells(ln_Fila + 1, 9).Value
                        End With
                        oeRegimenPensionario.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leDatosImportados.Add(oeRegimenPensionario)
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
            ' Verifica si las Empresas entan registradas en el SGI
            CargarCombo()
            If leDatosImportados.Count > 0 Then

                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()

                For Each oeImp In leDatosImportados
                    oeImp.PrefijoID = gs_PrefijoIdSucursal '@0001
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
            For Each oeReg In leDatosImportados
                oeReg.PrefijoID = gs_PrefijoIdSucursal '@0001
                If oeReg.IdEmpresa <> "" Then
                    If Not leRegimenPensionario.Contains(oeReg) Then
                        oeReg.TipoOperacion = "I"
                        oeReg.Activo = True
                        oeReg.Vigente = True
                        oeReg.UsuarioCreacion = gUsuarioSGI.Id
                    Else
                        oeReg.Activo = False
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

    Private Sub verEmpresa_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles verEmpresa.CheckedChanged
        CargarImportar(leDatosImportados)
    End Sub

    Private Sub ndComisionMixta_ValueChanged(sender As System.Object, e As System.EventArgs) Handles ndComisionMixta.ValueChanged
        If Not IsDBNull(ndComisionMixta.Value) Then
            oeRegimenPensionario.PorcentajeComisionMixta = ndComisionMixta.Value
        Else
            ndComisionMixta.Value = 0
        End If
    End Sub

    Private Sub ndSaldoMixta_ValueChanged(sender As System.Object, e As System.EventArgs) Handles ndSaldoMixta.ValueChanged
        If Not IsDBNull(ndSaldoMixta.Value) Then
            oeRegimenPensionario.PorcentajeSaldoMixta = ndSaldoMixta.Value
        Else
            ndSaldoMixta.Value = 0
        End If
    End Sub

    Private Sub ndRenumeracionMax_ValueChanged(sender As Object, e As EventArgs) Handles ndRenumeracionMax.ValueChanged
        If Not IsDBNull(ndRenumeracionMax.Value) Then
            oeRegimenPensionario.RenumeracionMaxima = ndRenumeracionMax.Value
        Else
            ndRenumeracionMax.Value = 0
        End If
    End Sub

    Private Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click
        If MessageBox.Show("¿Desea Enviar este Registro al historial y Generar uno nuevo?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            oeRegimenPensionario.TipoOperacion = "I"
            oeRegimenPensionario.Id = String.Empty
        End If
        Habilita_Controles(False)
        btnActualiza.Enabled = False
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombo()
        Try

            oeEmpresa = New e_Empresa
            oeEmpresa.TipoOperacion = ""
            oeEmpresa.Activo = True
            leEmpresa = olEmpresa.Listar(oeEmpresa)

            Dim _leEmp = leEmpresa.Where(Function(it) it.TipoEmpresa = "ENTIDAD ASEGURADORA").ToList

            LlenarCombo(cboEmpresa, "Nombre", _leEmp, -1)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try

            oeRegimenPensionario = New e_RegimenPensionario
            oeRegimenPensionario.TipoOperacion = ""
            oeRegimenPensionario.Activo = True
            oeRegimenPensionario.Vigente = 1
            leRegimenPensionario = olRegimenPensionario.Listar(oeRegimenPensionario)

            CargarRegimenPensionario(leRegimenPensionario)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarRegimenPensionario(ByVal leRegPen As List(Of e_RegimenPensionario))
        Try
            With griRegimenPensionario

                .ResetDisplayLayout()
                .DataSource = leRegPen

                ConfiguraGrilla(griRegimenPensionario, 1)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        cboEmpresa.SelectedIndex = -1
        ndObligatorio1.Value = 0
        ndComision.Value = 0
        ndSeguros.Value = 0
        ndComisionMixta.Value = 0
        ndSaldoMixta.Value = 0
        fecActividad.Value = Date.Now.Date
        CargarHistorial(New List(Of e_RegimenPensionario))
        cboEmpresa.ReadOnly = True
    End Sub

    Private Sub Mostrar()
        Try
            oeRegimenPensionario = New e_RegimenPensionario
            oeRegimenPensionario.Id = griRegimenPensionario.ActiveRow.Cells("Id").Value
            oeRegimenPensionario = olRegimenPensionario.Obtener(oeRegimenPensionario)
            With oeRegimenPensionario
                cboEmpresa.Value = .IdEmpresa
                ndObligatorio1.Value = .PorcentajeObligatorio
                ndObligatorio2.Value = .PorcentajeObligatorio2
                ndComision.Value = .PorcentajeComision
                ndSeguros.Value = .PorcentajeSeguros
                ndComisionMixta.Value = .PorcentajeComisionMixta
                ndSaldoMixta.Value = .PorcentajeSaldoMixta
                ndRenumeracionMax.Value = .RenumeracionMaxima
                fecActividad.Value = .FechaActividad
                CargarHistorial(.leHistorialPorcentaje)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarHistorial(ByVal leHistorial As List(Of e_RegimenPensionario))
        Try

            With griHistorialPorcentajes

                .ResetDisplayLayout()
                Dim _leHist = leHistorial.OrderByDescending(Function(it) it.FechaActividad).ToList

                .DataSource = _leHist
                ConfiguraGrilla(griHistorialPorcentajes, 2)

                For Each fil In .Rows
                    If fil.Cells("Vigente").Value Then
                        fil.CellAppearance.BackColor = colorVigente.Color
                    Else
                        fil.CellAppearance.BackColor = colorNoVigente.Color
                    End If
                Next

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarImportar(ByVal leImporta As List(Of e_RegimenPensionario))
        Try
            With griImporta

                .ResetDisplayLayout()

                Dim leAux As New List(Of e_RegimenPensionario)

                If verEmpresa.Checked Then
                    leAux = leImporta.Where(Function(it) it.IdEmpresa = "").ToList
                End If

                If leAux.Count > 0 Then
                    .DataSource = leAux
                Else
                    .DataSource = leImporta
                End If

                ConfiguraGrilla(griImporta, 3)

                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("IdEmpresa").Value <> "" Then
                            Fila.Cells("Empresa").Appearance.BackColor = colorRegistrado.Color
                        Else
                            Fila.Cells("Empresa").Appearance.BackColor = colorNoRegistrado.Color
                        End If
                    Next
                    .Text = "Datos Importados (" & .Rows.Count & ")"
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
                .DisplayLayout.Bands(0).Columns("FechaInactividad").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("Vigente").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("Activo").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("PorcentajeTotal").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                .DisplayLayout.Bands(0).Columns("PorcentajeTotalMixta").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEmpresa").Hidden = True
                If Tipo = 2 Then .DisplayLayout.Bands(0).Columns("Empresa").Hidden = True
                If Tipo <> 2 Then .DisplayLayout.Bands(0).Columns("FechaInactividad").Hidden = True
                .DisplayLayout.Bands(0).Columns("Vigente").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                If Tipo <> 3 Then .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("PorcentajeTotal").Hidden = True
                .DisplayLayout.Bands(0).Columns("PorcentajeTotalMixta").Hidden = True

                .DisplayLayout.Bands(0).Columns("Empresa").Width = 300

                .DisplayLayout.Bands(0).Columns("PorcentajeObligatorio").Header.Caption = "Obligatorio %"
                .DisplayLayout.Bands(0).Columns("PorcentajeComision").Header.Caption = "Comision %"
                .DisplayLayout.Bands(0).Columns("PorcentajeSeguros").Header.Caption = "Seguros %"
                .DisplayLayout.Bands(0).Columns("PorcentajeComisionMixta").Header.Caption = "Comision(Mixta) %"
                .DisplayLayout.Bands(0).Columns("PorcentajeSaldoMixta").Header.Caption = "Saldo(Mixta) %"
                .DisplayLayout.Bands(0).Columns("PorcentajeObligatorio2").Header.Caption = "Obligatorio(2) %"
                .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"

                .DisplayLayout.Bands(0).Columns("PorcentajeObligatorio").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PorcentajeComision").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PorcentajeSeguros").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PorcentajeComisionMixta").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PorcentajeSaldoMixta").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PorcentajeTotal").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PorcentajeTotalMixta").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PorcentajeObligatorio2").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("PorcentajeObligatorio").Format = "#,##0.00"
                .DisplayLayout.Bands(0).Columns("PorcentajeComision").Format = "#,##0.00"
                .DisplayLayout.Bands(0).Columns("PorcentajeSeguros").Format = "#,##0.00"
                .DisplayLayout.Bands(0).Columns("PorcentajeComisionMixta").Format = "#,##0.00"
                .DisplayLayout.Bands(0).Columns("PorcentajeSaldoMixta").Format = "#,##0.00"
                .DisplayLayout.Bands(0).Columns("PorcentajeObligatorio2").Format = "#,##0.00"

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

    Private Sub Habilita_Controles(_band As Boolean)
        fecActividad.Enabled = Not _band
        ndObligatorio1.ReadOnly = _band
        ndObligatorio2.ReadOnly = _band
        ndComision.ReadOnly = _band
        ndComisionMixta.ReadOnly = _band
        ndSeguros.ReadOnly = _band
        ndSaldoMixta.ReadOnly = _band
        ndRenumeracionMax.ReadOnly = _band
    End Sub

#End Region

#Region "Menu Conceptual"

    Private Sub mnuRegPen_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuRegPen.Opening
        mnuRegPen.Items("tsmiNuevo").Enabled = True
        mnuRegPen.Items("tsmiEditar").Enabled = False
        mnuRegPen.Items("tsmiEliminar").Enabled = False
        mnuRegPen.Items("tsmiImportar").Enabled = True
        If griRegimenPensionario.Rows.Count > 0 Then
            mnuRegPen.Items("tsmiEditar").Enabled = True
            mnuRegPen.Items("tsmiEliminar").Enabled = True
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
        MostrarTabs(2, ficRegimenPensionario)
        ficRegimenPensionario.Tabs(0).Enabled = False
        ficRegimenPensionario.Tabs(1).Enabled = False
        ficRegimenPensionario.Tabs(2).Enabled = True
        verEmpresa.Checked = False
        verEmpresa.Enabled = False
        btnValidar.Enabled = False
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        CargarImportar(New List(Of e_RegimenPensionario))
    End Sub

#End Region

End Class