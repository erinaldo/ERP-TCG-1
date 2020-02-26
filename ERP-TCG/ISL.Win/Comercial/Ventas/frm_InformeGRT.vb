'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_InformeGRT

    Inherits frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


    Private Shared instancia As frm_InformeGRT = Nothing
    Private Shared Operacion As String
    Private Estado As String
    ''' <summary>
    ''' Instancia unica de Formulario: frm_InformeGRT
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    '''
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_InformeGRT()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim oeGuiaTransportista As New e_GuiaTransportista
    Dim olGuiaTransportista As New l_GuiaTransportista

    Dim GuiaTransportistaLista As New List(Of e_GuiaTransportista)

    Dim oeGuiaRemitente As New e_GuiaRemitente
    Dim olGuiaRemitente As New l_GuiaRemitente

    Dim oeGuiaTransportistaInterrumpida As New e_GuiaTransportistaInterrumpida
    Dim olGuiaTransportistaInterrumpida As New l_GuiaTransportistaInterrumpida

    Dim olOperacion As New l_Operacion
    Dim oeOperacion As New e_Operacion

    Dim oeGuiasControl As New e_GuiasControl
    Dim olGuiasControl As New l_GuiasControl

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim ListaTracto As New List(Of e_Vehiculo)

    Dim oeFechas As New e_Fechas
    Dim _ingresando_datos As Boolean = False
    Dim Opcion As Boolean

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Operacion = "Inicializa"
        If Activo Then
            Estado = " Activo"
        Else
            Estado = " Inactivo"
        End If
        Try
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Nuevo"
            Inicializar()

            MostrarTabs(1, ficDemanda, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Inicializar()

            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            MostrarTabs(0, ficDemanda, 2)
            MyBase.Guardar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            MyBase.Imprimir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún Informe de Guía de Remisión Transportista para exportar al Excel")
            Exportar_Excel(griLista)

            MyBase.Exportar()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = Date.Today.AddDays(-5)
        fecHasta.Value = Date.Today.AddDays(+1)
    End Sub

    Private Sub frm_InformeGRT_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_InformeGRT_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficDemanda)
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
        End Select
    End Sub

    Private Sub frm_InformeGRT_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        txtRangoFinalNumeroAnulado.Text = String.Empty
        txtCorrelativo.Text = String.Empty
        txtStockGuias.Text = String.Empty
        txtStockTalonarios.Text = String.Empty
    End Sub

    Public Sub LlenaCombos()
        LlenarCombo(cboTracto, "Nombre", TractoPublic, -1)
    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If txtNumero.Text <> "" And txtRangoFinalNumeroAnulado.Text <> "" Then
                ValidarGrtAnular(txtNumero, txtRangoFinalNumeroAnulado)
            End If
            oeGuiaTransportista = New e_GuiaTransportista
            If verTracto.Checked Then
                l_FuncionesGenerales.ValidarCampoNoNulo(cboTracto.Text, "Ingrese Tracto")
                oeGuiaTransportista.Serie = ""
                oeGuiaTransportista.Inicial = ""
                oeGuiaTransportista.Final = ""
                oeGuiaTransportista.IdVehiculo = cboTracto.Value
                oeGuiaTransportista.FechaDesde = fecDesde.Value
                oeGuiaTransportista.FechaHasta = fecHasta.Value
            Else
                l_FuncionesGenerales.ValidarCampoNoNulo(txtSerie.Text, "Ingrese Serie")
                oeGuiaTransportista.Serie = txtSerie.Text
                oeGuiaTransportista.Inicial = txtNumero.Text
                oeGuiaTransportista.Final = txtRangoFinalNumeroAnulado.Text
                oeGuiaTransportista.IdVehiculo = ""
                oeGuiaTransportista.FechaDesde = ""
                oeGuiaTransportista.FechaHasta = ""
            End If
            griLista.DataSource = olGuiaTransportista.ListarInformeGrt(oeGuiaTransportista)
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                If fila.Cells("IndGrtConfirmada").Value Then
                    If fila.Cells("IndDocumentos").Value Then
                        fila.CellAppearance.BackColor = Me.colorConfConDoct.Color
                    Else
                        fila.CellAppearance.BackColor = Me.colorConfSinDoct.Color
                    End If
                    If fila.Cells("IndFacturado").Value And fila.Cells("IndDocumentos").Value Then
                        fila.CellAppearance.BackColor = Me.colorFactConDoct.Color
                    Else
                        If fila.Cells("IndFacturado").Value And fila.Cells("IndDocumentos").Value = False Then
                            fila.CellAppearance.BackColor = Me.colorFactSinDoct.Color
                        End If
                    End If
                Else
                    If fila.Cells("Viaje").Value = "ANULADO" Then
                        fila.CellAppearance.BackColor = Me.colorAnulado.Color
                    Else
                        If fila.Cells("Viaje").Value = "N.E" Then
                            fila.CellAppearance.BackColor = Me.colorNE.Color
                        End If
                    End If
                End If
                If fila.Cells("IndGrtPerdido").Value Then
                    fila.Cells("Serie").Appearance.BackColor = Me.colorDoctPerdido.Color
                    fila.Cells("Numero").Appearance.BackColor = Me.colorDoctPerdido.Color
                End If
            Next

            'Ubica el cursor el el primer registro de la grilla
            If griLista.Rows.Count > 0 Then
                griLista.Focus()
                griLista.Rows.Item(0).Selected = True
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            End If
            griLista.Focus()
            'InicializaTiempo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Function ValidarGrtAnular(ByVal txt_controlInicial As UltraWinMaskedEdit.UltraMaskedEdit, ByVal txt_controlFinal As UltraWinMaskedEdit.UltraMaskedEdit) As Boolean
        Try
            Dim ls_NroDocInicial As String = "", _
                    ls_NroDocFinal As String = ""
            ls_NroDocInicial = txt_controlInicial.Text
            ls_NroDocFinal = txt_controlFinal.Text
            If CDbl(ls_NroDocInicial) > CDbl(ls_NroDocFinal) Then
                txt_controlFinal.Focus()
                Throw New Exception("Nº Documento Inicial debe ser Menor a Nº Documento Final")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

    Private Sub frm_InformeGRT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaCombos()
        ControlRangoFechaInicializa()
    End Sub

    Private Sub verTracto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTracto.CheckedChanged
        If verTracto.Checked Then
            Inicializar()
            exgruViaje.Enabled = False
            cboTracto.Enabled = verTracto.Checked
            cboTracto.Focus()
        Else
            Inicializar()
            exgruViaje.Enabled = True
            cboTracto.Enabled = verTracto.Checked
            cboTracto.Text = ""
        End If
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        If txtSerie.Text <> "" Then
            txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
            oeGuiasControl = New e_GuiasControl
            oeGuiasControl.Serie = txtSerie.Text
            oeGuiasControl = olGuiasControl.Obtener(oeGuiasControl)
            If oeGuiasControl.Activo Then
                cboTracto.Value = oeGuiasControl.IdVehiculo
                txtCorrelativo.Value = oeGuiasControl.Correlativo
                txtStockGuias.Value = oeGuiasControl.StockGuias
                txtStockTalonarios.Value = oeGuiasControl.StockTalonarios
            End If
        End If
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        If txtNumero.Text <> "" Then
            txtNumero.Text = FormatoDocumento(txtNumero.Text, 8)
        End If
    End Sub

    Private Sub txtRangoFinalNumeroAnulado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRangoFinalNumeroAnulado.Validated
        If txtRangoFinalNumeroAnulado.Text <> "" Then
            txtRangoFinalNumeroAnulado.Text = FormatoDocumento(txtRangoFinalNumeroAnulado.Text, 8)
        End If
    End Sub

    Private Sub cboTracto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTracto.Validated
        oeGuiasControl = New e_GuiasControl
        oeGuiasControl.IdVehiculo = cboTracto.Value
        oeGuiasControl = olGuiasControl.Obtener(oeGuiasControl)
        If oeGuiasControl.Activo Then
            txtSerie.Text = oeGuiasControl.Serie
            txtCorrelativo.Value = oeGuiasControl.Correlativo
            txtStockGuias.Value = oeGuiasControl.StockGuias
            txtStockTalonarios.Value = oeGuiasControl.StockTalonarios
        End If
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        griLista.Text = "INFORME GUIA TRANSPORTISTA -- Lista Registros: " & e.Layout.Rows.Count
    End Sub

    Private Sub frm_InformeGRT_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub fecDesde_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecDesde.Validating
        If fecDesde.Value = Nothing Then
            fecDesde.Value = Today.Date
        End If
    End Sub

    Private Sub fecHasta_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecHasta.Validating
        If fecHasta.Value = Nothing Then
            fecHasta.Value = Today.Date
        End If
    End Sub

End Class



