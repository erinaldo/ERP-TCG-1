'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports System.IO
Imports System.Net
Imports Infragistics.Win

Public Class frm_EnvioEmail

    Inherits frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ms_Empresa = ""
        ms_Documento = ""
        ms_Email = ""
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


    Private Shared instancia As frm_EnvioCorreo = Nothing
    Private Shared Operacion As String
    Public bandFrmExterno As String = ""
    Public cadenaMensajeHtml As String = ""
    Public cadenaMensaje As String = ""
    Public asunto As String = ""
    Public cantMensajes As Integer = 2
    Public confirmarDemanda As String = ""
    Public bandDemandaEnviada As String = ""

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_EnvioCorreo()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

    Public Function Liquidaciones() As Boolean
        txtDe.Text = "consultores.tecnologicos.2010@gmail.com"
        txtDe.Enabled = False
        txtAsunto.Text = "Viajes desde"
        txtMensaje.Visible = False
        Return True
    End Function

    Public Function DemandaRapida() As Boolean
        Try
            txtMensaje.Visible = True
            txtMensajeExtra.Height = 74
            If gUsuarioSGI.oePersona.leEmail.Count > 0 Then
                txtDe.Text = gUsuarioSGI.oePersona.leEmail.Where(Function(Item) Item.Principal = 1 Or Item.Principal = 0).ToList.Item(0).Nombre.ToString ''"consultores.tecnologicos.2010@gmail.com" '
                    txtDe.Enabled = False            
            Else
                txtDe.Text = ""
                txtDe.Enabled = True
            End If
            txtAsunto.Text = IIf(bandFrmExterno.Equals("DR"), "Demanda Rapida", IIf(bandFrmExterno.Equals("DE"), "Demanda", "Demandas afectadas al eliminar el viaje"))
            txtCC.Text = IIf(bandFrmExterno.Equals("OP"), "", txtDe.Text)
            txtMensajeExtra.Text = vbCrLf & vbCrLf & vbCrLf & "Atte : " & gUsuarioSGI.oePersona.NombreCompleto
            txtPara.Focus()
            txtPara.Text = IIf(bandFrmExterno.Equals("OP"), txtDe.Text, "")
            Me.lstBusqueda.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function LlenarDatos() As Boolean
        Try
            txtDe.Text = gUsuarioSGI.oePersona.leEmail.Where(Function(Item) Item.Principal = 1).ToList.Item(0).Nombre.ToString ''"consultores.tecnologicos.2010@gmail.com" '
            txtDe.Enabled = False
            txtAsunto.Text = asunto
            txtCC.Text = gUsuarioSGI.oePersona.leEmail.Where(Function(Item) Item.Principal = 1).ToList.Item(0).Nombre.ToString
            txtMensajeExtra.Text = vbCrLf & vbCrLf & vbCrLf & "Atte : " & gUsuarioSGI.oePersona.NombreCompleto
            txtPara.Focus()
            Me.lstBusqueda.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SeguienteFalla(Mensaje As String) As Boolean
        txtDe.Text = "consultores.tecnologicos.2010@gmail.com"
        txtDe.Enabled = False
        txtPara.Text = IIf(bandFrmExterno = "SI", "consultores.tecnologicos.2010@gmail.com", "")
        txtAsunto.Text = asunto
        '  txtMensaje.DocumentText = Mensaje
        txtMensajeExtra.Text = Mensaje
        txtMensajeExtra.Height = agrAdjunto.Height
        txtMensaje.Visible = False
        Return True
    End Function

#Region "Declaración de variables"

    Private ms_Empresa As String

    Private ms_Documento As String
    Private ms_Email As String
    Private ms_Mensaje As String
    Private ms_CorreoTrabajador As String

    Private mb_De As Boolean = True
    Private mb_Para As Boolean = True
    Private mb_CC As Boolean = True
    Private mb_CCO As Boolean = True


    Private ms_CCO As String = ""

    Public oeArchivo As e_Archivo
    Public llListaAdjunto As New List(Of e_Archivo)
    Public sw As Integer


    Dim _ingresando_datos As Boolean = False
    Public Modulo As String = ""
    Public MensajeCorreo As String = ""
    Public Correo As String = ""
    Private oeCombo As e_Combo
    Private olCombo As l_Combo

