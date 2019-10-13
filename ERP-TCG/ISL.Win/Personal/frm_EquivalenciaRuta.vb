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

Public Class frm_EquivalenciaRuta
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_EquivalenciaRuta = Nothing

    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_EquivalenciaRuta()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeEquivalenciaRuta As New e_EquivalenciaRuta
    Private olEquivalenciaRuta As New l_EquivalenciaRuta
    Private loEquivalenciaRutaImportar As New List(Of e_EquivalenciaRuta)
    Private loEquivalenciaRutaValidar As New List(Of e_EquivalenciaRuta)
    Private loEquivalenciaRuta As New List(Of e_EquivalenciaRuta)
    Private loHistorialEquivalenciaRuta As New List(Of e_EquivalenciaRuta)

    Private oeComboVehiculo, oeComboLugarOrigen, oeComboLugarDestino As New e_Combo

    Private oeRuta As New e_Ruta
    Private olRuta As New l_Ruta
    Private loRuta As New List(Of e_Ruta)

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficEquivalenciaRuta, 1)
            MostrarTabs(0, ficMantenimiento, 0)
            oeEquivalenciaRuta.Modificado = False
            Inicializar()
            Operacion = "Nuevo"
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            Inicializar()
            Mostrar()
            MostrarTabs(1, ficEquivalenciaRuta, 1)
            MostrarTabs(0, ficMantenimiento, 0)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficMantenimiento.SelectedTab.Index
                Case 0
                    If GuardarEquivalencia() Then
                        MostrarTabs(0, ficEquivalenciaRuta)
                        Listar()
                    End If
                Case 1
                    'VerificarRutas()
                    Dim listaImpo As New List(Of e_EquivalenciaRuta)
                    listaImpo.AddRange(loEquivalenciaRutaImportar.Where(Function(item) item.IdRuta <> ""))
                    If listaImpo.Count > 0 Then
                        If olEquivalenciaRuta.GuardarMasivo(listaImpo, gs_PrefijoIdSucursal) Then
                            mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente")
                            MostrarTabs(0, ficEquivalenciaRuta)
                            Listar()
                        End If
                    Else
                        Throw New Exception("No hay Datos que Guardar")
                    End If
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeEquivalenciaRuta.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarEquivalencia() Then
                            MostrarTabs(0, ficEquivalenciaRuta, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficEquivalenciaRuta, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficEquivalenciaRuta, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficEquivalenciaRuta)
                _ingresando_datos = False
            End If
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            'Select Case ficMontoRuta.SelectedTab.Index
            'Case 0
            If griEquivalenciaRuta.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griEquivalenciaRuta)
            '    Case 1
            '        If griHistorialMontoRutas.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            '        Exportar_Excel(griHistorialMontoRutas)
            'End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            Select Case MessageBox.Show("Desea Eliminar la Informacion?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    EliminarEquivalencia()
                    Listar()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Inicializar()
        oeEquivalenciaRuta = New e_EquivalenciaRuta
        cboOrigen.SelectedIndex = -1
        cboDestino.SelectedIndex = -1
        numCuenta.Value = 0
        numMontoRuta.Value = 0.0
        numEquivalencia.Value = 0.0
    End Sub

    Public Sub Listar()
        Try
            oeEquivalenciaRuta = New e_EquivalenciaRuta
            oeEquivalenciaRuta.TipoOperacion = ""
            If rdbFechas.Checked Then

            Else
                If cboRuta.SelectedIndex <> 0 Then
                    oeEquivalenciaRuta.IdRuta = cboRuta.Value
                End If
            End If
            loEquivalenciaRuta = olEquivalenciaRuta.Listar(oeEquivalenciaRuta)
            griEquivalenciaRuta.DataSource = loEquivalenciaRuta
            If griEquivalenciaRuta.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Mostrar()
        Try
            Inicializar()
            oeEquivalenciaRuta.Id = griEquivalenciaRuta.ActiveRow.Cells("Id").Value
            oeEquivalenciaRuta = olEquivalenciaRuta.Obtener(oeEquivalenciaRuta)
            With oeEquivalenciaRuta
                cboDestino.Value = .IdDestino
                cboOrigen.Value = .IdOrigen
                numCuenta.Value = .Cuenta
                numEquivalencia.Value = .Equivalencia
                numMontoRuta.Value = .Monto
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EliminarEquivalencia()
        Try
            oeEquivalenciaRuta = New e_EquivalenciaRuta
            oeEquivalenciaRuta.Id = griEquivalenciaRuta.ActiveRow.Cells("Id").Value
            If olEquivalenciaRuta.Eliminar(oeEquivalenciaRuta) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Eliminada Correctamente")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub VerificarRutas()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GuardarEquivalencia() As Boolean
        Try
            LlenaObjeto()
            oeEquivalenciaRuta.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olEquivalenciaRuta.Guardar(oeEquivalenciaRuta) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub LlenaObjeto()
        Try
            oeRuta = New e_Ruta
            oeRuta.TipoOperacion = "M"
            oeRuta.IdOrigen = cboOrigen.Value
            oeRuta.IdDestino = cboDestino.Value
            oeRuta = olRuta.Obtener(oeRuta)
            If oeRuta.Id = "" Then Throw New Exception("Ruta no Existe. Verificar")
            If Operacion = "Nuevo" Then
                oeEquivalenciaRuta.TipoOperacion = "I"
            Else
                oeEquivalenciaRuta.TipoOperacion = "A"
            End If
            oeEquivalenciaRuta.IdRuta = oeRuta.Id
            oeEquivalenciaRuta.Cuenta = numCuenta.Value
            oeEquivalenciaRuta.Monto = numMontoRuta.Value
            oeEquivalenciaRuta.Equivalencia = numEquivalencia.Value
            oeEquivalenciaRuta.FechaCreacion = ObtenerFechaServidor()
            oeEquivalenciaRuta.UsuarioCreacion = gUsuarioSGI.Id
        Catch ex As Exception
            Throw ex
        End Try    
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_EquivalenciaRuta_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficEquivalenciaRuta.SelectedTab.Index
            Case 0
                If griEquivalenciaRuta.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_EquivalenciaRuta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_EquivalenciaRuta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_EquivalenciaRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oeRuta = New e_Ruta
        oeRuta.TipoOperacion = ""
        loRuta.AddRange(olRuta.Listar(oeRuta))
        CargarCombos()
    End Sub

