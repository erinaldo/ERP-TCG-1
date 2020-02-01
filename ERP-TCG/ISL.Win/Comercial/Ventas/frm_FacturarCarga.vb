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
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports System.IO
Imports System.Threading
Imports System.Configuration
Imports System.Collections.Specialized

Public Class frm_FacturarCarga
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_FacturarCarga()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private Shared instancia As frm_FacturarCarga = Nothing
    Private Shared Operacion As String

    Private oeMovDocumento As New e_MovimientoDocumento, olMovDocumento As New l_MovimientoDocumento
    Private oeDetalleDoc As New e_DetalleDocumento
    Private oeVehiculo As New e_Vehiculo, olVehiculo As New l_Vehiculo
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda, leMoneda As New List(Of e_Moneda)
    Private oeCliente As New e_Cliente, olCliente As New l_Cliente, leCliente As New List(Of e_Cliente)
    Private oePiloto As New e_Trabajador, olPiloto As New l_Trabajador
    Private oeTipoPago As New e_TipoPago, olTipoPago As New l_TipoPago, leTipoPago As New List(Of e_TipoPago)
    Private oeDireccion As New e_Direccion_EmpresaPersona, olDireccion As New l_Direccion_EmpresaPersona, leDir As New List(Of e_Direccion_EmpresaPersona)
    Private oeClienteTP As New e_PersonaEmpresa_TipoPago, olClienteTP As New l_PersonaEmpresa_TipoPago
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeViaje As New e_Viaje, olOperacion As New l_Operacion, leViaje As New List(Of e_Viaje)
    Private oeOperacionDet As New e_OperacionDetalle, leOperacionDet As New List(Of e_OperacionDetalle)
    Private oeDetalleDocOpeDet As New e_DetalleDoc_OperacionDet, leDetalleDocOD As New List(Of e_DetalleDoc_OperacionDet)
    Private leFactorReferencial As New List(Of e_DetalleDoc_OperacionDet)
    Private oeGuiaTransportista As New e_GuiaTransportista, olGuiaTransportista As New l_GuiaTransportista, leGuiaTrans As New List(Of e_GuiaTransportista)
    Private oeGuiaRemitente As New e_GuiaRemitente, olGuiaRemitente As New l_GuiaRemitente, leGuiaRemitente As New List(Of e_GuiaRemitente)
    Private oeRuta As New e_Ruta, olRuta As New l_Ruta
    Private oeTipoCarga As New e_TipoCarga, olTipoCarga As New l_TipoCarga, leTipoCarga As New List(Of e_TipoCarga)
    Private oeMaterial As New e_Material, olMaterial As New l_Material, leMaterial As New List(Of e_Material)
    Private oeLugar As New e_Lugar, olLugar As New l_Lugar, leLugar As New List(Of e_Lugar)
    Private oeIGV As New e_Impuesto, olIGV As New l_Impuesto
    Private oeCentro As New e_Centro, olCentro As New l_Centro, ListaCentro As New List(Of e_Centro)
    Private leCargas As New List(Of e_Viaje), leSelec As New List(Of e_Viaje), Prefijo As New l_Configuracion
    Private oeTipoDoc As New e_TipoDocumento, leTipoDoc As New List(Of e_TipoDocumento)
    Private oeServCtaCtble As New e_ServicioCuentaContable, olServCtaCtble As New l_ServicioCuentaContable, leServCtaCtble As New List(Of e_ServicioCuentaContable)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeCtaContable As e_CuentaContable, olCtaContable As l_CuentaContable, leCtaContable As List(Of e_CuentaContable)
    Private oeAnticipo As New e_MovimientoDocumento, olAnticipo As New l_MovimientoDocumento, lstAnticipo As New List(Of e_MovimientoDocumento)
    Private oeDocAsoc As New e_DocumentoAsociado, olDocAsoc As New l_DocumentoAsociado, lstDocAsoc As New List(Of e_DocumentoAsociado)
    Private cantmat As Double = 0
    Private oeTipoBien As New e_TipoBien
    Private olTipoBien As New l_TipoBien
    Private loTipobien As New List(Of e_TipoBien)

    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)

    Dim oeLiquidacion As New e_Liquidaciones, olLiquidacion As New l_Liquidacion, ListaLiquidacion As New List(Of e_Liquidaciones)
    Dim oeCuentaCorriente As New e_CuentaCorriente, olCuentaCorriente As New l_CuentaCorriente
    Dim oeSubClaseServicio As New e_Combo, ListaSubClaseServicio As New List(Of e_Combo)

    Dim TotalFlete As Double = 0, Cant As Double = 0, Precio As Double = 0
    Dim IdOrigen As String = "", IdDestino As String = "", IdCliente As String = "", IdLiquidacion As String = ""
    Dim CadId As String = "", CadIdGT As String = "", TD As String = "", NomRuta As String = "", Oper As String = ""
    Dim TipoConsulta As String = "", NombreGrilla As String = "", iEstado As String = String.Empty
    Dim NroSel As Integer = 0, AnioServ As Integer = 0
    Dim Band As Boolean = True, VistaPrevia As Boolean = True, BandDetalle As Boolean = False, BandBtn As Boolean = False, BandRuta As Boolean = False
    Dim BandSel As Boolean = True, BandLista As Boolean = False, BandPrecio As Boolean = True, BandSave As Boolean = True, IndProrratear As Boolean = False
    Dim BandCaso As Boolean, bandload As Boolean
    Dim leCadGTR As New List(Of e_GuiaTransportista)
    Dim _ingresando_datos As Boolean = False
    Dim ListaTipoCarga As New List(Of e_Combo)
    Private ValorIgv As Double = ObtenerIGV()
    Dim IdDocumento As String = String.Empty
    Dim b_anticipo As Boolean = False