#End Region

#Region "Métodos"

    Public Sub Inicializar()
        Me.txtDe.Text = String.Empty
        Me.txtPara.Text = String.Empty
        Me.txtCC.Text = String.Empty
        Me.txtCCO.Text = String.Empty
        Me.txtAsunto.Text = String.Empty
        '    Me.txtMensaje.DocumentText = ""
        Me.lstAdjuntados.Items.Clear()
        Me.lstBusqueda.Items.Clear()
        Me.lstBusqueda.Visible = False

        If confirmarDemanda <> "" Then
            groupConfirmar.Visible = True
            groupDatosCorreo.Visible = False
            agrAdjunto.Text = "Datos"
            txtMensajeExtra.Visible = False
            agrAdjunto.Dock = DockStyle.Fill
            Me.txtMensaje.Dock = DockStyle.Fill
        Else
            groupConfirmar.Visible = False
            groupDatosCorreo.Visible = True
            agrAdjunto.Text = "Mensaje de Correo"
            txtMensajeExtra.Visible = True
            agrAdjunto.Dock = DockStyle.Bottom
            Me.txtMensaje.Dock = DockStyle.Bottom
        End If
        btnConfirmarAtras.Text = "Confirmar"
        bandDemandaEnviada = ""
    End Sub

    Public Function ObtenerDatos(ByVal ls_Empresa As String _
        , ByVal ls_Documento As String _
        , ByVal ls_CorreoTrabajador As String _
        , Optional ByVal lb_De As Boolean = True, Optional ByVal lb_Para As Boolean = True _
        , Optional ByVal lb_CC As Boolean = True, Optional ByVal lb_CCO As Boolean = True _
        , Optional ByVal ls_Email As String = "", Optional ByVal ls_Mensaje As String = "" _
        , Optional ByVal ls_CCO As String = "" _
    ) As Boolean

        Try
            Inicializar()
            Operacion = "Correo"
            ms_Empresa = ls_Empresa
            ms_Documento = ls_Documento
            ms_Email = ls_Email
            ms_Mensaje = ls_Mensaje
            ms_CorreoTrabajador = ls_CorreoTrabajador
            mb_De = lb_De
            mb_Para = lb_Para
            mb_CC = lb_CC
            mb_CCO = lb_CCO
            ms_CCO = ls_CCO
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub CargarDatos()
        txtDe.Enabled = mb_De
        txtPara.Enabled = mb_Para
        txtCC.Enabled = mb_CC
        txtCCO.Enabled = mb_CCO
        txtDe.Value = ms_CorreoTrabajador
        txtCCO.Value = ms_CCO
        If ms_Documento <> "" Then
            If ms_Documento.Contains("Cotizacion1") Then
                txtAsunto.Value = "Solicitud de Cotizacion"
            Else
                If ms_Documento.Contains("_orden_compra1") Then
                    txtAsunto.Value = "Orden de Compra"
                End If
                If ms_Documento.Contains("Vales") Then
                    txtAsunto.Value = "VALES POR RENDIR ATRASADOS"
                End If
            End If
            txtPara.Text = ms_Email
            CargarAdjuntos(ms_Documento)
        Else
            txtPara.Text = ms_Email
        End If
        '  txtMensaje.DocumentText = ms_Mensaje
    End Sub


    Sub CargarAdjuntos(ByVal Ruta As String)
        Dim NomArchivo As Object() = Split(Ruta, "\")
        Dim oeArchivo As New e_Archivo
        oeArchivo.RutaDocumento = Ruta
        oeArchivo.Nombre = NomArchivo(NomArchivo.Length - 1)
        llListaAdjunto.Add(oeArchivo)
        Me.lstAdjuntados.Items.Add(oeArchivo.Nombre)
        '  griListadoArchivos.DataSource = llListaAdjunto
        'griListadoArchivos.DataBind()
        'With griListadoArchivos
        '    'Ubica el cursor el el primer registro de la grilla
        '    If .Rows.Count > 0 Then
        '        .Focus()
        '        .Rows.Item(0).Selected = True
        '    End If
        'End With
    End Sub



    Private Function quitarAdjunto(ByVal oeAr As e_Archivo) As Boolean
        If oeAr.Seleccion Then sw = 1
        Return oeAr.Seleccion
    End Function


#End Region

#Region "Eventos"


    Public listaCorreos As List(Of e_Combo)
    Private Sub frm_EnvioCorreo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oeCombo = New e_Combo
        olCombo = New l_Combo
        oeCombo.Nombre = "CORREOS"
        listaCorreos = olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList
        lstBusqueda.Visible = False

        Inicializar()
        If Modulo = "Liquidaciones" Then
            Liquidaciones()
        Else
            If Modulo = "Seguimiento" Then
                SeguienteFalla(cadenaMensaje)
            Else
                If Modulo = "DemandaRapida" Then
                    DemandaRapida()
                    ' If txtMensaje.DocumentText = "<HTML></HTML>" Then
                    txtMensaje.DocumentText = "<HTML><body>" + Me.cadenaMensajeHtml + "</body></HTML>"
                    'End If
                Else
                    If Modulo = "Trazabilidad" Then
                        LlenarDatos()
                        txtMensaje.DocumentText = "<HTML><body>" + Me.cadenaMensajeHtml + "</body></HTML>"
                    Else
                        If Modulo = "EventoViaje" Then
                            LlenarDatos()
                            txtMensaje.DocumentText = "<HTML><body>" + Me.cadenaMensajeHtml + "</body></HTML>"
                        Else
                            If Modulo = "SeguimientoMonitoreo" Then
                                LlenarDatos()
                                txtMensaje.DocumentText = "<HTML><body>" + Me.cadenaMensajeHtml + "</body></HTML>"
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    'Public Sub llenarHtml()
    '    txtMensaje.DocumentText = "<HTML><body>hOLA</body></HTML>"
    'End Sub
    Private Sub frm_EnvioCorreo_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                ' Nuevo()
            Case "Editar"
                'Editar()
            Case "Inicializa"
                'Tiempo1.Enabled = False
                'InicializaTiempo()
                'MostrarTabs(0, ficCotizacion)
                'Consultar(True)
            Case "Correo"
        End Select
        If txtMensaje.DocumentText.ToString.Equals("<HTML></HTML>") Then
            txtMensaje.DocumentText = "<HTML><body>" & Me.cadenaMensajeHtml & "</body></HTML>"
        End If
    End Sub



    Private Sub frm_EnvioCorreo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_EnvioCorreo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()

        End Select

        'e.Cancel = _ingresando_datos
        'If Not e.Cancel Then
        '    ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        'End If

    End Sub
    Private Sub btnAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.Filter = "Todos los Archivos (*.*)|*.*"
        OpenFileDialog1.Title = "Adjuntar Archivos"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        CargarAdjuntos(OpenFileDialog1.FileName)
    End Sub




#End Region

#Region "Menu y tabs"

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs)
        Select Case e.Tool.Key
            Case "Editar"
                EnviarCorreo()
            Case "Cancelar"
                SalirFrm()
        End Select
    End Sub

    Public Sub EnviarCorreo()

        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If Not txtDe.Value Is Nothing Then txtDe.Value = txtDe.Value.ToString.Trim
            If Not txtPara.Text Is Nothing Then txtPara.Text = txtPara.Text.ToString.Trim
            If Not txtAsunto.Value Is Nothing Then txtAsunto.Value = txtAsunto.Value.ToString.Trim
            If Not txtMensaje.DocumentText Is Nothing Then txtMensaje.DocumentText = txtMensaje.DocumentText.ToString.Trim

            Dim ls_Msje As String = ""
            ls_Msje = ValidarControlEmail(txtDe, "Campo De")
            If txtPara.Text = "" And txtCC.Text = "" And txtCCO.Text = "" Then
                ls_Msje &= Environment.NewLine & " Ingrese al menos un destinatario."
            End If

            If ls_Msje <> "" Then
                'MessageBox.Show(ls_Msje, "ERP T&L", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Exit Sub
                Throw New Exception(ls_Msje)
            End If

            Dim ls_ListaAdjuntos As String = ""

            For Each detalle As e_Archivo In llListaAdjunto
                ls_ListaAdjuntos = ls_ListaAdjuntos & detalle.RutaDocumento & "@" & detalle.Nombre & ","
            Next
            Dim mensajeExtra As String = "<font FACE='raro, arial' SIZE=2>"
            For Each linea As String In txtMensajeExtra.Lines
                mensajeExtra &= "" + linea & "<br/>"
            Next
            mensajeExtra &= "</font>"
            If ls_ListaAdjuntos <> "" Then ls_ListaAdjuntos = Strings.Left(ls_ListaAdjuntos, ls_ListaAdjuntos.Length - 1)
            EnviarEmail(txtDe.Value, txtPara.Text, txtCC.Value, txtCCO.Value, txtAsunto.Value, IIf(Me.cantMensajes = 2, mensajeExtra & "<br/><br/> " & Me.cadenaMensajeHtml, mensajeExtra), ls_ListaAdjuntos)
            ' Me.txtMensajeExtra.Text.ToString + " " +
            Me.DialogResult = Windows.Forms.DialogResult.OK
            ugb_Espera.Visible = False
            Me.cadenaMensajeHtml = ""
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub
    Public Sub SalirFrm()

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub




