'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports System.IO
Imports System.Net
Imports Infragistics.Win

Public Class frm_EnvioCorreo

    Inherits ISL.Win.frm_MenuPadre

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
    Public cadenaMensaje As String = ""

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
        Return True
    End Function

    Public Function DemandaRapida() As Boolean
        txtDe.Text = "consultores.tecnologicos.2010@gmail.com"
        txtDe.Enabled = False
        txtAsunto.Text = "Demanda Rapida"  
        txtMensaje.Text = ""
        Return True
    End Function

    Public Function SeguienteFalla(Mensaje As String) As Boolean
        txtDe.Text = "consultores.tecnologicos.2010@gmail.com"
        txtDe.Enabled = False
        txtAsunto.Text = "Incidencia OP"
        txtMensaje.Text = Mensaje
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
        Me.txtMensaje.Text = String.Empty

        LimpiaGrid(griListadoArchivos, ogdListadoArchivos)
        LimpiaGrid(griListaCorreo, ogdCorreos)
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
            txtPara.Value = ms_Email
            CargarAdjuntos(ms_Documento)
        Else
            txtPara.Value = ms_Email
        End If
        txtMensaje.Value = ms_Mensaje
    End Sub

    Sub CargarAdjuntos(ByVal Ruta As String)
        Dim NomArchivo As Object() = Split(Ruta, "\")
        Dim oeArchivo As New e_Archivo
        oeArchivo.RutaDocumento = Ruta
        oeArchivo.Nombre = NomArchivo(NomArchivo.Length - 1)
        llListaAdjunto.Add(oeArchivo)
        griListadoArchivos.DataSource = llListaAdjunto
        griListadoArchivos.DataBind()
        With griListadoArchivos
            'Ubica el cursor el el primer registro de la grilla
            If .Rows.Count > 0 Then
                .Focus()
                .Rows.Item(0).Selected = True                 
            End If
        End With
    End Sub


    Private Function quitarAdjunto(ByVal oeAr As e_Archivo) As Boolean
        If oeAr.Seleccion Then sw = 1
        Return oeAr.Seleccion
    End Function


#End Region

#Region "Eventos"

    Private Sub frm_EnvioCorreo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
        If Modulo = "Liquidaciones" Then
            Liquidaciones()
        Else
            If Modulo = "Seguimiento" Then
                SeguienteFalla(MensajeCorreo)
            Else
                If Modulo = "DemandaRapida" Then
                    DemandaRapida()
                Else
                    CargarDatos()
                End If
            End If
        End If
    End Sub

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
    Private Sub btnAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntar.Click
        OpenFileDialog1.Filter = "Todos los Archivos (*.*)|*.*"
        OpenFileDialog1.Title = "Adjuntar Archivos"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        CargarAdjuntos(OpenFileDialog1.FileName)
    End Sub


    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

        Try
            sw = 0
            With griListadoArchivos                
                If .ActiveRow.Index > -1 Then
                    llListaAdjunto.RemoveAll(AddressOf quitarAdjunto)
                    griListadoArchivos.DataBind()
                    'Else
                    '    sw = 1
                End If
                'If llListaAdjunto.Count > 0 AndAlso sw = 1 Then
                '    Throw New Exception("Seleccione un documento para quitarlo de la lista. ")
                'End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub griListaOrdenCompra_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        Try
            griListadoArchivos.UpdateData()
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message)            
        End Try
    End Sub




#End Region

#Region "Menu y tabs"

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
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
            If Not txtPara.Value Is Nothing Then txtPara.Value = txtPara.Value.ToString.Trim
            If Not txtAsunto.Value Is Nothing Then txtAsunto.Value = txtAsunto.Value.ToString.Trim
            If Not txtMensaje.Value Is Nothing Then txtMensaje.Value = txtMensaje.Value.ToString.Trim

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

            If ls_ListaAdjuntos <> "" Then ls_ListaAdjuntos = Strings.Left(ls_ListaAdjuntos, ls_ListaAdjuntos.Length - 1)
            EnviarEmail(txtDe.Value, txtPara.Value, txtCC.Value, txtCCO.Value, txtAsunto.Value, IIf(Me.cadenaMensaje.Trim <> "", Me.cadenaMensaje, txtMensaje.Value), ls_ListaAdjuntos)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            ugb_Espera.Visible = False
            Me.cadenaMensaje = ""
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

    Private Sub btnListarCorreos_Click(sender As Object, e As EventArgs) Handles btnListarCorreos.Click
        Try
            oeCombo = New e_Combo
            olCombo = New l_Combo
            oeCombo.Nombre = "CORREOS"
            griListaCorreo.DataSource = olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListadoArchivos_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListadoArchivos.CellChange
        griListadoArchivos.UpdateData()
    End Sub

    Private Sub griListaCorreo_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCorreo.CellChange
        griListaCorreo.UpdateData()
    End Sub

    Private Sub griListaCorreo_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaCorreo.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub griListadoArchivos_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListadoArchivos.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub griListaCorreo_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCorreo.AfterCellUpdate
        Try
            Dim Total_Selec As Integer = 0
            Select Case e.Cell.Column.Key
                Case "Id"
                    If griListaCorreo.Rows.Count > 1 Then
                        If griListaCorreo.ActiveRow.Cells("Id").Value Then
                            Total_Selec += 1
                            griListaCorreo.ActiveRow.Appearance.BackColor = Color.Aqua
                            griListaCorreo.ActiveRow.Fixed = True
                        Else
                            Total_Selec -= 1
                            griListaCorreo.ActiveRow.Appearance.BackColor = Color.White
                            griListaCorreo.ActiveRow.Fixed = False
                        End If
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarPara_Click(sender As Object, e As EventArgs) Handles btnAgregarPara.Click
        AgregarCorreos(txtPara)
    End Sub

    Private Function AgregarCorreos(ByVal txt As UltraWinEditors.UltraTextEditor) As Boolean
        Try
            Dim Correos As String = ""
            For Each Fila As UltraWinGrid.UltraGridRow In griListaCorreo.Rows.Where(Function(Iten) Iten.Cells("Id").Value = True)
                If Correos <> "" Then
                    Correos += ";"
                End If
                Correos += Fila.Cells("Nombre").Value
            Next
            If Correos = "" Then
                Throw New Exception("No hay correos seleccione para agregar.")
            End If
            txt.Text = Correos
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Function

    Private Sub btnAgregarCC_Click(sender As Object, e As EventArgs) Handles btnAgregarCC.Click
        AgregarCorreos(txtCC)
    End Sub

    Dim list As New List(Of String)
    Private Sub txtPara_TextChanged(sender As Object, e As EventArgs) Handles txtPara.TextChanged
        'txtPara.Text = displayMembers(list)
       
    End Sub
   
    'Public Function displayMembers(ByVal lista As List(Of String)) As String
    '    Dim listaN As New List(Of String)
    '    For i As Integer = 0 To lista.Count - 1
    '        If Not lista.Item(i).ToString.Contains(txtPara.Text.ToString) Then
    '            listaN.Add(lista.Item(i))
    '        End If
    '    Next
    '    Return String.Join(Environment.NewLine, listaN.ToArray())
    'End Function



End Class