#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        'MyBase.Consultar(Activo)
        Try
            ' If cboFactura.Text = "POR FACTURAR" AndAlso griFactura.Rows.Count > 0 Then
            Operacion = "Inicializa"
            Listar(Activo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        If PerfilAsignado(gNombrePerfilJefeContabilidad) Then
            mensajeEmergente.Confirmacion("¡¡Usted no tiene Permisos para realizar esta operación!!" & Environment.NewLine & _
                                          "Para poder tener más permisos comunicarse con el área encargada", True)
        Else
            Operacion = "Nuevo"
            Oper = "Generar"
            BandCaso = False
            Inicializar()
            agrListaCargas.Visible = True
            agrListaCargas.Expanded = False
            BandDetalle = True
            ficDetalle.SelectedTab = ficDetalle.Tabs(0)
            MostrarTabs(1, ficFactura, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)
            ListaLiquidacion = New List(Of e_Liquidaciones)
            griLiquidacion.DataSource = ListaLiquidacion
            ficDetalle.Tabs.Item(3).Visible = False
        End If
        IdLiquidacion = ""
        LimpiaGrid(griLiquidacion, ogdLiquidacion)
    End Sub

    Public Overrides Sub Editar()
        Try
            If IdDocumento = "" Then IdDocumento = griDocumentoVenta.ActiveRow.Cells("Id").Value.ToString
            Operacion = "Editar" : Oper = "Editar" : Mostrar()
            If iEstado <> "1CH00008" Then
                agrListaCargas.Visible = True : agrListaCargas.Expanded = False
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)
            Else
                ControlBoton(0, 0, 0, 0, 1, 0, 1, 1, 0)
                agrListaCargas.Visible = False
            End If
            BandDetalle = False
            ListaLiquidacion = New List(Of e_Liquidaciones)
            griLiquidacion.DataSource = ListaLiquidacion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        If PerfilAsignado(gNombrePerfilJefeContabilidad) Then
            mensajeEmergente.Confirmacion("¡Usted no tiene Permisos para realizar esta operación!" & Environment.NewLine & _
                                          "Para poder tener más permisos comunicarse con el área encargada" & Environment.NewLine & _
                                          "Haga Clik en el boton de <<Cancelar>> para salir", True)
        Else
            Try
                Dim monto As Double = 0
                Select Case Oper
                    Case "Generar"
                        'monto = Math.Round(leDetalleDocOD.Sum(Function(item) item.Valor), 4)
                        'If monto > decSubTotal.Value Then Throw New Exception("El Monto Total del Detalle(" & monto & ") no puede mayor al SubTotal de la Factura(" & oeMovDocumento.SubTotal & ")")
                        Guardando()
                    Case "Emitir"
                        monto = leDetalleDocOD.Sum(Function(item) item.Valor)
                        If Math.Round(monto, 2) <> (Math.Round(decSubTotal.Value, 2) + decAnticipo.Value) Then
                            Throw New Exception("El Monto Total del Detalle(" & Math.Round(monto, 2) & ") no puede ser diferente al SubTotal de la Factura(" & Math.Round(decSubTotal.Value, 2) & ")")
                        End If
                        Emitir()
                        MostrarTabs(0, ficFactura, 0)
                    Case "Anular"
                        Anular()
                    Case "Editar"
                        'If Not ChkAnexo.Checked Then
                        '    'monto = leDetalleDocOD.Sum(Function(item) Math.Round(item.Valor, 2))
                        '    'monto = leDetalleDocOD.Sum(Function(item) item.Valor)
                        '    'If Math.Round(monto, 2) <> Math.Round(decSubTotal.Value, 2) Then
                        '    '    Throw New Exception("El Monto Total del Detalle(" & Math.Round(monto, 2) & _
                        '    '                        ") no puede ser diferente al SubTotal de la Factura(" & Math.Round(decSubTotal.Value, 2) & ")")
                        '    'End If
                        'End If
                        Guardando()
                End Select
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
        End If
    End Sub

    Public Overrides Sub Cancelar()
        'MyBase.Cancelar()
        'ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        Consultar(_Activo)
        MostrarTabs(0, ficFactura)
    End Sub

    Public Overrides Sub Eliminar()
        If PerfilAsignado(gNombrePerfilJefeContabilidad) Then
            mensajeEmergente.Confirmacion("¡¡Usted no tiene Permisos para realizar esta operación!!" & Environment.NewLine & _
                                          "Para poder tener más permisos comunicarse con el área encargada", True)
        Else
            Try
                With griDocumentoVenta
                    If ValidarGrilla(griDocumentoVenta, "Factura") Then
                        oeMovDocumento.Id = .ActiveRow.Cells("Id").Value
                        oeMovDocumento = olMovDocumento.Obtener(oeMovDocumento)
                        If oeMovDocumento.IdEstadoDocumento = "1CH00014" Then
                            If oeMovDocumento.Activo Then
                                If MessageBox.Show("Esta seguro de eliminar el Documento: " & _
                                         .ActiveRow.Cells("Serie").Value.ToString & " - " & .ActiveRow.Cells("Numero").Value.ToString & " ?", _
                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                    oeMovDocumento.TipoOperacion = "X"

                                    olMovDocumento.EliminarDocumentoVenta(oeMovDocumento)
                                    Consultar(True)
                                End If
                            Else
                                Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                            End If
                        Else
                            Throw New Exception("¡¡El Documento debe estar en Estado Generado para poder ser Eliminado!! " & Me.Text)
                        End If
                    End If
                End With
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
        End If
    End Sub

    Public Overrides Sub Imprimir()
        Try
            If Not ConfiguracionRegionalPeru() Then Exit Sub
            Dim oecli As New e_Cliente
            oeMovDocumento.Direccion = cboDirec.Text
            ' oeMovDocumento.NombreProveedor = cboCliente.Text
            Select Case optCliente.CheckedIndex
                Case 0 : oeMovDocumento.NombreProveedor = cboCliente2.Text : oecli = cboCliente2.Rows(cboCliente2.SelectedRow.Index).ListObject
                Case 1 : oeMovDocumento.NombreProveedor = cboDestinatario.Text : oecli = cboDestinatario.Rows(cboDestinatario.SelectedRow.Index).ListObject
                Case 2 : oeMovDocumento.NombreProveedor = cboOtroCliente.Text : oecli = cboOtroCliente.Rows(cboOtroCliente.SelectedRow.Index).ListObject
            End Select
            'oecli = cboCliente.Items(cboCliente.SelectedIndex).ListObject
            oeMovDocumento.Ruc = oecli.Dni
            oeMovDocumento.SubTotal = decSubTotal.Value
            oeMovDocumento.IGV = decImpuesto.Value
            oeMovDocumento.Total = decTotal.Value
            oeMovDocumento.ImporteDetraer = decImporteDetraer.Value
            oeMovDocumento.NetoPagar = decNetoPagar.Value
            oeMovDocumento.Venta.Detraccion = decDetraccion.Value
            oeMovDocumento.Serie = txtSerie.Text
            oeMovDocumento.Numero = txtNumero.Text
            If txtGlosa.Text.Trim <> "" Then
                oeMovDocumento.Venta.Glosa = txtGlosa.Text.Trim
                If verObservaciones.Checked AndAlso txtObrservaciones.Text.Trim <> "" Then
                    oeMovDocumento.Venta.Glosa = oeMovDocumento.Venta.Glosa & "&" & txtObrservaciones.Text
                End If
            End If
            If verObservaciones.Checked Then oeMovDocumento.Observacion = txtObrservaciones.Text
            GuiasTransSel()

            If chkElectronico.Checked Then
                Dim frmImpresion As New frm_FacturaBoletaElectronico
                frmImpresion.mt_CargarDatos(oeMovDocumento.Id, False)
                frmImpresion.StartPosition = FormStartPosition.CenterScreen
                frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                frmImpresion.ShowDialog()
            Else
                Dim ofrm As New frm_ReporteFacturaVenta
                ofrm.CargarDocumento(oeMovDocumento, leDetalleDocOD, BandDetalle, verObservaciones.Checked, verQuitarCant.Checked, leCadGTR, _
                                     verIgv.Checked, verDetraccionCero.Checked, verDetalleAdj.Checked, decCantTn.Value, VistaPrevia)
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.Refresh()
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    ''' 

    Public Overrides Sub Exportar()
        Try
            If ficFactura.SelectedTab.Index = 0 Then
                If ficMaterial.SelectedTab.Index = 0 Then
                    Select Case ficCargas.SelectedTab.Index
                        Case 0
                            Exportar_Excel(griFactura)
                        Case 1
                            Exportar_Excel(griViajesProceso)
                    End Select
                Else
                    Exportar_Excel(griDocumentoVenta)
                End If
            Else
                If ficDetalle.SelectedTab.Index = 0 Then
                    If griDetalleDoc.Rows.Count > 0 Then
                        Exportar_Excel(griDetalleDoc)
                    Else
                        Throw New Exception("No hay Registros para exportar.")
                    End If
                ElseIf ficDetalle.SelectedTab.Index = 1 Then
                    If griGuiaTransportista.Focused Then
                        If griGuiaTransportista.Rows.Count > 0 Then
                            Exportar_Excel(griGuiaTransportista)
                        Else
                            Throw New Exception("No hay Registros para exportar.")
                        End If
                    ElseIf griGuiaRemisionR.Focused Then
                        If griGuiaRemisionR.Rows.Count > 0 Then
                            Exportar_Excel(griGuiaRemisionR)
                        Else
                            Throw New Exception("No hay Registros para exportar.")
                        End If
                    Else
                        Throw New Exception("Seleccione un listado para exportar")
                    End If
                ElseIf ficDetalle.SelectedTab.Index = 2 Then
                    Throw New Exception("Seleccione un listado para exportar")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_FacturarCarga_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
            Case "Editar"
                If iEstado <> "1CH00008" Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)
                Else
                    ControlBoton(0, 0, 0, 0, 1, 0, 1, 1, 0)
                End If
            Case "Inicializa"
                'If cboFactura.Text = "FACTURADOS" Then
                If ficMaterial.SelectedTab.Index = 1 Then
                    If griDocumentoVenta.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Else
                    If griFactura.Rows.Count > 0 Then
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
                End If
        End Select
        If BandBtn Then
            BandBtn = False
            CargaDireccionTipoPago()
        End If
        If BandRuta Then
            CalculaFlete()
            BandRuta = False
            'CargaDireccionTipoPago()
        End If
    End Sub

    Private Sub frm_FacturarCarga_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_FacturarCarga_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_FacturarCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, txtNroGuiaT.Name, decValorUni.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            CargarCombos()
            bandload = True
            CargarPorFacturar(New List(Of e_Viaje), griFactura)
            CargarFacturado(New List(Of e_MovimientoDocumento))
            bandload = False
            fecDoc.Value = Date.Now.Date
            CalculaTipoCambio(Date.Now.Date)
            MostrarTabs(0, ficFactura)
            fecDesde.Value = Date.Now.Date.AddDays(-5)
            fecHasta.Value = Date.Now.Date
            fecDesdeDoc.Value = Date.Now.Date.AddDays(-5)
            fecHastaDoc.Value = Date.Now.Date
            fecDesdeLiquidacion.Value = Date.Now.Date
            fecHastaLiquidacion.Value = Date.Now.Date
            fecPeriodo.Value = ObtenerFechaServidor()
            colorVencidos.Color = Color.LightCoral
            colorPorVencer.Color = Color.Khaki
            colorConDocumentos.Color = Color.LightBlue
            colorSinDocumentos.Color = Color.PaleTurquoise
            colorConDocumentosPerdidos.Color = Color.LightSteelBlue
            colorConDocFac.Color = Color.LightGreen
            colorSinDocFac.Color = Color.DarkSeaGreen
            colorDocPerFac.Color = Color.MediumSeaGreen
            colorRestablecido.Color = Color.Khaki
            etiPorVencer1.Appearance.BackColor = colorPorVencer.Color
            etiPorVencer2.Appearance.BackColor = colorPorVencer.Color
            etiVencidos.Appearance.BackColor = colorVencidos.Color
            etiConDocumentos.Appearance.BackColor = colorConDocumentos.Color
            etiSinDocumentos.Appearance.BackColor = colorSinDocumentos.Color
            etiConDocumentosPerdidos.Appearance.BackColor = colorConDocumentosPerdidos.Color
            etiConDocFac.Appearance.BackColor = colorConDocFac.Color
            etiSinDoc.Appearance.BackColor = colorSinDocFac.Color
            etiDocPerFac.Appearance.BackColor = colorDocPerFac.Color
            etiRestablecido.Appearance.BackColor = colorRestablecido.Color
            agrListaCargas.Expanded = False
            agrListaCargas.Visible = False
            numFaltan.Value = 1
            If PerfilAsignado(gNombrePerfilJefeContabilidad) Then ficMaterial.Tabs(0).Visible = False
            '''''''''''''Combo para liquidacion
            oeSubClaseServicio.Id = "REGULAR"
            oeSubClaseServicio.Nombre = "REGULAR"
            ListaSubClaseServicio.Add(oeSubClaseServicio)
            oeSubClaseServicio = New e_Combo
            oeSubClaseServicio.Id = "DEVOLUCION"
            oeSubClaseServicio.Nombre = "DEVOLUCION"
            ListaSubClaseServicio.Add(oeSubClaseServicio)
            oeSubClaseServicio = New e_Combo
            oeSubClaseServicio.Id = "ESPECIAL"
            oeSubClaseServicio.Nombre = "ESPECIAL"
            ListaSubClaseServicio.Add(oeSubClaseServicio)
            oeSubClaseServicio = New e_Combo
            oeSubClaseServicio.Id = "LOCAL-CHICLAYO"
            oeSubClaseServicio.Nombre = "LOCAL-CHICLAYO"
            ListaSubClaseServicio.Add(oeSubClaseServicio)
            LlenarCombo(cboClaseServicioTottus, "Nombre", ListaSubClaseServicio, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then e.Handled = True
    End Sub

    Private Sub chkElectronico_CheckedChanged(sender As Object, e As EventArgs) Handles chkElectronico.CheckedChanged
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then e.Handled = True
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim indSeriePermite As Boolean = False
            If txtSerie.Text.Trim <> "" Then
                If chkElectronico.Checked Then
                    txtSerie.Text = FormatoSerieElectronica(txtSerie.Text, IIf(cboTipoDocumento.Value = "1CH000000026", "F", "B"))
                Else
                    txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
                End If

                For Each i In loConcepto
                    If i.Valor2.Trim = txtSerie.Text.Trim Then
                        indSeriePermite = True
                        Exit For
                    End If
                Next
                If indSeriePermite = False Then
                    txtSerie.Text = String.Empty
                    Throw New Exception("Serie no permitida para el usuario.")
                End If

                If Operacion = "Nuevo" Then
                    Dim oe As New e_MovimientoDocumento
                    oe.TipoOperacion = "NUM"
                    oe.Serie = txtSerie.Text.Trim
                    oe.IdTipoDocumento = cboTipoDocumento.Value
                    txtNumero.Text = olMovDocumento.ObtenerNumDoc(oe).Numero
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Private Sub txtSerie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.ValueChanged
        oeMovDocumento.Serie = txtSerie.Text.Trim
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        If txtNumero.Text.Trim <> "" AndAlso CInt(txtNumero.Text) > 0 Then txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
    End Sub

    Private Sub txtNumero_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.ValueChanged
        oeMovDocumento.Numero = txtNumero.Text.Trim
    End Sub

    Private Sub fecDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecDoc.ValueChanged
        CalculaTipoCambio(fecDoc.Value)
        oeMovDocumento.FechaEmision = fecDoc.Value
    End Sub

    Private Sub griFactura_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griFactura.CellChange
        griFactura.UpdateData()
    End Sub

    Private Sub cboTipoPago_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPago.ValueChanged
        If cboTipoPago.SelectedIndex > -1 Then
            Dim oe As New e_TipoPago
            oe = cboTipoPago.Items(cboTipoPago.SelectedIndex).ListObject
            oeMovDocumento.FechaVencimiento = fecDoc.DateTime.AddDays(oe.Dias)
            oeMovDocumento.Venta.IdTipoPago = oe.Id
        End If
    End Sub

    Private Sub griDetalleDoc_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleDoc.CellChange
        Try
            'griDetalleDoc.UpdateData()
            BandPrecio = False
            CalculaFlete()
            BandPrecio = True

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decSubTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decSubTotal.ValueChanged
        If IsDBNull(decSubTotal.Value) Then decSubTotal.Value = 0
        If decSubTotal.Value > 0 Then
            oeMovDocumento.SubTotal = decSubTotal.Value
            If Operacion = "Nuevo" Then
                decImpuesto.Value = Math.Round(decSubTotal.Value * oeIGV.Porcentaje, 4)
                decTotal.Value = Math.Round(decSubTotal.Value, 2) + Math.Round(decImpuesto.Value, 2)
                Calcular_Montos()
            End If
        End If
    End Sub

    Private Sub decImpuesto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImpuesto.ValueChanged
        If IsDBNull(decImpuesto.Value) Then decImpuesto.Value = 0
        If decImpuesto.Value > 0 Then
            oeMovDocumento.IGV = decImpuesto.Value
            If Operacion = "Nuevo" Then
                decTotal.Value = Math.Round(decSubTotal.Value, 2) + Math.Round(decImpuesto.Value, 2)
                Calcular_Montos()
            End If
        End If
    End Sub

    Private Sub decTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotal.ValueChanged
        If IsDBNull(decTotal.Value) Then decTotal.Value = 0
        If decSubTotal.Value > 0 Then
            oeMovDocumento.Total = decTotal.Value
            oeMovDocumento.Saldo = decTotal.Value
        End If
    End Sub

    Private Sub fecPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecPeriodo.ValueChanged
        CalcularPeriodo(fecPeriodo.DateTime.Month, fecPeriodo.DateTime.Year)
    End Sub

    Private Sub decDetraccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decDetraccion.ValueChanged
        If cboTipoDocumento.Text = "FACTURA" Then
            oeMovDocumento.Venta.Detraccion = decDetraccion.Value
            oeMovDocumento.Venta.SaldoDetraccion = decDetraccion.Value
        Else
            oeMovDocumento.Venta.Detraccion = 0
            oeMovDocumento.Venta.SaldoDetraccion = 0
        End If
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        'If txtGlosa.Text.Trim <> "" Then oeMovDocumento.Venta.Glosa = txtGlosa.Text
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        If cboTipoDocumento.SelectedIndex > -1 Then
            If cboTipoDocumento.Text = "FACTURA" Then
                HabilitaDetalle(True)
            Else
                HabilitaDetalle(False)
            End If
            oeMovDocumento.IdTipoDocumento = cboTipoDocumento.Value
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc = cboTipoDocumento.Items(cboTipoDocumento.SelectedIndex).ListObject
            If txtSerie.Text.Trim <> "" Then
                txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
                If Operacion = "Nuevo" Then
                    Dim oe As New e_MovimientoDocumento
                    oe.TipoOperacion = "NUM"
                    oe.Serie = txtSerie.Text.Trim
                    oe.IdTipoDocumento = cboTipoDocumento.Value
                    txtNumero.Text = olMovDocumento.ObtenerNumDoc(oe).Numero
                End If
            End If
        End If
    End Sub

    Private Sub cboFactura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFactura.ValueChanged
        verSelecion.Enabled = IIf(cboFactura.Text = "POR FACTURAR", True, False)
    End Sub

    Private Sub colorPorVencer_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        etiPorVencer1.Appearance.BackColor = colorPorVencer.Color
        etiPorVencer2.Appearance.BackColor = colorPorVencer.Color
    End Sub

    Private Sub colorVencidos_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        etiVencidos.Appearance.BackColor = colorVencidos.Color
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        If cboMoneda.SelectedIndex <> -1 Then
            oeMoneda = New e_Moneda
            oeMoneda = cboMoneda.Items(cboMoneda.SelectedIndex).ListObject
            oeMovDocumento.IdMoneda = cboMoneda.Value
            RecalcularMontosOrig_Anticipos()
        End If
    End Sub

    Private Sub griFactura_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griFactura.AfterCellUpdate
        Try
            If BandSel Then
                If e.Cell.Row.Index > -1 Then
                    If griFactura.ActiveRow.Cells("GlosaEscala").Value <> "0" Then
                        If griFactura.ActiveRow.Cells("UsuarioSeguimiento").Value = "1" AndAlso griFactura.ActiveRow.Cells("Seleccion").Value Then
                            If MessageBox.Show("Esta Carga esta Facturada. ¿Desea cambiar a Por Facturar?", _
                                               "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                                Dim oeOperacionDet As New e_OperacionDetalle
                                oeOperacionDet.Id = griFactura.ActiveRow.Cells("Id").Value
                                oeOperacionDet.TipoOperacion = "R"
                                olOperacion.RegfacturarOperacionDet(oeOperacionDet)
                                MessageBox.Show("Esta Carga ha cambiado a Por Facturar", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Else
                                BandSel = False
                                griFactura.ActiveRow.Cells("Seleccion").Value = False
                                BandSel = True
                            End If
                        Else
                            NroSel = griFactura.Rows.Where(Function(item) item.IsFilteredOut = False And item.Cells("Seleccion").Value).Count
                            If Band Then
                                If NroSel = 1 Then
                                    IdCliente = griFactura.Rows(e.Cell.Row.Index).Cells("Tesoreria").Value
                                Else
                                    If NroSel > 0 AndAlso IdCliente <> griFactura.Rows(e.Cell.Row.Index).Cells("Tesoreria").Value Then
                                        Band = False
                                        griFactura.Rows(e.Cell.Row.Index).Cells("Seleccion").Value = False
                                        Throw New Exception("Debe Elegir el mismo Cliente")
                                    End If
                                End If
                                If griFactura.Rows(e.Cell.Row.Index).Cells("Seleccion").Value Then
                                    IdOrigen = griFactura.ActiveRow.Cells("IdOrigen").Value
                                    IdDestino = griFactura.ActiveRow.Cells("IdDestino").Value
                                    griFactura.Rows(e.Cell.Row.Index).Selected = True
                                Else
                                    griFactura.Rows(e.Cell.Row.Index).Selected = False
                                End If
                            Else
                                Band = True
                            End If
                        End If
                    Else
                        If griFactura.ActiveRow.Cells("Seleccion").Value Then
                            MessageBox.Show("La Carga del Viaje Nº: " & griFactura.ActiveRow.Cells("Codigo").Value & " no esta Confirmada", _
                                            "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            BandSel = False
                            griFactura.ActiveRow.Cells("Seleccion").Value = False
                            BandSel = True
                        End If

                    End If

                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub colorConDocumentos_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorConDocumentos.ColorChanged
        etiConDocumentos.Appearance.BackColor = colorConDocumentos.Color
    End Sub

    Private Sub griViajesProceso_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griViajesProceso.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub griViajesProceso_CellChange(sender As Object, e As CellEventArgs) Handles griViajesProceso.CellChange
        griViajesProceso.UpdateData()
    End Sub

    Private Sub VerSeleccionProceso_CheckedChanged(sender As Object, e As EventArgs) Handles VerSeleccionProceso.CheckedChanged
        For Each fila As UltraGridRow In griViajesProceso.Rows.Where(Function(item) item.IsFilteredOut = False)
            fila.Cells("Seleccion").Value = VerSeleccionProceso.Checked
        Next
    End Sub

    Private Sub fecDesde_Validated(sender As Object, e As EventArgs) Handles fecDesde.Validated
        txtCodigoOP.Text = DatePart(DateInterval.WeekOfYear, fecDesde.Value) & " - " & DatePart(DateInterval.Year, fecDesde.Value)
    End Sub

    Private Sub btnActualizarMasiva_Click(sender As Object, e As EventArgs) Handles btnActualizarMasiva.Click
        Try
            leOperacionDet = New List(Of e_OperacionDetalle)
            If txtCodigoOP.Text <> "" And griViajesProceso.Rows.Count > 0 Then
                For Each Fila As UltraGridRow In griViajesProceso.Rows.Where(Function(Item) Item.Cells("Seleccion").Value = 1 And Item.IsFilteredOut = False)
                    oeOperacionDet = New e_OperacionDetalle
                    With oeOperacionDet
                        .TipoOperacion = "4"
                        .Id = Fila.Cells("Id").Value
                        .IdOperacion = txtCodigoOP.Text
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    leOperacionDet.Add(oeOperacionDet)
                Next
                If MessageBox.Show("Se va actualizar todos los REGISTROS de la lista activa seleccionados desea continuar ? ", _
                                   "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    olOperacion.GuardarOperacionDetalleLista(leOperacionDet)
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente.", True)
                End If
            Else
                Throw New Exception("Verifique Codigo de Semana Proceso y Registros Seleccionados")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuAgregarDetalle_Click(sender As Object, e As EventArgs) Handles mnuAgregarDetalle.Click
        DuplicarRegistroDetalle()
    End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        Try
            oeViaje = New e_Viaje
            ValidarFechaDesde_Hasta(fecDesdeViaje, fecHastaViaje)
            oeViaje.FechaDesde = fecDesdeViaje.Value
            oeViaje.FechaHasta = fecHastaViaje.Value
            oeViaje.TipoOperacion = "7"
            oeViaje.IdEstado = cboTracto3.Value
            oeViaje.IndMotriz = 0
            oeViaje.Remitente = oeMovDocumento.IdClienteProveedor
            If verIncluirViajeR.Checked Then
                oeViaje.Activo = 1
            Else
                oeViaje.Activo = 0
            End If
            If txtNroGuiaT.Text.Trim <> "" Then oeViaje.Zona = "%" & txtNroGuiaT.Text.Trim & "%"
            BandLista = True : bandload = True
            CargarPorFacturar(olOperacion.ListarViaje(oeViaje), griListaCarga, False)
            BandLista = False : bandload = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub agrListaCargas_ExpandedStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agrListaCargas.ExpandedStateChanged
        If agrListaCargas.Expanded Then
            fecDesdeViaje.Value = Date.Now.Date.AddDays(-5)
            fecHastaViaje.Value = Date.Now
        End If
    End Sub

    Private Sub griListaCarga_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCarga.CellChange
        Try
            griListaCarga.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaCarga_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCarga.AfterCellUpdate
        Try
            Dim IdOpeDet As String = ""
            Select Case e.Cell.Column.Key.ToUpper
                Case "SELECCION"
                    With griListaCarga.Rows(e.Cell.Row.Index)
                        IdOpeDet = .Cells("Id").Value
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.Aqua
                            '.Fixed = True
                            AgregarCarga(IdOpeDet)
                        Else
                            .Appearance.BackColor = Color.White
                            '.Fixed = False
                            QuitarCarga(IdOpeDet)
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            griDetalleDoc.DataBind()
            griGuiaTransportista.DataBind()
            griGuiaRemisionR.DataBind()
        End Try

    End Sub

    Private Sub txtSerieB_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieB.Validated
        ''If txtSerieB.Text.Trim <> "" AndAlso CInt(txtSerieB.Text) > 0 Then txtSerieB.Text = FormatoDocumento(txtSerieB.Text, 4)
    End Sub

    Private Sub txNumeroB_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroB.Validated
        If txtNumeroB.Text.Trim <> "" AndAlso CInt(txtNumeroB.Text) > 0 Then txtNumeroB.Text = FormatoDocumento(txtNumeroB.Text, 10)
    End Sub

    Private Sub griDetalleDoc_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griDetalleDoc.BeforeCellUpdate
        Try
            With griDetalleDoc
                Select Case e.Cell.Column.Key.ToUpper
                    Case "CANTIDAD"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        If (e.NewValue <= 0) Then
                            Cant = IIf(IsDBNull(e.Cell.Value), 0, e.Cell.Value)
                            Throw New Exception("No se puede cambiar la cantidad por que es menor a cero.")
                        End If
                    Case "PRECIOUNITARIO"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    Case "FACTORREFUNI"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    Case "CONSOLIDADO"
                        If .ActiveRow.Cells("IndConsolidado").Value IsNot Nothing Then
                            e.Cancel = True
                            Throw New Exception("No se puede cambiar el monto consolidado, porque ya fue aplicado")
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalleDoc_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleDoc.AfterCellUpdate
        Try
            With griDetalleDoc
                If griDetalleDoc.Rows.Count > 0 Then
                    Select Case e.Cell.Column.Key.ToUpper
                        Case "CANTIDAD"
                            If IsDBNull(e.Cell.Value) Then
                                .ActiveRow.Cells("Cantidad").Value = Cant
                                Exit Sub
                            End If
                            If Not IsDBNull(e.Cell.Value) AndAlso .ActiveRow.Cells("Cantidad").Value < 0 Then
                                .ActiveRow.Cells("Cantidad").Value = Cant
                            End If
                            CalculaFlete()
                        Case "PRECIOUNITARIO"
                            BandPrecio = False
                            If IndProrratear = False Then
                                If IsDBNull(e.Cell.Value) Then
                                    .ActiveRow.Cells("PrecioUnitario").Value = Precio
                                    Exit Sub
                                End If
                                If Not IsDBNull(e.Cell.Value) AndAlso .ActiveRow.Cells("PrecioUnitario").Value < 0 Then
                                    ' BandPrecio = False
                                    .ActiveRow.Cells("PrecioUnitario").Value = Precio
                                    ' BandPrecio = True
                                End If
                                CalculaFlete()
                            Else
                                IndProrratear = False
                            End If
                            BandPrecio = True
                        Case "FACTORREFUNI"
                            If IsDBNull(e.Cell.Value) Then
                                .ActiveRow.Cells("FactorRefUni").Value = 0
                                Exit Sub
                            End If
                            BandRuta = False
                            CalculaFlete()
                        Case "IDMATERIALSERVICIO"
                            Dim oeMat As New e_Material
                            oeMat = leMaterial.Where(Function(item) item.Id = .ActiveRow.Cells("IdMaterialServicio").Value).ToList(0)
                            .ActiveRow.Cells("MaterialServicio").Value = oeMat.Nombre
                        Case "IDUNIDADMEDIDA"
                            Dim oeTC As New e_TipoCarga
                            oeTC = leTipoCarga.Where(Function(item) item.Id = .ActiveRow.Cells("IdUnidadMedida").Value).ToList(0)
                            .ActiveRow.Cells("UnidadMedida").Value = oeTC.Nombre
                    End Select
                End If

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCliente2_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboCliente2.InitializeLayout
        Me.cboCliente2.ValueMember = "Id"
        Me.cboCliente2.DisplayMember = "Nombre"
        With cboCliente2
            For Each colum As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                If colum.Key <> "Nombre" Then
                    colum.Hidden = True
                End If
            Next
            .DisplayLayout.Bands(0).Columns("Nombre").Width = 150
            .Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        End With
    End Sub

    'Private Sub cboDireccion2_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
    '    Me.cboDireccion2.ValueMember = "IdDireccion"
    '    Me.cboDireccion2.DisplayMember = "Nombre"
    '    With cboDireccion2
    '        For Each colum As UltraGridColumn In .DisplayLayout.Bands(0).Columns
    '            If colum.Key <> "Nombre" Then
    '                colum.Hidden = True
    '            End If
    '        Next
    '        .DisplayLayout.Bands(0).Columns("Nombre").Width = 150
    '        .Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
    '    End With
    'End Sub

    'Private Sub cboDireccion2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '        cboDireccion2.PerformAction(UltraComboAction.Dropdown)
    '    End If
    'End Sub

    'Private Sub cboDireccion2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        'Dim ListaDir As New List(Of e_Direccion_EmpresaPersona)
    '        If cboDireccion2.Text.Trim = "" Then
    '            cboDireccion2.DataSource = Nothing
    '            cboDireccion2.DataSource = New List(Of e_Direccion_EmpresaPersona)
    '        Else
    '            cboDireccion2.DataSource = Nothing
    '            Dim ListaDir = From le In leDir _
    '                    Select IdDireccion = le.oeDireccion.Id, le.Nombre
    '            cboDireccion2.DataSource = ListaDir.Where(Function(Item) Item.Nombre.Contains(cboDireccion2.Text.Trim)).ToList
    '        End If
    '    End If
    'End Sub

    Private Sub verFactorRCero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verFactorRCero.CheckedChanged
        Try
            If leDetalleDocOD.Count > 0 Then
                'griDetalleDoc.DataBind()
                If verFactorRCero.Checked Then
                    For Each oeDDOC As e_DetalleDoc_OperacionDet In leDetalleDocOD
                        oeDDOC.FactorRefUni = 0
                    Next
                Else
                    For Each oeDDOC As e_DetalleDoc_OperacionDet In leDetalleDocOD
                        Dim oe As New e_DetalleDoc_OperacionDet
                        oe = leFactorReferencial.Item(leFactorReferencial.IndexOf(oeDDOC))
                        oeDDOC.FactorRefUni = oe.FactorRefUni
                    Next
                End If
            End If
            BandPrecio = False
            CargarDetalle(leDetalleDocOD)
            BandPrecio = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNroGuiaT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroGuiaT.KeyPress
        e.Handled = EvaluarValorIngresado(sender, e)
    End Sub

    Private Sub txtNroGuiaT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroGuiaT.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ValidarGuiaRemitente(txtNroGuiaT)
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub txtNroGuiaT_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroGuiaT.Validated
        Try
            If txtNroGuiaT.Text <> "" Then
                ValidarGuiaRemitente(txtNroGuiaT)
                'cboRemitenteBusca.Focus()
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub verCantidadTn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verCantidadTn.CheckedChanged
        Try
            decCantTn.Enabled = verCantidadTn.Checked
            BandPrecio = False
            CalculaFlete(True)
            BandPrecio = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decCantTn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles decCantTn.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                CalculaFlete()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub verObservaciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verObservaciones.CheckedChanged
        txtObrservaciones.Enabled = verObservaciones.Checked
    End Sub

    Private Sub verDetraccionCero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verDetraccionCero.CheckedChanged
        If verDetraccionCero.Checked Then
            decImporteDetraer.Value = 0 : decDetraccion.Value = 0 : decNetoPagar.Value = 0
        Else
            Calcular_Montos()
        End If

    End Sub

    Private Sub txtObrservaciones_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObrservaciones.ValueChanged
        oeMovDocumento.Observacion = txtObrservaciones.Text
    End Sub

    Private Sub cboDirec_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboDirec.EditorButtonClick
        Try
            BandBtn = True
            Dim oecli As New e_Cliente
            Select Case optCliente.CheckedIndex
                Case 0 : oecli = cboCliente2.Rows(cboCliente2.SelectedRow.Index).ListObject
                Case 1 : oecli = cboDestinatario.Rows(cboDestinatario.SelectedRow.Index).ListObject
                Case 2 : oecli = cboOtroCliente.Rows(cboOtroCliente.SelectedRow.Index).ListObject
            End Select
            Dim tip As Integer = oecli.TipoPersonaEmpresa
            Dim idcli As String = IIf(tip = 1, oecli.IdPersona, oecli.IdEmpresa)
            If tip = 1 Then
                Dim frmPersona As New frm_Persona
                frmPersona = frmPersona.getInstancia()
                frmPersona.MdiParent = frm_Menu
                frmPersona.Show()
                frmPersona.AgregarDireccion(idcli)
            Else
                Dim frmEmpresa As New frm_Empresa
                frmEmpresa = frmEmpresa.getInstancia()
                frmEmpresa.MdiParent = frm_Menu
                frmEmpresa.Show()
                frmEmpresa.AgregarDireccion(idcli)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboDestinatario_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboDestinatario.InitializeLayout
        Me.cboDestinatario.ValueMember = "Id"
        Me.cboDestinatario.DisplayMember = "Nombre"
        With cboDestinatario
            For Each colum As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                If colum.Key <> "Nombre" Then
                    colum.Hidden = True
                End If
            Next
            .DisplayLayout.Bands(0).Columns("Nombre").Width = 150
            .Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        End With
    End Sub

    Private Sub cboOtroCliente_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboOtroCliente.InitializeLayout
        Me.cboOtroCliente.ValueMember = "Id"
        Me.cboOtroCliente.DisplayMember = "Nombre"
        With cboOtroCliente
            For Each colum As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                If colum.Key <> "Nombre" Then
                    colum.Hidden = True
                End If
            Next
            .DisplayLayout.Bands(0).Columns("Nombre").Width = 150
            .Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        End With
    End Sub

    Private Sub griDetalleDoc_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griDetalleDoc.DoubleClick
        Dim banderror As Boolean = False
        Try
            If griDetalleDoc.ActiveCell.Column.Key = "FactorRefUni" Then
                Band = True
                BandRuta = True
                oeRuta = New e_Ruta
                oeRuta.IdOrigen = griDetalleDoc.ActiveRow.Cells("IdOrigen").Value
                oeRuta.IdDestino = griDetalleDoc.ActiveRow.Cells("IdDestino").Value
                oeRuta = olRuta.Obtener(oeRuta)
                Dim frmRuta As New frm_Ruta
                frmRuta = frmRuta.getInstancia
                frmRuta.MdiParent = frm_Menu
                frmRuta.Show()
                frmRuta.AgregaFactorRef(oeRuta.Id)
            End If

        Catch ex As Exception
            If banderror Then
                mensajeEmergente.Problema(ex.Message, True)
            Else
                mensajeEmergente.Problema("Esta Columna no puede ser Editada", True)
            End If

        End Try
    End Sub

    Private Sub cboCliente2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente2.ValueChanged
        Try
            'If optCliente.CheckedIndex = 0 AndAlso Not cboCliente2.Value Is Nothing AndAlso cboCliente2.Value <> "" AndAlso cboEstado.Text <> "EMITIDA" Then
            '    If ValidaClienteCombo(cboCliente2.Value) Then CargaDireccionTipoPago()
            '    oeMovDocumento.IdClienteProveedor = cboCliente2.Value
            'End If
            If cboEstado.Text <> "EMITIDA" Then
                If cboCliente2.Text.Trim.Length > 0 Then
                    Dim _oeCliAux As New e_Cliente
                    _oeCliAux.Id = cboCliente2.Value
                    _oeCliAux.Equivale = 1
                    If leCliente.Contains(_oeCliAux) Then
                        CargaDireccionTipoPago()
                        oeMovDocumento.IdClienteProveedor = cboCliente2.Value
                    Else
                        cboDirec.Text = String.Empty
                        cboDirec.DataSource = New List(Of e_Direccion_EmpresaPersona)
                        cboTipoPago.DataSource = Nothing
                        cboTipoPago.SelectedIndex = -1
                    End If
                Else
                    cboDirec.Text = String.Empty
                    cboDirec.DataSource = New List(Of e_Direccion_EmpresaPersona)
                    cboTipoPago.DataSource = Nothing
                    cboTipoPago.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboDestinatario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestinatario.ValueChanged
        Try
            'If optCliente.CheckedIndex = 1 AndAlso Not cboDestinatario.Value Is Nothing AndAlso cboDestinatario.Value <> "" AndAlso cboEstado.Text <> "EMITIDA" Then
            '    If ValidaClienteCombo(cboDestinatario.Value) Then CargaDireccionTipoPago()
            '    oeMovDocumento.IdClienteProveedor = cboDestinatario.Value
            'End If
            If cboEstado.Text <> "EMITIDA" Then
                If cboDestinatario.Text.Trim.Length > 0 Then
                    Dim _oeCliAux As New e_Cliente
                    _oeCliAux.Id = cboDestinatario.Value
                    _oeCliAux.Equivale = 1
                    If leCliente.Contains(_oeCliAux) Then
                        CargaDireccionTipoPago()
                        oeMovDocumento.IdClienteProveedor = cboDestinatario.Value
                    Else
                        cboDirec.Text = String.Empty
                        cboDirec.DataSource = New List(Of e_Direccion_EmpresaPersona)
                        cboTipoPago.DataSource = Nothing
                        cboTipoPago.SelectedIndex = -1
                    End If
                Else
                    cboDirec.Text = String.Empty
                    cboDirec.DataSource = New List(Of e_Direccion_EmpresaPersona)
                    cboTipoPago.DataSource = Nothing
                    cboTipoPago.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboOtroCliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOtroCliente.ValueChanged
        Try
            If cboEstado.Text <> "EMITIDA" Then
                If cboOtroCliente.Text.Trim.Length > 0 Then
                    Dim _oeCliAux As New e_Cliente
                    _oeCliAux.Id = cboOtroCliente.Value
                    _oeCliAux.Equivale = 1
                    If leCliente.Contains(_oeCliAux) Then
                        CargaDireccionTipoPago()
                        oeMovDocumento.IdClienteProveedor = cboOtroCliente.Value
                    Else
                        cboDirec.Text = String.Empty
                        cboDirec.DataSource = New List(Of e_Direccion_EmpresaPersona)
                        cboTipoPago.DataSource = Nothing
                        cboTipoPago.SelectedIndex = -1
                    End If
                Else
                    cboDirec.Text = String.Empty
                    cboDirec.DataSource = New List(Of e_Direccion_EmpresaPersona)
                    cboTipoPago.DataSource = Nothing
                    cboTipoPago.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub optCliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCliente.ValueChanged
        Dim _idcliaux As String = ""
        cboCliente2.Enabled = False
        cboDestinatario.Enabled = False
        cboOtroCliente.Enabled = False
        cboDirec.Text = ""
        cboTipoPago.Text = ""
        Select Case optCliente.CheckedIndex
            Case 0
                If cboCliente2.Rows.Count > 0 Then
                    cboCliente2.Enabled = True
                    cboCliente2.PerformAction(UltraComboAction.FirstRow)
                    _idcliaux = cboCliente2.Value
                End If
            Case 1
                If cboDirec.Rows.Count > 0 Then
                    cboDestinatario.Enabled = True
                    cboDestinatario.PerformAction(UltraComboAction.FirstRow)
                    _idcliaux = cboDestinatario.Value
                End If
            Case 2
                cboOtroCliente.Enabled = True
                _idcliaux = cboOtroCliente.Value
        End Select
        If Not String.IsNullOrEmpty(_idcliaux) Then
            ValidaClienteCombo(_idcliaux)
            CargaDireccionTipoPago()
            oeMovDocumento.IdClienteProveedor = _idcliaux
        End If
        oeMovDocumento.Venta.IndCliente = optCliente.CheckedIndex
    End Sub

    Private Sub verSelecion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verSelecion.CheckedChanged
        Try
            If griFactura.Rows.Count > 0 Then
                If verSelecion.Checked Then
                    Dim idCliSel As String = ""
                    For Each fila As UltraGridRow In griFactura.Rows.Where(Function(item) item.IsFilteredOut = False)
                        If idCliSel <> fila.Cells("Tesoreria").Value Then
                            If idCliSel <> "" Then verSelecion.Checked = False : Throw New Exception("Debe Seleccionar el Mismo Cliente para Facturar")
                            IdCliente = fila.Cells("Tesoreria").Value
                            idCliSel = fila.Cells("Tesoreria").Value
                        End If
                    Next
                End If
                leSelec = New List(Of e_Viaje)
                BandSel = False
                For Each fila As UltraGridRow In griFactura.Rows.Where(Function(item) item.IsFilteredOut = False)
                    fila.Cells("Seleccion").Value = verSelecion.Checked
                    griFactura.UpdateData()
                Next
                BandSel = True
            Else
                verSelecion.Checked = False
                Throw New Exception("No hay Registros para Seleccionar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verCambiaVU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verCambiaVU.CheckedChanged
        Try
            decValorUni.Enabled = verCambiaVU.Checked
            CalculaFlete(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub decValorUni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decValorUni.KeyDown
        If e.KeyCode = Keys.Enter Then
            If decValorUni.Value > 0 Then
                CalculaFlete(True)
            Else
                decValorUni.Value = 0
                mensajeEmergente.Problema("Ingrese Valor Unitario", True)
            End If
        End If
    End Sub

    Private Sub decValorUni_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decValorUni.ValueChanged
        If IsDBNull(decValorUni.Value) Then decValorUni.Value = 0
    End Sub

    Private Sub griDetalleDoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griDetalleDoc.KeyDown
        Try
            If e.KeyCode = Keys.Down Then
                Dim int As Integer = griDetalleDoc.ActiveRow.Index
                If griDetalleDoc.Rows(int).Cells("PrecioUnitario").IsActiveCell Then
                    griDetalleDoc.PerformAction(ExitEditMode, False, False)
                    griDetalleDoc.PerformAction(BelowCell, False, False)
                    e.Handled = True
                    griDetalleDoc.PerformAction(EnterEditMode, False, False)
                End If
                If griDetalleDoc.Rows(Int).Cells("Cantidad").IsActiveCell Then
                    griDetalleDoc.PerformAction(ExitEditMode, False, False)
                    griDetalleDoc.PerformAction(BelowCell, False, False)
                    e.Handled = True
                    griDetalleDoc.PerformAction(EnterEditMode, False, False)
                End If
            End If
            If e.KeyCode = Keys.Up Then
                Dim int As Integer = griDetalleDoc.ActiveRow.Index
                If griDetalleDoc.Rows(int).Cells("PrecioUnitario").IsActiveCell Then
                    griDetalleDoc.PerformAction(ExitEditMode, False, False)
                    griDetalleDoc.PerformAction(AboveCell, False, False)
                    e.Handled = True
                    griDetalleDoc.PerformAction(EnterEditMode, False, False)
                End If
                If griDetalleDoc.Rows(int).Cells("Cantidad").IsActiveCell Then
                    griDetalleDoc.PerformAction(ExitEditMode, False, False)
                    griDetalleDoc.PerformAction(AboveCell, False, False)
                    e.Handled = True
                    griDetalleDoc.PerformAction(EnterEditMode, False, False)
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub colorConDocFac_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorConDocFac.ColorChanged
        etiConDocFac.Appearance.BackColor = colorConDocFac.Color
    End Sub

    Private Sub colorSinDocFac_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorSinDocFac.ColorChanged
        etiSinDoc.Appearance.BackColor = colorSinDocFac.Color
    End Sub

    Private Sub colorDocPerFac_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorDocPerFac.ColorChanged
        etiDocPerFac.Appearance.BackColor = colorDocPerFac.Color
    End Sub

    Private Sub colorSinDocumentos_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorSinDocumentos.ColorChanged
        etiSinDocumentos.Appearance.BackColor = colorSinDocumentos.Color
    End Sub

    Private Sub colorConDocumentosPerdidos_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorConDocumentosPerdidos.ColorChanged
        etiConDocumentosPerdidos.Appearance.BackColor = colorConDocumentosPerdidos.Color
    End Sub

    Private Sub griDocumentoVenta_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griDocumentoVenta.DoubleClick
        If griDocumentoVenta.Rows.Count > 0 AndAlso griDocumentoVenta.ActiveRow.Cells("IdEstadoDocumento").Value <> "1CH00001" Then
            IdDocumento = griDocumentoVenta.ActiveRow.Cells("Id").Value
            Editar()
        End If

    End Sub

    Private Sub ficMaterial_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficMaterial.SelectedTabChanged
        TabLista()
    End Sub

    Private Sub ficFactura_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficFactura.SelectedTabChanged
        If ficFactura.SelectedTab.Index = 0 Then
            TabLista()
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)
        End If
    End Sub

    Private Sub griGuiaTransportista_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGuiaTransportista.CellChange
        Try
            With griGuiaTransportista
                .UpdateData()
                If .ActiveRow.Cells("Selec").Value Then
                    If .ActiveRow.Cells("IndFacturado").Value Then
                        If MessageBox.Show("La Guia Transportista Nº: " & .ActiveRow.Cells("Serie").Value & "-" & .ActiveRow.Cells("Numero").Value & _
                                           " esta Facturada." & Environment.NewLine & "¿Desea Seleccionarla para volverla a Facturar?", _
                                           "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                            .ActiveRow.Cells("Selec").Value = False
                            .UpdateData()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnConsolidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsolidar.Click
        Try
            If griFactura.Rows.Count > 0 Then
                BandSel = False
                For Each fila As UltraGridRow In griFactura.Rows
                    If fila.Cells("UsuarioSeguimiento").Value = "0" Then
                        fila.Cells("Flota").Value = "POR FACTURAR"
                    Else
                        fila.Cells("Flota").Value = "FACTURADO"
                        If fila.Cells("Escala").Value.ToString.Contains("FACT: 001-") Then
                            fila.Cells("Zona").Value = "NATALIA TUESTA"
                        ElseIf fila.Cells("Escala").Value.ToString.Contains("FACT: 002-") Then
                            fila.Cells("Zona").Value = "IRINA RIVAS"
                        Else
                            fila.Cells("Zona").Value = "GOSVINDA CABOS"
                        End If
                    End If
                Next
                griFactura.UpdateData()
                BandSel = True
                mensajeEmergente.Confirmacion("Se Actualizo Correctamente. Listo para la Expotación")
            Else
                Throw New Exception("No hay Registros vuelva a Actualizar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griGuiaRemisionR_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGuiaRemisionR.CellChange
        griGuiaRemisionR.UpdateData()
    End Sub

    Private Sub btnLiquidaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiquidaciones.Click
        oeLiquidacion = New e_Liquidaciones
        oeLiquidacion.TipoOperacion = "F"
        oeLiquidacion.IdCliente = cboOtroCliente.Value
        oeLiquidacion.FechaDesde = fecDesdeLiquidacion.Value
        oeLiquidacion.FechaHasta = fecHastaLiquidacion.Value

        griLiquidacion.DataSource = olLiquidacion.Listar(oeLiquidacion)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLiquidacion.Rows
            Select Case fila.Cells("IndFormato").Value
                Case 0
                    fila.CellAppearance.BackColor = Me.ColorFormato0.Color
                Case 1
                    fila.CellAppearance.BackColor = Me.ColorFormato1.Color
                Case 2
                    fila.CellAppearance.BackColor = Me.ColorFormato2.Color
                Case 3
                    fila.CellAppearance.BackColor = Me.ColorFormato3.Color
                Case 4
                    fila.CellAppearance.BackColor = Me.ColorFormato4.Color
                Case 5
                    fila.CellAppearance.BackColor = Me.ColorFormato5.Color
            End Select
        Next
        CalcularTotales(griLiquidacion, "SubTotal", "Igv", "Total")
    End Sub

    Private Sub griLiquidacion_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLiquidacion.CellChange
        Try
            griLiquidacion.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLiquidacion_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLiquidacion.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griLiquidacion_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLiquidacion.AfterCellUpdate
        Try
            Dim IdOpeDet As String = ""
            Select Case e.Cell.Column.Key.ToUpper
                Case "ACTIVO"
                    With griLiquidacion.Rows(e.Cell.Row.Index)
                        IdOpeDet = .Cells("Id").Value
                        If .Cells("Activo").Value Then
                            .Appearance.BackColor = Color.Aqua
                            '.Fixed = True
                            AgregarCargaLiquidacion(IdOpeDet)
                            decSubTotal.Value = griLiquidacion.ActiveRow.Cells("SubTotal").Value
                            decImpuesto.Value = griLiquidacion.ActiveRow.Cells("Igv").Value
                            decTotal.Value = griLiquidacion.ActiveRow.Cells("Total").Value
                            txtGlosa.Text = " Liquidacion N°: " & griLiquidacion.ActiveRow.Cells("Codigo").Text & " Fecha: " & griLiquidacion.ActiveRow.Cells("Fecha").Text
                            IdLiquidacion = griLiquidacion.ActiveRow.Cells("Id").Value
                            verDetraccionCero.Checked = True
                            verDetraccionCero.Checked = False
                        Else
                            .Appearance.BackColor = Color.White
                            '.Fixed = False
                            QuitarCargaLiquidacion()
                            decSubTotal.Value = 0
                            decImpuesto.Value = 0
                            decTotal.Value = 0
                            txtGlosa.Text = ""
                            verDetraccionCero.Checked = True
                            verDetraccionCero.Checked = False
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            griDetalleDoc.DataBind()
            griGuiaTransportista.DataBind()
            griGuiaRemisionR.DataBind()
        End Try
    End Sub

    Private Sub griDetalleDoc_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDetalleDoc.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If griDetalleDoc.ActiveRow.Cells("Id").Value = "" Then
            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar la aplicación del consolidado?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                VolverAEstadoAnterior(griDetalleDoc.ActiveRow.Cells("IdOperacionDetalle").Value)
                e.Cancel = False
                If ficMaterial.SelectedTab.Index = 0 Then
                    decSubTotal.Value = leDetalleDocOD.Sum(Function(item) item.Valor)
                    decImpuesto.Value = decSubTotal.Value * oeIGV.Porcentaje
                    decTotal.Value = decSubTotal.Value + decImpuesto.Value
                End If
                If Not verDetraccionCero.Checked Then Calcular_Montos()
            End If
        End If
    End Sub

    Private Sub frm_FacturarCarga_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griGuiaTransportista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGuiaTransportista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griGuiaRemisionR_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGuiaRemisionR.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub btnActualizarFleteUnitario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarFleteUnitario.Click
        Dim flete As Double
        If griDetalleDoc.Rows.Count > 0 Then
            flete = decSubTotal.Value / CInt(griDetalleDoc.Rows.Count)
            If MessageBox.Show("Se va actualizar el Valor Unitario del detalle documento por : " & flete, _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griDetalleDoc.Rows
                    IndProrratear = True
                    Fila.Cells("PrecioUnitario").Value = flete
                    griDetalleDoc.UpdateData()
                Next
                ugb_Espera.Visible = False
            End If
        End If
    End Sub

    Private Sub opcFormatoLiquidacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcFormatoLiquidacion.ValueChanged
        cboClaseServicioTottus.Visible = False
        cboClaseServicioTottus.Text = ""
        Select Case opcFormatoLiquidacion.CheckedIndex
            Case 0
                cboOtroCliente.Text = "SUPERMERCADOS PERUANOS S.A."
            Case 1
                cboOtroCliente.Text = "SUPERMERCADOS PERUANOS S.A."
            Case 2
                cboOtroCliente.Text = "SUPERMERCADOS PERUANOS S.A."
            Case 3
                cboOtroCliente.Text = "SUPERMERCADOS PERUANOS S.A."
            Case 4
                cboOtroCliente.Text = "HIPERMERCADOS TOTTUS S.A."
                cboClaseServicioTottus.Visible = True
            Case 5
                cboOtroCliente.Text = "MAESTRO PERU S.A."
            Case 6
                cboOtroCliente.Text = "SAGA FALABELLA SA"
                cboClaseServicioTottus.Visible = True
            Case 7
                cboOtroCliente.Text = "SODIMAC PERU S.A."
                cboClaseServicioTottus.Visible = True
            Case 8
                cboOtroCliente.Text = "SUPERMERCADOS PERUANOS S.A."
        End Select
    End Sub

    Private Sub verUnDetalle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verUnDetalle.CheckedChanged
        If verUnDetalle.Checked Then BandDetalle = verUnDetalle.Checked : verDetalleAdj.Checked = False
        verDetalleAdj.Enabled = verUnDetalle.Checked
    End Sub

    Private Sub griFactura_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griFactura.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub ConfirmaCargaGRT_Click(sender As Object, e As EventArgs) Handles ConfirmaCargaGRT.Click
        With griFactura.ActiveRow
            If .Cells("Id").Value.ToString.Length > 0 Then
                IndDocumentos = False
                Dim formulario As frm_ConfirmarCargaOperacionGRT
                formulario = frm_ConfirmarCargaOperacionGRT
                If formulario.ListarViajeCarga(.Cells("Id").Text, .Cells("IdOrigen").Text) Then formulario.ShowDialog()
                If IndDocumentos Then
                    .CellAppearance.BackColor = Me.ColorCambio.Color
                End If
            End If
        End With
    End Sub

    Private Sub verDosDec_CheckedChanged(sender As Object, e As EventArgs) Handles verDosDec.CheckedChanged
        If verDosDec.Checked Then
            decTotal.Value = Math.Round(decSubTotal.Value, 2) + Math.Round(decImpuesto.Value, 2)
        Else
            decTotal.Value = decSubTotal.Value + decImpuesto.Value
        End If
        Calcular_Montos()
    End Sub

    Private Sub mnuAplicarValorU_Click(sender As Object, e As EventArgs) Handles mnuAplicarValorU.Click
        If griDetalleDoc.ActiveRow IsNot Nothing Then
            If griDetalleDoc.ActiveRow.Cells("IndConsolidado").Value Is Nothing Then
                If griDetalleDoc.ActiveRow.Cells("Consolidado").Value > 0 Then
                    With griDetalleDoc.ActiveRow
                        .Cells("PrecioUnitario").Value = ((.Cells("Valor").Value + .Cells("Consolidado").Value) / .Cells("Cantidad").Value)
                        .Cells("Valor").Value = (.Cells("PrecioUnitario").Value * .Cells("Cantidad").Value)
                        .Cells("IndConsolidado").Value = 2
                        '  .Cells("Consolidado").Column.CellClickAction = CellClickAction.CellSelect
                    End With
                    griDetalleDoc.DataBind()
                    '  griDetalleDoc.UpdateData()
                    If ficMaterial.SelectedTab.Index = 0 Then
                        decSubTotal.Value = leDetalleDocOD.Sum(Function(item) item.Valor)
                        decImpuesto.Value = decSubTotal.Value * oeIGV.Porcentaje
                        'decTotal.Value = Math.Round(decSubTotal.Value, 2) + Math.Round(decImpuesto.Value, 2)
                        decTotal.Value = decSubTotal.Value + decImpuesto.Value
                    End If

                    If Not verDetraccionCero.Checked Then Calcular_Montos()
                Else
                    mensajeEmergente.Confirmacion("Monto de CONSOLIDADO debe ser MAYOR A CERO", True)
                End If
            Else
                mensajeEmergente.Confirmacion("Ya se APLICÓ el monto de CONSOLIDADO", True)
            End If
        Else
            mensajeEmergente.Confirmacion("Debe SELECCIONAR un DETALLE de la lista", True)
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            Dim olCombo As New l_Combo
            Dim oeCombo As New e_Combo

            'Cargar Tracto para Lista
            Dim loVeh As New List(Of e_Vehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = "" : oeVehiculo.Placa = "TODOS"
            loVeh.Add(oeVehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A" : oeVehiculo.Motriz = 1 : oeVehiculo.Activo = 1
            loVeh.AddRange(olVehiculo.Listar(oeVehiculo).OrderBy(Function(item) item.Placa).ToList)
            LlenarCombo(cboTracto, "Placa", loVeh, 0)
            LlenarCombo(cboTracto3, "Placa", loVeh, 0)
            'Cargar Moneda
            oeMoneda = New e_Moneda
            leMoneda = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboMoneda, "Abreviatura", leMoneda, 0)
            'Cargar Cliente
            leCliente = New List(Of e_Cliente)
            oeCliente = New e_Cliente
            oeCliente.TipoClienteProveedor = 1
            leCliente = olCliente.Listar(oeCliente)
            cboOtroCliente.Text = String.Empty
            cboOtroCliente.DataSource = New List(Of e_Cliente)
            cboOtroCliente.DataSource = leCliente
            cboOtroCliente.PerformAction(UltraComboAction.Dropdown)
            'Cargar Tipo de Pago
            oeTipoPago = New e_TipoPago
            oeTipoPago.Activo = True
            leTipoPago = olTipoPago.Listar(oeTipoPago)
            'Cargar Tipo Documento
            oeTipoDoc = New e_TipoDocumento
            Dim olTipoDoc As New l_TipoDocumento
            Dim leTipoDocB As New List(Of e_TipoDocumento)
            oeTipoDoc.TipoOperacion = "F"
            leTipoDoc = olTipoDoc.Listar(oeTipoDoc)
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.Id = "FACBO" : oeTipoDoc.Nombre = "TODOS"
            leTipoDocB.Add(oeTipoDoc)
            leTipoDocB.AddRange(leTipoDoc)
            LlenarCombo(cboTipoDocumento, "Nombre", leTipoDoc, 0)
            LlenarCombo(cboTipoDocB, "Nombre", leTipoDocB, 0)
            'Cargar Estado Factura
            oeEstado = New e_Estado
            oeEstado.Nombre = "FACTURAR"
            leEstado = olEstado.Listar(oeEstado)
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)
            'Cargar Tipo Carga
            oeTipoCarga = New e_TipoCarga
            oeTipoCarga.Activo = True
            leTipoCarga = olTipoCarga.Listar(oeTipoCarga)
            'Cargar Material
            oeMaterial = New e_Material
            oeMaterial.TipoOperacion = "O" : oeMaterial.Activo = True
            leMaterial = olMaterial.Listar(oeMaterial)
            'Cargar Lugar
            oeLugar = New e_Lugar
            oeLugar.Activo = True
            leLugar = olLugar.Listar(oeLugar)
            'Cargar Estado de Carga
            cboFactura.Items.Clear()
            cboFactura.Items.Add("TODOS")
            cboFactura.Items.Add("POR FACTURAR")
            cboFactura.Items.Add("FACTURADOS")
            cboFactura.SelectedIndex = 1
            'Cargar Estado de Documentos
            cboRecuperado.Items.Clear()
            cboRecuperado.Items.Add("TODOS")
            cboRecuperado.Items.Add("SIN DOCUMENTOS")
            cboRecuperado.Items.Add("CON DOCUMENTOS")
            cboRecuperado.Items.Add("DOC. PERDIDOS")
            cboRecuperado.SelectedIndex = 0
            'Cargar Centro
            oeCentro.Abreviatura = "" : oeCentro.Nombre = "TODOS"
            ListaCentro.Add(oeCentro)
            oeCentro = New e_Centro
            oeCentro.TipoOperacion = "O"
            ListaCentro.AddRange(olCentro.Listar(oeCentro))
            LlenarCombo(cboCentro, "Nombre", ListaCentro, 0)
            'Cargar Servicios Venta
            AnioServ = Date.Now.Year
            oeServCtaCtble = New e_ServicioCuentaContable
            oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = AnioServ
            leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)
            'Cargar Asiento Modelo
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
            ' Cargar Cuentas Contables
            mt_CargarCtaContable(ObtenerFechaServidor().Year)

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

            LlenarComboMaestro(cboClienteLista, ClientesPublic, -1)
            oeCombo = New e_Combo
            oeCombo.Nombre = "TODOS"
            ListaTipoCarga.Add(oeCombo)
            ListaTipoCarga.AddRange(TipoCargaPublic)
            LlenarComboMaestro(cboTipoCarga, ListaTipoCarga, 0)
            oeCombo = New e_Combo
            OperacionesPublic = New List(Of e_Combo)
            OperacionesPublic.Add(oeCombo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "VENTAS"
            OperacionesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarComboMaestro(cboActividadNegocioLista, OperacionesPublic, 0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalculaTipoCambio(ByVal Fecha As Date)
        Try
            decTipoCambio.Value = TipoCambio(Fecha, True)(0)
            oeMovDocumento.TipoCambio = decTipoCambio.Value
            oeIGV = New e_Impuesto
            oeIGV = olIGV.IGV(Fecha)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case ficMaterial.SelectedTab.Index
                Case 0
                    Select Case ficCargas.SelectedTab.Index
                        Case 0
                            oeViaje = New e_Viaje
                            ValidarFechaDesde_Hasta(fecDesde, fecHasta)
                            oeViaje.FechaDesde = fecDesde.Value
                            oeViaje.FechaHasta = fecHasta.Value
                            oeViaje.TipoOperacion = "7"
                            oeViaje.IdEstado = cboTracto.Value
                            oeViaje.Centro = cboCentro.Value
                            Select Case cboFactura.SelectedIndex
                                Case 0 : oeViaje.IndMotriz = -1
                                Case 1 : oeViaje.IndMotriz = 0
                                Case 2 : oeViaje.IndMotriz = 1
                            End Select
                            If txtNroGuiaT.Text.Trim <> "" Then oeViaje.Zona = "%" & txtNroGuiaT.Text.Trim & "%"

                            If verViajeRetorno.Checked Then
                                oeViaje.Activo = 1
                            Else
                                oeViaje.Activo = 0
                            End If
                            Select Case cboRecuperado.Text
                                Case "TODOS" : oeViaje.Serie = ""
                                Case "SIN DOCUMENTOS" : oeViaje.Serie = 3
                                Case "CON DOCUMENTOS" : oeViaje.Serie = 1
                                Case "DOC. PERDIDOS" : oeViaje.Serie = 2
                            End Select
                            ObtieneSel()
                            leCargas = olOperacion.ListarViaje(oeViaje).OrderBy(Function(i) i.Fecha).ToList
                            CargarPorFacturar(leCargas, griFactura)
                            CargaSeleccionados()
                        Case 1
                            Dim Tabla As DataSet
                            oeViaje = New e_Viaje
                            With oeViaje
                                .TipoOperacion = "C"
                                .FechaDesde = fecDesde.Value
                                .FechaHasta = fecHasta.Value
                                .Cliente = cboClienteLista.Value
                                .Tracto = cboTracto.Value
                                .TipoVehiculo = cboTipoCarga.Value
                                .FleteUnitario = ValorIgv
                            End With
                            Tabla = olOperacion.ListarViajeProceso(oeViaje)
                            griViajesProceso.DataSource = Tabla.Tables(0)
                            CalcularTotales(griViajesProceso, "KM", "Tarifa", "FleteUnitario", "Flete", "CantidadCarga")
                            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajesProceso.Rows
                                Select Case fila.Cells("IndConfirmadoGrt").Value
                                    Case 1
                                        fila.CellAppearance.BackColor = Me.colorConDocumentos.Color
                                End Select
                            Next

                    End Select
                Case 1
                    IdDocumento = String.Empty
                    ValidarFechaDesde_Hasta(fecDesdeDoc, fecHastaDoc)
                    oeMovDocumento = New e_MovimientoDocumento
                    olMovDocumento = New l_MovimientoDocumento
                    oeMovDocumento.TipoOperacion = "FAC"
                    oeMovDocumento.Activo = True
                    oeMovDocumento.IndCompraVenta = 2
                    oeMovDocumento.IndServicioMaterial = "M"
                    oeMovDocumento.FechaInicio = fecDesdeDoc.Value
                    oeMovDocumento.FechaFinal = fecHastaDoc.Value
                    oeMovDocumento.Serie = txtSerieB.Text
                    oeMovDocumento.Numero = txtNumeroB.Text
                    oeMovDocumento.IdTipoDocumento = cboTipoDocB.Value
                    CargarFacturado(olMovDocumento.Listar(oeMovDocumento))
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub Inicializar(Optional ByVal IndIni As Boolean = True)

        cboTipoDocumento.ReadOnly = True
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        fecDoc.Value = Date.Now.Date
        fecDesdeLiquidacion.Value = Date.Now.Date
        fecHastaLiquidacion.Value = Date.Now.Date
        decSubTotal.Value = 0
        decImpuesto.Value = 0
        decTotal.Value = 0
        decImporteDetraer.Value = 0
        decDetraccion.Value = 0
        decNetoPagar.Value = 0
        verFactorRCero.Checked = False
        verCantidadTn.Checked = False
        verCambiaVU.Checked = False
        decCantTn.Enabled = False
        decValorUni.Enabled = False
        verObservaciones.Checked = False
        txtObrservaciones.Enabled = False
        verDetraccionCero.Checked = False
        verQuitarCant.Checked = False
        verIgv.Checked = True
        verUnDetalle.Checked = False
        verDetalleAdj.Enabled = False
        verDetalleAdj.Checked = False
        txtObrservaciones.Text = String.Empty
        decCantTn.Value = 30
        optCliente.CheckedIndex = -1
        cboCliente2.Text = String.Empty
        cboDestinatario.Text = String.Empty
        cboOtroCliente.Text = String.Empty
        cboCliente2.DataSource = Nothing
        cboDestinatario.DataSource = Nothing
        cboCliente2.DataSource = Nothing
        leDetalleDocOD = New List(Of e_DetalleDoc_OperacionDet)
        CargarDetalle(leDetalleDocOD)
        leGuiaTrans = New List(Of e_GuiaTransportista)
        CargarGuiaTrans(leGuiaTrans)
        leGuiaRemitente = New List(Of e_GuiaRemitente)
        CargarGuiaRemi(leGuiaRemitente)
        txtGlosa.Text = "POR SERVICIO DE TRANSPORTE"
        leDir = New List(Of e_Direccion_EmpresaPersona)
        cboDirec.Text = String.Empty
        cboDirec.DataSource = leDir
        hab_lectura()
        verDosDec.Checked = False
        DecDetraer.Value = 4
        chkElectronico.Enabled = True
        chkElectronico.Checked = True
        txtOrdenCompra.Text = String.Empty
        cboTipoBien.Value = "1SI000000027"
        ChkAnexo.Checked = False
        ChkOcultarProducto.Checked = False
        decAnticipo.Value = 0.0
        cbAnticipo.Checked = False
        lstDocAsoc = New List(Of e_DocumentoAsociado)
        Select Case Operacion

            Case "Nuevo"

                cboTipoDocumento.ReadOnly = BandCaso
                hab_lectura(BandCaso)
                decSubTotal.MaskInput = IIf(BandCaso, "nnnnnnnnn.nn", "nnnnnnnnn.nnnn")
                decImpuesto.MaskInput = IIf(BandCaso, "nnnnnnnnn.nn", "nnnnnnnnn.nnnn")
                decTotal.MaskInput = IIf(BandCaso, "nnnnnnnnn.nn", "nnnnnnnnn.nnnn")
                decSubTotal.FormatString = IIf(BandCaso, "#,##0.00", "#,##0.0000")
                decImpuesto.FormatString = IIf(BandCaso, "#,##0.00", "#,##0.0000")
                decTotal.FormatString = IIf(BandCaso, "#,##0.00", "#,##0.0000")
                optCliente.CheckedIndex = 2
                cboOtroCliente.PerformAction(UltraComboAction.Dropdown)
                cboDirec.PerformAction(UltraComboAction.Dropdown)
                cboTipoPago.SelectedIndex = -1
                cboEstado.Text = "GENERADA"
                Select Case TD
                    Case "F" : cboTipoDocumento.Text = "FACTURA"
                    Case "B" : cboTipoDocumento.Text = "BOLETA DE VENTA"
                End Select
                CalcularPeriodo(fecPeriodo.DateTime.Month, fecPeriodo.DateTime.Year)

                'Case Else

                'decSubTotal.MaskInput = "nnnnnnnnn.nn"
                'decImpuesto.MaskInput = "nnnnnnnnn.nn"
                'decTotal.MaskInput = "nnnnnnnnn.nn"

                'decSubTotal.FormatString = "#,##0.00"
                'decImpuesto.FormatString = "#,##0.00"
                'decTotal.FormatString = "#,##0.00"

        End Select


        If IndIni Then
            cboEstado.SelectedIndex = 0
            oeMovDocumento = New e_MovimientoDocumento
            oeMovDocumento.IndCompraVenta = 2
            oeMovDocumento.FechaEmision = Date.Now.Date
            oeMovDocumento.IdTipoDocumento = cboTipoDocumento.Value
            oeMovDocumento.IdUsuarioCrea = gUsuarioSGI.Id
            oeMovDocumento.IdMoneda = cboMoneda.Value
            oeMovDocumento.TipoCambio = decTipoCambio.Value
            oeMovDocumento.Venta.Glosa = txtGlosa.Value
            oeMovDocumento.Mac_PC_Local = MacPCLocal()
            oeMovDocumento.CadIdGuiasTrans = ""
            oeMovDocumento.EstadoDocumento = cboEstado.Text
            oeMovDocumento.IdAsientoMovimiento = ""
            If ficMaterial.SelectedTab.Index = 0 Then
                oeMovDocumento.CadIdOperacionDet = CadId
            End If
            oeMovDocumento.IndServicioMaterial = "M"
            oeMovDocumento._Operador = 1
            CalcularPeriodo(fecPeriodo.DateTime.Month, fecPeriodo.DateTime.Year)
        End If

    End Sub

    Private Sub CargarDato()

        Try

            cboOtroCliente.Value = IdCliente
            oeMovDocumento.IdClienteProveedor = IdCliente
            CargaDireccionTipoPago()

            oeDetalleDocOpeDet = New e_DetalleDoc_OperacionDet
            oeDetalleDocOpeDet.TipoOperacion = "2"
            oeDetalleDocOpeDet.IdOperacionDet = CadId
            'cambiosss
            leDetalleDocOD = olOperacion.ListarDS(oeDetalleDocOpeDet)
            CargarFactorReferencial(leDetalleDocOD)
            CargarDetalle(leDetalleDocOD)

            oeGuiaTransportista = New e_GuiaTransportista
            oeGuiaTransportista.TipoOperacion = "T"
            oeGuiaTransportista.IdOperacion = CadId
            leGuiaTrans = olGuiaTransportista.ListarDS(oeGuiaTransportista)
            CargarGuiaTrans(leGuiaTrans)

            oeGuiaRemitente = New e_GuiaRemitente
            oeGuiaRemitente.TipoOperacion = "R"
            oeGuiaRemitente.IdOperacion = CadId
            leGuiaRemitente = olGuiaRemitente.ListarDS(oeGuiaRemitente)
            CargarGuiaRemi(leGuiaRemitente)

            oeViaje = New e_Viaje
            oeViaje.TipoOperacion = "F"
            oeViaje.IdEstado = CadId
            leViaje = olOperacion.ListarViaje(oeViaje)
            CargarViajesAsociados(leViaje)

            oeMovDocumento.IdClienteProveedor = IdCliente

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    'cambios
    Private Sub CargarDetalle(ByVal leDDOD As List(Of e_DetalleDoc_OperacionDet))
        Try

            With griDetalleDoc

                .ResetDisplayLayout()
                .DataSource = leDDOD

                CreaCombo_GriDetalle()

                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Cantidad" Or Col.Key = "PrecioUnitario" _
                    Or Col.Key = "IdUnidadMedida" Or Col.Key = "IdMaterialServicio" Or Col.Key = "FactorRefUni" Then
                        Col.CellActivation = Activation.AllowEdit
                        Col.CellClickAction = CellClickAction.EditAndSelectText
                    Else
                        Col.CellActivation = Activation.NoEdit
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                OcultarColumna(griDetalleDoc, True, "Id", "IndGravado", "IdOperacionDetalle", "IdOperacion", "IdComisionista", "IdOrigen", "IdDestino", "MaterialServicio", _
                               "UnidadMedida", "IdMaterial", "IdUnidadCarga", "CantOpe", "IncluyeIgv", "FleteUnitario", "Flete", "PesoToneladas", "Glosa", "Saldo", _
                               "SubTotal", "Igv", "ValorUnit2")

                .DisplayLayout.Bands(0).Columns("FechaViaje").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("NroViaje").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("IdMaterialServicio").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("IdUnidadMedida").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("CantOpe").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("CV").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("FactorRefUni").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("FactorRefTotal").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("Valor").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("Tracto").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("Carreta").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("CantGuia").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("Consolidado").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("NroOperacionOrden").Header.VisiblePosition = 17 '@0001

                .DisplayLayout.Bands(0).Columns("IdOrigen").Header.Caption = "Origen"
                .DisplayLayout.Bands(0).Columns("IdDestino").Header.Caption = "Destino"
                .DisplayLayout.Bands(0).Columns("IdMaterialServicio").Header.Caption = "Material"
                .DisplayLayout.Bands(0).Columns("IdUnidadMedida").Header.Caption = "Tipo Carga"
                .DisplayLayout.Bands(0).Columns("FactorRefUni").Header.Caption = "F.R.U."
                .DisplayLayout.Bands(0).Columns("FactorRefTotal").Header.Caption = "F.R.T."
                .DisplayLayout.Bands(0).Columns("Valor").Header.Caption = "V. Total"
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.Caption = "V. Unitario"
                .DisplayLayout.Bands(0).Columns("CantGuia").Header.Caption = "Peso TN"
                .DisplayLayout.Bands(0).Columns("CantGuia").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("IdOrigen").Width = 180
                .DisplayLayout.Bands(0).Columns("IdDestino").Width = 180
                .DisplayLayout.Bands(0).Columns("FechaViaje").Width = 60
                .DisplayLayout.Bands(0).Columns("Tracto").Width = 55
                .DisplayLayout.Bands(0).Columns("Carreta").Width = 55
                .DisplayLayout.Bands(0).Columns("FactorRefUni").Width = 75
                .DisplayLayout.Bands(0).Columns("FactorRefTotal").Width = 55
                .DisplayLayout.Bands(0).Columns("Valor").Width = 60
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Width = 60
                .DisplayLayout.Bands(0).Columns("Cantidad").Width = 55
                .DisplayLayout.Bands(0).Columns("NroViaje").Width = 95
                .DisplayLayout.Bands(0).Columns("CV").Width = 25
                .DisplayLayout.Bands(0).Columns("Consolidado").Width = 60
                .DisplayLayout.Bands(0).Columns("NroOperacionOrden").Width = 75 '@0001
                .DisplayLayout.Bands(0).Columns("Consolidado").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Consolidado").CellActivation = Activation.AllowEdit
                .DisplayLayout.Bands(0).Columns("Consolidado").CellClickAction = CellClickAction.EditAndSelectText
                .DisplayLayout.Bands(0).Columns("GlosaConsolidado").CellActivation = Activation.AllowEdit
                .DisplayLayout.Bands(0).Columns("GlosaConsolidado").CellClickAction = CellClickAction.EditAndSelectText

                .DisplayLayout.Bands(0).Columns("Cantidad").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("FactorRefUni").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Valor").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Consolidado").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("Cantidad").Format = "##,###,###0.0000"
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Format = "##,###,###0.0000"
                .DisplayLayout.Bands(0).Columns("FactorRefTotal").Format = "#,###,###0.00"

                .DisplayLayout.Bands(0).Columns("Cantidad").MaskInput = "{double:9.4}"
                .DisplayLayout.Bands(0).Columns("Consolidado").MaskInput = "{double:9.4}"
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").MaskInput = "{double:9.4}"

                .DisplayLayout.Bands(0).Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("FactorRefTotal").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("FactorRefUni").CellButtonAppearance.Image = My.Resources.Agregar

                'añadir columnas
                .DisplayLayout.Bands(0).Columns("GlosaConsolidado").Header.Caption = "Glosa"
                .DisplayLayout.Bands(0).Columns("IndConsolidado").Hidden = True

                ColorFondoColumna(griDetalleDoc, Color.LightYellow, "Cantidad", "PrecioUnitario", "IdMaterialServicio", "IdUnidadMedida", "FactorRefUni")

                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1

                If leDDOD.Count > 0 Then
                    CalculaFlete()
                Else
                    decImporteDetraer.Value = decTotal.Value
                End If

                CalcularTotales(griDetalleDoc, "Cantidad", "Valor", "FactorRefTotal")

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarGuiaTrans(ByVal leGT As List(Of e_GuiaTransportista))
        Try
            With griGuiaTransportista

                .ResetDisplayLayout()
                .DataSource = leGT

                ' If cboFactura.SelectedIndex = 0 Then
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 30
                ' End If

                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key <> "IdSubContrata" AndAlso Col.Key.Contains("Id") Then Col.Hidden = True
                    If Col.Key = "Selec" Then
                        Col.CellClickAction = CellClickAction.Edit
                    Else
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                OcultarColumna(griGuiaTransportista, True, "Activo", "IndGrtPerdido", "Incidencia", "UsuarioCreacion", "Remitente", _
                               "Destinatario", "IndDocumentos", "FechaCreacion")

                .DisplayLayout.Bands(0).Columns("Glosa").Header.Caption = "Remitente"
                .DisplayLayout.Bands(0).Columns("SubSerie").Header.Caption = "Direccion Rte."
                .DisplayLayout.Bands(0).Columns("IdSubContrata").Header.Caption = "Destinatario"
                .DisplayLayout.Bands(0).Columns("SubNumero").Header.Caption = "Direccion Dest."
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.Caption = "TN"
                .DisplayLayout.Bands(0).Columns("IndFacturado").Header.Caption = "FAC"
                .DisplayLayout.Bands(0).Columns("IndGrtConfirmada").Header.Caption = "OK"

                .DisplayLayout.Bands(0).Columns("Serie").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("SubSerie").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("IdSubContrata").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("SubNumero").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("IndFacturado").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("IndGrtConfirmada").Header.VisiblePosition = 12

                .DisplayLayout.Bands(0).Columns("Serie").Width = 35
                .DisplayLayout.Bands(0).Columns("Numero").Width = 65
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 60
                .DisplayLayout.Bands(0).Columns("Viaje").Width = 95
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Width = 50
                .DisplayLayout.Bands(0).Columns("IndFacturado").Width = 30
                .DisplayLayout.Bands(0).Columns("IndGrtConfirmada").Width = 30

                .DisplayLayout.Bands(0).Columns("PesoToneladas").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("IndFacturado").Style = ColumnStyle.CheckBox
                .DisplayLayout.Bands(0).Columns("IndGrtConfirmada").Style = ColumnStyle.CheckBox

                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1

                CargaComboGrilla(leGT)

            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarGuiaRemi(ByVal leRR As List(Of e_GuiaRemitente))
        Try
            With griGuiaRemisionR
                .ResetDisplayLayout()
                .DataSource = leRR

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 30

                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key.Contains("Id") Then Col.Hidden = True
                    If Col.Key = "Selec" Then
                        Col.CellClickAction = CellClickAction.Edit
                    Else
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                OcultarColumna(griGuiaRemisionR, True, "Activo", "Viaje", "Glosa")

                .DisplayLayout.Bands(0).Columns("Serie").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("GuiaTransportista").Header.VisiblePosition = 5

                '.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                '.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculaFlete(Optional ByVal Cargar As Boolean = False)
        Try
            Dim oe As New e_Ruta
            If BandRuta Then
                oe.Id = oeRuta.Id
                oe = olRuta.Obtener(oe)
            End If
            For Each Fila As UltraGridRow In griDetalleDoc.Rows
                Dim var As Double = Fila.Cells("Valor").Value
                Fila.Cells("Igv").Value = IIf(Fila.Cells("IncluyeIGV").Value, Fila.Cells("Valor").Value * oeIGV.Porcentaje, 0)
                If BandRuta Then
                    If Fila.Cells("IdOrigen").Value = oe.IdOrigen AndAlso Fila.Cells("IdDestino").Value = oe.IdDestino Then
                        Fila.Cells("FactorRefUni").Value = oe.FactorReferencial
                    End If
                End If
                If Fila.Cells("UnidadMedida").Value <> "TONELADA" Then
                    If verCantidadTn.Checked Then : Fila.Cells("FactorRefTotal").Value = Fila.Cells("FactorRefUni").Value * decCantTn.Value
                    Else : Fila.Cells("FactorRefTotal").Value = Fila.Cells("FactorRefUni").Value * 0
                    End If
                Else
                    Fila.Cells("FactorRefTotal").Value = Fila.Cells("FactorRefUni").Value * Fila.Cells("Cantidad").Value
                End If
                If BandPrecio Then
                    If verCambiaVU.Checked Then
                        Fila.Cells("PrecioUnitario").Value = decValorUni.Value
                    Else
                        Fila.Cells("PrecioUnitario").Value = Fila.Cells("ValorUnit2").Value
                    End If
                End If
            Next

            If BandRuta Then griDetalleDoc.DataBind()
            If Cargar Then griDetalleDoc.DataBind()

            If ficMaterial.SelectedTab.Index = 0 Then
                decSubTotal.Value = leDetalleDocOD.Sum(Function(item) item.Valor)
                decImpuesto.Value = CDbl(decSubTotal.Value) * oeIGV.Porcentaje
                'decTotal.Value = Math.Round(decSubTotal.Value, 2) + Math.Round(decImpuesto.Value, 2)
                decTotal.Value = decSubTotal.Value + decImpuesto.Value
            End If

            If Not verDetraccionCero.Checked Then Calcular_Montos()

            griDetalleDoc.UpdateData()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CreaCombo_GriDetalle()
        'Para Columna de Material
        griDetalleDoc.DisplayLayout.ValueLists.Add("IdMaterialServicio")
        With griDetalleDoc.DisplayLayout.ValueLists("IdMaterialServicio").ValueListItems
            .Clear()
            For Each oeMat As e_Material In leMaterial
                .Add(oeMat.Id, oeMat.Nombre)
            Next
        End With
        CrearComboGrid3("IdMaterialServicio", "Nombre", griDetalleDoc, True)
        'Para Columna de Tipo Carga
        griDetalleDoc.DisplayLayout.ValueLists.Add("IdUnidadMedida")
        With griDetalleDoc.DisplayLayout.ValueLists("IdUnidadMedida").ValueListItems
            .Clear()
            For Each oeTC As e_TipoCarga In leTipoCarga
                .Add(oeTC.Id, oeTC.Nombre)
            Next
        End With
        CrearComboGrid3("IdUnidadMedida", "Nombre", griDetalleDoc, True)
        ''Para Columna de Origen
        'griDetalleDoc.DisplayLayout.ValueLists.Add("IdOrigen")
        'With griDetalleDoc.DisplayLayout.ValueLists("IdOrigen").ValueListItems
        '    .Clear()
        '    For Each oeLug As e_Lugar In leLugar
        '        .Add(oeLug.Id, oeLug.Nombre)
        '    Next
        'End With
        'CrearComboGrid3("IdOrigen", "Nombre", griDetalleDoc, True)
        ''Para Columna de Destino
        'griDetalleDoc.DisplayLayout.ValueLists.Add("IdDestino")
        'With griDetalleDoc.DisplayLayout.ValueLists("IdDestino").ValueListItems
        '    .Clear()
        '    For Each oeLug As e_Lugar In leLugar
        '        .Add(oeLug.Id, oeLug.Nombre)
        '    Next
        'End With
        'CrearComboGrid3("IdDestino", "Nombre", griDetalleDoc, True)
    End Sub

    Private Function Guardando() As Boolean
        Try
            'Cargar Direccion
            ' Dim oe As New e_Direccion_EmpresaPersona
            Dim c_sel As Integer = 0, c_monto As Integer = 0
            'VALIDAR APLICACIÓN DE ANTICIPOS
            If b_anticipo Then
                c_sel = griAnticipos.Rows.Where(Function(x) x.Cells("Seleccionar").Value = True).Count
                c_monto = griAnticipos.Rows.Where(Function(x) x.Cells("MontoOperar").Value > 0.0).Count
                If c_sel < 1 Then Throw New Exception("No puede aplicar un anticipo sino ha seleccionado los documentos de anticipos.")
                If decAnticipo.Value = 0 Then Throw New Exception("No puede aplicar un anticipo con monto igual a 0.")
                If c_monto < c_sel Then Throw New Exception("No puede aplicar un anticipo porque el Monto a Operar de uno o más documentos seleccionados es 0.")
                If decAnticipo.Value > leDetalleDocOD.Sum(Function(x) x.SubTotal) Then Throw New Exception("No puede aplicar un anticipo con monto mayor al subtotal.")
            End If
            If cboEstado.Text = "GENERADA" Then
                oeMovDocumento.Numero = FormatoDocumento(txtNumero.Text, 10)
                oeMovDocumento.IndElectronico = chkElectronico.Checked
            End If

            Dim oe = cboDirec.Rows(cboDirec.SelectedRow.Index).ListObject
            oeMovDocumento.SubTotal = Math.Round(decSubTotal.Value, 4)
            oeMovDocumento.Venta.IdDireccion = oe.IdDireccion
            oeMovDocumento.Venta.IndCliente = optCliente.CheckedIndex
            oeMovDocumento.lstDetalleDocumento = ObtieneDetalleDoc(leDetalleDocOD)
            oeMovDocumento.Venta.FactorRefUni = IIf(verCantidadTn.Checked, decCantTn.Value, 0)
            oeMovDocumento.Venta.Gravado = IIf(cboMoneda.Value <> "1CH01", Math.Round(oeMovDocumento.SubTotal * decTipoCambio.Value, 4), oeMovDocumento.SubTotal)
            oeMovDocumento.IGV = Math.Round(decImpuesto.Value, 4)
            oeMovDocumento.Venta.IGV = IIf(cboMoneda.Value <> "1CH01", Math.Round(oeMovDocumento.IGV * decTipoCambio.Value, 4), oeMovDocumento.IGV)
            oeMovDocumento.Total = Math.Round(decTotal.Value, 4)
            oeMovDocumento.Saldo = Math.Round(decTotal.Value, 4)
            oeMovDocumento.IdTipoBien = cboTipoBien.Value
            oeMovDocumento.OrdenCompra = txtOrdenCompra.Text
            oeMovDocumento.IndAnexo = ChkAnexo.Checked
            oeMovDocumento.IndDetalleGlosa = ChkOcultarProducto.Checked

            If cboTipoDocumento.Text = "FACTURA" Then
                oeMovDocumento.Venta.Detraccion = decDetraccion.Value
                oeMovDocumento.Venta.SaldoDetraccion = decDetraccion.Value
                If DecDetraer.Value > 0 Then
                    oeMovDocumento.Venta.PorcenDetra = DecDetraer.Value
                Else
                    oeMovDocumento.Venta.PorcenDetra = 0
                End If
            End If
            ' oeMovDocumento.IdClienteProveedor
            oeMovDocumento.Venta.IdTipoPago = cboTipoPago.Value
            oeMovDocumento.IdLiquidacion = IdLiquidacion
            If txtGlosa.Text.Trim <> "" Then
                oeMovDocumento.Venta.Glosa = txtGlosa.Text.Trim
                If verObservaciones.Checked AndAlso txtObrservaciones.Text.Trim <> "" Then
                    oeMovDocumento.Venta.Glosa = oeMovDocumento.Venta.Glosa & "&" & txtObrservaciones.Text
                End If
            End If

            If CadIdGT.Trim.Length > 0 Then oeMovDocumento.CadIdGuiasTrans = CadIdGT.Substring(0, CadIdGT.Length - 1)

            'MONTOS QUE SE SE HARÁ EFECTO POR ANTICIPO Y ASOCIAR DOCUMENTOS
            If cbAnticipo.Checked Then
                oeMovDocumento.IndAfectaAnticipo = True
                oeMovDocumento.Monto_Anticipo = decAnticipo.Value
                oeMovDocumento.IndAnticipo = False
                Dim lstDocAsoc_Aux As New List(Of e_DocumentoAsociado)
                If oeMovDocumento.TipoOperacion <> "I" Then
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
                    oeDocAsoc.PrefijoID = gs_PrefijoIdSucursal '@0001
                    lstDocAsoc.Add(oeDocAsoc)
                Next
                If oeMovDocumento.TipoOperacion <> "I" Then
                    For Each doc_ant_el In lstDocAsoc_Aux
                        If lstDocAsoc.Where(Function(x) x.IdMovimientoDocumentoAsoc.IndexOf(doc_ant_el.IdMovimientoDocumentoAsoc) <> -1).Count = 0 Then
                            oeDocAsoc = New e_DocumentoAsociado
                            oeDocAsoc.TipoOperacion = "E"
                            oeDocAsoc.Id = doc_ant_el.Id
                            oeDocAsoc.PrefijoID = gs_PrefijoIdSucursal '@0001
                            lstDocAsoc.Add(oeDocAsoc)
                        End If
                    Next
                End If
                oeMovDocumento.DocAsoc = lstDocAsoc
                Dim total_st As Double = oeMovDocumento.lstDetalleDocumento.Sum(Function(x) (x.Total - x.Igv))
                Dim cant_st As Double = oeMovDocumento.lstDetalleDocumento.Count, cont As Integer = 0
                Dim total_antic As Double = oeMovDocumento.Monto_Anticipo
                For Each detalle In oeMovDocumento.lstDetalleDocumento
                    cont += 1
                    If cont < cant_st Then
                        detalle.Monto_Anticipo = Math.Round(oeMovDocumento.Monto_Anticipo * IIf(detalle.Total = 0, 0, ((detalle.Total - detalle.Igv) / total_st)), 2)
                        total_antic = total_antic - detalle.Monto_Anticipo
                    Else
                        detalle.Monto_Anticipo = Math.Round(total_antic, 2)
                        total_antic = 0
                    End If
                    detalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                Next
            Else
                oeMovDocumento.IndAfectaAnticipo = False
                oeMovDocumento.Monto_Anticipo = 0.0
                If oeMovDocumento.TipoOperacion <> "I" Then
                    oeDocAsoc = New e_DocumentoAsociado
                    oeDocAsoc.TipoOperacion = "T"
                    oeDocAsoc.IdMovimientoDocumento = oeMovDocumento.Id
                    lstDocAsoc = New List(Of e_DocumentoAsociado)
                    oeDocAsoc.PrefijoID = gs_PrefijoIdSucursal '@0001
                    lstDocAsoc = olDocAsoc.Listar(oeDocAsoc)
                    For Each doc_ant_el In lstDocAsoc
                        doc_ant_el.TipoOperacion = "E"
                        doc_ant_el.PrefijoID = gs_PrefijoIdSucursal '@0001
                    Next
                    oeMovDocumento.DocAsoc = lstDocAsoc
                End If
            End If
            oeMovDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMovDocumento.GuardarMasivo(oeMovDocumento) Then
                leDetalleDocOD = New List(Of e_DetalleDoc_OperacionDet)
                If cboEstado.Text = "GENERADA" Then
                    If MessageBox.Show("La Información ha sido grabada satisfactoriamente en " & Me.Text & Environment.NewLine _
                                   & "¿Desea Continuar Modificando el Documento?", "Mensaje del sistema", MessageBoxButtons.YesNo _
                                   , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        'Emitir()
                        'MostrarTabs(0, ficFactura, 0)
                        IdDocumento = oeMovDocumento.Venta.IdMovimientoDocumento
                        Editar()
                    Else
                        'mensajeEmergente.Confirmacion("La Información ha sido grabada satisfactoriamente en " & Me.Text & Environment.NewLine, True)
                        'CambiarEstadoCarga(leSelec)
                        leSelec = New List(Of e_Viaje)
                        verSelecion.Checked = False
                        Consultar(_Activo)
                        MostrarTabs(0, ficFactura, 0)
                        griFactura.Focus()
                    End If
                Else
                    mensajeEmergente.Confirmacion("La Información ha sido grabada satisfactoriamente en " & Me.Text & Environment.NewLine, True)
                    'CambiarEstadoCarga
                    leSelec = New List(Of e_Viaje)
                    verSelecion.Checked = False
                    Consultar(_Activo)
                    MostrarTabs(0, ficFactura, 0)
                    griFactura.Focus()
                End If
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function ObtieneDetalleDoc(ByVal leOD As List(Of e_DetalleDoc_OperacionDet)) As List(Of e_DetalleDocumento)
        Dim le As New List(Of e_DetalleDocumento)
        Dim oeDDGT As New e_DetalleDoc_GuiaTrans
        Dim Band As Boolean = True
        Dim IdOD As String = ""
        CadIdGT = ""
        For Each oeOpeDet As e_DetalleDoc_OperacionDet In leOD
            If oeOpeDet.Id = "" Then
                oeDetalleDoc = New e_DetalleDocumento
                oeDetalleDoc.IndServicioMaterial = "M"
                oeDetalleDoc.IdMaterialServicio = oeOpeDet.IdMaterialServicio
                oeDetalleDoc.Cantidad = oeOpeDet.Cantidad
                oeDetalleDoc.IdVehiculo = oeOpeDet._IdVehiculo
                oeDetalleDoc.Precio = oeOpeDet.PrecioUnitario
                'oeDetalleDoc.IndGravado = oeOpeDet.IncluyeIgv
                'oeDetalleDoc.Igv = Math.Round(oeOpeDet.Igv, 4)
                oeDetalleDoc.IndGravado = 1
                oeDetalleDoc.Igv = Math.Round(oeOpeDet.Valor * oeIGV.Porcentaje, 4)
                oeDetalleDoc.Total = oeOpeDet.Valor
                oeDetalleDoc.IdOperacionDetalle = oeOpeDet.IdOperacionDetalle
                oeDetalleDoc.Activo = 1
                oeDetalleDoc.FechaCreacion = Date.Now
                oeDetalleDoc.UsuarioCreacion = gUsuarioSGI.Id
                oeDetalleDoc.IdUnidadMedida = oeOpeDet.IdUnidadMedida
                oeDetalleDoc.FactorRefUni = oeOpeDet.FactorRefUni
                oeDetalleDoc.Consolidado = oeOpeDet.Consolidado
                oeDetalleDoc.GlosaConsolidado = oeOpeDet.GlosaConsolidado
                oeDetalleDoc.IndConsolidado = oeOpeDet.IndConsolidado

                IdOD = IdOD & "'" & oeDetalleDoc.IdOperacionDetalle & "',"

                For Each oeGT As e_GuiaTransportista In leGuiaTrans
                    If Band Then CadIdGT = CadIdGT & "'" & oeGT.Id & "',"
                    If oeDetalleDoc.IdOperacionDetalle = oeGT.IdOperacionDetalle Then
                        oeDDGT = New e_DetalleDoc_GuiaTrans
                        oeDDGT.IdGuiaTrans = oeGT.Id
                        oeDDGT.Activo = 1
                        oeDDGT.FechaCreacion = Date.Now
                        oeDDGT.UsuarioCreacion = gUsuarioSGI.Id
                        oeDetalleDoc.leDetalleGuiaTrans.Add(oeDDGT)
                    End If
                Next

                Band = False
                le.Add(oeDetalleDoc)
            End If

        Next
        If IdOD.Trim.Length > 0 Then
            oeMovDocumento.CadIdOperacionDet = IdOD.Substring(0, IdOD.Length - 1)
        End If

        Return le
    End Function

    Private Sub CalcularPeriodo(ByVal Mes As Integer, ByVal Anio As Integer)
        Try
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            oePeriodo.Ejercicio = Anio
            oePeriodo.Mes = Mes
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            oeMovDocumento.IdPeriodo = oePeriodo.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPorFacturar(ByVal leViaje As List(Of e_Viaje), ByVal Grilla As UltraGrid, Optional ByVal Band As Boolean = True)

        With Grilla
            'Dim bandc As Boolean = False
            'If TipoConsulta <> cboFactura.Text Then
            '    TipoConsulta = cboFactura.Text
            ' bandc = True
            If bandload Then
                .ResetDisplayLayout()
                .DisplayLayout.ViewStyle = ViewStyle.SingleBand
            End If
            .DataSource = leViaje
            If bandload Then
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    'Or Col.Header.Caption.Contains("Salida") _
                    'Or Col.Header.Caption.Contains("Incidencia") _
                    If Col.Header.Caption.Contains("Id") _
                    Or Col.Header.Caption.Contains("Llegada") _
                    Or Col.Header.Caption.Contains("Usuario") _
                    Or Col.Header.Caption.Contains("Disponible") _
                    Then Col.Hidden = True : Col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    If Col.Header.Caption = "Seleccion" Then
                        Col.CellActivation = Activation.AllowEdit
                        Col.CellClickAction = CellClickAction.Edit
                    Else
                        Col.CellActivation = Activation.NoEdit
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                ExcluirColumna(Grilla, "CargaOrigen", "DescargaDestino", "DiaNoche", "ImpresionGuiaOrigen", "IndEscala", _
                               "IndFecha", "IngresoComplejoOrigen", "IngresoDestino", "KmTractoOrigen", "KmTractoDestino", "TerminoCargaOrigen", _
                               "TerminoDescargaDestino", "Tesoreria", "Turno", "ViajeVacio", "SalidaDestino")

                OcultarColumna(Grilla, True, "Tesoreria", "ViajeVacio", "Turno", "DiaNoche", "Carga", "Flota", "Zona", "IndFecha", "PorcentajeFlete", _
                               "IndEscala", "GlosaEscala", "KmTractoOrigen", "IngresoComplejoOrigen", "CargaOrigen", "TerminoCargaOrigen", "ImpresionGuiaOrigen", _
                               "IngresoDestino", "DescargaDestino", "TerminoDescargaDestino", "Operacion", "Estado", "KmTractoDestino", "Copiloto", "Ayudante", _
                               "SalidaDestino", "Capacidad", "IndCarga", "Produccion", "Cantidad", "FleteUnitario", "IncluyeIgv", "IncidenciaOperaciones", "TipoCambio")

                'If Prefijo.PrefijoID = "1CH" Then '@0001
                'If gs_PrefijoIdSucursal = "1CH" Then '@0001
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Piloto").Hidden = True
                'End If

                '.DisplayLayout.Bands(0).Columns("Fecha").SortIndicator = SortOrder.Ascending

                .DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("SalidaOrigen").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Tracto").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Carreta").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("CargaMaterial").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("KmCarretaOrigen").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("KmCarretaDestino").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("Subtotal").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("TotalFlete").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("TotalFleteConv").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("MonedaOp").Header.VisiblePosition = 17
                .DisplayLayout.Bands(0).Columns("Consolidado").Header.VisiblePosition = 18
                .DisplayLayout.Bands(0).Columns("Subtotal").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Consolidado").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("TotalFleteConv").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Piloto").Header.VisiblePosition = 19
                .DisplayLayout.Bands(0).Columns("Escala").Header.VisiblePosition = 20

                .DisplayLayout.Bands(0).Columns("KmCarretaOrigen").Header.Caption = "Cantidad"
                .DisplayLayout.Bands(0).Columns("KmCarretaDestino").Header.Caption = "Precio"
                .DisplayLayout.Bands(0).Columns("SalidaOrigen").Header.Caption = "Fec. Salida Carga"
                .DisplayLayout.Bands(0).Columns("Operacion").Header.Caption = "Nº Operacion"
                .DisplayLayout.Bands(0).Columns("Codigo").Header.Caption = "Nº Viaje"
                .DisplayLayout.Bands(0).Columns("Fecha").Header.Caption = "Fecha Viaje"
                .DisplayLayout.Bands(0).Columns("Estado").Header.Caption = "Est. Viaje"
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.Caption = "Peso Ton."
                .DisplayLayout.Bands(0).Columns("Escala").Header.Caption = "Documentos"
                .DisplayLayout.Bands(0).Columns("Flota").Header.Caption = "Tipo Carga"
                .DisplayLayout.Bands(0).Columns("Zona").Header.Caption = "Glosa GRT"
                .DisplayLayout.Bands(0).Columns("IncidenciaOperaciones").Header.Caption = "Codigo Semana"
                .DisplayLayout.Bands(0).Columns("IncidenciaSeguimiento").Header.Caption = "Comisionista"
                .DisplayLayout.Bands(0).Columns("TotalFleteConv").Header.Caption = "Total Flete (S/.)"
                .DisplayLayout.Bands(0).Columns("MonedaOp").Header.Caption = "M.O."
                .DisplayLayout.Bands(0).Columns("Seleccion").Width = 30
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 93
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 100
                .DisplayLayout.Bands(0).Columns("Cliente").Width = 150
                .DisplayLayout.Bands(0).Columns("Tracto").Width = 53
                .DisplayLayout.Bands(0).Columns("Carreta").Width = 53
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Width = 55
                .DisplayLayout.Bands(0).Columns("KmCarretaOrigen").Width = 55
                .DisplayLayout.Bands(0).Columns("Piloto").Width = 150
                .DisplayLayout.Bands(0).Columns("Escala").Width = 150
                .DisplayLayout.Bands(0).Columns("MonedaOp").Width = 30
                .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "Tercerizac"
                .DisplayLayout.Bands(0).Columns("IncidenciaSeguimiento").Header.Caption = "FlotaTracto"

                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.Fixed = True
                If Band Then
                    .DisplayLayout.Bands(0).Columns("Codigo").Header.Fixed = True
                    .DisplayLayout.Bands(0).Columns("Fecha").Header.Fixed = True
                    .DisplayLayout.Bands(0).Columns("Cliente").Header.Fixed = True
                End If

                .DisplayLayout.Bands(0).Columns("Fecha").Style = ColumnStyle.DateTime
                .DisplayLayout.Bands(0).Columns("SalidaOrigen").Style = ColumnStyle.DateTime

                FormatoColumna(Grilla, "#,##0.000", ColumnStyle.Double, HAlign.Right, "TotalFlete", "KmCarretaDestino", "PesoToneladas", "KmCarretaOrigen", "Subtotal", "Consolidado", "TotalFleteConv")

                .DisplayLayout.Bands(0).Columns("Operacion").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("Codigo").CellAppearance.TextVAlign = VAlign.Middle

                .DisplayLayout.Bands(0).Columns("Codigo").MergedCellStyle = MergedCellStyle.Always

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End If

            CalcularTotales(Grilla, "PesoToneladas", "TotalFlete", "Subtotal", "Consolidado", "TotalFleteConv")

            If griFactura.Rows.Count > 0 Then
                If Not BandLista Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                For Each Fila As UltraGridRow In Grilla.Rows
                    Select Case Fila.Cells("UsuarioSeguimiento").Value
                        Case "0"
                            Select Case Fila.Cells("GlosaEscala").Value
                                Case "3" : Fila.Appearance.BackColor = colorSinDocumentos.Color
                                Case "1" : Fila.Appearance.BackColor = colorConDocumentos.Color
                                Case "2" : Fila.Appearance.BackColor = colorConDocumentosPerdidos.Color
                            End Select
                        Case "1"
                            Select Case Fila.Cells("GlosaEscala").Value
                                Case "3" : Fila.Appearance.BackColor = colorSinDocFac.Color
                                Case "1" : Fila.Appearance.BackColor = colorConDocFac.Color
                                Case "2" : Fila.Appearance.BackColor = colorDocPerFac.Color
                            End Select
                        Case "2"
                            Fila.Appearance.BackColor = colorRestablecido.Color
                    End Select
                Next
            Else
                If Not BandLista Then ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        End With
    End Sub

    Private Sub CargarFacturado(ByVal loFacturados As List(Of e_MovimientoDocumento))
        Try
            With griDocumentoVenta
                'Dim bandf As Boolean = False
                'If TipoConsulta <> cboFactura.Text Then
                '    TipoConsulta = cboFactura.Text
                ' bandf = True
                If bandload Then
                    .ResetDisplayLayout()
                    .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                End If
                'End If
                .DataSource = loFacturados
                If bandload Then
                    CreaCombo_griFactura()
                    For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                        If Col.Header.Caption.Contains("Id") AndAlso _
                        Col.Header.Caption <> "IdMoneda" AndAlso _
                        Col.Header.Caption <> "IdEstadoDocumento" AndAlso _
                        Col.Header.Caption <> "IdTipoDocumento" Then Col.Hidden = True
                    Next
                    OcultarColumna(griDocumentoVenta, True, "NombreDocumento", "MontoOperar", "IndCompraVenta", "FechaCreacion", "AbreviaturaMoneda", _
                                   "Moneda", "TipoPago", "EstadoDocumento", "Activo", "Percepcion", "IndServicioMaterial", "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "MontoOperar", "Retencion", "IndAnexo", "CodMotivo", "MontoCanje", "IndAnticipo")
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
                    .DisplayLayout.Bands(0).Columns("Neto").Header.VisiblePosition = 16
                    .DisplayLayout.Bands(0).Columns("IdEstadoDocumento").Header.VisiblePosition = 17
                    .DisplayLayout.Bands(0).Columns("Monto_Anticipo").Header.VisiblePosition = 15

                    .DisplayLayout.Bands(0).Columns("Serie").Width = 30
                    .DisplayLayout.Bands(0).Columns("Numero").Width = 65
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 70
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 25
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

                    FormatoColumna(griDocumentoVenta, "#,##0.00", ColumnStyle.Double, HAlign.Right, "IGV", "SubTotal", "Total", "Saldo", "SaldoDetraccion", "Neto", "Monto_Anticipo")

                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                    .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect

                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1

                End If

                CalcularTotales(griDocumentoVenta, "Saldo")

                For Each Fila As UltraGridRow In .Rows
                    If Fila.Cells("DiasVen").Value > 0 Then
                    Else
                        If Fila.Cells("DiasVen").Value >= -1 * numFaltan.Value Then Fila.Appearance.BackColor = colorPorVencer.Color
                    End If
                Next

                If griDocumentoVenta.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CreaCombo_griFactura()
        'Para Columna de Moneda
        griDocumentoVenta.DisplayLayout.ValueLists.Add("IdMoneda")
        With griDocumentoVenta.DisplayLayout.ValueLists("IdMoneda").ValueListItems
            .Clear()
            For Each oeTD As e_Moneda In leMoneda
                .Add(oeTD.Id, oeTD.Abreviatura)
            Next
        End With
        CrearComboGrid3("IdMoneda", "Abreviatura", griDocumentoVenta, True)
        'Para Columna de Estado Documento
        griDocumentoVenta.DisplayLayout.ValueLists.Add("IdEstadoDocumento")
        With griDocumentoVenta.DisplayLayout.ValueLists("IdEstadoDocumento").ValueListItems
            .Clear()
            For Each oeEs As e_Estado In leEstado
                .Add(oeEs.Id, oeEs.Nombre)
            Next
        End With
        CrearComboGrid3("IdEstadoDocumento", "Nombre", griDocumentoVenta, True)
        'Para Columna de Tipo Documento
        griDocumentoVenta.DisplayLayout.ValueLists.Add("IdTipoDocumento")
        With griDocumentoVenta.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
            .Clear()
            For Each oeTD As e_TipoDocumento In leTipoDoc
                .Add(oeTD.Id, oeTD.Nombre)
            Next
        End With
        CrearComboGrid3("IdTipoDocumento", "TipoDocumento", griDocumentoVenta, True)
    End Sub

    Private Sub Mostrar()
        Try
            iEstado = String.Empty
            Dim ImporteDetraer As Double = 0
            Inicializar(False)
            oeMovDocumento = New e_MovimientoDocumento
            oeMovDocumento.CargarCompleto = True
            oeMovDocumento.Id = IdDocumento
            oeMovDocumento = olMovDocumento.ObtenerVenta(oeMovDocumento)
            If Oper = "Anular" AndAlso Math.Round(oeMovDocumento.Saldo, 2) <> Math.Round(oeMovDocumento.Total, 2) Then
                Throw New Exception("No puede Anular este documento por que tiene cobros asociados")
            End If
            If Oper = "Emitir" AndAlso oeMovDocumento.lstDetalleDocumento.Count = 0 Then
                Throw New Exception("No se Puede Emitir el Documento por que no tiene Detalle")
            End If
            iEstado = oeMovDocumento.IdEstadoDocumento
            With oeMovDocumento
                cboTipoDocumento.Value = .IdTipoDocumento
                If cboTipoDocumento.Text = "FACTURA" Then TD = "F"
                chkElectronico.Checked = .IndElectronico
                txtOrdenCompra.Text = .OrdenCompra
                cboTipoBien.Value = .IdTipoBien
                ChkAnexo.Checked = .IndAnexo
                ChkOcultarProducto.Checked = .IndDetalleGlosa
                txtSerie.Text = .Serie
                txtNumero.Text = .Numero
                cboEstado.Value = .IdEstadoDocumento
                decTipoCambio.Value = .TipoCambio
                cboMoneda.Value = .IdMoneda
                fecDoc.Value = .FechaEmision
                Dim parteGlosa As String()
                parteGlosa = .Venta.Glosa.Split("&")
                If parteGlosa.Length > 0 Then
                    txtGlosa.Text = parteGlosa(0)
                    If parteGlosa.Length > 1 Then
                        .Observacion = parteGlosa(1)
                        verObservaciones.Checked = IIf(.Observacion = "", False, True)
                        txtObrservaciones.Text = .Observacion
                    End If
                End If
                decSubTotal.Value = .SubTotal
                decImpuesto.Value = .IGV
                decTotal.Value = .Total
                TotalFlete = Math.Round(decTotal.Value, 2)
                verDetraccionCero.Checked = IIf(.Venta.Detraccion = 0, True, False)
                DecDetraer.Value = .Venta.PorcenDetra
                decDetraccion.Value = .Venta.Detraccion
                Dim _neto As Double = Math.Round(TotalFlete - decDetraccion.Value, 2)
                decNetoPagar.Value = IIf(.Venta.Detraccion = 0, 0, _neto)
                verCantidadTn.Checked = IIf(.Venta.FactorRefUni > 0, True, False)
                decCantTn.Value = .Venta.FactorRefUni
                leDetalleDocOD = .leDetalleDocOperDet
                CargarDetalle(leDetalleDocOD)
                Dim _idcliente As String = .IdClienteProveedor
                leGuiaTrans = .leGRT
                CargarGuiaTrans(leGuiaTrans)
                leGuiaRemitente = .leGRR
                CargarGuiaRemi(leGuiaRemitente)
                optCliente.CheckedIndex = .Venta.IndCliente
                Select Case .Venta.IndCliente
                    Case 0 : cboCliente2.Value = _idcliente
                    Case 1 : cboDestinatario.Value = _idcliente : If .leGRT(0).IdDestinatario <> _idcliente Then Throw New Exception("El Destinatario no coincide Con el Cliente, Revisar La Guia de Transportista") 'IIf(.leGRT(0).IdDestinatario = _idcliente, _idcliente, .leGRT(0).IdDestinatario) SE HIZO LA PRUEBA PARA CORREGIR ANULACIÓN - 29/08/2017
                    Case 2 : cboOtroCliente.Value = _idcliente
                End Select
                CargaDireccionTipoPago()
                cboDirec.Value = .Venta.IdDireccion
                cboTipoPago.Value = .Venta.IdTipoPago
                EditaDoc(IIf(cboEstado.Text = "EMITIDA", True, False))
                bandload = True
                CargarPorFacturar(New List(Of e_Viaje), griListaCarga, False)
                bandload = False
                decSubTotal.FormatString = "#,##0.00"
                decImpuesto.FormatString = "#,##0.00"
                decTotal.FormatString = "#,##0.00"
                cbAnticipo.Checked = .IndAfectaAnticipo
                decAnticipo.Value = .Monto_Anticipo
                If .IndAfectaAnticipo Then
                    Cargar_Anticipos_Check()
                    Seleccionar_Anticipos()
                    decAnticipo.Value = Calcular_Monto_Anticipo()
                    CalcularSubtotalesTotalesMaterial()
                End If
            End With

            ficDetalle.SelectedTab = ficDetalle.Tabs(0)
            MostrarTabs(1, ficFactura)
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Seleccionar_Anticipos()
        oeDocAsoc = New e_DocumentoAsociado
        oeDocAsoc.TipoOperacion = "T"
        oeDocAsoc.IdMovimientoDocumento = oeMovDocumento.Id
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

    Private Sub GenerarDoc()
        Try
            CadId = ""
            Dim i As Integer = 0
            For Each Fila As UltraGridRow In griFactura.Rows.Where(Function(item) item.IsFilteredOut = False)
                If Fila.Cells("Seleccion").Value Then
                    CadId = CadId & "'" & Fila.Cells("Id").Value & "',"
                End If
            Next
            If CadId <> "" Then
                ObtieneSel()
                CadId = CadId.Substring(0, CadId.Length - 1)
                Inicializar()
                CargarDato()
                ficDetalle.SelectedTab = ficDetalle.Tabs(0)
                VistaPrevia = True
                BandDetalle = False
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
                MostrarTabs(1, ficFactura, 1)
                EditaDoc(IIf(cboEstado.Text = "EMITIDA", True, False))
            Else
                Throw New Exception("Seleccione al menos Una Carga")
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HabilitaDetalle(ByVal Band As Boolean)
        agrDetraccion.Visible = Band
        decSubTotal.Visible = Band
        decImpuesto.Visible = Band
        etiSubtotal.Visible = Band
        etiImpuesto.Visible = Band
        verFactorRCero.Visible = Band
        verDetraccionCero.Visible = Band
        agrTipoBien.Visible = Band
    End Sub

    Private Sub CargaDetalleDoc(ByVal le As List(Of e_DetalleDocumento))
        Try
            With griDetalleDoc
                .ResetDisplayLayout()
                .DataSource = le

                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key.Contains("Id") Then Col.Hidden = True
                    If Col.Key = "Cantidad" Or Col.Key = "Precio" Then
                        Col.CellActivation = Activation.AllowEdit
                        Col.CellClickAction = CellClickAction.Edit
                    Else
                        Col.CellActivation = Activation.NoEdit
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("IndServicioMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndGravado").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Pos").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("CodigoMaterialServicio").Hidden = True
                .DisplayLayout.Bands(0).Columns("PrecioUnitarioConImp").Hidden = True
                .DisplayLayout.Bands(0).Columns("Igv").Hidden = True
                .DisplayLayout.Bands(0).Columns("Subtotal").Hidden = True

                .DisplayLayout.Bands(0).Columns("NombreMaterialServicio").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("UnidadMedida").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Precio").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 5

                .DisplayLayout.Bands(0).Columns("NombreMaterialServicio").Header.Caption = "Material"
                .DisplayLayout.Bands(0).Columns("UnidadMedida").Header.Caption = "Carga"

                .DisplayLayout.Bands(0).Columns("Cantidad").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Precio").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Total").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Precio").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("Cantidad").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                .DisplayLayout.Bands(0).Columns("Precio").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))

                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargaDireccionTipoPago()

        oeCliente = New e_Cliente
        leDir = New List(Of e_Direccion_EmpresaPersona)

        Select Case optCliente.CheckedIndex
            Case 0 : oeCliente = cboCliente2.Rows(cboCliente2.SelectedRow.Index).ListObject
            Case 1 : oeCliente = cboDestinatario.Rows(cboDestinatario.SelectedRow.Index).ListObject
            Case 2 : oeCliente = cboOtroCliente.Rows(cboOtroCliente.SelectedRow.Index).ListObject
        End Select

        If optCliente.CheckedIndex > -1 Then
            oeDireccion.IdPersonaEmpresa = IIf(oeCliente.TipoPersonaEmpresa = 1, oeCliente.IdPersona, oeCliente.IdEmpresa)
            oeDireccion.TipoPersonaEmpresa = oeCliente.TipoPersonaEmpresa
            leDir = olDireccion.Listar(oeDireccion).OrderBy(Function(item) item.Nombre).ToList
            Dim _leDirAux = From le In leDir _
                            Select IdDireccion = le.oeDireccion.Id, le.Nombre
            cboDirec.Text = String.Empty
            cboDirec.DataSource = New List(Of e_Direccion_EmpresaPersona)
            cboDirec.DataSource = _leDirAux.ToList
            cboDirec.PerformAction(UltraComboAction.FirstRow)

            cboDirec.Text = String.Empty
            cboDirec.DataSource = New List(Of e_Direccion_EmpresaPersona)
            cboDirec.DataSource = _leDirAux.ToList
            cboDirec.PerformAction(UltraComboAction.FirstRow)

            Dim leTipoP As New List(Of e_TipoPago)
            oeTipoPago = New e_TipoPago
            oeTipoPago.TipoOperacion = "F"
            oeTipoPago.IdClienteProveedor = oeCliente.Id
            oeTipoPago.TipoClienteProveedor = 1
            leTipoP = olTipoPago.Listar(oeTipoPago)

            If leTipoP.Count > 0 Then
                cboTipoPago.DataSource = Nothing
                cboTipoPago.SelectedIndex = -1
                LlenarCombo(cboTipoPago, "Nombre", leTipoP, 0)
            Else
                CargarTipoPago()
            End If
        End If

    End Sub

    Private Sub CargarViajesAsociados(ByVal le As List(Of e_Viaje))
        Try
            With griViaje
                .DataSource = leViaje

                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    If Col.Key.Contains("Id") _
                    Or Col.Key.Contains("Disponible") _
                    Or Col.Key.Contains("Incidencia") _
                    Or Col.Key.Contains("Usuario") _
                    Or Col.Key.Contains("Llegada") _
                    Or Col.Key.Contains("Salida") _
                    Or Col.Key.Contains("Km") _
                    Or Col.Key.Contains("Escala") _
                    Or Col.Key.Contains("Flete") _
                    Then Col.Hidden = True
                    Col.CellClickAction = CellClickAction.RowSelect
                Next


                OcultarColumna(griViaje, True, "Seleccion", "Activo", "Turno", "DiaNoche", "Flota", "Zona", "Tesoreria", "Carga", "IndFecha", "IngresoComplejoOrigen", _
                               "CargaOrigen", "TerminoCargaOrigen", "ImpresionGuiaOrigen", "IngresoDestino", "DescargaDestino", "TerminoDescargaDestino")

                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("Operacion").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Codigo").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Fecha").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Cliente").Header.Fixed = True

                .DisplayLayout.Bands(0).Columns("Operacion").Width = 95
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 95
                .DisplayLayout.Bands(0).Columns("Tracto").Width = 55
                .DisplayLayout.Bands(0).Columns("Carreta").Width = 55
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 60
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Width = 55
                .DisplayLayout.Bands(0).Columns("Cliente").Width = 150

                .DisplayLayout.Bands(0).Columns("Operacion").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("ViajeVacio").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("CargaMaterial").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("Tracto").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("Carreta").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("Piloto").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Copiloto").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("Ayudante").Header.VisiblePosition = 16

                .DisplayLayout.Bands(0).Columns("ViajeVacio").Header.Caption = "Vacio"
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.Caption = "TN/V"

                .DisplayLayout.Bands(0).Columns("ViajeVacio").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("PesoToneladas").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Operacion").CellAppearance.TextVAlign = HAlign.Center

                .DisplayLayout.Bands(0).Columns("Operacion").MergedCellStyle = MergedCellStyle.Always

                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

            End With

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

    Private Sub AgregarCarga(ByVal IdOperacionDet As String)
        Try
            Dim idOperaDet As String = ""
            idOperaDet = "'" & IdOperacionDet & "'"

            'Agregar Detalle Documento
            oeDetalleDocOpeDet = New e_DetalleDoc_OperacionDet
            oeDetalleDocOpeDet.TipoOperacion = "2"
            oeDetalleDocOpeDet.IdOperacionDet = idOperaDet
            oeDetalleDocOpeDet = olOperacion.ListarDS(oeDetalleDocOpeDet)(0)

            'Agregar Guia Tranportista
            oeGuiaTransportista = New e_GuiaTransportista
            oeGuiaTransportista.TipoOperacion = "T"
            oeGuiaTransportista.IdOperacion = idOperaDet
            leGuiaTrans.AddRange(olGuiaTransportista.ListarDS(oeGuiaTransportista))
            'CargarGuiaTrans(leGuiaTrans)

            'Agregar Guia Remitente
            oeGuiaRemitente = New e_GuiaRemitente
            oeGuiaRemitente.TipoOperacion = "R"
            oeGuiaRemitente.IdOperacion = idOperaDet
            leGuiaRemitente.AddRange(olGuiaRemitente.ListarDS(oeGuiaRemitente))
            'CargarGuiaRemi(leGuiaRemitente)

            Dim montotal As Double = 0
            montotal = leDetalleDocOD.Sum(Function(item) item.Valor) + oeDetalleDocOpeDet.Valor
            leDetalleDocOD.Add(oeDetalleDocOpeDet)
            CargarFactorReferencial(leDetalleDocOD)
            If montotal > oeMovDocumento.SubTotal Then Throw New Exception("El Monto Total del Detalle(" & montotal & ") no puede mayor al SubTotal de la Factura(" & oeMovDocumento.SubTotal & ")")
            'Else
            'leDetalleDocOD.Add(oeDetalleDocOpeDet)
            ' End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarCarga(ByVal IdOperacionDet As String)
        Try
            Dim leGT As New List(Of e_GuiaTransportista)
            Dim leGR As New List(Of e_GuiaRemitente)
            oeDetalleDocOpeDet = New e_DetalleDoc_OperacionDet
            oeDetalleDocOpeDet.IdOperacionDetalle = IdOperacionDet
            'oeDetalleDocOpeDet = griListaCarga.ActiveRow.ListObject
            oeDetalleDocOpeDet = leDetalleDocOD.Item(leDetalleDocOD.IndexOf(oeDetalleDocOpeDet))
            leDetalleDocOD.Remove(oeDetalleDocOpeDet)
            leGT = leGuiaTrans.Where(Function(item) item.IdOperacionDetalle = IdOperacionDet).ToList
            For Each oeGT As e_GuiaTransportista In leGT
                leGuiaTrans.Remove(oeGT)
                leGR = New List(Of e_GuiaRemitente)
                leGR = leGuiaRemitente.Where(Function(item) item.IdGuiaTransportista = oeGT.Id).ToList
                For Each oeGR As e_GuiaRemitente In leGR
                    leGuiaRemitente.Remove(oeGR)
                Next
            Next
            'leGR = leGuiaRemitente.Where(function(item) item.id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarCargaLiquidacion(ByVal IdOperacionDet As String)
        Try
            Dim idOperaDet As String = ""
            idOperaDet = "'" & IdOperacionDet & "'"

            'Agregar Detalle Documento
            oeDetalleDocOpeDet = New e_DetalleDoc_OperacionDet
            oeDetalleDocOpeDet.TipoOperacion = "L"
            oeDetalleDocOpeDet.IdOperacionDet = idOperaDet
            If opcFormatoLiquidacion.CheckedIndex = 4 Then
                oeDetalleDocOpeDet.Glosa = cboClaseServicioTottus.Text
            Else
                oeDetalleDocOpeDet.Glosa = ""
            End If
            leDetalleDocOD.AddRange(olOperacion.ListarDS(oeDetalleDocOpeDet))

            'Agregar Guia Tranportista
            oeGuiaTransportista = New e_GuiaTransportista
            oeGuiaTransportista.TipoOperacion = "L"
            oeGuiaTransportista.IdOperacion = idOperaDet
            If opcFormatoLiquidacion.CheckedIndex = 4 Then
                oeGuiaTransportista.Glosa = cboClaseServicioTottus.Text
            Else
                oeGuiaTransportista.Glosa = ""
            End If
            leGuiaTrans.AddRange(olGuiaTransportista.ListarDS(oeGuiaTransportista))
            CargarGuiaTrans(leGuiaTrans)

            'Agregar Guia Remitente
            oeGuiaRemitente = New e_GuiaRemitente
            oeGuiaRemitente.TipoOperacion = "Q"
            oeGuiaRemitente.IdOperacion = idOperaDet
            If opcFormatoLiquidacion.CheckedIndex = 4 Then
                oeGuiaRemitente.Glosa = cboClaseServicioTottus.Text
            Else
                oeGuiaRemitente.Glosa = ""
            End If
            leGuiaRemitente.AddRange(olGuiaRemitente.ListarDS(oeGuiaRemitente))
            CargarGuiaRemi(leGuiaRemitente)

            'Dim montotal As Double = 0
            'montotal = leDetalleDocOD.Sum(Function(item) item.Valor) + oeDetalleDocOpeDet.Valor
            'leDetalleDocOD.Add(oeDetalleDocOpeDet)
            'CargarFactorReferencial(leDetalleDocOD)
            'If montotal > oeMovDocumento.SubTotal Then Throw New Exception("El Monto Total del Detalle(" & montotal & ") no puede mayor al SubTotal de la Factura(" & oeMovDocumento.SubTotal & ")")
            ''Else
            ''leDetalleDocOD.Add(oeDetalleDocOpeDet)
            '' End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarCargaLiquidacion()
        Try
            leDetalleDocOD.Clear()
            leGuiaTrans.Clear()
            leGuiaRemitente.Clear()
            IdLiquidacion = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaComboGrilla(ByVal leGT As List(Of e_GuiaTransportista))
        Try
            Dim le As New List(Of e_GuiaTransportista)
            Dim leRemitente As New List(Of e_Cliente)
            Dim leDestinatario As New List(Of e_Cliente)
            Dim oeClienteGrilla As New e_Cliente
            Dim leCli As New List(Of e_Cliente)
            Dim idRemi As String = ""
            Dim idDesti As String = ""
            cboCliente2.Text = String.Empty
            cboCliente2.DataSource = New List(Of e_Cliente)
            le = leGT.OrderBy(Function(item) item.IdRemitente).ToList
            For Each oeGT As e_GuiaTransportista In le
                If idRemi <> oeGT.IdRemitente Then
                    idRemi = oeGT.IdRemitente
                    oeClienteGrilla = New e_Cliente
                    leCli = New List(Of e_Cliente)
                    leCli = leCliente.Where(Function(item) item.Id = idRemi).ToList
                    If leCli.Count > 0 Then
                        oeClienteGrilla = leCli(0)
                        leRemitente.Add(oeClienteGrilla)
                    Else
                        Throw New Exception("No se ha Ingresado Correctamente Remitente en la Guia Transportista Nº: " & oeGT.Serie & " - " & oeGT.Numero)
                    End If
                End If
            Next
            cboCliente2.DataSource = leRemitente
            If leRemitente.Count > 0 Then
                cboCliente2.PerformAction(UltraComboAction.FirstRow)
            Else
                cboCliente2.PerformAction(UltraComboAction.Dropdown)
            End If


            le = New List(Of e_GuiaTransportista)
            cboDestinatario.Text = String.Empty
            cboDestinatario.DataSource = New List(Of e_Cliente)
            le = leGT.OrderBy(Function(item) item.IdDestinatario).ToList
            For Each oeGT As e_GuiaTransportista In le
                If idDesti <> oeGT.IdDestinatario Then
                    idDesti = oeGT.IdDestinatario
                    oeClienteGrilla = New e_Cliente
                    leCli = New List(Of e_Cliente)
                    leCli = leCliente.Where(Function(item) item.Id = idDesti).ToList
                    If leCli.Count > 0 Then
                        oeClienteGrilla = leCli(0)
                        leDestinatario.Add(oeClienteGrilla)
                    Else
                        Throw New Exception("No se ha Ingresado Correctamente Destinatario en la Guia Transportista Nº: " & oeGT.Serie & " - " & oeGT.Numero)
                    End If
                End If
            Next
            cboDestinatario.DataSource = leDestinatario
            If leDestinatario.Count > 0 Then
                cboDestinatario.PerformAction(UltraComboAction.FirstRow)
            Else
                cboDestinatario.PerformAction(UltraComboAction.Dropdown)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarFactorReferencial(ByVal leDDOD As List(Of e_DetalleDoc_OperacionDet))
        Try
            For Each oeDDOD As e_DetalleDoc_OperacionDet In leDDOD
                Dim oe As New e_DetalleDoc_OperacionDet
                oe.IdOperacionDetalle = oeDDOD.IdOperacionDetalle
                oe.FactorRefUni = oeDDOD.FactorRefUni
                leFactorReferencial.Add(oe)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function ValidarGuiaRemitente(ByVal txt_controlInicial As ISL.Controles.Texto) As Boolean
        Try
            Dim ls_Serie As String
            Dim ls_Numero As String

            Dim o_DocumentoGrrInicial() As String = txt_controlInicial.Text.Split("-")
            ls_Serie = o_DocumentoGrrInicial(0).ToString.Trim
            If ls_Serie.Length > 3 Then
                txt_controlInicial.Focus()
                Throw New Exception("Nº Serie debe ser Menor o Igual a 3 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            If txt_controlInicial.Text.Trim.Length = 0 Or Not txt_controlInicial.Text.Contains("-") Then
                txt_controlInicial.Focus()
                Throw New Exception("Ingrese Correctamente Guía Remisión Remitente, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            ls_Numero = o_DocumentoGrrInicial(1).ToString.Trim
            If ls_Numero.Length < 1 Then
                txt_controlInicial.Focus()
                Throw New Exception("Numero Seguido de Serie debe ser Mayor a 1 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            ls_Serie = FormatoDocumento(ls_Serie, 3)
            ls_Numero = FormatoDocumento(ls_Numero, 7)
            txt_controlInicial.Text = ls_Serie & "-" & ls_Numero
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub hab_lectura(Optional ByVal hab As Boolean = True)
        decSubTotal.ReadOnly = hab
        decImpuesto.ReadOnly = hab
        decTotal.ReadOnly = hab
        'decImporteDetraer.ReadOnly = hab
        'decDetraccion.ReadOnly = hab
        'decNetoPagar.ReadOnly = hab
    End Sub
    'cambios
    Private Sub Calcular_Montos()
        Try
            Dim factortot As Double = Math.Round(leDetalleDocOD.Sum(Function(item) item.FactorRefTotal), 4)

            If decTotal.Value > 400 AndAlso TD = "F" Then
                If factortot > decTotal.Value Then
                    decImporteDetraer.Value = factortot
                Else
                    decImporteDetraer.Value = decTotal.Value
                End If
            Else
                decImporteDetraer.Value = decTotal.Value
            End If
            'no value decdetarer
            decDetraccion.Value = CDbl(decImporteDetraer.Value) * CDbl(DecDetraer.Value) / 100
            Dim _ximp As Double = Math.Round(decTotal.Value, 2)
            decNetoPagar.Value = Math.Round(_ximp - decDetraccion.Value, 2)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaSeleccionados()
        Try
            If leSelec.Count > 0 Then
                BandSel = False
                For Each oeSel As e_Viaje In leSelec
                    For Each fila As UltraGridRow In griFactura.Rows
                        If fila.Cells("Seleccion").Value = False AndAlso fila.Cells("Id").Value = oeSel.Id Then
                            fila.Cells("Seleccion").Value = True
                            griFactura.UpdateData()
                            Exit For
                        End If
                    Next
                Next
                BandSel = True
            Else
                NroSel = 0
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaClienteCombo(ByVal idcli As String) As Boolean
        If idcli.Length <> 12 Then
            Throw New Exception("El Cliente Seleccionado No Existe")
        Else
            Dim id As String = idcli.Substring(3, 9)
            If Not IsNumeric(id) Then
                Throw New Exception("El Cliente Seleccionado No Existe")
            End If
        End If
        Return True
    End Function

    Private Sub EditaDoc(ByVal IndEdi As Boolean)

        chkElectronico.Enabled = Not IndEdi
        txtSerie.ReadOnly = IndEdi
        txtNumero.ReadOnly = IndEdi
        cboDirec.ReadOnly = IndEdi
        cboTipoPago.ReadOnly = IndEdi
        fecDoc.ReadOnly = IndEdi

        cboCliente2.ReadOnly = IndEdi
        cboDestinatario.ReadOnly = IndEdi
        cboOtroCliente.ReadOnly = IndEdi

        optCliente.Enabled = Not IndEdi
        verDetraccionCero.Enabled = Not IndEdi
        verFactorRCero.Enabled = Not IndEdi
        verCantidadTn.Enabled = Not IndEdi

    End Sub

    'Public Overrides Sub MetodoParalelo()
    '    If cboFactura.SelectedIndex <> 1 Then BandSave = False
    '    'CambiarEstadoCarga(leSelec)
    '    leSelec = New List(Of e_Viaje)
    '    verSelecion.Checked = False
    '    Consultar(_Activo)
    '    BandSave = True
    '    HiloIsl.Abort()
    'End Sub

    Private Sub TabLista()
        If ficMaterial.SelectedTab.Index = 1 Then
            If griDocumentoVenta.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Else
            If griFactura.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        End If
    End Sub

    Private Sub GuiasTransSel()
        Try
            leCadGTR = New List(Of e_GuiaTransportista)
            'Captura las Guias de Transportistas Seleccionadas
            Dim oeGuiaT As New e_GuiaTransportista
            Dim leGTTemp As New List(Of e_GuiaTransportista)
            For Each fila As UltraGridRow In griGuiaTransportista.Rows
                If fila.Cells("Selec").Value Then
                    oeGuiaT = New e_GuiaTransportista
                    oeGuiaT = fila.ListObject
                    leGTTemp.Add(oeGuiaT)
                End If
            Next
            'Captura las Guias Remitentes Seleccionadas
            Dim oeGuiaR As New e_GuiaRemitente
            Dim leGRTemp As New List(Of e_GuiaRemitente)
            For Each fila2 As UltraGridRow In griGuiaRemisionR.Rows
                If fila2.Cells("Selec").Value Then
                    oeGuiaR = New e_GuiaRemitente
                    oeGuiaR = fila2.ListObject
                    leGRTemp.Add(oeGuiaR)
                End If
            Next
            '------------------------------------------
            If leGTTemp.Count > 0 Then
                Dim leOrderGT As New List(Of e_GuiaTransportista)
                Dim leOrderGR As New List(Of e_GuiaRemitente)
                Dim IdOpeDet As String = ""
                Dim CadenaGT As String = ""
                Dim CadenaGR As String = ""
                Dim idGT As String = ""
                Dim bandadd As Boolean = False
                leOrderGT = leGTTemp.OrderBy(Function(item) item.IdOperacionDetalle).ToList
                For Each oeTemp As e_GuiaTransportista In leOrderGT
                    idGT = oeTemp.Id
                    If IdOpeDet <> oeTemp.IdOperacionDetalle Then
                        bandadd = True
                        oeGuiaT = New e_GuiaTransportista
                        IdOpeDet = oeTemp.IdOperacionDetalle
                        oeGuiaT.Id = IdOpeDet
                        CadenaGT = "GRT: " & oeTemp.Serie.Substring(1, oeTemp.Serie.Length - 1) & "-" & oeTemp.Numero.Substring(3, oeTemp.Numero.Length - 3)
                        oeGuiaT.Serie = CadenaGT
                        leOrderGR = New List(Of e_GuiaRemitente)
                        leOrderGR = leGRTemp.Where(Function(item) item.IdGuiaTransportista = idGT).ToList
                        CadenaGR = "GRR: "
                        For Each oeGRTemp As e_GuiaRemitente In leOrderGR
                            CadenaGR = CadenaGR & oeGRTemp.Serie.Substring(1, oeGRTemp.Serie.Length - 1) & "-" & oeGRTemp.Numero.Substring(3, oeGRTemp.Numero.Length - 3) & "/"
                        Next
                        oeGuiaT.Numero = CadenaGR
                    Else
                        CadenaGT = CadenaGT & "/" & oeTemp.Serie.Substring(1, oeTemp.Serie.Length - 1) & "-" & oeTemp.Numero.Substring(3, oeTemp.Numero.Length - 3)
                        oeGuiaT.Serie = CadenaGT
                    End If
                    If Not bandadd Then
                        leOrderGR = New List(Of e_GuiaRemitente)
                        leOrderGR = leGRTemp.Where(Function(item) item.IdGuiaTransportista = idGT).ToList
                        For Each oeGRTemp As e_GuiaRemitente In leOrderGR
                            CadenaGR = CadenaGR & oeGRTemp.Serie.Substring(1, oeGRTemp.Serie.Length - 1) & "-" & oeGRTemp.Numero.Substring(3, oeGRTemp.Numero.Length - 3) & "/"
                        Next
                        oeGuiaT.Numero = CadenaGR
                    End If
                    If bandadd Then
                        bandadd = False
                        leCadGTR.Add(oeGuiaT)
                    End If
                Next
            Else
                leCadGTR = New List(Of e_GuiaTransportista)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CambiarEstadoCarga(ByVal leViaje As List(Of e_Viaje))
        Try
            If leViaje.Count = 1 Then
                If MessageBox.Show("Esta Carga esta Facturada. ¿Desea cambiar a Por Facturar?", _
                                               "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    Dim oeOperacionDet As New e_OperacionDetalle
                    oeOperacionDet.Id = leViaje(0).Id
                    oeOperacionDet.TipoOperacion = "R"
                    olOperacion.RegfacturarOperacionDet(oeOperacionDet)
                    MessageBox.Show("Esta Carga ha cambiado a Por Facturar", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ObtieneSel()
        If BandSave Then
            If griFactura.Rows.Count > 0 Then
                griFactura.DataBind()
                leSelec = leCargas.Where(Function(item) item.Seleccion = True).ToList
            End If
        End If
    End Sub

    Private Sub Emitir()
        Try
            Dim _banEmis As Boolean = True
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Oper = "Generar" Then
                    oeMovDocumento = New e_MovimientoDocumento
                    oeMovDocumento.Id = "" : oeMovDocumento.IdTipoDocumento = cboTipoDocumento.Value
                    oeMovDocumento.Serie = txtSerie.Text.Trim : oeMovDocumento.Numero = txtNumero.Text.Trim
                    oeMovDocumento.IndCompraVenta = 2 : oeMovDocumento.CargarCompleto = False
                    oeMovDocumento = olMovDocumento.ObtenerVenta(oeMovDocumento)
                    VistaPrevia = False
                End If
                If oeMovDocumento.leDetalleDocOperDet.Count = 0 Then Throw New Exception("No se Puede Emitir el Documento de Venta sin Detalles")
                If oeMovDocumento.FechaEmision.Year <> frm.Año1.Año Then Throw New Exception("Los años no son iguales, No se puede Emitir")
                If oeMovDocumento.FechaEmision.Month <> CInt(frm.cboMes.Text) Then Throw New Exception("El mes de emision es diferente al Periodo,No se puede Emitir")
                oeMovDocumento.IdPeriodo = frm.cboMes.Value : oeMovDocumento.Ejercicio = frm.Año1.Año
                oeMovDocumento.Venta.TipoDoc = oeTipoDoc : oeMovDocumento.Venta.Cliente = oeCliente : oeMovDocumento.Venta.Moneda = oeMoneda
                'Obtiene Asiento Modelo por Moneda
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.Equivale = 1 : oeAsientoModel.IdMoneda = oeMoneda.Id
                If leAsientoModel.Contains(oeAsientoModel) Then
                    oeAsientoModel = leAsientoModel.Item(leAsientoModel.IndexOf(oeAsientoModel))
                    oeAsientoModel.TipoOperacion = ""
                    oeAsientoModel.Ejercicio = oeMovDocumento.FechaEmision.Year
                    oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                    ' Actualizar Cuenta para Empresas Relacionada
                    Dim _oeEmpr As New e_Cliente
                    _oeEmpr.Equivale = 1
                    _oeEmpr.Id = oeMovDocumento.IdClienteProveedor.Trim
                    If leCliente.Contains(_oeEmpr) Then
                        _oeEmpr = leCliente.Item(leCliente.IndexOf(_oeEmpr))
                        If _oeEmpr.IndRelacionada = 1 Then
                            For Each _oeDet In oeAsientoModel.leDetalle
                                If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "12" Then
                                    Dim strCuenta As String = Replace(_oeDet.Cuenta, "2", "3", 1, 1)
                                    Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 3) & "33" & Microsoft.VisualBasic.Right(strCuenta, 1)
                                    _oeDet.Cuenta = strNuevaCuenta
                                    oeCtaContable = New e_CuentaContable
                                    oeCtaContable.Cuenta = strNuevaCuenta : oeCtaContable.Equivale = 0
                                    If leCtaContable.Contains(oeCtaContable) Then
                                        oeCtaContable = leCtaContable.Item(leCtaContable.IndexOf(oeCtaContable))
                                        _oeDet.IdCuentaContable = oeCtaContable.Id
                                    End If
                                End If
                            Next
                        End If
                    End If
                Else
                    Throw New Exception("No Existe Configuracion Contable")
                End If
                'Obtiene Servicio Cuenta Contable
                If AnioServ <> frm.Año1.Año Then
                    AnioServ = frm.Año1.Año
                    oeServCtaCtble = New e_ServicioCuentaContable
                    oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = AnioServ
                    leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)
                End If
                oeServCtaCtble = New e_ServicioCuentaContable
                oeServCtaCtble.IdServicio = gVSTransporte : oeServCtaCtble.Equivale = 1
                If leServCtaCtble.Contains(oeServCtaCtble) Then
                    oeServCtaCtble = leServCtaCtble.Item(leServCtaCtble.IndexOf(oeServCtaCtble))
                Else
                    Throw New Exception("No Existen Cuenta Contable para el Servicio: " & gVSTransporte & " para el Año: " & AnioServ & _
                                        Environment.NewLine & "Solicite el Apoyo del Area Contable.")
                End If
                'Valida CuentaCorriente
                oeCuentaCorriente = New e_CuentaCorriente
                oeCuentaCorriente.Tipo = 3 : oeCuentaCorriente.IdTrabajador = oeMovDocumento.IdClienteProveedor
                oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
                oeMovDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                If oeMovDocumento.IndAfectaAnticipo Then
                    oeDocAsoc = New e_DocumentoAsociado
                    oeDocAsoc.TipoOperacion = "T"
                    oeDocAsoc.IdMovimientoDocumento = oeMovDocumento.Id
                    oeMovDocumento.DocAsoc = olDocAsoc.Listar(oeDocAsoc)
                End If
                oeMovDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                If oeCuentaCorriente.Id <> "" Then
                    _banEmis = olMovDocumento.GuardarVentaAsiento(oeMovDocumento, oeAsientoModel, oeServCtaCtble, False, String.Empty, b_anticipo)
                Else
                    With oeCuentaCorriente
                        .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = oeMovDocumento.IdClienteProveedor
                        .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = frm.Año1.Año : .Usuario = gUsuarioSGI.Id
                        .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA"
                    End With
                    oeCuentaCorriente.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olCuentaCorriente.Guardar(oeCuentaCorriente)
                    _banEmis = olMovDocumento.GuardarVentaAsiento(oeMovDocumento, oeAsientoModel, oeServCtaCtble, False, String.Empty, b_anticipo)
                End If
                If _banEmis = True Then
                    mensajeEmergente.Confirmacion("El Documento Nº " & oeMovDocumento.Serie & " - " & oeMovDocumento.Numero & " ha sido Emitido", True)
                    'Dim WCF_Cpe As New WCF_CpeIndu.WCF_CpeClient("Indu_IWCF_Cpe")
                    Dim dsComprobante As DataSet
                    'Dim dt_cpe As DataTable

                    oeMovDocumento = New e_MovimientoDocumento
                    oeMovDocumento.TipoOperacion = "DT"
                    oeMovDocumento._Operador = 1
                    oeMovDocumento.Id = griDocumentoVenta.ActiveRow.Cells("Id").Value
                    oeMovDocumento.Abrev_Empresa = Abrev_Empresa
                    dsComprobante = olMovDocumento.ListaFacturacionElectronica(oeMovDocumento)
                    'dt_cpe = Deserializar_XmlStr(WCF_Cpe.GenerarXML_CPE(dsComprobante, Date.Now, dsComprobante.Tables(0).Rows(0).Item("cod_comprob_cat_1").ToString().Trim(), RutaArchivos, Abrev_Empresa, Nothing, Nothing))
                    'olDocumento.GenerarXmlFacturaElectronica_Emision(dsComprobante.Tables(0), dsComprobante.Tables(1), frm_DocumentoElectronico.RutaArchivos, gUsuarioEOS.Id)
                    olMovDocumento.GenerarXmlFacturaElectronica(dsComprobante.Tables(0), dsComprobante.Tables(1), RutaArchivos, gUsuarioSGI.Id) '<--
                    'Registro_ComprobanteElectronico_Bath(dt_cpe, "I", dsComprobante.Tables(0).Rows(0).Item("cod_comprob_cat_1").ToString().Trim(), Nothing)

                    'Imprimir()

                End If
                If cboFactura.SelectedIndex <> 1 Then BandSave = False
                leSelec = New List(Of e_Viaje) : verSelecion.Checked = False
                Consultar(_Activo)
                BandSave = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Anular()
        Try
            oeMovDocumento.IndOrigenContable = 2
            If olMovDocumento.Anular(oeMovDocumento, gUsuarioSGI.Id) Then
                mensajeEmergente.Confirmacion("El Documento " & oeMovDocumento.NombreDocumento & _
                                              " Nº " & oeMovDocumento.Serie & " - " & oeMovDocumento.Numero & _
                                              " ha sido Anulada", True)
                Consultar(_Activo)
                MostrarTabs(0, ficFactura, 0)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DuplicarRegistroDetalle()
        If griDetalleDoc.ActiveRow IsNot Nothing Then
            leDetalleDocOD = griDetalleDoc.DataSource
            If griDetalleDoc.ActiveRow.Cells("IndConsolidado").Value = "" Then
                If griDetalleDoc.ActiveRow.Cells("Consolidado").Value > 0 Then
                    With griDetalleDoc.ActiveRow
                        .Cells("IndConsolidado").Value = 0
                        '     .Cells("Consolidado").Column.CellClickAction = CellClickAction.CellSelect
                        oeDetalleDocOpeDet = New e_DetalleDoc_OperacionDet
                        oeDetalleDocOpeDet.Id = Nothing
                        oeDetalleDocOpeDet.IndGravado = .Cells("IndGravado").Value
                        oeDetalleDocOpeDet.IdOperacionDetalle = .Cells("IdOperacionDetalle").Value
                        oeDetalleDocOpeDet.IdOperacion = .Cells("IdOperacion").Value
                        oeDetalleDocOpeDet.IdComisionista = .Cells("IdComisionista").Value
                        oeDetalleDocOpeDet.IdOrigen = .Cells("IdOrigen").Value
                        oeDetalleDocOpeDet.IdDestino = .Cells("IdDestino").Value
                        oeDetalleDocOpeDet.MaterialServicio = .Cells("MaterialServicio").Value
                        oeDetalleDocOpeDet.UnidadMedida = .Cells("UnidadMedida").Value
                        oeDetalleDocOpeDet.IdComisionista = .Cells("IdComisionista").Value
                        oeDetalleDocOpeDet.IdMaterial = .Cells("IdMaterial").Value
                        oeDetalleDocOpeDet.IdUnidadCarga = .Cells("IdUnidadCarga").Value
                        oeDetalleDocOpeDet.CantOpe = .Cells("CantOpe").Value
                        oeDetalleDocOpeDet.IncluyeIgv = .Cells("IncluyeIgv").Value
                        oeDetalleDocOpeDet.FleteUnitario = IIf(.Cells("Cantidad").Value > 0, .Cells("Consolidado").Value / .Cells("Cantidad").Value, 0)
                        oeDetalleDocOpeDet.Flete = .Cells("Consolidado").Value
                        oeDetalleDocOpeDet.PesoToneladas = .Cells("PesoToneladas").Value
                        oeDetalleDocOpeDet.Glosa = .Cells("Glosa").Value
                        oeDetalleDocOpeDet.Saldo = .Cells("Saldo").Value
                        oeDetalleDocOpeDet.SubTotal = .Cells("SubTotal").Value
                        oeDetalleDocOpeDet.Igv = .Cells("Igv").Value
                        oeDetalleDocOpeDet.ValorUnit2 = .Cells("ValorUnit2").Value
                        oeDetalleDocOpeDet.FechaViaje = .Cells("FechaViaje").Value
                        oeDetalleDocOpeDet.NroViaje = .Cells("NroViaje").Value
                        oeDetalleDocOpeDet.IdMaterialServicio = .Cells("IdMaterialServicio").Value
                        oeDetalleDocOpeDet.Cantidad = .Cells("Cantidad").Value
                        oeDetalleDocOpeDet.IdUnidadMedida = .Cells("IdUnidadMedida").Value
                        oeDetalleDocOpeDet.CV = .Cells("CV").Value
                        oeDetalleDocOpeDet.FactorRefUni = .Cells("FactorRefUni").Value
                        oeDetalleDocOpeDet.FactorRefTotal = .Cells("FactorRefTotal").Value
                        oeDetalleDocOpeDet.PrecioUnitario = IIf(.Cells("Cantidad").Value > 0, .Cells("Consolidado").Value / .Cells("Cantidad").Value, 0)
                        oeDetalleDocOpeDet.Valor = .Cells("Consolidado").Value
                        oeDetalleDocOpeDet.Origen = .Cells("Origen").Value
                        oeDetalleDocOpeDet.Destino = .Cells("Destino").Value
                        oeDetalleDocOpeDet.Tracto = .Cells("Tracto").Value
                        oeDetalleDocOpeDet.Carreta = .Cells("Carreta").Value
                        oeDetalleDocOpeDet.CantGuia = .Cells("CantGuia").Value
                        oeDetalleDocOpeDet.Consolidado = .Cells("Consolidado").Value
                        oeDetalleDocOpeDet.IdOrigen = .Cells("IdOrigen").Value
                        '  oeDetalleDocOpeDet._IdVehiculo = .Cells("IdVehiculo").Value

                        oeDetalleDocOpeDet.IdDestino = .Cells("IdDestino").Value
                        oeDetalleDocOpeDet.IdMaterialServicio = .Cells("IdMaterialServicio").Value
                        oeDetalleDocOpeDet.IdUnidadMedida = .Cells("IdUnidadMedida").Value
                        oeDetalleDocOpeDet.Tracto = .Cells("Tracto").Value
                        oeDetalleDocOpeDet.Carreta = .Cells("Carreta").Value
                        oeDetalleDocOpeDet.CantGuia = .Cells("CantGuia").Value
                        oeDetalleDocOpeDet.IndConsolidado = 1
                        oeDetalleDocOpeDet.Consolidado = 0
                        oeDetalleDocOpeDet.GlosaConsolidado = .Cells("GlosaConsolidado").Value
                        oeDetalleDocOpeDet.NroOperacionOrden = .Cells("NroOperacionOrden").Value '@0001
                        leDetalleDocOD.Add(oeDetalleDocOpeDet)
                        griDetalleDoc.DataBind()
                        oeDetalleDocOpeDet = New e_DetalleDoc_OperacionDet
                    End With
                    If ficMaterial.SelectedTab.Index = 0 Then
                        decSubTotal.Value = leDetalleDocOD.Sum(Function(item) item.Valor)
                        decImpuesto.Value = decSubTotal.Value * oeIGV.Porcentaje
                        'decTotal.Value = Math.Round(decSubTotal.Value, 2) + Math.Round(decImpuesto.Value, 2)
                        decTotal.Value = decSubTotal.Value + decImpuesto.Value
                    End If
                Else
                    mensajeEmergente.Confirmacion("Monto de CONSOLIDADO debe ser MAYOR A CERO", True)
                End If
            Else
                mensajeEmergente.Confirmacion("Ya se APLICÓ el monto de CONSOLIDADO", True)
            End If
        Else
            mensajeEmergente.Confirmacion("Debe SELECCIONAR un DETALLE de la lista", True)
        End If
    End Sub

    Private Function llenarGlosa(ByVal oeDocumentoVenta As e_MovimientoDocumento, _
                          ByVal leDetalleDoc As List(Of e_DetalleDoc_OperacionDet), _
                          ByVal Observacion As Boolean, _
                          ByVal Omitir As Boolean, _
                          ByVal leGTGR As List(Of e_GuiaTransportista), _
                          ByVal optIgv As Boolean, _
                          ByVal detraccioncero As Boolean, _
                          ByVal OmitirAdjunto As Boolean, _
                          ByVal CantTonelada As Double) As String
        Try
            Dim oeIGV As New e_Impuesto, olIGV As New l_Impuesto
            Dim leTemp As New List(Of e_GuiaTransportista)
            Dim Cant As Double = 0, ValorUnit As Double = 0, vrefuni As Double = -1, vreftot As Double = -1, vx As Double = -1
            Dim Ruta As String = "", Producto As String = "", Descripcion As String = ""
            Dim bandruta As Boolean = False, bandprod As Boolean = False

            With oeDocumentoVenta
                'Carga los detalles de la factura
                leDetalleDoc = IIf(VistaPrevia, leDetalleDoc, .leDetalleDocOperDet)
                If leDetalleDoc.Count > 0 Then
                    'Cuando Tiene mas de 8 Detalles se genera un solo detalle con hoja adjunta
                    If leDetalleDoc.Count > 8 Then
                        Dim Unid As String = leDetalleDoc(0).UnidadMedida
                        Cant = IIf(Omitir = True, 0, leDetalleDoc.Sum(Function(item) item.Cantidad))
                        ValorUnit = IIf(Omitir = True, .SubTotal, leDetalleDoc(0).PrecioUnitario)

                        vx = leDetalleDoc.Sum(Function(item) item.FactorRefTotal)
                        vreftot = IIf(vx > .Total, vx, .Total)
                        For Each oedet As e_DetalleDoc_OperacionDet In leDetalleDoc
                            If Ruta <> oedet.Origen.Trim & " - " & oedet.Destino.Trim Then
                                If Ruta <> "" Then bandruta = True
                                Ruta = oedet.Origen.Trim & " - " & oedet.Destino.Trim
                            End If
                            If Producto <> oedet.MaterialServicio Then
                                If Producto <> "" Then bandprod = True
                                Producto = oedet.MaterialServicio
                            End If
                        Next
                        If Not bandruta Then
                            Descripcion = " RUTA: " & Ruta & Environment.NewLine : vrefuni = leDetalleDoc(0).FactorRefUni
                        Else
                            Descripcion = " DIVERSOS DESTINOS " & Environment.NewLine
                        End If
                        If Not bandprod Then Descripcion = Descripcion & " PRODUCTO: " & Producto & Environment.NewLine
                        Descripcion = IIf(Omitir = True, " POR SERVICIO DE TRANSPORTE" & Environment.NewLine & " DIVERSOS DESTINOS", _
                                                       Descripcion & Environment.NewLine & IIf(OmitirAdjunto = True, "", " DETALLE SEGÚN ANEXO ADJUNTO"))


                    Else
                        'Cuando se activo la opcion de mostrar un solo detalle
                        '   If UnDetalle Then
                        Dim _Unidx As String = leDetalleDoc(0).UnidadMedida
                        Cant = IIf(Omitir = True, 0, leDetalleDoc.Sum(Function(item) item.Cantidad))
                        ValorUnit = IIf(Omitir = True, .SubTotal, leDetalleDoc(0).PrecioUnitario)
                        vx = leDetalleDoc.Sum(Function(item) item.FactorRefTotal)
                        vreftot = IIf(vx > .Total, vx, .Total)
                        For Each oedet As e_DetalleDoc_OperacionDet In leDetalleDoc
                            If Ruta <> oedet.Origen.Trim & " - " & oedet.Destino.Trim Then
                                If Ruta <> "" Then bandruta = True
                                Ruta = oedet.Origen.Trim & " - " & oedet.Destino.Trim
                            End If
                            If Producto <> oedet.MaterialServicio Then
                                If Producto <> "" Then bandprod = True
                                Producto = oedet.MaterialServicio
                            End If
                        Next
                        If Not bandruta Then
                            Descripcion = " RUTA: " & Ruta & Environment.NewLine : vrefuni = leDetalleDoc(0).FactorRefUni
                        Else
                            Descripcion = " DIVERSOS DESTINOS " & Environment.NewLine
                        End If
                        If Not bandprod Then Descripcion = Descripcion & " PRODUCTO: " & Producto & Environment.NewLine
                        Descripcion = IIf(Omitir = True, " POR SERVICIO DE TRANSPORTE" & Environment.NewLine & " DIVERSOS DESTINOS", _
                                                       Descripcion & Environment.NewLine & IIf(OmitirAdjunto = True, "", " DETALLE SEGÚN ANEXO ADJUNTO"))

                        'End If

                    End If
                End If
                Return Descripcion
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub VolverAEstadoAnterior(ByVal idOperacionDetalle)
        For Each obj As UltraGridRow In griDetalleDoc.Rows
            With obj
                If (.Cells("IdOperacionDetalle").Value = idOperacionDetalle) Then
                    .Cells("IndConsolidado").Value = Nothing
                End If
            End With
        Next
    End Sub

    Private Sub mt_CargarCtaContable(ByVal Ejercicio As Integer)
        Try
            oeCtaContable = New e_CuentaContable : olCtaContable = New l_CuentaContable : leCtaContable = New List(Of e_CuentaContable)
            oeCtaContable.Activo = True : oeCtaContable.Ejercicio = Ejercicio
            leCtaContable = olCtaContable.Listar(oeCtaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mnuFacturar_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuFacturar.Opening
        ' mnuFacturar.Items("tmsiFacturar").Visible = False
        mnuFacturar.Items("tsmiEmitir").Visible = False
        mnuFacturar.Items("tsmiAnular").Visible = False
        'mnuFacturar.Items("tsmiBoleta").Visible = False
        mnuFacturar.Items("tsmiNuevo").Visible = True
        mnuFacturar.Items("tsmiEditar").Visible = False
        mnuFacturar.Items("tsmiEliminar").Visible = False
        If griDocumentoVenta.Selected.Rows.Count > 0 Then
            'Select Case cboFactura.SelectedIndex
            '    Case 0
            '        mnuFacturar.Items("tmsiFacturar").Visible = True
            '        mnuFacturar.Items("tsmiBoleta").Visible = True
            '    Case 1
            Select Case griDocumentoVenta.ActiveRow.Cells("IdEstadoDocumento").Value
                Case "1CH00014"
                    mnuFacturar.Items("tsmiEmitir").Visible = True
                    'mnuFacturar.Items("tsmiNuevo").Visible = True
                    mnuFacturar.Items("tsmiEditar").Visible = True
                    mnuFacturar.Items("tsmiEliminar").Visible = True
                Case "1CH00008" : mnuFacturar.Items("tsmiAnular").Visible = True
            End Select
            'End Select
        End If
    End Sub

    Private Sub tsmiNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    'Private Sub tmsiFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmsiFacturar.Click


    'End Sub

    'Private Sub tsmiBoleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBoleta.Click

    'End Sub

    Private Sub tsmiEmitir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEmitir.Click
        Try
            Operacion = "Editar"
            Oper = "Emitir"
            IdDocumento = griDocumentoVenta.ActiveRow.Cells("Id").Value
            Mostrar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAnular.Click
        Try
            Operacion = "Editar"
            Oper = "Anular"
            IdDocumento = griDocumentoVenta.ActiveRow.Cells("Id").Value
            Mostrar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuCargas_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuCargas.Opening
        mnuCargas.Items("tsmiGeneraFac").Visible = False
        mnuCargas.Items("tsmiGeneraBol").Visible = False
        mnuCargas.Items("ConfirmaCargaGRT").Visible = False
        ' mnuCargas.Items("").Visible = False
        Dim leseltemp As New List(Of e_Viaje)
        'If cboFactura.Text = "POR FACTURAR" AndAlso griFactura.Rows.Count > 0 Then
        If griFactura.Rows.Count > 0 Then
            griFactura.DataBind()
            leseltemp = leCargas.Where(Function(item) item.Seleccion = True).ToList
            mnuCargas.Items("ConfirmaCargaGRT").Visible = True
        End If
        If leseltemp.Count > 0 Then
            mnuCargas.Items("tsmiGeneraFac").Visible = True
            mnuCargas.Items("tsmiGeneraBol").Visible = True
        End If
    End Sub

    Private Sub tsmiGeneraFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGeneraFac.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Nuevo"
            Oper = "Generar"
            TD = "F"
            BandCaso = True
            GenerarDoc()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiGeneraBol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGeneraBol.Click
        Try
            Operacion = "Nuevo"
            Oper = "Generar"
            TD = "B"
            BandCaso = True
            GenerarDoc()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

    Private Sub cboDirec_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboDirec.InitializeLayout
        Try
            InicializarComboDireccion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub InicializarComboDireccion()
        Try
            With cboDirec
                .ValueMember = "IdDireccion"
                .DisplayMember = "Nombre"
                For Each Col In .DisplayLayout.Bands(0).Columns
                    Col.Hidden = "True"
                Next
                .DropDownStyle = UltraComboStyle.DropDown
                .AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
                .AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
                .DisplayLayout.Bands(0).ColHeadersVisible = False
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                .DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub tsmiDescargarPDF_Click(sender As Object, e As EventArgs) Handles tsmiDescargarPDF.Click
        Try
            If griDocumentoVenta.ActiveRow.Cells("IndElectronico").Value = 0 Then Throw New Exception("Documento debe ser Electrónico.")

            'If griDocumentoVenta.ActiveRow.Cells("Estado").Value = "Anulado" Then Throw New Exception("Documento esta Anulado.")

            Dim frmImpresion As New frm_FacturaBoletaElectronico
            frmImpresion.mt_CargarDatos(griDocumentoVenta.ActiveRow.Cells("Id").Value, False)
            frmImpresion.StartPosition = FormStartPosition.CenterScreen
            frmImpresion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            frmImpresion.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub tsmiDescargarXML_Click(sender As Object, e As EventArgs) Handles tsmiDescargarXML.Click
        Try
            'Dim RutaArchivos As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("DocElectronico") & "\Facturacion\"
            Dim RutaArchivos As String = Path.Combine(Application.StartupPath, "ComprobanteElectronico") & "\Facturacion\"
            Dim sNombreArchivo As String = ""
            Dim TipoDocumento As String = ""
            Dim SerieDes As String = ""
            Dim NumeroDes As String = ""
            If griDocumentoVenta.ActiveRow.Cells("EstadoSunat").Value <> "ACEPTADA" Then Throw New Exception("Para Descargar XML, Documento debe ser Aceptada por Sunat.")

            FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                sNombreArchivo = FolderBrowserDialog1.SelectedPath
            Else
                FolderBrowserDialog1.Dispose()
                Return
            End If

            If sNombreArchivo <> "" Then
                TipoDocumento = griDocumentoVenta.ActiveRow.Cells("IdTipoDocumento").Value
                If TipoDocumento = "1CH000000026" Then TipoDocumento = "01"
                If TipoDocumento = "1CH000000002" Then TipoDocumento = "03"
                If TipoDocumento = "1CH000000033" Then TipoDocumento = "08"
                If TipoDocumento = "1CH000000030" Then TipoDocumento = "07"

                SerieDes = griDocumentoVenta.ActiveRow.Cells("Serie").Value
                NumeroDes = griDocumentoVenta.ActiveRow.Cells("Numero").Value.ToString.Substring(2, 8)

                RutaArchivos = RutaArchivos + gs_RucEmpresaSistema.Trim + "-" + TipoDocumento + "-" + SerieDes + "-" + NumeroDes + ".zip"
                sNombreArchivo = sNombreArchivo + "\" + gs_RucEmpresaSistema.Trim + "-" + TipoDocumento + "-" + SerieDes + "-" + NumeroDes + ".zip"
                My.Computer.FileSystem.CopyFile(RutaArchivos, sNombreArchivo, True)
                mensajeEmergente.Confirmacion("Se copio archivo correctamente", True)
            End If


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoBien_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoBien.ValueChanged
        Dim oetipobien2 As New e_TipoBien
        oetipobien2 = cboTipoBien.Items(cboTipoBien.SelectedIndex).ListObject
        DecDetraer.Value = oetipobien2.Porcentaje

        If verDetraccionCero.Checked Then
            decImporteDetraer.Value = 0 : decDetraccion.Value = 0 : decNetoPagar.Value = 0
        Else
            Calcular_Montos()
        End If
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

    Private Sub cbAnticipo_CheckedChanged(sender As Object, e As EventArgs) Handles cbAnticipo.CheckedChanged
        Try
             Cargar_Anticipos_Check()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Cargar_Anticipos_Check()
        If cbAnticipo.Checked Then
            Select Case optCliente.CheckedIndex
                Case 0
                    If cboCliente2.Value Is String.Empty Or cboCliente2.Value Is DBNull.Value Or cboCliente2.Value Is Nothing Then cbAnticipo.Checked = False : Throw New Exception("Debe seleccionar cliente.")
                Case 1
                    If cboDestinatario.Value Is String.Empty Or cboDestinatario.Value Is DBNull.Value Or cboDestinatario.Value Is Nothing Then cbAnticipo.Checked = False : Throw New Exception("Debe seleccionar cliente.")
                Case 2
                    If cboOtroCliente.Value Is String.Empty Or cboOtroCliente.Value Is DBNull.Value Or cboOtroCliente.Value Is Nothing Then cbAnticipo.Checked = False : Throw New Exception("Debe seleccionar cliente.")
            End Select
            If griDetalleDoc.Rows.Count = 0 Then cbAnticipo.Checked = False : Throw New Exception("Debe agregar detalles de materiales antes de aplicar el anticipo.")

            ficDetalle.Tabs(3).Visible = True
            ficDetalle.Tabs(3).Selected = True
            b_anticipo = True
            oeAnticipo = New e_MovimientoDocumento
            oeAnticipo.Id = oeMovDocumento.Id
            oeAnticipo.NombreDocumento = ""
            oeAnticipo.IdEstadoDocumento = ""
            Select Case optCliente.CheckedIndex
                Case 0
                    oeAnticipo.IdClienteProveedor = cboCliente2.Value
                Case 1
                    oeAnticipo.IdClienteProveedor = cboDestinatario.Value
                Case 2
                    oeAnticipo.IdClienteProveedor = cboOtroCliente.Value
            End Select

            lstAnticipo = New List(Of e_MovimientoDocumento)
            If Oper = "Emitir" Then
                oeAnticipo.TipoOperacion = "FAT"
            Else
                oeAnticipo.TipoOperacion = "FAS"
            End If
            CargarAnticipos(olAnticipo.Listar_Anticipos(oeAnticipo))
        Else
            ficDetalle.Tabs(3).Visible = False
            ficDetalle.Tabs(0).Selected = True
            b_anticipo = False
            decAnticipo.Value = 0.0
        End If
        CalcularSubtotalesTotalesMaterial()
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
            If cbAnticipo.Checked Then
                griAnticipos.UpdateData()
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
                griAnticipos.UpdateData()
                CalcularSubtotalesTotalesMaterial()
            End If
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
                    antic.Cells("MontoOriginal").Value = Math.Round(antic.Cells("MontoOperar").Value * decTipoCambio.Value, 2)
                End If
            Else
                If antic.Cells("IdMoneda").Value = "1CH01" Then
                    antic.Cells("MontoOriginal").Value = Math.Round(antic.Cells("MontoOperar").Value / decTipoCambio.Value, 2)
                Else
                    antic.Cells("MontoOriginal").Value = Math.Round(antic.Cells("MontoOperar").Value, 2)
                End If
            End If
        Next
        decAnticipo.Value = Calcular_Monto_Anticipo()
        CalcularSubtotalesTotalesMaterial()
    End Sub

    Private Sub CalcularSubtotalesTotalesMaterial()
        decSubTotal.Value = leDetalleDocOD.Sum(Function(item) item.Valor) - decAnticipo.Value
        decImpuesto.Value = decSubTotal.Value * oeIGV.Porcentaje
        'decTotal.Value = Math.Round(decSubTotal.Value, 2) + Math.Round(decImpuesto.Value, 2)
        decTotal.Value = decSubTotal.Value + decImpuesto.Value
        If decTotal.Value <= 0.0 Then
            decImporteDetraer.Value = 0.0
            decDetraccion.Value = 0.0
            decNetoPagar.Value = 0.0
            verDetraccionCero.Checked = True
        End If
    End Sub
End Class