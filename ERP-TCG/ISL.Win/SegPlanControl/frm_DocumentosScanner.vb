Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports System.IO
Imports System.Xml
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Linq
Imports Microsoft.Office.Interop

Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Documents.Excel
Imports System.Text
Imports System.Runtime.InteropServices

Public Class frm_DocumentosScanner
    Inherits ISL.Win.frm_MenuPadre


#Region "Inicialización del formulario"

    Private Shared Instancia As frm_DocumentosScanner = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_DocumentosScanner
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

    Public Sub CargarDocumentosVencidos(ByVal Opcion As Integer)
        Try
            oeDocVehImg = New e_ImagenesDocumentos
            Select Case Opcion
                Case 1
                    oeDocVehImg.TipoOperacion = "Z"
                    oeDocVehImg.FechaCreacion = Date.Parse("01/01/1901")
                    oeDocVehImg.FechaFin = Date.Parse("01/01/1901")
                    oeDocVehImg.IdTipoDocumento = ""
                    oeDocVehImg.IdVehiculo = ""
                    oeDocVehImg.Identificador = ""
                Case 2
                    oeDocVehImg.TipoOperacion = "V"
                    oeDocVehImg.FechaCreacion = Date.Parse("01/01/1901")
                    oeDocVehImg.FechaFin = Date.Parse("01/01/1901")
                    oeDocVehImg.IdTipoDocumento = ""
                    oeDocVehImg.IdVehiculo = ""
                    oeDocVehImg.Identificador = ""
            End Select
            griLista.DataSource = olDocVehImg.Listar(oeDocVehImg)
            For Each fila As UltraGridRow In griLista.Rows
                If fila.Cells("FechaVencimiento").Value <> "01/01/1901" Then
                    fila.CellAppearance.ForeColor = Color.Black
                    If fila.Cells("Vencimiento").Value <= 10 Then
                        fila.CellAppearance.BackColor = Me.ColoresVencido.Color
                        fila.CellAppearance.ForeColor = Color.White
                    ElseIf fila.Cells("Vencimiento").Value > 10 And fila.Cells("Vencimiento").Value <= 20 Then
                        fila.CellAppearance.BackColor = Me.ColoresPorVencer.Color
                    Else
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    End If
                End If
            Next
            If griLista.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Definicion de Variables"

    Dim _ingresando_datos As Boolean = False

    Private oeDocVehIndividual As New e_ImagenesDocumentos
    Private oeDocVehMasivo As New e_ImagenesDocumentos
    Private oeDocVehIgual As New e_ImagenesDocumentos

    Private WithEvents oeDocVehImg As e_ImagenesDocumentos
    Private olDocVehImg As New l_ImagenesDocumentos

    Private imagen As String = ""
    Public IpServidor As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidor")
    Private listaImagenesDoc As New List(Of e_ImagenesDocumentos)
    Private listaDocumentoIgual As New List(Of e_ImagenesDocumentos)
    Dim idDV As String = ""
    Dim loVehiculo As New List(Of e_Combo)
    Dim listaImagenes As New List(Of e_ImagenesDocumentos)
    Dim listaImagenesIgual As New List(Of e_ImagenesDocumentos)
    Dim imagenDoc As New e_ImagenesDocumentos
