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

Public Class frm_NotaCreditoDebito
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_NotaCreditoDebito = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_NotaCreditoDebito
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeMovDocumento As New e_MovimientoDocumento
    Private oeCliente As New e_Cliente, olCliente As New l_Cliente, leCliente As New List(Of e_Cliente)
    Private oeNotaCreditoDebito As New e_MovimientoDocumento, olNotaCreditoDebito As New l_MovimientoDocumento
    Private leDetalle As New List(Of e_DetalleDocumento), olDetalle As New l_DetalleDocumento, oeDetalle As New e_DetalleDocumento
    Private oeDocAso As New e_MovimientoDocumento
    Private oeTipoDoc As New e_TipoDocumento, olTipoDoc As New l_TipoDocumento, leTipoDocBus As New List(Of e_TipoDocumento)
    Private leTipoDocAso As New List(Of e_TipoDocumento), leTipoDoc As New List(Of e_TipoDocumento)
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda, leMoneda As New List(Of e_Moneda)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeIGV As New e_Impuesto, olIGV As New l_Impuesto
    Private oeServCtaCtble As New e_ServicioCuentaContable, olServCtaCtble As New l_ServicioCuentaContable, leServCtaCtble As New List(Of e_ServicioCuentaContable)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeReferencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    Private oeCuentaCorriente As New e_CuentaCorriente, olCuentaCorriente As New l_CuentaCorriente
    Private oeCtaCtable As New e_CuentaContable, olCtaCtable As New l_CuentaContable, leCtaCtable As New List(Of e_CuentaContable)
    Dim band As Boolean = True
    Dim _ingresando_datos As Boolean = False, chkEmitir As Boolean = False
    Private AnioServ As Integer = 0
    Private IdCtaCtableAux As String = String.Empty
    Private DTReferencia As Data.DataTable, dtAux As Data.DataTable
    Private oeCombo As New e_Combo '@0001
    Dim loConcepto As New l_Concepto
    Dim oeConcepto As New e_Concepto
    Dim ListaMotivoNC As New List(Of e_Concepto)
    Dim ListaMotivoND As New List(Of e_Concepto)
    Dim ListaSeriePermitidas As New List(Of e_Concepto)

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griNotaCreditoDebito.Rows.Count > 0 Then
                ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MostrarTabs(1, ficNotaCreditoDebito, 1)
        Inicializar()
        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
        oeNotaCreditoDebito.TipoOperacion = "I"
        oeNotaCreditoDebito.Modificado = False
        cboTipoDocAso.Focus()
        Operacion = "Nuevo"
        ' MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        MyBase.Editar()
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                'MyBase.Guardar()
            Else
                MostrarTabs(1, ficNotaCreditoDebito, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeNotaCreditoDebito.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficNotaCreditoDebito, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficNotaCreditoDebito, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficNotaCreditoDebito, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficNotaCreditoDebito, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griNotaCreditoDebito.Rows.Count = 0 Then Throw New Exception("No hay ninguna Nota de Crédito/Débito para exportar al Excel")
            Exportar_Excel(griNotaCreditoDebito)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            Dim Id As String = ""
            Dim IndElectronico As Boolean = False

            If griNotaCreditoDebito.Selected.Rows.Count = 1 Then
                With griNotaCreditoDebito
                    Id = .ActiveRow.Cells("Id").Value
                    IndElectronico = .ActiveRow.Cells("IndElectronico").Value
                    If IndElectronico Then
                        Dim frmImpresion As New frm_FacturaBoletaElectronico
                        frmImpresion.mt_CargarDatos(Id, True, "")
                        frmImpresion.StartPosition = FormStartPosition.CenterScreen
                        frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                        frmImpresion.ShowDialog()
                    End If
                End With
            End If

            gtm_Imprimir_Documento(Id, "NCTICKET", "OV")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
       
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_NotaCreditoDebito_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                If griNotaCreditoDebito.Rows.Count > 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_NotaCreditoDebito_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_NotaCreditoDebito_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton()
    End Sub

    Private Sub frm_NotaCreditoDebito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, txtNumeroAso.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            fecDesde.Value = Date.Now.Date.AddDays(-5)
            fecHasta.Value = Date.Now.Date
            CargarCombos()
            CargarNotasCD(New List(Of e_MovimientoDocumento))
            band = False
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficNotaCreditoDebito)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkElectronico_CheckedChanged(sender As Object, e As EventArgs) Handles chkElectronico.CheckedChanged
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
    End Sub

    Private Sub txtSerieBus_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerieBus.KeyPress
        'TextoNumero(e)
    End Sub

    Private Sub txtNumeroBus_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroBus.KeyPress
        TextoNumero(e)
    End Sub

    Private Sub txtSerieAso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerieAso.KeyPress
        'TextoNumero(e)
    End Sub

    Private Sub txtNumeroAso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroAso.KeyPress
        TextoNumero(e)
    End Sub

    Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        'TextoNumero(e)
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        TextoNumero(e)
    End Sub

    Private Sub txtSerieBus_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieBus.Validated
        'FormateaTexto(txtSerieBus, 4)
    End Sub

    Private Sub txtNumeroBus_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroBus.Validated
        'FormateaTexto(txtNumeroBus, 10) '@0001
        FormateaTexto(txtNumeroBus, 8)
    End Sub

    Private Sub txtSerieAso_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieAso.Validated
        'FormateaTexto(txtSerieAso, 4)
    End Sub

    Private Sub txtNumeroAso_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroAso.Validated
        'FormateaTexto(txtNumeroAso, 10) '@0001
        FormateaTexto(txtNumeroAso, 8)
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        Try
            Dim indSeriePermite As Boolean = False
            If txtSerie.Text.Trim <> "" Then

                If chkElectronico.Checked Then
                    txtSerie.Text = FormatoSerieElectronica(txtSerie.Text, IIf(cboTipoDocAso.Value = "1CH000000026", "F", "B"))
                Else
                    txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
                End If

                For Each i In ListaSeriePermitidas
                    If i.Valor2.Trim = txtSerie.Text.Trim Then
                        indSeriePermite = True
                        Exit For
                    End If
                Next
                If indSeriePermite = False Then
                    txtSerie.Text = String.Empty
                    Throw New Exception("Serie no permitida para el usuario.")
                End If

                Dim oe As New e_MovimientoDocumento
                oe.TipoOperacion = "NUM"
                oe.Serie = txtSerie.Text.Trim
                oe.IdTipoDocumento = cboTipoDoc.Value
                oe.IndCompraVenta = 2
                txtNumero.Text = olNotaCreditoDebito.ObtenerNumDoc(oe).Numero
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        'FormateaTexto(txtNumero, 10) ' @0001
        FormateaTexto(txtNumero, 8)
    End Sub

    Private Sub decSubTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decSubTotal.ValueChanged
        If IsDBNull(decSubTotal.Value) Then decSubTotal.Value = 0
        decIgv.Value = Math.Round(decSubTotal.Value * oeIGV.Porcentaje, 2)
        CalcularTotal()
        oeNotaCreditoDebito.SubTotal = decSubTotal.Value
    End Sub

    Private Sub decIgv_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decIgv.ValueChanged
        If IsDBNull(decIgv.Value) Then decIgv.Value = 0
        CalcularTotal()
        oeNotaCreditoDebito.IGV = decIgv.Value
    End Sub

    Private Sub fecEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecEmision.ValueChanged
        CalculaTipoCambio(fecEmision.Value)
        oeNotaCreditoDebito.FechaEmision = fecEmision.Value
    End Sub

    Private Sub txtNumeroAso_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumeroAso.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'FormateaTexto(txtNumeroAso, 10) '@0001
                FormateaTexto(txtNumeroAso, 8)
                CargaDocAsociado()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        
    End Sub

    Private Sub btnCargaDocAso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaDocAso.Click
        Try
            CargaDocAsociado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDoc.ValueChanged
        Try
            If cboTipoDoc.SelectedIndex > -1 Then
                If oeDocAso.Id.Trim = String.Empty Then cboTipoDocAso.Focus() : Throw New Exception("Seleccione el Documento Asociado")
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                If oeDocAso.IndServicioMaterial = "M" Then
                    cadSQL = "TipoRef2 = 5 AND IdRef2 = '" & cboTipoDoc.Value & "' AND TipoRef3 = 6 AND Ref3 = '" & gVSTransporte & "'"
                Else
                    cadSQL = "TipoRef2 = 5 AND IdRef2 = '" & cboTipoDoc.Value & "' AND TipoRef3 = 6 AND Ref3 = '" & gVSOtros & "'"
                End If
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("El Tipo Doc: " & cboTipoDoc.Text & ", no tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                If txtSerie.Text.Trim <> "" Then
                    Dim oe As New e_MovimientoDocumento
                    oe.TipoOperacion = "NUM"
                    oe.Serie = txtSerie.Text.Trim
                    oe.IdTipoDocumento = cboTipoDoc.Value
                    txtNumero.Text = olNotaCreditoDebito.ObtenerNumDoc(oe).Numero
                End If
                oeTipoDoc = New e_TipoDocumento
                oeTipoDoc = cboTipoDoc.Items(cboTipoDoc.SelectedIndex).ListObject
                oeNotaCreditoDebito.IdTipoDocumento = oeTipoDoc.Id
                cboTipoMoneda.Value = oeDocAso.IdMoneda
                oeNotaCreditoDebito.IdMoneda = oeDocAso.IdMoneda

                If cboTipoDoc.Value = "1CH000000030" Then
                    cmbMotivoMod.DataSource = ListaMotivoNC
                    cmbMotivoMod.DisplayMember = "Nombre"
                    cmbMotivoMod.ValueMember = "Valor1"
                    cmbMotivoMod.SelectedIndex = 0
                Else
                    cmbMotivoMod.DataSource = ListaMotivoND
                    cmbMotivoMod.DisplayMember = "Nombre"
                    cmbMotivoMod.ValueMember = "Valor1"
                    cmbMotivoMod.SelectedIndex = 0
                End If

                
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.ValueChanged
        If txtSerie.Text <> "" Then oeNotaCreditoDebito.Serie = txtSerie.Text
    End Sub

    Private Sub txtNumero_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.ValueChanged
        If txtNumero.Text <> "" Then oeNotaCreditoDebito.Numero = txtNumero.Text
    End Sub

    Private Sub cboTipoMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoMoneda.ValueChanged
        Try
            oeAsientoModel = New e_AsientoModelo
            oeReferencia = New e_AsientoModelo_Referencia
            If cboTipoMoneda.SelectedIndex > -1 Then
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & cboTipoMoneda.Value & "'"
                _rwAux = dtAux.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("El Tipo Doc: " & cboTipoDoc.Text & " con Tipo Moneda: " & _
                    cboTipoMoneda.Value & ", no tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                oeNotaCreditoDebito.IdMoneda = cboTipoMoneda.Value
                oeMoneda = New e_Moneda
                oeMoneda = cboTipoMoneda.Items(cboTipoMoneda.SelectedIndex).ListObject
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decTipoCambio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTipoCambio.ValueChanged
        If IsDBNull(decTipoCambio.Value) Then decTipoCambio.Value = 0
        oeNotaCreditoDebito.TipoCambio = decTipoCambio.Value
    End Sub

    Private Sub decTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotal.ValueChanged
        If decTotal.Value > 0 Then
            CalcularSubTotal()
        End If
        oeNotaCreditoDebito.Total = decTotal.Value
        oeNotaCreditoDebito.Saldo = decTotal.Value
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeNotaCreditoDebito.Venta.Glosa = txtGlosa.Value + " - Documento: " + cboTipoDocAso.Text + "  Numero:" + txtSerieAso.Text + "-" + txtNumeroAso.Text + "  Fecha:" + dtpFecEmisionAso.Value.Date
    End Sub

    Private Sub decTotal_Leave(sender As Object, e As EventArgs) Handles decTotal.Leave
        If decTotal.Value > 0 Then
            CalcularIgv()
        End If
    End Sub

    Private Sub fecVencimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecVencimiento.ValueChanged
        oeNotaCreditoDebito.FechaVencimiento = fecVencimiento.Value
    End Sub

#End Region

#Region "Métodos"

    Private Sub Emitir(ByVal lsTipoDoc As String, ByVal lsSerie As String, ByVal lsNumero As String)
        Try
            Dim _banEmis As Boolean = True
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")
            Dim IndServ As Boolean = False
            IdCtaCtableAux = String.Empty
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim olMovDocumento As New l_MovimientoDocumento
                oeMovDocumento = New e_MovimientoDocumento
                oeMovDocumento.Id = "" : oeMovDocumento.IdTipoDocumento = lsTipoDoc
                oeMovDocumento.Serie = lsSerie : oeMovDocumento.Numero = lsNumero
                oeMovDocumento.IndCompraVenta = 2 : oeMovDocumento.CargarCompleto = False
                oeMovDocumento = olMovDocumento.ObtenerVenta(oeMovDocumento)
                If oeMovDocumento.lstDetalleDocumento.Count = 0 Then Throw New Exception("No se Puede Emitir el Documento de Venta sin Detalles")
                If oeMovDocumento.FechaEmision.Year <> frm.Año1.Año Then Throw New Exception("Los años no son iguales, No se puede Emitir")
                If oeMovDocumento.FechaEmision.Month <> CInt(frm.cboMes.Text) Then Throw New Exception("El mes de emision es diferente al Periodo,No se puede Emitir")
                oeMovDocumento.IdPeriodo = frm.cboMes.Value : oeMovDocumento.Ejercicio = frm.Año1.Año
                If chkEmitir Then CargarDatosEmitir(oeMovDocumento)
                oeMovDocumento.Venta.TipoDoc = oeTipoDoc : oeMovDocumento.Venta.Cliente = oeCliente : oeMovDocumento.Venta.Moneda = oeMoneda
                'Obtiene Asiento Modelo por Moneda
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = oeMovDocumento.FechaEmision.Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                ' Empresa Relacionada
                If oeCliente.IndRelacionada = 1 Then
                    For Each _oeDet In oeAsientoModel.leDetalle
                        ' Cuentas por Cobrar Comerciales Relacionadas
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
                        ' Otras Cuentas por Cobrar Relacionadas
                        If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "16" Then
                            Dim strCuenta2 As String = Replace(_oeDet.Cuenta, "6", "7", 1, 1)
                            Dim strNuevaCuenta2 As String = Microsoft.VisualBasic.Left(strCuenta2, 3) & "1" & Microsoft.VisualBasic.Right(strCuenta2, 1)
                            _oeDet.Cuenta = strNuevaCuenta2
                            oeCtaCtable = New e_CuentaContable
                            oeCtaCtable.Cuenta = strNuevaCuenta2 : oeCtaCtable.Equivale = 0
                            If leCtaCtable.Contains(oeCtaCtable) Then
                                oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
                                _oeDet.IdCuentaContable = oeCtaCtable.Id
                            End If
                        End If
                    Next
                End If
                'Obtiene Servicio Cuenta Contable
                If AnioServ <> frm.Año1.Año Then
                    AnioServ = frm.Año1.Año
                    oeServCtaCtble = New e_ServicioCuentaContable
                    oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = AnioServ
                    leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)
                    If oeMovDocumento.IndServicioMaterial = "S" Then
                        oeCtaCtable = New e_CuentaContable
                        oeCtaCtable.TipoOperacion = "N" : oeCtaCtable.Ejercicio = AnioServ : oeCtaCtable.Activo = True
                        leCtaCtable = olCtaCtable.Listar(oeCtaCtable)
                        oeCtaCtable = New e_CuentaContable
                        oeCtaCtable.Equivale = 0 : oeCtaCtable.Cuenta = gCC16531
                        If leCtaCtable.Contains(oeCtaCtable) Then
                            oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
                        End If
                    End If
                End If
                ' Cobros por Venta de Inmuebles con Empresas Relacionadas
                If oeCliente.IndRelacionada = 1 Then
                    Dim strCta As String = Replace(gCC16531, "6", "7", 1, 1)
                    Dim strNewCta As String = Microsoft.VisualBasic.Left(strCta, 3) & "3" & Microsoft.VisualBasic.Right(strCta, 1)
                    oeCtaCtable = New e_CuentaContable
                    oeCtaCtable.Equivale = 0 : oeCtaCtable.Cuenta = strNewCta
                    If leCtaCtable.Contains(oeCtaCtable) Then
                        oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
                    End If
                End If
                If oeMovDocumento.IndServicioMaterial = "S" AndAlso oeMovDocumento.lstDetalleDocumento.Count > 0 Then
                    oeDetalle = New e_DetalleDocumento
                    oeDetalle = oeMovDocumento.lstDetalleDocumento(0)
                End If
                oeServCtaCtble = New e_ServicioCuentaContable
                oeServCtaCtble.IdServicio = IIf(oeMovDocumento.IndServicioMaterial = "S", oeDetalle.NombreMaterialServicio, gVSTransporte) : oeServCtaCtble.Equivale = 1
                If leServCtaCtble.Contains(oeServCtaCtble) Then
                    oeServCtaCtble = leServCtaCtble.Item(leServCtaCtble.IndexOf(oeServCtaCtble))
                Else
                    Throw New Exception("No Existen Cuenta Contable para el Servicio: " & gVSTransporte & " para el Año: " & AnioServ & _
                                        Environment.NewLine & "Solicite el Apoyo del Area Contable.")
                End If
                If oeMovDocumento.IndServicioMaterial = "S" AndAlso oeDetalle.NombreMaterialServicio.Trim = gVSTracto.Trim Then IdCtaCtableAux = oeCtaCtable.Id
                If oeMovDocumento.IndServicioMaterial = "S" Then IndServ = True
                ' Valida CuentaCorriente
                oeCuentaCorriente = New e_CuentaCorriente
                oeCuentaCorriente.Tipo = 3 : oeCuentaCorriente.IdTrabajador = oeMovDocumento.IdClienteProveedor
                oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
                oeMovDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                If oeCuentaCorriente.Id <> "" Then
                    _banEmis = olMovDocumento.GuardarVentaAsiento(oeMovDocumento, oeAsientoModel, oeServCtaCtble, IndServ, IdCtaCtableAux)
                Else
                    With oeCuentaCorriente
                        .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = oeMovDocumento.IdClienteProveedor
                        .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = frm.Año1.Año : .Usuario = gUsuarioSGI.Id
                        .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA"
                    End With
                    oeCuentaCorriente.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olCuentaCorriente.Guardar(oeCuentaCorriente)
                    _banEmis = olMovDocumento.GuardarVentaAsiento(oeMovDocumento, oeAsientoModel, oeServCtaCtble, IndServ, IdCtaCtableAux)
                End If
                '  If olMovDocumento.InterfazVenta(oeMovDocumento) Then
                If _banEmis = True Then
                    mensajeEmergente.Confirmacion("El Documento " & " Nº " & oeMovDocumento.Serie & " - " & oeMovDocumento.Numero & " ha sido Emitida", True)
                    Dim id_doc As String = oeMovDocumento.Id
                    Dim WCF_Cpe As New WCF_CpeIndu.WCF_CpeClient("Indu_IWCF_Cpe")
                    Dim dsComprobante As DataSet
                    Dim dt_cpe As DataTable
                    oeMovDocumento = New e_MovimientoDocumento
                    olMovDocumento = New l_MovimientoDocumento
                    oeMovDocumento.TipoOperacion = "DT"
                    oeMovDocumento._Operador = IIf(cboTipoDoc.Value = "1CH000000030", 7, 8)
                    oeMovDocumento.Abrev_Empresa = Abrev_Empresa
                    oeMovDocumento.Id = id_doc
                    dsComprobante = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento)
                    'olDocumento.GenerarXmlFacturaElectronica_Emision(dsComprobante.Tables(0), dsComprobante.Tables(1), frm_DocumentoElectronico.RutaArchivos, gUsuarioEOS.Id)
                    'dt_cpe = Deserializar_XmlStr(WCF_Cpe.GenerarXML_CPE(dsComprobante, Date.Now, dsComprobante.Tables(0).Rows(0).Item("cod_comprob_cat_1").ToString().Trim(), RutaArchivos, Abrev_Empresa, Nothing, Nothing))
                    'Registro_ComprobanteElectronico_Bath(dt_cpe, "I", dsComprobante.Tables(0).Rows(0).Item("cod_comprob_cat_1").ToString().Trim(), Nothing)
                End If
                'End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCombos()
        Try
            'Cargar Tipo Documentos
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.TipoOperacion = "F"
            leTipoDocAso = olTipoDoc.Listar(oeTipoDoc)
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.Id = "NOTACD" : oeTipoDoc.Nombre = "TODOS"
            leTipoDocBus.Add(oeTipoDoc)
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.TipoOperacion = "" : oeTipoDoc.Nombre = "NOTA DE CRÉDITO"
            oeTipoDoc = olTipoDoc.Obtener(oeTipoDoc)
            leTipoDoc.Add(oeTipoDoc)
            leTipoDocBus.Add(oeTipoDoc)
            leTipoDocAso.Add(oeTipoDoc)
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.TipoOperacion = "" : oeTipoDoc.Nombre = "NOTA DE DÉBITO"
            oeTipoDoc = olTipoDoc.Obtener(oeTipoDoc)
            leTipoDoc.Add(oeTipoDoc)
            leTipoDocBus.Add(oeTipoDoc)
            leTipoDocAso.Add(oeTipoDoc)
            LlenarCombo(cboTipoDocumento, "Nombre", leTipoDocBus, 0)
            LlenarCombo(cboTipoDoc, "Nombre", leTipoDoc, -1)
            LlenarCombo(cboTipoDocAso, "Nombre", leTipoDocAso, -1)
            'Cargar Moneda
            oeMoneda = New e_Moneda
            leMoneda = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboTipoMoneda, "Nombre", leMoneda, -1)
            'Cargar Estado
            oeEstado = New e_Estado
            oeEstado.Nombre = "FACTURAR"
            leEstado = olEstado.Listar(oeEstado)
            'Cargar Cliente
            oeCliente = New e_Cliente
            oeCliente.TipoClienteProveedor = 1
            leCliente = olCliente.Listar(oeCliente)
            'Cargar Servicios Venta
            AnioServ = Date.Now.Year
            oeServCtaCtble = New e_ServicioCuentaContable
            oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = AnioServ
            leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)
            'Cargar Asiento Modelo
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
            'Cargar Asiento Modelo Referencia
            oeReferencia = New e_AsientoModelo_Referencia
            oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
            leReferencia = olReferencia.Listar(oeReferencia)
            'Cargar DT Referencia
            DTReferencia = GeneraDTRef(leReferencia)
            'Cargar Cuenta Ctable
            oeCtaCtable = New e_CuentaContable
            oeCtaCtable.TipoOperacion = "N" : oeCtaCtable.Ejercicio = AnioServ : oeCtaCtable.Activo = True
            leCtaCtable = olCtaCtable.Listar(oeCtaCtable)
            oeCtaCtable = New e_CuentaContable
            oeCtaCtable.Equivale = 0 : oeCtaCtable.Cuenta = gCC16531
            If leCtaCtable.Contains(oeCtaCtable) Then
                oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
            End If
            'Cargar Motivos
            ListaMotivoNC = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "20" 'prefijo de MOTIVO NOTA CREDITO
            ListaMotivoNC.AddRange(loConcepto.Listar(oeConcepto))

            ListaMotivoND = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "21" 'prefijo de MOTIVO NOTA DEBITO
            ListaMotivoND.AddRange(loConcepto.Listar(oeConcepto))

            'Cargar Series Permitidas
            ListaSeriePermitidas = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "22" 'prefijo de serie
            oeConcepto.Valor1 = gUsuarioSGI.Id
            ListaSeriePermitidas = loConcepto.Listar(oeConcepto)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub TextoNumero(ByVal ei As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(ei.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then ei.Handled = True
    End Sub

    Private Sub FormateaTexto(ByVal texto As UltraWinEditors.UltraTextEditor, ByVal lon As Integer)
        If texto.Text.Trim <> "" AndAlso CInt(texto.Text) > 0 Then
            texto.Text = FormatoDocumento(texto.Text, lon)
        End If
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeNotaCreditoDebito = New e_MovimientoDocumento
            ValidarFechaDesde_Hasta(fecDesde, fecHasta)
            oeNotaCreditoDebito.Activo = Activo
            oeNotaCreditoDebito.TipoOperacion = "FAC"
            oeNotaCreditoDebito.IdTipoDocumento = cboTipoDocumento.Value
            oeNotaCreditoDebito.IndCompraVenta = 2
            oeNotaCreditoDebito.FechaInicio = fecDesde.Value
            oeNotaCreditoDebito.FechaFinal = fecHasta.Value
            CargarNotasCD(olNotaCreditoDebito.Listar(oeNotaCreditoDebito))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griNotaCreditoDebito.Focus()
    End Sub

    Private Sub CargarNotasCD(ByVal leNotasCD As List(Of e_MovimientoDocumento))
        Try
            With griNotaCreditoDebito
                If band Then
                    .ResetDisplayLayout()
                    .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                End If
                .DataSource = leNotasCD
                If band Then
                    CreaCombo_griNotaCD()
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

                    .DisplayLayout.Bands(0).Columns("Serie").SortIndicator = SortOrder.Ascending

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
                    .DisplayLayout.Bands(0).Columns("Neto").Header.VisiblePosition = 15
                    .DisplayLayout.Bands(0).Columns("IdEstadoDocumento").Header.VisiblePosition = 16

                    .DisplayLayout.Bands(0).Columns("Serie").Width = 30
                    .DisplayLayout.Bands(0).Columns("Numero").Width = 65
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

                    .DisplayLayout.Bands(0).Columns("SubTotal").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("Total").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("Saldo").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("Neto").Format = "##,###,###0.0000"

                    .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1

                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                End If

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

    Private Sub CreaCombo_griNotaCD()
        'Para Columna de Moneda
        griNotaCreditoDebito.DisplayLayout.ValueLists.Add("IdMoneda")
        With griNotaCreditoDebito.DisplayLayout.ValueLists("IdMoneda").ValueListItems
            .Clear()
            For Each oeTD As e_Moneda In leMoneda
                .Add(oeTD.Id, oeTD.Abreviatura)
            Next
        End With
        CrearComboGrid3("IdMoneda", "Abreviatura", griNotaCreditoDebito, True)
        'Para Columna de Estado Documento
        griNotaCreditoDebito.DisplayLayout.ValueLists.Add("IdEstadoDocumento")
        With griNotaCreditoDebito.DisplayLayout.ValueLists("IdEstadoDocumento").ValueListItems
            .Clear()
            For Each oeEs As e_Estado In leEstado
                .Add(oeEs.Id, oeEs.Nombre)
            Next
        End With
        CrearComboGrid3("IdEstadoDocumento", "Nombre", griNotaCreditoDebito, True)
        'Para Columna de Tipo Documento
        griNotaCreditoDebito.DisplayLayout.ValueLists.Add("IdTipoDocumento")
        With griNotaCreditoDebito.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
            .Clear()
            For Each oeTD As e_TipoDocumento In leTipoDoc
                .Add(oeTD.Id, oeTD.Nombre)
            Next
        End With
        CrearComboGrid3("IdTipoDocumento", "TipoDocumento", griNotaCreditoDebito, True)
    End Sub

    Private Sub Inicializar()
        oeNotaCreditoDebito = New e_MovimientoDocumento
        cboTipoDocAso.SelectedIndex = -1
        txtSerieAso.Text = String.Empty
        txtNumeroAso.Text = String.Empty
        cboTipoDoc.SelectedIndex = -1
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        fecEmision.Value = Date.Now.Date
        fecVencimiento.Value = Date.Now.Date
        'fecPeriodo.Value = Date.Now.Date
        cboTipoMoneda.SelectedIndex = -1
        decSubTotal.Value = 0
        decIgv.Value = 0
        decTotal.Value = 0
        txtGlosa.Value = String.Empty
        txtClienteAso.Text = String.Empty
        txtEstadoAso.Text = String.Empty
        txtTipoMonedaAso.Text = String.Empty
        decSubTotalAso.Value = 0
        decIgvAso.Value = 0
        decTotalAso.Value = 0
        dtAux = New Data.DataTable
        leDetalle = New List(Of e_DetalleDocumento)
        CargarDetDoc(leDetalle)
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeNotaCreditoDebito.IdUsuarioCrea = gUsuarioSGI.Id
            oeNotaCreditoDebito.Mac_PC_Local = MacPCLocal()
            If oeTipoDoc.Codigo = "07" Then
                oeNotaCreditoDebito._Operador = -1
            Else
                oeNotaCreditoDebito._Operador = 1
            End If
            oeNotaCreditoDebito.IndCompraVenta = 2
            oeNotaCreditoDebito.IndElectronico = chkElectronico.Checked
            oeNotaCreditoDebito.CodMotivo = cmbMotivoMod.Value
            oeNotaCreditoDebito.IdTipoPago = "1SI000000001"
            oeNotaCreditoDebito.EstadoDocumento = "GENERADA"
            oeNotaCreditoDebito.FechaEmision = fecEmision.Value
            CalcularPeriodo(fecEmision.Value.Month, fecEmision.Value.Year)
            oeNotaCreditoDebito.FechaVencimiento = fecVencimiento.Value
            oeNotaCreditoDebito.lstDetalleDocumento = CargaDetalle()
            oeNotaCreditoDebito.TipoCambio = decTipoCambio.Value
            oeNotaCreditoDebito.Venta.IGV = IIf(cboTipoMoneda.Text.Trim <> "SOLES", Math.Round(decIgv.Value * decTipoCambio.Value, 4), decIgv.Value)
            oeNotaCreditoDebito.Venta.Gravado = IIf(decIgv.Value = 0, 0, IIf(cboTipoMoneda.Text.Trim <> "SOLES", Math.Round(decSubTotal.Value * decTipoCambio.Value, 4), decSubTotal.Value))
            oeNotaCreditoDebito.Venta.Inafecto = IIf(decIgv.Value = 0, IIf(cboTipoMoneda.Text.Trim <> "SOLES", Math.Round(decSubTotal.Value * decTipoCambio.Value, 4), decSubTotal.Value), 0)
            oeNotaCreditoDebito.Venta.IdDireccion = oeDocAso.Venta.IdDireccion
            olNotaCreditoDebito.ValidarNC_ND(oeNotaCreditoDebito)
            oeNotaCreditoDebito.PrefijoID = gs_PrefijoIdSucursal '@0001 Ini
            oeNotaCreditoDebito.DatosImpresion = New e_MovimientoDocumento_Impresion
            With oeNotaCreditoDebito.DatosImpresion
                .IdTipoDocumento = cboTipoDoc.Value
                .TipoDocumento = cboTipoDoc.Text
                .IdMedioPago = cmbMotivoMod.Value
                .MedioPago = cmbMotivoMod.Text
                .NombreClienteProveedor = txtClienteAso.Text
                .NroDocumentoClienteProveedor = txtRuc.Text
                oeCombo = New e_Combo
                oeCombo = DireccionClienteProveedorPublic.Where(Function(i) i.Descripcion = oeNotaCreditoDebito.IdClienteProveedor)(0)
                .IdDireccion = oeCombo.Id
                .Direccion = oeCombo.Nombre
                .MontoLetras = Conversiones.NumerosALetras.Ejecutar(oeNotaCreditoDebito.Total, True, True, "SOLES")
            End With
            If olNotaCreditoDebito.GuardarMasivo(oeNotaCreditoDebito) Then
                'mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                If MessageBox.Show("La informacion ha sido grabada satisfactoriamente en " & Me.Text & _
                                   Environment.NewLine & "¿Desea Emitir el Documento?", "Mensaje del sistema", MessageBoxButtons.YesNo _
                                  , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    Emitir(cboTipoDoc.Value, txtSerie.Value, txtNumero.Text)
                End If
                MostrarTabs(0, ficNotaCreditoDebito, 2)
                Consultar(_Activo)
                griNotaCreditoDebito.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'Enfocar(ex.Message)
        End Try
    End Function

    Private Sub CalculaTipoCambio(ByVal Fecha As Date)
        Try
            decTipoCambio.Value = TipoCambio(Fecha, True)(0)
            'oeMovDocumento.TipoCambio = decTipoCambio.Value
            oeIGV = New e_Impuesto
            oeIGV = olIGV.IGV(Fecha)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CalcularTotal()
        decTotal.Value = decSubTotal.Value + decIgv.Value
    End Sub

    Private Sub CalcularSubTotal()
        decSubTotal.Value = Math.Round(decTotal.Value / (oeIGV.Porcentaje + 1), 2)
        decIgv.Value = decTotal.Value - decSubTotal.Value
    End Sub

    Private Sub CalcularIgv()
        decIgv.Value = decTotal.Value - decSubTotal.Value
    End Sub

    Private Sub CargaDocAsociado()
        Try
            oeDocAso = New e_MovimientoDocumento
            leDetalle = New List(Of e_DetalleDocumento)
            Dim oeDetalle As New e_DetalleDocumento
            Dim oetm As New e_Moneda
            Dim oeDocAso2 As New e_DocumentoAsociado
            oeDocAso.IdTipoDocumento = cboTipoDocAso.Value
            oeDocAso.Serie = txtSerieAso.Text
            oeDocAso.Numero = txtNumeroAso.Text
            oeDocAso.IndCompraVenta = 2
            oeDocAso = olNotaCreditoDebito.ObtenerVenta(oeDocAso)
            With oeDocAso
                If .Id <> "" Then
                    oeCliente.Id = .IdClienteProveedor : oeCliente.Nombre = .NombreProveedor
                    oeNotaCreditoDebito.IdClienteProveedor = .IdClienteProveedor : oeNotaCreditoDebito.IndServicioMaterial = .IndServicioMaterial
                    oeDocAso2.TipoOperacion = "I" : oeDocAso2.IdMovimientoDocumentoAsoc = .Id : oeDocAso2.Activo = True
                    oeNotaCreditoDebito.DocAsoc = New List(Of e_DocumentoAsociado)
                    oeNotaCreditoDebito.DocAsoc.Add(oeDocAso2)
                    txtClienteAso.Text = .NombreProveedor : txtEstadoAso.Text = .EstadoDocumento
                    oetm = leMoneda.Where(Function(item) item.Id = .IdMoneda)(0)
                    txtTipoMonedaAso.Text = oetm.Nombre
                    Dim _leCli = leCliente
                    txtRuc.Text = _leCli.Where(Function(it) it.Id = .IdClienteProveedor).ToList(0).Dni
                    decSubTotalAso.Value = .SubTotal
                    decIgvAso.Value = .IGV
                    decTotalAso.Value = .Total
                    dtpFecEmisionAso.Value = .FechaEmision
                    oeDetalle.TipoOperacion = "VEN"
                    oeDetalle.IdMovimientoDocumento = .Id
                    oeDetalle.IndServicioMaterial = .IndServicioMaterial
                    leDetalle = olDetalle.Listar(oeDetalle)
                    CargarDetDoc(leDetalle)
                    oeDocAso.lstDetalleDocumento = leDetalle
                Else
                    Throw New Exception("No se encontro el documento: " & cboTipoDocAso.Text & " Nº " & txtSerieAso.Text & "-" & txtNumeroAso.Text)
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CargaDetalle() As List(Of e_DetalleDocumento)
        Try
            Dim le As New List(Of e_DetalleDocumento)
            Dim totAso As Double = oeDocAso.SubTotal
            Dim totDoc As Double = decSubTotal.Value
            If oeDocAso.lstDetalleDocumento.Count > 0 Then
                For Each oeDet As e_DetalleDocumento In oeDocAso.lstDetalleDocumento
                    Dim oeDetDoc As New e_DetalleDocumento
                    oeDetDoc.Cantidad = 1
                    oeDetDoc.Precio = Math.Round(((oeDet.Precio * oeDet.Cantidad) / totAso) * totDoc, 2)
                    oeDetDoc.Total = Math.Round(((oeDet.Precio * oeDet.Cantidad) / totAso) * totDoc, 2)
                    oeDetDoc.FactorRefUni = oeDet.FactorRefUni
                    oeDetDoc.IndGravado = oeDet.IndGravado
                    oeDetDoc.Igv = oeDetDoc.Total * oeIGV.Porcentaje
                    oeDetDoc.IdMaterialServicio = oeDet.IdMaterialServicio
                    oeDetDoc.IdOperacionDetalle = oeDet.IdOperacionDetalle
                    oeDetDoc.IdVehiculo = oeDet.IdVehiculo
                    oeDetDoc.IdUnidadMedida = oeDet.IdUnidadMedida
                    oeDetDoc.IndServicioMaterial = oeDet.IndServicioMaterial
                    oeDetDoc.UsuarioCreacion = gUsuarioSGI.Id
                    le.Add(oeDetDoc)
                Next
            End If
            Return le
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CalcularPeriodo(ByVal Mes As Integer, ByVal Anio As Integer)
        Try
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            oePeriodo.Ejercicio = Anio
            oePeriodo.Mes = Mes
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            oeNotaCreditoDebito.IdPeriodo = oePeriodo.Id
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarDatosEmitir(oeDoc As e_MovimientoDocumento)
        Try
            oeCliente = New e_Cliente
            oeCliente.Id = oeDoc.IdClienteProveedor : oeCliente.Equivale = 1
            If leCliente.Contains(oeCliente) Then
                oeCliente = leCliente.Item(leCliente.IndexOf(oeCliente))
            End If
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.Id = oeDoc.IdTipoDocumento : oeTipoDoc.Equivale = 0
            If leTipoDoc.Contains(oeTipoDoc) Then
                oeTipoDoc = leTipoDoc.Item(leTipoDoc.IndexOf(oeTipoDoc))
            End If
            oeMoneda = New e_Moneda
            oeMoneda.Id = oeDoc.IdMoneda
            If leMoneda.Contains(oeMoneda) Then
                oeMoneda = leMoneda.Item(leMoneda.IndexOf(oeMoneda))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetDoc(ByVal leDet As List(Of e_DetalleDocumento))
        Try
            With griDetalleDoc
                .ResetDisplayLayout()
                .DataSource = leDet
                .Text = "Detalle de Documentos"
                OcultarColumna(griDetalleDoc, True, "Id", "IdMovimientoDocumento", "IndServicioMaterial", "IdMaterialServicio", "CodigoMaterialServicio",
                               "PrecioUnitarioSinImp", "IndGravado", "IdOperacionDetalle", "IdVehiculo", "Activo", "UsuarioCreacion", "FechaCreacion",
                               "Seleccion", "IdUnidadMedida", "IdTipoUnidadMedida", "Pos", "FactorRefUni", "IdCuentaContableCompra", "IdViaje",
                                "IdEmpresaSis", "IdSucursal", "IndConsolidado", "GlosaConsolidado", "Consolidado")
                FormatoColumna(griDetalleDoc, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Cantidad", "Precio", "Igv", "Subtotal", "Total")
                .DisplayLayout.Bands(0).Columns("NombreMaterialServicio").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("UnidadMedida").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Precio").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Subtotal").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Igv").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("NombreMaterialServicio").Header.Caption = "Material / Servicio"
                .DisplayLayout.Bands(0).Columns("NombreMaterialServicio").Width = 200
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                CalcularTotales(griDetalleDoc, "Total")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mnuNotaCD_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuNotaCD.Opening
        mnuNotaCD.Items("tsmiEmitir").Visible = False
        mnuNotaCD.Items("tsmiAnular").Visible = False
        mnuNotaCD.Items("tsmiEliminar").Visible = False
        If griNotaCreditoDebito.Selected.Rows.Count > 0 Then
            Select Case griNotaCreditoDebito.ActiveRow.Cells("IdEstadoDocumento").Value
                Case "1CH00014"
                    mnuNotaCD.Items("tsmiEmitir").Visible = True
                    mnuNotaCD.Items("tsmiEliminar").Visible = True
                Case "1CH00008"
                    mnuNotaCD.Items("tsmiAnular").Visible = True
            End Select
        End If
    End Sub

    Private Sub tsmiEmitir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEmitir.Click
        Try
            oeNotaCreditoDebito = New e_MovimientoDocumento
            oeNotaCreditoDebito = griNotaCreditoDebito.ActiveRow.ListObject
            If MessageBox.Show("¿Desea Emitir el Documento Nº: " & oeNotaCreditoDebito.Serie & " - " & oeNotaCreditoDebito.Numero & "?" _
                               , "Mensaje de sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                chkEmitir = True
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                If oeNotaCreditoDebito.IndServicioMaterial = "M" Then
                    cadSQL = "TipoRef2 = 5 AND IdRef2 = '" & oeNotaCreditoDebito.IdTipoDocumento & "' AND TipoRef3 = 6 AND Ref3 = '" & _
                        gVSTransporte & "' AND TipoRef1 = 4 AND IdRef1 = '" & oeNotaCreditoDebito.IdMoneda & "'"
                Else
                    cadSQL = "TipoRef2 = 5 AND IdRef2 = '" & oeNotaCreditoDebito.IdTipoDocumento & "' AND TipoRef3 = 6 AND Ref3 = '" & _
                        gVSOtros & "' AND TipoRef1 = 4 AND IdRef1 = '" & oeNotaCreditoDebito.IdMoneda & "'"
                End If
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("El Tipo Doc: " & cboTipoDoc.Text & ", no tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                Emitir(oeNotaCreditoDebito.IdTipoDocumento, oeNotaCreditoDebito.Serie, oeNotaCreditoDebito.Numero)
                chkEmitir = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAnular.Click
        Try
            oeNotaCreditoDebito = New e_MovimientoDocumento
            oeNotaCreditoDebito = griNotaCreditoDebito.ActiveRow.ListObject
            If MessageBox.Show("¿Desea Anular el Documento Nº: " & oeNotaCreditoDebito.Serie & " - " & oeNotaCreditoDebito.Numero _
                               , "Mensaje de sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                olNotaCreditoDebito.Anular(oeNotaCreditoDebito, gUsuarioSGI.Id)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Try
            oeNotaCreditoDebito = New e_MovimientoDocumento
            oeNotaCreditoDebito = griNotaCreditoDebito.ActiveRow.ListObject
            If MessageBox.Show("¿Desea Eliminar el Documento Nº: " & oeNotaCreditoDebito.Serie & " - " & oeNotaCreditoDebito.Numero _
                               , "Mensaje de sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                oeNotaCreditoDebito.TipoOperacion = "X"
                olNotaCreditoDebito.EliminarDocumentoVenta(oeNotaCreditoDebito)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


    Private Sub tsmiDescargarPDF_Click(sender As Object, e As EventArgs) Handles tsmiDescargarPDF.Click
        Try
            If griNotaCreditoDebito.ActiveRow.Cells("IndElectronico").Value = 0 Then Throw New Exception("Documento debe ser Electrónico.")

            'If griDocumentoVenta.ActiveRow.Cells("Estado").Value = "Anulado" Then Throw New Exception("Documento esta Anulado.")

            Dim frmImpresion As New frm_FacturaBoletaElectronico
            frmImpresion.mt_CargarDatos(griNotaCreditoDebito.ActiveRow.Cells("Id").Value, True, "")
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
            'Dim RutaArchivos As String = Path.Combine(Application.StartupPath, "ComprobanteElectronico") & "\Facturacion\"
            Dim sNombreArchivo As String = ""
            Dim TipoDocumento As String = ""
            Dim SerieDes As String = ""
            Dim NumeroDes As String = ""
            If griNotaCreditoDebito.ActiveRow.Cells("EstadoSunat").Value <> "ACEPTADA" Then Throw New Exception("Para Descargar XML, Documento debe ser Aceptada por Sunat.")

            FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                sNombreArchivo = FolderBrowserDialog1.SelectedPath
            Else
                FolderBrowserDialog1.Dispose()
                Return
            End If

            If sNombreArchivo <> "" Then
                TipoDocumento = griNotaCreditoDebito.ActiveRow.Cells("IdTipoDocumento").Value
                If TipoDocumento = "1CH000000026" Then TipoDocumento = "01"
                If TipoDocumento = "1CH000000002" Then TipoDocumento = "03"
                If TipoDocumento = "1CH000000033" Then TipoDocumento = "08"
                If TipoDocumento = "1CH000000030" Then TipoDocumento = "07"

                SerieDes = griNotaCreditoDebito.ActiveRow.Cells("Serie").Value
                NumeroDes = griNotaCreditoDebito.ActiveRow.Cells("Numero").Value.ToString.Substring(2, 8)

                RutaArchivos = RutaArchivos + gs_RucEmpresaSistema.Trim + "-" + TipoDocumento + "-" + SerieDes + "-" + NumeroDes + ".zip"
                sNombreArchivo = sNombreArchivo + "\" + gs_RucEmpresaSistema.Trim + "-" + TipoDocumento + "-" + SerieDes + "-" + NumeroDes + ".zip"
                My.Computer.FileSystem.CopyFile(RutaArchivos, sNombreArchivo, True)
                mensajeEmergente.Confirmacion("Se copio archivo correctamente", True)
            End If


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
#End Region

End Class