#End Region

    Private Sub frm_EnvioCorreo_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub


    Private Sub griListaCorreo_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub griListadoArchivos_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub




    Dim list As New List(Of String)


    'Public Function displayMembers(ByVal lista As List(Of String)) As String
    '    Dim listaN As New List(Of String)
    '    For i As Integer = 0 To lista.Count - 1
    '        If Not lista.Item(i).ToString.Contains(txtPara.Text.ToString) Then
    '            listaN.Add(lista.Item(i))
    '        End If
    '    Next
    '    Return String.Join(Environment.NewLine, listaN.ToArray())
    'End Function

    Dim correos As Array



    Private Sub lstBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles lstBusqueda.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If lstBusqueda.Location.Y = 55 Then
                    txtPara.Text = cadenaF.Substring(0, cadenaF.Length - correos(correos.Length - 1).ToString.Length) + lstBusqueda.Items(lstBusqueda.SelectedIndex).ToString.Split(" ")(0) + ";"
                    txtPara.Focus()
                    txtPara.Select(txtPara.Text.Length, 0)
                    lstBusqueda.Visible = False
                    lstBusqueda.Left = lstBusqueda.Location.X + txtPara.Text.ToString.Length
                Else
                    If lstBusqueda.Location.Y = 81 Then
                        txtCC.Text = cadenaF.Substring(0, cadenaF.Length - correos(correos.Length - 1).ToString.Length) + lstBusqueda.Items(lstBusqueda.SelectedIndex).ToString.Split(" ")(0) + ";"
                        txtCC.Focus()
                        txtCC.Select(txtCC.Text.Length, 0)
                        lstBusqueda.Visible = False
                        lstBusqueda.Left = lstBusqueda.Location.X + txtCC.Text.ToString.Length
                    Else
                        If lstBusqueda.Location.Y = 104 Then
                            txtCCO.Text = cadenaF.Substring(0, cadenaF.Length - correos(correos.Length - 1).ToString.Length) + lstBusqueda.Items(lstBusqueda.SelectedIndex).ToString.Split(" ")(0) + ";"
                            txtCCO.Focus()
                            txtCCO.Select(txtCCO.Text.Length, 0)
                            lstBusqueda.Visible = False
                            lstBusqueda.Left = lstBusqueda.Location.X + txtCCO.Text.ToString.Length
                        End If
                    End If
                End If

            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub lstBusqueda_Click(sender As Object, e As EventArgs) Handles lstBusqueda.Click
        Try
            If lstBusqueda.Location.Y = 55 Then
                txtPara.Text = cadenaF.Substring(0, cadenaF.Length - correos(correos.Length - 1).ToString.Length) + lstBusqueda.Items(lstBusqueda.SelectedIndex).ToString.Split(" ")(0) + ";"
                txtPara.Focus()
                txtPara.Select(txtPara.Text.Length, 0)
                lstBusqueda.Visible = False
                lstBusqueda.Left = lstBusqueda.Location.X + txtPara.Text.ToString.Length
            Else
                If lstBusqueda.Location.Y = 81 Then
                    txtCC.Text = cadenaF.Substring(0, cadenaF.Length - correos(correos.Length - 1).ToString.Length) + lstBusqueda.Items(lstBusqueda.SelectedIndex).ToString.Split(" ")(0) + ";"
                    txtCC.Focus()
                    txtCC.Select(txtCC.Text.Length, 0)
                    lstBusqueda.Visible = False
                    lstBusqueda.Left = lstBusqueda.Location.X + txtCC.Text.ToString.Length
                Else
                    If lstBusqueda.Location.Y = 104 Then
                        txtCCO.Text = cadenaF.Substring(0, cadenaF.Length - correos(correos.Length - 1).ToString.Length) + lstBusqueda.Items(lstBusqueda.SelectedIndex).ToString.Split(" ")(0) + ";"
                        txtCCO.Focus()
                        txtCCO.Select(txtCCO.Text.Length, 0)
                        lstBusqueda.Visible = False
                        lstBusqueda.Left = lstBusqueda.Location.X + txtCCO.Text.ToString.Length
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Dim cadenaF As String = ""

    Private Sub btnAdjuntar_Click_1(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        OpenFileDialog1.Filter = "Todos los Archivos (*.*)|*.*"
        OpenFileDialog1.Title = "Adjuntar Archivos"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        CargarAdjuntos(OpenFileDialog1.FileName)
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click

        If Me.lstAdjuntados.SelectedIndex > -1 Then
            llListaAdjunto.RemoveAt(Me.lstAdjuntados.SelectedIndex)
            lstAdjuntados.Items.RemoveAt(Me.lstAdjuntados.SelectedIndex)
        Else
            mensajeEmergente.Confirmacion("Debe seleccionar un archivo", True)
        End If
    End Sub

    Private Sub txtPara_TextChanged(sender As Object, e As EventArgs) Handles txtPara.TextChanged
        Try
            Me.lstBusqueda.Location = New Point(81, 55)
            Dim cont As Integer = 0
            lstBusqueda.Items.Clear()
            correos = txtPara.Text.ToString.Split(";")
            cadenaF = txtPara.Text.ToString
            For Each cadena As e_Combo In listaCorreos
                If (cadena.Nombre + " " + cadena.Descripcion).ToUpper.Contains(correos(correos.Length - 1).ToString.ToUpper) Then
                    lstBusqueda.Items.Add(cadena.Nombre + " " + cadena.Descripcion)
                    cont += 1
                End If
            Next
            If cont = 0 Then
                lstBusqueda.Visible = False
            Else
                lstBusqueda.Refresh()
                lstBusqueda.Visible = True
            End If
            If txtPara.Text.ToString.Trim.Length = 0 Then
                Me.lstBusqueda.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub txtPara_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPara.KeyDown
        Try
            If e.KeyCode = Keys.Down Then
                If lstBusqueda.Items.Count > 0 Then
                    lstBusqueda.Focus()
                    lstBusqueda.SelectedIndex = 0
                End If

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        bandDemandaEnviada = "S"
        EnviarCorreo()
    End Sub

    Private Sub txtCC_TextChanged(sender As Object, e As EventArgs) Handles txtCC.TextChanged
        Try
            Me.lstBusqueda.Location = New Point(81, 81)
            Dim cont As Integer = 0
            lstBusqueda.Items.Clear()
            correos = txtCC.Text.ToString.Split(";")
            cadenaF = txtCC.Text.ToString
            For Each cadena As e_Combo In listaCorreos
                If (cadena.Nombre + " " + cadena.Descripcion).ToUpper.Contains(correos(correos.Length - 1).ToString.ToUpper) Then
                    lstBusqueda.Items.Add(cadena.Nombre + " " + cadena.Descripcion)
                    cont += 1
                End If
            Next
            If cont = 0 Then
                lstBusqueda.Visible = False
            Else
                lstBusqueda.Refresh()
                lstBusqueda.Visible = True
            End If
            If txtCC.Text.ToString.Trim.Length = 0 Then
                Me.lstBusqueda.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub txtCC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCC.KeyDown
        Try
            If e.KeyCode = Keys.Down Then
                If lstBusqueda.Items.Count > 0 Then
                    lstBusqueda.Focus()
                    lstBusqueda.SelectedIndex = 0
                End If

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCCO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCCO.KeyDown
        Try
            If e.KeyCode = Keys.Down Then
                If lstBusqueda.Items.Count > 0 Then
                    lstBusqueda.Focus()
                    lstBusqueda.SelectedIndex = 0
                End If

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCCO_TextChanged(sender As Object, e As EventArgs) Handles txtCCO.TextChanged
        Try
            Me.lstBusqueda.Location = New Point(81, 104)
            Dim cont As Integer = 0
            lstBusqueda.Items.Clear()
            correos = txtCCO.Text.ToString.Split(";")
            cadenaF = txtCCO.Text.ToString
            For Each cadena As e_Combo In listaCorreos
                If (cadena.Nombre + " " + cadena.Descripcion).ToUpper.Contains(correos(correos.Length - 1).ToString.ToUpper) Then
                    lstBusqueda.Items.Add(cadena.Nombre + " " + cadena.Descripcion)
                    cont += 1
                End If
            Next
            If cont = 0 Then
                lstBusqueda.Visible = False
            Else
                lstBusqueda.Refresh()
                lstBusqueda.Visible = True
            End If
            If txtCCO.Text.ToString.Trim.Length = 0 Then
                Me.lstBusqueda.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub txtMensaje_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles txtMensaje.DocumentCompleted
    '    txtMensaje.DocumentText = "<Html><body>uuuu</body></html>"
    'End Sub
    Dim c = 0
    Private Sub txtMensaje_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles txtMensaje.DocumentCompleted
        If c = 0 Then
            txtMensaje.DocumentText = "<Html><body>" & cadenaMensajeHtml & "</body></html>"
            c = 1
        End If

    End Sub

    Dim olDemanda As New l_Demanda
    Private Sub btnConfirmarAtras_Click(sender As Object, e As EventArgs) Handles btnConfirmarAtras.Click
        Try
            Dim oeDemanda As New e_Demanda
            oeDemanda.Id = confirmarDemanda
            oeDemanda.UsuarioCreacion = gUsuarioSGI.Id
            If btnConfirmarAtras.Text = "Salir" Then
                Me.Close()
            Else
                If olDemanda.ConfirmarDemanda(oeDemanda) Then
                    If MessageBox.Show("Demanda Confirmada. ¿Desea enviar correo?", "Información del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then                        
                        groupDatosCorreo.Visible = True
                        agrAdjunto.Text = "Mensaje de Correo"
                        txtMensajeExtra.Visible = True
                        groupDatosCorreo.Dock = DockStyle.Fill
                        agrAdjunto.Dock = DockStyle.Bottom
                        Me.btnConfirmarAtras.Text = "Salir"
                        Me.txtMensaje.Dock = DockStyle.Bottom
                    Else
                        Me.Close()
                    End If
                End If
            End If            
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