#End Region

    Public Sub CargarCombos()
        Dim oe As New e_Combo
        Dim looe As New List(Of e_Combo)
        oe.Id = ""
        oe.Nombre = "TODOS"
        looe.Add(oe)
        looe.AddRange(RutasPublic)
        LlenarCombo(cboDestino, "Nombre", LugaresPublic, -1)
        LlenarCombo(cboOrigen, "Nombre", LugaresPublic, -1)
        LlenarCombo(cboRuta, "Nombre", looe, 0)
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
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
                Dim IdRuta As String = ""
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                loEquivalenciaRutaImportar = New List(Of e_EquivalenciaRuta)
                Dim fecha As Date = ObtenerFechaServidor()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        oeComboLugarOrigen = New e_Combo
                        oeComboLugarOrigen.Tipo = 1
                        oeComboLugarOrigen.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If LugaresPublic.Contains(oeComboLugarOrigen) Then
                            oeComboLugarOrigen = LugaresPublic.Item(LugaresPublic.IndexOf(oeComboLugarOrigen))
                        End If
                        oeComboLugarDestino = New e_Combo
                        oeComboLugarDestino.Tipo = 1
                        oeComboLugarDestino.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value)
                        If LugaresPublic.Contains(oeComboLugarDestino) Then
                            oeComboLugarDestino = LugaresPublic.Item(LugaresPublic.IndexOf(oeComboLugarDestino))
                        End If
                        oeRuta = New e_Ruta
                        oeRuta.TipoOperacion = "R"
                        oeRuta.IdOrigen = oeComboLugarOrigen.Id
                        oeRuta.IdDestino = oeComboLugarDestino.Id
                        If loRuta.Contains(oeRuta) Then
                            oeRuta = loRuta.Item(loRuta.IndexOf(oeRuta))
                        End If
                        oeEquivalenciaRuta = New e_EquivalenciaRuta
                        oeEquivalenciaRuta.Id = String.Empty
                        oeEquivalenciaRuta.IdRuta = oeRuta.Id
                        oeEquivalenciaRuta.Origen = IIf(oeRuta.Origen = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value), oeRuta.Origen)
                        oeEquivalenciaRuta.Destino = IIf(oeRuta.Destino = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeRuta.Destino)
                        oeEquivalenciaRuta.Cuenta = CDbl(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value) = "", 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)))
                        oeEquivalenciaRuta.Monto = CDbl(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value) = "", 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value)))
                        oeEquivalenciaRuta.Equivalencia = CDbl(IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value) = "", 0, Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value)))
                        oeEquivalenciaRuta.FechaCreacion = fecha
                        oeEquivalenciaRuta.UsuarioCreacion = gUsuarioSGI.Id
                        oeEquivalenciaRuta.PrefijoID = gs_PrefijoIdSucursal '@0001
                        loEquivalenciaRutaImportar.Add(oeEquivalenciaRuta)
                    Else
                        Exit For
                    End If
                Next
                CargarImportar(loEquivalenciaRutaImportar)
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

    Public Sub CargarImportar(ByVal lista As List(Of e_EquivalenciaRuta))
        Try
            With griEquivalenciaImportar
                .DataSource = lista
                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("IdRuta").Value.ToString = "" Then
                            Fila.CellAppearance.BackColor = colorNoRegistrados.Color
                            Fila.CellAppearance.ForeColor = Color.White
                        End If
                    Next
                    .Text = "Datos Importados (" & .Rows.Count & ")"
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ToolStripMenuImportar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuImportar.Click
        Importar()
    End Sub

    Public Sub Importar()
        Try
            MostrarTabs(1, ficEquivalenciaRuta, 1)
            MostrarTabs(1, ficMantenimiento, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            CargarImportar(New List(Of e_EquivalenciaRuta))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub numMontoRuta_ValueChanged(sender As Object, e As EventArgs) Handles numMontoRuta.ValueChanged
        If IsDBNull(numMontoRuta.Value) Then numMontoRuta.Value = 0.0
        numEquivalencia.Value = numMontoRuta.Value * 0.25 / 20
    End Sub

    Private Sub griEquivalenciaRuta_DoubleClick(sender As Object, e As EventArgs) Handles griEquivalenciaRuta.DoubleClick
        Editar()
    End Sub

End Class