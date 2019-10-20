'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win

Public Class frm_ComprobanteCompra
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Public WithEvents oeMovimientoDocumento As New e_MovimientoDocumento

    Private olMovimientoDocumento As New l_MovimientoDocumento
    Private oeDocAsoc As New e_MovimientoDocumento, leDocAsoc As New List(Of e_MovimientoDocumento)
    Private oeMovimientoAnalisis As New e_MovimientoAnalisis
    ''' <summary>
    ''' lista de analisis que viene de documentos a rendir
    ''' </summary>
    ''' <remarks></remarks>
    Private leMovimientoAnalisisAGrega As List(Of e_MovimientoAnalisis)
    Private leProveedor As New List(Of e_Proveedor)
    Private leTipoCompra As New List(Of e_TablaContableDet)
    Private oeCta As New e_CuentaContable
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private _IGV As Double
    Private olImp As New l_Impuesto, oeIGV As New e_Impuesto
    Private oeItemGasto As e_ItemGasto, leItemGasto As New List(Of e_ItemGasto)
    Private _ComboPeriodo As Boolean = False, _BandLeasing As Boolean = False
    Private _ComboTipoCompra As String = ""
    Private _ItemCta As String = ""
    Private Shared instancia As frm_ComprobanteCompra = Nothing
    Private Shared Operacion As String
    Private Ejercicio As Integer = 0
    Private oeObligacionfin As New e_ObligacionFin, olObligacionFin As New l_ObligacionFinanciera, leObligacionFin As New List(Of e_ObligacionFin)
    Private oeTipoDoc As New e_TipoDocumento, leTipoDoc As New List(Of e_TipoDocumento), olTipoDoc As New l_TipoDocumento
    Public olAsiento As New l_Asiento
    Public TipoOrigen As String = "C"
    Public IndOrigen As Integer
    Dim oeCuota As New e_CuotaDocumentoVehiculo, olCuota As New l_CuotaDocumentoVehiculo, leCuota As New List(Of e_CuotaDocumentoVehiculo)
    Dim olCombo As New l_Combo
    Private oeCuotaMovimiento As New e_CuotaDocVeh_Movimiento, leCuotaMovimiento As New List(Of e_CuotaDocVeh_Movimiento)
    Dim oeOperacionDetalle As New e_OperacionDetalle
    Dim olOperacion As New l_Operacion
    Dim olProveedor As New l_Proveedor
    Private _CodigoDoc As String = String.Empty

    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)

    'variables para retencion de rrhh
    Private oeEmpresaAporte As New e_EmpresaAportacion
    Private olEmpresaAporte As New l_EmpresaAportacion

    Private lenSerie As Integer = 0, lenNumero As Integer = 0

    Private oeMovDocSel As e_MovimientoDocumento
#End Region

