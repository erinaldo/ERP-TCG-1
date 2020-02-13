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
Imports System.IO
Imports System.Configuration
Imports System.Collections.Specialized

Public Class frm_FacturarServicio
    Inherits frm_MenuPadre

#Region "Historial de Cambios"

    ' =====================================================================================================================
    ' CAMBIO    | Fecha         | Autor         | Observacion
    ' ---------------------------------------------------------------------------------------------------------------------
    ' @0001     | 2019-01-11    | ENEVADOB      | En el proceso de emision de CPE se cambio la funcion
    ' @0002     | 2019-01-11    | ENEVADOB      | Adicionar metodo para cargar servicios
    ' =====================================================================================================================

#End Region

#Region "Instancia"

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Shared instancia As frm_FacturarServicio = Nothing
    Private Shared Operacion As String
    Dim _ingresando_datos As Boolean = False

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_FacturarServicio()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeMovimientoDocumento As New e_MovimientoDocumento, olMovimientoDocumento As New l_MovimientoDocumento, lstMovimientoDocumento As New List(Of e_MovimientoDocumento)
    Private oeDetalleDocumento As New e_DetalleDocumento, olDetalleDocumento As New l_DetalleDocumento, lstDetalleDocumento As New List(Of e_DetalleDocumento)
    Private olArea As New l_Area, oeArea As New e_Area
    Private olUsuario As New l_Usuario, oeUsuario As New e_Usuario
    Private oeIGV As New e_Impuesto, olIGV As New l_Impuesto
    Private oeMoneda As New e_Moneda, oeMonedaDoc As New e_Moneda, olMoneda As New l_Moneda, llMoneda As New List(Of e_Moneda), leMoneda As New List(Of e_Moneda)
    Private oeTipoPago As New e_TipoPago, olTipoPago As New l_TipoPago, leTipoPago As New List(Of e_TipoPago), llTipoPago As New List(Of e_TipoPago)
    Private oeCliente As New e_Cliente, olCliente As New l_Cliente, loCliente As New List(Of e_Cliente)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, loEstado As New List(Of e_Estado), loEstadoBusq As New List(Of e_Estado), leEstado As New List(Of e_Estado)
    Private oeTipoDocumento As New e_TipoDocumento, olTipoDocumento As New l_TipoDocumento, leTipoDoc As New List(Of e_TipoDocumento), oeTipoDoc As New e_TipoDocumento
    Private oeProDoc As New e_ProcesoTipoDocumento, olProDoc As New l_ProcesoTipoDocumento
    Private oeProceso As New e_ProcesoNegocio, olProceso As New l_ProcesoNegocio
    Private oeServicio As New e_Servicio, olServicio As New l_Servicio, llServicio As New List(Of e_Servicio)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa
    Private oeCategoriaServicio As New e_CategoriaServicio, olCategoriaServicio As New l_CategoriaServicio, lstCategoriasServicio As New List(Of e_CategoriaServicio)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private oeUnidadMedida As New e_UnidadMedida, olUnidadMedida As New l_UnidadMedida
    Private oeServCtaCtble As New e_ServicioCuentaContable, olServCtaCtble As New l_ServicioCuentaContable, leServCtaCtble As New List(Of e_ServicioCuentaContable)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeCuentaCorriente As New e_CuentaCorriente, olCuentaCorriente As New l_CuentaCorriente
    Private oeCtaCtable As New e_CuentaContable, olCtaCtable As New l_CuentaContable, leCtaCtable As New List(Of e_CuentaContable)
    Private oeAnticipo As New e_MovimientoDocumento, olAnticipo As New l_MovimientoDocumento, lstAnticipo As New List(Of e_MovimientoDocumento)
    Private oeDocAsoc As New e_DocumentoAsociado, olDocAsoc As New l_DocumentoAsociado, lstDocAsoc As New List(Of e_DocumentoAsociado)

    Private loDireccionEmpresa As List(Of e_Direccion_EmpresaPersona)

    Dim totalSinIgv As Double = 0.0, totalIgv As Double = 0.0, totalConIng As Double = 0.0, cambioMon As Double = 0.0, cantmat As Double = 0
    Dim cont As Integer, posGrilla As Integer, AnioServ As Integer = 0
    Dim swIgv As Boolean, IndEmit As Boolean, _bandanular As Boolean = False
    Dim Oper As String = "", IdCtaCtableAux As String = String.Empty
    Dim b_anticipo As Boolean = False
    Private oeTipoBien As New e_TipoBien
    Private olTipoBien As New l_TipoBien
    Private loTipobien As New List(Of e_TipoBien)

    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)

    Dim IdDocumento As String = String.Empty

#End Region