#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Operacion = "Nuevo"
            MostrarTabs(1, ficImgDocVeh, 1)
            Inicializar()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            tabControl.SelectedTab = tabControl.Tabs("tabUnidad")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            ugb_Espera.Visible = True
            If griLista.Selected.Rows.Count > 0 Then
                Inicializar()
                'limpiarFormMasivo()
                Operacion = "Editar"
                MostrarTabs(1, ficImgDocVeh, 1)
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                tabControl.SelectedTab = tabControl.Tabs("tabMasivo")
                tabControl.Tabs("tabMasivo").Enabled = True
                tabControl.Tabs("tabUnidad").Enabled = False
                tabControl.Tabs("tabIgual").Enabled = False
                oeDocVehMasivo = New e_ImagenesDocumentos
                oeDocVehMasivo.IndVigente = 0
                oeDocVehMasivo.IdVehiculo = griLista.ActiveRow.Cells("IdVehiculo").Value
                listaImagenesDoc = olDocVehImg.Listar(oeDocVehMasivo)
                griVehiculos.DataSource = listaImagenesDoc
                GrigDocumentoMasivoMarcar()
                If griLista.ActiveRow IsNot Nothing Then
                    oeDocVehMasivo = New e_ImagenesDocumentos
                    oeDocVehMasivo = griLista.ActiveRow.ListObject
                    MostrarVeh()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            ugb_Espera.Visible = True
            Select Case ficImgDocVeh.SelectedTab.Index
                Case 1
                    If GuardarImgDocVeh() Then
                        MostrarTabs(0, ficImgDocVeh, 0)
                        Listar()
                    Else
                        MostrarTabs(1, ficImgDocVeh, 1)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    Guardar()
                Case Windows.Forms.DialogResult.No
                    'MostrarTabs(0, ficImgDocVeh, 2)
                    '_ingresando_datos = False
                    'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    MostrarTabs(0, ficImgDocVeh)
                    _ingresando_datos = False
                    Listar()
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficImgDocVeh.Tabs(0).Selected AndAlso griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficImgDocVeh.Tabs(0).Selected Then Exportar_Excel(griLista)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griLista.Selected.Rows.Count > 0 Then
                Select Case MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        EliminarImgDoc()
                        Consultar(True)
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ImagenesDocumentosVehiculos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficImgDocVeh.SelectedTab.Index
            Case 0
                If griLista.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_ImagenesDocumentosVehiculoss_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_ImagenesDocumentosVehiculos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ImagenesDocumentosVehiculos_Load(sender As Object, e As EventArgs) Handles Me.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        fecDesde.Value = Date.Now.AddDays(-30)
        fecHasta.Value = Date.Now.AddDays(60)
        CargarCombos()
        ReCargarComboVehiculo()
        MostrarTabs(0, ficImgDocVeh)
        Inicializar()
        'Me.griVehiculos.DataSource = listaImagenesDoc
    End Sub

    Dim listaImagenesInd As New List(Of e_ImagenesDocumentos)
    Dim imagenDocInd As New e_ImagenesDocumentos
    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Try
            Dim Formulario As New frm_Scanner
            'Formulario.CodigoViaje = String.Empty
            Formulario.ShowDialog()
            If Formulario.DialogResult = Windows.Forms.DialogResult.OK Then
                'Me.txtRuta.Text = ofd_Imagen.FileName
                imagenDocInd = New e_ImagenesDocumentos
                imagenDocInd.RutaImagen = Formulario.RutaImagen
                listaImagenesInd.Add(imagenDocInd)
                griImagenesInd.DataSource = listaImagenesInd
                griImagenesInd.DataBind()
                griImagenesInd.UpdateData()
                'imagen = ofd_Imagen.SafeFileName
                Dim Fs As FileStream = Nothing
                Fs = New FileStream(Formulario.RutaImagen, IO.FileMode.Open, IO.FileAccess.Read)
                upbDocVeh.Image = System.Drawing.Image.FromStream(Fs)
                'Dim objViaje As New e_Viaje
                'objViaje.Id = Formulario.CodigoViaje.Trim
                'oeIncidenciaMaestro.IdViaje = Formulario.CodigoViaje.Trim
                'objViaje.TipoOperacion = "G"
                'oeViaje = olOperacion.ObtenerViaje(objViaje)
                'LlenarDatosViaje(oeViaje)
                'CargarGrillasDetalle("", oeViaje.Id, "0")
            End If
            Formulario.Dispose()
            Formulario.Close()
            'ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        'Try
        '    Dim ofd_Imagen As New OpenFileDialog
        '    With ofd_Imagen
        '        .Filter = "Imágenes JPG (*.jpg)|*.jpg"
        '        .FilterIndex = 1
        '        .Title = "Abrir imagen ..."
        '    End With
        '    If ofd_Imagen.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        Me.txtRuta.Text = ofd_Imagen.FileName
        '        imagenDocInd = New e_ImagenesDocumentos
        '        imagenDocInd.RutaImagen = ofd_Imagen.FileName
        '        listaImagenesInd.Add(imagenDocInd)
        '        griImagenesInd.DataSource = listaImagenesInd
        '        griImagenesInd.DataBind()
        '        griImagenesInd.UpdateData()
        '        imagen = ofd_Imagen.SafeFileName
        '        Dim Fs As FileStream = Nothing
        '        Fs = New FileStream(txtRuta.Text, IO.FileMode.Open, IO.FileAccess.Read)
        '        upbDocVeh.Image = System.Drawing.Image.FromStream(Fs)
        '    End If
        '    ofd_Imagen.Dispose()
        '    ofd_Imagen = Nothing
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Private Sub griLista_DoubleClick(sender As Object, e As EventArgs) Handles griLista.DoubleClick
        Editar()
    End Sub

    Private Sub rbVehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles rbVehiculo.CheckedChanged
        If rbVehiculo.Checked Then
            ReCargarComboVehiculo()
        End If
    End Sub

    Private Sub Trabajador_CheckedChanged(sender As Object, e As EventArgs) Handles rbTrabajador.CheckedChanged
        If rbTrabajador.Checked Then
            RecargarComboTrabajador()
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        Try
            oeDocVehImg = New e_ImagenesDocumentos
            imagen = ""
            upbDocVeh.Image = Nothing
            cboTipoDocumento.SelectedIndex = 0
            cboVehiculo.SelectedIndex = 0
            cboTrabajador.SelectedIndex = -1
            Me.fecFechaVencimiento.Value = Date.Now.AddYears(1)
            fecFechaVencimiento.Enabled = True
            Me.fecFechaVigencia.Value = Date.Now
            Me.txtDescripcion.Text = String.Empty
            Me.txtNroDocumento.Text = String.Empty
            Me.rbTrabajador.Checked = False
            Me.rbVehiculo.Checked = True
            If Operacion = "Nuevo" Then
                Me.btnExaminar.Enabled = True
            Else
                Me.btnExaminar.Enabled = False
            End If
            tabControl.Tabs("tabMasivo").Enabled = True
            tabControl.Tabs("tabUnidad").Enabled = True
            listaImagenes.Clear()
            listaImagenesInd.Clear()
            Me.txtModeloFuncInd.Value = ""
            Me.txtTipoVehInd.Value = ""
            Me.txtModeloInd.Value = ""
            Me.txtMarcaINd.Value = ""

            InicializarMasivo()
            InicializarDocumentoVehiculoIgual()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarMasivo()
        Try
            oeDocVehMasivo = New e_ImagenesDocumentos
            limpiarFormMasivo()
            listaImagenesDoc = New List(Of e_ImagenesDocumentos)
            griVehiculos.DataSource = listaImagenesDoc
            griVehiculos.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarDocumentoVehiculoIgual()
        Try
            oeDocVehIgual = New e_ImagenesDocumentos
            pixImagenIgual.Image = Nothing
            cboTipoDocumentoIgual.SelectedIndex = 0
            cboVehiculoIgual.SelectedIndex = 0
            fecVencimientoIgual.Value = Date.Now.AddYears(1)
            fecVencimientoIgual.Enabled = True
            fecVigenciaIgual.Value = Date.Now
            txtDescripcionIgual.Text = String.Empty
            txtNroDocumentoIgual.Text = String.Empty
            listaImagenesIgual.Clear()
            txtModeloFuncionalIgual.Value = ""
            txtTipoVehiculoIgual.Value = ""
            txtModeloIgual.Value = ""
            txtMarcaIgual.Value = ""
            tabControl.Tabs("tabIgual").Enabled = True
            listaDocumentoIgual = New List(Of e_ImagenesDocumentos)
            gridDocumentoVehiculoIgual.DataSource = listaDocumentoIgual
            gridDocumentoVehiculoIgual.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeDocVehImg = New e_ImagenesDocumentos
            oeDocVehImg.TipoOperacion = ""
            If Me.rdbFechas.Checked Then
                oeDocVehImg.FechaCreacion = fecDesde.Value
                oeDocVehImg.FechaFin = fecHasta.Value
            End If
            If rdbDatosAdicionales.Checked Then
                oeDocVehImg.FechaCreacion = Date.Parse("01/01/1901")
                oeDocVehImg.FechaFin = Date.Parse("01/01/1901")
            End If
            oeDocVehImg.IdTipoDocumento = cboTipoDocLista.Value
            oeDocVehImg.IdVehiculo = cboVehiListar.Value
            If cboIndicadorListar.Value = "" Then
                oeDocVehImg.Identificador = ""
            Else
                oeDocVehImg.Identificador = cboIndicadorListar.Value
            End If
            griLista.DataSource = olDocVehImg.Listar(oeDocVehImg)
            For Each fila As UltraGridRow In griLista.Rows
                If fila.Cells("FechaVencimiento").Value <> "01/01/1901" Then
                    fila.CellAppearance.ForeColor = Color.Black
                    If fila.Cells("Vencimiento").Value <= 10 Then
                        fila.CellAppearance.BackColor = Me.ColoresVencido.Color
                        fila.CellAppearance.ForeColor = Color.White
                    ElseIf fila.Cells("Vencimiento").Value > 10 And fila.Cells("Vencimiento").Value <= 20 Then
                        fila.CellAppearance.BackColor = Me.ColoresPorVencer.Color
                    Else
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    End If
                End If
            Next
            If griLista.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EliminarImgDoc()
        Try
            oeDocVehImg = New e_ImagenesDocumentos
            oeDocVehImg.Id = griLista.ActiveRow.Cells("Id").Value
            'oeDocVehImg.RutaImagen = "//" & IpServidor & griLista.ActiveRow.Cells("RutaImagen").Value
            oeDocVehImg.TipoOperacion = "E"
            oeDocVehImg.UsuarioCreacion = gUsuarioSGI.Id.Trim
            If olDocVehImg.Eliminar(oeDocVehImg) Then
                'My.Computer.FileSystem.DeleteFile(oeDocVehImg.RutaImagen)
                mensajeEmergente.Confirmacion("La Informacion se ha eliminado Correctamente", True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarImgDocVeh() As Boolean
        Try
            If Me.tabControl.SelectedTab.Key = "tabUnidad" Then
                LlenarObjeto()
                ValidarDocumentoVehiculo(oeDocVehIndividual)
                Dim rutasImagenes As String = ""
                
                If griImagenesInd.Rows.Count > 0 Then
                    For i As Integer = 0 To griImagenesInd.Rows.Count - 1
                        Dim abreviaturaTipoDoc As String = TipoDocVehPublic.Where(Function(item) item.Id = Me.cboTipoDocumento.Value).ToList.Item(0).Descripcion
                        'Dim cadena As String = IIf(loVehiculo.Where(Function(item) item.Id = cboVehiculo.Value).ToList.Item(0).Descripcion = 0, "CARRETA", "TRACTO") & "\" & TipoDocVehPublic.Where(Function(item) item.Id = Me.cboTipoDocumento.Value).ToList.Item(0).Extras(0) & "-" & TipoDocVehPublic.Where(Function(item) item.Id = Me.cboTipoDocumento.Value).ToList.Item(0).Descripcion
                        Dim cadena As String = IIf(loVehiculo.Where(Function(item) item.Id = cboVehiculo.Value).ToList.Item(0).Descripcion = 0, "CARRETA", "TRACTO") & "\" & TipoDocVehPublic.Where(Function(item) item.Id = Me.cboTipoDocumento.Value).ToList.Item(0).Extras(0) & "-" & abreviaturaTipoDoc
                        'Dim fecha As String = Date.Now.Ticks ' ObtenerFechaServidor().ToShortDateString.Replace("/", "").Replace("/", "")
                        Dim fecha As String = ""
                        If cboTipoDocumento.Value.ToString() = "1CH000000051" Then
                            fecha = fecFechaVigencia.Value.ToShortDateString().Replace("/", "").Replace("/", "")
                        Else
                            fecha = fecFechaVencimiento.Value.ToShortDateString().Replace("/", "").Replace("/", "")
                        End If
                        'Dim nuevaimagen As String = cboVehiculo.Text & "_" & txtNroDocumento.Text & "_" & fecha & "_" & (i + 1) & ".jpg" 'txtNroDocumento.Text & ".jpg"
                        Dim nuevaimagen As String = cboVehiculo.Text & "_" & abreviaturaTipoDoc & "_" & fecha & "_" & Date.Now.Ticks & "_" & (i + 1) & ".jpg" 'txtNroDocumento.Text & ".jpg"
                        Dim rutacomprobacion As String = "\\" & IpServidor & "\ControlFlota\DOC " & cadena
                        If Directory.Exists(rutacomprobacion) = False Then
                            Directory.CreateDirectory(rutacomprobacion)
                        End If
                        Dim indS = listaImagenesInd.Item(griImagenesInd.Rows(i).Index).RutaImagen.LastIndexOf("\")
                        Dim img = listaImagenesInd.Item(griImagenesInd.Rows(i).Index).RutaImagen.Substring(indS, listaImagenesInd.Item(griImagenesInd.Rows(i).Index).RutaImagen.Length - indS)
                        Dim RutaImagen As String = "\\" & IpServidor & "\ControlFlota\DOC " & cadena & img
                        If griImagenesInd.Rows(i).Cells("RutaImagen").Value <> rutacomprobacion.Replace("\\" & IpServidor, "") & img Then
                            FileCopy(IIf(griImagenesInd.Rows(i).Cells("RutaImagen").Value.ToString.Contains("ControlFlota"),
                                         "\\" & IpServidor & griImagenesInd.Rows(i).Cells("RutaImagen").Value, griImagenesInd.Rows(i).Cells("RutaImagen").Value),
                                     rutacomprobacion & "\" & img)
                            oeDocVehImg.RutaImagen = "\ControlFlota\DOC " & cadena & "\" & nuevaimagen
                            Rename(RutaImagen, "\\" & IpServidor & oeDocVehImg.RutaImagen)
                        End If
                        rutasImagenes = rutasImagenes & "\ControlFlota\DOC " & cadena & "\" & nuevaimagen & "*"
                    Next
                    If rutasImagenes <> "" Then
                        oeDocVehIndividual.RutaImagen = IIf(rutasImagenes.Length > 0, rutasImagenes.Substring(0, rutasImagenes.Length - 1), rutasImagenes)
                    End If
                End If
                If olDocVehImg.Guardar(oeDocVehIndividual) Then
                    mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                    Return True
                End If
            ElseIf Me.tabControl.SelectedTab.Key = "tabMasivo" Then
                If GuardarImgDocVehMasivo() Then
                    Return True
                End If
            ElseIf Me.tabControl.SelectedTab.Key = "TabIgual" Then
                If GuardarIgual() Then
                    Return True
                End If
            End If
            Return False

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarImgDocVehMasivo() As Boolean
        Try
            Dim bol As Boolean = False
            Dim listaDocumentoConError As New List(Of e_ImagenesDocumentos)
            If griVehiculos.Rows.Count > 0 Then
                For Each obj As e_ImagenesDocumentos In listaImagenesDoc
                    If ValidarDocumentoVehiculoGuardar(obj) Then
                        listaImagenes = New List(Of e_ImagenesDocumentos)
                        Dim objI As e_ImagenesDocumentos
                        If obj.RutaImagen.Trim <> "" Then
                            Dim cant = obj.RutaImagen.Trim.Split("*").Length
                            For i As Integer = 0 To cant - 1
                                objI = New e_ImagenesDocumentos
                                objI.RutaImagen = obj.RutaImagen.Trim.Split("*")(i)
                                listaImagenes.Add(objI)
                            Next
                        End If

                        Dim rutasImagenes As String = ""
                        If listaImagenes.Count > 0 Then
                            Dim i As Integer = 0
                            For Each imagenes As e_ImagenesDocumentos In listaImagenes
                                Dim abreviaturaTipoDoc As String = TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Descripcion
                                Dim tractoCarreta As String = loVehiculo.Where(Function(item) item.Id = obj.IdVehiculo.Trim).ToList.Item(0).Nombre
                                'Dim cadena As String = IIf(loVehiculo.Where(Function(item) item.Id = obj.IdVehiculo.Trim).ToList.Item(0).Descripcion = 0, "CARRETA", "TRACTO") _
                                '                       & "\" & TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Extras(0) _
                                '                       & "-" & TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Descripcion
                                Dim cadena As String = IIf(loVehiculo.Where(Function(item) item.Id = obj.IdVehiculo.Trim).ToList.Item(0).Descripcion = 0, "CARRETA", "TRACTO") _
                                                       & "\" & TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Extras(0) _
                                                       & "-" & abreviaturaTipoDoc

                                'Dim fecha As String = Date.Now.Ticks ' ObtenerFechaServidor().ToShortDateString.Replace("/", "").Replace("/", "")
                                Dim fecha As String = ""
                                If obj.IdTipoDocumento = "1CH000000051" Then
                                    fecha = dtpVigencia.Value.ToShortDateString().Replace("/", "").Replace("/", "")
                                Else
                                    fecha = dtpVencimiento.Value.ToShortDateString().Replace("/", "").Replace("/", "")
                                End If
                                'Dim nuevaimagen As String = cboVehiculo.Text & "_" & txtNroDocumento.Text & "_" & fecha & "_" & (i + 1) & ".jpg" 'txtNroDocumento.Text & ".jpg"
                                Dim nuevaimagen As String = tractoCarreta & "_" & abreviaturaTipoDoc & "_" & fecha & "_" & Date.Now.Ticks & "_" & (i + 1) & ".jpg" 'txtNroDocumento.Text & ".jpg"

                                'Dim fecha As String = Date.Now.Ticks
                                'Dim nuevaimagen As String = cboVehiculoMasivo.Text & "_" & obj.NroDocumento.Trim & "_" & fecha & "_" & (i + 1) & ".jpg"
                                Dim rutacomprobacion As String = "\\" & IpServidor & "\ControlFlota\DOC " & cadena
                                If Directory.Exists(rutacomprobacion) = False Then
                                    Directory.CreateDirectory(rutacomprobacion)
                                End If
                                Dim indS = imagenes.RutaImagen.LastIndexOf("\")
                                Dim img = imagenes.RutaImagen.Substring(indS, imagenes.RutaImagen.Length - indS)
                                Dim RutaImagen As String = "\\" & IpServidor & "\ControlFlota\DOC " & cadena & img

                                If imagenes.RutaImagen.Trim <> rutacomprobacion.Replace("\\" & IpServidor, "") & img Then
                                    FileCopy(IIf(imagenes.RutaImagen.Trim.Contains("ControlFlota"),
                                                 "\\" & IpServidor & imagenes.RutaImagen.Trim, imagenes.RutaImagen.Trim),
                                             rutacomprobacion & "\" & img)
                                    obj.RutaImagen = "\ControlFlota\DOC " & cadena & "\" & nuevaimagen
                                    Rename(RutaImagen, "\\" & IpServidor & obj.RutaImagen)

                                    rutasImagenes = rutasImagenes & "\ControlFlota\DOC " & cadena & "\" & nuevaimagen & "*"
                                Else
                                    rutasImagenes = rutasImagenes & imagenes.RutaImagen.Trim & "*"
                                End If

                                i = i + 1
                            Next

                            If rutasImagenes <> "" Then
                                obj.RutaImagen = IIf(rutasImagenes.Length > 0, rutasImagenes.Substring(0, rutasImagenes.Length - 1), rutasImagenes)
                            End If
                        End If
                        bol = olDocVehImg.Guardar(obj)
                        If Not bol Then
                            listaDocumentoConError.Add(obj)
                        End If
                    Else
                        listaDocumentoConError.Add(obj)
                    End If
                Next
            End If
            If listaDocumentoConError.Count = 0 Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                Return True
            Else
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                Select Case MessageBox.Show("Existen Registros No Guardados, Desea Visualizarlos?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        listaImagenesDoc = listaDocumentoConError
                        griVehiculos.DataSource = listaImagenesDoc
                        griVehiculos.DataBind()
                        GrigDocumentoMasivoMarcar()
                        Return False
                    Case Windows.Forms.DialogResult.No
                        Return True
                    Case Windows.Forms.DialogResult.Cancel
                End Select
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarIgual() As Boolean
        Try
            Dim bol As Boolean = False
            Dim listaDocumentoConError As New List(Of e_ImagenesDocumentos)
            If gridDocumentoVehiculoIgual.Rows.Count > 0 Then
                For Each obj As e_ImagenesDocumentos In listaDocumentoIgual
                    If ValidarDocumentoVehiculoGuardar(obj) Then
                        listaImagenesIgual = New List(Of e_ImagenesDocumentos)
                        Dim objI As e_ImagenesDocumentos
                        If obj.RutaImagen.Trim <> "" Then
                            Dim cant = obj.RutaImagen.Trim.Split("*").Length
                            For i As Integer = 0 To cant - 1
                                objI = New e_ImagenesDocumentos
                                objI.RutaImagen = obj.RutaImagen.Trim.Split("*")(i)
                                listaImagenesIgual.Add(objI)
                            Next
                        End If

                        Dim rutasImagenes As String = ""
                        If listaImagenesIgual.Count > 0 Then
                            Dim i As Integer = 0
                            For Each imagenes As e_ImagenesDocumentos In listaImagenesIgual
                                Dim abreviaturaTipoDoc As String = TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Descripcion
                                Dim tractoCarreta As String = loVehiculo.Where(Function(item) item.Id = obj.IdVehiculo.Trim).ToList.Item(0).Nombre
                                'Dim cadena As String = IIf(loVehiculo.Where(Function(item) item.Id = obj.IdVehiculo.Trim).ToList.Item(0).Descripcion = 0, "CARRETA", "TRACTO") _
                                '                       & "\" & TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Extras(0) _
                                '                       & "-" & TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Descripcion
                                Dim cadena As String = IIf(loVehiculo.Where(Function(item) item.Id = obj.IdVehiculo.Trim).ToList.Item(0).Descripcion = 0, "CARRETA", "TRACTO") _
                                                       & "\" & TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Extras(0) _
                                                       & "-" & abreviaturaTipoDoc

                                'Dim fecha As String = Date.Now.Ticks ' ObtenerFechaServidor().ToShortDateString.Replace("/", "").Replace("/", "")
                                Dim fecha As String = ""
                                If obj.IdTipoDocumento = "1CH000000051" Then
                                    fecha = dtpVigencia.Value.ToShortDateString().Replace("/", "").Replace("/", "")
                                Else
                                    fecha = dtpVencimiento.Value.ToShortDateString().Replace("/", "").Replace("/", "")
                                End If
                                'Dim nuevaimagen As String = cboVehiculo.Text & "_" & txtNroDocumento.Text & "_" & fecha & "_" & (i + 1) & ".jpg" 'txtNroDocumento.Text & ".jpg"
                                Dim nuevaimagen As String = tractoCarreta & "_" & abreviaturaTipoDoc & "_" & fecha & "_" & Date.Now.Ticks & "_" & (i + 1) & ".jpg" 'txtNroDocumento.Text & ".jpg"


                                'Dim cadena As String = IIf(loVehiculo.Where(Function(item) item.Id = obj.IdVehiculo.Trim).ToList.Item(0).Descripcion = 0, "CARRETA", "TRACTO") _
                                '                       & "\" & TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Extras(0) _
                                '                       & "-" & TipoDocVehPublic.Where(Function(item) item.Id = obj.IdTipoDocumento.Trim).ToList.Item(0).Descripcion

                                'Dim fecha As String = Date.Now.Ticks
                                'Dim nuevaimagen As String = cboVehiculoMasivo.Text & "_" & obj.NroDocumento.Trim & "_" & fecha & "_" & (i + 1) & ".jpg"
                                Dim rutacomprobacion As String = "\\" & IpServidor & "\ControlFlota\DOC " & cadena
                                If Directory.Exists(rutacomprobacion) = False Then
                                    Directory.CreateDirectory(rutacomprobacion)
                                End If
                                Dim indS = imagenes.RutaImagen.LastIndexOf("\")
                                Dim img = imagenes.RutaImagen.Substring(indS, imagenes.RutaImagen.Length - indS)
                                Dim RutaImagen As String = "\\" & IpServidor & "\ControlFlota\DOC " & cadena & img

                                If imagenes.RutaImagen.Trim <> rutacomprobacion.Replace("\\" & IpServidor, "") & img Then
                                    FileCopy(IIf(imagenes.RutaImagen.Trim.Contains("ControlFlota"),
                                                 "\\" & IpServidor & imagenes.RutaImagen.Trim, imagenes.RutaImagen.Trim),
                                             rutacomprobacion & "\" & img)
                                    obj.RutaImagen = "\ControlFlota\DOC " & cadena & "\" & nuevaimagen
                                    Rename(RutaImagen, "\\" & IpServidor & obj.RutaImagen)

                                    rutasImagenes = rutasImagenes & "\ControlFlota\DOC " & cadena & "\" & nuevaimagen & "*"
                                Else
                                    rutasImagenes = rutasImagenes & imagenes.RutaImagen.Trim & "*"
                                End If

                                i = i + 1
                            Next

                            If rutasImagenes <> "" Then
                                obj.RutaImagen = IIf(rutasImagenes.Length > 0, rutasImagenes.Substring(0, rutasImagenes.Length - 1), rutasImagenes)
                            End If
                        End If
                        bol = olDocVehImg.Guardar(obj)
                        If Not bol Then
                            listaDocumentoConError.Add(obj)
                        End If
                    Else
                        listaDocumentoConError.Add(obj)
                    End If
                Next
            End If
            If listaDocumentoConError.Count = 0 Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                Return True
            Else
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                Select Case MessageBox.Show("Existen Registros No Guardados, Desea Visualizarlos?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        listaDocumentoIgual = listaDocumentoConError
                        gridDocumentoVehiculoIgual.DataSource = listaDocumentoIgual
                        gridDocumentoVehiculoIgual.DataBind()
                        GrigDocumentoIgualMarcar()
                        Return False
                    Case Windows.Forms.DialogResult.No
                        Return True
                    Case Windows.Forms.DialogResult.Cancel
                End Select
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarCombos()
        Dim ListaCombo As New List(Of e_Combo)
        Dim oeCombo As New e_Combo
        Dim olCombo As New l_Combo

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        ListaCombo.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Vehiculo"
        loVehiculo.AddRange(olCombo.Listar(oeCombo))
        ListaCombo.AddRange(loVehiculo)
        LlenarCombo(cboVehiListar, "Nombre", ListaCombo, 0)

        ListaCombo = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        ListaCombo.Add(oeCombo)
        ListaCombo.AddRange(TipoDocVehPublic)
        LlenarCombo(Me.cboTipoDocLista, "Nombre", ListaCombo, 0)

        LlenarCombo(cboVehiculo, "Nombre", loVehiculo, 0)
        LlenarCombo(Me.cboVehiculoMasivo, "Nombre", loVehiculo, 0)
        LlenarCombo(Me.cboVehiculoIgual, "Nombre", loVehiculo, 0)
        LlenarCombo(cboTrabajador, "Nombre", TrabajadorPublic, -1)

        ListaCombo = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        ListaCombo.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Id = "1"
        oeCombo.Nombre = "SI"
        ListaCombo.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Id = "0"
        oeCombo.Nombre = "NO"
        ListaCombo.Add(oeCombo)
        LlenarCombo(cboIndicadorListar, "Nombre", ListaCombo, 0)

        CrearComboGrid("IdVehiculo", "Nombre", griVehiculos, olCombo.ComboGrilla(loVehiculo), True)
        CrearComboGrid("IdTipoDocumento", "Nombre", griVehiculos, olCombo.ComboGrilla(TipoDocVehPublic), True)

        CrearComboGrid("IdVehiculo", "Nombre", gridDocumentoVehiculoIgual, olCombo.ComboGrilla(loVehiculo), True)
        CrearComboGrid("IdTipoDocumento", "Nombre", gridDocumentoVehiculoIgual, olCombo.ComboGrilla(TipoDocVehPublic), True)

    End Sub

    Private Sub LlenarObjeto()
        Try
            oeDocVehIndividual = New e_ImagenesDocumentos
            With oeDocVehIndividual
                If rbTrabajador.Checked = False And rbVehiculo.Checked = False Then
                    Throw New Exception("Debe Seleccionar Vehiculo o Trabajador")
                End If
                If Operacion = "Nuevo" Then
                    .TipoOperacion = "I"
                Else
                    .TipoOperacion = "A"
                End If
                If rbTrabajador.Checked Then
                    .IdTrabajador = cboTrabajador.Value
                Else
                    .IdTrabajador = ""
                End If
                If rbVehiculo.Checked Then
                    .IdVehiculo = IIf(cboVehiculo.Value = Nothing, "", cboVehiculo.Value)
                Else
                    .IdVehiculo = ""
                End If
                .IdTipoDocumento = IIf(cboTipoDocumento.Value = Nothing, "", cboTipoDocumento.Value)
                .NroDocumento = Me.txtNroDocumento.Text
                .Descripcion = Me.txtDescripcion.Text
                .UsuarioCreacion = gUsuarioSGI.Id
                If .IdTipoDocumento = "1CH000000051" Then
                    .FechaVencimiento = Now.AddYears(10)
                Else
                    .FechaVencimiento = Me.fecFechaVencimiento.Value
                End If

                .FechaVigencia = Me.fecFechaVigencia.Value
                '.IndVigente = chkVigenteIndividual.Checked
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ValidarDocumentoVehiculo(ByVal obj As e_ImagenesDocumentos)
        Try
            If obj.IdTipoDocumento.Trim = "" Then Throw New Exception("Debe Seleccionar Tipo Documento")
            If obj.IdVehiculo.Trim = "" Then Throw New Exception("Debe Seleccionar Vehículo")
            'If obj.NroDocumento.Trim = "" Then Throw New Exception("Debe Ingresar Nro Documento")
            If obj.FechaVencimiento.Date <= obj.FechaVigencia.Date Then Throw New Exception("Fecha Vencimiento Debe Ser Mayor A Fecha Vigencia")

            'Dim objListar As New e_ImagenesDocumentos
            'Dim Listaobj As New List(Of e_ImagenesDocumentos)
            'Dim Id As String = obj.Id.ToString.Trim()
            'objListar.TipoOperacion = ""
            'objListar.Id = ""
            'objListar.IdTipoDocumento = obj.IdTipoDocumento.Trim
            'objListar.NroDocumento = obj.NroDocumento.Trim
            'Listaobj = olDocVehImg.Listar(objListar)
            'If Id = "" Then
            '    If Listaobj.Count > 0 Then Throw New Exception("Número Documento Ya Existe.")
            'Else
            '    Dim resultado = Listaobj.Where(Function(x) x.Id.Trim <> Id.Trim)
            '    If resultado.Count > 0 Then Throw New Exception("Número Documento Ya Existe.")
            'End If

            'Listaobj = New List(Of e_ImagenesDocumentos)
            'objListar = New e_ImagenesDocumentos
            'objListar.TipoOperacion = ""
            'objListar.Id = ""
            'objListar.IdTipoDocumento = obj.IdTipoDocumento.Trim
            'objListar.IdVehiculo = obj.IdVehiculo.Trim
            'Listaobj = olDocVehImg.Listar(objListar)
            'If Listaobj.Count = 0 Then Return
            'If Id = "" Then
            '    Dim resultado = Listaobj.OrderByDescending(Function(x) x.FechaVencimiento)
            '    If resultado(0).FechaVencimiento.Date > obj.FechaVigencia.Date Then Throw New Exception("Vehículo Tiene Documento N°: " + resultado(0).NroDocumento.Trim + " Con La FechaVencimiento " + resultado(0).FechaVencimiento.Date + ", Debe Seleccionar FechaVigencia Mayor A " + resultado(0).FechaVencimiento.Date)
            'Else
            '    Dim resultado = Listaobj.Where(Function(x) x.Id.Trim <> Id.Trim).OrderByDescending(Function(y) y.FechaVencimiento)
            '    If resultado.Count = 0 Then Return
            '    If resultado(0).FechaVencimiento.Date > obj.FechaVigencia.Date Then Throw New Exception("Vehículo Tiene Documento N°: " + resultado(0).NroDocumento.Trim + " Con La FechaVencimiento " + resultado(0).FechaVencimiento.Date + ", Debe Seleccionar FechaVigencia Mayor A " + resultado(0).FechaVencimiento.Date)
            'End If



            'Dim objListar As New e_ImagenesDocumentos
            'Dim Listaobj As New List(Of e_ImagenesDocumentos)
            'objListar.TipoOperacion = ""
            'objListar.Id = ""
            'objListar.IdTipoDocumento = obj.IdTipoDocumento.Trim
            'Listaobj = olDocVehImg.Listar(objListar)
            'If obj.Id = "" Then
            '    Dim resultado = Listaobj.Where(Function(x) x.NroDocumento.Trim = obj.NroDocumento.Trim And x.IdTipoDocumento.Trim = obj.IdTipoDocumento.Trim)
            '    If resultado.Count > 0 Then Throw New Exception("Número Documento Ya Existe.")
            'Else
            '    Dim resultado = Listaobj.Where(Function(x) x.NroDocumento.Trim = obj.NroDocumento.Trim And x.Id.Trim <> obj.Id.Trim And x.IdTipoDocumento.Trim = obj.IdTipoDocumento.Trim)
            '    If resultado.Count > 0 Then Throw New Exception("Número Documento Ya Existe.")
            'End If
        Catch ex As Exception
            Throw ex
        End Try





    End Sub

    Private Function ValidarDocumentoVehiculoGuardar(ByVal obj As e_ImagenesDocumentos) As Boolean
        Try
            If obj.IdTipoDocumento.Trim = "" Then Throw New Exception("Debe Seleccionar Tipo Documento")
            If obj.IdVehiculo.Trim = "" Then Throw New Exception("Debe Seleccionar Vehículo")

            Dim IdTipoDocumento As String = ""
            Dim TipoDocumento As String = obj.IdTipoDocumento.Trim
            Dim listaD = TipoDocVehPublic.Where(Function(x) x.Id = TipoDocumento.Trim)
            If listaD.Count = 0 Then Throw New Exception("Debe Seleccionar Tipo Documento")

            Dim IdVehiculo As String = ""
            Dim Vehiculo As String = obj.IdVehiculo.Trim
            Dim listaV = loVehiculo.Where(Function(x) x.Id = Vehiculo.Trim)
            If listaV.Count = 0 Then Throw New Exception("Debe Seleccionar Vehículo")

            ValidarDocumentoVehiculo(obj)

            'If obj.NroDocumento.Trim = "" Then Throw New Exception("Debe Ingresar Nro Documento")
            'If obj.FechaVencimiento.Date <= obj.FechaVigencia.Date Then Throw New Exception("Fecha Vencimiento Debe Ser Mayor A Fecha Vigencia")
            'Dim objListar As New e_ImagenesDocumentos
            'Dim Listaobj As New List(Of e_ImagenesDocumentos)
            'objListar.TipoOperacion = ""
            'objListar.Id = ""
            'objListar.IdTipoDocumento = obj.IdTipoDocumento.Trim
            'Listaobj = olDocVehImg.Listar(objListar)
            'If obj.Id = "" Then
            '    Dim resultado = Listaobj.Where(Function(x) x.NroDocumento.Trim = obj.NroDocumento.Trim And x.IdTipoDocumento.Trim = obj.IdTipoDocumento.Trim)
            '    If resultado.Count > 0 Then Throw New Exception("Número Documento Ya Existe.")
            'Else
            '    Dim resultado = Listaobj.Where(Function(x) x.NroDocumento.Trim = obj.NroDocumento.Trim And x.Id.Trim <> obj.Id.Trim And x.IdTipoDocumento.Trim = obj.IdTipoDocumento.Trim)
            '    If resultado.Count > 0 Then Throw New Exception("Número Documento Ya Existe.")
            'End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub limpiarFormMasivo()
        cboVehiculoMasivo.SelectedIndex = 0
        '   cboTipoDocMasivo.SelectedIndex = -1
        Me.txtNroDocumentoMasivo.Text = ""
        Me.txtDescripcionMasivo.Text = ""
        'Me.txtRutaMasivo.Text = ""
        upbImagenMasivo.Image = Nothing
        Me.txtVencimientoMasivo.Value = 0
        Me.txtModeloFuncional.Value = ""
        Me.txtTipoVehMasivo.Value = ""
        Me.txtModelo.Value = ""
        Me.txtMarca.Value = ""
        dtpVencimiento.Value = Date.Now.AddYears(1)
        dtpVencimiento.Enabled = True
        dtpVigencia.Value = Date.Now
        listaImagenes.Clear()
        griImagenes.DataBind()
        griImagenes.UpdateData()
    End Sub

    Private Sub limpiarFormIgual()
        cboVehiculoIgual.SelectedIndex = 0
        txtNroDocumentoIgual.Text = ""
        pixImagenIgual.Image = Nothing
        txtModeloFuncionalIgual.Value = ""
        txtTipoVehiculoIgual.Value = ""
        txtModeloIgual.Value = ""
        txtMarcaIgual.Value = ""
        listaImagenesIgual.Clear()
        gridImagenesIgual.DataBind()
        gridImagenesIgual.UpdateData()
    End Sub

    Dim indiceVehMasivo As String = ""
    Private Sub LlenarObjetoMasivo()
        Try
            If oeDocVehMasivo.Identificador = "" Then oeDocVehMasivo.Identificador = Date.Now.Ticks
            With oeDocVehMasivo
                .TipoOperacion = "I"
                .IdTrabajador = ""
                .IdVehiculo = IIf(cboVehiculoMasivo.Value = Nothing, "", cboVehiculoMasivo.Value)
                .IdTipoDocumento = IIf(cboTipoDocMasivo.Value = Nothing, "", cboTipoDocMasivo.Value)
                .TipoDocumento = cboTipoDocMasivo.Text.Trim
                .NroDocumento = Me.txtNroDocumentoMasivo.Text
                .Descripcion = Me.txtDescripcionMasivo.Text
                .UsuarioCreacion = gUsuarioSGI.Id
                If .IdTipoDocumento = "1CH000000051" Then
                    .FechaVencimiento = Now.AddYears(10)
                Else
                    .FechaVencimiento = Me.dtpVencimiento.Value
                End If
                .FechaVigencia = Me.dtpVigencia.Value
                .IndVigente = Me.chkVigente.Checked
            End With
            Dim rutasImagenes As String = ""
            If griImagenes.Rows.Count > 0 Then
                For i As Integer = 0 To griImagenes.Rows.Count - 1
                    rutasImagenes = rutasImagenes & griImagenes.Rows(i).Cells("RutaImagen").Value.ToString.Trim & "*"
                Next
                If rutasImagenes <> "" Then
                    oeDocVehMasivo.RutaImagen = IIf(rutasImagenes.Length > 0, rutasImagenes.Substring(0, rutasImagenes.Length - 1), rutasImagenes)
                End If
            Else
                oeDocVehMasivo.RutaImagen = rutasImagenes
            End If

            'Dim lista As New List(Of e_DocumentoVehiculoDetalle)
            'Dim oeDetalle As e_DocumentoVehiculoDetalle
            'If chkTodosClienteMasivo.Checked Then
            '    oeDetalle = New e_DocumentoVehiculoDetalle
            '    oeDetalle.TipoOperacion = "I"
            '    oeDetalle.IdTipoDocumento = oeDocVehMasivo.IdTipoDocumento
            '    oeDetalle.IdDocumento = oeDocVehMasivo.Id
            '    oeDetalle.IndTodosCliente = chkTodosClienteMasivo.Checked
            '    oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
            '    lista.Add(oeDetalle)
            'Else
            '    For Each fila In gridClientesMasivo.Rows
            '        If fila.Cells("Select").Value Then
            '            oeDetalle = New e_DocumentoVehiculoDetalle
            '            oeDetalle.TipoOperacion = "I"
            '            oeDetalle.IdCliente = fila.Cells("Id").Value
            '            oeDetalle.IndTodosCliente = False
            '            oeDetalle.IdDocumento = oeDocVehMasivo.Id
            '            oeDetalle.IdTipoDocumento = oeDocVehMasivo.IdTipoDocumento
            '            oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
            '            lista.Add(oeDetalle)
            '        End If
            '    Next

            'End If
            'If chkTodosMaterialMasivo.Checked Then
            '    oeDetalle = New e_DocumentoVehiculoDetalle
            '    oeDetalle.TipoOperacion = "I"
            '    oeDetalle.IdTipoDocumento = oeDocVehMasivo.IdTipoDocumento
            '    oeDetalle.IdDocumento = oeDocVehMasivo.Id
            '    oeDetalle.IndTodosMaterial = chkTodosMaterialMasivo.Checked
            '    oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
            '    lista.Add(oeDetalle)
            'Else
            '    For Each fila In gridMaterialesMasivo.Rows
            '        If fila.Cells("Select").Value Then
            '            oeDetalle = New e_DocumentoVehiculoDetalle
            '            oeDetalle.TipoOperacion = "I"
            '            oeDetalle.IdMaterial = fila.Cells("Id").Value
            '            oeDetalle.IndTodosMaterial = chkTodosMaterialMasivo.Checked
            '            oeDetalle.IdTipoDocumento = oeDocVehMasivo.IdTipoDocumento
            '            oeDetalle.IdDocumento = oeDocVehMasivo.Id
            '            oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
            '            lista.Add(oeDetalle)
            '        End If
            '    Next
            'End If
            'oeDocVehMasivo.ListaDetalle = lista
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarObjetoIgual()
        Try
            If oeDocVehIgual.Identificador = "" Then oeDocVehIgual.Identificador = Date.Now.Ticks
            With oeDocVehIgual
                .TipoOperacion = "I"
                .IdTrabajador = ""
                .IdVehiculo = IIf(cboVehiculoIgual.Value = Nothing, "", cboVehiculoIgual.Value)
                .IdTipoDocumento = IIf(cboTipoDocumentoIgual.Value = Nothing, "", cboTipoDocumentoIgual.Value)
                .TipoDocumento = cboTipoDocumentoIgual.Text.Trim
                .NroDocumento = Me.txtNroDocumentoIgual.Text
                .Descripcion = Me.txtDescripcionIgual.Text
                .UsuarioCreacion = gUsuarioSGI.Id
                If .IdTipoDocumento = "1CH000000051" Then
                    .FechaVencimiento = Now.AddYears(10)
                Else
                    .FechaVencimiento = fecVencimientoIgual.Value
                End If
                .FechaVigencia = fecVigenciaIgual.Value
            End With
            Dim rutasImagenes As String = ""
            If gridImagenesIgual.Rows.Count > 0 Then
                For i As Integer = 0 To gridImagenesIgual.Rows.Count - 1
                    rutasImagenes = rutasImagenes & gridImagenesIgual.Rows(i).Cells("RutaImagen").Value.ToString.Trim & "*"
                Next
                If rutasImagenes <> "" Then
                    oeDocVehIgual.RutaImagen = IIf(rutasImagenes.Length > 0, rutasImagenes.Substring(0, rutasImagenes.Length - 1), rutasImagenes)
                End If
            Else
                oeDocVehIgual.RutaImagen = ""
            End If

            'Dim lista As New List(Of e_DocumentoVehiculoDetalle)
            'Dim oeDetalle As e_DocumentoVehiculoDetalle
            'If chkTodosClienteIgual.Checked Then
            '    oeDetalle = New e_DocumentoVehiculoDetalle
            '    oeDetalle.TipoOperacion = "I"
            '    oeDetalle.IdTipoDocumento = oeDocVehIgual.IdTipoDocumento
            '    oeDetalle.IdDocumento = oeDocVehIgual.Id
            '    oeDetalle.IndTodosCliente = chkTodosClienteIgual.Checked
            '    oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
            '    lista.Add(oeDetalle)
            'Else
            '    For Each fila In gridClientesIgual.Rows
            '        If fila.Cells("Select").Value Then
            '            oeDetalle = New e_DocumentoVehiculoDetalle
            '            oeDetalle.TipoOperacion = "I"
            '            oeDetalle.IdCliente = fila.Cells("Id").Value
            '            oeDetalle.IndTodosCliente = False
            '            oeDetalle.IdDocumento = oeDocVehIgual.Id
            '            oeDetalle.IdTipoDocumento = oeDocVehIgual.IdTipoDocumento
            '            oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
            '            lista.Add(oeDetalle)
            '        End If
            '    Next

            'End If
            'If chkTodosMaterialIgual.Checked Then
            '    oeDetalle = New e_DocumentoVehiculoDetalle
            '    oeDetalle.TipoOperacion = "I"
            '    oeDetalle.IdTipoDocumento = oeDocVehIgual.IdTipoDocumento
            '    oeDetalle.IdDocumento = oeDocVehIgual.Id
            '    oeDetalle.IndTodosMaterial = chkTodosMaterialIgual.Checked
            '    oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
            '    lista.Add(oeDetalle)
            'Else
            '    For Each fila In gridMaterialesIgual.Rows
            '        If fila.Cells("Select").Value Then
            '            oeDetalle = New e_DocumentoVehiculoDetalle
            '            oeDetalle.TipoOperacion = "I"
            '            oeDetalle.IdMaterial = fila.Cells("Id").Value
            '            oeDetalle.IndTodosMaterial = chkTodosMaterialIgual.Checked
            '            oeDetalle.IdTipoDocumento = oeDocVehIgual.IdTipoDocumento
            '            oeDetalle.IdDocumento = oeDocVehIgual.Id
            '            oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
            '            lista.Add(oeDetalle)
            '        End If
            '    Next
            'End If
            'oeDocVehIgual.ListaDetalle = lista
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ReemplazarDocVeh(ByVal obj As e_ImagenesDocumentos)
        Try
            Dim i As Integer = 0
            For Each imagen As e_ImagenesDocumentos In listaImagenesDoc
                If Operacion = "Nuevo" Then
                    If idDV = i Then
                        listaImagenesDoc.Item(i) = obj
                        Exit For
                    End If
                Else
                    If imagen.Id = obj.Id Then
                        listaImagenesDoc.Item(i) = obj
                        Exit For
                    End If
                End If

                i = i + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ReCargarComboVehiculo()
        Me.cboTrabajador.Enabled = False
        Me.cboTrabajador.SelectedIndex = -1
        Me.cboVehiculo.Enabled = True
        Me.cboTipoDocumento.DataSource = Nothing
        LlenarCombo(Me.cboTipoDocumento, "Nombre", TipoDocVehPublic, 0)
        LlenarCombo(Me.cboTipoDocMasivo, "Nombre", TipoDocVehPublic, 0)
        LlenarCombo(Me.cboTipoDocumentoIgual, "Nombre", TipoDocVehPublic, 0)
    End Sub

    Private Sub RecargarComboTrabajador()
        Me.cboTrabajador.Enabled = True
        Me.cboVehiculo.Enabled = False
        Me.cboVehiculo.SelectedIndex = 0
        Me.cboTipoDocumento.DataSource = Nothing
        LlenarCombo(Me.cboTipoDocumento, "Nombre", TipoDocTrabPublic, 0)
    End Sub

    Private Sub CambiarVigencia()
        Try
            oeDocVehImg = New e_ImagenesDocumentos
            olDocVehImg = New l_ImagenesDocumentos
            oeDocVehImg.Id = griLista.ActiveRow.Cells("Id").Value
            oeDocVehImg.UsuarioCreacion = gUsuarioSGI.Id.Trim
            oeDocVehImg.IdTipoDocumento = griLista.ActiveRow.Cells("IdTipoDocumento").Value
            oeDocVehImg.IdVehiculo = griLista.ActiveRow.Cells("IdVehiculo").Value
            oeDocVehImg.FechaVencimiento = griLista.ActiveRow.Cells("FechaVencimiento").Value
            oeDocVehImg.FechaVigencia = griLista.ActiveRow.Cells("FechaVigencia").Value
            oeDocVehImg.TipoOperacion = "V"
            If olDocVehImg.Guardar(oeDocVehImg) Then
                mensajeEmergente.Confirmacion("El Documento ha Cambiado de Vigencia Correctamente", True)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub ContextMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenu1.Opening
        If griLista.Selected.Rows.Count > 0 Then
            ContextMenu1.Items("ToolStripMenuEditar").Enabled = True
            ContextMenu1.Items("ToolStripMenuEliminar").Enabled = True
            ContextMenu1.Items("ToolStripMenuVigencia").Enabled = True
        End If
    End Sub

    Private Sub ToolStripMenuNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuNuevo.Click
        Nuevo()
    End Sub

    Private Sub ToolStripMenuEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuEditar.Click
        Editar()
    End Sub

    Private Sub ToolStripMenuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuEliminar.Click
        Eliminar()
    End Sub

    Private Sub ToolStripMenuVigencia_Click(sender As Object, e As EventArgs) Handles ToolStripMenuVigencia.Click
        CambiarVigencia()
    End Sub

#End Region

    Private Sub btnAgregarMasivo_Click(sender As Object, e As EventArgs) Handles btnAgregarMasivo.Click
        Try
            LlenarObjetoMasivo()
            ValidarDocumentoVehiculo(oeDocVehMasivo)
            If Not listaImagenesDoc.Contains(oeDocVehMasivo) Then
                listaImagenesDoc.Add(oeDocVehMasivo)
            Else
                listaImagenesDoc.Item(listaImagenesDoc.IndexOf(oeDocVehMasivo)) = oeDocVehMasivo
            End If
            griVehiculos.DataBind()
            GrigDocumentoMasivoMarcar()
            oeDocVehMasivo = New e_ImagenesDocumentos
            limpiarFormMasivo()
            cboTipoDocMasivo.Focus()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub ValidarTipoDocVigencia()
        Try
            'listar todos           
            Dim oeDocVehImg As New e_ImagenesDocumentos
            oeDocVehImg.FechaCreacion = Date.Parse("01/01/1901")
            oeDocVehImg.FechaFin = Date.Parse("01/01/1901")
            oeDocVehImg.IdTipoDocumento = ""
            oeDocVehImg.IdVehiculo = cboVehiListar.Value
            oeDocVehImg.IndVigente = False
            Dim lista As List(Of e_ImagenesDocumentos) = olDocVehImg.Listar(oeDocVehImg)
            Dim cont As Integer = 0
            For Each obj As e_ImagenesDocumentos In lista
                If obj.IdTipoDocumento = Me.cboTipoDocMasivo.Value And
                    obj.IndVigente = Me.chkVigente.Checked And
                    obj.IdVehiculo = Me.cboVehiculoMasivo.Value Then
                    If Operacion = "Nuevo" Then
                        Throw New Exception("Ya se inserto ese tipo de documento a este vehiculo")
                    End If
                    If Operacion = "Editar" Then
                        cont = cont + 1
                        If cont = 2 Then
                            Throw New Exception("Ya se inserto ese tipo de documento a este vehiculo")
                        End If
                    End If

                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarVeh(ByVal id As String)
        Try
            'Inicializar()
            limpiarFormMasivo()
            oeDocVehImg.Id = IIf(Operacion = "Nuevo", "", id)
            idDV = id
            oeDocVehImg = listaImagenesDoc.Item(griVehiculos.ActiveRow.Index) 'olDocVehImg.Obtener(oeDocVehImg)
            With oeDocVehImg
                Me.cboVehiculoMasivo.Value = .IdVehiculo
                Me.cboTipoDocMasivo.Value = .IdTipoDocumento

                Me.txtNroDocumentoMasivo.Text = .NroDocumento
                Me.txtDescripcionMasivo.Text = .Descripcion
                Me.dtpVencimiento.Value = .FechaVencimiento
                Me.dtpVigencia.Value = .FechaVigencia
                Me.txtVencimientoMasivo.Value = .Vencimiento
                Me.chkVigente.Checked = .IndVigente
                If Me.dtpVencimiento.Value <> "01/01/1901" Then
                    If Me.txtVencimientoMasivo.Value < 0 Then
                        Me.txtVencimientoMasivo.Appearance.BackColor = Me.ColoresVencido.Color
                        Me.txtVencimientoMasivo.Appearance.ForeColor = Color.White
                    ElseIf Me.txtVencimientoMasivo.Value >= 0 And Me.txtVencimientoMasivo.Value <= 60 Then
                        Me.txtVencimientoMasivo.Appearance.BackColor = Me.ColoresPorVencer.Color
                    Else
                        Me.txtVencimientoMasivo.Appearance.BackColor = Me.ColoresGenerado.Color
                    End If
                End If
                listaImagenes = New List(Of e_ImagenesDocumentos)
                ' listaImagenes = .RutaImagen.Split("*").ToList()
                If .RutaImagen <> "" Then
                    LlenarListaImagenes(.RutaImagen)
                Else
                    '  LlenarListaImagenes(griVehiculos.ActiveRow.Cells("RutaImagen").Value)
                    'Me.btnExaminarMasivo.Enabled = True
                End If
                griImagenes.DataSource = listaImagenes
                griImagenes.UpdateData()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarVeh()
        Try
            With oeDocVehMasivo
                cboVehiculoMasivo.Value = .IdVehiculo
                cboTipoDocMasivo.Value = .IdTipoDocumento
                dtpVigencia.Value = .FechaVigencia
                txtNroDocumentoMasivo.Text = .NroDocumento
                txtDescripcionMasivo.Text = .Descripcion
                dtpVencimiento.Value = .FechaVencimiento
                txtVencimientoMasivo.Value = .Vencimiento
                chkVigente.Checked = .IndVigente
                If Me.dtpVencimiento.Value <> "01/01/1901" Then
                    If Me.txtVencimientoMasivo.Value < 0 Then
                        txtVencimientoMasivo.Appearance.BackColor = Me.ColoresVencido.Color
                        txtVencimientoMasivo.Appearance.ForeColor = Color.White
                    ElseIf Me.txtVencimientoMasivo.Value >= 0 And Me.txtVencimientoMasivo.Value <= 60 Then
                        txtVencimientoMasivo.Appearance.BackColor = Me.ColoresPorVencer.Color
                    Else
                        txtVencimientoMasivo.Appearance.BackColor = Me.ColoresGenerado.Color
                    End If
                End If
                listaImagenes = New List(Of e_ImagenesDocumentos)
                If .RutaImagen <> "" Then
                    LlenarListaImagenes(.RutaImagen)
                Else
                    '  LlenarListaImagenes(griVehiculos.ActiveRow.Cells("RutaImagen").Value)
                    'Me.btnExaminarMasivo.Enabled = True
                End If
                griImagenes.DataSource = listaImagenes
                griImagenes.UpdateData()

                If cboTipoDocMasivo.Value = "1CH000000051" Then
                    dtpVencimiento.Enabled = False
                Else
                    dtpVencimiento.Enabled = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarIgual()
        Try
            With oeDocVehIgual
                cboVehiculoIgual.Value = .IdVehiculo
                cboTipoDocumentoIgual.Value = .IdTipoDocumento

                txtNroDocumentoIgual.Text = .NroDocumento
                txtDescripcionIgual.Text = .Descripcion
                fecVencimientoIgual.Value = .FechaVencimiento
                fecVigenciaIgual.Value = .FechaVigencia

                listaImagenesIgual = New List(Of e_ImagenesDocumentos)
                If .RutaImagen <> "" Then
                    Dim objI As e_ImagenesDocumentos
                    Dim cant = .RutaImagen.Split("*").Length
                    For i As Integer = 0 To cant - 1
                        objI = New e_ImagenesDocumentos
                        objI.RutaImagen = .RutaImagen.Split("*")(i)
                        listaImagenesIgual.Add(objI)
                    Next
                End If
                gridImagenesIgual.DataSource = listaImagenesIgual
                gridImagenesIgual.DataBind()
                gridImagenesIgual.UpdateData()

                'CambioIndTodosClienteIgual(False)
                'CambioIndTodosMaterialIgual(False)
                'CargarAsignadosIgual()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarListaImagenes(ByVal cadenaRutas As String)
        Try
            Dim objI As e_ImagenesDocumentos
            If cadenaRutas <> "" Then
                Dim cant = cadenaRutas.Split("*").Length
                For i As Integer = 0 To cant - 1
                    objI = New e_ImagenesDocumentos
                    objI.RutaImagen = cadenaRutas.Split("*")(i)
                    listaImagenes.Add(objI)
                Next
                griImagenes.DataSource = listaImagenes
                griImagenes.DataBind()
                griImagenes.UpdateData()
            End If
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub griVehiculos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griVehiculos.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griLista_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
        Eliminar()
    End Sub

    Private Sub griImagenes_DoubleClick(sender As Object, e As EventArgs) Handles griImagenes.DoubleClick
        Try
            If griImagenes.ActiveRow.Cells("RutaImagen").Value <> "" Then
                Dim Fs As FileStream = Nothing
                Fs = New FileStream(IIf(griImagenes.ActiveRow.Cells("RutaImagen").Value.ToString.Contains("ControlFlota"), "\\" & IpServidor, "") & griImagenes.ActiveRow.Cells("RutaImagen").Value, IO.FileMode.Open, IO.FileAccess.Read)
                upbImagenMasivo.Image = System.Drawing.Image.FromStream(Fs)
            End If
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles btnVerGrande.Click
        Try
            'If upbImagenMasivo.Image IsNot Nothing Then
            '    Dim formulario As New frm_Visor()
            '    formulario.EstablecerImagen(upbImagenMasivo.Image)
            '    formulario.ShowDialog()
            'End If
            If griImagenes.Selected.Rows.Count <> 1 Then mensajeEmergente.Confirmacion("Debe seleccionar una imagen", True)
            If griImagenes.ActiveRow.Cells("RutaImagen").Value = "" Then mensajeEmergente.Confirmacion("Registro no tiene imagen", True)
            Dim proceso As Process = New Process
            Dim rutaImagen As String = IIf(griImagenes.ActiveRow.Cells("RutaImagen").Value.ToString.Contains("ControlFlota"), "\\" & IpServidor, "") & griImagenes.ActiveRow.Cells("RutaImagen").Value
            proceso.StartInfo.FileName = "rundll32.exe"
            proceso.StartInfo.Arguments = "C:\WINDOWS\system32\shimgvw.dll,ImageView_Fullscreen " & rutaImagen
            'proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            proceso.StartInfo.CreateNoWindow = True
            proceso.Start()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub griImagenesInd_DoubleClick(sender As Object, e As EventArgs) Handles griImagenesInd.DoubleClick
        Try
            If griImagenesInd.ActiveRow.Cells("RutaImagen").Value <> "" Then
                Dim Fs As FileStream = Nothing
                Fs = New FileStream(IIf(griImagenesInd.ActiveRow.Cells("RutaImagen").Value.ToString.Contains("ControlFlota"), "\\" & IpServidor, "") & griImagenesInd.ActiveRow.Cells("RutaImagen").Value, IO.FileMode.Open, IO.FileAccess.Read)
                upbDocVeh.Image = System.Drawing.Image.FromStream(Fs)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griImagenes_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griImagenes.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Documento?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                griImagenes.Update()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griImagenesInd_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griImagenesInd.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Documento?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                If griImagenesInd.ActiveRow.Cells("RutaImagen").Value.ToString.Contains("ControlFlota") Then
                    File.Delete("\\" & IpServidor & griImagenesInd.ActiveRow.Cells("RutaImagen").Value)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboVehiculoMasivo_ValueChanged(sender As Object, e As EventArgs) Handles cboVehiculoMasivo.ValueChanged
        Try
            If Me.cboVehiculoMasivo.Value <> "" Then
                Dim olVehiculo As New l_Vehiculo
                Dim oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = Me.cboVehiculoMasivo.Value
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                If oeVehiculo.ModeloFuncional IsNot Nothing Then
                    chkMotrizMasivo.Checked = IIf(oeVehiculo.Motriz = 1, True, False)
                    txtModeloFuncional.Value = oeVehiculo.ModeloFuncional
                    txtTipoVehMasivo.Value = oeVehiculo.TipoVehiculo
                    txtMarca.Value = oeVehiculo.Marca
                    txtModelo.Value = oeVehiculo.Modelo
                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboVehiculo_ValueChanged(sender As Object, e As EventArgs) Handles cboVehiculo.ValueChanged
        Try
            If Me.cboVehiculo.Value <> "" Then
                Dim olVehiculo As New l_Vehiculo
                Dim oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = Me.cboVehiculo.Value
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                If oeVehiculo.ModeloFuncional IsNot Nothing Then
                    chkMotrizInd.Checked = IIf(oeVehiculo.Motriz = 1, True, False)
                    txtModeloFuncInd.Value = oeVehiculo.ModeloFuncional
                    txtTipoVehInd.Value = oeVehiculo.TipoVehiculo
                    txtMarcaINd.Value = oeVehiculo.Marca
                    txtModeloInd.Value = oeVehiculo.Modelo
                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs)
        Try
            Dim rutaDirectorio As String = "C:\ImagenSGI"
            Dim rutaImagen As String = rutaDirectorio & "\" & Date.Now.Ticks.ToString & ".jpg"
            If Not System.IO.Directory.Exists(rutaDirectorio) Then
                System.IO.Directory.CreateDirectory(rutaDirectorio)
            End If
            If System.IO.File.Exists(rutaImagen) Then
                System.IO.File.Delete(rutaImagen)
            End If

            Dim vCopia As New Bitmap(415, 450, Imaging.PixelFormat.Format24bppRgb)
            Dim g As Graphics = Graphics.FromImage(vCopia)
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            g.DrawImage(upbDocVeh.Image, 0, 0, vCopia.Width, vCopia.Height)
            vCopia.Save(rutaImagen, System.Drawing.Imaging.ImageFormat.Jpeg)

            'upbDocVeh.Image.Save(rutaImagen, Imaging.ImageFormat.Png)
            'upbDocVeh.Dispose()

            'Dim imagen As New Bitmap(300, 300)
            'Me.DrawToBitmap(imagen, upbDocVeh.Image)
            'imagen.Save(rutaImagen, Imaging.ImageFormat.Jpeg)

            ''If upbDocVeh.Image <> Nothing Then
            'oeDocVehImg.Imagen.Add(upbDocVeh.Image)
            'Dim lista = From la In oeDocVehImg.Imagen Select Imagen = la

            'griListaImagen.DataSource = lista.ToList
            'griListaImagen.DataBind()
            ''End If

        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub btnImagenMasivo_Click(sender As Object, e As EventArgs) Handles btnImagenMasivo.Click
        Try
            Dim Formulario As New frm_Scanner
            Formulario.ShowDialog()
            If Formulario.DialogResult = Windows.Forms.DialogResult.OK Then
                imagenDocInd = New e_ImagenesDocumentos
                imagenDocInd.RutaImagen = Formulario.RutaImagen
                listaImagenes.Add(imagenDocInd)
                griImagenes.DataSource = listaImagenes
                griImagenes.DataBind()
                griImagenes.UpdateData()
                Dim Fs As FileStream = Nothing
                Fs = New FileStream(Formulario.RutaImagen, IO.FileMode.Open, IO.FileAccess.Read)

                'upbDocVeh.Image = System.Drawing.Image.FromStream(Fs)
                upbImagenMasivo.Image = System.Drawing.Image.FromStream(Fs)
            End If
            Formulario.Dispose()
            Formulario.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

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
                listaImagenesDoc.Clear()
                'lstRegConsumoCombustible.Clear()
                Dim FechaActual As Date = ObtenerFechaServidor()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 2).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 3).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 4).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 5).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 6).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 7).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 8).Value Is Nothing) Then
                        oeDocVehImg = New e_ImagenesDocumentos
                        oeDocVehImg.Indicador = "0"
                        Dim IdTipoDocumento As String = ""
                        Dim TipoDocumento As String = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value).Trim
                        Dim listaD = TipoDocVehPublic.Where(Function(x) x.Nombre = TipoDocumento)
                        If listaD.Count = 1 Then IdTipoDocumento = listaD(0).Id
                        Dim IdVehiculo As String = ""
                        Dim Vehiculo As String = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value).Trim
                        Dim listaV = loVehiculo.Where(Function(x) x.Nombre = Vehiculo)
                        If listaV.Count = 1 Then IdVehiculo = listaV(0).Id

                        If IdTipoDocumento = "" Then IdTipoDocumento = TipoDocumento
                        If IdVehiculo = "" Then IdVehiculo = Vehiculo

                        oeDocVehImg.Id = ""
                        oeDocVehImg.Activo = True
                        oeDocVehImg.Descripcion = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value).Trim
                        oeDocVehImg.FechaCreacion = Date.Now
                        Dim fechaAux As String
                        fechaAux = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value).Trim
                        oeDocVehImg.FechaVencimiento = IIf(fechaAux.Trim = "", "01/01/1901", fechaAux.Trim)
                        oeDocVehImg.IdTipoDocumento = IdTipoDocumento
                        oeDocVehImg.IdTrabajador = ""
                        oeDocVehImg.IdVehiculo = IdVehiculo
                        oeDocVehImg.Imagen = Nothing
                        Dim vigente As String = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 8).Value).Trim
                        If vigente.ToUpper.Trim = "NO" Then
                            oeDocVehImg.IndVigente = False
                        Else
                            oeDocVehImg.IndVigente = True
                        End If
                        oeDocVehImg.NroDocumento = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value).Trim
                        oeDocVehImg.Placa = Vehiculo
                        oeDocVehImg.RutaImagen = ""
                        oeDocVehImg.TipoDocumento = TipoDocumento
                        oeDocVehImg.UsuarioCreacion = gUsuarioSGI.Id.Trim
                        oeDocVehImg.Vencimiento = 0
                        fechaAux = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value).Trim
                        oeDocVehImg.FechaVigencia = IIf(fechaAux.Trim = "", "01/01/1901", fechaAux.Trim)
                        oeDocVehImg.TipoOperacion = "I"
                        oeDocVehImg.Identificador = Date.Now.Ticks.ToString & ln_Fila.ToString
                        listaImagenesDoc.Add(oeDocVehImg)
                    Else
                        Exit For
                    End If
                Next

                griVehiculos.DataSource = listaImagenesDoc
                griVehiculos.DataBind()
                GrigDocumentoMasivoMarcar()
                oeDocVehImg = New e_ImagenesDocumentos

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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GrigDocumentoMasivoMarcar()
        Dim listaCombo As New List(Of e_Combo)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griVehiculos.Rows
            fila.CellAppearance.BackColor = Color.White
            'For Each celda In fila.Cells
            '    celda.Appearance.BackColor = Color.White
            'Next

            Dim tooltip As New StringBuilder
            listaCombo = ValidarFila(fila)
            For Each Combo In listaCombo
                'fila.CellAppearance.BackColor = Color.MediumAquamarine
                fila.CellAppearance.BackColor = Color.Red
                tooltip.AppendLine(Combo.Nombre)
            Next
            'For Each Combo In listaCombo
            '    fila.Cells(Combo.Id).Appearance.BackColor = Color.Red
            'Next
            fila.ToolTipText = tooltip.ToString
        Next
    End Sub

    Private Sub GrigDocumentoIgualMarcar()
        Dim listaCombo As New List(Of e_Combo)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In gridDocumentoVehiculoIgual.Rows
            fila.CellAppearance.BackColor = Color.White
            'For Each celda In fila.Cells
            '    celda.Appearance.BackColor = Color.White
            'Next

            Dim tooltip As New StringBuilder
            listaCombo = ValidarFila(fila)
            For Each Combo In listaCombo
                'fila.CellAppearance.BackColor = Color.MediumAquamarine
                fila.CellAppearance.BackColor = Color.Red
                tooltip.AppendLine(Combo.Nombre)
            Next
            'For Each Combo In listaCombo
            '    fila.Cells(Combo.Id).Appearance.BackColor = Color.Red
            'Next
            fila.ToolTipText = tooltip.ToString
        Next
    End Sub

    Private Function ValidarFila(ByVal fila As UltraGridRow) As List(Of e_Combo)
        Try
            Dim listaCombo As New List(Of e_Combo)
            Dim oeCombo As e_Combo

            Dim IdTipoDocumento As String = ""
            Dim TipoDocumento As String = fila.Cells("IdTipoDocumento").Text.ToString.Trim()
            Dim listaD = TipoDocVehPublic.Where(Function(x) x.Nombre.Trim = TipoDocumento.Trim)
            If listaD.Count = 1 Then IdTipoDocumento = listaD(0).Id

            Dim IdVehiculo As String = ""
            Dim Vehiculo As String = fila.Cells("IdVehiculo").Text.ToString.Trim()
            Dim listaV = loVehiculo.Where(Function(x) x.Nombre.Trim = Vehiculo.Trim)
            If listaV.Count = 1 Then IdVehiculo = listaV(0).Id

            Dim NumeroDocumento As String = fila.Cells("NroDocumento").Value.ToString.Trim()
            Dim FechaVigencia As String = fila.Cells("FechaVigencia").Value.ToString.Trim()
            Dim FechaVencimiento As String = fila.Cells("FechaVencimiento").Value.ToString.Trim()

            If FechaVigencia = "01/01/1901 12:00:00 a.m." Or FechaVigencia = "" Then
                oeCombo = New e_Combo
                oeCombo.Id = "FechaVigencia"
                oeCombo.Nombre = "Debe Ingresar Fecha Vigencia."
                listaCombo.Add(oeCombo)
            End If
            If FechaVencimiento = "01/01/1901 12:00:00 a.m." Or FechaVencimiento = "" Then
                oeCombo = New e_Combo
                oeCombo.Id = "FechaVencimiento"
                oeCombo.Nombre = "Debe Ingresar Fecha Vencimiento."
                listaCombo.Add(oeCombo)
            End If
            If IdVehiculo = "" Then
                oeCombo = New e_Combo
                oeCombo.Id = "IdVehiculo"
                oeCombo.Nombre = "Vehículo No Existe."
                listaCombo.Add(oeCombo)
            End If
            If IdTipoDocumento = "" Then
                oeCombo = New e_Combo
                oeCombo.Id = "IdTipoDocumento"
                oeCombo.Nombre = "Tipo Documento No Existe."
                listaCombo.Add(oeCombo)
            End If
            'If NumeroDocumento = "" Then
            '    oeCombo = New e_Combo
            '    oeCombo.Id = "NroDocumento"
            '    oeCombo.Nombre = "Debe Ingresar Número Documento."
            '    listaCombo.Add(oeCombo)
            'End If
            'If IdTipoDocumento = "" Or NumeroDocumento = "" Or IdVehiculo = "" Then Return listaCombo
            If IdTipoDocumento = "" Or IdVehiculo = "" Then Return listaCombo


            'Dim objListar As New e_ImagenesDocumentos
            'Dim Listaobj As New List(Of e_ImagenesDocumentos)
            'Dim Id As String = fila.Cells("Id").Text.ToString.Trim()
            'objListar.TipoOperacion = ""
            'objListar.Id = ""
            'objListar.IdTipoDocumento = IdTipoDocumento.Trim
            'objListar.NroDocumento = NumeroDocumento.Trim
            'Listaobj = olDocVehImg.Listar(objListar)
            'If Id = "" Then
            '    If Listaobj.Count > 0 Then
            '        oeCombo = New e_Combo
            '        oeCombo.Id = "NroDocumento"
            '        oeCombo.Nombre = "Número Documento Ya Existe."
            '        listaCombo.Add(oeCombo)
            '    End If
            'Else
            '    Dim resultados = Listaobj.Where(Function(x) x.Id.Trim <> Id.Trim)
            '    If resultados.Count > 0 Then
            '        oeCombo = New e_Combo
            '        oeCombo.Id = "NroDocumento"
            '        oeCombo.Nombre = "Número Documento Ya Existe."
            '        listaCombo.Add(oeCombo)
            '    End If
            'End If

            'Listaobj = New List(Of e_ImagenesDocumentos)
            'objListar = New e_ImagenesDocumentos
            'objListar.TipoOperacion = ""
            'objListar.Id = ""
            'objListar.IdTipoDocumento = IdTipoDocumento.Trim
            'objListar.IdVehiculo = IdVehiculo.Trim
            'Listaobj = olDocVehImg.Listar(objListar)
            'If Listaobj.Count = 0 Then Return listaCombo
            'Dim resultado = Listaobj.OrderByDescending(Function(x) x.FechaVencimiento)
            'If resultado(0).FechaVencimiento.Date > fila.Cells("FechaVigencia").Value.Date Then
            '    oeCombo = New e_Combo
            '    oeCombo.Id = "FechaVigencia"
            '    oeCombo.Nombre = "Vehículo Tiene Documento N°: " + resultado(0).NroDocumento.Trim + " Con La FechaVencimiento " + resultado(0).FechaVencimiento.Date + ", Debe Seleccionar FechaVigencia Mayor A " + resultado(0).FechaVencimiento.Date
            '    listaCombo.Add(oeCombo)
            'End If

            Return listaCombo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub griVehiculos_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griVehiculos.AfterCellUpdate
        Dim listaCombo As New List(Of e_Combo)
        listaCombo = ValidarFila(griVehiculos.ActiveRow)
        griVehiculos.ActiveRow.CellAppearance.BackColor = Color.White
        For Each cell In griVehiculos.ActiveRow.Cells
            cell.Appearance.BackColor = Color.White
        Next

        Dim tooltip As New StringBuilder
        For Each Combo In listaCombo
            griVehiculos.ActiveRow.CellAppearance.BackColor = Color.MediumAquamarine
            tooltip.AppendLine(Combo.Nombre)
        Next
        For Each Combo In listaCombo
            griVehiculos.ActiveRow.Cells(Combo.Id).Appearance.BackColor = Color.Red
        Next
        griVehiculos.ActiveRow.ToolTipText = tooltip.ToString
    End Sub

    Private Sub btnAgregarIgual_Click(sender As Object, e As EventArgs) Handles btnAgregarIgual.Click
        Try
            LlenarObjetoIgual()
            ValidarDocumentoVehiculo(oeDocVehIgual)
            If Not listaDocumentoIgual.Contains(oeDocVehIgual) Then
                listaDocumentoIgual.Add(oeDocVehIgual)
            Else
                listaDocumentoIgual.Item(listaDocumentoIgual.IndexOf(oeDocVehIgual)) = oeDocVehIgual
            End If
            gridDocumentoVehiculoIgual.DataBind()
            GrigDocumentoIgualMarcar()
            oeDocVehIgual = New e_ImagenesDocumentos

            limpiarFormIgual()
            cboVehiculoIgual.Focus()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub btnImagenIgual_Click(sender As Object, e As EventArgs) Handles btnImagenIgual.Click
        Try
            Dim Formulario As New frm_Scanner
            Formulario.ShowDialog()
            If Formulario.DialogResult = Windows.Forms.DialogResult.OK Then
                imagenDocInd = New e_ImagenesDocumentos
                imagenDocInd.RutaImagen = Formulario.RutaImagen
                listaImagenesIgual.Add(imagenDocInd)
                gridImagenesIgual.DataSource = listaImagenesIgual
                gridImagenesIgual.DataBind()
                gridImagenesIgual.UpdateData()
                Dim Fs As FileStream = Nothing
                Fs = New FileStream(Formulario.RutaImagen, IO.FileMode.Open, IO.FileAccess.Read)
                pixImagenIgual.Image = System.Drawing.Image.FromStream(Fs)
            End If
            Formulario.Dispose()
            Formulario.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnImportarIgual_Click(sender As Object, e As EventArgs) Handles btnImportarIgual.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

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
                listaDocumentoIgual.Clear()
                Dim FechaActual As Date = ObtenerFechaServidor()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 2).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 3).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 4).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 5).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 6).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 7).Value Is Nothing) Or _
                        (Not objWorkSheet.Cells(ln_Fila + 1, 8).Value Is Nothing) Then
                        oeDocVehIgual = New e_ImagenesDocumentos
                        oeDocVehIgual.Indicador = "0"
                        Dim IdTipoDocumento As String = ""
                        Dim TipoDocumento As String = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value).Trim
                        Dim listaD = TipoDocVehPublic.Where(Function(x) x.Nombre = TipoDocumento)
                        If listaD.Count = 1 Then IdTipoDocumento = listaD(0).Id
                        Dim IdVehiculo As String = ""
                        Dim Vehiculo As String = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value).Trim
                        Dim listaV = loVehiculo.Where(Function(x) x.Nombre = Vehiculo)
                        If listaV.Count = 1 Then IdVehiculo = listaV(0).Id

                        If IdTipoDocumento = "" Then IdTipoDocumento = TipoDocumento
                        If IdVehiculo = "" Then IdVehiculo = Vehiculo

                        oeDocVehIgual.Id = ""
                        oeDocVehIgual.Activo = True
                        oeDocVehIgual.Descripcion = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value).Trim
                        oeDocVehIgual.FechaCreacion = Date.Now
                        Dim fechaAux As String
                        fechaAux = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value).Trim
                        oeDocVehIgual.FechaVencimiento = IIf(fechaAux.Trim = "", "01/01/1901", fechaAux.Trim)
                        oeDocVehIgual.IdTipoDocumento = IdTipoDocumento
                        oeDocVehIgual.IdTrabajador = ""
                        oeDocVehIgual.IdVehiculo = IdVehiculo
                        oeDocVehIgual.Imagen = Nothing
                        Dim vigente As String = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 8).Value).Trim
                        If vigente.ToUpper.Trim = "NO" Then
                            oeDocVehIgual.IndVigente = False
                        Else
                            oeDocVehIgual.IndVigente = True
                        End If
                        oeDocVehIgual.NroDocumento = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value).Trim
                        oeDocVehIgual.Placa = Vehiculo
                        oeDocVehIgual.RutaImagen = ""
                        oeDocVehIgual.TipoDocumento = TipoDocumento
                        oeDocVehIgual.UsuarioCreacion = gUsuarioSGI.Id.Trim
                        oeDocVehIgual.Vencimiento = 0
                        fechaAux = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value).Trim
                        oeDocVehIgual.FechaVigencia = IIf(fechaAux.Trim = "", "01/01/1901", fechaAux.Trim)
                        oeDocVehIgual.TipoOperacion = "I"
                        oeDocVehIgual.Identificador = Date.Now.Ticks.ToString & ln_Fila.ToString
                        listaDocumentoIgual.Add(oeDocVehIgual)
                    Else
                        Exit For
                    End If
                Next

                gridDocumentoVehiculoIgual.DataSource = listaDocumentoIgual
                gridDocumentoVehiculoIgual.DataBind()
                GrigDocumentoIgualMarcar()
                oeDocVehIgual = New e_ImagenesDocumentos

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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridDocumentoVehiculoIgual_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles gridDocumentoVehiculoIgual.DoubleClickRow
        Try
            If gridDocumentoVehiculoIgual.ActiveRow IsNot Nothing Then
                oeDocVehIgual = New e_ImagenesDocumentos
                oeDocVehIgual = gridDocumentoVehiculoIgual.ActiveRow.ListObject
                MostrarIgual()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoDocumentoIgual_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDocumentoIgual.ValueChanged
        Try
            If cboTipoDocumentoIgual.Value = "1CH000000051" Then
                fecVencimientoIgual.Enabled = False
            Else
                fecVencimientoIgual.Enabled = True
            End If

            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In gridDocumentoVehiculoIgual.Rows
                fila.Cells("IdTipoDocumento").Value = cboTipoDocumentoIgual.Value.ToString.Trim()
                fila.Update()
            Next
            GrigDocumentoIgualMarcar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecVencimientoIgual_ValueChanged(sender As Object, e As EventArgs) Handles fecVencimientoIgual.ValueChanged
        Try
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In gridDocumentoVehiculoIgual.Rows
                fila.Cells("FechaVencimiento").Value = fecVencimientoIgual.Value
                fila.Update()
            Next
            GrigDocumentoIgualMarcar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecVigenciaIgual_ValueChanged(sender As Object, e As EventArgs) Handles fecVigenciaIgual.ValueChanged
        Try
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In gridDocumentoVehiculoIgual.Rows
                fila.Cells("FechaVigencia").Value = fecVigenciaIgual.Value
                fila.Update()
            Next
            GrigDocumentoIgualMarcar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboVehiculoIgual_ValueChanged(sender As Object, e As EventArgs) Handles cboVehiculoIgual.ValueChanged
        Try
            If Me.cboVehiculoIgual.Value <> "" Then
                Dim olVehiculo As New l_Vehiculo
                Dim oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = Me.cboVehiculoIgual.Value
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                If oeVehiculo.ModeloFuncional IsNot Nothing Then
                    chkMotrizIgual.Checked = IIf(oeVehiculo.Motriz = 1, True, False)
                    txtModeloFuncionalIgual.Value = oeVehiculo.ModeloFuncional
                    txtTipoVehiculoIgual.Value = oeVehiculo.TipoVehiculo
                    txtMarcaIgual.Value = oeVehiculo.Marca
                    txtModeloFuncionalIgual.Value = oeVehiculo.Modelo
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub gridDocumentoVehiculoIgual_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles gridDocumentoVehiculoIgual.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub btnMostrarIgual_Click(sender As Object, e As EventArgs) Handles btnMostrarIgual.Click
        Try
            If pixImagenIgual.Image IsNot Nothing Then
                Dim formulario As New frm_Visor()
                formulario.EstablecerImagen(pixImagenIgual.Image)
                formulario.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griVehiculos_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griVehiculos.DoubleClickRow
        Try
            If griVehiculos.ActiveRow IsNot Nothing Then
                oeDocVehMasivo = New e_ImagenesDocumentos
                oeDocVehMasivo = griVehiculos.ActiveRow.ListObject
                MostrarVeh()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridImagenesIgual_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles gridImagenesIgual.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Documento?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                gridImagenesIgual.Update()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDocumento.ValueChanged
        Try
            If cboTipoDocumento.Value = "1CH000000051" Then
                fecFechaVencimiento.Enabled = False
            Else
                fecFechaVencimiento.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoDocMasivo_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDocMasivo.ValueChanged
        Try
            If cboTipoDocMasivo.Value = "1CH000000051" Then
                dtpVencimiento.Enabled = False
            Else
                dtpVencimiento.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripDescargarImg_Click(sender As Object, e As EventArgs) Handles ToolStripDescargarImg.Click
        Try
            If griLista.Selected.Rows.Count <> 1 Then
                mensajeEmergente.Confirmacion("Debe seleccionar un registro", True)
                Return
            End If

            If griLista.ActiveRow.Cells("RutaImagen").Value = "" Then
                mensajeEmergente.Confirmacion("Registro no tiene imagen", True)
                Return
            End If

            listaImagenes = New List(Of e_ImagenesDocumentos)
            LlenarListaImagenes(griLista.ActiveRow.Cells("RutaImagen").Value)

            Dim Ruta As String = ""
            Dim sNombreArchivo As String = ""

            FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Ruta = FolderBrowserDialog1.SelectedPath.ToString
            Else
                FolderBrowserDialog1.Dispose()
                Return
            End If

            For Each fila In listaImagenes
                sNombreArchivo = fila.RutaImagen
                Dim posicion As Integer
                While sNombreArchivo.Contains("\")
                    posicion = 0
                    posicion = InStr(sNombreArchivo, "\")
                    sNombreArchivo = sNombreArchivo.Remove(0, posicion)
                End While
                FileCopy(IIf(fila.RutaImagen.ToString.Contains("ControlFlota"), "\\" & IpServidor & fila.RutaImagen, fila.RutaImagen), Ruta & "\" & sNombreArchivo)
            Next

        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub btnSincronizar_Click(sender As Object, e As EventArgs) Handles btnSincronizar.Click
        Try
            ugb_Espera.Visible = True
            Dim obj As New e_ImagenesDocumentos
            obj.TipoOperacion = "S"
            olDocVehImg.Sincronizar(obj)
            mensajeEmergente.Confirmacion("Sincronización Correcta", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera.Visible = False
        End Try
    End Sub
End Class