#Region "Definición del Formulario base"

    ''' <summary>
    ''' Para modulo de documentos a rendir
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal oeDoc As e_MovimientoDocumento, ByVal oeIG As e_ItemGasto, ByVal leMovAGrega As List(Of e_MovimientoAnalisis))

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        oeMovimientoDocumento = oeDoc
        oeItemGasto = oeIG
        leMovimientoAnalisisAGrega = leMovAGrega
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ComprobanteCompra()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If cboMes.SelectedIndex <> -1 Then
                Listar(Activo)
                If gridComprobanteCompra.Rows.Count > 0 Then
                    MyBase.Consultar(Activo) 'activa desactiva botonera
                Else
                    MyBase.Consultar() 'activa desactiva botonera
                End If
            Else
                mensajeEmergente.Problema("Seleccione Mes", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        If cboMes.SelectedIndex <> -1 Then
            Inicializar()
            oeMovimientoDocumento.IdPeriodo = cboMes.Value
            oeMovimientoDocumento.FechaFinal = oePeriodo.FechaFin
            oeMovimientoDocumento.TipoOperacion = "I"
            oeMovimientoDocumento.Compra.TipoOperacion = "I"
            oeMovimientoDocumento.Modificado = False
            cboTipoDocumento.Focus()
            MyBase.Nuevo() 'activa desactiva botonera
            Operacion = "Nuevo"
            grupoVerificacion.Visible = False
            grupoVerificar.Visible = False
            grupoDoctRendir.Visible = False
        Else
            mensajeEmergente.Problema("Seleccione Mes", True)
        End If
    End Sub

    Public Overrides Sub Editar()
        Try
            Dim ol_FuncionesGenerales As New l_FuncionesGenerales
            ValidarGrilla(gridComprobanteCompra, "Comprobante compra")
            If Not gridComprobanteCompra.ActiveRow Is Nothing AndAlso Not String.IsNullOrEmpty(gridComprobanteCompra.ActiveRow.Cells("Id").Value) Then
                Inicializar()
                Mostrar()
                oeMovimientoDocumento.TipoOperacion = "A"
                oeMovimientoDocumento.Compra.TipoOperacion = "A"
                If oeMovimientoDocumento.MovimientoAnalisis.Count > 0 Then
                    For Each obj As e_MovimientoAnalisis In oeMovimientoDocumento.MovimientoAnalisis
                        obj.TipoOperacion = "I"
                    Next
                End If
                oeMovimientoDocumento.Modificado = False
                MostrarTabs(0, tcComprobanteDetalle)
                cboTipoDocumento.Focus()
                MyBase.Editar()
                Operacion = "Editar"
                grupoVerificacion.Visible = True
                grupoVerificar.Visible = True
                grupoVerificar.Enabled = True
                MostrarVerficacion()
            Else
                Throw New Exception("Seleccione una Fila!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            MostrarTabs(0, tcComprobanteCompra)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If grupoCabeceraAsiento.Enabled Then
                If GuardarComprobante() Then
                    MyBase.Guardar()
                    Operacion = ""
                Else
                    MostrarTabs(1, tcComprobanteCompra)
                End If
            Else
                MostrarTabs(0, tcComprobanteCompra)
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
                        If Not GuardarComprobante() Then
                            MostrarTabs(1, tcComprobanteCompra)
                            MyBase.Consultar(True) 'activa desactiva botonera
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcComprobanteCompra)
                        MyBase.Consultar(True) 'activa desactiva botonera
                        Operacion = ""
                End Select
            Else
                MostrarTabs(0, tcComprobanteCompra)
                MyBase.Consultar(True) 'activa desactiva botonera
                Operacion = ""
            End If
            chkLeasing.Checked = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With gridComprobanteCompra
                ValidarGrilla(gridComprobanteCompra, "Comprobante")
                If Not .ActiveRow Is Nothing AndAlso .ActiveRow.Cells("Id").Value.ToString <> "" Then
                    oeMovimientoDocumento.Id = .ActiveRow.Cells("Id").Value
                    oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                    l_FuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Contabilidad, Date.Parse("01/01/1901"), "")
                    If oeMovimientoDocumento.Activo Then
                        IndOrigen = olAsiento.ObtenerOrigenContable(TipoOrigen, oeMovimientoDocumento.Id)
                        If IndOrigen = 6 Then
                            If MessageBox.Show("Esta seguro de eliminar el Comprobante: " & _
                                 .ActiveRow.Cells("Serie").Value.ToString & .ActiveRow.Cells("Numero").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeMovimientoDocumento.TipoOperacion = "E"
                                olMovimientoDocumento.EliminarComprobante(oeMovimientoDocumento)
                                Consultar(True)
                                Operacion = ""
                            End If
                        Else
                            If IndOrigen = 2 Or IndOrigen = 3 Or IndOrigen = 4 Or IndOrigen = 5 Then
                                If MessageBox.Show("El documento " & _
                                 .ActiveRow.Cells("Serie").Value.ToString & .ActiveRow.Cells("Numero").Value.ToString & " es de origen logístico, su eliminación será un extorno, desea continuar?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                    Extornar()
                                End If
                            ElseIf IndOrigen = 7 Then
                                Throw New Exception("Documento de liquidación; no puede ser eliminado desde este módulo")
                            ElseIf IndOrigen = 8 Then
                                Throw New Exception("Documento de Caja chica; no puede ser eliminado desde este módulo")
                            Else
                                Throw New Exception("Por un mejor control, no se puede eliminar este documento, comuníquese con Sistemas")
                            End If
                        End If
                    Else
                        Operacion = ""
                    End If
                Else
                    Operacion = ""
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If gridComprobanteCompra.Rows.Count = 0 Then Throw New Exception("No hay ningún Comprobante de Compra para exportar al Excel")
            Exportar_Excel(gridComprobanteCompra)

            If gridDetalleAsientoAnalisis.Rows.Count = 0 Then Throw New Exception("No hay ningún Detalle de Asiento de Análisis para exportar al Excel")
            Exportar_Excel(gridDetalleAsientoAnalisis)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub ListarLeasing()
        Try
            leObligacionFin = New List(Of e_ObligacionFin)
            oeObligacionfin = New e_ObligacionFin
            oeObligacionfin.Activo = True
            oeObligacionfin.Banco = cbeCtaCte.Value
            oeObligacionfin.TipoOperacion = "H"
            oeObligacionfin.FechaInicio = FecEmision.Value
            leObligacionFin.AddRange(olObligacionFin.Listar2(oeObligacionfin))
            With cboCodigoLeasing
                .DisplayMember = "NroContrato"
                .ValueMember = "Id"
                .DataSource = leObligacionFin
                .DataBind()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        ItemGastoGRILLA()
        _ItemCta = ""
        oeMovimientoDocumento = New e_MovimientoDocumento
        With oeMovimientoDocumento
            .IndCompraVenta = 1 'indica compra
            ._Operador = 1 'positivo para proveedores-compras
            .IdUsuarioCrea = gUsuarioSGI.Id
            .EstadoDocumento = "EMITIDA"
            .Compra.AnoEmisionAduana = Date.Now.Year
            .MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
        End With
        grupoCabeceraAsiento.Enabled = True : grupoObligaciones.Enabled = True : grupoDoctRendir.Enabled = True : grupoDetalle.Enabled = True
        grupoMontaCarga.Enabled = True : gridDetalleAsientoAnalisis.Enabled = True
        oeDocAsoc = New e_MovimientoDocumento : leDocAsoc = New List(Of e_MovimientoDocumento)
        cboTipoDocumento.SelectedIndex = -1 : FecEmision.Value = Date.Now : FecVencimiento.Value = Date.Now : txtNroSerie.Text = "" : cbeCtaCte.Value = Nothing
        txtNroDocumento.Text = "" : cboMoneda.SelectedIndex = -1 : decTC.Value = 0 : cboTipoCompra.SelectedIndex = -1 : cbeCtaCte.Text = String.Empty
        DecBi1.Value = 0 : DecBi2.Value = 0 : DecBi3.Value = 0 : DecIgv2.Value = 0 : DecIgv1.Value = 0 : DecIgv3.Value = 0 : DecISC.Value = 0
        DecOtrosTributos.Value = 0 : DecNoGravadas.Value = 0 : DecTotalImponible.Value = 0 : DecTotalIgv.Value = 0 : DecTotalDoc.Value = 0
        MostrarTabs(1, tcComprobanteCompra, 1) 'inicializamos
        ComboTipoCompra()
        cboCuenta.SelectedIndex = -1 : cboGastonFuncion.SelectedIndex = -1 : cboGastonFuncion.Enabled = False : cboItemGasto.SelectedIndex = -1
        cboItemGasto.Enabled = False : cboCentroCosto.SelectedIndex = -1 : cboCentroCosto.Enabled = False : cboTrabajador.SelectedIndex = -1
        cboTrabajador.Enabled = False : ChkVehiculoProper.Checked = False : cboVehiculo.SelectedIndex = -1 : cboVehiculo.Enabled = False
        cboRuta.SelectedIndex = -1 : cboRuta.Enabled = False : cboBanco.SelectedIndex = -1 : cboBanco.Enabled = False : cboAnalisis1.SelectedIndex = -1
        cboAnalisis1.Enabled = False : cboAnalisis2.SelectedIndex = -1 : cboAnalisis2.Enabled = False : DecMontoAn.Value = 0
        'cmbAgregar.Enabled = False
        LimpiaGrid(gridDetalleAsientoAnalisis, UltraDataSource4)
        LimpiaGrid(GriComprobanteAsociado, UltraDataSource3)
        MostrarTabs(0, tcComprobanteDetalle) 'inicializamos
        ListaCuentasContable(gridDetalleAsientoAnalisis, "IdCuentaContable", dtpFechaEjercicio.Value.Year, "Nombre")
        Lblsuario.Text = "--" : LblFeccha.Text = "--/--/--"
        _CodigoDoc = String.Empty : _BandLeasing = False
        cbCaja.Checked = False
        lenSerie = 4
        lenNumero = 10
        txtNroSerie.MaxLength = lenSerie
        txtNroDocumento.MaxLength = lenNumero
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                .Activo = Activo
                .IdPeriodo = cboMes.Value
                Dim oepro As New e_Proveedor
                oepro.Id = cboProveedores.Value
                oepro.TipoOperacion = "5"
                oepro = olProveedor.Obtener(oepro)
                If oepro.Id <> "" Then
                    .IdClienteProveedor = cboProveedores.Value
                Else
                    .IdClienteProveedor = ""
                End If
                .IndCompraVenta = 1 'Indica Compras
                .TipoOperacion = "CON"
            End With

            LimpiaGrid(gridComprobanteCompra, UltraDataSource1)
            With gridComprobanteCompra
                .DataSource = olMovimientoDocumento.Listar(oeMovimientoDocumento)
            End With
            CalcularTotales(gridComprobanteCompra, "SubTotal", "IGV", "Total")
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
        gridComprobanteCompra.Focus()
    End Sub

    ''' <summary>
    ''' traigo los documentos asociados, lista de objetos de la clase e_MovimientoDocumento
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ListarDocumentoAsociado()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim oeMovimientoDocumentoAsoc As New e_MovimientoDocumento
            oeMovimientoDocumentoAsoc.Activo = True
            'oeMovimientoDocumentoAsoc.Ejercicio = Ejercicio
            oeMovimientoDocumentoAsoc.FechaEmision = oeMovimientoDocumento.FechaEmision
            oeMovimientoDocumentoAsoc.IndCompraVenta = 1 'Indica compra
            oeMovimientoDocumentoAsoc.IdClienteProveedor = oeMovimientoDocumento.IdClienteProveedor
            oeMovimientoDocumentoAsoc._Operador = 1
            oeMovimientoDocumentoAsoc.TipoOperacion = "CON"
            GriSeleccionaComprobante.DataSource = New List(Of e_MovimientoDocumento)
            With GriSeleccionaComprobante
                .DataSource = olMovimientoDocumento.Listar(oeMovimientoDocumentoAsoc)
            End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        gridComprobanteCompra.Focus()
    End Sub

    Private Sub Mostrar()
        Try
            If gridComprobanteCompra.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeMovimientoDocumento.Id = gridComprobanteCompra.ActiveRow.Cells("Id").Value.ToString
                oeMovimientoDocumento = olMovimientoDocumento.ObtenerCompra(oeMovimientoDocumento)
                If oeMovimientoDocumento.Saldo < oeMovimientoDocumento.Total Then
                    mensajeEmergente.Problema("Existen Pagos asociados, Desea Continuar?", True)
                    grupoDoctRendir.Enabled = False : grupoCabeceraAsiento.Enabled = False : grupoObligaciones.Enabled = False : grupoDetalle.Enabled = False
                    grupoObligaciones.Enabled = False : gridDetalleAsientoAnalisis.Enabled = False : tcComprobanteDetalle.Enabled = False
                Else
                    grupoDoctRendir.Enabled = True : grupoCabeceraAsiento.Enabled = True : grupoObligaciones.Enabled = True : grupoDetalle.Enabled = True
                    grupoObligaciones.Enabled = True : gridDetalleAsientoAnalisis.Enabled = True : tcComprobanteDetalle.Enabled = True
                End If
                With oeMovimientoDocumento
                    cboTipoDocumento.Value = .IdTipoDocumento : txtNroSerie.Text = .Serie : txtNroDocumento.Text = .Numero : FecEmision.Value = .FechaEmision
                    FecVencimiento.Value = .FechaVencimiento : cboMoneda.Value = .IdMoneda : cbeCtaCte.Value = .IdClienteProveedor : cboTipoCompra.Value = .Compra.IdTipoCompra
                    If cboTipoCompra.SelectedIndex <> -1 Then CargaCuenta(cboTipoCompra.Value)
                    _ComboTipoCompra = cboTipoCompra.Value : decTC.Value = .TipoCambio
                    If cboMoneda.Text = "SOLES" Then
                        DecBi1.Value = .Compra.Base1 : DecBi2.Value = .Compra.Base2 : DecBi3.Value = .Compra.Base3 : DecIgv1.Value = .Compra.Igv1 : DecIgv2.Value = .Compra.Igv2
                        DecIgv3.Value = .Compra.Igv3 : DecISC.Value = .Compra.Isc : DecOtrosTributos.Value = .Compra.OtrosTributos : DecNoGravadas.Value = .Compra.NoGravadas
                    Else
                        DecBi1.Value = .Compra.Base1 / .TipoCambio : DecBi2.Value = .Compra.Base2 / .TipoCambio : DecBi3.Value = .Compra.Base3 / .TipoCambio
                        DecIgv1.Value = .Compra.Igv1 / .TipoCambio : DecIgv2.Value = .Compra.Igv2 / .TipoCambio : DecIgv3.Value = .Compra.Igv3 / .TipoCambio
                        DecISC.Value = .Compra.Isc / .TipoCambio : DecOtrosTributos.Value = .Compra.OtrosTributos / .TipoCambio
                        DecNoGravadas.Value = .Compra.NoGravadas / .TipoCambio
                    End If
                    cbCaja.Checked = IIf(.Compra.CobraCajaChica = 1, True, False)
                    DecTotalImponible.Value = DecBi1.Value + DecBi2.Value + DecBi3.Value
                    DecTotalIgv.Value = DecIgv1.Value + DecIgv2.Value + DecIgv3.Value
                    DecTotalDoc.Value = DecTotalImponible.Value + DecTotalIgv.Value + .Compra.Isc + .Compra.OtrosTributos + .Compra.NoGravadas
                    If cboTipoDocumento.Text = "NOTA DE CRÉDITO" OrElse cboTipoDocumento.Text = "NOTA DE DÉBITO" Then
                        Dim oeDocAsoc As New e_DocumentoAsociado
                        Dim olDocAsoc As New l_DocumentoAsociado
                        oeDocAsoc.IdMovimientoDocumento = .Id
                        leDocAsoc.AddRange(olDocAsoc.ListarDocAsoc(oeDocAsoc))
                        CargaComprobanteDetalles(leDocAsoc)
                    End If
                    CargaComprobantesAnalisis(oeMovimientoDocumento.MovimientoAnalisis)
                    If _CodigoDoc = "13" Then ObtenerLeasingAsociado(oeMovimientoDocumento.Id)
                End With
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarParaDocumentoXRendir()
        Try
            oeMovimientoDocumento.TipoOperacion = "I"
            With oeMovimientoDocumento
                cboTipoDocumento.Value = ""
                txtNroSerie.Text = ""
                txtNroDocumento.Text = ""
                FecEmision.Value = .FechaEmision
                FecVencimiento.Value = .FechaEmision
                cboMoneda.Value = .IdMoneda
                cbeCtaCte.Value = .IdClienteProveedor
                cboMes.Value = .IdPeriodo
                For j As Integer = 0 To cboTipoCompra.Items.Count - 1
                    Dim i As Integer = Strings.Len(.Compra.IdTipoCompra)
                    Dim oeTablaContableDet As e_TablaContableDet = cboTipoCompra.Items(j).ListObject
                    Do While i > 0
                        If oeTablaContableDet.Texto1.Trim = Strings.Left(.Compra.IdTipoCompra, i) Then
                            cboTipoCompra.Value = oeTablaContableDet.Id
                            Exit For
                        End If
                        i -= 1
                    Loop
                Next
                CargaCuenta(cboTipoCompra.Value)
                _ComboTipoCompra = cboTipoCompra.Value
                If leMovimientoAnalisisAGrega.Count > 0 Then
                    cboCuenta.Value = oeItemGasto.IdCuentaContable
                    Dim i As Integer = cboCuenta.SelectedIndex
                    oeCta = cboCuenta.Items(i).ListObject
                    CargaCombosSegunCta()
                    cboItemGasto.Value = leMovimientoAnalisisAGrega.Item(0).IdItemGasto
                End If
                'FecEmision.Value = .FechaEmision
                decTC.Value = .TipoCambio
                DecBi1.Value = (.Total - .NoGravado) / (1 + oeIGV.Porcentaje)
                DecBi2.Value = 0
                DecBi3.Value = 0
                DecIgv1.Value = (.Total - .NoGravado) - DecBi1.Value
                DecIgv2.Value = 0
                DecIgv3.Value = 0
                DecISC.Value = 0
                DecOtrosTributos.Value = 0
                DecNoGravadas.Value = .NoGravado
                DecTotalImponible.Value = DecBi1.Value + DecBi2.Value + DecBi3.Value
                DecTotalIgv.Value = DecIgv1.Value + DecIgv2.Value + DecIgv3.Value
                DecTotalDoc.Value = DecTotalImponible.Value + DecTotalIgv.Value + .Compra.Isc + .Compra.OtrosTributos + .Compra.NoGravadas
                Dim oeMovAna As New e_MovimientoAnalisis
                oeMovimientoDocumento.MovimientoAnalisis = New List(Of e_MovimientoAnalisis)
                For Each Obj As e_MovimientoAnalisis In leMovimientoAnalisisAGrega
                    oeMovAna = Obj.Clone
                    'oeMovAna.IdCuentaContable = Obj.IdCuentaContable.Clone
                    'oeMovAna.IdItemGasto = Obj.IdItemGasto.Clone
                    If oeMovAna.IdGastoFuncion.Trim = "" Then
                        oeMovAna.IdGastoFuncion = "1CH000087" 'costo de venta 
                    End If
                    oeMovAna.IdCuentaContable = oeItemGasto.IdCuentaContable
                    oeMovAna.IdItemGasto = oeItemGasto.Id
                    oeMovAna.TipoOperacion = "I"
                    oeMovAna.Monto = oeMovAna.SaldoSinIgv
                    oeMovAna.Saldo = 0
                    oeMovimientoDocumento.MovimientoAnalisis.Add(oeMovAna)
                Next
                CargaComprobantesAnalisis(oeMovimientoDocumento.MovimientoAnalisis)
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Carga documentos, lista de objetos de la clase de e_movimientodocumentos asociado a una nota de credito
    ''' </summary>
    ''' <param name="oeAsDetDet"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub CargaComprobanteDetalles(ByVal oeAsDetDet As List(Of e_MovimientoDocumento))
        Try
            With GriComprobanteAsociado
                LimpiaGrid(GriComprobanteAsociado, UltraDataSource2)
                If Not oeAsDetDet Is Nothing Then
                    Dim leASiento As New List(Of e_MovimientoDocumento)
                    '-----------obtengo lista de objetos activos
                    leASiento = oeAsDetDet.Where(Function(item) item.TipoOperacion <> "E").ToList
                    '-----------------
                    .DataSource = leASiento
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True

                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Validar_ExistenciaComprobante()
        Try
            With oeMovimientoDocumento
                Dim validar As Boolean = False
                Dim oeMovDocAUx As New e_MovimientoDocumento
                Dim oeCompraAux As New e_Compra
                Dim olCompraAux As New l_Compra
                Dim lst_MovDocAUx As New List(Of e_MovimientoDocumento)
                Dim num_doc1 As String = ""
                Dim num_doc2 As String = ""
                If .TipoOperacion = "I" Then
                    oeMovDocAUx.IdTipoDocumento = .IdTipoDocumento
                    oeMovDocAUx.Serie = .Serie
                    If Not IsNumeric(.Numero) Then
                        oeMovDocAUx.Numero = .Numero
                    Else
                        oeMovDocAUx.Numero = CStr(CType(.Numero, Int64))
                    End If

                    oeMovDocAUx.IdClienteProveedor = .IdClienteProveedor
                    oeMovDocAUx.TipoOperacion = "VDC"
                    oeMovDocAUx.IndCompraVenta = .IndCompraVenta
                    lst_MovDocAUx = olMovimientoDocumento.Listar(oeMovDocAUx)
                    If lst_MovDocAUx.Count > 0 Then Throw New Exception("El comprobante " & .Serie & "-" & .Numero & " de " & cbeCtaCte.Text & " ya ha sido registrado.")
                ElseIf .TipoOperacion = "ACT" Or .TipoOperacion = "A" Then
                    .FechaFinal = oePeriodo.FechaFin
                    oeMovDocAUx.TipoOperacion = ""
                    oeMovDocAUx.Id = IIf(.TipoOperacion = "ACT", gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("Id").Value, .Id)
                    oeMovDocSel = olMovimientoDocumento.Obtener(oeMovDocAUx)
                    oeCompraAux.IdMovimientoDocumento = oeMovDocSel.Id
                    oeCompraAux.Activo = 1
                    oeCompraAux = olCompraAux.Obtener(oeCompraAux)
                    If oeMovDocSel.IdTipoDocumento = IIf(.TipoOperacion = "ACT", gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("IdTipoDocumento").Value, cboTipoDocumento.Value) Then
                        If oeMovDocSel.IdClienteProveedor = .IdClienteProveedor Then
                            If Not IsNumeric(oeMovDocSel.Numero) Then
                                num_doc1 = oeMovDocSel.Numero
                            Else
                                num_doc1 = CStr(CType(oeMovDocSel.Numero, Int64))
                            End If
                            If Not IsNumeric(.Numero) Then
                                num_doc2 = .Numero
                            Else
                                num_doc2 = CStr(CType(.Numero, Int64))
                            End If
                            If oeMovDocSel.Serie = .Serie And num_doc1 = num_doc2 Then
                                If oeMovDocSel.FechaEmision = IIf(.TipoOperacion = "ACT", gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("FechaEmision").Value, .FechaEmision) And oeMovDocSel.FechaVencimiento = IIf(.TipoOperacion = "ACT", gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("FechaVencimiento").Value, .FechaVencimiento) Then
                                    If .TipoOperacion = "ACT" Then
                                        gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("FechaEmision").Value = oeMovDocSel.FechaEmision
                                        gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("FechaVencimiento").Value = oeMovDocSel.FechaVencimiento
                                    End If
                                    If oeCompraAux.IndDetraccion = gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("IndDetraccion").Value And .TipoOperacion = "ACT" Then
                                        Throw New Exception("El comprobante " & .Serie & "-" & .Numero & " de " & IIf(.TipoOperacion = "ACT", gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("NombreProveedor").Value, cbeCtaCte.Text) & " no necesita actualizar.")
                                    End If
                                    If .TipoOperacion = "A" Then
                                        Throw New Exception("El comprobante " & .Serie & "-" & .Numero & " de " & cbeCtaCte.Text & " no necesita actualizar.")
                                    End If
                                End If
                            Else
                                validar = True
                            End If
                        Else
                            validar = True
                        End If
                    Else
                        validar = True
                    End If
                End If

                If validar = True Then
                    oeMovDocAUx.IdTipoDocumento = IIf(.TipoOperacion = "ACT", gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("IdTipoDocumento").Value, cboTipoDocumento.Value)
                    oeMovDocAUx.Serie = .Serie
                    If Not IsNumeric(.Numero) Then
                        oeMovDocAUx.Numero = .Numero
                    Else
                        oeMovDocAUx.Numero = CStr(CType(.Numero, Int64))
                    End If
                    oeMovDocAUx.IdClienteProveedor = .IdClienteProveedor
                    oeMovDocAUx.TipoOperacion = "VDC"
                    oeMovDocAUx.IndCompraVenta = IIf(.TipoOperacion = "ACT", gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("IndCompraVenta").Value, .IndCompraVenta)
                    lst_MovDocAUx = olMovimientoDocumento.Listar(oeMovDocAUx)
                    If lst_MovDocAUx.Count > 0 Then
                        If .TipoOperacion = "ACT" Then
                            gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("Serie").Value = oeMovDocSel.Serie
                            gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("Numero").Value = oeMovDocSel.Numero
                        End If
                        Throw New Exception("El comprobante " & .Serie & "-" & .Numero & " de " & gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("NombreProveedor").Value & " ya ha sido registrado.")
                    End If
                    'Else
                    '    Throw New Exception("El comprobante " & .Serie & "-" & .Numero & " de " & IIf(.TipoOperacion = "ACT", gridComprobanteCompra.Rows(gridComprobanteCompra.ActiveRow.Index).Cells("NombreProveedor").Value, cbeCtaCte.Text) & " no necesita actualizar.")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarComprobante() As Boolean
        Try
            If ValidaComprobante() Then
                SumaTotales()
                CargaComprobantesAsociados()
                With oeMovimientoDocumento
                    Validar_ExistenciaComprobante()
                    .IndOrigenContable = 6
                    .Mac_PC_Local = MacPCLocal()
                    .EstadoDocumento = "ENVIADO"
                    If cboMoneda.Value = "1CH02" Then
                        .Compra.Base1 = DecBi1.Value * decTC.Value : .Compra.Base2 = DecBi2.Value * decTC.Value : .Compra.Base3 = DecBi3.Value * decTC.Value
                        .Compra.Igv1 = DecIgv1.Value * decTC.Value : .Compra.Igv2 = DecIgv2.Value * decTC.Value : .Compra.Igv3 = DecIgv3.Value * decTC.Value
                        .Compra.Isc = DecISC.Value * decTC.Value : .Compra.OtrosTributos = DecOtrosTributos.Value * decTC.Value
                        .Compra.NoGravadas = DecNoGravadas.Value * decTC.Value
                    Else
                        .Compra.Base1 = DecBi1.Value : .Compra.Base2 = DecBi2.Value : .Compra.Base3 = DecBi3.Value : .Compra.Igv1 = DecIgv1.Value
                        .Compra.Igv2 = DecIgv2.Value : .Compra.Igv3 = DecIgv3.Value : .Compra.Isc = DecISC.Value : .Compra.OtrosTributos = DecOtrosTributos.Value
                        .Compra.NoGravadas = DecNoGravadas.Value
                    End If
                    .Compra.CobraCajaChica = IIf(cbCaja.Checked, 1, 0)
                    .leCuotaDocVehMovimiento.Clear()
                    oeObligacionfin.TipoCambio = decTC.Value
                    If ChkCupon.Checked Then
                        Dim oe As New e_CuotaDocumentoVehiculo
                        oeCuotaMovimiento = New e_CuotaDocVeh_Movimiento
                        oeCuotaMovimiento.TipoOperacion = "I"
                        oeCuotaMovimiento.Tipo = "C"
                        oeCuotaMovimiento.Glosa = "COMPROBANTE DE COMPRA DE CUPÓN: " + CboFilPoliza.Text + " EL: " + CDate(FecEmision.Value).Date
                        oeCuotaMovimiento.Fecha = FecEmision.Value
                        oeCuotaMovimiento.IdMovimientoDocumento = ""
                        oeCuotaMovimiento.IdMovimientoCajaBanco = ""
                        oeCuotaMovimiento.IdMoneda = cboMoneda.Value
                        oeCuotaMovimiento.TipoCambio = decTC.Value
                        If oeCuotaMovimiento.IdMoneda = "1CH01" Then
                            oeCuotaMovimiento.MontoMN = nd_MontoOperaCupon.Value
                            oeCuotaMovimiento.MontoME = nd_MontoOperaCupon.Value / decTC.Value
                        ElseIf oeCuotaMovimiento.IdMoneda = "1CH02" Then
                            oeCuotaMovimiento.MontoMN = nd_MontoOperaCupon.Value * decTC.Value
                            oeCuotaMovimiento.MontoME = nd_MontoOperaCupon.Value
                        End If
                        oeCuotaMovimiento.Activo = 1
                        oeCuotaMovimiento.UsuarioCreacion = gUsuarioSGI.Id
                        oeCuotaMovimiento.FechaCeacion = Date.Now()
                        oeCuotaMovimiento.leCuota.Clear()
                        oe = leCuota.Where(Function(item) item.Id = CboFilPoliza.Value)(0)
                        oeCuotaMovimiento.leCuota.Add(oe)
                        leCuotaMovimiento.Add(oeCuotaMovimiento)
                        .leCuotaDocVehMovimiento = leCuotaMovimiento
                    End If

                End With
                oeMovimientoDocumento.Compra.TipoOperacion = oeMovimientoDocumento.TipoOperacion
                Dim leMovDoc As New List(Of e_MovimientoDocumento)
                Dim oeMovDoc As e_MovimientoDocumento
                Dim leTCD As New List(Of e_TablaContableDet)
                Dim i As Integer = 0
                For Each obj As e_MovimientoAnalisis In oeMovimientoDocumento.MovimientoAnalisis
                    oeMovDoc = New e_MovimientoDocumento
                    If obj.IdTipoCompraParaCompra Is Nothing Then
                        Throw New Exception("Este Item tiene una cuenta que no tiene Tipo de Compra: " & obj.Cuenta)
                    End If
                    If i = 0 Then
                        oeMovimientoDocumento.Compra.IdTipoCompra = obj.IdTipoCompraParaCompra
                        oeMovDoc = oeMovimientoDocumento.Clonar
                        oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                        oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
                        oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
                        oeMovDoc.Compra.Base1 = obj.Monto
                        leTCD = leTipoCompra.Where(Function(item) item.Id = obj.IdTipoCompraParaCompra).ToList
                        oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
                        oeMovimientoDocumento.Compra.IdTipoCompra = leTCD.Item(0).Id
                        leMovDoc.Add(oeMovDoc)
                    ElseIf obj.IdTipoCompraParaCompra = oeMovimientoDocumento.MovimientoAnalisis(i - 1).IdTipoCompraParaCompra Then
                        leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 = leMovDoc.Item(leMovDoc.Count - 1).Compra.Base1 + obj.Monto
                    Else
                        oeMovDoc = oeMovimientoDocumento.Clonar
                        oeMovDoc.Compra.TipoDoc = oeMovimientoDocumento.Compra.TipoDoc
                        oeMovDoc.Compra.Proveedor = oeMovimientoDocumento.Compra.Proveedor
                        oeMovDoc.Compra.Moneda = oeMovimientoDocumento.Compra.Moneda
                        oeMovDoc.Compra.Base1 = obj.Monto
                        leTCD = leTipoCompra.Where(Function(item) item.Id = obj.IdTipoCompraParaCompra).ToList
                        oeMovDoc.Compra.TipoCompra = leTCD.Item(0)
                        oeMovDoc.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leMovDoc.Add(oeMovDoc)
                    End If
                    i = i + 1
                Next
                'If oeMovimientoDocumento.IdTipoDocumento = "1CH000000043" Then
                '    If oeMovimientoDocumento.FechaEmision.Date >= Date.Parse("01/08/2014") Then ObtenerAportes()
                'End If
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                olMovimientoDocumento.GuardarCompra(oeMovimientoDocumento, leMovDoc, True, IIf(chkLeasing.Checked, oeObligacionfin, Nothing))
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                MostrarTabs(0, tcComprobanteCompra, 2)
                Consultar(True)
                gridComprobanteCompra.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaComprobante() As Boolean
        Try
            ValidarCombo(cboTipoDocumento, "TipoDocumento")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtNroSerie.Text, "Ingrese la Serie")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtNroDocumento.Text, "Ingrese el Número")
            ValidarCombo(cboMoneda, "Moneda")
            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de Cambio")
            ValidarCombo(cbeCtaCte, "Cuenta Corriente")
            If oeMovimientoDocumento.TipoOperacion = "I" Then ValidarCombo(cboTipoCompra, "Tipo de Compra")
            If DecTotalImponible.Value + DecNoGravadas.Value = 0 Then
                l_FuncionesGenerales.ValidarNumero(DecTotalImponible.Value, "Ingrese Base Imponible y/o No Gravada")
            End If

            txtNroSerie.Text = gfc_ConcatenarCeros(txtNroSerie.Text, lenSerie)
            gfc_ValidarSerieDoc(txtNroSerie.Text, oeTipoDoc.Codigo)
            'If Not IsNumeric(txtNroDocumento.Text) Then Throw New Exception("El valor ingresado deber ser numérico")
            txtNroDocumento.Text = gfc_ConcatenarCeros(txtNroDocumento.Text, lenNumero)
            gfc_ValidarNumeroDoc(txtNroDocumento.Text, oeTipoDoc.Codigo)

            If oePeriodo.Ejercicio = Year(FecEmision.Value) Then
                If oePeriodo.Mes < Month(FecEmision.Value) Then Throw New Exception("El mes de la fecha de emision tiene que ser o menor: " & oePeriodo.Mes.ToString)
                'ElseIf oePeriodo.Ejercicio <> Year(FecEmision.Value) Then
                '    Throw New Exception("El año de la fecha de emision tiene que ser: " & oePeriodo.Ejercicio.ToString)
            End If
            If Date.Parse(FecEmision.Value).Date > Date.Parse(FecVencimiento.Value).Date Then Throw New Exception("La fecha de Emision no puede ser mayor a la fecha de vencimiento")
            If decTC.Value <= 0 Then Throw New Exception("Ingrese Tipo de Cambio")

            If oeMovimientoDocumento.Compra.TipoDoc.Codigo.Trim = "07" AndAlso Not GriComprobanteAsociado.Rows.Count > 0 Then Throw New Exception("Ingrese Documentos Asociado")

            Dim ln_Valor As Double = DecNoGravadas.Value + DecTotalImponible.Value
            Dim ln_ValorAgregado As Double = 0
            Dim PasaCuentaLeasingMonto As Boolean = True
            Dim PasaCuentaLeasingcta As Boolean = True
            For Each obj As e_MovimientoAnalisis In oeMovimientoDocumento.MovimientoAnalisis
                If obj.TipoOperacion <> "E" Then
                    ln_ValorAgregado = ln_ValorAgregado + obj.Monto
                End If
                If chkLeasing.Checked Then
                    If obj.IdCuentaContable = oeObligacionfin.IdCuentaContable Then
                        PasaCuentaLeasingcta = False
                        If cboMoneda.Value = "1CH01" Then
                            If Math.Round(obj.Monto, 2) = Math.Round(IIf(oeObligacionfin.IdMoneda = "1CH01", _
                            oeObligacionfin.MontoMN + oeObligacionfin.MontoInteres, _
                            (oeObligacionfin.MontoMN + oeObligacionfin.MontoInteres) * decTC.Value), 2) Then
                                PasaCuentaLeasingMonto = False
                            End If
                        Else
                            If Math.Round(obj.Monto, 2) = Math.Round(IIf(oeObligacionfin.IdMoneda = "1CH02", _
                           oeObligacionfin.MontoME + oeObligacionfin.MontoInteres, _
                           (oeObligacionfin.MontoME + oeObligacionfin.MontoInteres) / decTC.Value), 2) Then
                                PasaCuentaLeasingMonto = False
                            End If
                        End If

                    End If
                End If
            Next
            If chkLeasing.Checked Then
                If PasaCuentaLeasingcta Then
                    Throw New Exception("Ingrese Cuenta asociada a leasing como Detalles")
                End If
                If PasaCuentaLeasingMonto Then
                    Throw New Exception("Ingrese Monto igual al saldo + interes a leasing como Detalles")
                End If
            End If

            If Math.Abs(ln_Valor - ln_ValorAgregado) > 0.02 Then Throw New Exception("El Valor de Compra y el Monto Total agregado no son Iguales")

            If ChkCupon.Checked = True Then
                If CboMonedaCupon.SelectedIndex = -1 Then Throw New Exception("Cupon no tiene moneda especifica.")
                If cboMoneda.SelectedIndex = -1 Then Throw New Exception("Anticipo no tiene moneda.")
                If nd_MontoOperaCupon.Value = 0.0 Then Throw New Exception("Monto a pagar de cupón no puede ser 0.0")

                If cboMoneda.Value = "1CH01" Then
                    If CboMonedaCupon.Value = "1CH01" Then
                        If Math.Round(DecTotalDoc.Value, 2) <> Math.Round(nd_MontoOperaCupon.Value, 2) Then Throw New Exception("Monto Soles deben ser iguales con el cupón.")
                    ElseIf CboMonedaCupon.Value = "1CH02" Then
                        Dim monto As Double = 0.0
                        monto = Math.Round(DecTotalDoc.Value / decTC.Value, 2)
                        If monto <> Math.Round(nd_MontoOperaCupon.Value, 2) Then Throw New Exception("El equivalente en dólares del anticipo es diferente al monto en dólares del cupón.")
                    End If
                ElseIf cboMoneda.Value = "1CH02" Then
                    If CboMonedaCupon.Value = "1CH01" Then
                        Dim monto As Double = 0.0
                        monto = Math.Round(DecTotalDoc.Value * decTC.Value, 2)
                        If monto <> Math.Round(nd_MontoOperaCupon.Value, 2) Then Throw New Exception("El equivalente en soles dle anticipo es diferente al monto en soles del cupón.")
                    ElseIf CboMonedaCupon.Value = "1CH02" Then
                        If Math.Round(DecTotalDoc.Value, 2) <> Math.Round(nd_MontoOperaCupon.Value, 2) Then Throw New Exception("Monto en dólares deben ser iguales para el cupón")
                    End If
                End If
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Sub ObtenerAportes()
    '    Try
    '        oeEmpresaAporte = New e_EmpresaAportacion
    '        oeEmpresaAporte.IdEmpresa = oeMovimientoDocumento.IdClienteProveedor
    '        oeEmpresaAporte = olEmpresaAporte.Obtener(oeEmpresaAporte)
    '        If oeEmpresaAporte.Id = "" Then
    '            Dim frm As New frm_EmpresaAportacion
    '            frm.IdEmpresa = oeMovimientoDocumento.IdClienteProveedor
    '            frm.ShowDialog()
    '            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
    '            oeEmpresaAporte = New e_EmpresaAportacion
    '            oeEmpresaAporte.IdEmpresa = oeMovimientoDocumento.IdClienteProveedor
    '            oeEmpresaAporte = olEmpresaAporte.Obtener(oeEmpresaAporte)
    '        End If
    '        If oeEmpresaAporte.Id = "" Then Throw New Exception("Tiene Que Registrar los Datos de AFP del Proveedor")
    '        Dim loHistorialRH As New List(Of e_Combo)
    '        loHistorialRH.AddRange(ListaRH(oeEmpresaAporte.IdEmpresa, oeMovimientoDocumento.FechaEmision))
    '        If oeEmpresaAporte.FechaNacimiento.Date >= Date.Parse("01/08/1973") Then
    '            Dim Total As Double = 0
    '            Total = loHistorialRH.Sum(Function(i) i.Descripcion) + oeMovimientoDocumento.Total
    '            If Total >= 750 Then
    '                If loHistorialRH.Count > 0 Then
    '                    If MessageBox.Show("No Puede Ingresar el Documento, MontoSuperado. Desea ver el Detalle?", "Mensaje de Sistema", _
    '                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
    '                        Dim frm As New frm_DetalleCajaExterna
    '                        frm.MostrarDetalle("3", Nothing, Nothing, Nothing, loHistorialRH)
    '                        frm.ShowDialog()
    '                    End If
    '                End If
    '                Throw New Exception("No puede Ingresar RH se ha Superado el Monto sin Retencion ")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub LlenarCombos()
        Try
            LlenarDocumentosDetraccion()
            ComboPeriodo()
            ComboMoneda()
            ComboTipoDocumentoOperacion()
            ComboProveedor()
            LlenaComboProveedor()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarDocumentosDetraccion()
        loConcepto = New List(Of e_Concepto)
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "41"
        loConcepto = olConcepto.Listar(oeConcepto)
    End Sub

    Private Sub LlenaComboProveedor()
        Dim oeProveedor As New e_Proveedor
        Dim ListaProveedor As New List(Of e_Proveedor)
        oeProveedor.TipoOperacion = "5"
        cboProveedores.Value = Nothing
        ListaProveedor.AddRange(olProveedor.Listar(oeProveedor))
        With cboProveedores
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = ListaProveedor
        End With
        InicializarComboProveedor()
    End Sub

    Public Sub InicializarComboProveedor()
        Try
            Me.cboProveedores.ValueMember = "Id"
            Me.cboProveedores.DisplayMember = "Nombre"
            With cboProveedores.DisplayLayout.Bands(0)
                '.Columns("Id").Hidden = True
                .Columns("Codigo").Hidden = True
                .Columns("TipoPersonaEmpresa").Hidden = True
                .Columns("IdPersona").Hidden = True
                .Columns("IdEmpresa").Hidden = True
                .Columns("FechaActividad").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("Seleccion").Hidden = True
                .Columns("Email").Hidden = True
                .Columns("Contacto").Hidden = True
                .Columns("NroDocumento").Header.Caption = "RUC/DNI"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboMoneda()
        Try
            If cboMoneda.Items.Count = 0 Then
                Dim oeMoneda As New e_Moneda
                Dim olMoneda As New l_Moneda
                Dim leMoneda As New List(Of e_Moneda)
                oeMoneda.Activo = True
                leMoneda.AddRange(olMoneda.Listar(oeMoneda))
                '--------------------- para llenar combo en grilla    
                gridComprobanteCompra.DisplayLayout.ValueLists.Add("IdMoneda")
                With gridComprobanteCompra.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                    .Clear()
                    For Each oeTD As e_Moneda In leMoneda
                        .Add(oeTD.Id, oeTD.Abreviatura)
                    Next
                End With
                CrearComboGrid3("IdMoneda", "Abreviatura", gridComprobanteCompra, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                GriComprobanteAsociado.DisplayLayout.ValueLists.Add("IdMoneda")
                With GriComprobanteAsociado.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                    .Clear()
                    For Each oeTD As e_Moneda In leMoneda
                        .Add(oeTD.Id, oeTD.Abreviatura)
                    Next
                End With
                CrearComboGrid3("IdMoneda", "Abreviatura", GriComprobanteAsociado, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                GriSeleccionaComprobante.DisplayLayout.ValueLists.Add("IdMoneda")
                With GriSeleccionaComprobante.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                    .Clear()
                    For Each oeTD As e_Moneda In leMoneda
                        .Add(oeTD.Id, oeTD.Abreviatura)
                    Next
                End With
                CrearComboGrid3("IdMoneda", "Abreviatura", GriSeleccionaComprobante, True)
                '------------------------------------------
                With cboMoneda
                    .DisplayMember = "Nombre"
                    .ValueMember = "Id"
                    .DataSource = leMoneda
                End With
                Dim leMoneda2 As New List(Of e_Moneda)
                leMoneda2 = leMoneda.ToList
                With cboMoneda2
                    .DisplayMember = "Nombre"
                    .ValueMember = "Id"
                    .DataSource = leMoneda2
                End With

                With CboMonedaCupon
                    .DisplayMember = "Nombre"
                    .ValueMember = "Id"
                    .DataSource = leMoneda
                End With

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            If _ComboPeriodo = True Then

                Dim lePeriodo As New List(Of e_Periodo)
                lePeriodo.AddRange(ObtenerPeriodoActivo(dtpFechaEjercicio.Value.Year.ToString))

                '--------------------- para llenar combo en grilla  
                With gridComprobanteCompra.DisplayLayout
                    If .Bands(0).Columns.Exists("IdPeriodo") Then
                        .ValueLists.Clear()
                        .ValueLists.Add("IdPeriodo")
                    End If
                End With
                With gridComprobanteCompra.DisplayLayout.ValueLists("IdPeriodo").ValueListItems
                    .Clear()
                    For Each oeTD As e_Periodo In lePeriodo
                        .Add(oeTD.Id, oeTD.Codigo)
                    Next
                End With
                CrearComboGrid3("IdPeriodo", "Codigo", gridComprobanteCompra, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                With GriComprobanteAsociado.DisplayLayout
                    If .Bands(0).Columns.Exists("IdPeriodo") Then
                        .ValueLists.Clear()
                        .ValueLists.Add("IdPeriodo")
                    End If
                End With
                With GriComprobanteAsociado.DisplayLayout.ValueLists("IdPeriodo").ValueListItems
                    .Clear()
                    For Each oeTD As e_Periodo In lePeriodo
                        .Add(oeTD.Id, oeTD.Codigo)
                    Next
                End With
                CrearComboGrid3("IdPeriodo", "Codigo", GriComprobanteAsociado, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                With GriSeleccionaComprobante.DisplayLayout
                    If .Bands(0).Columns.Exists("IdPeriodo") Then
                        .ValueLists.Clear()
                        .ValueLists.Add("IdPeriodo")
                    End If
                End With
                With GriSeleccionaComprobante.DisplayLayout.ValueLists("IdPeriodo").ValueListItems
                    .Clear()
                    For Each oeTD As e_Periodo In lePeriodo
                        .Add(oeTD.Id, oeTD.Codigo)
                    Next
                End With
                CrearComboGrid3("IdPeriodo", "Codigo", GriSeleccionaComprobante, True)
                '------------------------------------------
                With cboMes
                    .DisplayMember = "NomMes"
                    .ValueMember = "Id"
                    .DataSource = lePeriodo
                    If .Items.Count > 0 Then
                        .SelectedIndex = -1
                    End If
                    'cboMes_ValueChanged(e)
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboTipoDocumentoOperacion()
        Try
            If cboTipoDocumento.Items.Count = 0 Then
                oeTipoDoc = New e_TipoDocumento
                oeTipoDoc.Activo = True : oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
                leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
                '--------------------- para llenar combo en grilla    
                gridComprobanteCompra.DisplayLayout.ValueLists.Add("IdTipoDocumento")
                With gridComprobanteCompra.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                    .Clear()
                    For Each oeTD As e_TipoDocumento In leTipoDoc
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdTipoDocumento", "Nombre", gridComprobanteCompra, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                GriComprobanteAsociado.DisplayLayout.ValueLists.Add("IdTipoDocumento")
                With GriComprobanteAsociado.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                    .Clear()
                    For Each oeTD As e_TipoDocumento In leTipoDoc
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdTipoDocumento", "Nombre", GriComprobanteAsociado, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                GriSeleccionaComprobante.DisplayLayout.ValueLists.Add("IdTipoDocumento")
                With GriSeleccionaComprobante.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                    .Clear()
                    For Each oeTD As e_TipoDocumento In leTipoDoc
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdTipoDocumento", "Nombre", GriSeleccionaComprobante, True)
                '------------------------------------------
                With cboTipoDocumento
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leTipoDoc
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboProveedor()
        Try
            If cbeCtaCte.Rows.Count = 0 Then
                Dim oeProveedor As New e_Proveedor
                leProveedor = New List(Of e_Proveedor)
                Dim olProveedor As New l_Proveedor
                'oeProveedor.Activo = True
                leProveedor.AddRange(olProveedor.Listar(oeProveedor))
                '--------------------- para llenar combo en grilla    
                gridComprobanteCompra.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With gridComprobanteCompra.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Proveedor In leProveedor
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", gridComprobanteCompra, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                GriComprobanteAsociado.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With GriComprobanteAsociado.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Proveedor In leProveedor
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", GriComprobanteAsociado, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                GriSeleccionaComprobante.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With GriSeleccionaComprobante.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Proveedor In leProveedor
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", GriSeleccionaComprobante, True)
                '------------------------------------------
                With cbeCtaCte
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leProveedor
                End With
                InicializarComboPro()
            End If
        Catch ex As Exception
            Throw ex
        End Try
        'LlenarCombo(cboProveedor, "Nombre", ProveedorPublic, -1)
        'Dim Proveedor As New DataTable
        'Proveedor = olCombo.ComboGrilla(ProveedorPublic)
        'CrearComboGrid("IdClienteProveedor", "Nombre", gridComprobanteCompra, Proveedor, True)
        'CrearComboGrid("IdClienteProveedor", "Nombre", GriComprobanteAsociado, Proveedor, True)
        'CrearComboGrid("IdClienteProveedor", "Nombre", GriSeleccionaComprobante, Proveedor, True)
    End Sub

    Private Sub ComboTipoCompra()
        Try
            If Ejercicio <> dtpFechaEjercicio.Value.Year Then
                Dim oeTablaContableDet As New e_TablaContableDet
                Dim olTablaContableDet As New l_TablaContableDet
                oeTablaContableDet.TipoOperacion = "N"
                oeTablaContableDet.Nombre = "TIPO DE COMPRA" 'Tipo de COMPRA
                oeTablaContableDet.Valor1 = dtpFechaEjercicio.Value.Year
                oeTablaContableDet.Activo = True
                leTipoCompra.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
                With cboTipoCompra
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leTipoCompra
                End With
                Ejercicio = dtpFechaEjercicio.Value.Year
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarComboPro()
        Try
            Me.cbeCtaCte.ValueMember = "Id"
            Me.cbeCtaCte.DisplayMember = "Nombre"
            With cbeCtaCte.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Codigo").Hidden = True
                .Columns("NroDocumento").Hidden = True
                .Columns("TipoPersonaEmpresa").Hidden = True
                .Columns("IdPersona").Hidden = True
                .Columns("IdEmpresa").Hidden = True
                .Columns("FechaActividad").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("Seleccion").Hidden = True
                .Columns("Email").Hidden = True
                .Columns("Contacto").Hidden = True
                .Columns("Nombre").Header.Caption = "Proveedor"
                .Columns("NroDocumento").Header.Caption = "RUC/DNI"
                .Columns("NroDocumento").Header.VisiblePosition = 0
                .Columns("Nombre").Header.VisiblePosition = 1
                .Columns("NroDocumento").Width = 120
                .Columns("Nombre").Width = 450
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDocumentoAsociado()
        Try
            'CHEQUEAR SI EL IDTIPODOCUMENTO RETORNA EL NOMBRE DEL TIPO DE DOCUMENTO?
            If GriSeleccionaComprobante.ActiveRow.Cells("IdTipoDocumento").Text = "NOTA DE CRÉDITO" Then Throw New Exception("No puede agregar una Nota de Credito a los documentos asociados")

            'Inicializo objeto
            oeDocAsoc = New e_MovimientoDocumento
            '---
            '---capturo datos a ingresa-----
            oeDocAsoc = GriSeleccionaComprobante.ActiveRow.ListObject
            oeDocAsoc.TipoOperacion = "I"
            '-----------------------

            With oeMovimientoDocumento
                If .TipoOperacion = "I" Then ' cuando inserto o nuevo cabecera y detalles
                    If Not leDocAsoc.Contains(oeDocAsoc) Then
                        ' si no esta en la lista o no esta contenido AGREGOOO
                        leDocAsoc.Add(oeDocAsoc)
                    Else
                        Throw New Exception("Ya existe esta documento asociado")
                    End If
                ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                    If Not leDocAsoc.Contains(oeDocAsoc) Then
                        ' si no esta en la lista o no esta contenido AGREGOOO
                        leDocAsoc.Add(oeDocAsoc)
                    Else
                        '-------BUSCA OBJETO EN LA LISTA DE OBJETOS
                        oeDocAsoc = leDocAsoc.Item(leDocAsoc.IndexOf(oeDocAsoc))
                        '---------
                        If oeDocAsoc.TipoOperacion = "E" Then 'Existe en la BD y esta para eliminarse
                            ' la dejo como estaba al inicio(carga)
                            oeDocAsoc.TipoOperacion = ""
                        Else
                            Throw New Exception("Ya existe esta Cuenta")
                        End If
                    End If
                End If
                'recargo grilla
                CargaComprobanteDetalles(leDocAsoc)
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub QuitarDocumentoAsoc()
        Try
            If GriComprobanteAsociado.Rows.Count > 0 Then

                'inicialializo mi objeto
                oeDocAsoc = New e_MovimientoDocumento
                '---Obtengo O CAPTURO objeto de la grilla 
                oeDocAsoc = GriComprobanteAsociado.ActiveRow.ListObject
                '----------------------
                With oeMovimientoDocumento
                    If .TipoOperacion = "I" Then 'cuando inserto o nuevo objeto cabecera y detalles
                        '-----remuevo o elimino de mi lista de objetos
                        leDocAsoc.Remove(oeDocAsoc)
                        '-------------------
                    ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                        If oeDocAsoc.Id <> "" Then '---viene de BD
                            '-----Solo cambio tipo de operacion para desactivar ya que viene de BD
                            oeDocAsoc.TipoOperacion = "E"
                            '--------------------
                        Else '-----no viene de BD
                            '-----remuevo de mi lista de objetos
                            leDocAsoc.Remove(oeDocAsoc)
                            '----------------------------
                        End If
                    End If
                End With
                CargaComprobanteDetalles(leDocAsoc) '----recargo mi grilla
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SumaTotales()
        DecTotalImponible.Value = DecBi1.Value + DecBi2.Value + DecBi3.Value
        oeMovimientoDocumento.SubTotal = DecTotalImponible.Value
        DecTotalIgv.Value = DecIgv1.Value + DecIgv2.Value + DecIgv3.Value
        oeMovimientoDocumento.IGV = DecTotalIgv.Value
        DecTotalDoc.Value = DecTotalImponible.Value + DecTotalIgv.Value + _
        DecISC.Value + DecOtrosTributos.Value + DecNoGravadas.Value
        DecMontoAn.Value = DecTotalImponible.Value + DecNoGravadas.Value

        oeMovimientoDocumento.Compra.TotalBaseCompra = DecTotalImponible.Value
        oeMovimientoDocumento.Compra.TotalIGVCompra = DecTotalIgv.Value
        oeMovimientoDocumento.Total = DecTotalDoc.Value
        oeMovimientoDocumento.Saldo = DecTotalDoc.Value

    End Sub

    Private Sub CargaComprobantesAnalisis(ByVal oeDetalleAnalisis As List(Of e_MovimientoAnalisis))
        Try

            With gridDetalleAsientoAnalisis
                LimpiaGrid(gridDetalleAsientoAnalisis, UltraDataSource4)
                If Not oeDetalleAnalisis Is Nothing Then
                    Dim leASiento As New List(Of e_MovimientoAnalisis)
                    '-----------obtengo lista de objetos activos
                    leASiento = oeDetalleAnalisis.Where(Function(item) item.TipoOperacion <> "E").ToList
                    '-----------------
                    .DataSource = leASiento
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdAsientoMovimiento").Hidden = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargaComprobantesAsociados()
        Dim oeDA As New e_DocumentoAsociado
        If leDocAsoc.Count > 0 Then
            For Each obj As e_MovimientoDocumento In leDocAsoc
                oeDA = New e_DocumentoAsociado
                If oeMovimientoDocumento.TipoOperacion = "I" Then
                    oeDA.Id = "" : oeDA.IdMovimientoDocumento = "" : oeDA.IdMovimientoDocumentoAsoc = obj.Id
                    oeDA.TipoOperacion = "I" : oeDA.Activo = True
                Else
                    oeDA.Id = obj.IdDocAsoc : oeDA.IdMovimientoDocumento = oeMovimientoDocumento.Id
                    oeDA.IdMovimientoDocumentoAsoc = obj.Id : oeDA.TipoOperacion = obj.TipoOperacion
                End If
                oeMovimientoDocumento.DocAsoc.Add(oeDA)
            Next
        Else
            oeMovimientoDocumento.DocAsoc = Nothing
        End If
    End Sub

    Private Sub CargaCuenta(ByVal lsCta As String)
        Try
            Dim oeCta As New e_CuentaContable
            Dim leCta As New List(Of e_CuentaContable)
            Dim olCta As New l_CuentaContable
            oeCta.TipoOperacion = "L"
            oeCta.Cuenta = oeMovimientoDocumento.Compra.TipoCompra.Texto1
            oeCta.Activo = True
            oeCta.Movimiento = 1
            oeCta.Ejercicio = dtpFechaEjercicio.Value.Year
            leCta.AddRange(olCta.Listar(oeCta))
            ''--------------------- para llenar combo en grilla    
            'With gridDetalleAsientoAnalisis.DisplayLayout
            '    If .Bands(0).Columns.Exists("IdCuentaContable") Then
            '        .ValueLists.Clear()
            '        .ValueLists.Add("IdCuentaContable")
            '    End If
            'End With
            'With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdCuentaContable").ValueListItems
            '    .Clear()
            '    For Each oeTD As e_CuentaContable In leCta
            '        .Add(oeTD.Id, oeTD.Nombre)
            '    Next
            'End With
            'CrearComboGrid3("IdCuentaContable", "Nombre", gridDetalleAsientoAnalisis, True)
            ''------------------------------------------
            With cboCuenta
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leCta
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaCombosSegunCta()
        Try
            If Not oeCta Is Nothing Then
                ItemGasto(oeCta.Id)
                If oeCta.GastoFuncion = 1 Then
                    cboGastonFuncion.Enabled = True
                    GastoFuncion()
                Else
                    cboGastonFuncion.Enabled = False
                    cboGastonFuncion.SelectedIndex = -1
                End If
                If oeCta.CentroCosto = 1 Then
                    cboCentroCosto.Enabled = True
                    CentroCosto()
                Else
                    cboCentroCosto.Enabled = False
                    cboCentroCosto.SelectedIndex = -1
                End If
                If oeCta.Trabajador = 1 Then

                    cboTrabajador.Enabled = True
                    Trabajador()
                Else
                    cboTrabajador.Enabled = False
                    cboTrabajador.SelectedIndex = -1
                End If
                If oeCta.Tracto = 1 Then
                    ChkVehiculoProper.Enabled = True
                    cboVehiculo.Enabled = True
                    Vehiculo()
                Else
                    ChkVehiculoProper.Enabled = False
                    cboVehiculo.Enabled = False
                    cboVehiculo.SelectedIndex = -1
                End If
                If oeCta.Ruta = 1 Then
                    cboRuta.Enabled = True
                    Ruta()
                Else
                    cboRuta.Enabled = False
                    cboRuta.SelectedIndex = -1
                End If
                If oeCta.Banco = 1 Then
                    cboBanco.Enabled = True
                    Banco()
                Else
                    cboBanco.Enabled = False
                    cboBanco.SelectedIndex = -1
                End If
                If oeCta.Analisis01 = 1 Then
                    cboAnalisis1.Enabled = True
                    Analisis1()
                Else
                    cboAnalisis1.Enabled = False
                    cboAnalisis1.SelectedIndex = -1
                End If
                If oeCta.Analisis02 = 1 Then
                    cboAnalisis2.Enabled = True
                    Analisis2()
                Else
                    cboAnalisis2.Enabled = False
                    cboAnalisis2.SelectedIndex = -1
                End If
                'If oeCta.CentroCosto = 1 Or oeCta.Trabajador = 1 Or oeCta.Tracto = 1 _
                'Or oeCta.Ruta = 1 Or oeCta.Banco = 1 Or oeCta.Analisis01 = 1 Or _
                'oeCta.Analisis02 = 1 Or cboItemGasto.Enabled = True Then
                '    cmbAgregar.Enabled = True
                'Else
                '    cmbAgregar.Enabled = False
                'End If
                '-----------------------------------------
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ObtenerDocumentoServicios() As Boolean
        Try
            If Operacion = "Nuevo" And opcTerceros.CheckedIndex <> 2 Then
                oeOperacionDetalle = New e_OperacionDetalle
                With oeOperacionDetalle
                    .IdOperacion = "ENVIADA"
                    .FechaDesde = ""
                    .FechaHasta = ""
                    .IdDemanda = txtNroSerie.Text
                    .Cliente = txtNroDocumento.Text
                    .Proveedor = cbeCtaCte.Value
                    Select Case opcTerceros.CheckedIndex
                        Case 0
                            .TipoOperacion = "7"
                        Case 1
                            .TipoOperacion = "T"
                            .IdOperacion = "ENVIADO"
                        Case 2
                            .Proveedor = ""
                            LimpiaGrid(griLista, ogdOperacionDetalle)
                    End Select
                End With
                If oeOperacionDetalle.Proveedor <> "" Then
                    griLista.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                    CalcularTotales(griLista, "FleteUnitario")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

#Region "Combos"

    Private Sub ItemGastoGRILLA()
        If leItemGasto.Count = 0 Then
            Dim oeItemGasto As New e_ItemGasto
            Dim olItemGasto As New l_ItemGasto
            oeItemGasto.Ejercicio = dtpFechaEjercicio.Value.Year
            oeItemGasto.Activo = True
            leItemGasto.AddRange(olItemGasto.Listar(oeItemGasto))

            '--------------------- para llenar combo en grilla    
            With gridDetalleAsientoAnalisis.DisplayLayout
                If .Bands(0).Columns.Exists("IdItemGasto") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdItemGasto")
                End If
            End With
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdItemGasto").ValueListItems
                .Clear()
                For Each oeTD As e_ItemGasto In leItemGasto
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdItemGasto", "Nombre", gridDetalleAsientoAnalisis, True)
            '------------------------------------------
        End If

    End Sub

    Private Sub GastoFuncion()
        If cboGastonFuncion.Items.Count = 0 Then
            Dim oeTablaContableDet As New e_TablaContableDet
            Dim olTablaContableDet As New l_TablaContableDet
            Dim leTabla As New List(Of e_TablaContableDet)
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "GASTO FUNCION" 'Tipo de medio de pago
            oeTablaContableDet.Activo = True
            oeTablaContableDet.Logico2 = 1
            leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            '--------------------- para llenar combo en grilla    
            gridDetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdGastoFuncion")
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdGastoFuncion").ValueListItems
                .Clear()
                For Each oeTD As e_TablaContableDet In leTabla
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdGastoFuncion", "Nombre", gridDetalleAsientoAnalisis, True)
            '------------------------------------------
            With cboGastonFuncion
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leTabla
            End With
        End If

    End Sub

    Private Sub ItemGasto(ByVal idCuenta As String)
        If _ItemCta <> idCuenta Then
            Dim oeItemGasto As New e_ItemGasto
            Dim olItemGasto As New l_ItemGasto
            Dim leIG As New List(Of e_ItemGasto)
            oeItemGasto.Activo = True
            oeItemGasto.IdCuentaContable = idCuenta
            oeItemGasto.Ejercicio = dtpFechaEjercicio.Value.Year
            leIG.AddRange(olItemGasto.Listar(oeItemGasto))
            '--------------------- para llenar combo en grilla    
            With gridDetalleAsientoAnalisis.DisplayLayout
                If .Bands(0).Columns.Exists("IdItemGasto") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdItemGasto")
                End If
            End With
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdItemGasto").ValueListItems
                .Clear()
                For Each oeTD As e_ItemGasto In leIG
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdItemGasto", "Nombre", gridDetalleAsientoAnalisis, True)
            '------------------------------------------
            With cboItemGasto
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leIG
            End With
            If cboItemGasto.Items.Count = 0 Then
                cboItemGasto.Enabled = False
            Else
                cboItemGasto.Enabled = True
            End If
            _ItemCta = idCuenta
        End If

    End Sub

    Private Sub CentroCosto()
        If cboCentroCosto.Items.Count = 0 Then
            Dim oeCentroCosto As New e_CentroCosto
            Dim olCentroCosto As New l_CentroCosto
            Dim leCentroCosto As New List(Of e_CentroCosto)
            oeCentroCosto.Activo = True
            leCentroCosto.AddRange(olCentroCosto.Listar(oeCentroCosto))
            '--------------------- para llenar combo en grilla    
            gridDetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdCentroCosto")
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdCentroCosto").ValueListItems
                .Clear()
                For Each oeTD As e_CentroCosto In leCentroCosto
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdCentroCosto", "Nombre", gridDetalleAsientoAnalisis, True)
            '------------------------------------------

            With cboCentroCosto
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leCentroCosto
            End With
        End If
    End Sub

    Private Sub Trabajador()
        If cboTrabajador.Items.Count = 0 Then
            Dim oeTrabajador As New e_Trabajador
            Dim olTrabajador As New l_Trabajador
            Dim leTrabajador As New List(Of e_Trabajador)
            oeTrabajador.Activo = True
            leTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
            '--------------------- para llenar combo en grilla    
            gridDetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdTrabajador")
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdTrabajador").ValueListItems
                .Clear()
                For Each oeTD As e_Trabajador In leTrabajador
                    .Add(oeTD.Id, oeTD.oePersona.NombreCompleto)
                Next
            End With
            CrearComboGrid3("IdTrabajador", "NombreCompleto", gridDetalleAsientoAnalisis, True)
            '------------------------------------------
            With cboTrabajador
                .ValueMember = "Id"
                .DisplayMember = "NombreCompleto"
                Dim _leTrabAux = From le In leTrabajador _
                                 Select le.Id, le.oePersona.NombreCompleto
                .DataSource = _leTrabAux.ToList
            End With
        End If
    End Sub

    Private Sub Vehiculo()
        If cboVehiculo.Items.Count = 0 Then
            Dim oeVehiculo As New e_Vehiculo
            Dim olVehiculo As New l_Vehiculo
            Dim leVehiculo As New List(Of e_Vehiculo)
            oeVehiculo.Activo = True
            oeVehiculo.Motriz = 1
            leVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
            '--------------------- para llenar combo en grilla    
            gridDetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdVehiculo")
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdVehiculo").ValueListItems
                .Clear()
                For Each oeTD As e_Vehiculo In leVehiculo
                    .Add(oeTD.Id, oeTD.Placa)
                Next
            End With
            CrearComboGrid3("IdVehiculo", "Placa", gridDetalleAsientoAnalisis, True)
            '------------------------------------------
            With cboVehiculo
                .ValueMember = "Id"
                .DisplayMember = "Placa"
                .DataSource = leVehiculo
            End With
        End If
    End Sub

    Private Sub Ruta()
        If cboRuta.Items.Count = 0 Then
            Dim oeRuta As New e_Ruta
            Dim olRuta As New l_Ruta
            Dim leRutas As New List(Of e_Ruta)
            oeRuta.Activo = True
            leRutas.AddRange(olRuta.Listar(oeRuta))
            '--------------------- para llenar combo en grilla    
            gridDetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdRuta")
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdRuta").ValueListItems
                .Clear()
                For Each oeTD As e_Ruta In leRutas
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdRuta", "Nombre", gridDetalleAsientoAnalisis, True)
            '------------------------------------------
            With cboRuta
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leRutas
            End With
        End If
    End Sub

    Private Sub Banco()
        If cboBanco.Items.Count = 0 Then
            Dim oeBanco As New e_Banco
            Dim olBanco As New l_Banco
            Dim leBanco As New List(Of e_Banco)
            oeBanco.Activo = True
            leBanco.AddRange(olBanco.Listar(oeBanco))
            '--------------------- para llenar combo en grilla    
            gridDetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdBanco")
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdBanco").ValueListItems
                .Clear()
                For Each oeTD As e_Banco In leBanco
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdBanco", "Nombre", gridDetalleAsientoAnalisis, True)
            '------------------------------------------
            With cboBanco
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leBanco
            End With
        End If
    End Sub

    Private Sub Analisis1()
        If cboAnalisis1.Items.Count = 0 Then
            Dim oeTablaContableDet As New e_TablaContableDet
            Dim olTablaContableDet As New l_TablaContableDet
            Dim leTabla As New List(Of e_TablaContableDet)
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "ANALISIS 1" 'Tipo de medio de pago
            oeTablaContableDet.Activo = True
            leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            '--------------------- para llenar combo en grilla    
            gridDetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdAnalisis1")
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdAnalisis1").ValueListItems
                .Clear()
                For Each oeTD As e_TablaContableDet In leTabla
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdAnalisis1", "Nombre", gridDetalleAsientoAnalisis, True)
            '------------------------------------------
            With cboAnalisis1
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leTabla
            End With
        End If
    End Sub

    Private Sub Analisis2()
        If cboAnalisis2.Items.Count = 0 Then
            Dim oeTablaContableDet As New e_TablaContableDet
            Dim olTablaContableDet As New l_TablaContableDet
            Dim leTabla As New List(Of e_TablaContableDet)
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "ANALISIS 2" 'Tipo de medio de pago
            oeTablaContableDet.Activo = True
            leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            '--------------------- para llenar combo en grilla    
            gridDetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdAnalisis2")
            With gridDetalleAsientoAnalisis.DisplayLayout.ValueLists("IdAnalisis2").ValueListItems
                .Clear()
                For Each oeTD As e_TablaContableDet In leTabla
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdAnalisis2", "Nombre", gridDetalleAsientoAnalisis, True)
            '------------------------------------------
            With cboAnalisis2
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = olTablaContableDet.Listar(oeTablaContableDet)
            End With
        End If
    End Sub

#End Region

    Private Function ValidaAgregaMovimientoAnalisis() As Boolean
        Try
            If cboCuenta.Enabled Then
                ValidarCombo(cboCuenta, "Cuenta Contable")
            Else
                cboCuenta.SelectedIndex = -1
            End If
            If cboGastonFuncion.Enabled Then
                ValidarCombo(cboGastonFuncion, "Distribucion")
            Else
                cboGastonFuncion.SelectedIndex = -1
            End If
            If cboItemGasto.Enabled Then
                ValidarCombo(cboItemGasto, "Item Gasto")
            Else
                cboItemGasto.SelectedIndex = -1
            End If
            If cboCentroCosto.Enabled Then
                ValidarCombo(cboCentroCosto, "Centro de Costo")
            Else
                cboCentroCosto.SelectedIndex = -1
            End If
            If cboTrabajador.Enabled Then
                ValidarCombo(cboTrabajador, "Trabajador")
            Else
                cboTrabajador.SelectedIndex = -1
            End If
            If cboVehiculo.Enabled Then
                ValidarCombo(cboVehiculo, "Vehiculo")
            Else
                cboVehiculo.SelectedIndex = -1
            End If
            If cboRuta.Enabled Then
                ValidarCombo(cboRuta, "Ruta")
            Else
                cboRuta.SelectedIndex = -1
            End If
            If cboBanco.Enabled = True Then
                ValidarCombo(cboBanco, "Banco")
            Else
                cboBanco.SelectedIndex = -1
            End If
            If cboAnalisis1.Enabled Then
                ValidarCombo(cboAnalisis1, "Analisis 1")
            Else
                cboAnalisis1.SelectedIndex = -1
            End If
            If cboAnalisis2.Enabled Then
                ValidarCombo(cboAnalisis2, "Analisis 2")
            Else
                cboAnalisis2.SelectedIndex = -1
            End If
            If DecMontoAn.Value <= 0 Then Throw New Exception("Ingresa Monto")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarMovimientoAnalisis()
        Try
            If ValidaAgregaMovimientoAnalisis() Then
                'Inicializo objeto
                oeMovimientoAnalisis = New e_MovimientoAnalisis
                Dim leListaAn As New List(Of e_MovimientoAnalisis)
                Dim Divide As Integer = 0
                If ChkVehiculoProper.Checked Then
                    Dim checkedItemList As ICheckedItemList = DirectCast(cboVehiculo.Items.ValueList, ICheckedItemList)
                    For i As Integer = 0 To cboVehiculo.Items.Count - 1
                        oeMovimientoAnalisis = New e_MovimientoAnalisis
                        Dim item As ValueListItem = cboVehiculo.Items(i)
                        Dim checkState__1 As CheckState = checkedItemList.GetCheckState(i)
                        If checkState__1 = CheckState.Checked Then
                            Divide = Divide + 1
                            With oeMovimientoAnalisis
                                .Id = ""
                                .IdAsientoMovimiento = ""
                                .IdCuentaContable = cboCuenta.Value
                                .IdGastoFuncion = cboGastonFuncion.Value
                                .IdItemGasto = cboItemGasto.Value
                                .IdCentroCosto = cboCentroCosto.Value
                                .IdTrabajador = cboTrabajador.Value
                                .IdRuta = cboRuta.Value
                                .IdVehiculo = item.DataValue.ToString
                                .IdBanco = cboBanco.Value
                                .IdAnalisis1 = cboAnalisis1.Value
                                .IdAnalisis2 = cboAnalisis2.Value
                                .Monto = DecMontoAn.Value
                                .Saldo = DecMontoAn.Value
                                .Activo = True
                                .TipoOperacion = "I"
                                .IdTipoCompraParaCompra = oeCta.IdTipoCompra
                                If cboGastonFuncion.SelectedIndex > -1 Then
                                    .GastoFuncion = cboGastonFuncion.Items(cboGastonFuncion.SelectedIndex).ListObject
                                End If
                            End With
                            leListaAn.Add(oeMovimientoAnalisis)
                        End If
                    Next
                Else
                    Divide = 1
                    With oeMovimientoAnalisis
                        .Id = ""
                        .IdAsientoMovimiento = ""
                        .IdCuentaContable = cboCuenta.Value
                        .IdGastoFuncion = cboGastonFuncion.Value
                        .IdItemGasto = cboItemGasto.Value
                        .IdCentroCosto = cboCentroCosto.Value
                        .IdTrabajador = cboTrabajador.Value
                        .IdVehiculo = cboVehiculo.Value
                        .IdRuta = cboRuta.Value
                        .IdBanco = cboBanco.Value
                        .IdAnalisis1 = cboAnalisis1.Value
                        .IdAnalisis2 = cboAnalisis2.Value
                        .Monto = DecMontoAn.Value
                        .Saldo = DecMontoAn.Value
                        .Activo = True
                        .TipoOperacion = "I"
                        .IdTipoCompraParaCompra = oeCta.IdTipoCompra
                        If cboGastonFuncion.SelectedIndex > -1 Then
                            .GastoFuncion = cboGastonFuncion.Items(cboGastonFuncion.SelectedIndex).ListObject
                        End If
                    End With
                    leListaAn.Add(oeMovimientoAnalisis)
                End If
                '-----------------------
                For Each obj As e_MovimientoAnalisis In leListaAn
                    With oeMovimientoDocumento
                        If .TipoOperacion = "I" Then ' cuando inserto o nuevo cabecera y detalles
                            If Not .MovimientoAnalisis.Contains(obj) Then
                                ' si no esta en la lista o no esta contenido AGREGOOO
                                obj.Monto = obj.Monto / Divide
                                obj.Saldo = obj.Saldo / Divide
                                .MovimientoAnalisis.Add(obj)
                            Else
                                Throw New Exception("Ya existe este Análisis")
                            End If
                        ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                            If Not .MovimientoAnalisis.Contains(obj) Then
                                ' si no esta en la lista o no esta contenido AGREGOOO
                                obj.Monto = obj.Monto / Divide
                                obj.Saldo = obj.Saldo / Divide
                                .MovimientoAnalisis.Add(obj)
                            Else
                                '-------BUSCA OBJETO EN LA LISTA DE OBJETOS
                                oeMovimientoAnalisis = .MovimientoAnalisis.Item(.MovimientoAnalisis.IndexOf(obj))
                                '---------
                                If oeMovimientoAnalisis.TipoOperacion = "E" Then 'Existe en la BD y esta para eliminarse
                                    ' la dejo como estaba al inicio(carga)
                                    oeMovimientoAnalisis.TipoOperacion = ""
                                Else
                                    Throw New Exception("Ya existe este Análisis")
                                End If
                            End If
                        End If
                        CargaComprobantesAnalisis(.MovimientoAnalisis)
                    End With
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarMovimientoAnalisis()
        Try
            If gridDetalleAsientoAnalisis.Rows.Count > 0 Then
                With oeMovimientoDocumento
                    'inicialializo mi objeto
                    oeMovimientoAnalisis = New e_MovimientoAnalisis
                    '---Obtengo O CAPTURO objeto de la grilla 
                    oeMovimientoAnalisis = gridDetalleAsientoAnalisis.ActiveRow.ListObject
                    '----------------------

                    If .TipoOperacion = "I" Then 'cuando inserto o nuevo objeto cabecera y detalles
                        '-----remuevo o elimino de mi lista de objetos
                        .MovimientoAnalisis.Remove(oeMovimientoAnalisis)
                        '-------------------
                    ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                        If oeMovimientoAnalisis.Id <> "" Then '---viene de BD
                            '-----Solo cambio tipo de operacion para desactivar ya que viene de BD
                            oeMovimientoAnalisis.TipoOperacion = "E"
                            '--------------------
                        Else '-----no viene de BD
                            '-----remuevo de mi lista de objetos
                            .MovimientoAnalisis.Remove(oeMovimientoAnalisis)
                            '----------------------------
                        End If
                    End If
                    CargaComprobantesAnalisis(.MovimientoAnalisis) '----recargo mi grilla
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Extornar()
        Try
            ValidarGrilla(gridComprobanteCompra, "Comprobante Compra")
            If Not gridComprobanteCompra.ActiveRow Is Nothing AndAlso gridComprobanteCompra.ActiveRow.Cells("Id").Value.ToString <> "" Then
                'inicialializo mi objeto
                oeMovimientoDocumento = New e_MovimientoDocumento
                '---Obtengo O CAPTURO objeto de la grilla 
                oeMovimientoDocumento = gridComprobanteCompra.ActiveRow.ListObject
                olMovimientoDocumento.ExtornarDocEmitidoEnviado(oeMovimientoDocumento, gUsuarioSGI.Id)
                MostrarTabs(0, tcComprobanteCompra, 2)
                Consultar(True)
                gridComprobanteCompra.Focus()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub ObtenerLeasingAsociado(IdMovDoc As String)
        Try
            Dim oeObliAso As New e_ObligacionFin
            oeObliAso.TipoOperacion = "D" : oeObliAso.IdTipoObligacion = IdMovDoc
            oeObliAso = olObligacionFin.Obtener2(oeObliAso)
            If oeObliAso IsNot Nothing AndAlso oeObliAso.Id.Trim <> "" Then
                chkLeasing.Checked = True : _BandLeasing = True
                If cboCodigoLeasing.Items.Count > 0 Then cboCodigoLeasing.Value = oeObliAso.Id
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub Año1_DatoCambiado()
        Try
            ComboPeriodo()
            LimpiaGrid(gridComprobanteCompra, UltraDataSource1)
            ComboTipoCompra()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub oeMovimientoDocumento_DatoCambiado() Handles oeMovimientoDocumento.DatoCambiado
        oeMovimientoDocumento.Modificado = True
    End Sub

    Private Sub frm_ComprobanteCompra_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Else
            ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
        End If
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Me.Tag <> "bien" Then
            instancia = Nothing
        End If
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select

        If Me.Tag = "Error" Then
            e.Cancel = True
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ComprobanteDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            MostrarTabs(0, tcComprobanteCompra)
            _ComboPeriodo = True
            LlenarCombos()
            oeIGV = olImp.IGV(Date.Now)
            _IGV = oeIGV.Porcentaje
            If Not leMovimientoAnalisisAGrega Is Nothing AndAlso leMovimientoAnalisisAGrega.Count > 0 Then
                dtpFechaEjercicio.Value = "01/01/" + CStr(oeMovimientoDocumento.Ejercicio)
                grupoDoctRendir.Visible = True
                ComboTipoCompra()
                MostrarParaDocumentoXRendir()
                MostrarTabs(1, tcComprobanteCompra, 1)
                Agrupacion2.Enabled = False
                cboTipoCompra.Enabled = False
                tcComprobanteDetalle.Enabled = False
                grupoObligaciones.Enabled = False
                gridDetalleAsientoAnalisis.Enabled = False
                tcComprobanteDetalle.Enabled = False
                grupoDetalle.Enabled = False
                grupoMontaCarga.Enabled = False
            End If
            ListaUsuarios(gridComprobanteCompra, "IdUsuarioCrea")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridComprobanteCompra_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridComprobanteCompra.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub gridComprobanteCompra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridComprobanteCompra.DoubleClick
        If gridComprobanteCompra.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub gridComprobanteCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridComprobanteCompra.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub AgregarCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarCabecera.Click
        Nuevo()
    End Sub

    Private Sub EditarCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarCabecera.Click
        Editar()
    End Sub

    Private Sub EliminaCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminaCabecera.Click
        Eliminar()
    End Sub

    Private Sub AgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarDetalle.Click
        Try
            If cboTipoDocumento.SelectedIndex = -1 Then Throw New Exception("Selecciona Tipo de Documento")
            If Not oeMovimientoDocumento.Compra.TipoDoc.Codigo.Trim = "07" And Not oeMovimientoDocumento.Compra.TipoDoc.Codigo.Trim = "08" Then Throw New Exception("Solo para Notas de crédito/débito")
            If cbeCtaCte.Text = String.Empty Then Throw New Exception("Selecciona Proveedor")
            ListarDocumentoAsociado()
            If GriComprobanteAsociado.Rows.Count = 1 Then Throw New Exception("Solo se permite asociar un solo comprobante")
            MostrarTabs(1, tcComprobanteDetalle, 1) 'inicializamos
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarDetalle.Click
        Try
            QuitarDocumentoAsoc()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub mnuDetalleAsiento_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuDetalleAsiento.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    AgregarDocumentoAsociado()
                    MostrarTabs(0, tcComprobanteDetalle, 2)
                Case "Cancelar"
                    MostrarTabs(0, tcComprobanteDetalle, 2)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GriSeleccionaComprobante_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GriSeleccionaComprobante.DoubleClick
        Try
            AgregarDocumentoAsociado()
            MostrarTabs(0, tcComprobanteDetalle, 2)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        oeMovimientoDocumento.IdTipoDocumento = cboTipoDocumento.Value
        If cboTipoDocumento.SelectedIndex <> -1 Then
            Dim i As Integer = cboTipoDocumento.SelectedIndex
            oeMovimientoDocumento.Compra.TipoDoc = cboTipoDocumento.Items(i).ListObject
            If oeMovimientoDocumento.Compra.TipoDoc.Codigo.Trim = "07" Then
                oeMovimientoDocumento._Operador = -1 'negativo para proveedores o compras
            Else
                oeMovimientoDocumento._Operador = 1
            End If
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc = cboTipoDocumento.Items(i).ListObject
            _CodigoDoc = oeTipoDoc.Codigo.Trim
            lenSerie = gfc_ObtieneLongitudSerie(oeTipoDoc.Codigo)
            txtNroSerie.MaxLength = lenSerie
            lenNumero = gfc_ObtieneLongitudNumero(oeTipoDoc.Codigo)
            txtNroDocumento.MaxLength = lenNumero
        End If
    End Sub

    Private Sub txtNroSerie_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroSerie.Validated
        txtNroSerie.Text = gfc_ConcatenarCeros(txtNroSerie.Text, lenSerie)
    End Sub

    Private Sub txtNroSerie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroSerie.ValueChanged
        oeMovimientoDocumento.Serie = txtNroSerie.Text
    End Sub

    Private Sub txtNroDocumento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDocumento.Validated
        txtNroDocumento.Text = gfc_ConcatenarCeros(txtNroDocumento.Text, lenNumero)
    End Sub

    Private Sub txtNroDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDocumento.ValueChanged
        oeMovimientoDocumento.Numero = txtNroDocumento.Text
    End Sub

    Private Sub FecEmision_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecEmision.Validated
        Try
            If oeMovimientoDocumento.TipoOperacion = "I" Then
                decTC.Value = TipoCambio(FecEmision.Value)(0)
            ElseIf oeMovimientoDocumento.TipoOperacion = "A" Then
                If decTC.Value = 0 Then
                    decTC.Value = TipoCambio(FecEmision.Value)(0)
                Else
                    If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                       = Windows.Forms.DialogResult.Yes Then
                        decTC.Value = TipoCambio(FecEmision.Value)(0)
                    End If
                End If
            End If
            oeIGV = New e_Impuesto
            oeIGV = olImp.IGV(FecEmision.Value)
            _IGV = oeIGV.Porcentaje
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub FecEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecEmision.ValueChanged
        oeMovimientoDocumento.FechaEmision = FecEmision.Value
    End Sub

    Private Sub FecVencimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecVencimiento.ValueChanged
        oeMovimientoDocumento.FechaVencimiento = FecVencimiento.Value
    End Sub

    Private Sub cboCtaCte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeCtaCte.ValueChanged
        oeMovimientoDocumento.IdClienteProveedor = cbeCtaCte.Value
        If Not IsNothing(cbeCtaCte.ActiveRow) AndAlso cbeCtaCte.Text <> String.Empty Then
            oeMovimientoDocumento.Compra.Proveedor = cbeCtaCte.ActiveRow.ListObject
        End If
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeMovimientoDocumento.IdMoneda = cboMoneda.Value
        If cboMoneda.SelectedIndex <> -1 Then
            Dim i As Integer = cboMoneda.SelectedIndex
            oeMovimientoDocumento.Compra.Moneda = cboMoneda.Items(i).ListObject
        End If
    End Sub

    Private Sub decTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTC.ValueChanged
        oeMovimientoDocumento.TipoCambio = decTC.Value
    End Sub

    Private Sub cboTipoCompra_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoCompra.Validated
        Try
            If _ComboTipoCompra <> cboTipoCompra.Value Then
                If cboTipoCompra.SelectedIndex <> -1 Then
                    'If _ComboTipoCompra <> cboTipoCompra.Value And gridDetalleAsientoAnalisis.Rows.Count > 0 Then
                    '    If MessageBox.Show("Se borraran lo items agregados, Esta seguro de cambiar de compra?", _
                    '    "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    '        cboTipoCompra.Value = _ComboTipoCompra
                    '    Else
                    '        Dim leMovAn As List(Of e_MovimientoAnalisis)
                    '        Dim oeMovAn As e_MovimientoAnalisis
                    '        leMovAn = oeMovimientoDocumento.MovimientoAnalisis.ToList
                    '        For Each obj As e_MovimientoAnalisis In leMovAn
                    '            If obj.Id <> "" Then
                    '                oeMovAn = oeMovimientoDocumento.MovimientoAnalisis.Item(oeMovimientoDocumento.MovimientoAnalisis.IndexOf(obj))
                    '                oeMovAn.TipoOperacion = "E"
                    '            Else
                    '                oeMovimientoDocumento.MovimientoAnalisis.Remove(obj)
                    '            End If
                    '        Next
                    '        LimpiaGrid(gridDetalleAsientoAnalisis, UltraDataSource4)
                    '    End If
                    'End If
                    CargaCuenta(cboTipoCompra.Value)
                    _ComboTipoCompra = cboTipoCompra.Value
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoCompra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCompra.ValueChanged
        oeMovimientoDocumento.Compra.IdTipoCompra = cboTipoCompra.Value
        If cboTipoCompra.SelectedIndex <> -1 Then
            Dim i As Integer = cboTipoCompra.SelectedIndex
            oeMovimientoDocumento.Compra.TipoCompra = cboTipoCompra.Items(i).ListObject
        End If
    End Sub

    Private Sub cboCuenta_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuenta.SelectionChangeCommitted
        Try
            If cboCuenta.SelectedIndex <> -1 Then
                Dim i As Integer = cboCuenta.SelectedIndex
                oeCta = cboCuenta.Items(i).ListObject
                CargaCombosSegunCta()
                oeMovimientoAnalisis = New e_MovimientoAnalisis
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub DecBi1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles DecBi1.Validated
        DecIgv1.Value = DecBi1.Value * _IGV
        DecIgv1.Value = Math.Round(DecIgv1.Value, 2)
        SumaTotales()
    End Sub

    Private Sub DecBi2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles DecBi2.Validated
        DecIgv2.Value = Math.Round(DecBi2.Value * _IGV, 2)
        SumaTotales()
    End Sub

    Private Sub DecBi3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) _
   Handles DecBi3.Validated
        DecIgv3.Value = Math.Round(DecBi3.Value * _IGV, 2)
        SumaTotales()
    End Sub

    Private Sub DecBi1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecBi1.ValueChanged
        oeMovimientoDocumento.Compra.Base1 = DecBi1.Value
    End Sub

    Private Sub DecBi2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecBi2.ValueChanged
        oeMovimientoDocumento.Compra.Base2 = DecBi2.Value
    End Sub

    Private Sub DecBi3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecBi3.ValueChanged
        oeMovimientoDocumento.Compra.Base3 = DecBi3.Value
    End Sub

    Private Sub DecIgv1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DecIgv1.Validated, _
    DecIgv2.Validated, DecIgv3.Validated
        SumaTotales()
    End Sub

    Private Sub DecIgv1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecIgv1.ValueChanged
        oeMovimientoDocumento.Compra.Igv1 = DecIgv1.Value
    End Sub

    Private Sub DecIgv2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecIgv2.ValueChanged
        oeMovimientoDocumento.Compra.Igv2 = DecIgv2.Value
    End Sub

    Private Sub DecIgv3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecIgv3.ValueChanged
        oeMovimientoDocumento.Compra.Igv3 = DecIgv3.Value
    End Sub

    Private Sub DecOtros_Validated(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles DecISC.Validated, DecOtrosTributos.Validated, DecNoGravadas.Validated
        SumaTotales()
    End Sub

    Private Sub DecISC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecISC.ValueChanged
        oeMovimientoDocumento.Compra.Isc = DecISC.Value
    End Sub

    Private Sub DecOtrosTributos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecOtrosTributos.ValueChanged
        oeMovimientoDocumento.Compra.OtrosTributos = DecOtrosTributos.Value
    End Sub

    Private Sub DecNoGravadas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecNoGravadas.ValueChanged
        oeMovimientoDocumento.Compra.NoGravadas = DecNoGravadas.Value
    End Sub

    Private Sub cmbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAgregar.Click
        Try
            Select Case opcTerceros.CheckedIndex
                Case 0
                    If griLista.Rows.Count > 0 Then
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                            cboVehiculo.Text = fila.Cells("IdOperacion").Value.ToString
                            DecMontoAn.Value = fila.Cells("FleteUnitario").Value.ToString
                            AgregarMovimientoAnalisis()
                        Next
                    End If
                Case 1
                    If griLista.Rows.Count > 0 Then
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                            cboVehiculo.Text = fila.Cells("IdOperacion").Value.ToString
                            DecMontoAn.Value = fila.Cells("FleteUnitario").Value.ToString
                            AgregarMovimientoAnalisis()
                        Next
                    End If
                Case 2
                    AgregarMovimientoAnalisis()
            End Select
            cboCuenta.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub EliminarAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarAnalisis.Click
        Try
            QuitarMovimientoAnalisis()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.ValueChanged
        If cboMes.SelectedIndex <> -1 Then
            Dim i As Integer = cboMes.SelectedIndex
            oePeriodo = cboMes.Items(i).ListObject
            EtiPeriodo.Text = "Periodo: " & oePeriodo.Codigo
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If ValidaComprobante() Then
                SumaTotales()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Tag = ""
            Else
                Me.Tag = "Error"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Tag = ""
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub ChkVehiculoProper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkVehiculoProper.CheckedChanged
        If ChkVehiculoProper.Checked Then
            With cboVehiculo.CheckedListSettings
                .CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox
                .EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems
                .ListSeparator = ";"
            End With
        Else
            With cboVehiculo.CheckedListSettings
                .CheckBoxStyle = Infragistics.Win.CheckStyle.None
                .EditorValueSource = Infragistics.Win.EditorWithComboValueSource.SelectedItem
                .ListSeparator = ""
            End With
        End If
    End Sub

    Private Sub btn_Extornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Extornar.Click
        If MessageBox.Show("Esta seguro de Extornar esta operacion?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Extornar()
        End If

    End Sub

    Private Sub txtRuc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuc.ValueChanged
        If Not txtRuc.Value Is Nothing Then
            If txtRuc.Value.ToString.Trim.Length > 7 Then
                Dim leProv As New List(Of e_Proveedor)
                leProv = leProveedor.ToList
                leProv = leProv.Where(Function(item) item.NroDocumento.Contains(txtRuc.Value)).ToList
                If leProv.Count > 0 Then
                    cbeCtaCte.Value = leProv(0).Id
                End If
            End If
        End If
    End Sub

    Private Sub chkObligacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLeasing.CheckedChanged
        Try
            If chkLeasing.Checked Then
                ChkCupon.Checked = False
                TabFinanciero.Tabs(0).Selected = True
            Else
                chkLeasing.Checked = False
                ChkCupon.Checked = False
            End If
            MostrarXCheck()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ChkCupon_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCupon.CheckedChanged
        Try
            If ChkCupon.Checked Then
                chkLeasing.Checked = False
                TabFinanciero.Tabs(1).Selected = True
            Else
                chkLeasing.Checked = False
                ChkCupon.Checked = False
            End If
            MostrarXCheck()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MostrarXCheck()
        Try
            If ChkCupon.Checked Then
                PanelCupon.Enabled = True
                CboFilPoliza.SelectedIndex = -1
                TxtNumeroPoliza.Value = ""
                ndMontoCupon.Value = 0.0
                nd_SaldoCupon.Value = 0.0
                nd_MontoOperaCupon.Value = 0.0
                dtpFechaCupon.Value = Date.Now()

            Else
                PanelCupon.Enabled = False
                CboFilPoliza.SelectedIndex = -1
                TxtNumeroPoliza.Value = ""
                ndMontoCupon.Value = 0.0
                nd_SaldoCupon.Value = 0.0
                nd_MontoOperaCupon.Value = 0.0
                dtpFechaCupon.Value = Date.Now()
            End If

            If chkLeasing.Checked Then
                agrObligación.Enabled = True
                ListarLeasing()
            Else
                agrObligación.Enabled = False
                cboCodigoLeasing.SelectedIndex = -1
                txtGlosa.Text = ""
                cboMoneda2.SelectedIndex = -1
                decSaldo.Value = 0
                txtCuenta.Text = ""
                txtCuota.Text = ""
                decTotalLeasing.Value = 0
                decInteres.Value = 0
                etiTotalLeasing.Text = ""
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboCodigoLeasing_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoLeasing.ValueChanged
        Try
            If cboCodigoLeasing.SelectedIndex <> -1 Then
                oeObligacionfin = cboCodigoLeasing.Items(cboCodigoLeasing.SelectedIndex).ListObject
                txtCuenta.Value = leCuentaContable.Where(Function(item) item.Id = oeObligacionfin.IdCuentaContable)(0).Cuenta
                fecVenc.Value = oeObligacionfin.FechaVencimiento
                cboMoneda2.Value = oeObligacionfin.IdMoneda
                decSaldo.Value = oeObligacionfin.Saldo - oeObligacionfin.MontoInteres
                txtCuota.Value = oeObligacionfin.NroVencimiento
                txtGlosa.Value = oeObligacionfin.Glosa
                decTotalLeasing.Value = IIf(cboMoneda2.Value = "1CH01", oeObligacionfin.MontoMN, oeObligacionfin.MontoME)
                decInteres.Value = oeObligacionfin.MontoInteres
                etiTotalLeasing.Text = Strings.Format(Math.Round((oeObligacionfin.Saldo), 2), "#,###,##0.00").ToString
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridDetalleAsientoAnalisis_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridDetalleAsientoAnalisis.CellChange
        Try
            gridDetalleAsientoAnalisis.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CboFilPoliza_ValueChanged(sender As Object, e As EventArgs) Handles CboFilPoliza.ValueChanged
        Try
            If CboFilPoliza.SelectedIndex <> -1 Then
                TxtNumeroPoliza.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).IdDocumento
                ndMontoCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).Monto
                nd_SaldoCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).SaldoContable
                nd_MontoOperaCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).MontoOpera
                dtpFechaCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).Fecha
                CboMonedaCupon.Value = leCuota.Where(Function(i) i.Id = CboFilPoliza.Value)(0).IdMoneda
            Else
                TxtNumeroPoliza.Value = ""
                ndMontoCupon.Value = 0.0
                nd_SaldoCupon.Value = 0.0
                nd_MontoOperaCupon.Value = 0.0
                dtpFechaCupon.Value = Date.Now()
                CboMonedaCupon.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            leCuota.Clear()
            oeCuota.TipoOperacion = "4"
            oeCuota.Activo = 1
            oeCuota.FechaDesde = Date.Parse("01/" + CmbMes.Value.ToString + "/" + Año.Año.ToString)
            leCuota = olCuota.Listar(oeCuota)
            LlenarCombo(CboFilPoliza, "Glosa", leCuota, -1)
            TxtNumeroPoliza.Value = ""
            ndMontoCupon.Value = 0.0
            nd_SaldoCupon.Value = 0.0
            nd_MontoOperaCupon.Value = 0.0
            dtpFechaCupon.Value = Date.Now()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub nd_MontoOperaCupon_ValueChanged(sender As Object, e As EventArgs) Handles nd_MontoOperaCupon.ValueChanged
        Try
            If CboFilPoliza.SelectedIndex <> -1 Then
                If Math.Round(nd_MontoOperaCupon.Value, 2) > Math.Round(nd_SaldoCupon.Value, 2) Then
                    nd_MontoOperaCupon.Value = nd_SaldoCupon.Value
                End If
            Else
                nd_MontoOperaCupon.Value = 0.0
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub DecSaldo_ValueChanged(sender As Object, e As EventArgs) Handles decSaldo.ValueChanged
        If CboFilPoliza.SelectedIndex <> -1 Then
            If Math.Round(nd_MontoOperaCupon.Value, 2) > Math.Round(nd_SaldoCupon.Value, 2) Then
                nd_MontoOperaCupon.Value = nd_SaldoCupon.Value
                txtNroSerie.Focus()
                nd_MontoOperaCupon.Focus()
                nd_MontoOperaCupon.SelectAll()
            End If
        Else
            nd_MontoOperaCupon.Value = 0.0
        End If
    End Sub

    Private Sub gridComprobanteCompra_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridComprobanteCompra.CellChange
        gridComprobanteCompra.UpdateData()
    End Sub

    Private Sub gridComprobanteCompra_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridComprobanteCompra.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "TipoPago"

                    'Validar IndDetraccion para algunos documentos
                    Dim IndDetrae As Boolean = False
                    If gridComprobanteCompra.ActiveRow.Cells("IndDetraccion").Value Then
                        For Each obj In loConcepto
                            If obj.Valor1 = gridComprobanteCompra.ActiveRow.Cells("IdTipoDocumento").Value Then
                                IndDetrae = True
                            End If
                        Next
                        If Not IndDetrae Then
                            Throw New Exception("Tipo documento " & gridComprobanteCompra.ActiveRow.Cells("IdTipoDocumento").Text & " no tiene configuración para detracción")
                        End If
                    End If

                    oePeriodo = New e_Periodo
                    oePeriodo.Id = gridComprobanteCompra.ActiveRow.Cells("IdPeriodo").Value
                    oePeriodo = olPeriodo.Obtener(oePeriodo)
                    If Not oePeriodo.CierreCompras Then
                        oeMovimientoDocumento = New e_MovimientoDocumento
                        With oeMovimientoDocumento
                            .TipoOperacion = "ACT"
                            .Id = RTrim(gridComprobanteCompra.ActiveRow.Cells("Id").Value)
                            .Serie = FormatoDocumento(RTrim(gridComprobanteCompra.ActiveRow.Cells("Serie").Value), 4)
                            .Numero = FormatoDocumento(RTrim(gridComprobanteCompra.ActiveRow.Cells("Numero").Value), 10)
                            .IdClienteProveedor = RTrim(gridComprobanteCompra.ActiveRow.Cells("IdClienteProveedor").Value)
                            .FechaEmision = gridComprobanteCompra.ActiveRow.Cells("FechaEmision").Value
                            .FechaVencimiento = gridComprobanteCompra.ActiveRow.Cells("FechaVencimiento").Value
                            .IdUsuarioCrea = gUsuarioSGI.Id
                            .IndDetraccion = gridComprobanteCompra.ActiveRow.Cells("IndDetraccion").Value
                            Validar_ExistenciaComprobante()
                        End With
                        If olMovimientoDocumento.Anular(oeMovimientoDocumento, "") Then
                            gridComprobanteCompra.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                        End If
                    Else
                        Throw New Exception("No se puede actualizar el documento el periodo declarado se encuentra se cerrado")
                    End If
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub CambiarPeriodoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambiarPeriodoToolStripMenuItem.Click
        Try
            ValidarGrilla(gridComprobanteCompra, "Comprobante Diario")
            If Not gridComprobanteCompra.ActiveRow Is Nothing AndAlso gridComprobanteCompra.ActiveRow.Cells("Id").Value.ToString <> "" Then
                Dim frm As New Frm_PeriodoTipoAsiento(True, True, True, "CMP")
                frm.cboTipoAsiento.Visible = False
                frm.FecEmision.Visible = False
                frm.etiTipoAsiento.Visible = False
                frm.etiEmision.Visible = False
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim oeMovDoc As New e_MovimientoDocumento
                    Dim olMovDoc As New l_MovimientoDocumento
                    oeMovDoc.TipoOperacion = "PER"
                    oeMovDoc.Id = gridComprobanteCompra.ActiveRow.Cells("Id").Value.ToString
                    oeMovDoc.IdPeriodo = frm.cboMes.Value
                    oeMovDoc.IdUsuarioCrea = gUsuarioSGI.Id
                    If Not PerfilIdAsignado("1CH000000004") Then Throw New Exception("Solo realizable por el Jefe de Contabilidad")
                    olMovDoc.CambiarPeriodo(oeMovDoc)
                    mensajeEmergente.Confirmacion("Periodo cambiado correctamente", True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCtaCte_Validated(sender As Object, e As EventArgs)
        Try
            ValidarCombo(cbeCtaCte, "Proveedor")
            ObtenerDocumentoServicios()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub opcTerceros_Validated(sender As Object, e As EventArgs) Handles opcTerceros.Validated
        ObtenerDocumentoServicios()
    End Sub

    Private Sub frm_ComprobanteCompra_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub dtpFechaEjercicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEjercicio.ValueChanged
        Try
            ComboPeriodo()
            LimpiaGrid(gridComprobanteCompra, UltraDataSource1)
            ComboTipoCompra()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Verificación de documentos"

    Private Sub BtnVerificar_Click(sender As System.Object, e As System.EventArgs) Handles BtnVerificar.Click
        Try
            If Len(oeMovimientoDocumento.Id) <> 15 Then Throw New Exception("Ingrese a un documento válido para poder verificarlo")
            Dim oeMovDocVerifica As New e_MovimientoDocumento
            oeMovDocVerifica.TipoOperacion = "VER"
            oeMovDocVerifica.Id = oeMovimientoDocumento.Id
            oeMovDocVerifica.IdUsuarioCrea = gUsuarioSGI.Id
            olMovimientoDocumento.VerificarDocumento(oeMovDocVerifica)
            mensajeEmergente.Problema("Se verificó el asiento.")
            Lblsuario.Text = "VERIFICADO"
            LblFeccha.Text = Date.Now.ToString.Substring(1, 10)
            BtnVerificar.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MostrarVerficacion()
        Try
            If Len(oeMovimientoDocumento.Id) <> 15 Then Throw New Exception("No es un documento válido.")
            Dim oeMovDoc As New e_MovimientoDocumento
            oeMovDoc.TipoOperacion = "VER"
            oeMovDoc.Id = oeMovimientoDocumento.Id
            Dim dt As New DataTable
            dt = olMovimientoDocumento.ListarVerificacionAsiento(oeMovDoc)
            If dt.Rows.Count() = 0 Then
                BtnVerificar.Enabled = True
                Lblsuario.Text = "--"
                LblFeccha.Text = "--/--/-- --:--"
            Else
                BtnVerificar.Enabled = False
                Lblsuario.Text = dt.Rows(0)(2).ToString
                LblFeccha.Text = dt.Rows(0)(1).ToString
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class