#Region "Botonera"

    Public Overrides Sub Nuevo()
        Try
            InicializarControles()
            oeMovimientoDocumento.TipoOperacion = "I"
            gbeListadoMatSer.Expanded = True
            MostrarTabs(1, ficFacturaCompra, 1)
            Operacion = "Nuevo"
            Oper = "Generar"
            cboEstadoFacturaM.Text = "GENERADA"
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
            cbAnticipo.Checked = False
            griAnticipos.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMovimientoDocumento.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarMovimientoDocumento() Then
                            MostrarTabs(0, ficFacturaCompra, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficFacturaCompra, 1)
                        End If
                        gbeListadoMatSer.Enabled = True
                        Agrupacion2.Enabled = True
                        Agrupacion4.Enabled = True
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficFacturaCompra, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                Consultar(True)
                MostrarTabs(0, ficFacturaCompra, 2)
                _ingresando_datos = False
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Oper = "Emitir" Then
                IndEmit = True
                Emitir()
            ElseIf Oper = "Anular" Then
                Anular()
            Else
                IndEmit = False
                If oeMovimientoDocumento.TipoOperacion = String.Empty Then oeMovimientoDocumento.TipoOperacion = "I"
                GuardarMovimientoDocumento()
                'If GuardarMovimientoDocumento() Then
                '    MostrarTabs(0, ficFacturaCompra, 2)
                '    Consultar(True)
                'Else
                '    MostrarTabs(1, ficFacturaCompra, 1)
                'End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaFacturaCompra.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            InicializarControles()
            If IdDocumento = "" Then IdDocumento = griListaFacturaCompra.ActiveRow.Cells("Id").Value.ToString
            Oper = "Editar"
            If EditarFacturaCompra() Then
                oeMovimientoDocumento.TipoOperacion = "A"
                If cboEstadoFacturaM.Text = "EMITIDA" Then
                    If _bandanular Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
                    Else
                        ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 0)
                    End If
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
                End If
                MostrarTabs(1, ficFacturaCompra, 1)
                'gbeListadoMatSer.Expanded = False
                Operacion = "Editar"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaFacturaCompra
                If ValidarGrilla(griListaFacturaCompra, "Facturas") Then
                    oeMovimientoDocumento.Id = .ActiveRow.Cells("Id").Value
                    oeMovimientoDocumento.TipoOperacion = "FAC"
                    oeMovimientoDocumento = olMovimientoDocumento.ObtenerDocumentosPorCompras(oeMovimientoDocumento)
                    If oeMovimientoDocumento.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la factura : " & _
                                       .ActiveRow.Cells("NombreDocumento").Value.ToString & " ?", _
                                                          "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMovimientoDocumento.TipoOperacion = "E"
                            olMovimientoDocumento.Eliminar(oeMovimientoDocumento)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            If Not ConfiguracionRegionalPeru() Then Exit Sub
            Dim oecli As New e_Cliente
            Dim oeTipoPago As New e_TipoPago
            If cboTipoPago.SelectedIndex <> -1 Then oeTipoPago = cboTipoPago.Items(cboTipoPago.SelectedIndex).ListObject
            oecli = cboCliente.Items(cboCliente.SelectedIndex).ListObject
            'oeMovimientoDocumento.Serie = FormatoDocumento(txtSerieM.Text.Trim, 4)
            oeMovimientoDocumento.Serie = txtSerieM.Text.Trim
            'oeMovimientoDocumento.Numero = FormatoDocumento(txtNumeroM.Text.Trim, 10) '@0001
            oeMovimientoDocumento.Numero = FormatoDocumento(txtNumeroM.Text.Trim, 8)
            oeMovimientoDocumento.Direccion = cboDireccion.Text
            oeMovimientoDocumento.NombreProveedor = cboCliente.Text
            oeMovimientoDocumento.Ruc = oecli.Dni
            oeMovimientoDocumento.FechaEmision = fecFechaActual.Value
            oeMovimientoDocumento.FechaVencimiento = fecFechaActual.DateTime.AddDays(oeTipoPago.Dias)
            oeMovimientoDocumento.SubTotal = Math.Round(txtSubTotal.Value, 4)
            oeMovimientoDocumento.IGV = Math.Round(txtIGV.Value, 4)
            oeMovimientoDocumento.Total = Math.Round(txtTotal.Value, 4)
            oeMovimientoDocumento.ImporteDetraer = IIf(txtNetoPagar.Value = 0, 0, txtTotal.Value)
            oeMovimientoDocumento.NetoPagar = txtNetoPagar.Value

            If chkElectronico.Checked Then
                Dim frmImpresion As New frm_FacturaBoletaElectronico
                frmImpresion.mt_CargarDatos(oeMovimientoDocumento.Id, False)
                frmImpresion.StartPosition = FormStartPosition.CenterScreen
                frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                frmImpresion.ShowDialog()
            Else
                Dim ofrm As New frm_ReporteFacturaVenta
                ofrm.CargarDocumento2(oeMovimientoDocumento, lstDetalleDocumento, IndEmit, verCantidad.Checked, verOmiteCta.Checked)
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.Refresh()
                ofrm.ShowDialog()
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griListaFacturaCompra.Rows.Count = 0 Then Throw New Exception("No hay ninguna Factura de Servicio para exportar al Excel")
            Exportar_Excel(griListaFacturaCompra)

            If griListaDetalleFactura.Rows.Count = 0 Then Throw New Exception("No hay ningún Detalle de Factura de Servicio para exportar al Excel")
            Exportar_Excel(griListaDetalleFactura)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_FacturarServicio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
            Case "Editar"
                oeMovimientoDocumento.TipoOperacion = "A"
                If cboEstadoFacturaM.Text = "EMITIDA" Then
                    If _bandanular Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
                    Else
                        ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 0)
                    End If
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
                End If
            Case "Inicializa"
                If griListaFacturaCompra.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_FacturarServicio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_FacturarServicio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_FacturarServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            gmt_ConfigurarEventoKeyEnter_Tab(Me, txtNumeroDoc.Name, txtGlosa.Name)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            InicializaTiempo()
            Inicializar()
            InicializaControlesListado()
            CargarCombos()
            CargarListados(New List(Of e_MovimientoDocumento))
            MostrarTabs(0, ficFacturaCompra, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FacturarServicio_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griListaServicios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaServicios.CellChange
        Try
            griListaServicios.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaServicios_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaServicios.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaServicios.DisplayLayout.Bands(0).Layout.ActiveRow
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.LightYellow
                            .Appearance.ForeColor = Color.Red
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleFactura_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaDetalleFactura.CellChange
        Try
            griListaDetalleFactura.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleFactura_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaDetalleFactura.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaDetalleFactura.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.LightYellow
                            .Appearance.ForeColor = Color.Red
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                        End If
                    End With
                Case "Cantidad"
                    With griListaDetalleFactura.ActiveRow
                        If .Cells("Cantidad").Value <= 0 Then
                            .Cells("Cantidad").Value = cantmat
                            Throw New Exception("El cantidad ingresada no puede ser menor o igual a 0. ")
                        End If
                        If .Cells("Cantidad").Value.Equals("") Then
                            .Cells("Cantidad").Value = 1
                        End If
                    End With
                    CalcularSubtotalesTotalesMaterial()
                Case "Precio"
                    With griListaDetalleFactura.ActiveRow
                        If .Index > -1 Then
                            If .Cells("Precio").Value <= 0 Then
                                .Cells("Precio").Value = 1
                                Throw New Exception("El precio unitario con impuesto no puede ser menor o igual a 0.")
                            End If
                        End If
                    End With
                    CalcularSubtotalesTotalesMaterial(1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleFactura_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griListaDetalleFactura.BeforeCellUpdate
        With griListaDetalleFactura
            Select Case e.Cell.Column.Key
                Case "Cantidad", "Precio"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    cantmat = e.Cell.Value
            End Select
        End With
    End Sub

    Private Sub griListaFacturaCompra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaFacturaCompra.DoubleClick
        If griListaFacturaCompra.Selected.Rows.Count > 0 Then
            Dim idestado As String = griListaFacturaCompra.ActiveRow.Cells("IdEstadoDocumento").Value
            Dim leest As New List(Of e_Estado)
            leest = leEstado.Where(Function(item) item.Id = idestado).ToList
            Dim estado As String = leest(0).Nombre
            If estado <> "ANULADO" Then
                Editar()
            Else
                mensajeEmergente.Problema("No se puede Editar un Documento con estado: " & estado, True)
            End If
        End If
    End Sub

    Private Sub txtNumeroDoc_Enter(sender As Object, e As EventArgs) Handles txtNumeroDoc.Enter
        txtNumeroDoc.SelectAll()
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
    End Sub

    Private Sub rbNroDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNroDoc.CheckedChanged
        gbNroDoc.Enabled = rbNroDoc.Checked
        txtSerie.Focus()
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        If cboMoneda.SelectedIndex <> -1 Then
            oeMonedaDoc = cboMoneda.Items(cboMoneda.SelectedIndex).ListObject
            RecalcularMontosOrig_Anticipos()
        End If
        oeMovimientoDocumento.IdMoneda = cboMoneda.Value
    End Sub

    Private Sub txtSerieM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerieM.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumeroM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroM.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        'txtNumero.Text = FormatoDocumento(txtNumero.Text, 10) '@0001
        txtNumero.Text = FormatoDocumento(txtNumero.Text, 8)
    End Sub

    Private Sub chkElectronico_CheckedChanged(sender As Object, e As EventArgs) Handles chkElectronico.CheckedChanged
        txtSerieM.Text = String.Empty
        txtNumeroM.Text = String.Empty
    End Sub

    Private Sub txtSerieM_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieM.Validated
        Try
            Dim indSeriePermite As Boolean = False
            If txtSerieM.Text.Trim <> "" Then

                If chkElectronico.Checked Then
                    txtSerieM.Text = FormatoSerieElectronica(txtSerieM.Text, IIf(cboTipoDocumento.Value = "1CH000000026", "F", "B"))
                Else
                    txtSerieM.Text = FormatoDocumento(txtSerieM.Text, 4)
                End If

                For Each i In loConcepto
                    If i.Valor2.Trim = txtSerieM.Text.Trim Then
                        indSeriePermite = True
                        Exit For
                    End If
                Next
                If indSeriePermite = False Then
                    txtSerieM.Text = String.Empty
                    Throw New Exception("Serie no permitida para el usuario.")
                End If

                Dim oe As New e_MovimientoDocumento
                oe.TipoOperacion = "NUM"
                oe.Serie = txtSerieM.Text.Trim
                oe.IdTipoDocumento = cboTipoDocumento.Value
                txtNumeroM.Text = olMovimientoDocumento.ObtenerNumDoc(oe).Numero
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNumeroM_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroM.Validated
        'txtNumeroM.Text = FormatoDocumento(txtNumeroM.Text, 10)
        txtNumeroM.Text = FormatoDocumento(txtNumeroM.Text, 8)
    End Sub

    Private Sub fecFechaActual_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaActual.ValueChanged
        CalculaTipoCambio(fecFechaActual.Value)
    End Sub

    Private Sub cboCliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.ValueChanged
        If cboCliente.SelectedIndex > -1 Then
            oeCliente = New e_Cliente
            loDireccionEmpresa = New List(Of e_Direccion_EmpresaPersona)
            Dim oeDireccion As New e_Direccion_EmpresaPersona
            Dim olDireccion As New l_Direccion_EmpresaPersona
            oeCliente = cboCliente.Items(cboCliente.SelectedIndex).ListObject
            oeMovimientoDocumento.IdClienteProveedor = cboCliente.Value
            oeDireccion.IdPersonaEmpresa = IIf(oeCliente.TipoPersonaEmpresa = 1, oeCliente.IdPersona, oeCliente.IdEmpresa)
            oeDireccion.TipoPersonaEmpresa = oeCliente.TipoPersonaEmpresa
            loDireccionEmpresa = olDireccion.Listar(oeDireccion)
            LlenarCombo(cboDireccion, "Nombre", loDireccionEmpresa, 0)
            oeTipoPago = New e_TipoPago
            oeTipoPago.TipoOperacion = "F"
            oeTipoPago.IdClienteProveedor = oeCliente.Id
            oeTipoPago.TipoClienteProveedor = 1
            llTipoPago = olTipoPago.Listar(oeTipoPago)
            If llTipoPago.Count > 0 Then
                cboTipoPago.DataSource = Nothing
                LlenarCombo(cboTipoPago, "Nombre", llTipoPago, 0)
            Else
                CargarTipoPago()
            End If
        Else
            cboDireccion.DataSource = Nothing
            cboDireccion.SelectedIndex = -1
            cboTipoPago.DataSource = Nothing
            cboTipoPago.SelectedIndex = -1
        End If
    End Sub

    Private Sub DecDetraer_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecDetraer.ValueChanged
        Calcular_Detraccion()
    End Sub

    Private Sub DecMontoDetraccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecMontoDetraccion.ValueChanged
        Calcular_Detraccion()
    End Sub

    Private Sub Calcular_Detraccion()
        If DecDetraer.Value > 0 Then
            DecMontoDetraccion.Value = Me.txtTotal.Value * (DecDetraer.Value / 100)
            oeMovimientoDocumento.Venta.PorcenDetra = DecDetraer.Value
        Else
            oeMovimientoDocumento.Venta.PorcenDetra = 0
            DecMontoDetraccion.Value = 0
        End If
        If DecMontoDetraccion.Value > 0 Then
            Me.txtNetoPagar.Value = txtTotal.Value - Me.DecMontoDetraccion.Value
            oeMovimientoDocumento.Venta.Detraccion = DecMontoDetraccion.Value
            oeMovimientoDocumento.Venta.SaldoDetraccion = DecMontoDetraccion.Value
        Else
            oeMovimientoDocumento.Venta.Detraccion = 0
            oeMovimientoDocumento.Venta.SaldoDetraccion = 0
            txtNetoPagar.Value = 0
        End If
    End Sub

    Private Sub fecPeriodo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecPeriodo.Validated
        CalcularPeriodo(fecPeriodo.DateTime.Month, fecPeriodo.DateTime.Year)
    End Sub

    Private Sub fecPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecPeriodo.ValueChanged
        CalcularPeriodo(fecPeriodo.DateTime.Month, fecPeriodo.DateTime.Year)
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeMovimientoDocumento.Venta.Glosa = txtGlosa.Text
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        If cboTipoDocumento.SelectedIndex <> -1 Then
            oeTipoDoc = cboTipoDocumento.Items(cboTipoDocumento.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub btnCargaDocAso_Click(sender As Object, e As EventArgs) Handles btnCargaDocAso.Click
        Try
            ListarDoc()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerieDoc_Validated(sender As Object, e As EventArgs) Handles txtSerieDoc.Validated
        txtSerieDoc.Text = FormatoDocumento(txtSerieDoc.Text, 4)
    End Sub

    Private Sub txtNumeroDoc_Validated(sender As Object, e As EventArgs) Handles txtNumeroDoc.Validated
        'txtNumeroDoc.Text = FormatoDocumento(txtNumeroDoc.Text, 10)
        txtNumeroDoc.Text = FormatoDocumento(txtNumeroDoc.Text, 8)
    End Sub

    Private Sub txtNumeroDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroDoc.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ListarDoc()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDocumentoVenta_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griListaDocumentoVenta.DoubleClickRow
        Try
            AgregarDetalleDoc(griListaDocumentoVenta.ActiveRow.Cells("Id").Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Function EditarFacturaCompra() As Boolean
        Dim id As String
        Try
            id = IdDocumento
            With griListaFacturaCompra
                'id = .ActiveRow.Cells("Id").Value.ToString
                If id.Length > 0 Then
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.Id = id
                    oeMovimientoDocumento = olMovimientoDocumento.ObtenerVenta(oeMovimientoDocumento)
                    If _bandanular Then
                        If oeMovimientoDocumento.Saldo <> oeMovimientoDocumento.Total Then
                            Throw New Exception("No se puede anular el documento por que tiene Cobros Asociados")
                        End If
                    End If
                    With oeMovimientoDocumento
                        If .Activo Then
                            chkElectronico.Checked = .IndElectronico
                            verOmiteCta.Checked = .IndDetalleGlosa
                            txtOrdenCompra.Text = .OrdenCompra
                            cboCliente.Value = .IdClienteProveedor
                            cboEstadoFacturaM.Value = .IdEstadoDocumento.Trim
                            txtNumeroM.Value = .Numero
                            txtSerieM.Value = .Serie
                            cboTipoPago.Value = .Venta.IdTipoPago
                            For Each oeaux As e_Direccion_EmpresaPersona In loDireccionEmpresa
                                If oeaux.oeDireccion.Id = oeMovimientoDocumento.Venta.IdDireccion Then
                                    cboDireccion.Value = oeaux.Id
                                    Exit For
                                Else
                                    cboDireccion.SelectedIndex = 0
                                End If
                            Next
                            txtGlosa.Text = .Venta.Glosa
                            cboMoneda.Value = .IdMoneda
                            fecFechaActual.Value = .FechaEmision
                            txtSubTotal.Value = .SubTotal
                            txtIGV.Value = .IGV
                            txtTotal.Value = .Total
                            totalSinIgv = .SubTotal
                            totalIgv = .IGV
                            totalConIng = .Total
                            DecDetraer.Value = .Venta.PorcenDetra
                            cboTipoBien.Value = .IdTipoBien
                            'Muestra Periodo
                            If .IdPeriodo.Trim <> String.Empty Then
                                Dim lePer As New List(Of e_Periodo)
                                lePer = lePeriodo.Where(Function(item) item.Id = .IdPeriodo).ToList
                                fecPeriodo.Value = lePer(0).Mes & " / " & lePer(0).Ejercicio
                            End If
                            ConsultarDetalleDocumento()
                            cbAnticipo.Checked = .IndAfectaAnticipo
                            decAnticipo.Value = IIf(.IndAfectaAnticipo, .Monto_Anticipo, "0.00")
                            If .IndAfectaAnticipo Then
                                Cargar_Anticipos_Check()
                                Seleccionar_Anticipos()
                                decAnticipo.Value = Calcular_Monto_Anticipo()
                                CalcularSubtotalesTotalesMaterial()
                            End If

                            If Oper <> "Emitir" Then
                                gbeListadoMatSer.Enabled = True
                                Agrupacion2.Enabled = True
                                Agrupacion4.Enabled = True
                            Else
                                gbeListadoMatSer.Enabled = False
                                Agrupacion2.Enabled = False
                                Agrupacion4.Enabled = False
                            End If
                            Return True
                        Else
                            Throw New Exception(Me.Text & ": El Registro se encuentra eliminado y no se puede editar")
                        End If
                    End With
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Seleccionar_Anticipos()
        oeDocAsoc = New e_DocumentoAsociado
        oeDocAsoc.TipoOperacion = "T"
        oeDocAsoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
        lstDocAsoc = New List(Of e_DocumentoAsociado)
        lstDocAsoc = olDocAsoc.Listar(oeDocAsoc)

        For Each anticipos In griAnticipos.Rows
            For Each DocAsoc In lstDocAsoc
                If anticipos.Cells("Id").Value = DocAsoc.IdMovimientoDocumentoAsoc Then
                    anticipos.Cells("Seleccionar").Value = True
                    anticipos.Cells("MontoOperar").Value = DocAsoc.Monto_Operar
                    anticipos.Cells("MontoOriginal").Value = DocAsoc.Monto_Desc
                End If
            Next
        Next
        'RecalcularMontosOrig_Anticipos()
        griAnticipos.Update()
    End Sub
    Public Sub ConsultarDetalleDocumento()
        Try
            listarDetalleDocumento(True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub listarDetalleDocumento(Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeDetalleDocumento = New e_DetalleDocumento
            With griListaDetalleFactura
                oeDetalleDocumento.TipoOperacion = "COM"
                oeDetalleDocumento.Activo = Activo
                oeDetalleDocumento.IdMovimientoDocumento = oeMovimientoDocumento.Id
                oeDetalleDocumento.IndServicioMaterial = "S"
                lstDetalleDocumento = olDetalleDocumento.Listar(oeDetalleDocumento)
                .DataSource = lstDetalleDocumento
                .DisplayLayout.Bands(0).Columns("FactorRefUni").Hidden = True
                .DisplayLayout.Bands(0).Columns("PrecioUnitarioSinImp").Hidden = True
                .DisplayLayout.Bands(0).Columns("PrecioUnitarioSinImp").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Precio").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PrecioUnitarioSinImp").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("PrecioUnitarioSinImp").CellClickAction = CellClickAction.EditAndSelectText
                .DisplayLayout.Bands(0).Columns("PrecioUnitarioSinImp").MaskInput = "{double:9.4}"
                .DisplayLayout.Bands(0).Columns("PrecioUnitarioSinImp").Format = "##,###,###0.0000"
                .DisplayLayout.Bands(0).Columns("Precio").Format = "##,###,###0.00"
                .DisplayLayout.Bands(0).Columns("Cantidad").Format = "##,###,###0.00"
                .DisplayLayout.Bands(0).Columns("Total").Format = "##,###,###0.00"
                .DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.False
                llenaCombosGrillaMaterial()
            End With
        Catch ex As Exception
            Throw ex
        End Try
        If griListaDetalleFactura.Rows.Count > 0 Then griListaDetalleFactura.Focus()
    End Sub

    Public Sub InicializaControlesListado()
        cboTipoDocumento.Text = "FACTURA"
        txtSerieD.Value = String.Empty
        rbDatosAdicionales.Checked = True
        fecDesde.Value = Date.Now.AddDays(-7)
        fecHasta.Value = Date.Now
        Me.lbl_etiqueta.Text = ""
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            IdDocumento = String.Empty
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                If rbDatosAdicionales.Checked Then
                    .Activo = Activo
                    .FechaInicio = fecDesde.Value
                    .FechaFinal = fecHasta.Value
                    .IndServicioMaterial = "S"
                    .IndCompraVenta = 2
                    .IdTipoDocumento = cboTipoDocumento.Value
                    If txtSerieD.Text.Trim.Length > 0 Then txtSerieD.Text = FormatoDocumento(txtSerieD.Text, 4)
                    .Serie = txtSerieD.Value
                Else
                    .Serie = FormatoDocumento(txtSerie.Value, 4)
                    '.Numero = FormatoDocumento(txtNumero.Value, 10) '@0001
                    .Numero = FormatoDocumento(txtNumero.Value, 8)
                    .IndServicioMaterial = "S"
                    If .Serie Is Nothing OrElse .Serie.Trim = "" Then Throw New Exception("Agregue el número de serie de la factura para listar.")
                    If .Numero Is Nothing OrElse .Numero.Trim = "" Then Throw New Exception("Agregue el número de factura para listar.")
                End If
                .TipoOperacion = "FAC"
            End With
            CargarListados(olMovimientoDocumento.Listar(oeMovimientoDocumento))
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Function GuardarMovimientoDocumento() As Boolean
        Try
            Dim c_sel As Integer = 0, c_monto As Integer = 0
            'VALIDAR APLICACIÓN DE ANTICIPOS
            If b_anticipo Then
                c_sel = griAnticipos.Rows.Where(Function(x) x.Cells("Seleccionar").Value = True).Count
                c_monto = griAnticipos.Rows.Where(Function(x) x.Cells("MontoOperar").Value > 0.0).Count
                If c_sel < 1 Then Throw New Exception("No puede aplicar un anticipo sino ha seleccionado los documentos de anticipos.")
                If decAnticipo.Value = 0 Then Throw New Exception("No puede aplicar un anticipo con monto igual a 0.")
                If c_monto < c_sel Then Throw New Exception("No puede aplicar un anticipo porque el Monto a Operar de uno o más documentos seleccionados es 0.")
                If decAnticipo.Value > lstDetalleDocumento.Sum(Function(x) x.Subtotal) Then Throw New Exception("No puede aplicar un anticipo con monto mayor al subtotal.")
            End If
            ObtenerDatosControles()
            oeMovimientoDocumento.IndAfectaAnticipo = b_anticipo
            oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeAnticipo.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeMovimientoDocumento = olMovimientoDocumento.Guardar(oeMovimientoDocumento, oeAnticipo)
            If cboEstadoFacturaM.Text = "GENERADA" Then
                    If MessageBox.Show("La Información ha sido grabada satisfactoriamente en " & Me.Text & Environment.NewLine _
                                   & "¿Desea Continuar Modificando el Documento.?", "Mensaje del sistema", MessageBoxButtons.YesNo _
                                   , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        'Emitir()
                        'MostrarTabs(0, ficFacturaCompra, 0)
                        IdDocumento = oeMovimientoDocumento.Id
                        Editar()
                    Else
                        Consultar(_Activo)
                        MostrarTabs(0, ficFacturaCompra, 0)
                        ficFacturaCompra.Focus()
                    End If
                Else
                    mensajeEmergente.Confirmacion("La Información ha sido grabada satisfactoriamente en " & Me.Text, True)
                    Consultar(_Activo)
                    MostrarTabs(0, ficFacturaCompra, 0)
                    ficFacturaCompra.Focus()
                End If
                lstDetalleDocumento = New List(Of e_DetalleDocumento)
                Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ObtenerDatosControles()
        Try
            Dim oe As New e_Direccion_EmpresaPersona
            Dim i As Integer = cboDireccion.SelectedIndex
            If cboDireccion.SelectedIndex <> -1 Then oe = cboDireccion.Items(i).ListObject
            Dim oeTipoPago As New e_TipoPago
            If cboTipoPago.SelectedIndex <> -1 Then oeTipoPago = cboTipoPago.Items(cboTipoPago.SelectedIndex).ListObject
            With oeMovimientoDocumento
                .IndServicioMaterial = "S"
                .IndElectronico = chkElectronico.Checked
                .IndDetalleGlosa = verOmiteCta.Checked
                .IdTipoBien = cboTipoBien.Value
                .OrdenCompra = txtOrdenCompra.Text
                '.Serie = FormatoDocumento(txtSerieM.Text.Trim, 4)
                .Serie = txtSerieM.Text.Trim
                '.Numero = FormatoDocumento(txtNumeroM.Text.Trim, 10) '@0001
                .Numero = FormatoDocumento(txtNumeroM.Text.Trim, 8)
                .IdUsuarioCrea = gUsuarioSGI.Id
                .FechaEmision = fecFechaActual.Value
                .FechaVencimiento = fecFechaActual.DateTime.AddDays(oeTipoPago.Dias)
                .SubTotal = Math.Round(txtSubTotal.Value, 4)
                .IdClienteProveedor = cboCliente.Value
                .IGV = Math.Round(txtIGV.Value, 4)
                .Total = Math.Round(txtTotal.Value, 4)
                .Saldo = Math.Round(txtTotal.Value, 4)
                '.FechaVencimiento = fecFechaActual.Value
                .IdEstadoDocumento = cboEstadoFacturaM.Value
                .IndCompraVenta = 2
                .IdTipoDocumento = txtTipoDocumento.Tag
                .IdMoneda = cboMoneda.Value
                .IdCuentaContable = ""
                .TipoCambio = decTc.Value
                ._Operador = 1
                .Mac_PC_Local = MacPCLocal()
                .Venta.IdTipoPago = oeTipoPago.Id
                .Venta.Exonerado = 0
                .Venta.Exportacion = 0
                .Venta.Inafecto = 0
                .Venta.ISC = 0
                .Venta.OtrosTributos = 0
                .Venta.Descuentos = 0
                .Venta.IdTipoVenta = ""
                .Venta.IdDireccion = oe.oeDireccion.Id
                .Venta.Gravado = IIf(cboMoneda.Value <> "1CH01", Math.Round(.SubTotal * decTc.Value, 2), .SubTotal)
                .Venta.IGV = IIf(cboMoneda.Value <> "1CH01", Math.Round(.IGV * decTc.Value, 2), .IGV)
                If DecDetraer.Value > 0 Then
                    .Venta.PorcenDetra = DecDetraer.Value
                Else
                    .Venta.PorcenDetra = 0
                End If
                If DecMontoDetraccion.Value > 0 Then
                    .Venta.Detraccion = DecMontoDetraccion.Value
                    .Venta.SaldoDetraccion = DecMontoDetraccion.Value
                Else
                    .Venta.Detraccion = 0
                    .Venta.SaldoDetraccion = 0
                End If
                .lstDetalleDocumento = lstDetalleDocumento

                'VALIDAR ACTUALIZACIÓN DE DETALLE DE SERVICIOS
                If oeMovimientoDocumento.TipoOperacion = "A" Then
                    oeDetalleDocumento = New e_DetalleDocumento
                    oeDetalleDocumento.Activo = True
                    oeDetalleDocumento.TipoOperacion = "VEN"
                    oeDetalleDocumento.IndServicioMaterial = "S"
                    oeDetalleDocumento.IdMovimientoDocumento = oeMovimientoDocumento.Id
                    olDetalleDocumento = New l_DetalleDocumento
                    Dim list_DetalleDoc As New List(Of e_DetalleDocumento)
                    list_DetalleDoc = olDetalleDocumento.Listar(oeDetalleDocumento)
                    If list_DetalleDoc(0).IdMaterialServicio <> .lstDetalleDocumento(0).IdMaterialServicio Then
                        list_DetalleDoc(0).TipoOperacion = "E"
                        .lstDetalleDocumento.Add(list_DetalleDoc(0))
                    End If
                End If

                'MONTOS QUE SE SE HARÁ EFECTO POR ANTICIPO Y ASOCIAR DOCUMENTOS
                If cbAnticipo.Checked Then
                    .IndAfectaAnticipo = True
                    .Monto_Anticipo = decAnticipo.Value
                    .IndAnticipo = False
                    Dim lstDocAsoc_Aux As New List(Of e_DocumentoAsociado)
                    If oeMovimientoDocumento.TipoOperacion <> "I" Then
                        lstDocAsoc_Aux = lstDocAsoc
                    End If
                    lstDocAsoc = New List(Of e_DocumentoAsociado)
                    For Each doc_antic In griAnticipos.Rows.Where(Function(x) x.Cells("Seleccionar").Value = True And x.Cells("MontoOperar").Value > 0).ToList
                        oeDocAsoc = New e_DocumentoAsociado
                        If lstDocAsoc_Aux.Count > 0 Then
                            If lstDocAsoc_Aux.Where(Function(x) x.IdMovimientoDocumentoAsoc.IndexOf(doc_antic.Cells("Id").Value) <> -1).Count = 0 Then
                                oeDocAsoc.TipoOperacion = "I"
                            Else
                                oeDocAsoc.TipoOperacion = "A"
                                oeDocAsoc.Id = lstDocAsoc_Aux.Where(Function(x) x.IdMovimientoDocumentoAsoc.IndexOf(doc_antic.Cells("Id").Value) <> -1).ToList.Item(0).Id
                            End If
                        Else
                            oeDocAsoc.TipoOperacion = "I"
                        End If
                        oeDocAsoc.Monto_Operar = doc_antic.Cells("MontoOperar").Value
                        oeDocAsoc.Monto_Desc = doc_antic.Cells("MontoOriginal").Value
                        oeDocAsoc.IdMovimientoDocumentoAsoc = doc_antic.Cells("Id").Value
                        lstDocAsoc.Add(oeDocAsoc)
                    Next
                    If oeMovimientoDocumento.TipoOperacion <> "I" Then
                        For Each doc_ant_el In lstDocAsoc_Aux
                            If lstDocAsoc.Where(Function(x) x.IdMovimientoDocumentoAsoc.IndexOf(doc_ant_el.IdMovimientoDocumentoAsoc) <> -1).Count = 0 Then
                                oeDocAsoc = New e_DocumentoAsociado
                                oeDocAsoc.TipoOperacion = "E"
                                oeDocAsoc.Id = doc_ant_el.Id
                                lstDocAsoc.Add(oeDocAsoc)
                            End If
                        Next
                    End If
                    .DocAsoc = lstDocAsoc

                    Dim total_st As Double = oeMovimientoDocumento.lstDetalleDocumento.Sum(Function(x) x.Subtotal)
                    Dim cant_st As Double = oeMovimientoDocumento.lstDetalleDocumento.Count, cont As Integer = 0
                    Dim total_antic As Double = oeMovimientoDocumento.Monto_Anticipo
                    For Each detalle In oeMovimientoDocumento.lstDetalleDocumento
                        cont += 1
                        If cont < cant_st Then
                            detalle.Monto_Anticipo = oeMovimientoDocumento.Monto_Anticipo * (detalle.Subtotal / total_st)
                            total_antic = total_antic - detalle.Monto_Anticipo
                        Else
                            detalle.Monto_Anticipo = total_antic
                            total_antic = 0
                        End If
                    Next
                Else
                    oeMovimientoDocumento.IndAfectaAnticipo = False
                    oeMovimientoDocumento.Monto_Anticipo = 0.0
                    If oeMovimientoDocumento.TipoOperacion <> "I" Then
                        oeDocAsoc = New e_DocumentoAsociado
                        oeDocAsoc.TipoOperacion = "T"
                        oeDocAsoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                        lstDocAsoc = New List(Of e_DocumentoAsociado)
                        lstDocAsoc = olDocAsoc.Listar(oeDocAsoc)
                        For Each doc_ant_el In lstDocAsoc
                            doc_ant_el.TipoOperacion = "E"
                        Next
                    End If
                End If

                'DOCUMENTO ANTICIPO QUE SE RELACIONARÁ CON LA FACTURA DE ANTICIPO
                If lstDetalleDocumento.Where(Function(x) x.NombreMaterialServicio.IndexOf("ANTICIPO") <> -1).Count > 0 Then
                    oeAnticipo = New e_MovimientoDocumento
                    .IndAnticipo = True
                    .IndAfectaAnticipo = False
                    .Monto_Anticipo = 0.0
                    With oeAnticipo
                        .TipoOperacion = oeMovimientoDocumento.TipoOperacion
                        .IndServicioMaterial = "S"
                        .IndElectronico = False
                        .IndDetalleGlosa = verOmiteCta.Checked
                        .IdTipoBien = cboTipoBien.Value
                        .OrdenCompra = ""
                        .Serie = txtSerieM.Text.Trim
                        '.Numero = FormatoDocumento(txtNumeroM.Text.Trim, 10) '@0001
                        .Numero = FormatoDocumento(txtNumeroM.Text.Trim, 8)
                        .IdUsuarioCrea = gUsuarioSGI.Id
                        .FechaEmision = fecFechaActual.Value
                        .FechaVencimiento = fecFechaActual.DateTime.AddDays(oeTipoPago.Dias)
                        .SubTotal = Math.Round(txtSubTotal.Value, 4)
                        .IdClienteProveedor = cboCliente.Value
                        .IGV = 0.0
                        .Total = Math.Round(txtSubTotal.Value, 4)
                        .Saldo = Math.Round(txtSubTotal.Value, 4)
                        '.FechaVencimiento = fecFechaActual.Value
                        .IdEstadoDocumento = cboEstadoFacturaM.Value
                        .IndCompraVenta = 5
                        .IdTipoDocumento = "1CH000000070"
                        .IdMoneda = cboMoneda.Value
                        .IdCuentaContable = ""
                        .TipoCambio = decTc.Value
                        ._Operador = 1
                        .Mac_PC_Local = MacPCLocal()
                        .IdPeriodo = oeMovimientoDocumento.IdPeriodo
                        .IndAnticipo = True
                        .IndAfectaAnticipo = False
                        .Monto_Anticipo = 0.0
                    End With
                End If

               
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InicializarControles()
        cboTipoBien.SelectedIndex = 0
        txtSerieM.Value = String.Empty
        txtNumeroM.Value = String.Empty
        cboMoneda.Value = "1CH01"
        'cboCategoriaServicios.SelectedIndex = 0
        txtTipoDocumento.Text = cboTipoDocumento.Text
        txtTipoDocumento.Tag = cboTipoDocumento.Value
        Me.gbeListadoMatSer.Enabled = 1
        Me.MenuDetalle.Enabled = 1
        utcListadoMatSer.Tabs("1").Visible = True
        ' LlenaComboCategoriaServicios()
        chkElectronico.Enabled = True
        chkElectronico.Checked = True
        verOmiteCta.Checked = False
        txtOrdenCompra.Text = String.Empty

        Me.txtSubTotal.Value = 0
        Me.txtIGV.Value = 0
        Me.txtTotal.Value = 0
        Me.DecDetraer.Value = 0
        fecFechaActual.Value = Date.Now
        fecPeriodo.Value = Date.Now
        cboCliente.SelectedIndex = -1
        cboDireccion.SelectedIndex = -1
        cboTipoPago.SelectedIndex = -1
        txtGlosa.Text = String.Empty
        'cboTipoBien.Value = "1SI000000027"
        If cboTipoDocumento.Text <> "FACTURA" Then
            agrDetraccion.Visible = False
            etiSubTotal.Visible = False
            etiIgv.Visible = False
            txtSubTotal.Visible = False
            txtIGV.Visible = False
            agrTipoBien.Visible = False
        Else
            agrDetraccion.Visible = True
            etiSubTotal.Visible = True
            etiIgv.Visible = True
            txtSubTotal.Visible = True
            txtIGV.Visible = True
            agrTipoBien.Visible = True
        End If
        lstDetalleDocumento = New List(Of e_DetalleDocumento)
        CargarDetalleDoc(lstDetalleDocumento)
        ListarServicios(True)
        verCantidad.Checked = False
        txtSerieDoc.Text = String.Empty
        txtNumeroDoc.Text = String.Empty
        LimpiaGrid(griListaDocumentoVenta, OrigenDatos1)
        decAnticipo.Value = "0.00"
        gbeListadoMatSer.Enabled = True
        Agrupacion2.Enabled = True
        Agrupacion4.Enabled = True
    End Sub

    Private Sub CargarServicio(ByVal leServ As List(Of e_Servicio))
        Try
            With griListaServicios
                .ResetDisplayLayout()
                .DataSource = leServ
                For Each col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If col.Key.Contains("Id") Then col.Hidden = True
                    If col.Key = "Seleccion" Then
                        col.CellActivation = Activation.AllowEdit
                        col.CellClickAction = CellClickAction.EditAndSelectText
                    Else
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("CategoriaServicio").Hidden = True
                .DisplayLayout.Bands(0).Columns("Precio").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 40
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 200
                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 200
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetalleDoc(ByVal leDetalle As List(Of e_DetalleDocumento))
        Try
            With griListaDetalleFactura
                .ResetDisplayLayout()
                llenaCombosGrillaMaterial()
                griListaDetalleFactura.DataSource = leDetalle
                For Each col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If col.Key.Contains("Id") And col.Key <> "IdUnidadMedida" Then col.Hidden = True
                    If col.Key = "Seleccion" Or col.Key = "Cantidad" Or col.Key = "Precio" Then
                        col.CellActivation = Activation.AllowEdit
                        col.CellClickAction = CellClickAction.EditAndSelectText
                    Else
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FactorRefUni").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UnidadMedida").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndGravado").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndServicioMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("Pos").Hidden = True
                .DisplayLayout.Bands(0).Columns("PrecioUnitarioSinImp").Hidden = True
                .DisplayLayout.Bands(0).Columns("Total").Hidden = True
                .DisplayLayout.Bands(0).Columns("Igv").Hidden = True

                .DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("CodigoMaterialServicio").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NombreMaterialServicio").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("IdUnidadMedida").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Precio").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Subtotal").Header.VisiblePosition = 6

                .DisplayLayout.Bands(0).Columns("CodigoMaterialServicio").Header.Caption = "Codigo"
                .DisplayLayout.Bands(0).Columns("NombreMaterialServicio").Header.Caption = "Servicio"
                .DisplayLayout.Bands(0).Columns("IdUnidadMedida").Header.Caption = "UnidadMedida"

                .DisplayLayout.Bands(0).Columns("Seleccion").Width = 50
                .DisplayLayout.Bands(0).Columns("CodigoMaterialServicio").Width = 70
                .DisplayLayout.Bands(0).Columns("NombreMaterialServicio").Width = 200

                .DisplayLayout.Bands(0).Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Precio").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Subtotal").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("Cantidad").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Precio").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Subtotal").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("Precio").Format = "#,##0.0000"
                .DisplayLayout.Bands(0).Columns("Precio").MaskInput = "{double:9.4}"

                .DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.False

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            ColoresGenerado.Color = Color.White
            ColoresEmitido.Color = Color.Khaki
            ColoresAnulado.Color = Color.PowderBlue
            oeUsuario.Id = gUsuarioSGI.Id
            oeUsuario = olUsuario.Obtener(oeUsuario)
            oeArea = olUsuario.Area(oeUsuario)
            oeEmpresa = New e_Empresa
            oeEmpresa.Id = gs_IdEmpresaSistema.Trim
            oeEmpresa.CargaCompleta = True
            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
            LlenaCombos()
            fecDesde.Value = Date.Now.AddDays(-7)
            fecHasta.Value = Date.Now
            lstDocAsoc = New List(Of e_DocumentoAsociado)
            AsociarMenu()
            griAnticipos.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaCombos()
        Try
            'Cargar Cliente
            oeCliente = New e_Cliente
            oeCliente.TipoClienteProveedor = 1
            LlenarCombo(cboCliente, "Nombre", olCliente.Listar(oeCliente), -1)
            cboCliente.DropDownStyle = DropDownStyle.DropDown
            cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend

            'Cargar Moneda
            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            llMoneda = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboMoneda, "Abreviatura", llMoneda, 0)

            'Cargar Estado Factura
            oeEstado = New e_Estado
            oeEstado.Nombre = "FACTURAR"
            loEstado = olEstado.Listar(oeEstado)
            LlenarCombo(cboEstadoFacturaM, "Nombre", loEstado, -1)

            oeEstado = New e_Estado
            oeEstado.Id = ""
            oeEstado.Nombre = "<TODOS>"
            loEstadoBusq.Add(oeEstado)
            loEstadoBusq.AddRange(loEstado)
            LlenarCombo(cboEstadoFactura, "Nombre", loEstadoBusq, 0)

            'Proceso Tipo Documento            
            Dim oeTipoDoc As New e_TipoDocumento
            Dim olTipoDoc As New l_TipoDocumento
            oeTipoDoc.TipoOperacion = "F"
            leTipoDoc = olTipoDoc.Listar(oeTipoDoc)
            LlenarCombo(cboTipoDocumento, "Nombre", leTipoDoc, 0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerProceso(ByVal cad As String) As String
        Try
            oeProceso = New e_ProcesoNegocio
            oeProceso.Nombre = cad.Trim
            oeProceso = olProceso.Obtener(oeProceso)
            Return oeProceso.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ListarServicios(ByVal Activo As Boolean)
        Try
            oeServicio.TipoOperacion = "V"
            oeServicio.Activo = Activo
            llServicio = olServicio.Listar(oeServicio)
            With griListaServicios
                .DataSource = llServicio
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Anular()
        Try
            If olMovimientoDocumento.Anular(oeMovimientoDocumento, gUsuarioSGI.Id) Then
                mensajeEmergente.Confirmacion("El Documento " & " Nº " & oeMovimientoDocumento.Serie & " - " & oeMovimientoDocumento.Numero & _
                                              " ha sido Anulada", True)
                Consultar(True)
                MostrarTabs(0, ficFacturaCompra, 0)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub AgregarDetalle()
        AsignarServicioFactura()
    End Sub

    Sub QuitarDetalle()
        Try
            Dim sw As Boolean = False
            For Each oeDD As e_DetalleDocumento In lstDetalleDocumento.Where(Function(item) item.Seleccion)
                sw = True
                Dim Referencia As String = oeDD.Pos.ToString
            Next
            If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista")
            If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                lstDetalleDocumento.RemoveAll(AddressOf verificarSeleccionadoMaterial)
                griListaDetalleFactura.DataBind()
                griListaServicios.DataBind()
                CalcularSubtotalesTotalesMaterial()
                If griListaDetalleFactura.Rows.Count < 1 Then
                    cbAnticipo.Checked = False
                    decAnticipo.Value = 0.0
                    gbeListadoMatSer.Expanded = True
                    utcListadoMatSer.Tabs(2).Visible = False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function verificarSeleccionadoMaterial(ByVal oeDetalle As e_DetalleDocumento) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeDetalle.IdMaterialServicio) Then
                If oeDetalle.Seleccion Then
                    Select Case oeDetalle.IndServicioMaterial
                        Case "M"
                            'Dim oeMaterial As New e_Material
                            'oeMaterial.Id = oeDetalle.IdMaterialServicio
                            ''oeMaterial.IdAlmacen = oeDetalle.Id
                            'oeMaterial.TipoOperacion = "5"
                            'oeMaterial.Activo = True
                            'oeMaterial = olMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
                            'llMaterial.Add(oeMaterial)
                        Case "S"
                            Dim oeServicio As New e_Servicio
                            oeServicio.Id = oeDetalle.IdMaterialServicio
                            oeServicio.TipoOperacion = "S"
                            oeServicio.Activo = True
                            oeServicio = olServicio.Obtener(oeServicio)
                            llServicio.Add(oeServicio)
                    End Select
                End If
            End If
            Return oeDetalle.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub AsignarServicioFactura()
        Try
            If lstDetalleDocumento.Count = 1 Then Throw New Exception("Solo se puede Adicionar un Solo Detalle")
            For Each oeServicio As e_Servicio In llServicio
                If oeServicio.Seleccion Then
                    oeDetalleDocumento = New e_DetalleDocumento()
                    With oeDetalleDocumento
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .Seleccion = False
                        .Activo = True
                        .IdMaterialServicio = oeServicio.Id
                        .CodigoMaterialServicio = oeServicio.Codigo
                        .IndServicioMaterial = "S"
                        .NombreMaterialServicio = oeServicio.Nombre
                        .IdUnidadMedida = oeServicio.IdUnidadMedida
                        .IdTipoUnidadMedida = oeServicio.IdTipoUnidadMedida
                        .Cantidad = 1
                        .IndGravado = 1
                        .Igv = .Cantidad * oeServicio.Precio
                        .PrecioUnitarioSinImp = oeServicio.Precio
                        .Pos = lstDetalleDocumento.Count
                        .TipoOperacion = "I"
                        .IdOperacionDetalle = ""
                        .IdVehiculo = ""
                    End With
                    lstDetalleDocumento.Add(oeDetalleDocumento)
                End If
            Next
            CalcularSubtotalesTotalesMaterial()
            griListaDetalleFactura.DataBind()
            llenaCombosGrillaMaterial()
            llServicio.RemoveAll(AddressOf eliminaServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CalcularSubtotalesTotalesMaterial(Optional ByVal sw As Integer = 0)
        totalSinIgv = 0
        totalIgv = 0
        totalConIng = 0
        txtSubTotal.Value = 0
        txtIGV.Value = 0
        txtTotal.Value = 0
        If lstDetalleDocumento.Count > 0 Then
            For Each oeDetalleDoc As e_DetalleDocumento In lstDetalleDocumento
                oeDetalleDoc.Subtotal = Math.Round(oeDetalleDoc.Cantidad * oeDetalleDoc.Precio, 4)
                oeDetalleDoc.Igv = IIf(oeDetalleDoc.IndGravado, Math.Round(oeDetalleDoc.Precio * oeIGV.Porcentaje, 2), 0)
                oeDetalleDoc.Total = Math.Round(oeDetalleDoc.Subtotal + oeDetalleDoc.Igv, 4)
                totalSinIgv += oeDetalleDoc.Subtotal
                totalIgv += oeDetalleDoc.Igv
            Next
            totalConIng = totalSinIgv + totalIgv
            txtSubTotal.Value = Math.Round(totalSinIgv - decAnticipo.Value, 4)
            txtIGV.Value = Math.Round((txtSubTotal.Value) * oeIGV.Porcentaje, 2)
            txtTotal.Value = Math.Round((txtSubTotal.Value) + txtIGV.Value, 2)
            Calcular_Detraccion()
            If txtTotal.Value <= 0.0 Then
                DecMontoDetraccion.Value = 0.0
                txtNetoPagar.Value = 0.0
            End If
        End If
    End Sub

    Private Function eliminaServicio(ByVal oeServicio As e_Servicio) As Boolean
        Return oeServicio.Seleccion
    End Function

    Private Function eliminaMaterial(ByVal oeMat As e_Material) As Boolean
        Return oeMat.Seleccion
    End Function

    Public Sub llenaCombosGrillaMaterial()
        Try
            For i As Integer = 0 To griListaDetalleFactura.Rows.Count - 1
                oeUnidadMedida = New e_UnidadMedida()
                oeUnidadMedida.Activo = True
                oeUnidadMedida.Factor = 0
                oeUnidadMedida.IdTipoUnidadMedida = griListaDetalleFactura.Rows(i).Cells("IdTipoUnidadMedida").Value.ToString
                CrearComboGridPorCelda("IdUnidadMedida", "Nombre", i, griListaDetalleFactura, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)
            Next
            griListaDetalleFactura.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AnularFactura()
        Try
            _bandanular = True
            Editar()
            Oper = "Anular"
            lbl_etiqueta.Text = "ANULANDO FACTURA"
            lbl_etiqueta.Visible = True
            oeMovimientoDocumento.TipoOperacion = "ANU"
            _bandanular = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TrasponerDetalleOrden(ByVal lstDetalleOrden As List(Of e_OrdenMaterial), Optional ByVal _ref As String = "0")
        Try
            'Transpone el Detalle de la Orden al Detalle del Documento
            For Each oeDetOrden As e_OrdenMaterial In lstDetalleOrden
                oeDetalleDocumento = New e_DetalleDocumento()
                With oeDetalleDocumento
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Seleccion = False
                    .IndGravado = True
                    .Activo = True
                    .IdMaterialServicio = oeDetOrden.IdMaterial
                    .CodigoMaterialServicio = oeDetOrden.CodigoMaterial
                    .IndServicioMaterial = "M"
                    .NombreMaterialServicio = oeDetOrden.Material
                    .IdUnidadMedida = oeDetOrden.IdUnidadMedida
                    .IdTipoUnidadMedida = oeDetOrden.IdTipoUnidadMedida
                    .Cantidad = oeDetOrden.CantidadMaterial
                    .Precio = oeDetOrden.PrecioUnitario
                    'cont = MaximaPosicionDetalleFactura()
                    'cont += 1
                    .Pos = _ref
                End With
                lstDetalleDocumento.Add(oeDetalleDocumento)
            Next
            CalcularSubtotalesTotalesMaterial()
            griListaDetalleFactura.DataBind()
            llenaCombosGrillaMaterial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalculaTipoCambio(ByVal Fecha As Date)
        Try
            decTc.Value = TipoCambio(Fecha, True)(0)
            oeMovimientoDocumento.TipoCambio = decTc.Value
            oeIGV = New e_Impuesto
            oeIGV = olIGV.IGV(Fecha)
            decPorcenIGV.Value = oeIGV.Porcentaje
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalcularPeriodo(ByVal Mes As Integer, ByVal Anio As Integer)
        Try
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            oePeriodo.Ejercicio = Anio
            oePeriodo.Mes = Mes
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            oeMovimientoDocumento.IdPeriodo = oePeriodo.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CreaCombo_griFactura()
        'Para Columna de Moneda
        griListaFacturaCompra.DisplayLayout.ValueLists.Add("IdMoneda")
        With griListaFacturaCompra.DisplayLayout.ValueLists("IdMoneda").ValueListItems
            .Clear()
            For Each oeTD As e_Moneda In leMoneda
                .Add(oeTD.Id, oeTD.Abreviatura)
            Next
        End With
        CrearComboGrid3("IdMoneda", "Abreviatura", griListaFacturaCompra, True)
        'Para Columna de Estado Documento
        griListaFacturaCompra.DisplayLayout.ValueLists.Add("IdEstadoDocumento")
        With griListaFacturaCompra.DisplayLayout.ValueLists("IdEstadoDocumento").ValueListItems
            .Clear()
            For Each oeEs As e_Estado In leEstado
                .Add(oeEs.Id, oeEs.Nombre)
            Next
        End With
        CrearComboGrid3("IdEstadoDocumento", "Nombre", griListaFacturaCompra, True)
        'Para Columna de Tipo Documento
        griListaFacturaCompra.DisplayLayout.ValueLists.Add("IdTipoDocumento")
        With griListaFacturaCompra.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
            .Clear()
            For Each oeTD As e_TipoDocumento In leTipoDoc
                .Add(oeTD.Id, oeTD.Nombre)
            Next
        End With
        CrearComboGrid3("IdTipoDocumento", "TipoDocumento", griListaFacturaCompra, True)
    End Sub

    Private Sub CargarCombos()
        Try
            'Cargar Moneda
            oeMoneda = New e_Moneda
            leMoneda = olMoneda.Listar(oeMoneda)
            'Cargar Estado Factura
            oeEstado = New e_Estado
            oeEstado.Nombre = "FACTURAR"
            leEstado = olEstado.Listar(oeEstado)
            'Cargar Servicios
            oeServicio.TipoOperacion = "V"
            oeServicio.Activo = 1
            llServicio = olServicio.Listar(oeServicio)
            'Cargar Periodo
            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = ""
            lePeriodo = olPeriodo.Listar(oePeriodo)
            'Cargar Tipo de Pago
            oeTipoPago = New e_TipoPago
            oeTipoPago.Activo = True
            leTipoPago = olTipoPago.Listar(oeTipoPago)
            'Cargar Servicios Venta 
            ' @0002 INI *******************************************************************************************************
            'AnioServ = Date.Now.Year
            'oeServCtaCtble = New e_ServicioCuentaContable
            'oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = AnioServ
            'leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)
            mt_ConsultarServicios(Date.Now.Year)
            ' @0002 FIN ********************************************************************************************************
            'Cargar Asiento Modelo
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
            'Cargar Cuenta Ctable
            oeCtaCtable = New e_CuentaContable
            oeCtaCtable.TipoOperacion = "N" : oeCtaCtable.Ejercicio = AnioServ : oeCtaCtable.Activo = True
            leCtaCtable = olCtaCtable.Listar(oeCtaCtable)
            oeCtaCtable = New e_CuentaContable
            oeCtaCtable.Equivale = 0 : oeCtaCtable.Cuenta = gCC16531
            If leCtaCtable.Contains(oeCtaCtable) Then
                oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
            End If

            'Cargar Series Permitidas
            loConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "22" 'prefijo de serie
            oeConcepto.Valor1 = gUsuarioSGI.Id
            loConcepto = olConcepto.Listar(oeConcepto)

            'Cargar Tipo Bien
            oeTipoBien = New e_TipoBien
            oeTipoBien.Id = "0" : oeTipoBien.Nombre = "NINGUNO"
            loTipobien = New List(Of e_TipoBien)
            loTipobien.Add(oeTipoBien)
            oeTipoBien = New e_TipoBien
            loTipobien.AddRange(olTipoBien.Listar(oeTipoBien))
            For Each item In loTipobien
                item.Nombre = item.Codigo + " - " + item.Nombre
            Next
            LlenarCombo(cboTipoBien, "Nombre", loTipobien, 0)
            cboTipoBien.Value = "1SI000000027"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarListados(ByVal leDocumentos As List(Of e_MovimientoDocumento))
        Try
            With griListaFacturaCompra
                .ResetDisplayLayout()
                .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                .DataSource = leDocumentos.OrderBy(Function(i) i.Serie).ToList
                CreaCombo_griFactura()
                OcultarColumna(griListaFacturaCompra, True, "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "MontoOperar", "Retencion", "IndAnexo", "CodMotivo", "MontoCanje")
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Header.Caption.Contains("Id") AndAlso _
                    Col.Header.Caption <> "IdMoneda" AndAlso _
                    Col.Header.Caption <> "IdEstadoDocumento" AndAlso _
                    Col.Header.Caption <> "IdTipoDocumento" Then Col.Hidden = True
                Next
                .DisplayLayout.Bands(0).Columns("NombreDocumento").Hidden = True
                .DisplayLayout.Bands(0).Columns("MontoOperar").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndCompraVenta").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("AbreviaturaMoneda").Hidden = True
                .DisplayLayout.Bands(0).Columns("Moneda").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoPago").Hidden = True
                .DisplayLayout.Bands(0).Columns("EstadoDocumento").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Percepcion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndServicioMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndDetraccion").Hidden = True
                '.DisplayLayout.Bands(0).Columns("Serie").SortIndicator = SortOrder.Ascending

                .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Serie").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("DiasVen").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("NombreProveedor").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("IdMoneda").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("TipoCambio").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("SubTotal").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("IGV").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Monto_Anticipo").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("Neto").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("IdEstadoDocumento").Header.VisiblePosition = 17

                .DisplayLayout.Bands(0).Columns("Serie").Width = 40
                .DisplayLayout.Bands(0).Columns("Numero").Width = 75
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 70
                .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 30
                .DisplayLayout.Bands(0).Columns("NombreProveedor").Width = 200
                .DisplayLayout.Bands(0).Columns("IdMoneda").Width = 30

                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fec. Emision"
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.Caption = "Fec. Venc."
                .DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
                .DisplayLayout.Bands(0).Columns("NombreProveedor").Header.Caption = "Cliente"
                .DisplayLayout.Bands(0).Columns("IdMoneda").Header.Caption = "Mon"
                .DisplayLayout.Bands(0).Columns("IdEstadoDocumento").Header.Caption = "Estado"
                .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Header.Caption = "Tipo Doc."
                .DisplayLayout.Bands(0).Columns("Monto_Anticipo").Header.Caption = "Anticipo"

                .DisplayLayout.Bands(0).Columns("IGV").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("SubTotal").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Total").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Neto").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("IGV").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("SubTotal").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("SaldoDetraccion").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Neto").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Monto_Anticipo").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("SubTotal").Format = "##,###,###0.0000"
                .DisplayLayout.Bands(0).Columns("Total").Format = "##,###,###0.0000"
                .DisplayLayout.Bands(0).Columns("Saldo").Format = "##,###,###0.0000"
                .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Format = "##,###,###0.0000"
                .DisplayLayout.Bands(0).Columns("Neto").Format = "##,###,###0.0000"
                .DisplayLayout.Bands(0).Columns("Monto_Anticipo").Format = "##,###,###0.00"

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1

                .Font = New System.Drawing.Font("Tahoma", 8.25!)

                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With

            CalcularTotales(griListaFacturaCompra, "Saldo")

            'Colorea la grilla de acuerdo a los estados
            For Each fila As UltraGridRow In griListaFacturaCompra.Rows
                Select Case fila.Cells("IdEstadoDocumento").Value
                    Case "1CH00014"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "1CH00008"
                        fila.CellAppearance.BackColor = Me.ColoresEmitido.Color
                    Case Else
                        fila.CellAppearance.BackColor = Me.ColoresAnulado.Color
                End Select
            Next
            With griListaFacturaCompra
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Emitir()
        Try
            IdCtaCtableAux = String.Empty
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")
            Dim _banEmis As Boolean = True
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Oper = "Generar" Then
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.Id = "" : oeMovimientoDocumento.IdTipoDocumento = cboTipoDocumento.Value
                    oeMovimientoDocumento.Serie = txtSerieM.Text.Trim : oeMovimientoDocumento.Numero = txtNumeroM.Text.Trim
                    oeMovimientoDocumento.IndCompraVenta = 2 : oeMovimientoDocumento.CargarCompleto = False
                    oeMovimientoDocumento = olMovimientoDocumento.ObtenerVenta(oeMovimientoDocumento)
                End If
                If oeMovimientoDocumento.lstDetalleDocumento.Count = 0 Then Throw New Exception("No se Puede Emitir el Documento de Venta sin Detalles")
                If oeMovimientoDocumento.FechaEmision.Year <> frm.Año1.Año Then Throw New Exception("Los años no son iguales, No se puede Emitir")
                If oeMovimientoDocumento.FechaEmision.Month <> CInt(frm.cboMes.Text) Then Throw New Exception("El mes de emision es diferente al Periodo,No se puede Emitir")
                oeMovimientoDocumento.IdPeriodo = frm.cboMes.Value : oeMovimientoDocumento.Ejercicio = frm.Año1.Año
                oeMovimientoDocumento.Venta.TipoDoc = oeTipoDoc : oeMovimientoDocumento.Venta.Cliente = oeCliente : oeMovimientoDocumento.Venta.Moneda = oeMonedaDoc
                'Obtiene Asiento Modelo por Moneda
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.Equivale = 1 : oeAsientoModel.IdMoneda = oeMonedaDoc.Id

                If oeMovimientoDocumento.lstDetalleDocumento.Count > 0 Then
                    oeDetalleDocumento = New e_DetalleDocumento
                    oeDetalleDocumento = oeMovimientoDocumento.lstDetalleDocumento(0)
                End If

                ' @0002 INI ******************************************************************************************
                If AnioServ <> oeMovimientoDocumento.FechaEmision.Year Then
                    mt_ConsultarServicios(oeMovimientoDocumento.FechaEmision.Year)
                End If
                ' @0002 FIN ******************************************************************************************

                oeServCtaCtble = New e_ServicioCuentaContable
                oeServCtaCtble.IdServicio = oeDetalleDocumento.NombreMaterialServicio : oeServCtaCtble.Equivale = 1
                If leServCtaCtble.Contains(oeServCtaCtble) Then
                    oeServCtaCtble = leServCtaCtble.Item(leServCtaCtble.IndexOf(oeServCtaCtble))
                Else
                    Throw New Exception("No Existen Cuenta Contable para el Servicio: " & oeDetalleDocumento.NombreMaterialServicio & " para el Año: " & AnioServ & _
                                        Environment.NewLine & "Solicite el Apoyo del Area Contable.")
                End If

                'Obtiene Servicio Cuenta Contable
                If AnioServ <> frm.Año1.Año Then
                    'AnioServ = frm.Año1.Año
                    'oeServCtaCtble = New e_ServicioCuentaContable
                    'oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = AnioServ
                    'leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)
                    oeCtaCtable = New e_CuentaContable
                    oeCtaCtable.TipoOperacion = "N" : oeCtaCtable.Ejercicio = AnioServ : oeCtaCtable.Activo = True
                    leCtaCtable = olCtaCtable.Listar(oeCtaCtable)
                    oeCtaCtable = New e_CuentaContable
                    oeCtaCtable.Equivale = 0 : oeCtaCtable.Cuenta = gCC16531
                    If leCtaCtable.Contains(oeCtaCtable) Then
                        oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
                    End If
                End If

                If leAsientoModel.Contains(oeAsientoModel) Then
                    Dim oeCtaCtbleAux As New e_CuentaContable
                    Dim olCtaCtbleAux As New l_CuentaContable
                    oeCtaCtbleAux.Id = oeDetalleDocumento.IdCuentaContableDebe
                    If Microsoft.VisualBasic.Left(olCtaCtbleAux.Obtener(oeCtaCtbleAux).Cuenta.Trim, 2) <> "12" Then
                        oeAsientoModel = leAsientoModel.Where(Function(x) x.IdMoneda = oeAsientoModel.IdMoneda And Not x.Nombre.Contains("ESTIBA")).ToList.Item(0)
                    Else
                        oeAsientoModel = leAsientoModel.Where(Function(x) x.IdMoneda = oeAsientoModel.IdMoneda And x.Nombre.Contains("ESTIBA")).ToList.Item(0)
                    End If
                    'oeAsientoModel = leAsientoModel.Item(leAsientoModel.IndexOf(oeAsientoModel))
                    oeAsientoModel.TipoOperacion = ""
                    oeAsientoModel.Ejercicio = oeMovimientoDocumento.FechaEmision.Year
                    oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                    If oeCliente.IndRelacionada = 1 Then
                        For Each _oeDet In oeAsientoModel.leDetalle
                            If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "16" Then
                                Dim strCuenta As String = Replace(_oeDet.Cuenta, "6", "7", 1, 1)
                                Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 3) & "1" & Microsoft.VisualBasic.Right(strCuenta, 1)
                                _oeDet.Cuenta = strNuevaCuenta
                                oeCtaCtable = New e_CuentaContable
                                oeCtaCtable.Cuenta = strNuevaCuenta : oeCtaCtable.Equivale = 0
                                If leCtaCtable.Contains(oeCtaCtable) Then
                                    oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
                                    _oeDet.IdCuentaContable = oeCtaCtable.Id
                                End If
                            End If

                            If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "12" Then
                                Dim strCuenta As String = Replace(_oeDet.Cuenta, "2", "3", 1, 1)
                                Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 3) & "33" & Microsoft.VisualBasic.Right(strCuenta, 1)
                                _oeDet.Cuenta = strNuevaCuenta
                                oeCtaCtable = New e_CuentaContable
                                oeCtaCtable.Cuenta = strNuevaCuenta : oeCtaCtable.Equivale = 0
                                If leCtaCtable.Contains(oeCtaCtable) Then
                                    oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
                                    _oeDet.IdCuentaContable = oeCtaCtable.Id
                                End If
                            End If
                        Next
                    End If
                Else
                    Throw New Exception("No Existe Configuracion Contable")
                End If

                If oeCliente.IndRelacionada = 1 Then
                    Dim strCta As String = Replace(gCC16531, "6", "7", 1, 1)
                    Dim strNewCta As String = Microsoft.VisualBasic.Left(strCta, 3) & "3" & Microsoft.VisualBasic.Right(strCta, 1)
                    oeCtaCtable = New e_CuentaContable
                    oeCtaCtable.Equivale = 0 : oeCtaCtable.Cuenta = strNewCta
                    If leCtaCtable.Contains(oeCtaCtable) Then
                        oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
                    End If
                End If
                'If oeMovimientoDocumento.lstDetalleDocumento.Count > 0 Then
                '    oeDetalleDocumento = New e_DetalleDocumento
                '    oeDetalleDocumento = oeMovimientoDocumento.lstDetalleDocumento(0)
                'End If
                'oeServCtaCtble = New e_ServicioCuentaContable
                'oeServCtaCtble.IdServicio = oeDetalleDocumento.NombreMaterialServicio : oeServCtaCtble.Equivale = 1
                'If leServCtaCtble.Contains(oeServCtaCtble) Then
                '    oeServCtaCtble = leServCtaCtble.Item(leServCtaCtble.IndexOf(oeServCtaCtble))
                'Else
                '    Throw New Exception("No Existen Cuenta Contable para el Servicio: " & gVSTransporte & " para el Año: " & AnioServ & _
                '                        Environment.NewLine & "Solicite el Apoyo del Area Contable.")
                'End If
                If oeDetalleDocumento.NombreMaterialServicio.Trim = gVSTracto.Trim Then IdCtaCtableAux = oeCtaCtable.Id
                'Valida CuentaCorriente
                oeCuentaCorriente = New e_CuentaCorriente
                oeCuentaCorriente.Tipo = 3 : oeCuentaCorriente.IdTrabajador = oeMovimientoDocumento.IdClienteProveedor
                oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
                oeMovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                If oeMovimientoDocumento.IndAfectaAnticipo Then
                    oeDocAsoc = New e_DocumentoAsociado
                    oeDocAsoc.TipoOperacion = "T"
                    oeDocAsoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                    oeDocAsoc.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeMovimientoDocumento.DocAsoc = olDocAsoc.Listar(oeDocAsoc)
                End If
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                If oeCuentaCorriente.Id <> "" Then
                    _banEmis = olMovimientoDocumento.GuardarVentaAsiento(oeMovimientoDocumento, oeAsientoModel, oeServCtaCtble, True, IdCtaCtableAux, oeMovimientoDocumento.IndAfectaAnticipo)
                Else
                    With oeCuentaCorriente
                        .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = oeMovimientoDocumento.IdClienteProveedor
                        .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = frm.Año1.Año : .Usuario = gUsuarioSGI.Id
                        .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA"
                    End With
                    oeCuentaCorriente.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olCuentaCorriente.Guardar(oeCuentaCorriente)
                    _banEmis = olMovimientoDocumento.GuardarVentaAsiento(oeMovimientoDocumento, oeAsientoModel, oeServCtaCtble, True, IdCtaCtableAux, oeMovimientoDocumento.IndAfectaAnticipo)
                End If
                If _banEmis = True Then
                    mensajeEmergente.Confirmacion("El Documento Nº " & oeMovimientoDocumento.Serie & " - " & oeMovimientoDocumento.Numero & _
                      " ha sido Emitida", True)
                    'Dim WCF_Cpe As New WCF_CpeIndu.WCF_CpeClient("Indu_IWCF_Cpe") '@0001
                    Dim dsComprobante As DataSet
                    'Dim dt_cpe As DataTable '@0001
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.TipoOperacion = "DT"
                    oeMovimientoDocumento._Operador = 1
                    oeMovimientoDocumento.Abrev_Empresa = Abrev_Empresa
                    oeMovimientoDocumento.Id = griListaFacturaCompra.ActiveRow.Cells("Id").Value
                    dsComprobante = olMovimientoDocumento.ListaFacturacionElectronica(oeMovimientoDocumento)
                    'dt_cpe = Deserializar_XmlStr(WCF_Cpe.GenerarXML_CPE(dsComprobante, Date.Now, dsComprobante.Tables(0).Rows(0).Item("cod_comprob_cat_1").ToString().Trim(), RutaArchivos, Abrev_Empresa, Nothing, Nothing)) '@0001
                    'olDocumento.GenerarXmlFacturaElectronica_Emision(dsComprobante.Tables(0), dsComprobante.Tables(1), frm_DocumentoElectronico.RutaArchivos, gUsuarioEOS.Id) '@0001
                    '--olMovimientoDocumento.GenerarXmlFacturaElectronica(dsComprobante.Tables(0), dsComprobante.Tables(1), RutaArchivos, gUsuarioSGI.Id) '@0001
                    'Registro_ComprobanteElectronico_Bath(dt_cpe, "I", dsComprobante.Tables(0).Rows(0).Item("cod_comprob_cat_1").ToString().Trim(), Nothing) '@0001
                    'Imprimir()
                End If
                If IndEmit Then
                    MostrarTabs(0, ficFacturaCompra, 0)
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTipoPago()
        Try
            cboTipoPago.DataSource = New List(Of e_TipoPago)
            'cboTipoPago.DataSource = leTipoPago
            LlenarCombo(cboTipoPago, "Nombre", leTipoPago, 0)
            cboTipoPago.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarDoc()
        Try
            Dim oeMovDoc As New e_MovimientoDocumento
            With oeMovDoc
                .TipoOperacion = "FAC"
                .Activo = True
                .IndCompraVenta = 2
                .IndServicioMaterial = "M"
                .Serie = FormatoDocumento(txtSerieDoc.Text, 4)
                '.Numero = FormatoDocumento(txtNumeroDoc.Text, 10) '@0001
                .Numero = FormatoDocumento(txtNumeroDoc.Text, 8)
            End With
            griListaDocumentoVenta.DataSource = olMovimientoDocumento.Listar(oeMovDoc)
            griListaDocumentoVenta.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDetalleDoc(IdDocumento As String)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim oeMovDoc As e_MovimientoDocumento
            Dim Glosa As String = "" : Dim Producto As String = "" : Dim Ruta As String = ""
            Dim Viaje As String = "" : Dim Placa As String = "" : Dim Carreta As String = ""
            Dim GRT As String = "" : Dim GRR As String = ""
            Dim oeDetDocOpe As New e_DetalleDoc_OperacionDet
            Dim loDetDocOpe As New List(Of e_DetalleDoc_OperacionDet)
            oeMovDoc = New e_MovimientoDocumento
            oeMovDoc.Id = IdDocumento
            oeMovDoc = olMovimientoDocumento.ObtenerVenta(oeMovDoc)
            cboCliente.Focus()
            cboCliente.Value = oeMovDoc.IdClienteProveedor
            cboDireccion.Focus()
            loDetDocOpe = oeMovDoc.leDetalleDocOperDet
            For Each oe In oeMovDoc.leGRT
                GRT = GRT + CStr(CInt(oe.Serie)) + "-" + CStr(CInt(oe.Numero)) + "/"
            Next
            For Each oe In oeMovDoc.leGRR
                GRR = GRR + CStr(CInt(oe.Serie)) + "-" + CStr(CInt(oe.Numero)) + "/"
            Next
            If loDetDocOpe.Count > 0 Then
                Producto = Producto + loDetDocOpe(0).MaterialServicio
                Ruta = loDetDocOpe(0).Origen + "-" + loDetDocOpe(0).Destino
                Viaje = Strings.Left(loDetDocOpe(0).NroViaje, 2) + CStr(CInt(Strings.Right(loDetDocOpe(0).NroViaje, 13)))
                Placa = loDetDocOpe(0).Tracto
                Carreta = loDetDocOpe(0).Carreta
                Glosa = "SERVICIO DE GASTOS DE DESESTIBA"
                Glosa = Glosa & Environment.NewLine
                Glosa = Glosa & Environment.NewLine + "PRODUCTO: " + Producto
                Glosa = Glosa & Environment.NewLine + "RUTA: " + Ruta
                Glosa = Glosa & Environment.NewLine
                Glosa = Glosa & Environment.NewLine + Viaje + "  " + Placa + "//" + Carreta + ", GRT: " + GRT.Replace("/", "").Trim + ", GRR: " + GRR.Replace("/", "").Trim
            End If
            txtGlosa.Text = Glosa
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub mt_ConsultarServicios(nEjercicio As Integer)
        'Cargar Servicios Venta
        AnioServ = nEjercicio
        oeServCtaCtble = New e_ServicioCuentaContable
        oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = AnioServ
        leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griListaFacturaCompra.ContextMenuStrip = MenuContextual2
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiActualizar.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub AnularToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAnular.Click
        AnularFactura()
    End Sub

    Private Sub tsmiEmitir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEmitir.Click
        Oper = "Emitir"
        InicializarControles()
        IdDocumento = griListaFacturaCompra.ActiveRow.Cells("Id").Value.ToString
        If EditarFacturaCompra() Then
            oeMovimientoDocumento.TipoOperacion = "A"
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
            MostrarTabs(1, ficFacturaCompra, 1)
            gbeListadoMatSer.Expanded = False
            Operacion = "Editar"
        End If
    End Sub

    Private Sub tsmiDescargarPDF_Click(sender As Object, e As EventArgs) Handles tsmiDescargarPDF.Click
        Try
            If griListaFacturaCompra.ActiveRow.Cells("IndElectronico").Value = 0 Then Throw New Exception("Documento debe ser Electrónico.")

            'If griDocumentoVenta.ActiveRow.Cells("Estado").Value = "Anulado" Then Throw New Exception("Documento esta Anulado.")

            Dim frmImpresion As New frm_FacturaBoletaElectronico
            frmImpresion.mt_CargarDatos(griListaFacturaCompra.ActiveRow.Cells("Id").Value, False)
            frmImpresion.StartPosition = FormStartPosition.CenterScreen
            frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            frmImpresion.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub tsmiDescargarXML_Click(sender As Object, e As EventArgs) Handles tsmiDescargarXML.Click
        Try
            Dim RutaArchivos As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("DocElectronico") & "\Facturacion\"
            'Dim RutaArchivos As String = Path.Combine(Application.StartupPath, "ComprobanteElectronico") & "\Facturacion\" '@0001
            Dim sNombreArchivo As String = ""
            Dim TipoDocumento As String = ""
            Dim SerieDes As String = ""
            Dim NumeroDes As String = ""
            If griListaFacturaCompra.ActiveRow.Cells("EstadoSunat").Value <> "ACEPTADA" Then Throw New Exception("Para Descargar XML, Documento debe ser Aceptada por Sunat.")

            FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                sNombreArchivo = FolderBrowserDialog1.SelectedPath
            Else
                FolderBrowserDialog1.Dispose()
                Return
            End If

            If sNombreArchivo <> "" Then
                TipoDocumento = griListaFacturaCompra.ActiveRow.Cells("IdTipoDocumento").Value
                If TipoDocumento = "1CH000000026" Then TipoDocumento = "01"
                If TipoDocumento = "1CH000000002" Then TipoDocumento = "03"
                If TipoDocumento = "1CH000000033" Then TipoDocumento = "08"
                If TipoDocumento = "1CH000000030" Then TipoDocumento = "07"

                SerieDes = griListaFacturaCompra.ActiveRow.Cells("Serie").Value
                NumeroDes = griListaFacturaCompra.ActiveRow.Cells("Numero").Value.ToString.Substring(2, 8)

                RutaArchivos = RutaArchivos + gs_RucEmpresaSistema.Trim + "-" + TipoDocumento + "-" + SerieDes + "-" + NumeroDes + ".zip"
                sNombreArchivo = sNombreArchivo + "\" + gs_RucEmpresaSistema.Trim + "-" + TipoDocumento + "-" + SerieDes + "-" + NumeroDes + ".zip"
                My.Computer.FileSystem.CopyFile(RutaArchivos, sNombreArchivo, True)
                mensajeEmergente.Confirmacion("Se copio archivo correctamente", True)
            End If


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuContextual2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual2.Opening
        MenuContextual2.Items("tsmiNuevo").Visible = True
        MenuContextual2.Items("tsmiEliminar").Visible = False
        MenuContextual2.Items("tsmiActualizar").Visible = False
        MenuContextual2.Items("tsmiEmitir").Visible = False
        MenuContextual2.Items("tsmiAnular").Visible = False
        If griListaFacturaCompra.Selected.Rows.Count > 0 Then
            Select Case griListaFacturaCompra.ActiveRow.Cells("IdEstadoDocumento").Value
                Case "1CH00014"
                    MenuContextual2.Items("tsmiEliminar").Visible = True
                    MenuContextual2.Items("tsmiActualizar").Visible = True
                    MenuContextual2.Items("tsmiEmitir").Visible = True
                Case "1CH00008"
                    MenuContextual2.Items("tsmiAnular").Visible = True
            End Select
        End If

    End Sub

