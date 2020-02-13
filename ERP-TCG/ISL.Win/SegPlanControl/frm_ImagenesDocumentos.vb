'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports System.IO
Imports System.Xml
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Linq
Imports System.Data
Imports System.Text

Public Class frm_ImagenesDocumentos
    Inherits frm_MenuPadre


#Region "Inicialización del formulario"

    Private Shared Instancia As frm_ImagenesDocumentos = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_ImagenesDocumentos
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Definicion de Variables"

    Private oeMovDocumento As e_MovimientoDocumento, olMovDocumento As New l_MovimientoDocumento
    Private oeComprobanteBath As e_ComprobanteElectronicoBath, olComprobanteBath As New l_ComprobanteElectronicoBath

    Private WithEvents oeDocVehImg As e_ImagenesDocumentos
    Private olDocVehImg As New l_ImagenesDocumentos

    Private envio_boleta As Boolean = False
    Private imagen As String = ""
    Public IpServidor As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidor")
    Public RutaArchivos As String = "\\" & DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidor") & "\ComprobanteElectronico\Facturacion\"
    'Dim RutaArchivos As String = Path.Combine(Application.StartupPath, "ComprobanteElectronico") & "\Facturacion\" '@0001
    '   "D:\CPE\Facturacion\"

    Private listaImagenesDoc As New List(Of e_ImagenesDocumentos)
    Dim idDV As String = ""
    Dim loVehiculo As New List(Of e_Combo)
    Dim listaImagenes As New List(Of e_ImagenesDocumentos)
    Dim imagenDoc As New e_ImagenesDocumentos
    Dim bandload As Boolean

    Private oe_TipoDocumento As e_TipoDocumento : Private ol_TipoDocumento As l_TipoDocumento : Private lst_TipoDocumento As List(Of e_TipoDocumento)

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        'Try
        '    Operacion = "Nuevo"
        '    MostrarTabs(1, ficImgDocVeh, 1)

        '    Inicializar()
        '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        '    ficImgDocVeh.Tabs(0).Enabled = True
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
            ControlBoton(1, 0, 0, 0, 0, 0, 1, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        'Try
        '    If griLista.Selected.Rows.Count > 0 Then
        '        Inicializar()
        '        limpiarFormMasivo()
        '        Operacion = "Editar"
        '        MostrarTabs(1, ficImgDocVeh, 1)
        '        '  Mostrar()
        '        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
        '        '   tabControl.SelectedTab = tabControl.Tabs("tabUnidad")
        '        tabControl.SelectedTab = tabControl.Tabs("tabMasivo")
        '        tabControl.Tabs("tabMasivo").Enabled = True
        '        tabControl.Tabs("tabUnidad").Enabled = False
        '        'llenar tabla imagenes doc segun idvehiculo
        '        oeDocVehImg = New e_ImagenesDocumentos
        '        oeDocVehImg.IndVigente = 0
        '        oeDocVehImg.IdVehiculo = griLista.ActiveRow.Cells("IdVehiculo").Value
        '        listaImagenesDoc = olDocVehImg.Listar(oeDocVehImg)
        '        griVehiculos.DataSource = listaImagenesDoc
        '        opcIngresoVehicular.Enabled = False
        '        Me.cboVehiculoMasivo.Enabled = False
        '        'listado veh
        '        For Each fila As UltraGridRow In griVehiculos.Rows
        '            If fila.Cells("IndVigente").Value = False Then
        '                fila.CellAppearance.BackColor = Me.ColoresVencido.Color
        '            End If
        '        Next
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Public Overrides Sub Guardar()
        'Try
        '    Select Case ficImgDocVeh.SelectedTab.Index
        '        Case 1
        '            If GuardarImgDocVeh() Then
        '                MostrarTabs(0, ficImgDocVeh, 0)
        '                Listar()
        '            Else
        '                MostrarTabs(1, ficImgDocVeh, 1)
        '            End If
        '    End Select
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Public Overrides Sub Cancelar()
        'Try
        '    If oeDocVehImg.Modificado Then
        '        Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        '            Case Windows.Forms.DialogResult.Yes
        '                If GuardarImgDocVeh() Then
        '                    MostrarTabs(0, ficImgDocVeh, 2)
        '                    _ingresando_datos = False
        '                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        '                Else
        '                    _ingresando_datos = True
        '                    MostrarTabs(1, ficImgDocVeh, 1)
        '                End If
        '            Case Windows.Forms.DialogResult.No
        '                MostrarTabs(0, ficImgDocVeh, 2)
        '                _ingresando_datos = False
        '                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        '        End Select
        '    Else
        '        MostrarTabs(0, ficImgDocVeh)
        '        _ingresando_datos = False
        '        Listar()
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Public Overrides Sub Exportar()
        'Try
        '    If ficImgDocVeh.Tabs(0).Selected AndAlso griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
        '    If ficImgDocVeh.Tabs(0).Selected Then Exportar_Excel(griLista)
        '    MyBase.Exportar()
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Public Overrides Sub Eliminar()
        'Try
        '    If griLista.Selected.Rows.Count > 0 Then
        '        Select Case MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        '            Case Windows.Forms.DialogResult.Yes
        '                EliminarImgDoc()
        '                Consultar(True)
        '        End Select
        '    End If
        'Catch ex As Exception
        '    Throw ex
        'End Try

    End Sub

    Public Overrides Sub Imprimir()
        Try
            Dim frmImpresion As New frm_FacturaBoletaElectronico
            Dim TipoDoc As Boolean = False

            If ficImgDocVeh.SelectedTab.Index = 0 Then 'Documentos pendientes
                If gridPendientes.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro a imprimir.")
                TipoDoc = IIf(gridPendientes.ActiveRow.Cells("IdTipoDocumento").Value = "1CH000000030" Or gridPendientes.ActiveRow.Cells("IdTipoDocumento").Value = "1CH000000033", True, False)
                frmImpresion.mt_CargarDatos(gridPendientes.ActiveRow.Cells("Id").Value, TipoDoc)
                frmImpresion.StartPosition = FormStartPosition.CenterScreen
                frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                frmImpresion.ShowDialog()
            End If
            If ficImgDocVeh.SelectedTab.Index = 1 Then 'Documentos a enviar
                If gridPorEnviar.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro a imprimir.")
                TipoDoc = IIf(gridPorEnviar.ActiveRow.Cells("IdTipoDocumento").Value = "1CH000000030" Or gridPorEnviar.ActiveRow.Cells("IdTipoDocumento").Value = "1CH000000033", True, False)
                frmImpresion.mt_CargarDatos(gridPorEnviar.ActiveRow.Cells("Id").Value, TipoDoc)
                frmImpresion.StartPosition = FormStartPosition.CenterScreen
                frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                frmImpresion.ShowDialog()
            End If
            If ficImgDocVeh.SelectedTab.Index = 2 Then 'Documentos a enviados
                If gridEnviados.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 registro a imprimir.")
                TipoDoc = IIf(gridEnviados.ActiveRow.Cells("IdTipoDocumento").Value = "1CH000000030" Or gridEnviados.ActiveRow.Cells("IdTipoDocumento").Value = "1CH000000033", True, False)
                frmImpresion.mt_CargarDatos(gridEnviados.ActiveRow.Cells("Id").Value, TipoDoc)
                frmImpresion.StartPosition = FormStartPosition.CenterScreen
                frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                frmImpresion.ShowDialog()
            End If
            'If ficImgDocVeh.SelectedTab.Index = 3 Then 'Documentos a baja
            '    dv = dt.DefaultView
            '    dv.RowFilter = "IdEstadoDocumento in ('1CH00001') and EstadoElectronico = 'A'" 'agregar indanulado
            '    dt = dv.ToTable
            '    CargarBajas(dt)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

#End Region

    Private Sub frm_ImagenesDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            bandload = True
            ControlBoton(1, 0, 0, 0, 0, 0, 1, 0, 1)
            fecHasta.Value = Date.Now
            fecDesde.Value = DateAdd(DateInterval.Day, -7, Date.Now)
            cargarTipoDocumento()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cargarTipoDocumento()
        Try
            oe_TipoDocumento = New e_TipoDocumento
            ol_TipoDocumento = New l_TipoDocumento
            lst_TipoDocumento = New List(Of e_TipoDocumento)
            oe_TipoDocumento = New e_TipoDocumento
            oe_TipoDocumento.Id = "TODOS"
            oe_TipoDocumento.Nombre = "TODOS"
            lst_TipoDocumento.Add(oe_TipoDocumento)
            oe_TipoDocumento.TipoOperacion = "E"
            lst_TipoDocumento.AddRange(ol_TipoDocumento.Listar(oe_TipoDocumento))
            ComboNormal(cboTipoDoc, lst_TipoDocumento, 0)
            Listar()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Validar_Controles()
        Select Case ficImgDocVeh.SelectedTab.Index
            Case 1
                Select Case cboTipoDoc.SelectedIndex
                    Case 0
                        mostrarBotones(False, True, True, True, True, True, True, False)
                    Case 2
                        mostrarBotones(True, True, False, False, True, True, True, False)
                    Case Else
                        mostrarBotones(True, True, True, True, True, True, False, False)
                End Select
            Case 3
                Select Case cboTipoDoc.SelectedIndex
                    Case 0
                        mostrarBotones(False, False, True, True, True, True, True, False)
                    Case Else
                        mostrarBotones(True, False, False, False, True, True, True, False)
                End Select
            Case 5
                mostrarBotones(False, True, True, True, False, False, False, False)
            Case 6
                mostrarBotones(True, False, True, True, False, False, False, False)
            Case 2
                mostrarBotones(False, True, True, True, True, True, False, True)
            Case Else
                mostrarBotones(False, False, True, True, True, True, False, False)
        End Select

        'If ficImgDocVeh.SelectedTab.Index = 3 Then
        '    If cboTipoDoc.SelectedIndex = 3 Or cboTipoDoc.SelectedIndex = 4 Then
        '        mensajeEmergente.Problema("Solo se puede comunicar bajas de Facturas y Boletas.")
        '        cboTipoDoc.SelectedIndex = 0
        '    End If
        'End If
    End Sub
    Private Sub mostrarBotones(ByVal enviar As Boolean, ByVal consultar As Boolean,
                                  ByVal fecha As Boolean, ByVal lfecha As Boolean,
                                  ByVal lcombo As Boolean, ByVal combo As Boolean,
                                  ByVal texto As Boolean, xml As Boolean)
        Try
            btnEnviar.Enabled = enviar
            btnConsultar.Enabled = consultar
            btnXml.Enabled = xml
            lblTipoDoc.Enabled = lcombo
            cboTipoDoc.Enabled = combo
            fecHasta.Visible = fecha
            lblHasta.Visible = lfecha
            'chkTodos.Visible = resumen
            If texto = True Then
                lblDesde.Text = "Emisión:"
            Else
                lblDesde.Text = "Desde:"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frm_ImagenesDocumentos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarFechaDesde_Hasta(fecDesde, fecHasta)
            Dim dt As New DataTable
            ' Dim dv As DataView
            If ficImgDocVeh.SelectedTab.Index = 0 Then 'Documentos pendientes
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.TipoOperacion = "1"
                oeMovDocumento.FechaInicio = fecDesde.Value
                oeMovDocumento.FechaFinal = fecHasta.Value
                oeMovDocumento.IdTipoDocumento = IIf(cboTipoDoc.Value = "TODOS", "", cboTipoDoc.Value)
                oeMovDocumento._Operador = 1
                dt = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento).Tables(0)
                Configuracion_Grilla(gridPendientes, dt, True)
            End If
            If ficImgDocVeh.SelectedTab.Index = 1 Then 'Documentos a enviar
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.TipoOperacion = "1"
                oeMovDocumento.FechaInicio = fecDesde.Value
                oeMovDocumento.FechaFinal = IIf(cboTipoDoc.SelectedIndex = 2, fecDesde.Value, fecHasta.Value)
                oeMovDocumento.IdTipoDocumento = IIf(cboTipoDoc.Value = "TODOS", "", cboTipoDoc.Value)
                oeMovDocumento._Operador = 2
                dt = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento).Tables(0)
                Configuracion_Grilla(gridPorEnviar, dt, False)
                If cboTipoDoc.SelectedIndex = 2 Then envio_boleta = True Else envio_boleta = False
                If cboTipoDoc.SelectedIndex = 0 Then Habilitar_Edicion_Check(False, gridPorEnviar) Else Habilitar_Edicion_Check(True, gridPorEnviar)
            End If
            If ficImgDocVeh.SelectedTab.Index = 2 Then 'Documentos a enviados
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.TipoOperacion = "1"
                oeMovDocumento.FechaInicio = fecDesde.Value
                oeMovDocumento.FechaFinal = fecHasta.Value
                oeMovDocumento.IdTipoDocumento = IIf(cboTipoDoc.Value = "TODOS", "", cboTipoDoc.Value)
                oeMovDocumento._Operador = 3
                dt = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento).Tables(0)
                Configuracion_Grilla(gridEnviados, dt, True)
            End If
            If ficImgDocVeh.SelectedTab.Index = 3 Then 'Documentos a dar baja
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.TipoOperacion = "1"
                oeMovDocumento.FechaInicio = fecDesde.Value
                oeMovDocumento.FechaFinal = IIf(cboTipoDoc.SelectedIndex = 0, fecHasta.Value, fecDesde.Value)
                oeMovDocumento.IdTipoDocumento = IIf(cboTipoDoc.Value = "TODOS", "", cboTipoDoc.Value)
                oeMovDocumento._Operador = 4
                dt = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento).Tables(0)
                Configuracion_Grilla(gridEnviarBaja, dt, False)
                If cboTipoDoc.SelectedIndex = 2 Then envio_boleta = True Else envio_boleta = False
                If cboTipoDoc.SelectedIndex = 0 Then Habilitar_Edicion_Check(False, gridEnviarBaja) Else Habilitar_Edicion_Check(True, gridEnviarBaja)
            End If
            If ficImgDocVeh.SelectedTab.Index = 4 Then 'Documentos de baja
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.TipoOperacion = "1"
                oeMovDocumento.FechaInicio = fecDesde.Value
                oeMovDocumento.FechaFinal = fecHasta.Value
                oeMovDocumento.IdTipoDocumento = IIf(cboTipoDoc.Value = "TODOS", "", cboTipoDoc.Value)
                oeMovDocumento._Operador = 5
                dt = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento).Tables(0)
                Configuracion_Grilla(gridBaja, dt, True)
            End If
            If ficImgDocVeh.SelectedTab.Index = 5 Then 'Ticket
                oeComprobanteBath = New e_ComprobanteElectronicoBath
                oeComprobanteBath.TipoOperacion = ""
                oeComprobanteBath.Id = ""
                oeComprobanteBath.TipoReferencia = "1"
                oeComprobanteBath.FechaEnvio = #1/1/1901#
                oeComprobanteBath.FechaCrea = fecDesde.Value
                oeComprobanteBath.FechaModifica = fecHasta.Value
                dt = olComprobanteBath.ListarTicket(oeComprobanteBath).Tables(0)
                CargarTicket(dt)
            End If
            If ficImgDocVeh.SelectedTab.Index = 6 Then 'Documentos Enviar a Portal de Sunat
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.TipoOperacion = "1"
                oeMovDocumento.FechaInicio = fecDesde.Value
                oeMovDocumento.FechaFinal = fecHasta.Value
                oeMovDocumento._Operador = 6
                dt = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento).Tables(0)
                Configuracion_Grilla(gridConsultas, dt, False)
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub Habilitar_Edicion_Check(_ban As Boolean, grilla As UltraGrid)
        With grilla
            If _ban Then
                .DisplayLayout.Bands(0).Columns("Select").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Select").CellActivation = Activation.AllowEdit
            Else
                .DisplayLayout.Bands(0).Columns("Select").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                .DisplayLayout.Bands(0).Columns("Select").CellActivation = Activation.NoEdit
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            End If
            .UpdateData()
        End With
    End Sub

    Private Sub apariencia_Estados_Grilla(ByVal grilla As UltraWinGrid.UltraGrid)
        Try
            If grilla.Name = "gridTicket" Then
                For Each fila In grilla.Rows
                    Select Case Trim(fila.Cells("Estado").Value)
                        Case "A", "ACEPTADA"
                            fila.CellAppearance.BackColor = ucpAceptado.Color
                        Case "R", "RECHAZADA"
                            fila.CellAppearance.BackColor = ucpRechazado.Color
                        Case "E", "EN PROCESO"
                            fila.CellAppearance.BackColor = ucpProceso.Color
                    End Select
                Next
            Else
                For Each fila In grilla.Rows
                    Select Case fila.Cells("EstadoElectronico").Value
                        Case "A", "ACEPTADA"
                            fila.CellAppearance.BackColor = ucpAceptado.Color
                        Case "R", "RECHAZADA"
                            fila.CellAppearance.BackColor = ucpRechazado.Color
                        Case "E", "EN PROCESO"
                            fila.CellAppearance.BackColor = ucpProceso.Color
                    End Select
                    fila.Cells("SubTotal").Appearance.BackColor = Color.SkyBlue
                    fila.Cells("IGV").Appearance.BackColor = Color.Wheat
                    fila.Cells("Total").Appearance.BackColor = Color.Pink
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Configuracion_Grilla(grilla As UltraGrid, ByVal lo_datos As DataTable, hid_select As Boolean)
        Try
            grilla.DataSource = lo_datos
            With grilla
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                If hid_select Then
                    OcultarColumna(grilla, True, "Select", "Id", "IdTipoDocumento", "CodigoSunat", "IdEstadoDocumento", "EstadoElectronico", "EstadoBaja")
                Else
                    OcultarColumna(grilla, True, "Id", "IdTipoDocumento", "CodigoSunat", "IdEstadoDocumento", "EstadoElectronico", "EstadoBaja")
                End If

                .DisplayLayout.Bands(0).Columns("FechaEmision").SortIndicator = SortOrder.Ascending

                .DisplayLayout.Bands(0).Columns("Select").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Id").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Serie").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Dni").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("SubTotal").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("IGV").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("CodigoSunat").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("IdEstadoDocumento").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("EstadoElectronico").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("EstadoBaja").Header.VisiblePosition = 17

                .DisplayLayout.Bands(0).Columns("Select").Width = 50
                .DisplayLayout.Bands(0).Columns("Id").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Width = 70
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 120
                .DisplayLayout.Bands(0).Columns("Serie").Width = 45
                .DisplayLayout.Bands(0).Columns("Numero").Width = 55
                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("Cliente").Width = 220
                .DisplayLayout.Bands(0).Columns("SubTotal").Width = 100
                .DisplayLayout.Bands(0).Columns("IGV").Width = 100
                .DisplayLayout.Bands(0).Columns("Total").Width = 100
                .DisplayLayout.Bands(0).Columns("CodigoSunat").Width = 40
                .DisplayLayout.Bands(0).Columns("IdEstadoDocumento").Width = 70
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 80
                .DisplayLayout.Bands(0).Columns("EstadoElectronico").Width = 30
                .DisplayLayout.Bands(0).Columns("EstadoBaja").Width = 30

                .DisplayLayout.Bands(0).Columns("Dni").Header.Caption = "RUC/DNI"
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Estado"
                .DisplayLayout.Bands(0).Columns("Select").Header.Caption = "Enviar"

                FormatoColumna(gridConsultas, "#,##0.00", ColumnStyle.Double, HAlign.Right, "IGV", "SubTotal", "Total")

                .DisplayLayout.Override.SelectTypeRow = SelectType.SingleAutoDrag
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.SeparateElement
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = UltraGridFilterUIProvider1
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                .DisplayLayout.Bands(0).Columns("Select").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                .DisplayLayout.Bands(0).Columns("Select").CellActivation = Activation.AllowEdit
                .DisplayLayout.Bands(0).Columns("FechaEmision").CellActivation = Activation.NoEdit
            End With
            apariencia_Estados_Grilla(grilla)
        Catch ex As Exception
            Throw ex
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
                .DisplayLayout.Bands(0).Columns("IndBaja").Width = 50
                .DisplayLayout.Bands(0).Columns("Estado").Width = 80
                .DisplayLayout.Bands(0).Columns("UsuarioCrea").Width = 100
                .DisplayLayout.Bands(0).Columns("FechaCrea").Width = 70
                .DisplayLayout.Bands(0).Columns("UsuarioModifica").Width = 100
                .DisplayLayout.Bands(0).Columns("FechaModifica").Width = 70

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = UltraGridFilterUIProvider1

                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
            apariencia_Estados_Grilla(gridTicket)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub btnSincronizar_Click(sender As Object, e As EventArgs)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            oeMovDocumento = New e_MovimientoDocumento
            oeMovDocumento.TipoOperacion = "FE"
            'olMovDocumento.SincronizarFacturado()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griDocumentoVenta_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            'Dim check As CheckBox
            Dim dsComprobante As DataSet
            Dim sbMensaje As New StringBuilder
            'Dim facturaObj As New Generarxml.FacturacionElectronica(mCadenaConexion)
            'Dim factura1Obj As New FacturacionElectronica(mCadenaConexion)            
            Dim contErrores As Integer = 0
            Dim contAceptados As Integer = 0
            Dim contRechazos As Integer = 0
            Dim sbMensajeError As New StringBuilder
            Dim boolRetorno As Boolean = False
            Dim ids As String = ""

            For Each drFila In gridPendientes.Selected.Rows

                'check = CType(drFila.Cells(12).Controls.Item(5), CheckBox)
                'If check.Checked Then
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.TipoOperacion = "2"
                oeMovDocumento.Id = drFila.Cells("Id").Value
                'dsComprobante = factura1Obj.ObtenerComprobanteFE(drFila.Cells(0).Text)
                dsComprobante = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento)
                If dsComprobante.Tables.Count > 1 Then
                    If dsComprobante.Tables(0).Rows(0).Item("estado").ToString.Trim = "C" Then
                        Try
                            'boolRetorno = olMovDocumento.GenerarXmlFacturaElectronica(dsComprobante.Tables(0), dsComprobante.Tables(2), dsComprobante.Tables(1), RutaArchivos, gUsuarioSGI.Id)
                            boolRetorno = olMovDocumento.GenerarXmlFacturaElectronica(dsComprobante.Tables(0), dsComprobante.Tables(2), RutaArchivos, gUsuarioSGI.Id)
                            contAceptados += 1
                            ids &= "'" & drFila.Cells(0).Text & "',"
                        Catch ex As Exception
                            sbMensajeError.Append("Documento " & dsComprobante.Tables(0).Rows(0).Item("idcomp") & ": " & ex.Message & "<br/>")
                            If boolRetorno Then
                                contRechazos += 1
                            Else
                                contErrores = contErrores + 1
                            End If
                        End Try
                    End If
                Else
                    contErrores = contErrores + 1
                End If
                'End If
            Next
            If contAceptados > 0 Then
                'Funciones.EnviarData(ids, mCadenaConexion, False)
                sbMensaje.Append(contAceptados.ToString().Trim & " comprobantes fueron aceptados por la SUNAT.<br/>")
            End If
            If contRechazos > 0 Then
                sbMensaje.Append(contRechazos.ToString().Trim & " comprobantes fueron rechazados por la SUNAT.<br/>")
            End If
            If contErrores > 0 Then
                sbMensaje.Append(contErrores.ToString().Trim & " comprobantes no se enviaron por que contienen errores.<br/>")
            End If
            sbMensaje.Append(sbMensajeError.ToString)
            'ucMsje.RegistrarMensajeCliente("dvMsjeInfo", m_strImagenInformacion, sbMensaje.ToString)
            mensajeEmergente.Problema(sbMensaje.ToString, True)

            Listar()

            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cbInd_CheckedChanged(sender As Object, e As EventArgs)
        Try
            'If cbInd.Checked Then
            '    For Each obj In gridPorEnviar.Rows.Where(Function(item) item.IsFilteredOut = False)
            '        obj.Cells("Select").Value = True
            '    Next
            'Else
            '    For Each obj In gridPorEnviar.Rows.Where(Function(item) item.IsFilteredOut = False)
            '        obj.Cells("Select").Value = False
            '    Next
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


    Private Function ObtenerComprobantesEnviar() As DataTable
        Dim dtRet As New DataTable
        Dim drAux As DataRow
        dtRet.Columns.Add("idcomp", GetType(System.String))
        dtRet.Columns.Add("codmon", GetType(System.String))
        dtRet.Columns.Add("tipcomp", GetType(System.String))
        dtRet.Columns.Add("seriecomp", GetType(System.String))
        dtRet.Columns.Add("corrcomp", GetType(System.String))
        dtRet.Columns.Add("valopergravadas", GetType(System.Double))
        dtRet.Columns.Add("valoperinafectas", GetType(System.Double))
        dtRet.Columns.Add("valoperexoneradas", GetType(System.Double))
        dtRet.Columns.Add("valopergratuitas", GetType(System.Double))
        dtRet.Columns.Add("importeventa", GetType(System.Double))
        dtRet.Columns.Add("igv", GetType(System.Double))
        dtRet.Columns.Add("feccomp", GetType(System.DateTime))
        dtRet.Columns.Add("factorc", GetType(System.Double))
        dtRet.Columns.Add("tipoid", GetType(System.String))
        dtRet.Columns.Add("nroid", GetType(System.String))
        dtRet.Columns.Add("razonsocial", GetType(System.String))
        dtRet.Columns.Add("estado", GetType(System.String))
        dtRet.Columns.Add("tipocomprobante", GetType(System.String))

        For Each drFila In gridEnviarBaja.Rows.Where(Function(g) g.Cells("Select").Value = True).ToList
            drAux = dtRet.NewRow
            drAux.Item("idcomp") = drFila.Cells("Id").Value
            'drAux.Item("codmon") = drFila.Item("codmon")
            drAux.Item("tipcomp") = drFila.Cells("CodigoSunat").Value
            drAux.Item("seriecomp") = drFila.Cells("Serie").Value
            drAux.Item("corrcomp") = drFila.Cells("Numero").Value
            drAux.Item("valopergravadas") = drFila.Cells("SubTotal").Value
            'drAux.Item("valoperinafectas") = drFila.Item("valoperinafectas")
            'drAux.Item("valoperexoneradas") = drFila.Item("valoperexoneradas")
            'drAux.Item("valopergratuitas") = drFila.Item("valopergratuitas")
            drAux.Item("importeventa") = drFila.Cells("Total").Value
            drAux.Item("igv") = drFila.Cells("IGV").Value
            drAux.Item("feccomp") = drFila.Cells("FechaEmision").Value
            drAux.Item("factorc") = 1
            'drAux.Item("tipoid") = drFila.Item("tipoid")
            'drAux.Item("nroid") = drFila.Item("nroid")
            ' drAux.Item("razonsocial") = drFila.Item("razonsocial")
            'drAux.Item("estado") = drFila.Item("estado")
            'drAux.Item("tipocomprobante") = drFila.Item("tipocomprobante")
            dtRet.Rows.Add(drAux.ItemArray)
        Next
        Return dtRet
    End Function


    Private Sub EnviarComprobantes()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim dsComprobante As DataSet
            Dim sbMensaje As New StringBuilder
            Dim contErrores As Integer = 0
            Dim contAceptados As Integer = 0
            Dim contRechazos As Integer = 0
            Dim sbMensajeError As New StringBuilder
            Dim boolRetorno As Boolean = False
            Dim ids As String = ""
            Dim enviados_portal As New List(Of e_MovimientoDocumento)
            For Each drFila In gridPorEnviar.Rows.Where(Function(g) g.Cells("select").Value = True).ToList

                oeMovDocumento = New e_MovimientoDocumento
                'oeMovDocumento.TipoOperacion = "2"
                oeMovDocumento.TipoOperacion = "DT"
                oeMovDocumento._Operador = 1
                oeMovDocumento.Id = drFila.Cells("Id").Value
                dsComprobante = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento)
                If dsComprobante.Tables.Count > 1 Then
                    If dsComprobante.Tables(0).Rows(0).Item("estado").ToString.Trim = "C" Then
                        Try
                            'boolRetorno = olMovDocumento.GenerarXmlFacturaElectronica(dsComprobante.Tables(0), dsComprobante.Tables(2), dsComprobante.Tables(1), RutaArchivos, gUsuarioSGI.Id)
                            boolRetorno = olMovDocumento.GenerarXmlFacturaElectronica(dsComprobante.Tables(0), dsComprobante.Tables(1), RutaArchivos, gUsuarioSGI.Id)
                            contAceptados += 1
                            ids &= "'" & drFila.Cells(0).Text & "',"
                            oeMovDocumento.Serie = drFila.Cells("Serie").Value
                            oeMovDocumento.Numero = drFila.Cells("Numero").Value
                            enviados_portal.Add(oeMovDocumento)
                        Catch ex As Exception
                            sbMensajeError.AppendLine("Documento " & dsComprobante.Tables(0).Rows(0).Item("id") & ": " & ex.Message)
                            If boolRetorno Then
                                contRechazos += 1
                            Else
                                contErrores = contErrores + 1
                            End If
                        End Try
                    End If
                Else
                    contErrores = contErrores + 1
                End If
            Next
            If contAceptados > 0 Then
                'Funciones.EnviarData(ids, mCadenaConexion, False)
                sbMensaje.AppendLine(contAceptados.ToString().Trim & " comprobantes fueron aceptados por la SUNAT.")
            End If
            If contRechazos > 0 Then
                sbMensaje.AppendLine(contRechazos.ToString().Trim & " comprobantes fueron rechazados por la SUNAT.")
            End If
            If contErrores > 0 Then
                sbMensaje.AppendLine(contErrores.ToString().Trim & " comprobantes no se enviaron por que contienen errores.")
            End If
            sbMensaje.AppendLine(sbMensajeError.ToString)

            If sbMensaje.ToString <> "" Then
                mensajeEmergente.Problema(sbMensaje.ToString, True)
            End If

            'PortalConsultas_EnvioSunat(enviados_portal)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Listar()
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub EnviaraBaja()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim sbMensaje As New StringBuilder
            Dim contErrores As Integer = 0
            Dim contAceptados As Integer = 0
            Dim contRechazos As Integer = 0
            Dim sbMensajeError As New StringBuilder
            Dim boolRetorno As Boolean = False
            Dim ids As String = ""
            Dim ticket As String = ""

            If gridEnviarBaja.Rows.Where(Function(g) g.Cells("Select").Value = True).Count < 1 Then Throw New Exception("Debe seleccionar más de 1 registro a dar de baja")

            ticket = olMovDocumento.GenerarXmlComprobantesBaja(ObtenerComprobantesEnviar(), Date.Now, RutaArchivos, gUsuarioSGI.Id, gs_PrefijoIdSucursal)

            mensajeEmergente.Problema("Comprobantes declarados de baja, el numero de ticket es:" & ticket & ". Ticket Aceptado.", True)

            Listar()

            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ConsultarTicket()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If gridTicket.Selected.Rows.Count <> 1 Then Throw New Exception("Debe seleccionar solo 1 ticket")
            Dim ticket As String = gridTicket.ActiveRow.Cells("Ticket").Value
            olMovDocumento.EnviarXMLGetStatus(RutaArchivos, ticket, gs_PrefijoIdSucursal)
            'dtAux = factura1Obj.BuscarComprobantes(ticket)
            'For Each drFila As DataRow In dtAux.Rows
            '    ids &= "'" & drFila.Item("id_documento") & "',"
            'Next
            'Funciones.EnviarData(ids, mCadenaConexion, True)

            mensajeEmergente.Problema("Comprobante aceptado por la SUNAT", True)

            Listar()

            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If ficImgDocVeh.SelectedTab.Index = 0 Then 'Documentos pendientes

            End If
            If ficImgDocVeh.SelectedTab.Index = 1 Then 'Documentos a enviar   
                If envio_boleta Then
                    EnviarBath(False)
                Else
                    EnviarComprobantes()
                End If
            End If
            If ficImgDocVeh.SelectedTab.Index = 2 Then 'Documentos a enviados                
            End If
            If ficImgDocVeh.SelectedTab.Index = 3 Then 'Documentos a dar baja
                If envio_boleta Then
                    EnviarBath(True)
                Else
                    EnviaraBaja()
                End If
            End If
            If ficImgDocVeh.SelectedTab.Index = 4 Then 'Documentos de baja                
            End If
            If ficImgDocVeh.SelectedTab.Index = 5 Then 'Ticket
                ConsultarTicket()
            End If
            If ficImgDocVeh.SelectedTab.Index = 6 Then 'Ticket
                EnviarPortalConsultas()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EnviarPortalConsultas()
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ugb_Espera.Visible = True
            Dim _ban As Boolean = False
            Dim oeDocumento As e_MovimientoDocumento
            Dim cont As Integer = 0
            Dim enviados_portal As New List(Of e_MovimientoDocumento)
            For Each drFila In gridConsultas.Rows.Where(Function(g) g.Cells("Select").Value = True).ToList
                oeDocumento = New e_MovimientoDocumento
                cont += 1
                oeDocumento = New e_MovimientoDocumento
                oeDocumento.Id = drFila.Cells("Id").Value
                oeDocumento.Serie = drFila.Cells("Serie").Value
                oeDocumento.Numero = drFila.Cells("Numero").Value
                enviados_portal.Add(oeDocumento)
            Next
            PortalConsultas_EnvioSunat(enviados_portal)
            If cont = 0 Then
                mensajeEmergente.Confirmacion("Debe seleccionar al menos 1 un documento.")
            End If
            Listar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub PortalConsultas_EnvioSunat(documentos As List(Of e_MovimientoDocumento))
        Dim _ban As Boolean = False
        Dim contEnvios As Integer = 0
        Dim contError As Integer = 0
        Dim contNoEnvios As Integer = 0
        Dim ids As String = ""
        Dim sbMensajeError As New StringBuilder
        Dim sbMensaje As New StringBuilder
        Dim olDocumento As New l_MovimientoDocumento
        Dim oeDocumento As e_MovimientoDocumento
        Try
            For Each drFila In documentos
                oeDocumento = New e_MovimientoDocumento
                oeDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeDocumento.Id = drFila.Id
                Try
                    _ban = EnviarPortalSunat(oeDocumento)
                    If _ban Then
                        contEnvios += 1
                        oeDocumento.TipoOperacion = "EPC"
                        oeDocumento.IdUsuarioCrea = gUsuarioSGI.IdTrabajador
                        olDocumento.Guardar(oeDocumento)
                    Else
                        contNoEnvios += 1
                        ids &= "'" & drFila.Serie & "-" & drFila.Numero & "'."
                    End If
                Catch ex As Exception
                    sbMensajeError.AppendLine("Documento " & drFila.Serie & "-" & drFila.Numero & ": " & ex.Message)
                    contError += 1
                End Try
            Next

            If contEnvios > 0 Then
                sbMensaje.AppendLine("(" + contEnvios.ToString().Trim & ") comprobantes fueron enviados al Portal de Consultas.")
            End If
            If contNoEnvios > 0 Then
                sbMensaje.AppendLine("(" + contNoEnvios.ToString().Trim & ") comprobantes no se pudieron Enviar al Portal de Consultas: " & ids)
            End If
            If contError > 0 Then
                sbMensaje.AppendLine("(" + contError.ToString().Trim & ") comprobantes no se enviaron por contener error al Enviar al Portal de Consultas: " & ids)
            End If
            sbMensaje.AppendLine(sbMensajeError.ToString)

            MsgBox(sbMensaje.ToString, MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function EnviarPortalSunat(oeDocumento As e_MovimientoDocumento) As Boolean
        Dim _ban As Boolean = False
        Try
            Dim olDocumento As New l_MovimientoDocumento
            oeDocumento.TipoOperacion = "EPC"
            Dim msj As String = olDocumento.EnviarPortalSunat(oeDocumento)
            If msj = 1 Then
                _ban = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
        Return _ban
    End Function

    Private Sub gridConsultas_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles gridConsultas.InitializeLayout
        Try
            If {"gridConsultas"}.Contains(e.Layout.Grid.Name) Then
                e.Layout.Override.CellClickAction = CellClickAction.RowSelect
                For Each r In e.Layout.Bands(0).Columns
                    If r.Key = "Select" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gridConsultas_CellChange(sender As Object, e As CellEventArgs) Handles gridConsultas.CellChange
        Try
            gridConsultas.UpdateData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gridPorEnviar_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles gridPorEnviar.InitializeLayout 'Permite seleccionar toda la fila
        Try
            If {"gridPorEnviar"}.Contains(e.Layout.Grid.Name) Then
                e.Layout.Override.CellClickAction = CellClickAction.RowSelect
                For Each r In e.Layout.Bands(0).Columns
                    If r.Key = "Select" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gridEnviarBaja_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles gridEnviarBaja.InitializeLayout 'Permite seleccionar toda la fila
        Try
            If {"gridEnviarBaja"}.Contains(e.Layout.Grid.Name) Then
                e.Layout.Override.CellClickAction = CellClickAction.RowSelect
                For Each r In e.Layout.Bands(0).Columns
                    If r.Key = "Select" Then
                        r.CellClickAction = CellClickAction.Edit
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gridPorEnviar_CellChange(sender As Object, e As CellEventArgs) Handles gridPorEnviar.CellChange
        gridPorEnviar.UpdateData()
    End Sub

    Private Sub gridEnviarBaja_CellChange(sender As Object, e As CellEventArgs) Handles gridEnviarBaja.CellChange
        gridEnviarBaja.UpdateData()
    End Sub

    Private Sub ficImgDocVeh_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficImgDocVeh.SelectedTabChanged
        Validar_Controles()
        Listar()
    End Sub

    Private Sub cboTipoDoc_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDoc.ValueChanged
        Validar_Controles()
    End Sub


#Region "Resumen Diario 2018"
    Private Function ObtenerComprobantesBath(ByVal dtCab As DataTable) As DataTable
        Try
            Dim dtRet As New DataTable
            Dim drAux As DataRow
            'Dim drFilas() As DataRow
            Dim dataView As New DataView()

            Dim validar As Boolean = True
            Dim Serie As String = ""
            Dim Corr As Integer = 0

            dtRet.Columns.Add("ABT", GetType(System.String))
            dtRet.Columns.Add("idcomp", GetType(System.String))
            dtRet.Columns.Add("codempr", GetType(System.String))
            dtRet.Columns.Add("codmon", GetType(System.String))
            dtRet.Columns.Add("tipcomp", GetType(System.String))
            dtRet.Columns.Add("seriecomp", GetType(System.String))
            dtRet.Columns.Add("corrcomp", GetType(System.String))
            dtRet.Columns.Add("corrini", GetType(System.String))
            'dtRet.Columns.Add("corrfin", GetType(System.String))
            dtRet.Columns.Add("tipdociden", GetType(System.String))
            dtRet.Columns.Add("dociden", GetType(System.String))
            dtRet.Columns.Add("valopergravadas", GetType(System.Double))
            dtRet.Columns.Add("valoperinafectas", GetType(System.Double))
            dtRet.Columns.Add("valoperexoneradas", GetType(System.Double))
            dtRet.Columns.Add("valopergratuitas", GetType(System.Double))
            dtRet.Columns.Add("importeventa", GetType(System.Double))
            dtRet.Columns.Add("igv", GetType(System.Double))
            dtRet.Columns.Add("feccomp", GetType(System.DateTime))
            dtRet.Columns.Add("factorc", GetType(System.Double))

            dtRet.Columns.Add("seriedocasoc", GetType(System.String))
            dtRet.Columns.Add("corrdocasoc", GetType(System.String))
            dtRet.Columns.Add("tipodocasoc", GetType(System.String))

            'ORDENAR POR SERIE Y CORRETALIVO
            dataView = New DataView(dtCab)
            dataView.Sort = "seriecomp ASC , corrcomp ASC"
            dtCab = dataView.ToTable()

            For Each drFila As DataRow In dtCab.Rows

                drAux = dtRet.NewRow
                drAux.Item("codmon") = drFila.Item("codmon")
                drAux.Item("ABT") = drFila.Item("ABT")
                drAux.Item("idcomp") = drFila.Item("idcomp")
                drAux.Item("codempr") = drFila.Item("codempr")
                drAux.Item("tipcomp") = drFila.Item("tipcomp")
                drAux.Item("seriecomp") = drFila.Item("seriecomp")
                drAux.Item("corrcomp") = CType(drFila.Item("corrcomp"), Int64).ToString.Trim.PadLeft(8, "0")
                drAux.Item("corrini") = CType(drFila.Item("corrcomp"), Int64).ToString.Trim.PadLeft(8, "0")
                drAux.Item("tipdociden") = drFila.Item("tipoid")
                drAux.Item("dociden") = drFila.Item("nroid")
                drAux.Item("feccomp") = drFila.Item("feccomp")
                drAux.Item("importeventa") = drFila.Item("importeventa") * IIf(drFila.Item("codmon").ToString().Trim <> "SOL", drFila.Item("factorc"), 1)
                drAux.Item("valopergravadas") = drFila.Item("valopergravadas") * IIf(drFila.Item("codmon").ToString().Trim <> "SOL", drFila.Item("factorc"), 1)
                drAux.Item("valoperinafectas") = drFila.Item("valoperinafectas") * IIf(drFila.Item("codmon").ToString().Trim <> "SOL", drFila.Item("factorc"), 1)
                drAux.Item("valoperexoneradas") = drFila.Item("valoperexoneradas") * IIf(drFila.Item("codmon").ToString().Trim <> "SOL", drFila.Item("factorc"), 1)
                drAux.Item("valopergratuitas") = drFila.Item("valopergratuitas") * IIf(drFila.Item("codmon").ToString().Trim <> "SOL", drFila.Item("factorc"), 1)
                drAux.Item("igv") = drFila.Item("igv") * IIf(drFila.Item("codmon").ToString().Trim <> "SOL", drFila.Item("factorc"), 1)
                drAux.Item("factorc") = drFila.Item("factorc")
                drAux.Item("seriedocasoc") = drFila.Item("seriedocasoc")
                If IsNumeric(drFila.Item("corrdocasoc")) Then
                    drAux.Item("corrdocasoc") = CType(drFila.Item("corrdocasoc"), Int64).ToString.Trim.PadLeft(8, "0")
                Else
                    drAux.Item("corrdocasoc") = drFila.Item("corrdocasoc")
                End If
                drAux.Item("tipodocasoc") = drFila.Item("tipodocasoc")

                dtRet.Rows.Add(drAux.ItemArray)
            Next
            dtRet.AcceptChanges()
            Return dtRet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub EnviarBath(b_Baja As Boolean)
        Try
            Dim ticket As String = ""
            Dim ticket_dec As String = ""
            Dim dsComprobante As DataSet
            Dim DT As New DataTable
            Dim C As Boolean = True

            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim grilla As UltraGrid
            If b_Baja Then grilla = gridEnviarBaja Else grilla = gridPorEnviar

            For Each fila In grilla.Rows.Where(Function(g) g.Cells("Select").Value = True).ToList
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.Id = fila.Cells("Id").Value
                If b_Baja = False Then
                    oeMovDocumento.IdTipoDocumento = fila.Cells("IdTipoDocumento").Value
                    oeMovDocumento.TipoOperacion = "2"
                    oeMovDocumento.FechaInicio = fecDesde.Value
                    oeMovDocumento.FechaFinal = fecDesde.Value
                    dsComprobante = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento)
                    'olMovDocumento.GenerarXmlFacturaElectronica_Resumen(dsComprobante.Tables(0), dsComprobante.Tables(2), dsComprobante.Tables(1), RutaArchivos, gUsuarioSGI.Id) '@001
                    olMovDocumento.GenerarXmlFacturaElectronica_Resumen(dsComprobante.Tables(0), dsComprobante.Tables(2), dsComprobante.Tables(1), RutaArchivos, gUsuarioSGI.Id) '@001
                End If
                oeMovDocumento.TipoOperacion = "4"
                dsComprobante = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento)
                If C Then 'Se realiza para copiar la estructura
                    If dsComprobante.Tables.Count = 0 Then Throw New Exception("Error al copiar estructura.")
                    DT = dsComprobante.Tables(0).Clone
                End If
                C = False
                If dsComprobante.Tables(0).Rows.Count = 0 Then Throw New Exception("No se encuentra documento : " & oeMovDocumento.Id)
                DT.ImportRow(dsComprobante.Tables(0).Rows(0))

            Next
            ticket = olMovDocumento.GenerarXmlFacturaElectronicaBath_2018(ObtenerComprobantesBath(DT), DT, fecDesde.Value, RutaArchivos, gUsuarioSGI.Id, b_Baja, gs_PrefijoIdSucursal)
            If b_Baja Then
                mensajeEmergente.Confirmacion("Comprobantes declarados, Ticket Aceptado Nº" & ticket & ".")
            Else
                mensajeEmergente.Confirmacion("Comprobantes declarados, Ticket Aceptado N°:" & ticket & ".")
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Listar()
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub
#End Region

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            If ficImgDocVeh.SelectedTab.Index = 5 Then
                olMovDocumento = New l_MovimientoDocumento
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                If gridTicket.Selected.Rows.Count = 0 Then Throw New Exception("Debe seleccionar 1 Ticket para consultar.")
                Dim ticket As String = gridTicket.ActiveRow.Cells("Ticket").Value
                olMovDocumento.EnviarXMLGetStatus(RutaArchivos, ticket, gs_PrefijoIdSucursal)
                mensajeEmergente.Confirmacion("Comprobante aceptado por la SUNAT.")
                ugb_Espera.Visible = False
            ElseIf ficImgDocVeh.SelectedTab.Index = 1 Then
                ConsultaDocumento()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
            Listar()
        End Try

    End Sub

    Private Sub ConsultaDocumento()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If gridPorEnviar.Rows.Where(Function(g) g.Cells("select").Value = True).ToList.Count = 0 Then Throw New Exception("Debe seleccionar documento.")
            If gridPorEnviar.Rows.Where(Function(g) g.Cells("select").Value = True).ToList.Count > 1 Then Throw New Exception("Debe seleccionar 1 documento.")
            'If udg_DatosDocaEnviar.Rows.Where(Function(g) g.Cells("SEL").Value = True).ToList.Count > 1 Then Throw New Exception("Debe seleccionar solo 1 Documnto")
            Dim dsComprobante As DataSet
            Dim sbMensajeError As New StringBuilder
            Dim sbMensaje As New StringBuilder
            Dim contErrores As Integer = 0
            Dim contAceptados As Integer = 0
            Dim contRechazos As Integer = 0


            For Each drFila In gridPorEnviar.Rows.Where(Function(g) g.Cells("select").Value = True).ToList
                oeMovDocumento = New e_MovimientoDocumento
                ' oeMovDocumento.TipoOperacion = "2"
                oeMovDocumento.Id = drFila.Cells("Id").Value
                oeMovDocumento.TipoOperacion = "2"
                dsComprobante = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento)
                Try
                    If dsComprobante.Tables.Count > 1 Then
                        If dsComprobante.Tables(0).Rows(0).Item("estado").ToString.Trim = "C" Then
                            olMovDocumento.ConsultarDocumento(dsComprobante, RutaArchivos, gUsuarioSGI.Id)
                            contAceptados += 1
                        Else
                            Throw New Exception("El comprobante aun no a sido emitido en el sistema.")
                        End If
                    Else
                        Throw New Exception("No se encuentra comprobante.")
                    End If
                Catch ex As Exception
                    sbMensajeError.AppendLine("Documento " & dsComprobante.Tables(0).Rows(0).Item("idcomp") & ": " & ex.Message)
                    contErrores += 1
                End Try
            Next
            Dim ol_ComprobElect As New l_ComprobanteElectronico
            Dim olConfiguracion As New l_Configuracion
            If contAceptados > 0 Then
                sbMensaje.AppendLine(contAceptados.ToString().Trim & " comprobantes fueron consultados a SUNAT.")
                Dim strNombre As String = ol_ComprobElect.Obtener(New e_ComprobanteElectronico With {.TipoReferencia = 1, .IdReferencia = oeMovDocumento.Id}).nombrexml
                Dim strRuta As String = olConfiguracion.DocElectronico
                'Dim strRuta As String = Path.Combine(Application.StartupPath, "ComprobanteElectronico") '@0001
                If File.Exists(strRuta.Trim() & "\Facturacion\R-" & strNombre.Trim() & ".zip") Then
                    My.Computer.FileSystem.CopyFile(strRuta.Trim() & "\Facturacion\R-" & strNombre.Trim() & ".zip", "D:\R-" & strNombre.Trim() & ".zip")

                End If
            End If
            If contRechazos > 0 Then
                sbMensaje.AppendLine(contRechazos.ToString().Trim & " comprobantes fueron rechazados por la SUNAT.")
            End If
            If contErrores > 0 Then
                sbMensaje.AppendLine(contErrores.ToString().Trim & " comprobantes no se consultaron por que contienen errores.")
            End If

            sbMensaje.AppendLine(sbMensajeError.ToString)

            If sbMensaje.ToString <> "" Then
                MessageBox.Show(sbMensaje.ToString, "OSIRIS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Listar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ficImgDocVeh_Resize(sender As Object, e As EventArgs) Handles ficImgDocVeh.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub frm_ImagenesDocumentos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub



    Private Sub DescargarXml_Comprobantes(grilla As UltraGrid)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim strRuta As String = ""
            Dim strNombre As String = ""
            If gridEnviados.Rows(gridEnviados.ActiveRow.Index).Cells("TipoDocumento").Value = "BOLETA DE VENTA" Then Throw New Exception("¡Las boletas de venta son enviadas en resumen.!")
            If grilla.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Comprobante!")
            If grilla.ActiveRow.Index > -1 Then
                Dim oeMovDoc As New e_MovimientoDocumento
                oeMovDocumento.Id = gridEnviados.Rows(gridEnviados.ActiveRow.Index).Cells("Id").Value
                Dim ol_ComprobElect As New l_ComprobanteElectronico
                Dim olConfiguracion As New l_Configuracion
                strRuta = olConfiguracion.DocElectronico
                'strRuta = Path.Combine(Application.StartupPath, "ComprobanteElectronico") '@0001
                strNombre = ol_ComprobElect.Obtener(New e_ComprobanteElectronico With {.TipoReferencia = 1, .IdReferencia = oeMovDocumento.Id}).nombrexml
                If File.Exists(strRuta.Trim() & "\Facturacion\" & strNombre.Trim() & ".zip") Then
                    My.Computer.FileSystem.CopyFile(strRuta.Trim() & "\Facturacion\" & strNombre.Trim() & ".zip", "D:\" & strNombre.Trim() & ".zip")

                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
            Listar()
        End Try
    End Sub

    Private Sub btnXml_Click(sender As Object, e As EventArgs) Handles btnXml.Click
        DescargarXml_Comprobantes(gridEnviados)
    End Sub
End Class