Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Microsoft.Office.Interop


Public Class frm_ValesRendir
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_ValesRendir = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_ValesRendir()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeValesRendir As New e_ValesRendir
    Private olValesRendir As New l_ValesRendir
    Private loValesRendir As New List(Of e_ValesRendir)
    Dim idMovimiento, idCuentaTrabajador, idTrabajador As String

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador

    Dim loCuentaCorriente As New List(Of e_CuentaCorriente)

    Dim Prefijo As New l_Configuracion

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro

    Private Estado As String
    Private idCajaCentro As String = ""
    Private olPersona As New l_Persona

    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficValesRendir, 1)
            oeValesRendir = New e_ValesRendir
            oeValesRendir.Modificado = False
            oeValesRendir.IndRendido = 0
            oeValesRendir.TipoOperacion = "I"
            oeValesRendir.UsuarioCreacion = gUsuarioSGI.Id
            oeValesRendir.IdCentro = cboCentroL.Value
            Inicializar()
            cboTrabajadores.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar()
        Try
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If ValidaUsuarioCajaCentro(idCajaCentro, ObtenerCentro.Id, gUsuarioSGI.IdTrabajador) Then
                Select Case ficValesRendir.SelectedTab.Index
                    Case 1
                        If GuardarVale() Then
                            MostrarTabs(0, ficValesRendir, 0)
                            Listar()
                            ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
                        Else
                            MostrarTabs(1, ficValesRendir, 1)
                        End If
                End Select
            Else
                Throw New Exception("No puede Realizar Movimientos en esta Sede")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeValesRendir.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarVale() Then
                            MostrarTabs(0, ficValesRendir, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficValesRendir, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficValesRendir, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficValesRendir)
                _ingresando_datos = False
                Listar()
                ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            Dim tipo As String = "A"
            If griValesRendir.Selected.Rows.Count > 0 Then
                If griValesRendir.ActiveRow.Selected = True Then
                    Dim formulario As New frm_ReporteVoucherMovimientoCaja
                    formulario.CargarDatos(tipo, griValesRendir.ActiveRow.Cells("Id").Value.ToString)
                    formulario.ShowDialog()
                End If
            End If
            ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficValesRendir.Tabs(0).Selected AndAlso griValesRendir.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficValesRendir.Tabs(0).Selected Then Exportar_Excel(griValesRendir)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griValesRendir.ActiveRow.Cells("IndRendido").Value = False Then
                If idCajaCentro = "" Then
                    Throw New Exception("No Puede Eliminar Vales. No esta Asignado a la Caja.")
                End If
                Select Case MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        EliminarVale()
                End Select
            End If
            
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ValesRendir_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Me.ficValesRendir.SelectedTab.Index = 1 Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Else
            ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
        End If
    End Sub

    Private Sub frm_ValesRendir_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_ValesRendir_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ValesRendir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
            fecValeDesde.Value = Date.Now.AddDays(-15)
            LlenaCombosTrabajadores()
            ListarCuentaCorriente()
            LlenaComboCentro()
            BuscarUsuarioCaja()
            MostrarTabs(0, ficValesRendir, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        MenuContextual1.Items("RendirToolStripMenuItem").Visible = False
        MenuContextual1.Items("EnviarMailToolStripMenuItem").Visible = True
        MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        If Me.griValesRendir.Selected.Rows.Count > 0 Then
            If Me.griValesRendir.ActiveRow.Selected = True And Me.griValesRendir.ActiveRow.Cells("IndRendido").Value = False Then
                MenuContextual1.Items("RendirToolStripMenuItem").Visible = True
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
            End If
        End If
    End Sub

    Private Sub griValesRendir_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griValesRendir.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub cboAutorizaVale_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAutorizaVale.ValueChanged
        oeValesRendir.IdTrabajadorAutoriza = cboAutorizaVale.Value
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeValesRendir.Glosa = txtGlosa.Text
    End Sub

    Private Sub txtVoucher_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoucher.ValueChanged
        oeValesRendir.NroVale = txtVoucher.Text
    End Sub

    Private Sub RendirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RendirToolStripMenuItem.Click
        RendirVale()
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub txtImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.ValueChanged
        oeValesRendir.Importe = txtImporte.Value
    End Sub

    Private Sub cboCentroL_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroL.ValueChanged
        oeValesRendir.IdCentro = cboCentroL.Value
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub EnviarMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarMailToolStripMenuItem.Click
        Try
            EnviarMail()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griValesRendir_CellChange(sender As Object, e As UltraWinGrid.CellEventArgs) Handles griValesRendir.CellChange
        griValesRendir.UpdateData()
    End Sub

    Private Sub frm_ValesRendir_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Metodos"

    Private Sub EliminarVale()
        Try

            Dim oeSaldo As New e_Saldo
            Dim olSaldo As New l_Saldo
            oeSaldo.TipoOperacion = "3"
            oeSaldo.IdCaja = idCajaCentro
            oeSaldo = olSaldo.Obtener(oeSaldo)
            oeValesRendir = New e_ValesRendir
            oeValesRendir.Id = griValesRendir.ActiveRow.Cells("Id").Value
            oeValesRendir.FechaCreacion = griValesRendir.ActiveRow.Cells("FechaCreacion").Value
            If oeValesRendir.FechaCreacion > oeSaldo.FechaHora Then
                oeValesRendir.TipoOperacion = "E"
                If olValesRendir.Eliminar(oeValesRendir) Then
                    mensajeEmergente.Confirmacion("La Informacion ha Sido Eliminada Correctamente")
                    Listar()
                End If
            Else
                Throw New Exception("No Puede Eliminar Vales Pasado el Cierre de Caja")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function RendirVale() As Boolean
        Try
            Dim oeValRen As New e_ValesRendir
            oeValesRendir = New e_ValesRendir
            oeValesRendir.Id = griValesRendir.ActiveRow.Cells("Id").Value.ToString
            oeValesRendir.TipoOperacion = ""
            oeValRen = olValesRendir.Obtener(oeValesRendir)
            oeValesRendir.TipoOperacion = "R"
            oeValesRendir.FechaCierre = Date.Parse("01/01/1901")
            oeValRen.Id = ""
            oeValRen.TipoOperacion = "X"
            oeValRen.IdCentro = cboCentroL.Value
            oeValRen.Glosa = "VALE RENDIDO Nro: " & oeValRen.NroVale & " // " & oeValRen.Glosa
            oeValRen.IndRendido = 1
            oeValRen.IndCerrado = 0
            oeValRen.Fecha = Date.Now
            oeValRen.IdCuentaCorriente = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
            If oeValRen.IdCuentaCorriente.Trim = "" Then Throw New Exception("¡Usted no Tiene Cuenta Administrativa!")
            oeValRen.FechaCierre = Date.Parse("01/01/1901")
            oeValRen.IdCaja = idCajaCentro
            If olValesRendir.RendirVale(oeValesRendir, oeValRen) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficValesRendir)
                oeValesRendir = New e_ValesRendir
                Listar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LlenaComboCentro()
        Dim oe As New e_Centro
        Dim leCentro As New List(Of e_Centro)
        oe.Id = ""
        oe.Nombre = "TODOS"
        leCentro.Add(oe)
        leCentro.AddRange(olCentro.Listar(oeCentro))
        LlenarCombo(cboCentroL, "Nombre", leCentro, 0)
    End Sub

    Private Sub BuscarUsuarioCaja()
        Try
            Dim oeCajaUsuario As New e_CajaUsuario
            Dim olCajaUsuario As New l_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            idCajaCentro = oeCajaUsuario.IdCaja
            If oeCajaUsuario.Id <> "" Then
                cboCentroL.Value = oeCajaUsuario.IdCentro
                If oeCajaUsuario.IdCentro = "1CH001" Then
                    cboCentroL.Enabled = True
                Else
                    cboCentroL.Enabled = False
                End If
            Else
                Throw New Exception("Usuario no Asignado a Caja")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarVale() As Boolean
        Try
            Dim TipoOperacion As String = "A"
            oeValesRendir.Fecha = fecVale.Value
            oeValesRendir.IdCuentaCorriente = BuscarIdCtaCte(gUsuarioSGI.IdTrabajador, 1, loCuentaCorriente)
            oeValesRendir.FechaCierre = Date.Parse("01/01/1901")
            oeValesRendir.IndCerrado = 0
            oeValesRendir.IdCaja = idCajaCentro
            If oeValesRendir.IdTrabajadorAutoriza = "" Then
                mensajeEmergente.Problema("Seleccion Trabajador Autoriza")
                Return False
            End If
            If olValesRendir.Guardar(oeValesRendir) Then
                Dim formulario As New frm_ReporteVoucherMovimientoCaja
                formulario.CargarDatos(TipoOperacion, oeValesRendir.Id)
                formulario.ShowDialog()
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Listar()
        Try
            oeValesRendir = New e_ValesRendir
            oeValesRendir.IdCentro = cboCentroL.Value
           
            oeValesRendir.TipoOperacion = ""
            If chkPorRendir.Checked Then
                oeValesRendir.Fecha = Date.Parse("01/01/1901")
                oeValesRendir.FechaCreacion = Date.Parse("01/01/1901")
                oeValesRendir.IndRendido = 0
            Else
                oeValesRendir.Fecha = fecValeDesde.Value
                oeValesRendir.FechaCreacion = fecValeHasta.Value
                oeValesRendir.IndRendido = 1
            End If
            loValesRendir = olValesRendir.Listar(oeValesRendir)
            griValesRendir.DataSource = loValesRendir
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griValesRendir.Rows
                Select Case fila.Cells("IndRendido").Value
                    Case "0"
                        fila.CellAppearance.BackColor = Me.ColoresPorRendir.Color
                    Case "1"
                        fila.CellAppearance.BackColor = Me.ColoresRendido.Color
                End Select
            Next
            CalcularTotales(griValesRendir, "Ingreso", "Egreso")
            Dim cantingreso As Double = loValesRendir.Sum(Function(item) item.Ingreso)
            Dim cantegreso As Double = loValesRendir.Sum(Function(item) item.Egreso)
            Me.decSaldo.Value = cantegreso - cantingreso
            With griValesRendir
                .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                If griValesRendir.Rows.Count > 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Inicializar()
        cboTrabajadores.SelectedIndex = -1
        cboAutorizaVale.SelectedIndex = -1
        Me.txtImporte.Value = 0
        Me.FotoTrabajador.Visible = False
        Me.agrDatosBasicos.Visible = False
        Me.txtGlosa.Value = String.Empty
        Me.txtVoucher.Value = String.Empty
        Me.fecVale.Value = Date.Now
    End Sub

    Private Sub ListarCuentaCorriente()
        Try
            Dim oeCuentaCorriente As New e_CuentaCorriente
            Dim olCuentaCorriente As New l_CuentaCorriente
            oeCuentaCorriente.Activo = True
            oeCuentaCorriente.Tipo = 1
            loCuentaCorriente = olCuentaCorriente.Listar(oeCuentaCorriente).OrderBy(Function(item) item.Trabajador).ToList
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EnviarMail()
        Try
            If loValesRendir.Where(Function(item) item.Seleccion = True).ToList.Count > 0 Then
                CargarDatosCorreo()
            Else
                Throw New Exception("No hay Registros Seleccionados")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDatosCorreo()
        Dim oeCombo As New e_Combo
        Dim objXls As Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objWorkSheet As Excel.Worksheet
        objXls = New Excel.Application
        Dim FileToCopy As String
        Dim PathFile As String
        Try
            FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\ValesRendir.xlt"
            PathFile = Application.StartupPath & "\" & "ValesRendir.xls"
            If System.IO.File.Exists(FileToCopy) = True And System.IO.File.Exists(PathFile) = True Then
                System.IO.File.SetAttributes(PathFile, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                System.IO.File.Copy(FileToCopy, PathFile, True)
                System.IO.File.SetAttributes(PathFile, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
            Else
                If System.IO.File.Exists(FileToCopy) = True Then
                    System.IO.File.Copy(FileToCopy, PathFile, True)
                    System.IO.File.SetAttributes(PathFile, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                Else
                    Throw New Exception("No se encontro el archivo de Plantilla, Consulte con Soporte")
                End If
            End If
            ' Creamos una variable para guardar la cultura actual
            Dim OldCultureInfo As System.Globalization.CultureInfo = _
            System.Threading.Thread.CurrentThread.CurrentCulture
            'Crear una cultura standard (en-US) inglés estados unidos
            System.Threading.Thread.CurrentThread.CurrentCulture = _
            New System.Globalization.CultureInfo("es-PE")

            objWorkbook = objXls.Workbooks.Open(PathFile)
            objWorkSheet = objXls.Worksheets(1)
            objWorkSheet.Name = "ValesRendir"

            objWorkSheet.Cells(4, 7) = Date.Now.Date

            Dim ln_Fila As Integer = 1

            For Each valren As e_ValesRendir In loValesRendir.Where(Function(item) item.Seleccion = True).ToList
                objWorkSheet.Cells(ln_Fila + 6, 1) = ln_Fila
                objWorkSheet.Cells(ln_Fila + 6, 2) = valren.NroVale
                objWorkSheet.Cells(ln_Fila + 6, 3) = valren.Fecha
                objWorkSheet.Cells(ln_Fila + 6, 4) = valren.Trabajador
                objWorkSheet.Cells(ln_Fila + 6, 8) = valren.Glosa
                objWorkSheet.Cells(ln_Fila + 6, 12) = valren.Egreso
                ln_Fila = ln_Fila + 1
            Next

            'Mostramos el documento en pantalla
            objXls.ActiveWindow.Zoom = 100
            objXls.ActiveWindow.DisplayGridlines = False
            objXls.Sheets.Item(1).Select()
            ' Proteger con password la hoja de calculo para que no se pueda editar. 
            'objWorkSheet.Protect("SOFTCOM", True, True, True, True)
            System.IO.File.SetAttributes(PathFile, IO.FileAttributes.ReadOnly)

            Dim ruta As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & objWorkbook.Name & ".xls"
            Dim ruta2 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & objWorkbook.Name & ".xlsx"
            Dim Documento As String
            If System.IO.File.Exists(ruta) Then
                System.IO.File.Delete(ruta)
            End If
            If System.IO.File.Exists(ruta2) Then
                System.IO.File.Delete(ruta2)
            End If
            objWorkbook.Save()
            Documento = objWorkbook.Path & "\" & objWorkbook.Name
            objXls.Workbooks.Close()
            objXls.Quit()
            Dim listaMailTrabajadores As String = "ing.miguelherrera.sistemas@gmail.com; "
            For Each detalle As e_ValesRendir In loValesRendir.Where(Function(item) item.Seleccion = True).ToList
                oeCombo = New e_Combo
                oeCombo.Id = detalle.IdTrabajador
                oeCombo.Tipo = 0
                If CorreosPublic.Contains(oeCombo) Then
                    oeCombo = CorreosPublic.Item(CorreosPublic.IndexOf(oeCombo))
                    listaMailTrabajadores &= oeCombo.Nombre.Trim & "; "
                End If
            Next
            listaMailTrabajadores = Strings.Left(listaMailTrabajadores, listaMailTrabajadores.Length - 2)
            oeCombo = New e_Combo
            oeCombo.Id = gUsuarioSGI.IdTrabajador
            If CorreosPublic.Contains(oeCombo) Then
                oeCombo = CorreosPublic.Item(CorreosPublic.IndexOf(oeCombo))
            End If
            Dim correoTrabajador As String = oeCombo.Nombre.Trim
            Dim formulario As frm_EnvioCorreo
            formulario = frm_EnvioCorreo
            If gUsuarioSGI.oePersona.leEmail.Count > 0 Then correoTrabajador = gUsuarioSGI.oePersona.leEmail.Item(0).Nombre '"weezer@hotmail.com" 'Quiem lo envia                
            If formulario.ObtenerDatos("", Documento, correoTrabajador, True, True, True, True, _
                 listaMailTrabajadores, "TIENE VALE(S) PENDIENTES POR RENDIR. FAVOR ACERCARSE A TESORERIA O DICHOS VALES SERAN DESCONTADOS DE SU CUENTA") Then
                formulario.ShowDialog()
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
            End If
            formulario = Nothing
            'objXls.ActiveWorkbook.Close(False)
            objWorkSheet = Nothing
            objWorkbook = Nothing
            objXls = Nothing
            'Restauramos la cultura original
            System.Threading.Thread.CurrentThread.CurrentCulture = OldCultureInfo
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Combo Trabajador"

    Public Sub LlenaCombosTrabajadores()
        Try
            LlenarCombo(cboAutorizaVale, "Nombre", TrabajadorPublic, -1)
            LlenarCombo(cboTrabajadores, "Nombre", TrabajadorPublic, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboTrabajadores_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadores.Validated
        Try
            Dim oeMovimientoPersonal As New e_MovimientoPersonal
            If cboTrabajadores.SelectedIndex > -1 Then
                oeMovimientoPersonal.IdTrabajador = cboTrabajadores.Value
                oeValesRendir.IdTrabajador = cboTrabajadores.Value
                Dim oeTrabajador As New e_Trabajador
                Dim olTrabajador As New l_Trabajador
                oeTrabajador.Id = oeMovimientoPersonal.IdTrabajador
                oeTrabajador = olTrabajador.ObtenerObjeto(oeTrabajador)
                If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then FotoTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
                FotoTrabajador.Visible = True
                agrDatosBasicos.Visible = True
                txtArea.Text = oeTrabajador.oeArea.Nombre
                txtCargo.Text = oeTrabajador.oeCargo.Nombre
                fecFechaIngreso.Value = oeTrabajador.FechaIngreso
                chkDisponible.Checked = oeTrabajador.Disponible
                If oeTrabajador.Disponible Then
                    chkDisponible.BackColor = Color.Transparent
                    chkDisponible.ForeColor = Color.Black
                    chkDisponible.Text = "Disponible"
                Else
                    chkDisponible.BackColor = Color.Red
                    chkDisponible.ForeColor = Color.Yellow
                    chkDisponible.Text = "Trabajador NO Disponible"
                End If
                oeValesRendir.Modificado = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class