#End Region

#Region "Menu y tabs"

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    If griListaServicios.Rows.Where(Function(x) x.Cells("Seleccion").Value = True).Count > 1 Then Throw New Exception("Solo se puede Adicionar un Solo Detalle.")
                    AgregarDetalle()
                Case "Eliminar"
                    QuitarDetalle()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

    Private Sub cboTipoBien_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoBien.ValueChanged
        Dim oetipobien2 As New e_TipoBien
        oetipobien2 = cboTipoBien.Items(cboTipoBien.SelectedIndex).ListObject
        DecDetraer.Value = oetipobien2.Porcentaje

        'If DecDetraer.Value > 0 Then
        '    DecMontoDetraccion.Value = Me.txtTotal.Value * (DecDetraer.Value / 100)
        '    oeMovimientoDocumento.Venta.PorcenDetra = DecDetraer.Value
        'Else
        '    oeMovimientoDocumento.Venta.PorcenDetra = 0
        '    DecMontoDetraccion.Value = 0
        'End If
    End Sub

    Private Sub cbAnticipo_CheckedChanged(sender As Object, e As EventArgs) Handles cbAnticipo.CheckedChanged
        Try
            Cargar_Anticipos_Check()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Cargar_Anticipos_Check()
        If cbAnticipo.Checked Then
            If cboCliente.Value Is String.Empty Or cboCliente.Value Is DBNull.Value Or cboCliente.Value Is Nothing Then cbAnticipo.Checked = False : decAnticipo.Value = 0.0 : Throw New Exception("Debe seleccionar cliente.")
            If griListaDetalleFactura.Rows.Count = 0 Then cbAnticipo.Checked = False : decAnticipo.Value = 0.0 : Throw New Exception("Debe agregar detalles de servicio antes de aplicar el anticipo.")
            If lstDetalleDocumento.Where(Function(x) x.NombreMaterialServicio.IndexOf("ANTICIPO") <> -1).Count > 0 Then cbAnticipo.Checked = False : decAnticipo.Value = 0.0 : Throw New Exception("No se puede aplicar el anticipo a un Servicio de Anticipo.")
            griAnticipos.Visible = True
            b_anticipo = True
            oeAnticipo = New e_MovimientoDocumento
            oeAnticipo.IdClienteProveedor = cboCliente.Value
            oeAnticipo.Id = oeMovimientoDocumento.Id
            oeAnticipo.NombreDocumento = ""
            oeAnticipo.IdEstadoDocumento = ""
            lstAnticipo = New List(Of e_MovimientoDocumento)
            If Oper = "Emitir" Then
                oeAnticipo.TipoOperacion = "FAT"
            Else
                oeAnticipo.TipoOperacion = "FAS"
            End If
            CargarAnticipos(olAnticipo.Listar_Anticipos(oeAnticipo))
        Else
            griAnticipos.Visible = False
            b_anticipo = False
            decAnticipo.Value = 0.0
        End If
        CalcularSubtotalesTotalesMaterial()
    End Sub

    Private Sub CargarAnticipos(dt As DataTable)
        Try
            With griAnticipos
                .ResetDisplayLayout()
                .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                .DataSource = dt
                For Each col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If col.Key = "Seleccionar" Then
                        col.CellActivation = Activation.AllowEdit
                        col.CellClickAction = CellClickAction.Edit
                        col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                    ElseIf col.Key = "MontoOperar" Then
                        col.CellActivation = Activation.AllowEdit
                        col.CellClickAction = CellClickAction.EditAndSelectText
                    Else
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next
                OcultarColumna(griAnticipos, True, "Id", "IGV", "SubTotal", "IdMoneda")

                .DisplayLayout.Bands(0).Columns("Seleccionar").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Serie").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("ClienteProveedor").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Moneda").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("MontoOperar").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("MontoOriginal").Header.VisiblePosition = 10


                .DisplayLayout.Bands(0).Columns("Serie").Width = 40
                .DisplayLayout.Bands(0).Columns("Numero").Width = 75
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                .DisplayLayout.Bands(0).Columns("ClienteProveedor").Width = 200

                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fec. Emisión"
                .DisplayLayout.Bands(0).Columns("Moneda").Header.Caption = "MON."
                .DisplayLayout.Bands(0).Columns("ClienteProveedor").Header.Caption = "Cliente"
                .DisplayLayout.Bands(0).Columns("Seleccionar").Header.Caption = ""
                .DisplayLayout.Bands(0).Columns("MontoOriginal").Header.Caption = "Monto Desc."
               

                .DisplayLayout.Bands(0).Columns("Total").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("MontoOperar").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("MontoOriginal").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("MontoOperar").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("MontoOriginal").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("Total").Format = "##,###,###0.00"
                .DisplayLayout.Bands(0).Columns("Saldo").Format = "##,###,###0.00"
                .DisplayLayout.Bands(0).Columns("MontoOperar").Format = "##,###,###0.00"
                .DisplayLayout.Bands(0).Columns("MontoOriginal").Format = "##,###,###0.00"

                .Font = New System.Drawing.Font("Tahoma", 8.25!)

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                
            End With

            CalcularTotales(griAnticipos, "Saldo")


            With griAnticipos
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griAnticipos_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griAnticipos.AfterCellUpdate
        If cbAnticipo.Checked Then
            Select Case e.Cell.Column.Key
                Case "Seleccionar", "MontoOperar"
                    decAnticipo.Value = Calcular_Monto_Anticipo()
                    CalcularSubtotalesTotalesMaterial()
            End Select
        End If
    End Sub

    Private Sub griAnticipos_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griAnticipos.BeforeCellUpdate
        If cbAnticipo.Checked Then
            With griAnticipos
                Select Case e.Cell.Column.Key
                    Case "MontoOperar"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        cantmat = e.Cell.Value

                End Select
            End With
        End If
    End Sub

    Private Sub griAnticipos_CellChange(sender As Object, e As CellEventArgs) Handles griAnticipos.CellChange
        Try
            griAnticipos.UpdateData()
            If cbAnticipo.Checked Then
                If e.Cell.Column.Key = "Seleccionar" Then
                    If e.Cell.Value = False Then
                        griAnticipos.Rows(e.Cell.Row.Index).Cells("MontoOperar").Value = griAnticipos.Rows(e.Cell.Row.Index).Cells("Saldo").Value
                        griAnticipos.Rows(e.Cell.Row.Index).Cells("MontoOriginal").Value = griAnticipos.Rows(e.Cell.Row.Index).Cells("Saldo").Value
                    End If
                ElseIf e.Cell.Column.Key = "MontoOperar" Then
                    If e.Cell.Value > griAnticipos.Rows(e.Cell.Row.Index).Cells("Saldo").Value Then
                        mensajeEmergente.Problema("El Monto aplicar no debe ser mayor que el saldo.", True)
                        e.Cell.Value = griAnticipos.Rows(e.Cell.Row.Index).Cells("Saldo").Value
                    End If
                    RecalcularMontosOrig_Anticipos()
                End If
                decAnticipo.Value = Calcular_Monto_Anticipo()
                CalcularSubtotalesTotalesMaterial()
            End If
            griAnticipos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function Calcular_Monto_Anticipo() As Double
        Dim anticipo As Double = 0.0
        For Each antic In griAnticipos.Rows.Where(Function(x) x.Cells("Seleccionar").Value = True)
            anticipo += CType(antic.Cells("MontoOriginal").Value, Double)
        Next
        Return Math.Round(anticipo, 2)
    End Function

    Private Sub RecalcularMontosOrig_Anticipos()
        For Each antic In griAnticipos.Rows
            If cboMoneda.Value = "1CH01" Then
                If antic.Cells("IdMoneda").Value = "1CH01" Then
                    antic.Cells("MontoOriginal").Value = Math.Round(antic.Cells("MontoOperar").Value, 2)
                Else
                    antic.Cells("MontoOriginal").Value = Math.Round(antic.Cells("MontoOperar").Value * decTc.Value, 2)
                End If
            Else
                If antic.Cells("IdMoneda").Value = "1CH01" Then
                    antic.Cells("MontoOriginal").Value = Math.Round(antic.Cells("MontoOperar").Value / decTc.Value, 2)
                Else
                    antic.Cells("MontoOriginal").Value = Math.Round(antic.Cells("MontoOperar").Value, 2)
                End If
            End If
        Next
        decAnticipo.Value = Calcular_Monto_Anticipo()
        CalcularSubtotalesTotalesMaterial()
    End Sub
End Class