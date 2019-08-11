Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_ComprobanteVentas
    Inherits ISL.Win.frm_MenuPadre

    Private WithEvents oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento
    'Private leMovDocumento As New List(Of e_MovimientoDocumento)
    Private oeDocAsoc As New e_MovimientoDocumento, leDocAsoc As New List(Of e_MovimientoDocumento)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private _IGV As Double
    Private olImp As New l_Impuesto, oeIGV As New e_Impuesto
    Private oeServCtaCtble As New e_ServicioCuentaContable, olServCtaCtble As New l_ServicioCuentaContable, leServCtaCtble As New List(Of e_ServicioCuentaContable)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeReferencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    Private oeCuentaCorriente As New e_CuentaCorriente, olCuentaCorriente As New l_CuentaCorriente
    Private oeCtaCtable As New e_CuentaContable, olCtaCtable As New l_CuentaContable, leCtaCtable As New List(Of e_CuentaContable)
    Private _ComboPeriodo As Boolean = False
    Private Ejercicio As Integer = 0, AnioServ As Integer = 0
    Private DTReferencia As Data.DataTable, dtAux As Data.DataTable

    Private Shared instancia As frm_ComprobanteVentas = Nothing
    Private Shared Operacion As String
    Private IdCtaCtableAux As String = String.Empty

    Private leEmpresa As List(Of e_Cliente)

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ComprobanteVentas()
        End If
        instancia.Activate()
        Return instancia

    End Function

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If cboMes.SelectedIndex <> -1 Then
                Listar(Activo)
                If gridComprobanteVenta.Rows.Count > 0 Then
                    MyBase.Consultar(Activo) 'activa desactiva botonera
                Else
                    MyBase.Consultar() 'activa desactiva botonera
                End If
            Else
                Throw New Exception("Seleccione el Mes")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            If cboMes.SelectedIndex <> -1 AndAlso l_FuncionesGenerales.ValidarPeriodo(cboMes.Value, gAreasSGI.Contabilidad) Then
                Inicializar()
                oeMovimientoDocumento.IdPeriodo = cboMes.Value
                oeMovimientoDocumento.TipoOperacion = "I"
                oeMovimientoDocumento.Venta.TipoOperacion = "I"
                oeMovimientoDocumento.Modificado = False
                cboTipoDocumento.Focus()
                MyBase.Nuevo() 'activa desactiva botonera
                Operacion = "Nuevo"
            Else
                Throw New Exception("Seleccione el Mes")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Editar()
        Try
            ValidarGrilla(gridComprobanteVenta, "Comprobante Venta")
            If Not gridComprobanteVenta.ActiveRow Is Nothing AndAlso gridComprobanteVenta.ActiveRow.Cells("Id").Value.ToString <> "" _
            AndAlso l_FuncionesGenerales.ValidarPeriodo(cboMes.Value, gAreasSGI.Contabilidad) Then
                Inicializar()
                Mostrar()
                oeMovimientoDocumento.TipoOperacion = "A"
                oeMovimientoDocumento.Venta.TipoOperacion = "A"
                oeMovimientoDocumento.Modificado = False
                MostrarTabs(0, tcComprobanteDetalle)
                cboTipoDocumento.Focus()
                MyBase.Editar()
                Operacion = "Editar"
            Else
                Throw New Exception("Seleccione una Fila!")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            MostrarTabs(0, tcComprobanteVenta)
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If agrCabeceraAsiento.Enabled Then
                If GuardarComprobante() Then
                    MyBase.Guardar()
                    Operacion = ""
                Else
                    MostrarTabs(1, tcComprobanteVenta)
                End If
            Else
                MostrarTabs(0, tcComprobanteVenta)
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
                            MostrarTabs(1, tcComprobanteVenta)
                            MyBase.Consultar(True) 'activa desactiva botonera
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcComprobanteVenta)
                        MyBase.Consultar(True) 'activa desactiva botonera
                        Operacion = ""
                End Select
            Else
                MostrarTabs(0, tcComprobanteVenta)
                MyBase.Consultar(True) 'activa desactiva botonera
                Operacion = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With gridComprobanteVenta
                ValidarGrilla(gridComprobanteVenta, "Comprobante")
                If Not .ActiveRow Is Nothing AndAlso .ActiveRow.Cells("Id").Value.ToString <> "" Then
                    oeMovimientoDocumento.Id = .ActiveRow.Cells("Id").Value
                    oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                    l_FuncionesGenerales.ValidarPeriodo(oeMovimientoDocumento.IdPeriodo, gAreasSGI.Contabilidad, Date.Parse("01/01/1901"), "")
                    If oeMovimientoDocumento.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Comprobante: " & _
                                 .ActiveRow.Cells("Serie").Value.ToString & .ActiveRow.Cells("Numero").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMovimientoDocumento.TipoOperacion = "E"
                            olMovimientoDocumento.EliminarComprobante(oeMovimientoDocumento)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada.")
                    End If
                Else
                    Throw New Exception("Seleccione una Fila!")
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
            If gridComprobanteVenta.Rows.Count = 0 Then Throw New Exception("No hay ningún Comprobante de Venta para exportar al Excel")
            Exportar_Excel(gridComprobanteVenta)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        oeMovimientoDocumento = New e_MovimientoDocumento
        With oeMovimientoDocumento
            .EstadoDocumento = "EMITIDA"
            .IndCompraVenta = 2 'indicador ventas
            ._Operador = 1
            .IdUsuarioCrea = gUsuarioSGI.Id
        End With
        oeDocAsoc = New e_MovimientoDocumento
        leDocAsoc = New List(Of e_MovimientoDocumento)

        cboTipoDocumento.SelectedIndex = -1
        FecEmision.Value = Date.Now
        FecVencimiento.Value = Date.Now
        txtNroSerie.Text = ""
        txtNroDocumento.Text = ""
        cboMoneda.SelectedIndex = -1
        decTC.Value = 0
        cboCtaCte.SelectedIndex = -1
        DecGravado.Value = 0
        DecExonerado.Value = 0
        DecInafecta.Value = 0
        DecIsc.Value = 0
        DecIgv.Value = 0
        DecOtrosTributos.Value = 0
        DecTotalVenta.Value = 0
        DecTotalDoc.Value = 0
        MostrarTabs(1, tcComprobanteVenta, 1) 'inicializamos
        MostrarTabs(0, tcComprobanteDetalle) 'inicializamos
        leDocAsoc.Clear()
        LimpiaGrid(GriComprobanteAsociado, UltraDataSource2)
        ComboTipoVenta()
        cboTipo.SelectedIndex = -1
        cboServicio.ReadOnly = True : cboServicio.SelectedIndex = -1
        cboTipoVenta.ReadOnly = True : cboTipoVenta.SelectedIndex = -1
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMovimientoDocumento = New e_MovimientoDocumento
            oeMovimientoDocumento.Activo = Activo
            oeMovimientoDocumento.IdPeriodo = cboMes.Value
            oeMovimientoDocumento.IndCompraVenta = 2 'Indica Venta
            oeMovimientoDocumento.TipoOperacion = "CON"
            LimpiaGrid(gridComprobanteVenta, UltraDataSource1)
            With gridComprobanteVenta
                .DataSource = olMovimientoDocumento.Listar(oeMovimientoDocumento)
                OcultarColumna(gridComprobanteVenta, True, "Retencion_Saldo", "Retencion_Letra", "Retencion", "IndDetalleGlosa", "MontoCanje", "IdUsuarioCrea", _
                               "IdTipoBien", "OrdenCompra", "FechaCreacion", "IndAnexo", "CodMotivo")
                .DisplayLayout.Bands(0).Columns("Monto_Anticipo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Monto_Anticipo").Format = "#,##0.00"
            End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        gridComprobanteVenta.Focus()
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
            oeMovimientoDocumentoAsoc.Ejercicio = Ejercicio
            oeMovimientoDocumentoAsoc.FechaEmision = oeMovimientoDocumento.FechaEmision
            oeMovimientoDocumentoAsoc.IndCompraVenta = 2 'Indica Venta
            oeMovimientoDocumentoAsoc.IdClienteProveedor = oeMovimientoDocumento.IdClienteProveedor
            oeMovimientoDocumentoAsoc._Operador = 1
            oeMovimientoDocumentoAsoc.TipoOperacion = "CON"
            LimpiaGrid(GriSeleccionaComprobante, UltraDataSource3)
            With GriSeleccionaComprobante
                .DataSource = olMovimientoDocumento.Listar(oeMovimientoDocumentoAsoc)
            End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        gridComprobanteVenta.Focus()
    End Sub

    Private Sub Mostrar()
        Try
            If gridComprobanteVenta.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeMovimientoDocumento.Id = gridComprobanteVenta.ActiveRow.Cells("Id").Value.ToString
                oeMovimientoDocumento = olMovimientoDocumento.ObtenerVenta(oeMovimientoDocumento)
                If oeMovimientoDocumento.Saldo < oeMovimientoDocumento.Total Then
                    mensajeEmergente.Problema("Existen cobros asociados, Desea Continuar?", True)
                    agrCabeceraAsiento.Enabled = False
                    Agrupacion3.Enabled = False
                Else
                    agrCabeceraAsiento.Enabled = True
                    Agrupacion3.Enabled = True
                End If
                With oeMovimientoDocumento
                    cboTipoDocumento.Value = .IdTipoDocumento
                    txtNroSerie.Text = .Serie
                    txtNroDocumento.Text = .Numero
                    FecEmision.Value = .FechaEmision
                    FecVencimiento.Value = .FechaVencimiento
                    cboMoneda.Value = .IdMoneda
                    cboCtaCte.Value = .IdClienteProveedor
                    cboTipoVenta.Value = .Venta.IdTipoVenta
                    decTC.Value = .TipoCambio
                    If cboMoneda.Text = "SOLES" Then
                        DecGravado.Value = .Venta.Gravado
                        DecExonerado.Value = .Venta.Exonerado
                        DecInafecta.Value = .Venta.Inafecto
                        DecIgv.Value = .Venta.IGV
                        DecIsc.Value = .Venta.ISC
                        DecOtrosTributos.Value = .Venta.OtrosTributos
                    Else
                        DecGravado.Value = .Venta.Gravado / .TipoCambio
                        DecExonerado.Value = .Venta.Exonerado / .TipoCambio
                        DecInafecta.Value = .Venta.Inafecto / .TipoCambio
                        DecIgv.Value = .Venta.IGV / .TipoCambio
                        DecIsc.Value = .Venta.ISC / .TipoCambio
                        DecOtrosTributos.Value = .Venta.OtrosTributos / .TipoCambio
                    End If
                  
                    DecTotalVenta.Value = .Venta.Gravado + .Venta.Exonerado + .Venta.Inafecto
                    DecTotalDoc.Value = .Venta.Gravado + .Venta.Exonerado + .Venta.Inafecto + .Venta.IGV + .Venta.ISC + .Venta.OtrosTributos
                    If cboTipoDocumento.Text = "NOTA DE CRÉDITO" Or cboTipoDocumento.Text = "NOTA DE DÉBITO" Then
                        Dim oeDocAsoc As New e_DocumentoAsociado
                        Dim olDocAsoc As New l_DocumentoAsociado
                        oeDocAsoc.IdMovimientoDocumento = .Id
                        leDocAsoc.AddRange(olDocAsoc.ListarDocAsoc(oeDocAsoc))
                        CargaComprobanteDetalles(leDocAsoc)
                    End If
                End With

            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Carga documentos, lista de objetos de la clase de e_movimientodocumentos 
    ''' </summary>
    ''' <param name="oeAsDetDet">Variable de ingreso es una lista de objetos de movimiento documento</param>
    ''' <remarks></remarks>
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

    Private Function GuardarComprobante() As Boolean
        Try
            If ValidaComprobante() Then
                Dim IndServ As Boolean = False
                IdCtaCtableAux = String.Empty
                SumaTotales() : CargaComprobantesAsociados()
                With oeMovimientoDocumento
                    .Mac_PC_Local = MacPCLocal()
                    .EstadoDocumento = "EMITIDA"
                    .Venta.Exonerado = IIf(.IdMoneda = "1CH02", DecExonerado.Value, DecExonerado.Value)
                    .Venta.Gravado = IIf(.IdMoneda = "1CH02", (DecGravado.Value * decTC.Value), DecGravado.Value)
                    .Venta.IGV = IIf(.IdMoneda = "1CH02", (DecIgv.Value * decTC.Value), DecIgv.Value)
                    .Venta.ISC = IIf(.IdMoneda = "1CH02", (DecIsc.Value * decTC.Value), DecIsc.Value)
                    .Venta.OtrosTributos = IIf(.IdMoneda = "1CH02", (DecOtrosTributos.Value * decTC.Value), DecOtrosTributos.Value)
                    .Venta.Inafecto = IIf(.IdMoneda = "1CH02", (DecInafecta.Value * decTC.Value), DecInafecta.Value)
                    .Venta.TipoOperacion = oeMovimientoDocumento.TipoOperacion
                End With
                oeMovimientoDocumento.Mac_PC_Local = MacPCLocal()
                oeMovimientoDocumento.EstadoDocumento = "EMITIDA"
                'Filtra DtReferencia
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                Dim _tipodocaux As String = String.Empty
                If cboTipo.SelectedIndex = 0 Then
                    _tipodocaux = IIf(cboTipoDocumento.Text = gTDNotaCredito, gTDNotaCredito, gTDOtro)
                    cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & cboMoneda.Value & "' AND TipoRef2 = 5 AND Ref2 = '" & _tipodocaux & _
                        "' AND TipoRef3 = 6 AND Ref3 = '" & gVSTransporte & "'"
                Else
                    cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & cboMoneda.Value & "' AND TipoRef2 = 5 AND Ref2 = '" & _tipodocaux & _
                        "' AND TipoRef3 = 6 AND Ref3 = '" & gVSOtros & "'"
                End If
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = Año1.Año
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                ' Verificar Empresa Relacionada
                Dim _oeEmpr As New e_Cliente
                _oeEmpr.Equivale = 1
                _oeEmpr.Id = oeMovimientoDocumento.IdClienteProveedor.Trim
                If leEmpresa.Contains(_oeEmpr) Then
                    _oeEmpr = leEmpresa.Item(leEmpresa.IndexOf(_oeEmpr))
                    If _oeEmpr.IndRelacionada = 1 Then
                        For Each _oeDet In oeAsientoModel.leDetalle
                            ' Cuentas por Cobrar Relacionadas
                            If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "12" Then
                                Dim strCuenta As String = Replace(_oeDet.Cuenta, "2", "3", 1, 1)
                                Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 4) & "3" & Microsoft.VisualBasic.Right(strCuenta, 1)
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
                End If
                ' Obtiene Servicio Cuenta Contable
                If AnioServ <> Año1.Año Then
                    AnioServ = Año1.Año
                    oeServCtaCtble = New e_ServicioCuentaContable
                    oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = AnioServ
                    leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)
                    If cboTipo.SelectedIndex > 0 Then
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
                ' Obtiene Cuenta Relacionada por Venta de Inmobiliarios
                If _oeEmpr.IndRelacionada = 1 Then
                    Dim strCta As String = Replace(gCC16531, "6", "7", 1, 1)
                    Dim strNewCta As String = Microsoft.VisualBasic.Left(strCta, 3) & "3" & Microsoft.VisualBasic.Right(strCta, 1)
                    oeCtaCtable = New e_CuentaContable
                    oeCtaCtable.Equivale = 0 : oeCtaCtable.Cuenta = strNewCta
                    If leCtaCtable.Contains(oeCtaCtable) Then
                        oeCtaCtable = leCtaCtable.Item(leCtaCtable.IndexOf(oeCtaCtable))
                    End If
                End If
                oeServCtaCtble = New e_ServicioCuentaContable
                oeServCtaCtble.IdServicio = IIf(cboTipo.SelectedIndex > 0, cboServicio.Text, gVSTransporte) : oeServCtaCtble.Equivale = 1
                If leServCtaCtble.Contains(oeServCtaCtble) Then
                    oeServCtaCtble = leServCtaCtble.Item(leServCtaCtble.IndexOf(oeServCtaCtble))
                Else
                    Throw New Exception("No Existen Cuenta Contable para el Servicio: " & gVSTransporte & " para el Año: " & AnioServ & _
                                        Environment.NewLine & "Solicite el Apoyo del Area Contable.")
                End If
                If cboTipo.SelectedIndex > 0 AndAlso cboServicio.Text = gVSTracto.Trim Then IdCtaCtableAux = oeCtaCtable.Id
                If cboTipo.SelectedIndex > 0 Then IndServ = True
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                oeMovimientoDocumento.IndConta = True
                'Valida CuentaCorriente
                oeCuentaCorriente = New e_CuentaCorriente
                oeCuentaCorriente.Tipo = 3 : oeCuentaCorriente.IdTrabajador = oeMovimientoDocumento.IdClienteProveedor
                oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
                If oeCuentaCorriente.Id <> "" Then
                    olMovimientoDocumento.GuardarVentaAsiento(oeMovimientoDocumento, oeAsientoModel, oeServCtaCtble, IndServ, IdCtaCtableAux)
                Else
                    With oeCuentaCorriente
                        .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = oeMovimientoDocumento.IdClienteProveedor
                        .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = Año1.Año : .Usuario = gUsuarioSGI.Id
                        .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA"
                    End With
                    olCuentaCorriente.Guardar(oeCuentaCorriente)
                    olMovimientoDocumento.GuardarVentaAsiento(oeMovimientoDocumento, oeAsientoModel, oeServCtaCtble, IndServ, IdCtaCtableAux)
                End If
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                MostrarTabs(0, tcComprobanteVenta, 2)
                Consultar(True)
                gridComprobanteVenta.Focus()
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
            ValidarCombo(cboCtaCte, "Cuenta Corriente")
            ValidarCombo(cboTipoVenta, "Tipo de Venta")
            l_FuncionesGenerales.ValidarNumero(DecTotalVenta.Value, "Monto Venta")
            If Not IsNumeric(txtNroSerie.Text) Then Throw New Exception("La Serie tiene que ser numérica")
            txtNroSerie.Text = FormatoDocumento(txtNroSerie.Text, 4)
            If Not IsNumeric(txtNroDocumento.Text) Then Throw New Exception("Debe ingresar un valor numérico")
            txtNroDocumento.Text = FormatoDocumento(txtNroDocumento.Text, 10)
            If oePeriodo.Ejercicio = Year(FecEmision.Value) AndAlso oePeriodo.Mes <> Month(FecEmision.Value) Then Throw New Exception("El mes de la fecha de emision tiene que ser: " & oePeriodo.Mes.ToString)
            If oePeriodo.Ejercicio <> Year(FecEmision.Value) Then Throw New Exception("El Año de la fecha de emision tiene que ser: " & oePeriodo.Ejercicio.ToString)
            If Date.Parse(FecEmision.Value).Date > Date.Parse(FecVencimiento.Value).Date Then Throw New Exception("La fecha de Emision no puede ser mayor a la Fecha de vencimiento")
            If decTC.Value <= 0 Then Throw New Exception("Ingrese el Tipo de Cambio")
            If (oeMovimientoDocumento.Venta.TipoDoc.Codigo.Trim = "07" Or _
                oeMovimientoDocumento.Venta.TipoDoc.Codigo.Trim = "06") AndAlso _
                Not GriComprobanteAsociado.Rows.Count > 0 Then Throw New Exception("Ingrese Documentos Asociado")

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LlenarCombos()
        ComboPerido()
        ComboMoneda()
        ComboTipoDocumentoOperacion()
        ComboCliente()
        CargarAsientoModel()
        cboTipo.Items.Clear()
        cboTipo.Items.Add("MATERIAL")
        cboTipo.Items.Add("SERVICIO")
        cboTipo.SelectedIndex = -1
    End Sub

    Private Sub ComboMoneda()
        If cboMoneda.Items.Count = 0 Then
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            gridComprobanteVenta.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridComprobanteVenta.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridComprobanteVenta, True)
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
        End If
    End Sub

    Private Sub ComboPerido()
        Try
            If _ComboPeriodo = True Then
                Dim lePeriodo As New List(Of e_Periodo)
                lePeriodo.AddRange(ObtenerPeriodoActivo(Año1.Año))
                '--------------------- para llenar combo en grilla   
                With gridComprobanteVenta.DisplayLayout
                    If .Bands(0).Columns.Exists("IdPeriodo") Then
                        .ValueLists.Clear()
                        .ValueLists.Add("IdPeriodo")
                    End If
                End With
                With gridComprobanteVenta.DisplayLayout.ValueLists("IdPeriodo").ValueListItems
                    .Clear()
                    For Each oeTD As e_Periodo In lePeriodo
                        .Add(oeTD.Id, oeTD.Codigo)
                    Next
                End With
                CrearComboGrid3("IdPeriodo", "Codigo", gridComprobanteVenta, True)
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
                        .Text = Date.Now.Month
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ComboTipoDocumentoOperacion()
        Try
            If cboTipoDocumento.Items.Count = 0 Then
                Dim oeTipoDoc As New e_TipoDocumento
                Dim leTipoDoc As New List(Of e_TipoDocumento)
                Dim olTipoDoc As New l_TipoDocumento
                oeTipoDoc.Activo = True
                oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
                leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
                '--------------------- para llenar combo en grilla    
                gridComprobanteVenta.DisplayLayout.ValueLists.Add("IdTipoDocumento")
                With gridComprobanteVenta.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                    .Clear()
                    For Each oeTD As e_TipoDocumento In leTipoDoc
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdTipoDocumento", "Nombre", gridComprobanteVenta, True)
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
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ComboCliente()
        Try
            If cboCtaCte.Items.Count = 0 Then
                Dim oeCliente As New e_Cliente
                Dim leCliente As New List(Of e_Cliente)
                Dim olCliente As New l_Cliente
                oeCliente.Activo = True
                leCliente.AddRange(olCliente.Listar(oeCliente))
                leEmpresa = New List(Of e_Cliente)
                leEmpresa.AddRange(leCliente)
                '--------------------- para llenar combo en grilla    
                gridComprobanteVenta.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With gridComprobanteVenta.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Cliente In leCliente
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", gridComprobanteVenta, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                GriComprobanteAsociado.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With GriComprobanteAsociado.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Cliente In leCliente
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", GriComprobanteAsociado, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                GriSeleccionaComprobante.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With GriSeleccionaComprobante.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Cliente In leCliente
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", GriSeleccionaComprobante, True)
                '------------------------------------------
                With cboCtaCte
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leCliente
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub ComboTipoVenta()
        Try
            If Ejercicio <> Año1.Año Then
                Dim oeTablaContableDet As New e_TablaContableDet
                Dim olTablaContableDet As New l_TablaContableDet
                oeTablaContableDet.TipoOperacion = "N"
                oeTablaContableDet.Nombre = "TIPO DE VENTA" 'Tipo de medio de pago
                oeTablaContableDet.Activo = True
                oeTablaContableDet.Valor1 = Año1.Año
                With cboTipoVenta
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = olTablaContableDet.Listar(oeTablaContableDet)
                End With
                Ejercicio = Año1.Año
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarDocumentoAsociado()
        Try
            ValidarGrilla(GriSeleccionaComprobante, "Comprobante Venta")
            If GriSeleccionaComprobante.ActiveRow Is Nothing Or GriSeleccionaComprobante.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
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
                        Throw New Exception("Este documento ya se encuentra asociado con otro comprobante de ventas")
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
            mensajeEmergente.Problema(ex.Message, True)
        End Try


    End Sub

    Private Sub QuitarDocumentoAsoc()
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
    End Sub

    Private Sub SumaTotales()
        DecTotalVenta.Value = DecGravado.Value + DecExonerado.Value + DecInafecta.Value
        oeMovimientoDocumento.SubTotal = DecTotalVenta.Value
        DecTotalDoc.Value = DecTotalVenta.Value + DecIgv.Value + DecIsc.Value + DecOtrosTributos.Value
        oeMovimientoDocumento.IGV = DecIgv.Value + DecIsc.Value + DecOtrosTributos.Value
        oeMovimientoDocumento.Venta.TotalVenta = DecTotalVenta.Value
        oeMovimientoDocumento.Total = DecTotalDoc.Value
        oeMovimientoDocumento.Saldo = DecTotalDoc.Value
    End Sub

    Private Sub CargaComprobantesAsociados()
        Dim oeDA As New e_DocumentoAsociado
        If leDocAsoc.Count > 0 Then
            For Each obj As e_MovimientoDocumento In leDocAsoc
                oeDA = New e_DocumentoAsociado
                If oeMovimientoDocumento.TipoOperacion = "I" Then
                    oeDA.Id = ""
                    oeDA.IdMovimientoDocumento = ""
                    oeDA.IdMovimientoDocumentoAsoc = obj.Id
                    oeDA.TipoOperacion = "I"
                    oeDA.Activo = True
                Else
                    oeDA.Id = obj.IdDocAsoc
                    oeDA.IdMovimientoDocumento = oeMovimientoDocumento.Id
                    oeDA.IdMovimientoDocumentoAsoc = obj.Id
                    oeDA.TipoOperacion = obj.TipoOperacion
                End If
                oeMovimientoDocumento.DocAsoc.Add(oeDA)
            Next
        Else
            oeMovimientoDocumento.DocAsoc = Nothing
        End If
    End Sub

    Public Sub Extornar()
        Try
            ValidarGrilla(gridComprobanteVenta, "Comprobante Venta")
            Dim oeMovDoc = New e_MovimientoDocumento
            oeMovDoc.Id = gridComprobanteVenta.ActiveRow.Cells("Id").Value
            Dim olMooDoc = New l_MovimientoDocumento
            oeMovDoc = olMooDoc.Obtener(oeMovDoc)
            If oeMovDoc.EstadoSunat <> "PENDIENTE" Then Throw New Exception("No se puede extornar Comprobante que ha sido enviado a Sunat.")
            Dim lst_docasoc As New List(Of e_DocumentoAsociado)
            If gridComprobanteVenta.ActiveRow.Cells("IndAnticipo").Value Then
                Dim oe_docas As New e_DocumentoAsociado
                Dim oe_docas_afant As New e_DocumentoAsociado
                Dim ol_docas As New l_DocumentoAsociado
                oe_docas.TipoOperacion = ""
                oe_docas.IdMovimientoDocumentoAsoc = gridComprobanteVenta.ActiveRow.Cells("Id").Value
                oe_docas.Activo = 1
                oe_docas = ol_docas.Listar(oe_docas)(0)
                With oe_docas_afant
                    .TipoOperacion = ""
                    .Activo = 1
                    .IdMovimientoDocumentoAsoc = oe_docas.IdMovimientoDocumento
                End With
                lst_docasoc = ol_docas.Listar(oe_docas_afant)
                If lst_docasoc.Count > 0 Then Throw New Exception("No se puede extornar Factura de Anticipo porque tiene documentos asociados.")
            End If

            If Not gridComprobanteVenta.ActiveRow Is Nothing AndAlso gridComprobanteVenta.ActiveRow.Cells("Id").Value.ToString <> "" Then
                'oeMovimientoDocumento = New e_MovimientoDocumento
                'oeMovimientoDocumento.CargarCompleto = False
                'oeMovimientoDocumento.Id = gridComprobanteVenta.ActiveRow.Cells("Id").Value
                'oeMovimientoDocumento = olMovimientoDocumento.ObtenerVenta(oeMovimientoDocumento)
                'If oeMovimientoDocumento.Venta.SaldoDetraccion = 0 Then
                '    Throw New Exception("No se puede Extornar el Documento por que ya se ha pagado la Detraccion!!")
                'End If
                'inicialializo mi objeto
                'Comento Willy para obtener los datos de BD
                ''oeMovimientoDocumento = New e_MovimientoDocumento
                '---Obtengo O CAPTURO objeto de la grilla 
                ''oeMovimientoDocumento = gridComprobanteVenta.ActiveRow.ListObject
                oeMovimientoDocumento.Id = gridComprobanteVenta.ActiveRow.Cells("Id").Value
                oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                oeMovimientoDocumento.IndOrigenContable = 1
                olMovimientoDocumento.ExtornarDocEmitidoEnviado(oeMovimientoDocumento, gUsuarioSGI.Id)
                MostrarTabs(0, tcComprobanteVenta, 2)
                Consultar(True)
                gridComprobanteVenta.Focus()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub CargarAsientoModel()
        Try
            'Cargar Servicios Venta
            AnioServ = Date.Now.Year
            oeServCtaCtble = New e_ServicioCuentaContable
            oeServCtaCtble.TipoOperacion = "V" : oeServCtaCtble.Activo = True : oeServCtaCtble.Ejercicio = AnioServ
            leServCtaCtble = olServCtaCtble.Listar(oeServCtaCtble)
            LlenarCombo(cboServicio, "IdServicio", leServCtaCtble, -1)
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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        Try
            ComboPerido()
            LimpiaGrid(gridComprobanteVenta, UltraDataSource1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub oeMovimientoDocumento_DatoCambiado() Handles oeMovimientoDocumento.DatoCambiado
        oeMovimientoDocumento.Modificado = True
    End Sub

    Private Sub frm_ComprobanteVentas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Else
            ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
        End If
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
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
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ComprobanteDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcComprobanteVenta)
            _ComboPeriodo = True
            LlenarCombos()
            oeIGV = olImp.IGV(Date.Now)
            _IGV = oeIGV.Porcentaje
            ListaUsuarios(gridComprobanteVenta, "IdUsuarioCrea")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridComprobanteVenta_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridComprobanteVenta.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub gridComprobanteVenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridComprobanteVenta.DoubleClick
        If gridComprobanteVenta.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub gridComprobanteVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridComprobanteVenta.KeyDown
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
            If Not oeMovimientoDocumento.Venta.TipoDoc.Codigo.Trim = "07" Then Throw New Exception("Solo para Notas de credito")
            If cboCtaCte.SelectedIndex = -1 Then Throw New Exception("Debe seleccionar algún Cliente")
            If GriComprobanteAsociado.Rows.Count = 1 Then Throw New Exception("Solo se puede asociar un solo comprobante")
            ListarDocumentoAsociado()
            MostrarTabs(1, tcComprobanteDetalle, 1) 'inicializamos
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub EliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarDetalle.Click
        QuitarDocumentoAsoc()
    End Sub

    Private Sub mnuDetalleAsiento_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuDetalleAsiento.ToolClick
        Select Case e.Tool.Key
            Case "Agregar"
                AgregarDocumentoAsociado()
                MostrarTabs(0, tcComprobanteDetalle, 2)
            Case "Cancelar"
                MostrarTabs(0, tcComprobanteDetalle, 2)
        End Select
    End Sub

    Private Sub GriSeleccionaComprobante_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GriSeleccionaComprobante.DoubleClick
        AgregarDocumentoAsociado()
        MostrarTabs(0, tcComprobanteDetalle, 2)
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        oeMovimientoDocumento.IdTipoDocumento = cboTipoDocumento.Value
        If cboTipoDocumento.SelectedIndex <> -1 Then
            Dim i As Integer = cboTipoDocumento.SelectedIndex
            oeMovimientoDocumento.Venta.TipoDoc = cboTipoDocumento.Items(i).ListObject
            If oeMovimientoDocumento.Venta.TipoDoc.Codigo.Trim = "07" Then
                oeMovimientoDocumento._Operador = -1 'negativo para clientes o ventas
            Else
                oeMovimientoDocumento._Operador = 1
            End If
        End If
    End Sub

    Private Sub txtNroSerie_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroSerie.Validated
        txtNroSerie.Text = FormatoDocumento(txtNroSerie.Text, 4)
    End Sub

    Private Sub txtNroSerie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroSerie.ValueChanged
        oeMovimientoDocumento.Serie = txtNroSerie.Text
    End Sub

    Private Sub txtNroDocumento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDocumento.Validated
        txtNroDocumento.Text = FormatoDocumento(txtNroDocumento.Text, 10)
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

    Private Sub cboCtaCte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCtaCte.ValueChanged
        oeMovimientoDocumento.IdClienteProveedor = cboCtaCte.Value
        If cboCtaCte.SelectedIndex <> -1 Then
            Dim i As Integer = cboCtaCte.SelectedIndex
            oeMovimientoDocumento.Venta.Cliente = cboCtaCte.Items(i).ListObject
            MostrarTabs(0, tcComprobanteDetalle) 'inicializamos
            leDocAsoc.Clear()
            LimpiaGrid(GriComprobanteAsociado, UltraDataSource2)
        End If
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeMovimientoDocumento.IdMoneda = cboMoneda.Value
        If cboMoneda.SelectedIndex <> -1 Then
            Dim i As Integer = cboMoneda.SelectedIndex
            oeMovimientoDocumento.Venta.Moneda = cboMoneda.Items(i).ListObject
        End If

    End Sub

    Private Sub decTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTC.ValueChanged
        oeMovimientoDocumento.TipoCambio = decTC.Value
    End Sub

    Private Sub cboTipoVenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVenta.ValueChanged
        oeMovimientoDocumento.Venta.IdTipoVenta = cboTipoVenta.Value
        If cboTipoVenta.SelectedIndex <> -1 Then
            Dim i As Integer = cboTipoVenta.SelectedIndex
            oeMovimientoDocumento.Venta.TipoVenta = cboTipoVenta.Items(i).ListObject
        End If
    End Sub

    Private Sub DecGravado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles DecGravado.Validated
        DecIgv.Value = Math.Round(DecGravado.Value * _IGV, 2)
        SumaTotales()
    End Sub

    Private Sub DecGravado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecGravado.ValueChanged
        oeMovimientoDocumento.Venta.Gravado = DecGravado.Value
    End Sub

    Private Sub DecExonerado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles DecExonerado.Validated, DecInafecta.Validated, DecIgv.Validated, _
    DecOtrosTributos.Validated, DecIsc.Validated
        SumaTotales()
    End Sub

    Private Sub DecExonerado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecExonerado.ValueChanged
        oeMovimientoDocumento.Venta.Exonerado = DecExonerado.Value
    End Sub

    Private Sub DecInafecta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecInafecta.ValueChanged
        oeMovimientoDocumento.Venta.Inafecto = DecInafecta.Value
    End Sub

    Private Sub DecIgv_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecIgv.ValueChanged
        oeMovimientoDocumento.Venta.IGV = DecIgv.Value
    End Sub

    Private Sub DecOtrosTributos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecOtrosTributos.ValueChanged
        oeMovimientoDocumento.Venta.OtrosTributos = DecOtrosTributos.Value
    End Sub

    Private Sub DecIsc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecIsc.ValueChanged
        oeMovimientoDocumento.Venta.ISC = DecIsc.Value
    End Sub

    Private Sub cboMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.ValueChanged
        If cboMes.SelectedIndex <> -1 Then
            Dim i As Integer = cboMes.SelectedIndex
            oePeriodo = cboMes.Items(i).ListObject
            EtiPeriodo.Text = "Periodo: " & oePeriodo.Codigo
        End If
    End Sub

    Private Sub btn_Extornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Extornar.Click
        If MessageBox.Show("Esta seguro de Extornar esta operacion?", "Mensaje del sistema", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Extornar()
        End If
    End Sub

    Private Sub cboTipo_ValueChanged(sender As Object, e As EventArgs) Handles cboTipo.ValueChanged
        If cboTipo.SelectedIndex > -1 Then
            If cboTipo.SelectedIndex = 0 Then
                cboServicio.Text = gVSTransporte
            Else
                cboServicio.ReadOnly = False : cboServicio.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub cboServicio_ValueChanged(sender As Object, e As EventArgs) Handles cboServicio.ValueChanged
        If cboServicio.SelectedIndex > -1 Then
            oeServCtaCtble = New e_ServicioCuentaContable
            oeServCtaCtble = cboServicio.Items(cboServicio.SelectedIndex).ListObject
            cboTipoVenta.Value = oeServCtaCtble.CuentaHaber
        Else
            cboTipoVenta.SelectedIndex = -1
        End If
    End Sub

#End Region

    Private Sub Etiqueta2_Click(sender As Object, e As EventArgs) Handles Etiqueta2.Click

    End Sub

End Class
