'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports System.IO
Imports System.Configuration
Imports Infragistics.Win
Imports System.Text

Public Class frm_PagoRetencion
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento

    Private oeDocumentoRetencion As New e_DocumentoRetencion

    Private olAsiento As New l_Asiento

    Private leMovDoc As New List(Of e_MovimientoDocumento)
    Private leMovDocAgregado As New List(Of e_MovimientoDocumento)
    Private leProeveedor As New List(Of e_Proveedor)
    Private leRetencion As New List(Of e_DocumentoRetencion)

    Private MontoCuota As Double

    Private Shared instancia As frm_PagoRetencion = Nothing
    Private Shared Operacion As String
    Private Ejercicio As Integer = 0
    Private ln_TasaRetencion As Double = 0

    Private olDocElectronico As l_ComprobanteElectronico
    Private olConfiguracion As l_Configuracion

    Private olRetencion As l_DocumentoRetencion

#End Region

#Region "Inicialización del formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_PagoRetencion()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Select Case tcCobranza.SelectedTab.Index
                Case 0 : Listar(Activo)
                Case 1
                    If ficRetencion.SelectedTab.Index = 0 Then
                        Retencion()
                    ElseIf ficRetencion.SelectedTab.Index = 1 Then
                        mt_ListarAnulados()
                    Else
                        Dim dt As DataTable
                        Dim oeComprobanteBath As New e_ComprobanteElectronicoBath
                        Dim olComprobanteBath As New l_ComprobanteElectronicoBath
                        oeComprobanteBath.TipoOperacion = ""
                        oeComprobanteBath.TipoReferencia = "2"
                        oeComprobanteBath.FechaCrea = fecInicio.Value
                        oeComprobanteBath.FechaModifica = fecFin.Value
                        dt = olComprobanteBath.ListarTicket(oeComprobanteBath).Tables(0)
                        CargarTicket(dt)
                    End If

            End Select
            If tcCobranza.SelectedTab.Index = 0 Then
                If gridPagoAgregado.Rows.Count = 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) Else ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
            Else
                If ficRetencion.SelectedTab.Index = 0 Then
                    If Grilla1.Rows.Count = 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) Else ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                Else
                    If griAnulados.Rows.Count = 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) Else ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarTicket(ByVal loFacturados As DataTable)
        Try
            gridTicket.DataSource = loFacturados
            With gridTicket
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                OcultarColumna(gridTicket, True, "Id", "TipoReferencia", "UsuarioCrea", "FechaCrea", "UsuarioModifica", "FechaModifica")

                .DisplayLayout.Bands(0).Columns("FechaEnvio").SortIndicator = SortOrder.Ascending

                .DisplayLayout.Bands(0).Columns("Id").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("TipoReferencia").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("FechaEnvio").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("xmlbase64").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("nombrexml").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("cdrxml").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Ticket").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("IndBaja").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("UsuarioCrea").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("FechaCrea").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("UsuarioModifica").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("FechaModifica").Header.VisiblePosition = 13

                .DisplayLayout.Bands(0).Columns("Id").Width = 80
                .DisplayLayout.Bands(0).Columns("TipoReferencia").Width = 30
                .DisplayLayout.Bands(0).Columns("FechaEnvio").Width = 70
                .DisplayLayout.Bands(0).Columns("xmlbase64").Width = 120
                .DisplayLayout.Bands(0).Columns("nombrexml").Width = 120
                .DisplayLayout.Bands(0).Columns("cdrxml").Width = 120
                .DisplayLayout.Bands(0).Columns("Ticket").Width = 120
                .DisplayLayout.Bands(0).Columns("IndBaja").Width = 30
                .DisplayLayout.Bands(0).Columns("Estado").Width = 80
                .DisplayLayout.Bands(0).Columns("UsuarioCrea").Width = 100
                .DisplayLayout.Bands(0).Columns("FechaCrea").Width = 70
                .DisplayLayout.Bands(0).Columns("UsuarioModifica").Width = 100
                .DisplayLayout.Bands(0).Columns("FechaModifica").Width = 70

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = UltraGridFilterUIProvider1

                .DisplayLayout.Override.RowSelectorNumberStyle = UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = UltraWinGrid.CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
            apariencia_Estados_Grilla(gridTicket)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub apariencia_Estados_Grilla(ByVal grilla As UltraWinGrid.UltraGrid)
        Try
            If grilla.Name = "gridTicket" Then
                For Each fila In grilla.Rows
                    Select Case Trim(fila.Cells("Estado").Value)
                        Case "A", "ACEPTADA"
                            fila.CellAppearance.BackColor = colorAceptado.Color
                        Case "R", "RECHAZADA"
                            fila.CellAppearance.BackColor = colorRechazado.Color
                        Case "E", "EN PROCESO"
                            fila.CellAppearance.BackColor = colorProceso.Color
                    End Select
                Next
            Else
                For Each fila In grilla.Rows
                    Select Case fila.Cells("EstadoElectronico").Value
                        Case "A", "ACEPTADA"
                            fila.CellAppearance.BackColor = colorAceptado.Color
                        Case "R", "RECHAZADA"
                            fila.CellAppearance.BackColor = colorRechazado.Color
                        Case "E", "EN PROCESO"
                            fila.CellAppearance.BackColor = colorProceso.Color
                    End Select
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If tcCobranza.Tabs(0).Selected = True Then
                If GuardarPago() Then
                    limpiarcontroles()
                    Listar(True)
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    txtNumero.Text = CStr(CInt(txtNumero.Text) + 1)
                    txtNumero.Focus()
                End If
            Else
                Throw New Exception("No se puede guardar en en Listado de Retenciones.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMovimientoDocumento.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarPago() Then
                            Consultar(True)
                        End If
                    Case Windows.Forms.DialogResult.No
                        Consultar(True)
                End Select
            Else
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If tcCobranza.Tabs(0).Selected = True Then
                If gridPago.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(gridPago)
            ElseIf tcCobranza.Tabs(1).Selected = True Then
                If Grilla1.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(Grilla1)
            End If
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            If Grilla1.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Comprobante de Retención!")
            If Grilla1.ActiveRow.Index > -1 Then
                Dim oeRetencion As New e_DocumentoRetencion
                oeRetencion = Grilla1.ActiveRow.ListObject
                If oeRetencion.IndElectronico = 1 Then
                    Dim frmImpresion As New frm_ERetencion
                    frmImpresion.mt_CargarDatos(oeRetencion.Id)
                    frmImpresion.StartPosition = FormStartPosition.CenterScreen
                    frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                    frmImpresion.ShowDialog()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_PagoRetencion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If tcCobranza.SelectedTab.Index = 0 Then
            If gridPagoAgregado.Rows.Count = 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) Else ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
        Else
            If ficRetencion.SelectedTab.Index = 0 Then
                If Grilla1.Rows.Count = 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) Else ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            Else
                If griAnulados.Rows.Count = 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) Else ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            End If
        End If
    End Sub

    Private Sub frm_PagoRetencion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_PagoRetencion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_PagoRetencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            inicializar()
            fecInicio.Value = DateAdd(DateInterval.Day, -15, Date.Now)
            Grilla1.DataSource = leRetencion
            Ejercicio = Date.Parse(fecRetencion.Value).Year
            ln_TasaRetencion = ObtenerRetencion()
            chkProveedor.Checked = False
            OcultarColumna(gridPago, True, "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "Retencion", "MontoCanje")
            OcultarColumna(gridPagoAgregado, True, "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "Retencion", "EstadoSunat", "MontoCanje")
            Validar_TipoCambio()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridVentas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridPago.DoubleClick
        Try
            AgregarDetalle()
            If gridPagoAgregado.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DecTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTC.ValueChanged
        mostrar_totales()
    End Sub

    Private Sub fecRetencion_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecRetencion.Validated
        Try
            If oeDocumentoRetencion.TipoOperacion = "I" Then
                DecTC.Value = TipoCambio(fecRetencion.Value)(0)
            End If
            If Ejercicio <> Date.Parse(fecRetencion.Value).Year Then
                Ejercicio = Date.Parse(fecRetencion.Value).Year
                leMovDocAgregado = New List(Of e_MovimientoDocumento)
                leMovDoc = New List(Of e_MovimientoDocumento)
                LimpiaGrid(gridPago, UltraDataSource1)
                LimpiaGrid(gridPagoAgregado, UltraDataSource2)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridCobranzaAgregado_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridPagoAgregado.CellChange
        Try
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            If IsNumeric(e.Cell.Value) Then
                Dim obj As New e_MovimientoDocumento
                obj = gridPagoAgregado.ActiveRow.ListObject
                If Math.Abs(obj.Saldo) < Math.Abs(CDbl(e.Cell.Value)) Then Throw New Exception("El monto ingresado es mayor al saldo")
                gridPagoAgregado.UpdateData()
                mostrar_totales()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarDocumento.Click
        Try
            QuitarDetalle()
            If gridPagoAgregado.Rows.Count = 0 Then
                ControlBoton(1, 0, 0, 0, 0, , 0, 0, 1)
            Else
                ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub txtSerie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
        'If txtNumero.Text = "" Then
        ConsultarUltimoNroDoc(txtSerie.Text, True)
        'End If
    End Sub

    Private Sub txtNumero_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
    End Sub

    Private Sub ActualizarStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarStripMenuItem1.Click
        Retencion()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarRetencion()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        DocumentoRetencionAnulado()
    End Sub

    Private Sub btanCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btanCancelar.Click
        Limpiar()
    End Sub

    Private Sub txtSerieAgregar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieAgregar.ValueChanged
        txtSerieAgregar.Text = FormatoDocumento(txtSerieAgregar.Text, 4)
        ConsultarUltimoNroDoc(txtSerieAgregar.Text, False)
    End Sub

    Private Sub txtNroAgregar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroAgregar.ValueChanged
        txtNroAgregar.Text = FormatoDocumento(txtNroAgregar.Text, 10)
    End Sub

    Private Sub tcCobranza_SelectedTabChanged(sender As Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tcCobranza.SelectedTabChanged
        If tcCobranza.SelectedTab.Index = 0 Then
            If gridPagoAgregado.Rows.Count = 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) Else ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
        Else
            If ficRetencion.SelectedTab.Index = 0 Then
                If Grilla1.Rows.Count = 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) Else ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            Else
                If griAnulados.Rows.Count = 0 Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1) Else ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            End If
        End If
    End Sub

    Private Sub btnEnviarSunat_Click(sender As Object, e As EventArgs) Handles btnEnviarSunat.Click
        Try
            Dim oeRetencion As New e_DocumentoRetencion, olRetencion As New l_DocumentoRetencion
            If ficRetencion.SelectedTab.Index = 0 Then
                If Grilla1.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Comprobante de Retención para Enviar a SUNAT!")
                If Grilla1.ActiveRow.Index > -1 Then
                    oeRetencion = Grilla1.ActiveRow.ListObject
                    If oeRetencion.IndElectronico = 0 Then Throw New Exception("¡Seleccione un Comprobante de Retención Electronico!")
                    If oeRetencion.IndEnviado Then Throw New Exception("¡Este Comprobante Electronico ya ha sido enviado a SUNAT!")
                    oeRetencion.TipoOperacion = "E"
                    olRetencion.EnviarSunat(oeRetencion)
                    mensajeEmergente.Confirmacion("¡El Comprobante Electronico fue enviado correctamente a SUNAT!", True)
                    Retencion()
                End If
            Else
                If griAnulados.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Comprobante de Retención para Enviar a SUNAT!")
                If griAnulados.ActiveRow.Index > -1 Then
                    oeRetencion = griAnulados.ActiveRow.ListObject
                    If oeRetencion.IndElectronico = 0 Then Throw New Exception("¡Seleccione un Comprobante de Retención Electronico!")
                    If oeRetencion.EstadoElectronico = "C" Or oeRetencion.EstadoElectronico = "R" Then
                        oeRetencion.FechaEmision = fecInicio.Value
                        oeRetencion.TipoOperacion = "C"
                        olRetencion.ComunicaBajaSunat(oeRetencion)
                        mensajeEmergente.Confirmacion("¡El Comunicacion de Baja fue enviado correctamente a SUNAT!", True)
                        mt_ListarAnulados()
                    ElseIf oeDocumentoRetencion.EstadoElectronico = "A" Then
                        Throw New Exception("¡El Comprobante de Retención Electronica ya ha sido aceptado por Sunat!")
                    Else
                        Throw New Exception("¡El Comprobante de Retención Electronica ya ha sido enviado a Sunat!")
                    End If

                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnXml_Click(sender As Object, e As EventArgs) Handles btnXml.Click
        Try
            Dim strRuta As String = ""
            Dim strNombre As String = ""
            If Grilla1.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Comprobante de Retención!")
            If Grilla1.ActiveRow.Index > -1 Then
                Dim oeRetencion As New e_DocumentoRetencion
                oeRetencion = Grilla1.ActiveRow.ListObject
                If oeRetencion.IndElectronico = 1 Then
                    If Not oeRetencion.IndEnviado Then Throw New Exception("¡El Comprobante no ha sido enviado a SUNAT!")
                    olDocElectronico = New l_ComprobanteElectronico : olConfiguracion = New l_Configuracion
                    strRuta = olConfiguracion.DocElectronico
                    strNombre = olDocElectronico.Obtener(New e_ComprobanteElectronico With {.TipoReferencia = 2, .IdReferencia = oeRetencion.Id}).nombrexml
                    'If File.Exists(strRuta.Trim() & "\Retencion\" & strNombre.Trim() & ".zip") Then
                    '    My.Computer.FileSystem.CopyFile(strRuta.Trim() & "\Retencion\" & strNombre.Trim() & ".zip", "D:\" & strNombre.Trim() & ".zip")
                    'Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
                    'With sfd_Dialogo
                    '    .Filter = "Retencion Electronica (*.zip)|*.zip"
                    '    .DefaultExt = "zip"
                    '    .FilterIndex = 1
                    '    .Title = "Exportar a ..."
                    '    .FileName = strNombre.Trim()
                    'End With
                    'Dim result As DialogResult = sfd_Dialogo.ShowDialog()
                    'Dim stNombreArchivo As String = sfd_Dialogo.FileName
                    'If result = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    'If File.Exists(stNombreArchivo) = False Then File.Create(stNombreArchivo)
                    'End If
                    Dim SdGuardar As New System.Windows.Forms.SaveFileDialog
                    strRuta = strRuta.Trim() & "\Retencion\" & strNombre.Trim() & ".ZIP"
                    If File.Exists(strRuta.Trim()) Then
                        SdGuardar.FileName = strNombre.Trim() & ".ZIP"
                        SdGuardar.DefaultExt = ".ZIP"
                        SdGuardar.Filter = "*.ZIP|Todos los archivos"
                        SdGuardar.Title = "Guardar ZIP"
                        If SdGuardar.ShowDialog = Windows.Forms.DialogResult.OK Then
                            My.Computer.FileSystem.CopyFile(strRuta, SdGuardar.FileName, True)
                        End If
                        'My.Computer.FileSystem.CopyFile(strRuta.Trim() & strNombre.Trim() & ".zip", unidad & strNombre.Trim() & ".zip")
                        'MsgBox("El archivo fue descargado en la dirección " & unidad & strNombre.Trim() & ".zip", MsgBoxStyle.Information, Me.Text)
                        'Process.Start("explorer.exe", unidad & strNombre.Trim() & ".zip")
                    Else
                        mensajeEmergente.Confirmacion("No existe archivo. Vuelva a Consultar a SUNAT para obtener el CDR.")
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            If Grilla1.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Comprobante de Retención para Enviar a SUNAT!")
            If Grilla1.ActiveRow.Index > -1 Then
                Dim oeRetencion As New e_DocumentoRetencion, olRetencion As New l_DocumentoRetencion
                oeRetencion = Grilla1.ActiveRow.ListObject
                If oeRetencion.IndElectronico = 0 Then Throw New Exception("¡Seleccione un Comprobante de Retención Electronico!")
                If oeRetencion.IndEnviado = 0 Then Throw New Exception("¡Seleccione un Comprobante de Retención Electronico Enviado a SUNAT!")
                If MessageBox.Show("¿Desea Anular este Comprobante?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    oeRetencion.TipoOperacion = "X"
                    oeRetencion.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olRetencion.Guardar(oeRetencion)
                    mensajeEmergente.Confirmacion("¡El Comprobante Electronico fue anulado!", True)
                    Retencion()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ficRetencion_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficRetencion.SelectedTabChanged
        fecFin.Enabled = IIf(ficRetencion.SelectedTab.Index = 1, False, True)
        btnAnular.Enabled = IIf(ficRetencion.SelectedTab.Index = 0, True, False)
        btnConsultar.Enabled = IIf(ficRetencion.SelectedTab.Index = 2 Or ficRetencion.SelectedTab.Index = 0, True, False)
    End Sub

    Private Sub chkProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles chkProveedor.CheckedChanged
        If chkProveedor.Checked Then cboProveedor.SelectedText = String.Empty
        cboProveedor.Enabled = Not chkProveedor.Checked
    End Sub

#End Region

#Region "Métodos"

    Private Sub limpiarcontroles()
        Try
            EtiImporteDolares.Text = "0"
            EtiImporteSoles.Text = "0"
            leMovDocAgregado.Clear()
            gridPagoAgregado.DataBind()
            LimpiaGrid(gridPago, UltraDataSource1)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Dim olDocRetDet As New l_DocumentoRetencionDetalle
            Me.Cursor = Cursors.WaitCursor
            If txtSerie.Text.Trim.Length = 0 Then Throw New Exception("¡Ingrese Serie de Retencion!")
            If gridPagoAgregado.Rows.Count > 0 Then
                If MessageBox.Show("Existen Pagos agregados, desea eliminarlos", "Mensaje del Sistema", _
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
               = Windows.Forms.DialogResult.Yes Then
                    leMovDocAgregado.Clear()
                    gridPagoAgregado.DataBind()
                Else
                    Exit Sub
                End If
            Else
                leMovDocAgregado.Clear()
            End If
            Me.Cursor = Cursors.WaitCursor
            If Microsoft.VisualBasic.Left(txtSerie.Text.Trim, 1) <> "R" Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento.Activo = Activo
                oeMovimientoDocumento.IdPeriodo = ""
                oeMovimientoDocumento.TipoOperacion = "PAG"
                oeMovimientoDocumento.Ejercicio = Date.Parse(fecRetencion.Value).Year
            End If
            LimpiaGrid(gridPago, UltraDataSource1)
            leMovDoc.Clear()
            If Microsoft.VisualBasic.Left(txtSerie.Text.Trim, 1) <> "R" Then
                leMovDoc.AddRange(olMovimientoDocumento.Listar(oeMovimientoDocumento))
            Else
                leMovDoc.AddRange(olDocRetDet.ListarDoc(New e_DocumentoRetencionDetalle With {.TipoOperacion = "D", .IdProveedor = IIf(chkProveedor.Checked, String.Empty, cboProveedor.Value), .NumeroPago = Date.Parse(fecRetencion.Value).Year}))
            End If
            gridPago.DataBind()
            With gridPago
                .DataSource = leMovDoc
            End With
            OcultarColumna(gridPago, True, "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "Retencion", "MontoCanje")
            OcultarColumna(gridPagoAgregado, True, "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "Retencion", "EstadoSunat", "MontoCanje")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            gridPago.Focus()
        End Try
    End Sub

    Private Sub LlenaMoneda()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            gridPago.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridPago.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridPago, True)
            '--------------------- para llenar combo en grilla    
            gridPagoAgregado.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridPagoAgregado.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridPagoAgregado, True)
            '-------------------------------
            With cboMoneda
                .DisplayMember = "Abreviatura"
                .ValueMember = "Id"
                .DataSource = leMoneda
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaTipoDocumentoOperacion()
        Try
            Dim oeTipoDoc As New e_TipoDocumento
            Dim leTipoDoc As New List(Of e_TipoDocumento)
            Dim olTipoDoc As New l_TipoDocumento
            oeTipoDoc.Activo = True
            oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            '--------------------- para llenar combo en grilla    
            gridPago.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With gridPago.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", gridPago, True)
            '------------------------------------------
            '--------------------- para llenar combo en grilla    
            gridPagoAgregado.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With gridPagoAgregado.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", gridPagoAgregado, True)
            '------------------------------------------
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            LlenaMoneda()
            LlenaTipoDocumentoOperacion()
            ComboProveedor()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboProveedor()
        Try
            If leProeveedor.Count = 0 Then
                Dim oeProveedor As New e_Proveedor
                Dim olProveedor As New l_Proveedor
                oeProveedor.Activo = True
                leProeveedor.AddRange(olProveedor.Listar(oeProveedor))
                '--------------------- para llenar combo en grilla    
                gridPago.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With gridPago.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Proveedor In leProeveedor
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", gridPago, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                gridPagoAgregado.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With gridPagoAgregado.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Proveedor In leProeveedor
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", gridPagoAgregado, True)
                '------------------------------------------     
                With cboProveedor
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leProeveedor
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDetalle()
        Try
            If gridPago.Rows.Count > 0 AndAlso Not gridPago.ActiveRow.ListObject Is Nothing Then
                Dim ls_Id As String = String.Empty
                Dim oeMovAux As e_MovimientoDocumento
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento = gridPago.ActiveRow.ListObject
                ls_Id = oeMovimientoDocumento.Id
                oeMovimientoDocumento.TipoOperacion = "I"
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                '-----------------------
                If ValidarAgregarDetalle(oeMovimientoDocumento) Then
                    With leMovDocAgregado
                        If Not .Contains(oeMovimientoDocumento) Then
                            .Add(oeMovimientoDocumento.Clonar)
                        Else
                            Throw New Exception("Ya existe este documento asociado")
                        End If
                        If Microsoft.VisualBasic.Left(txtSerie.Text.Trim, 1) = "R" Then
                            oeMovAux = New e_MovimientoDocumento
                            oeMovAux.Equivale = 1
                            oeMovAux.Id = ls_Id
                            If leMovDocAgregado.Contains(oeMovAux) Then
                                Dim _MontoPago As Double = 0
                                oeMovAux = leMovDocAgregado.Item(leMovDocAgregado.IndexOf(oeMovAux))
                                _MontoPago = oeMovAux.Saldo
                                oeMovAux.Total = CDbl(oeMovAux.Percepcion)
                                oeMovAux.MontoOperar = _MontoPago
                                oeMovAux.Saldo = CDbl(oeMovAux.PercepcionPorc)
                                oeMovAux.Percepcion = 0
                                oeMovAux.PercepcionPorc = 0
                            End If
                        End If
                    End With
                    mostrar_totales()
                    gridPagoAgregado.DataSource = leMovDocAgregado
                    gridPagoAgregado.DataBind()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub mostrar_totales()
        Try
            Dim importeMN As Double = 0
            Dim importeME As Double = 0
            For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
                With oeMovimientoDocumento
                    If .IdMoneda = "1CH01" Then
                        importeMN = importeMN + .MontoOperar
                        importeME = importeME + .MontoOperar / DecTC.Value
                    Else
                        importeMN = importeMN + .MontoOperar * DecTC.Value
                        importeME = importeME + .MontoOperar
                    End If
                End With
            Next

            importeME = Math.Round(importeME, 4)
            importeMN = Math.Round(importeMN, 4)
            EtiImporteSoles.Text = importeMN.ToString
            EtiImporteDolares.Text = importeME.ToString

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            If gridPagoAgregado.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(gridPagoAgregado, "Documentos x Rendir agregados")
            If Not gridPagoAgregado.ActiveRow.ListObject Is Nothing AndAlso gridPagoAgregado.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            'inicialializo mi objeto
            oeMovimientoDocumento = New e_MovimientoDocumento
            '---Obtengo O CAPTURO objeto de la grilla 
            oeMovimientoDocumento = gridPagoAgregado.ActiveRow.ListObject
            '----------------------
            With leMovDocAgregado
                '-----remuevo o elimino de mi lista de objetos
                .Remove(oeMovimientoDocumento)
                '-------------------
            End With
            mostrar_totales()
            gridPagoAgregado.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub inicializar()
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            gridPagoAgregado.DataSource = leMovDocAgregado
            gridPago.DataSource = leMovDoc
            oeDocumentoRetencion.TipoOperacion = "I"
            oeDocumentoRetencion.PrefijoID = gs_PrefijoIdSucursal '@0001
            LlenarCombos()
            DecTC.Value = TipoCambio(fecRetencion.Value, True)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ConsultarUltimoNroDoc(ByVal lsSerieDocumentoRetencion As String, ByVal ldBand As Boolean)
        Try
            Dim lsNumero As String = ""
            Dim olDocumentoRetencion As New l_DocumentoRetencion
            lsNumero = olDocumentoRetencion.UltimoNroRetencion(lsSerieDocumentoRetencion)
            If ldBand Then
                txtNumero.Text = lsNumero
            Else
                txtNroAgregar.Text = lsNumero
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Retencion()
        Try
            Dim oeRetencion As New e_DocumentoRetencion
            olRetencion = New l_DocumentoRetencion

            oeRetencion.Activo = 1
            oeRetencion.FechaEmision = fecInicio.Value
            oeRetencion.FechaFin = fecFin.Value
            leRetencion.Clear()
            LimpiaGrid(Grilla1, UltraDataSource3)
            leRetencion.AddRange(olRetencion.Listar(oeRetencion))
            Grilla1.DataSource = leRetencion
            Grilla1.DataBind()
            For Each fil In Grilla1.Rows
                If fil.Cells("EstadoElectronico").Value = "A" Then
                    fil.Appearance.FontData.Bold = DefaultableBoolean.True
                    fil.Appearance.BackColor = Color.LightSteelBlue
                End If
            Next
            apariencia_Estados_Grilla(Grilla1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarRetencion()
        Try
            If MessageBox.Show("Desea eliminar el Documento Retencion: " & Grilla1.ActiveRow.Cells("Serie").Value + "-" + Grilla1.ActiveRow.Cells("Numero").Value, _
                               "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                               = Windows.Forms.DialogResult.Yes Then
                Dim oeAsientoMovimiento As New e_AsientoMovimiento
                Dim olAsientoMovimiento As New l_AsientoMovimiento
                oeAsientoMovimiento.Id = Grilla1.ActiveRow.Cells("IdAsientoMovimiento").Value
                oeAsientoMovimiento = olAsientoMovimiento.Obtener(oeAsientoMovimiento)
                If Not oeAsientoMovimiento.IdAsiento Is Nothing AndAlso oeAsientoMovimiento.IdAsiento <> "" Then
                    Dim oeAsiento As New e_Asiento
                    Dim olAsiento As New l_Asiento
                    oeAsiento.Id = oeAsientoMovimiento.IdAsiento
                    oeAsiento.IdUsuarioCrea = gUsuarioSGI.IdTrabajador
                    If olAsiento.EliminarCobroPago(oeAsiento) Then
                        mensajeEmergente.Confirmacion("Retención " & Grilla1.ActiveRow.Cells("Serie").Value & " - " & Grilla1.ActiveRow.Cells("Numero").Value & " ha sido Eliminada.", True)
                        Retencion()
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DocumentoRetencionAnulado()
        Try
            If txtSerieAgregar.Text = "" Or txtNroAgregar.Text = "" Then
                Throw New Exception("Ingresar Serie y Numero")
            End If
            Dim olDocumentoRetencion As New l_DocumentoRetencion
            Dim oeDocumentoRetencion As New e_DocumentoRetencion
            With oeDocumentoRetencion
                .NombreTipoDoc = "RETENCION"
                .IdEstado = "ANULADO"
                .FechaEmision = FecEmisAgregar.Value
                .Serie = txtSerieAgregar.Value
                .Numero = txtNroAgregar.Value
                .Voucher = txtVoucherAgregar.Value
                .TipoOperacion = "I"
                .IdAsientoMovimiento = ""
            End With
            oeDocumentoRetencion.PrefijoID = gs_PrefijoIdSucursal '@0001
            olDocumentoRetencion.Guardar(oeDocumentoRetencion)
            Retencion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Limpiar()
        txtSerieAgregar.Text = ""
        txtNroAgregar.Text = ""
        txtVoucherAgregar.Text = ""
    End Sub

    Private Sub mt_ListarAnulados()
        Try
            olRetencion = New l_DocumentoRetencion
            griAnulados.DataSource = olRetencion.Listar(New e_DocumentoRetencion With {.TipoOperacion = "A", .FechaEmision = fecInicio.Value, .FechaFin = fecFin.Value})
            griAnulados.ResetDisplayLayout()
            ConfiguraGrilla(griAnulados, "Tahoma", True, UIElementBorderStyle.Default)
            OcultarColumna2(griAnulados, False, "Serie", "Numero", "FechaEmision", "NroDocElectronico", "EstadoElectronico", "IndElectronico", "IndEnviado", _
                            "IndAnulado", "IndEmail", "IndExterno")
            FormatoColumna(griAnulados, "", UltraWinGrid.ColumnStyle.CheckBox, HAlign.Default, "IndElectronico")
            griAnulados.Text = "Listado de Retenciones"
            apariencia_Estados_Grilla(griAnulados)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Funciones"

    Private Function GuardarPago() As Boolean

        Try
            If validarPagos() Then
                oeDocumentoRetencion = New e_DocumentoRetencion
                With oeDocumentoRetencion
                    .TipoOperacion = "I"
                    .Serie = txtSerie.Text
                    .Numero = txtNumero.Text
                    .Voucher = ""
                    .IdMoneda = cboMoneda.Value
                    .FechaEmision = fecRetencion.Value
                    .TipoCambio = DecTC.Value
                    .ImporteDol = EtiImporteDolares.Text
                    .ImporteSol = EtiImporteSoles.Text
                    .IdUsuario = gUsuarioSGI.Id
                    .MacPCLocal = MacPCLocal()

                    .IndElectronico = IIf(txtSerie.Text.Contains("R"), 1, 0)
                    .IndEnviado = False
                    .IndAnulado = False
                    .Regimen = "01"
                    .Tasa = ln_TasaRetencion
                    .Comentario = String.Empty
                    .IdMonedaRetencion = "1CH01"
                    .TipoCambioRetencion = DecTC.Value
                    '.ImporteRetencion = IIf(cboMoneda.Value = "1CH01", Math.Round(CDbl(EtiImporteSoles.Text), 2), Math.Round(CDbl(EtiImporteDolares.Text), 2))
                    .IdMonedaPagado = cboMoneda.Value
                    Dim total As Decimal = 0.0
                    Dim montooperar As Decimal = 0.0
                    For Each fila In gridPagoAgregado.Rows
                        total += (CDbl(fila.Cells("MontoOperar").Value) / ln_TasaRetencion)
                        montooperar += CDbl(fila.Cells("MontoOperar").Value)
                    Next
                    .ImportePagado = Math.Round(total, 2)
                    .ImporteRetencion = Math.Round(montooperar, 2)
                    .NroDocElectronico = String.Empty
                    .EstadoElectronico = "C"
                    .IndEmail = False
                    .IndExterno = False
                    .UsuarioCrea = gUsuarioSGI.Id
                    .UsuarioModifica = gUsuarioSGI.Id
                    .IdProveedor = leMovDocAgregado(0).IdClienteProveedor
                End With

                Dim ls_IdDet As String = String.Empty
                For Each _oeDet In leMovDocAgregado
                    ls_IdDet = ls_IdDet & "'" & _oeDet.IdMotivoDocumento & "',"
                Next
                If ls_IdDet.Trim.Length > 0 Then
                    ls_IdDet = Microsoft.VisualBasic.Left(ls_IdDet.Trim, Len(ls_IdDet.Trim) - 1)
                End If
                oeDocumentoRetencion.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olAsiento.GuardarPagoRetencion(leMovDocAgregado, oeDocumentoRetencion, ls_IdDet) Then
                    mensajeEmergente.Confirmacion("Pago(s) guardados satisfactoriamente", True)
                    If oeDocumentoRetencion.Id <> "" And Microsoft.VisualBasic.Left(oeDocumentoRetencion.Serie, 1) <> "R" Then
                        Dim frm2 As New frm_DocumentoRentencion(oeDocumentoRetencion.Id)
                        frm2.ShowDialog()
                        frm2 = Nothing
                    End If
                    Return True
                End If
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function validarPagos() As Boolean
        Try
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            If Double.Parse(EtiImporteSoles.Text) < 0 Then Throw New Exception("El importe debe ser mayor a 0")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtSerie.Text, "Ingrese la Serie")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtNumero.Text, "Ingrese el Número")
            If leMovDocAgregado.Count <= 0 Then Throw New Exception("No Existen Pagos para registrar")
            ValidarCombo(cboMoneda, "Moneda")
            validarmonto()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function validarmonto() As Boolean
        Try
            For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
                With oeMovimientoDocumento
                    Dim oeMovDoc As New e_MovimientoDocumento
                    oeMovDoc = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                    If Math.Round(oeMovDoc.Saldo, 2) >= Math.Round(oeMovimientoDocumento.Saldo, 2) Then
                        Return True
                    Else
                        oeMovDoc.Saldo = oeMovimientoDocumento.Saldo
                        gridPagoAgregado.DataBind()
                        Throw New Exception("El Monto a Cobrar es mayor al Saldo")
                    End If
                End With
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarAgregarDetalle(ByVal oeMovDoc As e_MovimientoDocumento) As Boolean
        Try
            If oeMovDoc.Saldo < 0 Then Throw New Exception("No se puede operar: es negativo")
            ValidarGrilla(gridPago, "Documentos x Pagar")
            If Not gridPago.ActiveRow Is Nothing AndAlso gridPago.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            If gridPagoAgregado.Rows.Count > 0 Then
                If gridPagoAgregado.Rows.Item(0).Cells("IdClienteProveedor").Value <> oeMovimientoDocumento.IdClienteProveedor Then
                    Throw New Exception("Solo puede agregar Documentos de un Solo Proveedor")
                End If
            End If
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Return False
        End Try
    End Function
    Private Sub DecTC_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles DecTC.EditorButtonClick
        Validar_TipoCambio()
    End Sub

    Private Sub fecRetencion_ValueChanged(sender As Object, e As EventArgs) Handles fecRetencion.ValueChanged
        Validar_TipoCambio()
    End Sub
#End Region


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            If ficRetencion.SelectedTab.Index = 2 Then
                Dim olMovDocumento As New l_DocumentoRetencion
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                If gridTicket.Selected.Rows.Count = 0 Then Throw New Exception("Debe seleccionar 1 Ticket para consultar.")
                Dim ticket As String = gridTicket.ActiveRow.Cells("Ticket").Value
                olMovDocumento.EnviarXMLGetStatus(ticket, gUsuarioSGI.Id, gs_PrefijoIdSucursal)
                mensajeEmergente.Confirmacion("Comprobante aceptado por la SUNAT.")
            Else
                If ficRetencion.SelectedTab.Index = 0 Then
                    ConsultaDocumento()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            Me.Consultar(True)
        End Try
    End Sub

    Private Sub ConsultaDocumento()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If Grilla1.ActiveRow.Index = -1 Then Throw New Exception("Debe seleccionar Documento")
            'If udg_DatosDocaEnviar.Rows.Where(Function(g) g.Cells("SEL").Value = True).ToList.Count > 1 Then Throw New Exception("Debe seleccionar solo 1 Documnto")
            Dim dsComprobante As DataSet
            Dim sbMensajeError As New StringBuilder
            Dim sbMensaje As New StringBuilder
            Dim contErrores As Integer = 0
            Dim contAceptados As Integer = 0
            Dim contRechazos As Integer = 0
            Dim oeRetencion As New e_DocumentoRetencion, olRetencion As New l_DocumentoRetencion

            If Grilla1.ActiveRow.Index > -1 Then
                Try
                    oeDocumentoRetencion = New e_DocumentoRetencion
                    ' oeMovDocumento.TipoOperacion = "2"
                    oeDocumentoRetencion.Id = Grilla1.Rows(Grilla1.ActiveRow.Index).Cells("Id").Value
                    oeDocumentoRetencion.TipoOperacion = "E"
                    olRetencion.ConsultarDocumento(oeDocumentoRetencion)
                Catch ex As Exception
                    sbMensajeError.AppendLine("Documento " & Grilla1.Rows(Grilla1.ActiveRow.Index).Cells("Id").Value & ": " & ex.Message)
                    contErrores += 1
                End Try
            End If

            If contAceptados > 0 Then
                sbMensaje.AppendLine(contAceptados.ToString().Trim & " comprobantes fueron consultados a SUNAT.")
            End If
            If contRechazos > 0 Then
                sbMensaje.AppendLine(contRechazos.ToString().Trim & " comprobantes fueron rechazados por la SUNAT.")
            End If
            If contErrores > 0 Then
                sbMensaje.AppendLine(contErrores.ToString().Trim & " comprobantes no se consultaron por que contienen errores.")
            End If

            sbMensaje.AppendLine(sbMensajeError.ToString)

            If sbMensaje.ToString <> "" Then
                MessageBox.Show(sbMensaje.ToString, "SGI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Consultar(True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Validar_TipoCambio()
        Try
            DecTC.Value = TipoCambio(fecRetencion.Value, False)(0)
            If DecTC.Value = 0.0 Then Throw New Exception("Comuníquese con el Área de Contabilidad para actualizar el T.C. del día seleccionado.")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub
End Class
